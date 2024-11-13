using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<author>Oghenetejiri Peace Onosajerhe</author>
///<date>13, 11, 2024.</date>
///<version>1.0</version>

namespace SharedAlternateScreen
{
    ///<summary>
    /// The <c>SASDocumentMediaSource</c> class is a media source responsible for document sharing operation.
    ///</summary>
    ///<author>Oghenetejiri Peace Onosajerhe</author>
    ///<date>13, 11, 2024.</date>
    ///<version>1.0</version>

    public class SASDocumentMediaSource : SASMediaSource
    {

        /// <summary>
        /// <c>SASDocumentMediaSource</c> Constructor receives  two parameters to initialize the document media source and type properties.
        /// </summary>
        /// <param name="source"> string source of document media .</param>
        /// <param name="type"> string type of document media.</param>
        public SASDocumentMediaSource(string source, string type) : base(source, type)
        {

        }


        /// Implemented method to check for a valid media source.
        /// </summary>
        /// <param name="source">string source of Media  content</param>
        /// <returns>Boolean</returns>
        public override bool IsValidSource(string source)
        {
            return false;
        }

        /// Implemented method to check for a valid document media type.
        /// </summary>
        /// <param name="type">string source of document media  content</param>
        /// <returns>Boolean</returns>
        public override bool IsValidType(string type)
        {
            return false;
        }


    }
}
