namespace JourneyOfLeetCodeTop150InterviewQs;
public class RemoveElementSln
{
    public int RemoveElement(int[] nums, int val)
    {
        //Run time beats 100%, Memory usage beats 43.06%
        //from solution, which will only use one pointer
        //counter could be used as a counter, but also indicates where should the 
        //element go
        int counter = 0;
        for (int i = 0; i < nums.Length; i++)
        { 
            if (nums[i] != val)
                nums[counter++] = nums[i];
        }
        return counter;
        //Run time beats 100%, Memory usage beats 29.11%, same performance compare to the first one
        /*//do it from backward to see performance
        //return in any order
        int counter = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                //find the next one, and exchange
                int y = nums.Length - 1;
                while (y > i)
                {
                    if (nums[y] != val)
                    {
                        //exchange
                        break;
                    }
                    y--;
                }
                if (y == i)
                {
                    //reached to the i and can't find any val to exchange
                    break;
                }
                else
                {
                    nums[i] = nums[y];
                    nums[y] = val;
                    counter++;
                }
            }
            else
            {
                counter++;
            }
        }
        return counter;*/
        //Run time beats 100%, Memory usage beats 29.11%
        //this version will return things in order
        /*//how many elements that is not val
        int counter = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                //find the next one, and exchange
                int y = i + 1;
                while (y < nums.Length)
                {
                    if (nums[y] != val)
                    {
                        //exchange
                        break;
                    }
                    y++;
                }
                if (y == nums.Length)
                {
                    //reached to the end and can't find any val to exchange
                    break;
                }
                else
                {
                    nums[i] = nums[y];
                    nums[y] = val;
                    counter++;
                }
            }
            else
            {
                counter++;
            }
        }
        return counter;*/
    }
}
