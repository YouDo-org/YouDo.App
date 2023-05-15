using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouDo
{
    public class Hyperlink : Label
    {
        public static readonly BindableProperty UrlProperty =
            BindableProperty.Create(nameof(Url), typeof(string), typeof(Hyperlink), null);
        public static readonly BindableProperty m_TextColorProperty =
            BindableProperty.Create(nameof(m_TextColor), typeof(Color), typeof(Hyperlink), Colors.Blue);

        public string Url
        {
            get { return (string)GetValue(UrlProperty); }
            set { SetValue(UrlProperty, value); }
        }

        public Color m_TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        public Hyperlink()
        {
            TextDecorations = TextDecorations.Underline;
            TextColor = m_TextColor;
            GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () => await Browser.OpenAsync(Url))
            }) ;

            Console.WriteLine("Link opened!");
        }
    }
}
