
namespace MentorMateDevCamp
{
   public interface IRectangleValidator 
    {
        //Validate the size(N,M) of rectangle
        public  bool IsValidSize(int n,int m);
        /*Validate the size of a brick to be not more than 2
          Note - 1 is incorect size of brick*/
        public bool IsValidBrick(int[,] inputBricks, int n, int m);
    }
}
