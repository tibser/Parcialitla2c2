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
										Console.WriteLine("\n--- Add Student ---");

										int id;

										Console.Write("Student ID: ");
										while (!int.TryParse(Console.ReadLine(), out id))
										{
											Console.Write("Invalid ID. Enter again: ");
										}


										Console.Write("First Name: ");
										string firstName = Console.ReadLine();


										Console.Write("Last Name: ");
										string lastName = Console.ReadLine();


										int age;

										Console.Write("Age: ");
										while (!int.TryParse(Console.ReadLine(), out age))
										{
											Console.Write("Invalid age. Enter again: ");
										}


										studentIds.Add(id);
										firstNames.Add(firstName);
										lastNames.Add(lastName);
										ages.Add(age);


										Console.WriteLine("Student added successfully!");

										break;
									}


						case 2:
							{
								Console.WriteLine("Add Subject");

								Console.WriteLine("\n*** Add Subject ***");

								int id;

								Console.Write("Subject ID: ");
								while (!int.TryParse(Console.ReadLine(), out id))
								{
									Console.Write("Invalid ID. Enter again: ");
								}

								Console.Write("Subject Name: ");
								string subjectName = Console.ReadLine();

								Console.Write("Teacher Name: ");
								string teacherName = Console.ReadLine();

								subjectIds.Add(id);
								subjectNames.Add(subjectName);
								teacherNames.Add(teacherName);

								Console.WriteLine("Subject added successfully!");


								break;
							}


						case 3:
							{
								Console.WriteLine("Add Attendance");

								int attendanceId;

								Console.Write("Attendance ID: ");
								while (!int.TryParse(Console.ReadLine(), out attendanceId))
								{
									Console.Write("Invalid ID. Enter again: ");
								}

								int studentId;

								Console.Write("Student ID: ");
								while (!int.TryParse(Console.ReadLine(), out studentId))
								{
									Console.Write("Invalid Student ID. Enter again: ");
								}

								int subjectId;

								Console.Write("Subject ID: ");
								while (!int.TryParse(Console.ReadLine(), out subjectId))
								{
									Console.Write("Invalid Subject ID. Enter again: ");
								}

								Console.Write("Date: ");
								string date = Console.ReadLine();

								Console.Write("Attendance (true = Present, false = Absent): ");

								bool status;
								while (!bool.TryParse(Console.ReadLine(), out status))
								{
									Console.Write("Invalid value. Enter true or false: ");
								}

								attendanceIds.Add(attendanceId);
								attendanceStudentIds.Add(studentId);
								attendanceSubjectIds.Add(subjectId);
								attendanceDates.Add(date);
								attendanceStatus.Add(status);

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

										if (studentIds.Count == 0)
										{
											Console.WriteLine("No students registered.");
											break;
										}

										Console.Write("Enter Student ID: ");
										int id;
										int.TryParse(Console.ReadLine(), out id);

										int index = studentIds.IndexOf(id);

										if (index >= 0)
										{
											Console.WriteLine("Student Found!");
											Console.WriteLine("ID: " + studentIds[index]);
											Console.WriteLine("First Name: " + firstNames[index]);
											Console.WriteLine("Last Name: " + lastNames[index]);
											Console.WriteLine("Age: " + ages[index]);
										}
										else
										{
											Console.WriteLine("Student not found.");
										}

										break;
									}




						case 2:
							{
								Console.WriteLine("\n--- Search Subject ---");

								if (subjectIds.Count == 0)
								{
									Console.WriteLine("No subjects registered.");
									break;
								}

								Console.Write("Enter Subject ID: ");
								int id;
								int.TryParse(Console.ReadLine(), out id);

								int index = subjectIds.IndexOf(id);

								if (index >= 0)
								{
									Console.WriteLine("Subject Found!");
									Console.WriteLine("ID: " + subjectIds[index]);
									Console.WriteLine("Subject Name: " + subjectNames[index]);
									Console.WriteLine("Teacher: " + teacherNames[index]);
								}
								else
								{
									Console.WriteLine("Subject not found.");
								}




								break;
							}

						case 3:
							{
								Console.WriteLine("Search Attendance");
								Console.WriteLine("Enter Attendance ID");

								if (attendanceIds.Count == 0)
								{
									Console.WriteLine("No attendance records.");
									break;
								}

								Console.Write("Attendance ID: ");
								int id;
								int.TryParse(Console.ReadLine(), out id);

								int index = attendanceIds.IndexOf(id);

								if (index >= 0)
								{
									Console.WriteLine("Attendance Found!");
									Console.WriteLine("Attendance ID: " + attendanceIds[index]);
									Console.WriteLine("Student ID: " + attendanceStudentIds[index]);
									Console.WriteLine("Subject ID: " + attendanceSubjectIds[index]);
									Console.WriteLine("Date: " + attendanceDates[index]);
									Console.WriteLine("Status: " + (attendanceStatus[index] ? "Present" : "Absent"));
								}
								else
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
								int id;
								int.TryParse(Console.ReadLine(), out id);

								for (int i = 0; i < studentIds.Count; i++)
								{
									if (studentIds[i] == id)
									{
										Console.Write("New First Name: ");
										firstNames[i] = Console.ReadLine();

										Console.Write("New Last Name: ");
										lastNames[i] = Console.ReadLine();

										Console.Write("New Age: ");

										int newAge;
										int.TryParse(Console.ReadLine(), out newAge);

										ages[i] = newAge;

										Console.WriteLine("Student updated!");
										break;
									}
								}



								break;
							}

						case 2:
							{
								Console.WriteLine("Edit Subject");

								Console.WriteLine("\n$$$ Edit Subject $$$");

								Console.Write("Enter Subject ID: ");
								int id;
								int.TryParse(Console.ReadLine(), out id);

								for (int i = 0; i < subjectIds.Count; i++)
								{
									if (subjectIds[i] == id)
									{
										Console.Write("New Subject Name: ");
										subjectNames[i] = Console.ReadLine();

										Console.Write("New Teacher Name: ");
										teacherNames[i] = Console.ReadLine();

										Console.WriteLine("Subject updated!");
										break;
									}
								}


								break;
							}

						case 3:
							{
								Console.WriteLine("Edit Attendance");

								Console.WriteLine("\n--- Edit Attendance ---");

								Console.Write("Enter Attendance ID: ");
								int id;
								int.TryParse(Console.ReadLine(), out id);

								for (int i = 0; i < attendanceIds.Count; i++)
								{
									if (attendanceIds[i] == id)
									{
										int studentId;
										int.TryParse(Console.ReadLine(), out studentId);
										attendanceStudentIds[i] = studentId;

										int subjectId;
										int.TryParse(Console.ReadLine(), out subjectId);
										attendanceSubjectIds[i] = subjectId;


										Console.Write("New Date: ");
										attendanceDates[i] = Console.ReadLine();


										bool status;
										bool.TryParse(Console.ReadLine(), out status);
										attendanceStatus[i] = status;


										Console.WriteLine("Attendance updated!");
										break;
									}
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
								Console.WriteLine("Delete Student");

								Console.WriteLine("\n ''' Delete Student '''");

								if (studentIds.Count == 0)
								{
									Console.WriteLine("No students registered.");
									break;
								}

								Console.Write("Enter Student ID: ");
								int id;
								int.TryParse(Console.ReadLine(), out id);

								int index = studentIds.IndexOf(id);

								if (index >= 0)
								{
									studentIds.RemoveAt(index);
									firstNames.RemoveAt(index);
									lastNames.RemoveAt(index);
									ages.RemoveAt(index);

									Console.WriteLine("Student deleted successfully!");
								}
								else
								{
									Console.WriteLine("Student not found.");
								}


								break;
							}

						case 2:
							{
								Console.WriteLine("Delete Subject");

								Console.WriteLine("\n 33333 Delete Subject 33333");

								if (subjectIds.Count == 0)
								{
									Console.WriteLine("No subjects registered.");
									break;
								}

								Console.Write("Enter Subject ID: ");
								int id;
								int.TryParse(Console.ReadLine(), out id);

								int index = subjectIds.IndexOf(id);

								if (index >= 0)
								{
									subjectIds.RemoveAt(index);
									subjectNames.RemoveAt(index);
									teacherNames.RemoveAt(index);

									Console.WriteLine("Subject deleted successfully!");
								}
								else
								{
									Console.WriteLine("Subject not found.");
								}




								break;
							}

						case 3:
							{
								Console.WriteLine("Delete Attendance");

								Console.WriteLine("\n Delete Attendance ");

								if (attendanceIds.Count == 0)
								{
									Console.WriteLine("No attendance records.");
									break;
								}

								Console.Write("Enter Attendance ID: ");
								int id;
								int.TryParse(Console.ReadLine(), out id);

								int index = attendanceIds.IndexOf(id);

								if (index >= 0)
								{
									attendanceIds.RemoveAt(index);
									attendanceStudentIds.RemoveAt(index);
									attendanceSubjectIds.RemoveAt(index);
									attendanceDates.RemoveAt(index);
									attendanceStatus.RemoveAt(index);

									Console.WriteLine("Attendance deleted successfully!");
								}
								else
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
								Console.WriteLine("List Students");

								Console.WriteLine("List Students");

								Console.WriteLine("\n--- Student List ---");

								if (studentIds.Count == 0)
								{
									Console.WriteLine("No students registered.");
									break;
								}

								for (int i = 0; i < studentIds.Count; i++)
								{
									Console.WriteLine("Student " + (i + 1));
									Console.WriteLine("ID: " + studentIds[i]);
									Console.WriteLine("First Name: " + firstNames[i]);
									Console.WriteLine("Last Name: " + lastNames[i]);
									Console.WriteLine("Age: " + ages[i]);
									Console.WriteLine();
								}


								break;
							}

						case 2:
							{
								Console.WriteLine("List Subjects");

								Console.WriteLine("List Subjects");

								Console.WriteLine("\n °°°° Subject List °°°°");

								if (subjectIds.Count == 0)
								{
									Console.WriteLine("No subjects registered.");
									break;
								}

								for (int i = 0; i < subjectIds.Count; i++)
								{
									Console.WriteLine("Subject " + (i + 1));
									Console.WriteLine("ID: " + subjectIds[i]);
									Console.WriteLine("Subject Name: " + subjectNames[i]);
									Console.WriteLine("Teacher Name: " + teacherNames[i]);
									Console.WriteLine();
								}


								break;
							}

						case 3:
							{
								Console.WriteLine("List Attendance");

								Console.WriteLine("\n--- Attendance List ---");

								if (attendanceIds.Count == 0)
								{
									Console.WriteLine("No attendance records.");
									break;
								}

								for (int i = 0; i < attendanceIds.Count; i++)
								{
									Console.WriteLine("Attendance ID: " + attendanceIds[i]);
									Console.WriteLine("Student ID: " + attendanceStudentIds[i]);
									Console.WriteLine("Subject ID: " + attendanceSubjectIds[i]);
									Console.WriteLine("Date: " + attendanceDates[i]);
									Console.WriteLine("Status: " + (attendanceStatus[i] ? "Present" : "Absent"));
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

