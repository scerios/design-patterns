using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Mediator
{
    public class ArticlesDialogBox : DialogBox
    {
        public ListBox ArticlesListBox { get; set; }
        public TextBox TitleTextBox { get; set; }
        public Button SaveButton { get; set; }

        public ArticlesDialogBox()
        {
            ArticlesListBox = new ListBox(this);
            TitleTextBox = new TextBox(this);
            SaveButton = new Button(this); 
        }
        public override void Changed(UIControl uIControl)
        {
            if (uIControl == ArticlesListBox)
            {
                ArticleSelected();
            }
            else if(uIControl == TitleTextBox)
            {
                TitleChanged();
            }
        }

        public void SimulateUserInteraction()
        {
            ArticlesListBox.Selection = "Article 1";
            Console.WriteLine($"Textbox: { TitleTextBox.Content }");
            Console.WriteLine($"Button: { SaveButton.IsEnabled }");

            TitleTextBox.Content = "";
            Console.WriteLine($"Textbox: { TitleTextBox.Content }");
            Console.WriteLine($"Button: { SaveButton.IsEnabled }");

            TitleTextBox.Content = "Article 2";
            Console.WriteLine($"Textbox: { TitleTextBox.Content }");
            Console.WriteLine($"Button: { SaveButton.IsEnabled }");
        }

        private void ArticleSelected()
        {
            TitleTextBox.Content = ArticlesListBox.Selection;
            SaveButton.IsEnabled = true;
        }

        private void TitleChanged()
        {
            var content = TitleTextBox.Content;
            var isEmpty = content == null || content.Length == 0;
            SaveButton.IsEnabled = !isEmpty;
        }
    }
}
