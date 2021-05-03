﻿using System;
using System.Windows.Forms;
//1.
//а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
//б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен получить это число за минимальное количество ходов.
//в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте библиотечный обобщенный класс System.Collections.Generic.Stack<int>Stack.
//Вся логика игры должна быть реализована в классе с удвоителем.
//Шакун Кирилл

namespace WF_Udvoitel
{
    public partial class Form1 : Form
    {
        Doubler doubler;
        public Form1()
        {
            doubler = new Doubler();
            InitializeComponent();
            btn1.Text = "+1";
            btn2.Text = "x2";
            lblNumber.Text = "0";
            btnReset.Text = "Сброс";
            this.Text = "Удвоитель";
            lblGoal.Visible = false;
            lblGoalText.Visible = false;
            lblStepsCount.Text = "0";
        }
        public void Update()
        {
            lblNumber.Text = doubler.Value.ToString();
            lblStepsCount.Text = doubler.Steps.ToString();
            this.Refresh();
            if (lblGoal.Visible)
                if (doubler.CheckGoal())
                {
                    MessageBox.Show($"Поздравляем! Вы добрались за {doubler.Steps} шагов");
                    lblGoal.Visible = false;
                    lblGoalText.Visible = false;
                    doubler.Reset();
                }

        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            doubler.Increment();
            Update();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            doubler.Double();
            Update();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            doubler.Reset();
            Update();
        }

        private void menuStart_Click(object sender, EventArgs e)
        {
            doubler.GetGoal();
            MessageBox.Show($"Получите значение: {doubler.Goal}");
            lblGoal.Visible = true;
            lblGoalText.Visible = true;
            lblGoal.Text = doubler.Goal.ToString();
            doubler.Reset();
            Update();
        }

        private void menuStop_Click(object sender, EventArgs e)
        {
            lblGoal.Visible = false;
            lblGoalText.Visible = false;
        }

        private void menuCancel_Click(object sender, EventArgs e)
        {
            doubler.CheckStack();
            Update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
