using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
 	 
namespace ClosedXML.Excel.Drawings
{
 	public interface IXLPicture
 	{
 	Stream ImageStream { get; set; }
 	 
 	List<IXLMarker> GetMarkers();
 	void AddMarker(IXLMarker marker);
 	 
 	long MaxHeight { get; set; }
 	long MaxWidth { get; set; }
 	long Width { get; set; }
 	long Height { get; set; }
 	long OffsetX { get; set; }
 	long OffsetY { get; set; }
 	long RawOffsetX { get; set; }
 	long RawOffsetY { get; set; }
    bool IsAbsolute { get; set; }

 	String Name { get; set; }

    /// <summary>
    /// Method for stream copying. Needed for .NET 3.5.
    /// </summary>
    /// <param name="input">Stream to be copied.</param>
    /// <param name="copy">Stream to be copied onto.</param>
    void StreamCopy(Stream input, Stream copy);
 	}
}	  
