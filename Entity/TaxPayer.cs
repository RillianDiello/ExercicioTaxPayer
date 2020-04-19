using System;
namespace Entity
{
    abstract class TaxPayer
    {
       public String Nome {get; set;}   // 
       public double anualIncome {get; set;} // renda

       protected TaxPayer (String name, double anual)
       {
           Nome = name;
           anualIncome = anual;
       }

       public abstract double Tax();
    }
}