namespace JourneyOfLeetCodeTop150InterviewQs;
public class RansomNoteSln
{
    
    public bool CanConstruct(string ransomNote, string magazine)
    {
        if(ransomNote.Length > magazine.Length)
            return false;
        int[] charCount = new int[26];
        // Count the occurrences of each character in the magazine
        for (int i = 0; i < magazine.Length; i++)
        {
            if(i < ransomNote.Length)
                charCount[ransomNote[i] - 'a']--;
            charCount[magazine[i] - 'a']++;
        }
        return charCount.All(counter => counter >= 0);
    }
}
