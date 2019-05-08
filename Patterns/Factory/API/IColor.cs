namespace Factory.API
{
    public enum ColorType
    {
        Blue,
        Red,
    } 

    public interface IColor
    {
        string ColorName { get; }
    }
}
