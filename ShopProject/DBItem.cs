namespace ShopProject
{
    internal class DBItem<T> where T : IID
    {
        private int counter = 1;
        public List<T> Items { get; set; }

        public DBItem()
        {
            Items = new List<T>();
        }
        public void AddItem(T item)
        {
            item.ID = counter++;
            Items.Add(item);
        }
    }
}
