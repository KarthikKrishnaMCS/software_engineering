using System;
namespace OfficeEquipment.Core
{
	/// <summary>
	/// Scanner for scanning documents
	/// </summary>
	public class SimpleScanner : IScanner
    {
        /// <summary>
        /// Scans a document and returns text
        /// </summary>
        /// <returns>String representing the scanned text</returns>
        public string Scan()
		{
			return "Scanned content";
		}
	}
}

