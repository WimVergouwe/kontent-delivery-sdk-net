﻿namespace KenticoCloud.Delivery.ImageOptimization
{
    /// <summary>
    /// Types of image compression.
    /// </summary>
    public enum ImageCompression
    {
        /// <summary>
        /// Allows the original data to be perfectly reconstructed from the compressed data.
        /// </summary>
        Lossless,

        /// <summary>
        /// Irreversible compression where partial data are discrarded.
        /// </summary>
        Lossy
    }
}