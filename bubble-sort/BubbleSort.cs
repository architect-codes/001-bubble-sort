namespace ar.codes.bubble_sort
{
    /// <summary>
    /// this is a demonstration implementation of "bubble sort" algorithm
    /// </summary>
    public class BubbleSort
    {
        public static void PerformSort(ref decimal[] data)
        {
            // do nothing if we have less than 2 elements
            if(data.Length < 2)
                return;

            // have two loops:
            //  outer loop goes from last element to beginning of array - every pass will assure largest value will be placed 
            //  inner loop goes from first to whatever current outer value
            for(int i = data.Length - 1; i > 0; i--)
                for(int j = 0; j < i; j++)
                    // if previous element is larger than next element - swap those
                    if(data[j] > data[j + 1])
                        // swap values data[j] and data[j+1] using tuple
                        (data[j + 1], data[j]) = (data[j], data[j + 1]);
        }
    }
}