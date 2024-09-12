
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

//Cargar pagina


WebDriver driver = new ChromeDriver();
driver.Navigate().GoToUrl("https://novofarma-web-test.azurewebsites.net/account/login");
driver.Manage().Window.Maximize();

//ingreso de login 
//Thread.Sleep(10000);
WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

IWebElement _email = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("email")));
_email.SendKeys("luis.riquelme@novofarma.com");

//driver.FindElement(By.Id("email")).SendKeys("luis.riquelme@novofarma.com");

Thread.Sleep(6000);
driver.FindElement(By.Id("password")).SendKeys("LRiquelme2024@@");

driver.FindElement(By.Id("btnLogin")).Click();
Thread.Sleep(9000);


//Seleccion de laboratorio


IWebElement LAB = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Laboratory_Id")));
LAB.Click();
LAB.SendKeys("PFIZER");

Thread.Sleep(3000);
driver.FindElement(By.XPath("//P")).Click();

    //Seleccion del menu 

   
IWebElement menu = driver.FindElement(By.XPath("//nav[2]/button/div"));
menu.Click();

Thread.Sleep(3000);


IWebElement cargaPreaviso = driver.FindElement(By.LinkText("Carga de Preaviso"));
cargaPreaviso.Click();


Thread.Sleep(3000);


//Seleccion Tipo de Preaviso

//IWebElement LAB2 = driver.FindElement(By.Id("Purch_Order_Type_Id"));
//LAB2.Click();

IWebElement LAB2 = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Purch_Order_Type_Id")));
LAB2.Click();


IWebElement Imp = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//p[contains(.,'Importaciones')]")));
Imp.Click();


// Seleccionamos Proveedor


IWebElement Cliente = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Provider_Id")));

Cliente.SendKeys("PFIZER");
IWebElement Cliente1 = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//p[contains(.,'PFIZER SERVICE CO BVBA (BE9/TR... (31-0100010186)')]")));
Cliente1.Click();



IWebElement FechaEstimada = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(//*[name()='svg'][@role='img'])[32]")));
FechaEstimada.Click();

IWebElement FechaEstimada1 = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//p[normalize-space()='14']")));
FechaEstimada1.Click();


IWebElement Referencia = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Delivery_Number_Id")));
Referencia.SendKeys("272727272");
Referencia.SendKeys(Keys.Tab);

//driver.FindElement(By.Id("btn_add_line")).Click();


IWebElement Boton = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("btn_add_line")));
Boton.Click();


// Ingreso de Producto
// skdlskdskddj


IWebElement Producto = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Item_Id")));

Producto.SendKeys("FF000000232");

IWebElement Producto1 = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[11]/div[1]/div[1]/div[1]/p[1]")));
Producto1.Click();
//button[@id='btn_add_line']//span[@class='mud-fab-label']//*[name()='svg']

//p[class= 'mud-typography mud-typography-body1']
//input[@id='Delivery_Number_Id']
//div[3]/div[2]

//try
//{
//    int[] myNumbers = { 1, 2, 3 };
//    Console.WriteLine(myNumbers[10]);
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);

//Console.WriteLine("Error se presento un error");

//}



//driver.FindElement(By.XPath("//P")).Click();
//Thread.Sleep(3000);