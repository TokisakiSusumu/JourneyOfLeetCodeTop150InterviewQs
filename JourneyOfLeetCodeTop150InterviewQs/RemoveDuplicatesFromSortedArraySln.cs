namespace JourneyOfLeetCodeTop150InterviewQs;
public class RemoveDuplicatesFromSortedArraySln
{
    public int RemoveDuplicates(int[] nums)
    {
        //Run time beats 100%, Memory usage beats 99.23%
        //weird that sbyte would cost more memory than a int
        //could do it using hashset, but it is already sorted
        //we only need to have a value copy to make sure the next one
        //is not equal to the current one, then change using pointer(counter)
        //the counter is doing the same thing compare to removeElementSln
        //count from very beginning
        if (nums.Length == 0)
            return 0;
        int counter = 1;
        int currentValue = nums[0];
        for (int i = 1; i < nums.Length; i++) 
        {
            if (nums[i] != currentValue) 
            {
                nums[counter++] = currentValue = nums[i];
            }
        }
        return counter;
    }
    public int RemoveDuplicatesII(int[] nums)
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
