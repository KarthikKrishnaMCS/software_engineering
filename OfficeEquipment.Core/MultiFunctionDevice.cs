using System;
namespace OfficeEquipment.Core
{
    /// <summary>
    /// Multifunction device that supports both printing and scanning
    /// </summary>
    public sealed class MultiFunctionDevice : IPrinter, IScanner
    {
        private readonly IPrinter _printer;
        private readonly IScanner _scanner;

        /// <summary>
        /// Instance of the MultiFunctionDevice using composition
        /// </summary>
        /// <param name="printer">Component responsible for printing</param>
        /// <param name="scanner">Component responsible for scanning</param>
        /// <exception cref="ArgumentNullException">Error message if components are null</exception>
        public MultiFunctionDevice(IPrinter printer,IScanner scanner)
        {
            if (printer == null || scanner == null)
            {
                throw new ArgumentNullException("Components cannot be null");
            }
            _printer = printer;
            _scanner = scanner;
        }

        /// <summary>
        /// Printing task assigned to printer component
        /// </summary>
        /// <param name="document">The text to print</param>
        public void Print(string document)
        {
            _printer.Print(document);
        }

        /// <summary>
        /// Scanning task assigned to scanning component
        /// </summary>
        /// <returns>The scanned text</returns>
        public string Scan()
        {
            return _scanner.Scan();
        }
    }
}

