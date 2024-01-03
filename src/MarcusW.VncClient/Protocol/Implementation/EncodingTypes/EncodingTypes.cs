namespace MarcusW.VncClient.Protocol.Implementation.EncodingTypes;

public enum EncodingTypes
{
    // Frame encodings
    RawEncodingType,
    CopyRectEncodingType,
    TightEncodingType,
    ZlibEncodingType,
    ZrleEncodingType,
    // Pseudo encodings
    ContinuousUpdatesEncodingType,
    DesktopSizeEncodingType,
    ExtendedDesktopSizeEncodingType,
    FenceEncodingType,
    LastRectEncodingType,
    JpegFineGrainedQualityLevelEncodingType,
    JpegQualityLevelEncodingType,
    JpegSubsamplingLevelEncodingType,
}
