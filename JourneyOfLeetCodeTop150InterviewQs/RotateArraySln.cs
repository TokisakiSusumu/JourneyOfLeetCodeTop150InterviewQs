namespace JourneyOfLeetCodeTop150InterviewQs;
public class RotateArraySln
{
    public void Rotate(int[] nums, int k)
    {
        //k is the number of rotations
        //we can use the reverse method to rotate the array
        //reverse the whole array
        //reverse the first k elements
        //reverse the rest of the elements
        k = k % nums.Length;
        Array.Reverse(nums);
        Array.Reverse(nums, 0, k);
        Array.Reverse(nums, k, nums.Length - k);
    }
}
