using System;
using Xunit;
using OfficeEquipment.Core;

namespace OfficeEquipment.Tests
{
    /// <summary>
    /// Unit tests to verify the functioning of office equipment devices
    /// </summary>
    public class DeviceTests
    {
        /// <summary>
        /// SimplePrinter test
        /// </summary>
        [Fact]
        public void SimplePrinter_Test()
        {
            var printer = new SimplePrinter();
            string doc = "Sample Doc";

            printer.Print(doc);

            Assert.Equal(doc,printer.LastPrintedDocument);
        }

        /// <summary>
        /// SimpleScanner test
        /// </summary>
        [Fact]
        public void SimpleScanner_Test()
        {
            var scanner = new SimpleScanner();

            var result = scanner.Scan();

            Assert.Equal("Scanned content",result);
        }

        /// <summary>
        /// MultiFunctionDevice test
        /// </summary>
        [Fact]
        public void MultiFunctionDevice_Test()
        {
            var printer = new SimplePrinter();
            var scanner = new SimpleScanner();

            var multiFunctionDevice = new MultiFunctionDevice(printer, scanner);
            string doc = "Sample Doc";

            multiFunctionDevice.Print(doc);
            string result = multiFunctionDevice.Scan();

            Assert.Equal(doc,printer.LastPrintedDocument);
            Assert.Equal("Scanned content",result);
        }
    }
}
