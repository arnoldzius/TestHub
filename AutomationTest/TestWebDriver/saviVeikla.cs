using System;

public class saviVeikla
{
	public saviVeikla()
	{

         private static IWebDriver _driver;

    [OneTimeSetUp]
    public void SetUp()
    {
        _driver = new ChromeDriver();
        _driver.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
    }

    [OneTimeTearDown]
    public static void TearDown()
    {
        _driver.Close();
    }


    [TestCase("2", "2", "4", TestName = "2 + 2 = 4")]
    [TestCase("-5", "3", "-2", TestName = "-5 + 3 = -2")]
    [TestCase("a", "b", "NaN", TestName = "a + b = NaN")]
    public static void TestSumBlock(string firstInput, string secondInput, string result)
    {
        IWebElement firstInputField = _driver.FindElement(By.Id("sum1"));
        IWebElement secondInputField = _driver.FindElement(By.Id("sum2"));
        firstInputField.Clear();
        firstInputField.SendKeys(firstInput);
        secondInputField.Clear();
        secondInputField.SendKeys(secondInput);
        IWebElement getTotalButton = _driver.FindElement(By.XPath("//*[@id='gettotal']/button"));
        getTotalButton.Click();
        IWebElement actualResult = _driver.FindElement(By.Id("displayvalue"));
        Assert.AreEqual(result, actualResult.Text, "Sum is Incorrect");

    }
}
