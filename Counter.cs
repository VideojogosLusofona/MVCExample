using System;

namespace MVCExample.Common
{
    public class Counter
    {
        private int count;
        private readonly int maxCount;

        public Counter(int maxCount)
        {
            if (maxCount < 1)
                throw new ArgumentOutOfRangeException(
                    "The maxCount argument must be > 0");
            count = 0;
            this.maxCount = maxCount;
        }

        public void IncrementCount()
        {
            count++;
            if (count >= maxCount)
            {
                OnHitMaxCount();
            }
        }

        protected void OnHitMaxCount()
        {
            HitMaxCount?.Invoke();
            count = 0;
        }

        public event Action HitMaxCount;
    }
}
