using System;
namespace Entity
{
    class Individual : TaxPayer{
         public double HealthExpenditures { get; set; }


        public Individual(string name, double anualIncome, double healthExpenditures) 
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if(anualIncome > 20000.0){
                return anualIncome * 0.15 - HealthExpenditures * 0.5;
            }else{
                return anualIncome * 0.25 - HealthExpenditures * 0.5;
            }
        }
    }
}