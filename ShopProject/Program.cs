using ShopProject;
using ShopProject.business_logic;
using ShopProject.Menu;
using ShopProject.presentation_layer;

DB db = new DB();

SMServicesBLL smServicesBLL = new SMServicesBLL(db);
ClientBLL clientBLL = new ClientBLL(db);
OrderBLL orderBLL = new OrderBLL(db);

SMServivesPL smServivesPL = new SMServivesPL(smServicesBLL);
ClientPL clientPL = new ClientPL(clientBLL);
OrderPL orderPL = new OrderPL(orderBLL);

SalesManagerServicesMenu salesManagerServicesMenu = new SalesManagerServicesMenu(smServivesPL);
OrderCRUDMenu orderCRUDMenu = new OrderCRUDMenu(orderPL);
ClientCRUDMenu clientCRUDMenu = new ClientCRUDMenu(clientPL);

HrMenu hrMenu = new HrMenu();
ProductManagerMenu productManagerMenu = new ProductManagerMenu();
SalesManagerMenu salesManagerMenu = new SalesManagerMenu(clientCRUDMenu, orderCRUDMenu, salesManagerServicesMenu);

MainMenu mainMenu = new MainMenu(hrMenu, productManagerMenu, salesManagerMenu);
mainMenu.Run();