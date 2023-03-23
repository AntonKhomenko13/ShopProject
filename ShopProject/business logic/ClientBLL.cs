namespace ShopProject.business_logic
{
    internal class ClientBLL
    {
        DB db;

        public ClientBLL(DB db)
        {
            this.db = db;
        }
        public void CreateClient(string clientFirstName, string clientLastName, int clientAge)
        {
            Client client = new Client(clientFirstName, clientLastName, clientAge);
            DBItem<Client> dbClient = db.DBClient;
            dbClient.AddItem(client);
        }
        public Client GetByID(int id)
        {
            Client result = default(Client);
            result = db.DBClient.GetById(id);
            return result;
        }
        public List<Client> GetAllClients()
        {
            return db.DBClient.Items;
        }
        public bool UpDateClient(Client oldItem, string clientFirstName, string clientLastName, int clientAge)
        {
            bool result = false;
            Client newItem = new Client(clientFirstName, clientLastName, clientAge);
            result = db.DBClient.Update(oldItem, newItem);
            return result;
        }
        public bool DeleteClient(Client client)
        {
            bool result = false;
            result = db.DBClient.Delete(client);
            return result;
        }
    }
}
