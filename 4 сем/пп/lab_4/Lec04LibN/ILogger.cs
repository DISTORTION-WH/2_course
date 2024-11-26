namespace Lec04LibN
{
    public interface ILogger
    {
        //методы
        void start(string title);
        void log(string message);
        void stop();
    }
}
