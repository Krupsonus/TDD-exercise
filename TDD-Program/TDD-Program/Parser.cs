namespace TDD_Program
{
    public class Parser
    {
        public int max(int a, int b)
        {
            return Math.Max(a, b);
        }

        public int min(int a, int b)
        {
            return Math.Min(a, b);
        }

        public bool isPositive(int a)
        {
            if (a < 0) { return false; }
            return true;
        }
    }
}
