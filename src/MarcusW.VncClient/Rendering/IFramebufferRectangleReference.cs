namespace MarcusW.VncClient.Rendering;

public interface IFramebufferRectangleReference : IFramebufferReference
{
    /// <summary>
    /// Called after a rectangle has been drawn to the framebuffer. Only called if UpdateByRectangle is present in the render flags.
    /// </summary>
    /// <param name="rect">An object representing the height, width, and location of the rectangle.</param>
    public void UpdateRectangle(Rectangle rect);
}
