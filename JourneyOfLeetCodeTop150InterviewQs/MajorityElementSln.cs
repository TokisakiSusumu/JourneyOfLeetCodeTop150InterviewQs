namespace JourneyOfLeetCodeTop150InterviewQs;
public class MajorityElementSln
{
    public int MajorityElement(int[] nums)
    {
        //because the major element will always be
        //more than half of the array, so the counter will at least be one once the whole array is traversed for the major element
        int maj = 0;
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (count == 0)
            {
                maj = nums[i];
            }

            count += nums[i] == maj ? 1 : -1;
        }
        return maj;
        /*return nums.GroupBy(i => i)
            .Where(g => g.Count() > (nums.Length / 2))
            .First().Key;*/
    }
}
