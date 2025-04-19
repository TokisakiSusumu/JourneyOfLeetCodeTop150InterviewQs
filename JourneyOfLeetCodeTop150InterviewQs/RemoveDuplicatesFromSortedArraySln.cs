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
}
