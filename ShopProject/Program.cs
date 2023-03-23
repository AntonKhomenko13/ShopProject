using ShopProject;

DB db = new DB();
SMServicesBLL smServicesBLL = new SMServicesBLL(db);
SMServivesPL smServivesPL = new SMServivesPL(smServicesBLL);
SalesManagerServicesMenu salesManagerServicesMenu = new SalesManagerServicesMenu(smServivesPL);
SalesManagerMenu salesManagerMenu = new SalesManagerMenu(salesManagerServicesMenu);
HrMenu hrMenu = new HrMenu();
MainMenu mainMenu = new MainMenu(hrMenu, salesManagerMenu);
mainMenu.Run();