using Microsoft.VisualBasic;
using NUnit.Framework;
using NUnit.Framework.Internal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SeleniumLearning
{
    public class Tests
    {

        //Si ejecutas los tests, el orden de ejecución sería:
        //[OneTimeSetUp] → una vez al inicio
        //[SetUp] → antes de cada[Test]
        //[Test] → el método de prueba
        //[TearDown] → después de cada[Test]
        //[OneTimeTearDown] → una vez al final

        /*
         👉 Escribe un mensaje en la salida de progreso (el panel o consola donde se muestran los logs del test runner).
         A diferencia de Console.WriteLine(), este método:
         Siempre muestra el mensaje, incluso cuando las pruebas se ejecutan desde herramientas como Visual Studio Test Explorer, GitHub Actions o CI/CD.
         Es seguro de usar en NUnit, ya que el framework captura la salida correctamente.
        */

        // Se ejecuta una sola vez ANTES de todos los tests
        // Ideal para abrir conexiones o configurar recursos globales
        [OneTimeSetUp]
        public void Incializa1SolaVez()
        {            
        }

        //El atributo [SetUp] se usa para marcar un método que se ejecutará antes de cada prueba ([Test]).
        // Normalmente se usa para inicializar datos o preparar el entorno de prueba.

        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("Setup method execution");
        }

        //El atributo [Test] marca un método de prueba:
        //Es una función que contiene unidades de verificación(normalmente con Assert) para comprobar que el resultado del código es el esperado.

        [Test]
        public void Test1()
        {
            TestContext.Progress.WriteLine("This is test 1");
        }
        [Test]
        public void Test2()
        {
            TestContext.Progress.WriteLine("This is test 2");
        }

        // Se ejecuta después de CADA test
        // Ideal para liberar memoria o cerrar archivos.
        [TearDown]
        public void CloseBrowser()
        {
            TestContext.Progress.WriteLine("Tear dow method");
        }

        // Se ejecuta una sola vez DESPUÉS de todos los tests
        // Aquí podrías cerrar conexiones globales o liberar recursos grandes
        [OneTimeTearDown]
        public void ConfiguracionGlobal()
        {
        }
    }
}