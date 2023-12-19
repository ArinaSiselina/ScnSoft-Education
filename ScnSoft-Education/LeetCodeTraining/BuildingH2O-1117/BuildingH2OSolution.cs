namespace LeetCodeTraining.BuildingH2O
{
    //https://leetcode.com/problems/building-h2o/
    public class H2O
    {
        private SemaphoreSlim semaphoreO = new(0);
        private SemaphoreSlim semaphoreH = new(1);
        private int hcount = 0;

        public H2O()
        {

        }

        public void Hydrogen(Action releaseHydrogen)
        {
            semaphoreH.Wait();
            hcount += 1;

            releaseHydrogen();

            if (hcount % 2 == 0)
            {
                semaphoreO.Release();
            }
            else
            {
                semaphoreH.Release();
            }

        }

        public void Oxygen(Action releaseOxygen)
        {
            semaphoreO.Wait();
            releaseOxygen();
            semaphoreH.Release();
        }
    }
}