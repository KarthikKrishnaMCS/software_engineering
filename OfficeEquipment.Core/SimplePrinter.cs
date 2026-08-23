using System;
namespace OfficeEquipment.Core
{
    /// <summary>
    /// Basic printer that only supports printing
    /// </summary>
    public class SimplePrinter : IPrinter
	{
        /// <summary>
        /// Gets the content of the most recently printed document.
        /// </summary>
        public string LastPrintedDocument {get; private set;} = string.Empty;

        /// <summary>
        /// Prints the document and stores in memory
        /// </summary>
        /// <param name="document">The text in the document</param>
        public void Print(string document)
		{
            LastPrintedDocument = document;
		}
	}
}

