using Help_Jacob_SOLID.Interfaces;

namespace Help_Jacob_SOLID.Classes
{
    /// <summary>
    /// Reprecents a class for converting a message from text to html.
    /// </summary>
    public class HTMLConverter : IConverter
    {
        public string Convert(string messageBody)
        {
            return "<html><body>" + messageBody + "</html></body>";
        }
    }
}
