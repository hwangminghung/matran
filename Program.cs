using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhập số hàng của ma trận:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhập số cột của ma trận:");
        int columns = int.Parse(Console.ReadLine());

        double[,] matrix = new double[rows, columns];

        Console.WriteLine("Nhập các phần tử của ma trận:");

        // Nhập giá trị cho từng phần tử của ma trận
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine($"Nhập giá trị cho phần tử [{i}, {j}]:");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        double maxElement = matrix[0, 0];
        int maxRow = 0;
        int maxColumn = 0;

        // Tìm phần tử lớn nhất trong ma trận
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (matrix[i, j] > maxElement)
                {
                    maxElement = matrix[i, j];
                    maxRow = i;
                    maxColumn = j;
                }
            }
        }

        Console.WriteLine($"Phần tử lớn nhất trong ma trận có giá trị {maxElement} và tọa độ [{maxRow}, {maxColumn}].");
    }
}