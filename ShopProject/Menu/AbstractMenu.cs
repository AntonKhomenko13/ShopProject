namespace ShopProject
{
    internal abstract class AbstractMenu
    {
        public bool Flag { get; set; } = true;

        public void Run()
        {
            Init();
            while (Flag == true)
            {
                Idle();
            }
            CleanUp();
        }
        protected abstract void CleanUp();
        protected abstract void Init();
        protected abstract void Idle();
    }
}