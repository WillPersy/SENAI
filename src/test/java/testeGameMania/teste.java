package testeGameMania;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

public class teste {
	
	private WebDriver driver;

	@Before
		public void ConfigurarTeste() {
		
			System.setProperty("webdriver.chrome.driver", "C:\\Users\\OI417392\\Desktop\\DEV\\chromedriver");
			driver = new ChromeDriver ();
			driver.get("http://localhost:4200/login");
			driver.manage().window().maximize();
			driver.findElement(By.xpath("//*[@id=\"menu\"]/a[2]")).click();
			
	}
	
	@Test
	public void teste () {
		
		WebElement campoEmail = driver.findElement(By.id("email"));
		WebElement campoSenha = driver.findElement(By.id("senha"));
		
		campoEmail.sendKeys("william@hotmail.com");
		campoSenha.sendKeys("william1234");
		
		driver.findElement(By.id("botao-enviar")).click();
		
		
	}
	
	@After
	public void EncerrarTeste ( ) {
		
	}
		
}
