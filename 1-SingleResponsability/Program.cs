using SingleResponsability;

StudentRepository studentRepository = new();
StudentExport studentExport = new(studentRepository);
studentExport.Export();
Console.WriteLine("Proceso Completado");