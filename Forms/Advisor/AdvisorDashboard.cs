using CRUD_Operations;
using Guna.UI2.WinForms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1.Forms.Advisor
{
	public partial class AdvisorDashboard : Form
	{
		public string id = string.Empty;
		public AdvisorDashboard(string advId)
		{
			InitializeComponent();
			setPanelNames();
			id = advId;
			UIController.initializeComboBox("Select Value from Lookup where Category = 'ADVISOR_ROLE';", RoleCB);
			UIController.initializeComboBox("Select Title from Project", ProjectCB);
			UIController.loadGrid("select * from Evaluation", EvaluationMetricsDGV);
			UIController.initializeComboBox("select Id from [Group]", GroupEvaluationCB, true);
			UIController.initializeComboBox("select Name from Evaluation", MetricCB);
			UIController.loadGrid("select * from GroupEvaluation", GroupEvaluationDGV);
		}

		public void setPanelNames()
		{
			tabPage1.Text = "Add Projects";
			tabPage2.Text = "Join Projects";
			tabPage3.Text = "Evaluation Metrics";
			tabPage4.Text = "Evaluate Group";
			tabPage5.Text = "Reports";
		}

		private void AdvisorDashboard_Load(object sender, EventArgs e)
		{

		}

		// add project button
		private void button1_Click(object sender, EventArgs e)
		{
			if (ProjectTitleTB.Text != null && ProjectDescriptionTB.Text != null && !ProjectController.alreadyExists(ProjectTitleTB.Text))
			{
				var connection = Configuration.getInstance().getConnection();
				SqlCommand cmd = new SqlCommand("INSERT INTO Project (Description, Title) VALUES (@Description, @Title)", connection);
				cmd.Parameters.AddWithValue("@Title", ProjectTitleTB.Text);
				cmd.Parameters.AddWithValue("@Description", ProjectDescriptionTB.Text);
				cmd.ExecuteNonQuery();

				MessageBox.Show("Added!");
				ProjectCB.Items.Clear();
				UIController.initializeComboBox("Select Title from Project", ProjectCB);
			}
			else
			{
				MessageBox.Show("Fill out completely");
			}
		}

		private void JoinProjectBtn_Click(object sender, EventArgs e)
		{
			int projectId = ProjectController.getProjectIdFromTitle(ProjectCB.Text);
			int roleId = getRoleIdFromTable(RoleCB.Text);
			if (projectId > 0 && roleId > 0 && canJoinProject(projectId, roleId))
			{
				var connection = Configuration.getInstance().getConnection();
				SqlCommand cmd = new SqlCommand("INSERT INTO ProjectAdvisor (AdvisorId, ProjectId, AdvisorRole, AssignmentDate) VALUES (@AdvisorId, @ProjectId, @AdvisorRole, @AssignmentDate)", connection);
				cmd.Parameters.AddWithValue("@AdvisorId", id);
				cmd.Parameters.AddWithValue("@ProjectId", projectId);
				cmd.Parameters.AddWithValue("@AdvisorRole", roleId);
				cmd.Parameters.AddWithValue("@AssignmentDate", DateTime.Now);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Added!");
			}
			else
			{
				MessageBox.Show("Select all fields correctly!");
			}
		}

		private bool canJoinProject(int projectId, int roleId)
		{			
			var con = Configuration.getInstance().getConnection();

			// check if advisor is already in project
			SqlCommand sqlCommand = new SqlCommand("select * from ProjectAdvisor where ProjectId = @projectId and AdvisorId = @advisorId", con);
			sqlCommand.Parameters.AddWithValue("@ProjectId", projectId);
			sqlCommand.Parameters.AddWithValue("@AdvisorId", id);
			var x = sqlCommand.ExecuteScalar();
			sqlCommand.ExecuteNonQuery();
			if (x != null) 
			{
				MessageBox.Show("Cannot join same project!");
				return false;
			}

			// check if advisor role already filled in project
			SqlCommand Command = new SqlCommand("select * from ProjectAdvisor where ProjectId = @projectId and AdvisorRole = @roleId", con);
			Command.Parameters.AddWithValue("@ProjectId", projectId);
			Command.Parameters.AddWithValue("@roleId", roleId);
			var y = Command.ExecuteScalar();
			Command.ExecuteNonQuery();
			if (y != null)
			{
				MessageBox.Show("Spot already filled!");
				return false;
			}

			return true;
		}

		public int getRoleIdFromTable(string role)
		{
			string id = DbController.getFromTable("Id", "Lookup", "where Value = '" + role + "'");
			return id == null ? -1 : int.Parse(id);
		}

		private void EvaluationAddBtn_Click(object sender, EventArgs e)
		{
			if (EvaluationNameTB.Text != null && EvaluationTotalMarksTB.Text != null && EvaluationTotalWeightageTB.Text != null && int.TryParse(EvaluationTotalMarksTB.Text, out int x) && int.TryParse(EvaluationTotalWeightageTB.Text, out int y) && int.Parse(EvaluationTotalMarksTB.Text) > 0 && int.Parse(EvaluationTotalWeightageTB.Text) > 0 && int.Parse(EvaluationTotalMarksTB.Text) < 100 && int.Parse(EvaluationTotalWeightageTB.Text) < 100)
			{
				if (EvaluationsController.getEvaluationMetric(EvaluationNameTB.Text, "Id") == null)
				{
					var connection = Configuration.getInstance().getConnection();
					SqlCommand cmd = new SqlCommand("INSERT INTO Evaluation (Name, TotalMarks, TotalWeightage) VALUES (@Name, @TotalMarks, @TotalWeightage)", connection);
					cmd.Parameters.AddWithValue("@Name", EvaluationNameTB.Text);
					cmd.Parameters.AddWithValue("@TotalMarks", EvaluationTotalMarksTB.Text);
					cmd.Parameters.AddWithValue("@TotalWeightage", EvaluationTotalWeightageTB.Text);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Added!");
					UIController.loadGrid("select * from Evaluation", EvaluationMetricsDGV);
					UIController.initializeComboBox("select Name from Evaluation", MetricCB);
				}
				else
				{
					MessageBox.Show("Duplicate Metric!");
				}
			}
			else
			{
				MessageBox.Show("Validations Error!");
			}
		}

		// add group evaluation button
		private void button2_Click(object sender, EventArgs e)
		{
			string group = GroupEvaluationCB.SelectedIndex > -1 ? GroupEvaluationCB.SelectedItem.ToString() : null;
			string metric = MetricCB.SelectedIndex > -1 ? MetricCB.SelectedItem.ToString() : null;
			if (group != null && metric != null)
			{
				string evaluationId = EvaluationsController.getEvaluationMetric(metric, "Id");
				if (alreadyEvaluated(group, evaluationId))
				{
					MessageBox.Show("Already Evaluated!");
				}
				else
				{
					string marks = EvaluationsController.getEvaluationMetric(metric, "TotalMarks");
					int totalMarks = 0;
					if (int.TryParse(marks, out int y))
					{
						totalMarks = y;
						if (ScoreTB.Text != null && int.TryParse(ScoreTB.Text, out int x) && int.Parse(ScoreTB.Text) <= totalMarks)
						{
							var connection = Configuration.getInstance().getConnection();
							SqlCommand cmd = new SqlCommand("INSERT INTO GroupEvaluation (GroupId, EvaluationId, ObtainedMarks, EvaluationDate) VALUES (@groupId, @EvaluationId, @ObtainedMarks, @EvaluationDate)", connection);
							cmd.Parameters.AddWithValue("@GroupId", group);
							cmd.Parameters.AddWithValue("@EvaluationId", evaluationId);
							cmd.Parameters.AddWithValue("@ObtainedMarks", ScoreTB.Text);
							cmd.Parameters.AddWithValue("@EvaluationDate", DateTime.Now);
							cmd.ExecuteNonQuery();
							UIController.loadGrid("select * from GroupEvaluation", GroupEvaluationDGV);
							MessageBox.Show("Added!");
						}
						else
						{
							MessageBox.Show("Enter marks properly!");
						}
					}
					else
					{
						MessageBox.Show("Something went wrong!");
					}
				}
			}
			else
			{
				MessageBox.Show("Select values properly");
			}
		}


		private bool alreadyEvaluated(string groupId, string evalId)
		{
			var con = Configuration.getInstance().getConnection();
			SqlCommand Command = new SqlCommand("select * from GroupEvaluation where GroupId = @groupId and EvaluationId = @evalId", con);
			Command.Parameters.AddWithValue("@groupId", groupId);
			Command.Parameters.AddWithValue("@evalId", evalId);
			var y = Command.ExecuteScalar();
			Command.ExecuteNonQuery();
			return y != null;
		}

		private void ReportsMarksBtn_Click(object sender, EventArgs e)
		{
			UIController.reportsGrid(ReportDGV, "select GroupEvaluation.GroupId, Person.FirstName + ' ' + Person.LastName as StudentName, Student.RegistrationNo, sum(ObtainedMarks * Evaluation.TotalWeightage / Evaluation.TotalMarks ) as Result, sum(Evaluation.TotalWeightage) as TotalMarks from GroupEvaluation join Evaluation on Evaluation.Id = GroupEvaluation.EvaluationId join GroupStudent on GroupStudent.GroupId = GroupEvaluation.GroupId join Student on GroupStudent.StudentId = Student.Id join Person on Person.Id = Student.Id group by GroupEvaluation.GroupId, Student.RegistrationNo, Person.FirstName, Person.LastName");
		}

		private void ReportAdvisorBtn_Click(object sender, EventArgs e)
		{
			UIController.reportsGrid(ReportDGV, "select Person.FirstName as FirstName, Person.LastName as LastName, Project.Title as ProjectTitle, GroupProject.GroupId as StudentGroupId, Lookup.Value as Role from Person join ProjectAdvisor on Person.Id = ProjectAdvisor.AdvisorId join Project on Project.Id = ProjectAdvisor.ProjectId join GroupProject on GroupProject.ProjectId = Project.Id join Lookup on Lookup.Id = ProjectAdvisor.AdvisorRole order by FirstName;");
		}

		private void ReportProjectBtn_Click(object sender, EventArgs e)
		{
			UIController.reportsGrid(ReportDGV, "SELECT p.Title AS ProjectTitle, AVG(ge.ObtainedMarks) AS AverageMarks, count(distinct ge.GroupId) as NumberOfGroups FROM Project p JOIN GroupProject gp ON p.Id = gp.ProjectId JOIN GroupEvaluation ge ON gp.GroupId = ge.GroupId GROUP BY p.Id, p.Title, ge.GroupId;");
		}

		private void ReportStudentsBtn_Click(object sender, EventArgs e)
		{
			UIController.reportsGrid(ReportDGV, "select Student.Id, FirstName + ' ' + LastName as Name, RegistrationNo from Student join Person on Person.Id = Student.Id where Student.Id not in (select StudentId from GroupStudent)");
		}

		private void ReportFacultyBtn_Click(object sender, EventArgs e)
		{
			UIController.reportsGrid(ReportDGV, "select Advisor.Id, FirstName + ' ' + LastName as FullName, Advisor.Designation, Advisor.Salary, count(ProjectId) as NumberOfProjects from Advisor join ProjectAdvisor on Advisor.Id = ProjectAdvisor.AdvisorId join Person on Person.Id = Advisor.Id group by AdvisorId, Advisor.Id, FirstName, LastName, Designation, Salary");
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			if (ReportDGV.Rows.Count > 0)
			{
				SaveFileDialog save = new SaveFileDialog();
				save.Filter = "PDF (.pdf)|.pdf";
				save.FileName = "Result.pdf";
				bool ErrorMessage = false;
				if (save.ShowDialog() == DialogResult.OK)
				{
					if (File.Exists(save.FileName))
					{
						try
						{
							File.Delete(save.FileName);
						}
						catch (Exception ex)
						{
							ErrorMessage = true;
							MessageBox.Show("Error Writing file to destination\n" + ex.Message);
						}
					}
					if (!ErrorMessage)
					{
						try
						{
							PdfPTable pTable = new PdfPTable(ReportDGV.Columns.Count);
							pTable.DefaultCell.Padding = 2;
							pTable.WidthPercentage = 100;
							pTable.HorizontalAlignment = Element.ALIGN_LEFT;
							foreach (DataGridViewColumn col in ReportDGV.Columns)
							{
								PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
								pTable.AddCell(pCell);
							}
							foreach (DataGridViewRow viewRow in ReportDGV.Rows)
							{
								if (viewRow.Cells != null)
								{
									foreach (DataGridViewCell dcell in viewRow.Cells)
									{
										if (dcell.Value != null) // Add null check for the cell value
										{
											pTable.AddCell(dcell.Value.ToString());
										}
										else
										{
											pTable.AddCell(""); // Add an empty cell if the value is null
										}
									}
								}
							}
							using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
							{
								Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
								PdfWriter.GetInstance(document, fileStream);
								document.Open();
								document.Add(pTable);
								document.Close();
								fileStream.Close();
							}
							MessageBox.Show("Data Export Successfully", "info");
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error while exporting Data" + ex.Message);
						}
					}
				}
			}
			else
			{
				MessageBox.Show("No Record Found", "Info");
			}
		}
	}
}
