namespace Parkapp
{
    public class Park
    {
        // Revenue = Entrance fee * PriorYearVisitors
        // CostPerVisitor = AnnualBudget / PriorYearVisitors
        // Properties
        // Name should theoretically not need a setter, but sometimes Parks change names
        public string Name { get; set; }
        public string Location { get; }
        public string Type { get; }
        public string? Factilities { get; set; }
        public int NumEmployees { get; set; }
        public double AnnualBudget { get; set; }
        public int PriorYearVisitors { get; set; }
        public double EntranceFee { get; set; }

        // Variables with custom setters
        private double revenue;
        public double Revenue
        { 
            get { return revenue; }
            set { revenue = EntranceFee * PriorYearVisitors; }
        }
        private double costPerVisitor;
        public double CostPerVisitor
        {
            get { return costPerVisitor; }
            set {costPerVisitor = AnnualBudget / PriorYearVisitors; }
        }

        public Park(string name, string location, string type)
        {
            Name = name;
            Location = location;
            Type = type;
            
        }

        public Park(string name, string location, string type, string facilities)
        {
            Name = name;
            Location = location;
            Type = type;
            Factilities = facilities;
        }

        public Park(string name, string location, string type, string facilities,
                    int numEmployees, double annualBudget, int priorYearVisitors, double fee)
        {
            Name = name;
            Location = location;
            Type = type;
            Factilities = facilities;
            NumEmployees = numEmployees;
            AnnualBudget = annualBudget;
            PriorYearVisitors = priorYearVisitors;
            EntranceFee = fee;

            // Init to 0 so that their setters take effect
            Revenue = 0;
            CostPerVisitor = 0;
        }

        public override string ToString()
        {
            return $"{"Park:", -15}" + Name +
                   $"{"\nPark Location:", -16}" + Location +
                   $"{"\nType of Park:", -16}" + Type;
        }

        public string GetFacilities()
        {
            return $"{"\nFacilities:", -16}" + Factilities;
        }

        public string GetAnnualReport()
        {
            return "\n===== Annual Report =====" + 
                   $"{"\nEmployees:", -20}" + NumEmployees +
                   $"{"\nPrior Year Guests:", -20}" + PriorYearVisitors +
                   $"{"\nAnnual Budget:", -20}" + AnnualBudget +
                   $"{"\nRevenue:", -20}" + Revenue +
                   $"{"\nCost per Visistor:", -20}" + CostPerVisitor;
        }
        
    }
}