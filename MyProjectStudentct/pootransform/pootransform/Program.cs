Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to the Student Attendance Management System!");

bool running = true;
int operationInput;
int subMenuInput;

List<Student> students = new List<Student>();
List<Subject> subjects = new List<Subject>();
List<Attendance> attendances = new List<Attendance>();

while (running)
{
	Console.WriteLine("\n+++++++++ MAIN MENU +++++++++");
	Console.WriteLine("1. Add");
	Console.WriteLine("2. Search");
	Console.WriteLine("3. Edit");
	Console.WriteLine("4. Delete");
	Console.WriteLine("5. List");
	Console.WriteLine("6. Exit");

	operationInput = int.Parse(Console.ReadLine());

	switch (operationInput)
	{
		case 1:
			{
				Console.WriteLine("\nWhat do you want to add?");
				Console.WriteLine("1. Student");
				Console.WriteLine("2. Subject");
				Console.WriteLine("3. Attendance");
				Console.WriteLine("4. Back");

				subMenuInput = int.Parse(Console.ReadLine());

				switch (subMenuInput)
				{
					case 1:
						{
							Console.WriteLine("\n--- Add Student ---");

							Student student = new Student();

							Console.Write("Student ID: ");
							student.Id = int.Parse(Console.ReadLine());

							Console.Write("First Name: ");
							student.FirstName = Console.ReadLine();

							Console.Write("Last Name: ");
							student.LastName = Console.ReadLine();

							Console.Write("Age: ");
							student.Age = int.Parse(Console.ReadLine());

							students.Add(student);

							Console.WriteLine("Student added successfully!");

							break;
						}


					case 2:
						{
							Console.WriteLine("\n--- Add Subject ---");

							Subject subject = new Subject();

							Console.Write("Subject ID: ");
							subject.Id = int.Parse(Console.ReadLine());

							Console.Write("Subject Name: ");
							subject.Name = Console.ReadLine();

							Console.Write("Teacher Name: ");
							subject.Teacher = Console.ReadLine();

							subjects.Add(subject);

							Console.WriteLine("Subject added successfully!");

							break;
						}



					case 3:
						{
							Console.WriteLine("\n--- Add Attendance ---");

							Attendance attendance = new Attendance();

							Console.Write("Attendance ID: ");
							attendance.Id = int.Parse(Console.ReadLine());

							Console.Write("Student ID: ");
							attendance.StudentId = int.Parse(Console.ReadLine());

							Console.Write("Subject ID: ");
							attendance.SubjectId = int.Parse(Console.ReadLine());

							Console.Write("Date: ");
							attendance.Date = Console.ReadLine();

							Console.Write("Attendance (true = Present, false = Absent): ");
							attendance.Status = bool.Parse(Console.ReadLine());

							attendances.Add(attendance);

							Console.WriteLine("Attendance added successfully!");

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
							Console.WriteLine("\n--- Search Student ---");

							if (students.Count == 0)
							{
								Console.WriteLine("No students registered.");
								break;
							}

							Console.Write("Enter Student ID: ");
							int id = int.Parse(Console.ReadLine());

							bool found = false;

							for (int i = 0; i < students.Count; i++)
							{
								if (students[i].Id == id)
								{
									Console.WriteLine("Student Found!");
									Console.WriteLine("ID: " + students[i].Id);
									Console.WriteLine("First Name: " + students[i].FirstName);
									Console.WriteLine("Last Name: " + students[i].LastName);
									Console.WriteLine("Age: " + students[i].Age);

									found = true;
									break;
								}
							}

							if (!found)
							{
								Console.WriteLine("Student not found.");
							}

							break;
						}

					case 2:
						{
							Console.WriteLine("\n--- Search Subject ---");

							if (subjects.Count == 0)
							{
								Console.WriteLine("No subjects registered.");
								break;
							}

							Console.Write("Enter Subject ID: ");
							int id = int.Parse(Console.ReadLine());

							bool found = false;

							for (int i = 0; i < subjects.Count; i++)
							{
								if (subjects[i].Id == id)
								{
									Console.WriteLine("Subject Found!");
									Console.WriteLine("ID: " + subjects[i].Id);
									Console.WriteLine("Subject Name: " + subjects[i].Name);
									Console.WriteLine("Teacher: " + subjects[i].Teacher);

									found = true;
									break;
								}
							}

							if (!found)
							{
								Console.WriteLine("Subject not found.");
							}

							break;
						}

					case 3:
						{
							Console.WriteLine("\n--- Search Attendance ---");

							if (attendances.Count == 0)
							{
								Console.WriteLine("No attendance records.");
								break;
							}

							Console.Write("Attendance ID: ");
							int id = int.Parse(Console.ReadLine());

							bool found = false;

							for (int i = 0; i < attendances.Count; i++)
							{
								if (attendances[i].Id == id)
								{
									Console.WriteLine("Attendance Found!");
									Console.WriteLine("Attendance ID: " + attendances[i].Id);
									Console.WriteLine("Student ID: " + attendances[i].StudentId);
									Console.WriteLine("Subject ID: " + attendances[i].SubjectId);
									Console.WriteLine("Date: " + attendances[i].Date);
									Console.WriteLine("Status: " + (attendances[i].Status ? "Present" : "Absent"));

									found = true;
									break;
								}
							}

							if (!found)
							{
								Console.WriteLine("Attendance not found.");
							}

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
							Console.WriteLine("\n--- Edit Student ---");

							Console.Write("Enter Student ID: ");
							int id = int.Parse(Console.ReadLine());

							for (int i = 0; i < students.Count; i++)
							{
								if (students[i].Id == id)
								{
									Console.Write("New First Name: ");
									students[i].FirstName = Console.ReadLine();

									Console.Write("New Last Name: ");
									students[i].LastName = Console.ReadLine();

									Console.Write("New Age: ");
									students[i].Age = int.Parse(Console.ReadLine());

									Console.WriteLine("Student updated!");
									break;
								}
							}

							break;
						}

					case 2:
						{
							Console.WriteLine("\n--- Edit Subject ---");

							Console.Write("Enter Subject ID: ");
							int id = int.Parse(Console.ReadLine());

							bool found = false;

							for (int i = 0; i < subjects.Count; i++)
							{
								if (subjects[i].Id == id)
								{
									Console.Write("New Subject Name: ");
									subjects[i].Name = Console.ReadLine();

									Console.Write("New Teacher Name: ");
									subjects[i].Teacher = Console.ReadLine();

									Console.WriteLine("Subject updated!");

									found = true;
									break;
								}
							}

							if (!found)
							{
								Console.WriteLine("Subject not found.");
							}

							break;
						}


					case 3:
						{
							Console.WriteLine("\n--- Edit Attendance ---");

							Console.Write("Enter Attendance ID: ");
							int id;
							int.TryParse(Console.ReadLine(), out id);

							bool found = false;

							for (int i = 0; i < attendances.Count; i++)
							{
								if (attendances[i].Id == id)
								{
									Console.Write("New Student ID: ");
									int studentId;
									int.TryParse(Console.ReadLine(), out studentId);
									attendances[i].StudentId = studentId;

									Console.Write("New Subject ID: ");
									int subjectId;
									int.TryParse(Console.ReadLine(), out subjectId);
									attendances[i].SubjectId = subjectId;

									Console.Write("New Date: ");
									attendances[i].Date = Console.ReadLine();

									Console.Write("New Status (true = Present, false = Absent): ");
									bool status;
									bool.TryParse(Console.ReadLine(), out status);
									attendances[i].Status = status;

									Console.WriteLine("Attendance updated!");

									found = true;
									break;
								}
							}

							if (!found)
							{
								Console.WriteLine("Attendance not found.");
							}

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
							Console.WriteLine("\n--- Delete Student ---");

							if (students.Count == 0)
							{
								Console.WriteLine("No students registered.");
								break;
							}

							Console.Write("Enter Student ID: ");
							int id;
							int.TryParse(Console.ReadLine(), out id);

							bool found = false;

							for (int i = 0; i < students.Count; i++)
							{
								if (students[i].Id == id)
								{
									students.RemoveAt(i);

									Console.WriteLine("Student deleted successfully!");

									found = true;
									break;
								}
							}

							if (!found)
							{
								Console.WriteLine("Student not found.");
							}

							break;
						}


					case 2:
						{
							Console.WriteLine("\n--- Delete Subject ---");

							if (subjects.Count == 0)
							{
								Console.WriteLine("No subjects registered.");
								break;
							}

							Console.Write("Enter Subject ID: ");
							int id;
							int.TryParse(Console.ReadLine(), out id);

							bool found = false;

							for (int i = 0; i < subjects.Count; i++)
							{
								if (subjects[i].Id == id)
								{
									subjects.RemoveAt(i);

									Console.WriteLine("Subject deleted successfully!");

									found = true;
									break;
								}
							}

							if (!found)
							{
								Console.WriteLine("Subject not found.");
							}

							break;
						}

					case 3:
						{
							Console.WriteLine("\n--- Delete Attendance ---");

							if (attendances.Count == 0)
							{
								Console.WriteLine("No attendance records.");
								break;
							}

							Console.Write("Enter Attendance ID: ");
							int id;
							int.TryParse(Console.ReadLine(), out id);

							bool found = false;

							for (int i = 0; i < attendances.Count; i++)
							{
								if (attendances[i].Id == id)
								{
									attendances.RemoveAt(i);

									Console.WriteLine("Attendance deleted successfully!");

									found = true;
									break;
								}
							}

							if (!found)
							{
								Console.WriteLine("Attendance not found.");
							}

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
							Console.WriteLine("\n--- Student List ---");

							if (students.Count == 0)
							{
								Console.WriteLine("No students registered.");
								break;
							}

							for (int i = 0; i < students.Count; i++)
							{
								Console.WriteLine("Student " + (i + 1));
								Console.WriteLine("ID: " + students[i].Id);
								Console.WriteLine("First Name: " + students[i].FirstName);
								Console.WriteLine("Last Name: " + students[i].LastName);
								Console.WriteLine("Age: " + students[i].Age);
								Console.WriteLine();
							}

							break;
						}


					case 2:
						{
							Console.WriteLine("\n--- Subject List ---");

							if (subjects.Count == 0)
							{
								Console.WriteLine("No subjects registered.");
								break;
							}

							for (int i = 0; i < subjects.Count; i++)
							{
								Console.WriteLine("Subject " + (i + 1));
								Console.WriteLine("ID: " + subjects[i].Id);
								Console.WriteLine("Subject Name: " + subjects[i].Name);
								Console.WriteLine("Teacher Name: " + subjects[i].Teacher);
								Console.WriteLine();
							}

							break;
						}


					case 3:
						{
							Console.WriteLine("\n--- Attendance List ---");

							if (attendances.Count == 0)
							{
								Console.WriteLine("No attendance records.");
								break;
							}

							for (int i = 0; i < attendances.Count; i++)
							{
								Console.WriteLine("Attendance ID: " + attendances[i].Id);
								Console.WriteLine("Student ID: " + attendances[i].StudentId);
								Console.WriteLine("Subject ID: " + attendances[i].SubjectId);
								Console.WriteLine("Date: " + attendances[i].Date);
								Console.WriteLine("Status: " + (attendances[i].Status ? "Present" : "Absent"));
								Console.WriteLine();
							}

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



