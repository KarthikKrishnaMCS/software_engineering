using System;
namespace OfficeEquipment.Core
{
	/// <summary>
	/// Represents the device for printing documents
	/// </summary>
	public interface IPrinter
	{
        /// <summary>
        /// Prints the document text
        /// </summary>
        /// <param name="document">The text in the document</param>
        void Print(string document);
	}
}

