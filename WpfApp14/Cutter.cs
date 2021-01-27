namespace WpfApp14
{
    class Cutter
    {
        public string Text { get; set; }
        public Cutter (string text)
        {
            Text = text;
        }

        public string Cut(string begin, string end)
        {
            if (Text.IndexOf(begin) >= 0)
            {
                Text = Text.Remove(0, Text.IndexOf(begin) + begin.Length);
                string result = Cut(0, Text.IndexOf(end));
                return result;
            }
            else
                return "Невоможно выполнить операцию. Индекс вне границ текста";
        }
        public string Cut(int begin, int end)
        {
            if ( Text.Length <begin || end>Text.Length || end<0 ||begin<0)
            {
                return "Невоможно выполнить операцию. Индекс вне границ текста";
            }
            else
            {
                string result;
                result = Text.Remove(end);
                result = result.Remove(0, begin);
                return result;
            }
        }
    }
}
