namespace test
{
    public interface IMedia
    {

    }

    public interface IAudioTrack : IDynamic, IAudial
    {
    }

    public interface ITime : IMedia
    {
    }

    public interface IStatic : ITime
    {
    }

    public interface IPicture: IStatic, IVisual
    {
    }

    public interface IDynamic: ITime
    {
    }

    public interface ISerial: IVideo
    {
    }

    public interface IClip :IVideo
    {
    }

    public interface IMovie: IVideo
    {
    }

    public interface IAudial :IMedia
    {
    }

    public interface IVisual: IMedia
    {
    }

    public interface ITactile : IMedia
    {
    }

    public interface IVideo : IVisual, IDynamic
    {
    }

    public interface IAudio : IAudial, IDynamic
    {
    }

    public interface ISculpture : IStatic, IVisual, ITactile
    {
    }

}
