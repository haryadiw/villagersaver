using System.Reflection.Metadata.Ecma335;

namespace VillagerSaver.Models;

public class ViewModel
{
    public PersonModel? PersonA { get; set; }
    public PersonModel? PersonB { get; set; }

    public Int32? TotalPeopleKilled { get; set; }
    public float? AvgPeopleKilled { get; set; }

    public void calculate(){

        this.TotalPeopleKilled = this.getTotalPeopleKilled();

        if(this.TotalPeopleKilled == -1){
            this.AvgPeopleKilled = -1;
        }else{
            this.AvgPeopleKilled = (float) this.TotalPeopleKilled / 2;
        }

    }

    private Int32 getTotalPeopleKilled(){

        Int32 Total = 0;

        if(PersonA?.PeopleKilled == -1 || PersonB?.PeopleKilled == -1){
            Total = -1;
        }else{
            Total = (Int32) PersonA?.PeopleKilled + (Int32) PersonB?.PeopleKilled;
        }

        return Total;
    }
}
