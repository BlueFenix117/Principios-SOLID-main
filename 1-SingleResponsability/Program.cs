using SingleResponsability;

StudentRepository studentRepository = new();
StudentExport studentExport = new();
studentExport.Export();
Console.WriteLine("Proceso Completado");