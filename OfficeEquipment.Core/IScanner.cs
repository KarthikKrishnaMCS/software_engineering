using System;
namespace OfficeEquipment.Core
{
    /// <summary>
    /// Represents the device for scanning documents
    /// </summary>
    public interface IScanner
	{
        /// <summary>
        /// Scans the document text
        /// </summary>
        /// <returns>String representing the scanned text</returns>
        string Scan();
	}
}

