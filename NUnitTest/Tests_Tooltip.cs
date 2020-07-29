using explorerNET;
using NUnit.Framework;
using System.Threading;

/// <summary>
/// Przestrzeń nazw zawierająca testy jednostkowe programu.
/// </summary>
namespace NUnitTest
{
    /// <summary>
    /// Testy jednostkowe "tooltip-a" - nazwy wyświetlanej po najechaniu na kontrolkę.
    /// </summary>
    [TestFixture, Apartment(ApartmentState.STA)]
    public class Tests_Tooltip
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
        /// Test jednostkowy sprawdzający wybrany "tooltip".
        /// </summary>
        [Test]
        public void SprawdzTooltip()
        {
            var button = form.getRefreshButton();
            Assert.That(button.ToolTipText, Is.EqualTo("Odśwież"));
        }
    }
}
