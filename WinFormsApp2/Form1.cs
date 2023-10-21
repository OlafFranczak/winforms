namespace WinFormsApp2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Fx
        {
            private Form1 parentForm;
            public int a = 1;
            public int b = 1;
            public int c = 1;
            public int d = 1;

            public Fx(Form1 form)
            {
                parentForm = form;
                a = int.Parse(parentForm.textBox1.Text);
                b = int.Parse(parentForm.textBox2.Text);

                if (parentForm.textBox3.Visible && parentForm.textBox4.Visible)
                {
                    c = int.Parse(parentForm.textBox3.Text);
                    d = int.Parse(parentForm.textBox4.Text);
                }
            }

            // blok przetrzymuj¹cy funkcje matematyczne nie wnikam bo nie chce mi sie podpisywaæ <3

            public int Proportion(int a,int b)
            {
                return (a * b) / 100;
            }

            public int Multiply(int a,int b)
            {
                return (a * b);
            }

            public int Division(int a,int b)
            {
                return (a / b);
            }

            public int Addition(int a,int b)
            {
                return (a + b);
            }

            public int Substraction(int a,int b)
            {
                return (a - b);
            }
            
            public int Modulo(int a,int b)
            {
                return (a % b);
            }
            public int Factorial(int n)
            {
                if (n == 0)
                    return 1;
                return n * Factorial(n - 1);
            }

        }

        // Przycisk 1 - Oblicz proporcjê i wyœwietl wynik na etykiecie 1
        private void button1_Click(object sender, EventArgs e)
        {
            Fx fx = new(this); //tworzenie obiektu fx klasy Fx
            int proportionResult = fx.Proportion(fx.a,fx.b); // przypisanie operacji proporcji do zmiennej proportionResult
            label1.Text = proportionResult.ToString(); // przypisanie zmiennej przetrzymuj¹cej wynik proporcji do tekstu etykiety 1 i konwersja zmiennej typu liczbowego na typ string
        }

        // Przycisk 5 - Oblicz mno¿enie u³amków liczb, wyœwietl wynik na etykietach 5 i 8, wyczyœæ etykiete wyniku 1
        private void button5_Click(object sender, EventArgs e)
        {
            Fx fx = new(this); //tworzenie obiektu fx klasy Fx
            int multiplyResult = fx.Multiply(fx.a, fx.b); // przypisanie operacji mno¿enia do zmiennej multiplyResult
            label1.Text = multiplyResult.ToString(); // przypisanie zmiennej przetrzymuj¹cej wynik mno¿enia do tekstu etykiety 1 i konwersja zmiennej typu liczbowego na typ string

            if (textBox4.Visible)
            {
                int multiplyResult1 = fx.Multiply(fx.a, fx.c); // iloczyn pierwszego licznika z drugim licznikiem
                int multiplyResult2 = fx.Multiply(fx.b, fx.d); // iloczyn pierwszego mianownika z drugim mianownikiem

                label1.Text = " "; // czyszczenie tekstu wyœwietlanego na etykiecie 1
                label5.Text = multiplyResult1.ToString(); // przypisanie zmiennej multiplyResult1 wyniku ilorazu liczników
                label8.Text = multiplyResult2.ToString(); // przypisanie zmiennej multiplyResult1 wyniku ilorazu mianowników
            }
        }

        // Przycisk 6 - Oblicz dzielenie u³amków liczb przez odwrócone mno¿enie i wyœwietl wynik na etykietach 5 i 8
        private void button6_Click(object sender, EventArgs e)
        {
            Fx fx = new(this); //tworzenie obiektu fx klasy Fx
            int divisionResult = fx.Division(fx.a, fx.b); // przypisanie operacji dzielenia do zmiennej divisionResult
            label1.Text = divisionResult.ToString(); // przypisanie zmiennej przetrzymuj¹cej wynik dzielenia do tekstu etykiety 1 i konwersja zmiennej typu liczbowego na typ string

            if(textBox4.Visible)
            {
                int multiplyResult1 = fx.Multiply(fx.a, fx.d); // iloczyn pierwszego licznika z drugim mianownikiem
                int multiplyResult2 = fx.Multiply(fx.b, fx.c); // iloczyn pierwszego mianownika z drugim licznikiem

                label1.Text = " "; // czyszczenie tekstu wyœwietlanego na etykiecie 1
                label5.Text = multiplyResult1.ToString(); // przypisanie zmiennej multiplyResult1 wyniku ilorazu liczników
                label8.Text = multiplyResult2.ToString(); // przypisanie zmiennej multiplyResult1 wyniku ilorazu mianowników
            }
        }

        // Przycisk 7 - Oblicz dodawanie u³amków 
        private void button7_Click(object sender, EventArgs e)
        {
            Fx fx = new(this); //tworzenie obiektu fx klasy Fx 
            int additionResult = fx.Addition(fx.a, fx.b); // przypisanie operacji sumy do zmiennej additionResult
            label1.Text = additionResult.ToString(); // przypisanie zmiennej przetrzymuj¹cej wynik sumy do tekstu etykiety 1 i konwersja zmiennej typu liczbowego na typ string

            if (textBox4.Visible)
            {
                int additionResult1 = 0, additionResult2 = 0; //inicjowanie zmiennych lokalnych typu liczbowego wyników

                if (fx.b != fx.d)
                {
                    int m = fx.Multiply(fx.b, fx.d); // suma mianowników
                    int l1 = fx.Multiply(fx.a, fx.d); // mno¿enie pierwszego licznika przez drugi mianownik
                    int l2 = fx.Multiply(fx.c, fx.b); // mnozenie drugiego licznika przez pierwszy mianownik
                    additionResult1 = fx.Addition(l1, l2); // przypisanie zmiennej additionResult1 wyniku sumy liczników
                    additionResult2 = m; // przypisanie zmiennej additionResult2 wyniku iloczynu mianowników
                }

                //wyœwietl wynik na etykiecie
                label1.Text = " "; // czyszczenie tekstu wyœwietlanego na etykiecie 1
                label5.Text = additionResult1.ToString(); // przypisanie pierwszej zmiennej przetrzymuj¹cej wynik dodawania do tekstu etykiety 5 i konwersja zmiennej typu liczbowego na typ string
                label8.Text = additionResult2.ToString(); // przypisanie drugiej zmiennej przetrzymuj¹cej wynik dodawania do tekstu etykiety 8 i konwersja zmiennej typu liczbowego na typ string
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Fx fx = new(this); //tworzenie obiektu fx klasy Fx 
            int substractionResult = fx.Substraction(fx.a, fx.b); // przypisanie operacji odejmowania do zmiennej substractionResult
            label1.Text = substractionResult.ToString(); // przypisanie zmiennej przetrzymuj¹cej wynik odejmowania do tekstu etykiety 1 i konwersja zmiennej typu liczbowego na typ string 


            if (textBox4.Visible)
            {
                int substractionResult1 = 0, substractionResult2 = 0; //inicjowanie zmiennych lokalnych typu liczbowego wyników

                if (fx.b != fx.d)
                {
                    int m = fx.Multiply(fx.b, fx.d); // iloczyn mianowników
                    int l1 = fx.Multiply(fx.a, fx.d); // mno¿enie pierwszego licznika
                    int l2 = fx.Multiply(fx.c, fx.b); // mnozenie drugiego licznika
                    substractionResult1 = fx.Substraction(l1, l2); // przypisanie zmiennej substractionResult1 wyniku odejmowania licznika 1 od licznika 2
                    substractionResult2 = m; // przypisanie zmiennej substractionResult2 wyniku iloczynu mianowników 
                }

                //wyœwietl wyniki na etykietach 5 i 8
                label1.Text = " "; // czyszczenie tekstu wyœwietlanego na etykiecie 1
                label5.Text = substractionResult1.ToString(); // przypisanie drugiej zmiennej przetrzymuj¹cej wynik odejmowania do tekstu etykiety 5 i konwersja zmiennej typu liczbowego na typ string
                label8.Text = substractionResult2.ToString(); // przypisanie trzeciej zmiennej przetrzymuj¹cej wynik odejmowania do tekstu etykiety 8 i konwersja zmiennej typu liczbowego na typ string
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Fx fx = new(this); //tworzenie obiektu fx klasy Fx
            int moduloResult = fx.Modulo(fx.a, fx.b); // przypisanie operacji odejmowania do zmiennej moduloResult
            label1.Text = moduloResult.ToString(); // przypisanie zmiennej przetrzymuj¹cej wynik dzielenia z reszt¹ do tekstu etykiety 1 i konwersja zmiennej moduloResult typu liczbowego na typ string
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Fx fx = new(this); //tworzenie obiektu fx klasy Fx
            int factorialResult = fx.Factorial(fx.a); // przypisanie operacji obliczania silni do zmiennej factorialResult
            label1.Text = factorialResult.ToString(); // przypisanie zmiennej przetrzymuj¹cej wynik silni do tekstu etykiety 1 i konwersja zmiennej typu liczbowego na typ string
        }

        // Przycisk 2 - Poka¿ pola do wprowadzania u³amków liczb
        private void button2_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            label6.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label8.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
        }

        // Przycisk 4 - Ukryj pola do wprowadzania u³amków liczb
        private void button4_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label6.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label8.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
        }
    }
}