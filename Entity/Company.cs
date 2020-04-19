using System;
namespace Entity
{
    class Company : TaxPayer
    {
       public int NumberOfEmployees { get; set; }

       public Company(string name, double anualIncome, int numberOfEmployees) 
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if(NumberOfEmployees > 10)
            {
                return anualIncome * 0.14;                
            }else{
                return anualIncome * 0.16;
            }
        
        }
    }
}