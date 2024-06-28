using System.Reflection.Metadata.Ecma335;

namespace VillagerSaver.Models;

public class PersonModel
{
    public Int32? AgeOfDeath { get; set; }
    public Int32? YearOfDeath { get; set; }
    public Int32? YearOfBorn { get; set; }

    public Int32? PeopleKilled { get; set; }

    public PersonModel(Int32 ageOfDeath, Int32 yearOfDeath){
        this.AgeOfDeath = ageOfDeath;
        this.YearOfDeath = yearOfDeath;
        this.YearOfBorn = this.getYearOfBorn();
        this.PeopleKilled = this.getPeopleKilled();
    }

    private Int32 getPeopleKilled(){

        FiboModel fb = new FiboModel((Int32) this.YearOfBorn);

        if(this.YearOfBorn == -1){
            return -1;
        }

        return fb.getTotal();

    }

    private Int32 getYearOfBorn(){
        if(this.AgeOfDeath > this.YearOfDeath){
            return -1;
        }
        return (Int32) this.YearOfDeath - (Int32) this.AgeOfDeath;
    }
    
}
