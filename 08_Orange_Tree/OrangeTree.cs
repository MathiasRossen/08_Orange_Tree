using System;

namespace _08_Orange_Tree
{
    internal class OrangeTree
    {
        int age, height, numOranges, orangesEaten;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int Height
        {
            get { return height + age * 2; }
        }

        public bool TreeAlive
        {
            get
            {
                if (Age < 80)
                    return true;
                return false;
            }
        }

        public int NumOranges
        {
            get { return numOranges + (Age - 1) * 5; }
            set { numOranges = value; }
        }

        public int OrangesEaten
        {
            get { return orangesEaten; }
            set { orangesEaten = value; }
        }

        public OrangeTree(int age, int height)
        {
            Age = age;
            this.height = height;
        }

        public void OneYearPasses()
        {
            age++;
        }

        public void EatOrange(int num)
        {
            if (num > NumOranges)
                throw new IndexOutOfRangeException();
            else
                orangesEaten += num;
        }
    }
}