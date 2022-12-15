namespace DeferedExecutionDemo
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsVaccinated { get; set; }
        public bool HasHMO { get; set; }
        public PatientType Type { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Id: {Id}, Type: {Type}, IsVaccinated: {IsVaccinated}, HasHMO: {HasHMO}";
        }
    }
}
