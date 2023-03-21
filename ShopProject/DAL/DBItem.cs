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
        public T GetById(int id)
        {
            T result = default(T);
            foreach (T item in Items)
            {
                if (item.ID == id)
                {
                    result = item;
                    break;
                }
            }
            return result;
        }
        public bool Update(T oldItem, T newItem)
        {
            bool result = false;
            newItem.ID = oldItem.ID;
            result = Delete(oldItem);
            Items.Add(newItem);
            return result;
        }
        public bool Delete(T item)
        {
            return Items.Remove(item);
        }

    }
}
