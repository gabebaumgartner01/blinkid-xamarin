﻿namespace Microblink.Forms.Core.Recognizers
{
    /// <summary>
    /// Recognizer which can scan back side of Brunei national Residence Permit cards.
    /// </summary>
    public interface IBruneiResidencePermitBackRecognizer : IRecognizer
    {
        
        /// <summary>
        /// Defines if glare detection should be turned on/off.
        /// 
        ///  
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool DetectGlare { get; set; }
        
        /// <summary>
        /// Defines if address of Brunei Residence Permit card owner should be extracted.
        /// 
        ///  
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractAddress { get; set; }
        
        /// <summary>
        /// Defines if date of issue of Brunei Residence Permit card should be extracted.
        /// 
        ///  
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractDateOfIssue { get; set; }
        
        /// <summary>
        /// Defines if the race of Brunei Residence Permit card owner should be extracted.
        /// 
        ///  
        ///
        /// By default, this is set to 'true'
        /// </summary>
        bool ExtractRace { get; set; }
        
        /// <summary>
        /// Property for setting DPI for full document images
        /// Valid ranges are [100,400]. Setting DPI out of valid ranges throws an exception
        /// 
        ///  
        ///
        /// By default, this is set to '250'
        /// </summary>
        uint FullDocumentImageDpi { get; set; }
        
        /// <summary>
        /// Image extension factors for full document image.
        /// 
        /// @see ImageExtensionFactors
        ///  
        ///
        /// By default, this is set to '{0.0f, 0.0f, 0.0f, 0.0f}'
        /// </summary>
        IImageExtensionFactors FullDocumentImageExtensionFactors { get; set; }
        
        /// <summary>
        /// Sets whether full document image of ID card should be extracted.
        /// 
        ///  
        ///
        /// By default, this is set to 'false'
        /// </summary>
        bool ReturnFullDocumentImage { get; set; }
        

        /// <summary>
        /// Gets the result.
        /// </summary>
        IBruneiResidencePermitBackRecognizerResult Result { get; }
    }

    /// <summary>
    /// Result object for IBruneiResidencePermitBackRecognizer.
    /// </summary>
    public interface IBruneiResidencePermitBackRecognizerResult : IRecognizerResult {
        
        /// <summary>
        /// The address of Brunei Residence Permit card owner. 
        /// </summary>
        string Address { get; }
        
        /// <summary>
        /// The date of issue of Brunei Residence Permit card. 
        /// </summary>
        IDate DateOfIssue { get; }
        
        /// <summary>
        /// full document image if enabled with returnFullDocumentImage property. 
        /// </summary>
        Xamarin.Forms.ImageSource FullDocumentImage { get; }
        
        /// <summary>
        /// The data extracted from the machine readable zone. 
        /// </summary>
        IMrzResult MrzResult { get; }
        
        /// <summary>
        /// The race of Brunei Residence Permit card owner. 
        /// </summary>
        string Race { get; }
        
    }
}