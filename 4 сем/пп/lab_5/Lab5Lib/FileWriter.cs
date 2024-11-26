namespace Lab5Lib 
{
    //логика для метода сейв
    public class FileWriter : IWriter 
    {
        private string _fileName;

        public string FileName 
        {
            get => _fileName;
        }

        public FileWriter(string? filename = null) 
        {
            this._fileName = filename ?? Constant.FileName;
        }

        public string? Save(string? message)
        {
            File.WriteAllText(this._fileName, message);
            return this._fileName;
        }
    }
}
