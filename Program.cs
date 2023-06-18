namespace SearchingProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearch binarySearch = new BinarySearch();
            string[] arr = {"abc", "def", "pqr", "xyz" };
            string data = "xyz";
            binarySearch.binarySearch(arr, data);
        }
    }
}