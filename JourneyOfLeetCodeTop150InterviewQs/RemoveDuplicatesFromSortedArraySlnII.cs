namespace JourneyOfLeetCodeTop150InterviewQs;
public class RemoveDuplicatesFromSortedArraySlnII
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length < 2)
            return nums.Length;
        //we dont need to worry about the first two elements
        int counter = 2;
        for (int i = 2; i < nums.Length; i++)
        {
            //it is already sorted.
            if (nums[i] != nums[counter - 2])
            {
                nums[counter++] = nums[i];
            }
        }
        return counter;
        /*//Run time beats 34.66%, Memory usage beats 88.25%
        if (nums.Length == 0)
            return 0;
        int counter = 1;
        int currentValue = nums[0];
        bool alreadyTwice = false;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != currentValue)
            {
                nums[counter++] = currentValue = nums[i];
                alreadyTwice = false;
            }
            else 
            {
                if (!alreadyTwice) 
                {
                    nums[counter++] = nums[i];
                    alreadyTwice = true;
                }
            }
        }
        return counter;*/
    }
}
