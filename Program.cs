using System;
class Program{
    static void Main(string[] args){
            
        Console.WriteLine("Enter the Pascal's triangle row number:");
        int rowNumber;

        do{
           rowNumber = int.Parse(Console.ReadLine());

            if(rowNumber >= 0 ){
                
                break;

            }

            Console.WriteLine("Invalid Pascal's triangle row number.");

        }while(rowNumber < 0 );

        PascalsTriangle(rowNumber);

    }
        static void PascalsTriangle(int rows){

        for (int i = 0; i <= rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(CalculatePascal(i, j) + " ");
            }

            Console.WriteLine();
        }
    }

    static int CalculatePascal(int row, int column)
    {
        if (column == 0 || column == row)
            return 1;

        return CalculatePascal(row - 1, column - 1) + CalculatePascal(row - 1, column);
    }
}