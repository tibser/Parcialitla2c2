Console.WriteLine("Hello, World!");

Console.WriteLine("Welcome to the Student Attendance Management System!");

bool running = true;
int operationInput;
int subMenuInput;

List<int> studentIds = new List<int>();
List<string> firstNames = new List<string>();
List<string> lastNames = new List<string>();
List<int> ages = new List<int>();

List<int> subjectIds = new List<int>();
List<string> subjectNames = new List<string>();
List<string> teacherNames = new List<string>();

List<int> attendanceIds = new List<int>();
List<int> attendanceStudentIds = new List<int>();
List<int> attendanceSubjectIds = new List<int>();
List<string> attendanceDates = new List<string>();
List<bool> attendanceStatus = new List<bool>();

try
{
	while (running)
	{
		Console.WriteLine();
		Console.WriteLine("+++++++++ MAIN MENU ++++++++");
		Console.WriteLine("1. Add");
		Console.WriteLine("2. Search");
		Console.WriteLine("3. Edit");
		Console.WriteLine("4. Delete");
		Console.WriteLine("5. List");
		Console.WriteLine("6. Exit");

		int.TryParse(Console.ReadLine(), out operationInput);

		switch (operationInput)
		{
			case 1:
				{
					Console.WriteLine();
					Console.WriteLine("What do you want to add?");
					Console.WriteLine("1. Student");
					Console.WriteLine("2. Subject");
					Console.WriteLine("3. Attendance");
					Console.WriteLine("4. Back");

					int.TryParse(Console.ReadLine(), out subMenuInput);

					switch (subMenuInput)
					{
						case 1:
							{
								Console.WriteLine("Add Student");
								break;
							}

						case 2:
							{
								Console.WriteLine("Add Subject");
								break;
							}

						case 3:
							{
								Console.WriteLine("Add Attendance");
								break;
							}

						case 4:
							{
								Console.WriteLine("Returning to Main Menu...");
								break;
							}

						default:
							{
								Console.WriteLine("Invalid option.");
								break;
							}
					}

					break;
				}

			case 2:
				{
					Console.WriteLine();
					Console.WriteLine("What do you want to search?");
					Console.WriteLine("1. Student");
					Console.WriteLine("2. Subject");
					Console.WriteLine("3. Attendance");
					Console.WriteLine("4. Back");

					int.TryParse(Console.ReadLine(), out subMenuInput);

					switch (subMenuInput)
					{
						case 1:
							{
								Console.WriteLine("Search Student");
								Console.WriteLine("1. By ID");
								Console.WriteLine("2. By First Name");
								Console.WriteLine("3. By Last Name");
								break;
							}

						case 2:
							{
								Console.WriteLine("Search Subject");
								Console.WriteLine("1. By ID");
								Console.WriteLine("2. By Subject Name");
								break;
							}

						case 3:
							{
								Console.WriteLine("Search Attendance");
								Console.WriteLine("1. By Student ID");
								Console.WriteLine("2. By Subject ID");
								Console.WriteLine("3. By Date");
								break;
							}

						case 4:
							{
								Console.WriteLine("Returning to Main Menu...");
								break;
							}

						default:
							{
								Console.WriteLine("Invalid option.");
								break;
							}
					}

					break;
				}

			case 3:
				{
					Console.WriteLine();
					Console.WriteLine("What do you want to edit?");
					Console.WriteLine("1. Student");
					Console.WriteLine("2. Subject");
					Console.WriteLine("3. Attendance");
					Console.WriteLine("4. Back");

					int.TryParse(Console.ReadLine(), out subMenuInput);

					switch (subMenuInput)
					{
						case 1:
							{
								Console.WriteLine("Edit Student");
								break;
							}

						case 2:
							{
								Console.WriteLine("Edit Subject");
								break;
							}

						case 3:
							{
								Console.WriteLine("Edit Attendance");
								break;
							}

						case 4:
							{
								Console.WriteLine("Returning to Main Menu...");
								break;
							}

						default:
							{
								Console.WriteLine("Invalid option.");
								break;
							}
					}

					break;
				}

			case 4:
				{
					Console.WriteLine();
					Console.WriteLine("What do you want to delete?");
					Console.WriteLine("1. Student");
					Console.WriteLine("2. Subject");
					Console.WriteLine("3. Attendance");
					Console.WriteLine("4. Back");

					int.TryParse(Console.ReadLine(), out subMenuInput);

					switch (subMenuInput)
					{
						case 1:
							{
								Console.WriteLine("Delete Student");
								break;
							}

						case 2:
							{
								Console.WriteLine("Delete Subject");
								break;
							}

						case 3:
							{
								Console.WriteLine("Delete Attendance");
								break;
							}

						case 4:
							{
								Console.WriteLine("Returning to Main Menu...");
								break;
							}

						default:
							{
								Console.WriteLine("Invalid option.");
								break;
							}
					}

					break;
				}

			case 5:
				{
					Console.WriteLine();
					Console.WriteLine("What do you want to list?");
					Console.WriteLine("1. Students");
					Console.WriteLine("2. Subjects");
					Console.WriteLine("3. Attendance");
					Console.WriteLine("4. Back");

					int.TryParse(Console.ReadLine(), out subMenuInput);

					switch (subMenuInput)
					{
						case 1:
							{
								Console.WriteLine("List Students");
								break;
							}

						case 2:
							{
								Console.WriteLine("List Subjects");
								break;
							}

						case 3:
							{
								Console.WriteLine("List Attendance");
								break;
							}

						case 4:
							{
								Console.WriteLine("Returning to Main Menu...");
								break;
							}

						default:
							{
								Console.WriteLine("Invalid option.");
								break;
							}
					}

					break;
				}

			case 6:
				{
					Console.WriteLine("Goodbye!");
					running = false;
					break;
				}

			default:
				{
					Console.WriteLine("Invalid option.");
					break;
				}
		}
	}
}
catch (Exception ex)
{
	Console.WriteLine($"An error occurred: {ex.Message}");
}

