
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
    /// The <c>SASMediaSource</c> class is an abstrack class responsible for the type of media screen invoked.
    /// It retrieves content from the specified media source being shared.
    ///</summary>
    ///<author>Oghenetejiri Peace Onosajerhe</author>
    ///<date>13, 11, 2024.</date>
    ///<version>1.0</version>

    public abstract class SASMediaSource
    {

        ///<summary>
        ///Source: property of the media source
        ///</summary>
        public string Source { get; private set; }

        ///<summary>
        ///Type: property of the media type
        ///</summary>
        public string Type { get; private set; }

        /// <summary>
        /// <c>SASMediaSource</c> Constructor receives  two parameters to initialize the media source and type properties.
        /// </summary>
        /// <param name="source"> string source of Media.</param>
        /// <param name="type"> string type of Media.</param>
        public SASMediaSource(string source, string type)
        {
            Source = source;
            Type = type;
        }

        /// <summary>
        /// Method to reset the value of the Source property.
        /// </summary>
        /// <param name="source">string source of Media content.</param>
        public void ResetSource(string source)
        {
            Source = source;
        }

        /// <summary>
        /// Method to reset the value of the Type property.
        /// </summary>
        /// <param name="type">string type of Media.</param>
        public void ResetType(string type)
        {
            Type = type;
        }

        /// <summary>
        /// Abstract method to check for a valid media source.
        /// All inherited class must to implement.
        /// </summary>
        /// <param name="source">string source of Media  content</param>
        /// <returns>Boolean</returns>
        public abstract bool IsValidSource(string source);

        /// <summary>
        /// Abstract method to check for a valid media type.
        /// All inherited class must to implement.
        /// </summary>
        /// <param name="type">string type of Media </param>
        /// <returns>Boolean</returns>
        public abstract bool IsValidType(string type);

        public override string ToString()
        {
            return $"Media Source: {Source}, Type: {Type}";
        }

    }

}
