using System;
using System.Timers;
using System.Windows.Forms;

namespace Игровой_автомат
{
    public partial class Form2 : Form
    {
        Random random = new Random(); //Создаем экземпляр класса Random
        int balance; //Исходный баланс.
        int counter_money = 0; //Текущий ставка.
        int win_money = 0; //Выигранные деньги.
        bool IsActive = true; //Активность кнопки "ИГРАТЬ!"
        private static System.Timers.Timer Timer1, Timer2, Timer3;
        public Form2(string name, double sasha)
        {
            InitializeComponent();

            textBox1.Text = name;
            textBox2.Text = Convert.ToString(sasha);

        }
        public Form2()
        {
            InitializeComponent();
            play.Enabled = false;
        }
     
        private void play_Click(object sender, EventArgs e)
        {
            //активируем таймеры

            SetTimer1();
            SetTimer2();
            SetTimer3();
            

            IsActive = true;
            play.Enabled = false; //Пока барабаны крутятся кнопка "ИГРАТЬ!"  заблокирована.

            Timer1.Stop();
            Timer1.Dispose();
            Timer2.Stop();
            Timer2.Dispose();
            Timer3.Stop();
            Timer3.Dispose();
            this.Refresh();
        }

        private void SetTimer1()
        {
            Timer1 = new System.Timers.Timer(5);
            Timer1.Elapsed += OnTimeEvent1;
            Timer1.AutoReset = false;
            Timer1.Enabled = true;
        }

        private void OnTimeEvent1(Object source, ElapsedEventArgs e)
        {
            int timer1 = random.Next(8); // Получаем случайное число от 0-7
            label1.Text = timer1.ToString(); //Выводим полученное число.
        }

        private void SetTimer2()
        {
            Timer2 = new System.Timers.Timer(10);
            Timer2.Elapsed += OnTimeEvent2;
            Timer2.AutoReset = false;
            Timer2.Enabled = true;
        }

        private void OnTimeEvent2(Object source, ElapsedEventArgs e)
        {
            int timer = random.Next(8); // Получаем случайное число от 0-7
            label2.Text = timer.ToString(); //Выводим полученное число.
        }

        private void SetTimer3()
        {
            Timer3 = new System.Timers.Timer(15);
            Timer3.Elapsed += OnTimeEvent3;
            Timer3.AutoReset = false;
            Timer3.Enabled = true;
        }

        private void OnTimeEvent3(Object source, ElapsedEventArgs e)
        {
            int timer = random.Next(8); // Получаем случайное число от 0-7
            label3.Text = timer.ToString(); //Выводим полученное число.
            this.Refresh();
        }
        

           
        private void Win_Money()
        {
            if (label1.Text == "0" && label2.Text == "0" && label3.Text == "0") Upd_Win_Money(17);
            if (label1.Text == "1" && label2.Text == "1" && label3.Text == "1") Upd_Win_Money(10);
            if (label1.Text == "2" && label2.Text == "2" && label3.Text == "2") Upd_Win_Money(11);
            if (label1.Text == "3" && label2.Text == "3" && label3.Text == "3") Upd_Win_Money(12);
            if (label1.Text == "4" && label2.Text == "4" && label3.Text == "4") Upd_Win_Money(13);
            if (label1.Text == "5" && label2.Text == "5" && label3.Text == "5") Upd_Win_Money(14);
            if (label1.Text == "6" && label2.Text == "6" && label3.Text == "6") Upd_Win_Money(15);
            if (label1.Text == "7" && label2.Text == "7" && label3.Text == "7") Upd_Win_Money(20);
            if ((label1.Text == "0" && label2.Text == "0") || (label2.Text == "0" && label3.Text == "0")) Upd_Win_Money(7);
            if ((label1.Text == "1" && label2.Text == "1") || (label2.Text == "1" && label3.Text == "1")) Upd_Win_Money(1);
            if ((label1.Text == "2" && label2.Text == "2") || (label2.Text == "2" && label3.Text == "2")) Upd_Win_Money(2);
            if ((label1.Text == "3" && label2.Text == "3") || (label2.Text == "3" && label3.Text == "3")) Upd_Win_Money(3);
            if ((label1.Text == "4" && label2.Text == "4") || (label2.Text == "4" && label3.Text == "4")) Upd_Win_Money(4);
            if ((label1.Text == "5" && label2.Text == "5") || (label2.Text == "5" && label3.Text == "5")) Upd_Win_Money(5);
            if ((label1.Text == "6" && label2.Text == "6") || (label2.Text == "6" && label3.Text == "6")) Upd_Win_Money(6);
            if ((label1.Text == "7" && label2.Text == "7") || (label2.Text == "7" && label3.Text == "7")) Upd_Win_Money(10);
        }
        private void Upd_Win_Money(int number)
        {
            win_money = counter_money * number; //умножаем ставку на коэффициент получаем кол-во выигранных денег
            DialogResult result = MessageBox.Show("Вы выиграли: $" + win_money, "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Выыодим поздравления.
            textBox2.Text = Convert.ToString(balance + win_money); //Прибавляем выигрыш к балансу
            textBox2.Text = "Баланс: $" + textBox2; //Выводим обновленный балансе
            play.Enabled = false; //Блокируем кнопку "Погнали!"
            stavka.Enabled = true; //Открываем кнопку "Сделать ставку"
            IsActive = false; //Это костыль, может кто-то предложит как от него отказаться ))
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Делайте новую ставку!", "Новая игра", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Init_Counter(decimal counter)
        {
            counter_money = Convert.ToInt32(counter);
            balance = balance - counter_money;
            symma.Text = "Баланс: $" + balance;

        }
    }
}
