using System.Reflection.Metadata.Ecma335;

namespace VillagerSaver.Models;

public class FiboModel
{

    public Int32 Deep;
    private Int32 Total;
    public FiboModel(Int32 Deep)
    {
        this.Deep = Deep;
    }

    public Int32 getTotal()
    {

        int[,] myArray = new int[this.Deep, this.Deep];

        for (Int32 i = 0; i < this.Deep; i++)
        {
            this.Total = 0;
            for (Int32 j = 0; j < this.Deep; j++)
            {
                if (i >= j)
                {
                    myArray[i, j] = 1;
                }
                if (i >= j && i > 1 && j > 1)
                {
                    myArray[i, j] = myArray[i, j - 1] + myArray[i, j - 2];
                }
                this.Total += myArray[i, j];
            }
        }

        return this.Total;

    }


}
