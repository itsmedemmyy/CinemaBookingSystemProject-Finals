namespace CinemaVariables
{
    public class Variables
    {
        public string EmpName = "Employee1";
        public int Selected_num { get; set; }
        public string? Username { get; set; }
        public string? CusNum { get; set; } 
        public string? CusName { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string? Time { get; set; }
        public int Ticket { get; set; }
        public int Price { get; set; }
        public int Totalprice { get; set; }
        public string? trans_date { get; set; }
        public DateTime dateNow { get; set; } = DateTime.Now;
    }
}