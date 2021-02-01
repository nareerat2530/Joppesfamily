using System;
using System.Collections.Generic;
using System.Windows.Forms;
using JoppesHundar_uppgift;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public PetOwner Nammy  { get; set; }
        public Form1()
        {
            InitializeComponent();
            
            var pets = new List<Animal>();
            pets.Add(new Cat(2, "Haru", "fish", "Perser", false));
            pets.Add(new Dog(3, "Leo", "chicken", "Siberian husky", true));
            pets.Add(new Puppy(1, "Poppy", "banana", "Alaskan malamute", true));
            Nammy = new PetOwner(33,pets);
        } 
        public string PetName { get; set; }
        public void Form1_Load(object sender, EventArgs e)
        {
            HideInfo();
        } 
        public void HideInfo()
        {
            PoppyPic.Hide();
            HaruPic.Hide();
            LeoPic.Hide();
            PetInfo.Hide();
            Accept.Hide();
            Cancel.Hide();
            informationBox.Hide();
            FoodBox.Hide();
            FoodLabel.Hide();
            FeedBox.Hide();
            PlayButton.Hide();
            FeedButton.Hide();
            PlayInfo.Hide();
            ToyInfo.Hide();
            Check_ball.Hide();
            Check_mouse.Hide();
        }
        private void HaruButton_Click_1(object sender, EventArgs e)
        {
            HideInfo();
            HaruPic.Show();
            PetInfo.Show();
            var petList = Nammy.List_animals();
            PetInfo.Text = petList[0].ToString();
            PetName = "Haru";
            PlayButton.Show();
            FeedButton.Show();
        } 
        private void LeoButton_Click(object sender, EventArgs e)
        {
            HideInfo();
            PetInfo.Show();
            var petList = Nammy.List_animals();
            PetInfo.Text = petList[1].ToString();
            LeoPic.Show();
            PetName = "Leo";
            PlayButton.Show();
            FeedButton.Show();
        }
        private void PoppyButton_Click(object sender, EventArgs e)
        {
            HideInfo();
            PetInfo.Show();
            var petList = Nammy.List_animals();
            PetInfo.Text = petList[2].ToString();
            PoppyPic.Show();
            PetName = "Poppy";
            PlayButton.Show();
            FeedButton.Show();
        } 
        private void PlayButton_Click(object sender, EventArgs e)
        {
            Cancel.Hide();
            FoodLabel.Hide();
            Accept.Hide();
            FoodBox.Hide(); 
            FeedBox.Hide();
            PlayInfo.Show();
            PlayInfo.Text = Nammy.Play(PetName);
            if (PetName == "Haru")
            {
                Check_mouse.Show(); 
            }
            else
            {
                Check_ball.Show();
            }
        }
        private void FeedButton_Click(object sender, EventArgs e)
        {
            informationBox.Show();
            informationBox.Text = $"Please write the food you want to feed to {PetName}";
            FoodBox.Show();
            FoodLabel.Show();
            Accept.Show();
            Cancel.Show();
            PlayInfo.Hide();
            Check_ball.Hide();
            Check_mouse.Hide();
            ToyInfo.Hide();
           
        }
        private void Accept_Click(object sender, EventArgs e)
        {
            FeedBox.Show();
            FeedBox.Text = Nammy.Feed(PetName,FoodBox.Text);
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Accept.Hide();
            Cancel.Hide();
            informationBox.Hide();
            FoodBox.Hide();
            FoodLabel.Hide();
            FeedBox.Hide();
        } 
        private void Check_ball_Click(object sender, EventArgs e)
        {
            ToyInfo.Show();
            ToyInfo.Text = Nammy.Check_ball();
        } 
        private void Check_mouse_Click(object sender, EventArgs e)
        {
            ToyInfo.Show();
            ToyInfo.Text = Nammy.Check_mouse();
        }

        
    }
    
}