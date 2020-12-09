using System;
using System.Collections.Generic;

namespace MentorMateDevCamp
{
   public class Rectagle : IRectangleValidator
    {
        public int M { get; set; }

        public int N { get; set; }

        public int BrickWall(int N, int M)
        {
            var integarList = new List<int>(); 
            int[,] inputArray = new int[N, M];

            if (N>10 || M>10)
            {
                Console.WriteLine("Incorect input !");
                return -1;
            }
            if (N % 2 == 0 && M % 2 == 0 && IsValidSize(N, M))
            {

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        Console.Write("Input number : ");// TODO: make it less then 100//
                        var input = Convert.ToInt32(Console.ReadLine());
                        if (input>=100)
                        {
                            Console.WriteLine("To large Number for brick !!");
                            return -1;
                        }
                        inputArray[i, j] = input;
                    }
                }
                if (IsValidBrick(inputArray, N, M))
                {

                for (int i = 0; i < N; i++) //Printing the first layer
                {
                    for (int j = 0; j < M; j++)
                    {
                        Console.Write(inputArray[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                for (int i = 0; i < N; i++)
                {
                    for (int j = 1; j < M; j += 2)
                    {
                        if (j == M - 1)
                        {
                            integarList.Add(inputArray[i, j]); // Added last number of rows

                            break;
                        }

                        inputArray[i, j + 1] = inputArray[i, j]; // make the center of the array to be with brick (column from 1 to M-2)
                    }
                }

                if (integarList.Count == 4)
                {
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            if (integarList.Count == 4)
                            {
                                for (int k = 0, count = 0, h = 0; k < integarList.Count / 2; k++, h++) //set the first brick in first column to be vertical.
                                {
                                    inputArray[h, j] = integarList[count];

                                }
                                for (int k = 2, count = 1, h = 2; k < integarList.Count; k++)//set the last brick from first column to be vertical.
                                    {

                                    inputArray[h, j] = integarList[count];
                                    h++;
                                }
                                break;
                            }
                        }
                        break;
                    }

                    for (int i = 0; i < N; i++)
                    {
                        for (int j = M - 1; j < M; j++)
                        {
                            if (integarList.Count == 4)
                            {
                                for (int k = 0, count = 2, h = 0; k < integarList.Count / 2; k++, h++)//set the first brick in last column to be vertical.
                                    {
                                    inputArray[h, j] = integarList[count];

                                }
                                for (int k = 2, count = 3, h = 2; k < integarList.Count; k++)//set the last brick from last column to be vertical.
                                    {

                                    inputArray[h, j] = integarList[count];
                                    h++;
                                }
                                break;

                            }


                        }
                        break;
                    }
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < M; j++)
                        {
                            Console.Write(inputArray[i, j]);
                        }
                        Console.WriteLine();
                    }

                   
                    return 1;
                }
                if (integarList.Count == 2)
                {
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            if (integarList.Count == 2)
                            {
                                for (int k = 0, count = 0, h = 0; k < integarList.Count; k++, h++)//set the first brick in first column to be vertical.
                                    {
                                    inputArray[h, j] = integarList[count];

                                }
                            }
                        }
                        break;
                    }

                    for (int i = 0; i < N; i++)
                    {
                        for (int j = M - 1; j < M; j++)
                        {
                            if (integarList.Count == 2)
                            {

                                for (int k = 0, count = 1, h = 0; k < integarList.Count; k++)//set the first brick in last column to be vertical.
                                    {

                                    inputArray[h, j] = integarList[count];
                                    h++;
                                }
                                break;

                            }


                        }
                        break;
                    }

                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < M; j++)
                        {
                            Console.Write(inputArray[i, j]);
                        }
                        Console.WriteLine();
                    }

                    foreach (var item in integarList)
                    {
                        Console.WriteLine(item);
                    }
                    return 1;
                }
                
            }
                return -1;
            }
            else
            {
                return -1;
            }
           
        }

        public bool IsValidBrick(int[,] inputBricks, int n , int m)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j+=2)
                {

                    if (j+1 <m && inputBricks[i,j] == inputBricks[i,j+1] )
                    {
                        count++;
                    }
                    else if (j+1>=m)
                    {
                        break;
                    }
                    if (i>0)
                    {
                        if (inputBricks[i, j] == inputBricks[i-1, m-1])
                        {
                            count++;
                        }
                    }
                    
                    
                }
                if (count == m/2)
                {
                    count = 0;
                    
                }
                else
                {
                    Console.WriteLine("Error - To large brick  !!");
                    return false;
                }
                
            }
            
            return true;
            
        }

        public bool IsValidSize(int n,int m)
        {
            if (m==2*n)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
