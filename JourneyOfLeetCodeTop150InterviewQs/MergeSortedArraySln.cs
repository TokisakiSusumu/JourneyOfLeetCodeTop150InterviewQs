namespace JourneyOfLeetCodeTop150InterviewQs;
public class MergeSortedArraySln
{
    //Run time beats 100%, Memory usage beats 44.18%
    public void Merge(int[] NumArray1, int NumArray1Counter, int[] NumArray2, int NumArray2Counter)
    {
        //two pointers
        int firstEnd = NumArray1Counter - 1, secondEnd = NumArray2Counter - 1, totalEnd = NumArray1Counter + NumArray2Counter - 1;
        while (totalEnd >= 0)
        {
            //if in the second array we still have elements
            //and if it is bigger than the element in the first array 
            //then we put it in the last position of the total array(first array)
            if (firstEnd < 0 || (secondEnd >= 0 && NumArray2[secondEnd] >= NumArray1[firstEnd]))
            {
                NumArray1[totalEnd--] = NumArray2[secondEnd--];
            }
            else if (secondEnd < 0) 
            {
                return;
            }
            //if we need to use the element in the first array
            //and there are still element in the second array
            else
            {
                NumArray1[totalEnd--] = NumArray1[firstEnd--];
            }
        }
    }
}
