namespace BTCuoiKy
{
    public partial class Dictionary : Form
    {

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Node first;
        private Node last;
        private int size;

        public Dictionary()
        {
            InitializeComponent();
            first = null;
            last = null;
            size = 0;
        }



        public class Node
        {
            public string Word { get; set; }
            public string Type { get; set; }
            public List<string> Meanings { get; set; }
            public ExampleNode Examples { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }

            public Node(string word, string type, List<string> meanings)
            {
                Word = word;
                Type = type;
                Meanings = meanings;
                Examples = null;
                Next = null;
                Previous = null;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------
        //Note (word) section
        private void PrintLastestNodes()
        {
            WordBox.Text += first.Word + " <" + first.Type + "> \n";
        }
        //Print all meanings of the word in the meaning list
        private void PrintMeanings(string word)
        {
            MeaningBox.Clear();
            Node current = first;
            for (int i = 0; i < size; i++)
            {
                if (current.Word == word)
                {
                    for (int j = 0; j < current.Meanings.Count; j++)
                    {
                        MeaningBox.Text += current.Meanings[j] + " ";
                    }
                    break;
                }
                current = current.Next;
            }
        }

        // Search for node and print out its information
        private void SearchNode(string word)
        {
            Node current = first;
            for (int i = 0; i < size; i++)
            {
                if (current.Word == word)
                {
                    TypeBox.Text = current.Type;
                    WordBox.Text = current.Word + " <" + current.Type + "> \n";
                    for (int j = 0; j < current.Meanings.Count; j++)
                    {
                        MeaningBox.Text += current.Meanings[j] + " ";
                    }
                    ExampleNode currentExample = current.Examples;
                    while (currentExample != null)
                    {
                        ExamplesBox.Text += currentExample.Example + "\n";
                        currentExample = currentExample.Next;
                    }
                    break;
                }
                current = current.Next;
            }

        }
        //------------------------------------------------------------------------------------------------------------------------
        public void AddWord(string word, string type, List<string> meanings)
        {
            Node newNode = new Node(word, type, meanings);
            if (first == null)
            {
                first = newNode;
                last = newNode;
            }
            else
            {
                newNode.Next = first;
                first.Previous = newNode;
                first = newNode;
                last.Next = newNode;
                newNode.Previous = last;
            }
            size++;
        }
        //Save the new word to txt file in E:\OneDrive - IT software\UUTE\Data bla bla\Final\1\Winform\text\Dictionary.txt
        public void SaveWord()
        {
            string path = @"D:\Cpp\C-C++\WinformProject\BTCuoiKy\data.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(first.Word);
                sw.WriteLine(first.Type);
                for (int i = 0; i < first.Meanings.Count; i++)
                {
                    sw.WriteLine(first.Meanings[i]);
                }
                sw.WriteLine("Examples:");
                ExampleNode current = first.Examples;
                while (current != null)
                {
                    sw.WriteLine(current.Example);
                    current = current.Next;
                }
                //Write the time adding the word
                sw.WriteLine("Time: " + DateTime.Now.ToString());
                sw.WriteLine("--------------------------------------------------");
            }
        }

        //remove word
        public void RemoveWord(string word)
        {
            Node current = first;
            for (int i = 0; i < size; i++)
            {
                if (current.Word == word)
                {
                    if (current == first)
                    {
                        first = first.Next;
                        first.Previous = null;
                    }
                    else if (current == last)
                    {
                        last = last.Previous;
                        last.Next = null;
                    }
                    else
                    {
                        current.Previous.Next = current.Next;
                        current.Next.Previous = current.Previous;
                    }
                    size--;
                    break;
                }
                current = current.Next;
            }
        }
        //modify word
        public void ModifyWord(string word, string newWord, string newType)
        {
            Node current = first;
            for (int i = 0; i < size; i++)
            {
                if (current.Word == word)
                {
                    current.Word = newWord;
                    current.Type = newType;
                    break;
                }
                current = current.Next;
            }
        }
        //print all words and their type in the list
        public void PrintAllWords()
        {
            WordBox.Clear();
            Node current = first;
            for (int i = 0; i < size; i++)
            {
                WordBox.Text += current.Word + " <" + current.Type + "> \n";
                current = current.Next;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------
        //Meaning section
        // Add meaning to the word
        public void AddMeaning(string word, string meaning)
        {
            Node current = first;
            for (int i = 0; i < size; i++)
            {
                if (current.Word == word)
                {
                    current.Meanings.Add(meaning);
                    break;
                }
                current = current.Next;
            }
        }
        // Remove the nth meaning from the word
        public void RemoveMeaning(string word, int n)
        {
            Node current = first;
            for (int i = 0; i < size; i++)
            {
                if (current.Word == word)
                {
                    current.Meanings.RemoveAt(n - 1);
                    break;
                }
                current = current.Next;
            }

        }
        //------------------------------------------------------------------------------------------------------------------------
        //Example section
        public class ExampleNode
        {
            public string Example { get; set; }
            public ExampleNode Next { get; set; }
            public ExampleNode Previous { get; set; }

            public ExampleNode(string example)
            {
                Example = example;
                Next = null;
                Previous = null;
            }
        }
        // Add example to the word
        public void AddExample(string word, string example)
        {
            Node current = first;
            for (int i = 0; i < size; i++)
            {
                if (current.Word == word)
                {
                    ExampleNode newNode = new ExampleNode(example);
                    if (current.Examples == null)
                    {
                        current.Examples = newNode;
                    }
                    else
                    {
                        ExampleNode temp = current.Examples;
                        while (temp.Next != null)
                        {
                            temp = temp.Next;
                        }
                        temp.Next = newNode;
                        newNode.Previous = temp;
                    }
                    break;
                }
                current = current.Next;
            }
        }
        // Remove the nth example from the word
        public void RemoveExample(string word, int n)
        {
            Node current = first;
            for (int i = 0; i < size; i++)
            {
                if (current.Word == word)
                {
                    ExampleNode temp = current.Examples;
                    for (int j = 0; j < n - 1; j++)
                    {
                        temp = temp.Next;
                    }
                    if (temp == current.Examples)
                    {
                        current.Examples = current.Examples.Next;
                        current.Examples.Previous = null;
                    }
                    else if (temp.Next == null)
                    {
                        temp.Previous.Next = null;
                    }
                    else
                    {
                        temp.Previous.Next = temp.Next;
                        temp.Next.Previous = temp.Previous;
                    }
                    break;
                }
                current = current.Next;
            }
        }
        //print all examples of the word
        public void PrintExamples(Node word)
        {
            ExamplesBox.Clear();
            ExampleNode current = word.Examples;
            while (current != null)
            {
                ExamplesBox.Text += current.Example + "\n";
                current = current.Next;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------
        private void SearchBox_Enter(object sender, EventArgs e)
        {
            if (SearchBox.Text == "Search for...")
            {
                SearchBox.Text = "";
                SearchBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void SearchBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchBox.Text))
            {
                SearchBox.Text = "Search for...";
                SearchBox.ForeColor = Color.Gray;
            }
            if (SearchBox.Text == "Search for..." || SearchBox.Text == "")
            {
                SearchBtn.Enabled = false;
                AddBtn.Enabled = false;
            }
            else
            {
                SearchBtn.Enabled = true;
                AddBtn.Enabled = true;
            }
        }

        private void TypeBox_Enter(object sender, EventArgs e)
        {
            if (TypeBox.Text == "Loai tu")
            {
                TypeBox.Text = "";
                TypeBox.ForeColor = SystemColors.WindowText;
            }

        }

        private void TypeBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TypeBox.Text))
            {
                TypeBox.Text = "Loai tu";
                TypeBox.ForeColor = Color.Gray;
            }
            if (TypeBox.Text == "Loai tu" || TypeBox.Text == "")
            {
                AddBtn.Enabled = false;
            }
            else
            {
                AddBtn.Enabled = true;
            }
        }


        private void NewWordBox_Enter(object sender, EventArgs e)
        {
            if (NewWordBox.Text == "Change to")
            {
                NewWordBox.Text = "";
                NewWordBox.ForeColor = SystemColors.WindowText;
            }

        }

        private void NewWordBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NewWordBox.Text))
            {
                NewWordBox.Text = "Change to";
                NewWordBox.ForeColor = Color.Gray;
            }
            if (MeaningBox.Text == "Dinh Nghia" || MeaningBox.Text == "")
            {
                ModifyBtn.Enabled = false;
            }
            else
            {
                ModifyBtn.Enabled = true;
            }
        }

        private void RemoveExampleIndex_Enter(object sender, EventArgs e)
        {
            if (RemoveMeaningIndex.Text == "index")
            {
                RemoveMeaningIndex.Text = "";
                RemoveMeaningIndex.ForeColor = SystemColors.WindowText;
            }
            if (ExamplesBox.Text == "Vi Du" || ExamplesBox.Text == "")
            {
                AddBtn.Enabled = false;
            }
            else
            {
                AddBtn.Enabled = true;
            }
        }

        private void RemoveExampleIndex_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RemoveMeaningIndex.Text))
            {
                RemoveMeaningIndex.Text = "index";
                RemoveMeaningIndex.ForeColor = Color.Gray;
            }
        }

        private void RemoveMeaningIndex_Enter(object sender, EventArgs e)
        {
            if (RemoveMeaningIndex.Text == "index")
            {
                RemoveMeaningIndex.Text = "";
                RemoveMeaningIndex.ForeColor = SystemColors.WindowText;
            }
        }

        private void RemoveMeaningIndex_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RemoveMeaningIndex.Text))
            {
                RemoveMeaningIndex.Text = "index";
                RemoveMeaningIndex.ForeColor = Color.Gray;
            }
        }

        private void NewMeaningBox_Enter(object sender, EventArgs e)
        {
            if (NewMeaningBox.Text == "Meaning")
            {
                NewMeaningBox.Text = "";
                NewMeaningBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void NewMeaningBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NewMeaningBox.Text))
            {
                NewMeaningBox.Text = "Meaning";
                NewMeaningBox.ForeColor = Color.Gray;
            }
        }

        private void MeaningBox_Enter(object sender, EventArgs e)
        {
            if (MeaningBox.Text == "Dinh Nghia")
            {
                MeaningBox.Text = "";
                MeaningBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void MeaningBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MeaningBox.Text))
            {
                MeaningBox.Text = "Dinh Nghia";
                MeaningBox.ForeColor = Color.Gray;
            }
        }

        private void ExamplesBox_Enter(object sender, EventArgs e)
        {
            if (ExamplesBox.Text == "Vi Du")
            {
                ExamplesBox.Text = "";
                ExamplesBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void ExamplesBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ExamplesBox.Text))
            {
                ExamplesBox.Text = "Vi Du";
                ExamplesBox.ForeColor = Color.Gray;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------

        private void Dictionary_Paint(object sender, PaintEventArgs e)
        {
            int y = 190;
            int startX = 30;
            int endX = 930;

            using (Pen pen = new Pen(Color.Black))
            {
                e.Graphics.DrawLine(pen, startX, y, endX, y);
            }
        }

        // clear
        private void ClearBox()
        {
            SearchBox.Text = "Search for...";
            SearchBox.ForeColor = Color.Gray;
            TypeBox.Text = "Loai tu";
            TypeBox.ForeColor = Color.Gray;
            MeaningBox.Text = "Dinh Nghia";
            MeaningBox.ForeColor = Color.Gray;
            ExamplesBox.Text = "Vi Du";
            ExamplesBox.ForeColor = Color.Gray;
            NewWordBox.Text = "Change to";
            NewWordBox.ForeColor = Color.Gray;
            NewMeaningBox.Text = "Meaning";
            NewMeaningBox.ForeColor = Color.Gray;
            RemoveMeaningIndex.Text = "index";
            RemoveMeaningIndex.ForeColor = Color.Gray;
            RemoveExampleIndex.Text = "index";
            RemoveExampleIndex.ForeColor = Color.Gray;
            PrintAllWords();
        }
        //------------------------------------------------------------------------------------------------------------------------
        //UX section
        //disable button when the words in box is the default text or empty


        private void TypeBox_TextChanged(object sender, EventArgs e)
        {
            if (TypeBox.Text == "Loai tu" || TypeBox.Text == "")
            {
                AddBtn.Enabled = false;
            }
            else
            {
                AddBtn.Enabled = true;
            }
        }

        private void MeaningBox_TextChanged(object sender, EventArgs e)
        {
            if (MeaningBox.Text == "Dinh Nghia" || MeaningBox.Text == "")
            {
                AddBtn.Enabled = false;
            }
            else
            {
                AddBtn.Enabled = true;
            }
        }

        private void ExamplesBox_TextChanged(object sender, EventArgs e)
        {
            if (ExamplesBox.Text == "Vi Du" || ExamplesBox.Text == "")
            {
                AddBtn.Enabled = false;
            }
            else
            {
                AddBtn.Enabled = true;
            }
        }

        private void NewWordBox_TextChanged(object sender, EventArgs e)
        {
            if (NewWordBox.Text == "Change to" || NewWordBox.Text == "")
            {
                ModifyBtn.Enabled = false;
            }
            else
            {
                ModifyBtn.Enabled = true;
            }
        }

        private void NewMeaningBox_TextChanged(object sender, EventArgs e)
        {
            if (NewMeaningBox.Text == "Meaning" || NewMeaningBox.Text == "")
            {
                ModifyBtn.Enabled = false;
            }
            else
            {
                ModifyBtn.Enabled = true;
            }
        }

        private void RemoveMeaningIndex_TextChanged(object sender, EventArgs e)
        {
            if (RemoveMeaningIndex.Text == "index" || RemoveMeaningIndex.Text == "")
            {
                DeletaBtn.Enabled = false;
            }
            else
            {
                DeletaBtn.Enabled = true;
            }
        }

        private void RemoveExampleIndex_TextChanged(object sender, EventArgs e)
        {
            if (RemoveExampleIndex.Text == "index" || RemoveExampleIndex.Text == "")
            {
                RemoveExampleBtn.Enabled = false;
            }
            else
            {
                RemoveExampleBtn.Enabled = true;
            }
        }


        //------------------------------------------------------------------------------------------------------------------------

        //Btn section

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string word = SearchBox.Text;
            word = word.ToLower();
            //clear boxes before print
            TypeBox.Clear();
            MeaningBox.Clear();
            ExamplesBox.Clear();
            PrintAllWords();
            SearchNode(word);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string word = SearchBox.Text;
            word = word.ToLower();
            string type = TypeBox.Text;
            type = type.ToLower();
            List<string> meanings = new List<string>();
            meanings.Add(MeaningBox.Text);
            AddWord(word, type, meanings);
            // add examples
            string example = ExamplesBox.Text;
            AddExample(word, example);
            PrintLastestNodes();
            SaveWord();
        }

        private void DeletaBtn_Click(object sender, EventArgs e)
        {
            //remove word
            string word = SearchBox.Text;
            word = word.ToLower();
            RemoveWord(word);
            PrintAllWords();
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            string word = SearchBox.Text;
            word = word.ToLower();
            string newWord = NewWordBox.Text;
            newWord = newWord.ToLower();
            string newType = TypeBox.Text;
            ModifyWord(word, newWord, newType);
            PrintAllWords();
        }
        //Wherever TextChanged, the hint box will print words whose first characters match the characters you just entered
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text == "Search for..." || SearchBox.Text == "")
            {
                SearchBtn.Enabled = false;
                AddBtn.Enabled = false;
            }
            else
            {
                SearchBtn.Enabled = true;
                AddBtn.Enabled = true;
            }
            if (TypeBox.Text == "Loai tu" || TypeBox.Text == "")
            {
                AddBtn.Enabled = false;
            }
            else
            {
                AddBtn.Enabled = true;
            }
            if (string.IsNullOrWhiteSpace(SearchBox.Text))
            {
                LightBarListBox.Text = "";
                PrintAllWords();
            }
            else
            {
                LightBarListBox.Text = "";
                LightBarListBox.Items.Clear();
                WordBox.Clear();
                bool hasMatchingItems = false;
                string searchWord = SearchBox.Text;
                searchWord = searchWord.ToLower();
                Node current = first;
                for (int i = 0; i < size; i++)
                {
                    if (current.Word.StartsWith(searchWord))
                    {
                        LightBarListBox.Text += current.Word + ", ";
                        LightBarListBox.Items.Add(current.Word);
                        WordBox.Text += current.Word + " <" + current.Type + "> \n";
                        LightBarListBox.Visible = true;
                        hasMatchingItems = true;
                    }
                    current = current.Next;
                }

                if (hasMatchingItems)
                {
                    LightBarListBox.SelectedIndex = 0; // Chọn item đầu tiên
                }
                else
                {
                    LightBarListBox.Visible = false;
                }
            }

        }
        //Add meaning to a word
        private void AddMeaningBtn_Click(object sender, EventArgs e)
        {
            string word = SearchBox.Text;
            word = word.ToLower();
            string meaning = MeaningBox.Text;
            AddMeaning(word, meaning);
            PrintLastestNodes();
            SaveWord();

        }

        private void RemoveMeaningBtn_Click(object sender, EventArgs e)
        {
            string word = SearchBox.Text;
            word = word.ToLower();
            int index = int.Parse(RemoveMeaningIndex.Text);
            RemoveMeaning(word, index);
            PrintAllWords();
            SaveWord();
        }

        private void AddExampleBtn_Click(object sender, EventArgs e)
        {
            string word = SearchBox.Text;
            word = word.ToLower();
            string example = ExamplesBox.Text;
            AddExample(word, example);
            PrintLastestNodes();
            SaveWord();
        }

        private void RemoveExampleBtn_Click(object sender, EventArgs e)
        {
            string word = SearchBox.Text;
            word = word.ToLower();
            int index = int.Parse(RemoveExampleIndex.Text);
            RemoveExample(word, index);
            PrintAllWords();
            SaveWord();
        }
        //set all textboxes to default text
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearBox();
        }

        private void LightBarListBox_MouseMove(object sender, MouseEventArgs e)
        {
            int index = LightBarListBox.IndexFromPoint(e.Location);
            if (index >= 0 && index < LightBarListBox.Items.Count)
            {
                LightBarListBox.SelectedIndex = index;
            }
        }

        private void LightBarListBox_DoubleClick(object sender, EventArgs e)
        {
            if (LightBarListBox.SelectedIndex >= 0)
            {
                string selectedWord = LightBarListBox.SelectedItem.ToString();
                SearchBox.Text = selectedWord;
            }
            string word = SearchBox.Text;
            word = word.ToLower();
            //clear boxes before print
            TypeBox.Clear();
            MeaningBox.Clear();
            ExamplesBox.Clear();
            PrintAllWords();
            SearchNode(word);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}