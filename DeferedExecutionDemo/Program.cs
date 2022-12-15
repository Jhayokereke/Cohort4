/* DEFERRED EXECUTION aka LAZY LOADING
 * 
 * This occurs when a query is not executed until the values from the query are required.
 * 
 * Select, Where, Take, Skip etc
 * 
 * IMMEDIATE EXECUTION aka EAGER LOADING
 * 
 * This occurs when a query is executed at the point where it is defined.
 * 
 * FirstOrDefault, Tolist, ToArray
 */

using DeferedExecutionDemo;

List<Patient> patients = new List<Patient>
{
    new Patient { Id = 001, Name = "Emilokan", IsVaccinated = false, HasHMO = true, Type = PatientType.In_Patient },
    new Patient { Id = 002, Name = "Adebisi", IsVaccinated = true, HasHMO = true, Type = PatientType.Out_Patient },
    new Patient { Id = 003, Name = "Georgyln", IsVaccinated = true, HasHMO = false, Type = PatientType.Out_Patient },
    new Patient { Id = 004, Name = "Tonrak", IsVaccinated = false, HasHMO = false, Type = PatientType.Out_Patient },
};

//vaccinated patients
var query = from p in patients
            where p.IsVaccinated
            select p;

var query3 = query.Skip(1);

patients.Add(new Patient { Id = 005, Name = "Harry", IsVaccinated = true, HasHMO = false, Type = PatientType.In_Patient });

foreach (var patient in query)
{
    Console.WriteLine(patient);
}
Console.WriteLine();

patients.Add(new Patient { Id = 006, Name = "Caleb", IsVaccinated = true, HasHMO = true, Type = PatientType.Out_Patient });

var query1 = query.FirstOrDefault(p => p.Id > 5);

var query2 = query.Where(p => p.HasHMO);

patients.Add(new Patient { Id = 007, Name = "Cynthia", IsVaccinated = true, HasHMO = true, Type = PatientType.In_Patient });

foreach (var patient in query2)
{
    Console.WriteLine(patient);
}

Console.WriteLine();
foreach (var patient in query3)
{
    Console.WriteLine(patient);
}

Console.WriteLine();
Console.WriteLine(query1?.ToString() ?? "No patient");
