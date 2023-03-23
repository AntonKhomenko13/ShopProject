using ShopProject;

DB db = new DB();
SMServicesBLL smServicesBLL = new SMServicesBLL(db);
SMServivesPL smServivesPL = new SMServivesPL(smServicesBLL);
SalesManagerServicesMenu salesManagerServicesMenu = new SalesManagerServicesMenu(smServivesPL);
HrMenu hrMenu = new HrMenu();
ProductManagerMenu productManagerMenu = new ProductManagerMenu();
SalesManagerMenu salesManagerMenu = new SalesManagerMenu(salesManagerServicesMenu);
MainMenu mainMenu = new MainMenu(hrMenu, productManagerMenu, salesManagerMenu);
mainMenu.Run();