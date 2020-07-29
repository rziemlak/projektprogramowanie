using explorerNET;
using NUnit.Framework;
using System.Threading;

/// <summary>
/// Przestrzeń nazw zawierająca testy jednostkowe programu.
/// </summary>
namespace NUnitTest
{
    /// <summary>
    /// Testy jednostkowe paska postępu w oknie głównym aplikacji.
    /// </summary>
    [TestFixture, Apartment(ApartmentState.STA)]
    public class Tests_ProgressBar
    {
        /// <summary>
        /// Instancja okna, które podlega testowaniu.
        /// </summary>
        Form1 form;

        /// <summary>
        /// Metoda konfigurująca proces testowania.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            form = new Form1();
        }

        /// <summary>
        /// Test jednostkowy sprawdzający poprawność wartości dolnego zakresu paska postępu.
        /// </summary>
        [Test]
        public void MinimumValueTest()
        {
            var bar = form.getProgressBar();
            Assert.That(bar.Minimum, Is.EqualTo(0));
        }

        /// <summary>
        /// Test jednostkowy sprawdzający poprawność wartości górnego zakresu paska postępu.
        /// </summary>
        [Test]
        public void MaximumValueTest()
        {
            var bar = form.getProgressBar();
            Assert.That(bar.Maximum, Is.EqualTo(100));
        }

        /// <summary>
        /// Test jednostkowy sprawdzający początkową wartość paska postępu.
        /// </summary>
        [Test]
        public void ValueTest()
        {
            var bar = form.getProgressBar();
            Assert.That(bar.Value, Is.EqualTo(0));
        }
    }
}