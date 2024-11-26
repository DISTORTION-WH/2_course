namespace Lab5Lib 
{
    //вайб по функционалу не изменяя главный классс
    public class Decorator : IWriter 
    {
        protected IWriter? _writer;

        public Decorator(IWriter? writer) //обьект врайтера, который будем оборачивать в декоратор
        {
            this._writer = writer;
        }

        public virtual string? Save(string? message) => _writer?.Save(message); //вывод в файликс
    }
}
