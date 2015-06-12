using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork5
{
    public partial class Form1 : Form
    {
        private int currentScene = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void changeScene(int choice)
        {
            //////if (currentScene == 0)
            //////{
            //////    scene.Image = HomeWork5.Properties.Resources.scene1;
            //////    currentScene = 1;
            //////}
            //////else if (currentScene == 1)
            //////{
            //////    {
            //////        if (choice == 1)
            //////        {
            //////            scene.Image = HomeWork5.Properties.Resources.scene2;
            //////            currentScene = 2;
            //////        }
            //////        else
            //////        {
            //////            scene.Image = HomeWork5.Properties.Resources.scene3;
            //////            currentScene = 3;
            //////        }
            //////    }
            //////}
            //////else if (currentScene == 2)
            //////{
            //////    if (choice == 1)
            //////    {
            //////        scene.Image = HomeWork5.Properties.Resources.scene4;
            //////        currentScene = 4;
            //////    }
            //////    else
            //////    {
            //////        scene.Image = HomeWork5.Properties.Resources.scene5;
            //////        currentScene = 5;
            //////    }
            //////}
            //////else if (currentScene == 3)
            //////{
            //////    if (choice == 1)
            //////    {
            //////        scene.Image = HomeWork5.Properties.Resources.scene7;
            //////        currentScene = 7;
            //////    }
            //////    else
            //////    {
            //////        scene.Image = HomeWork5.Properties.Resources.scene8;
            //////        currentScene = 8;
            //////    }
            //////}
            //////else if (currentScene == 4)
            //////{
            //////    if (choice == 1)
            //////    {
            //////        scene.Image = HomeWork5.Properties.Resources.scene8;
            //////        currentScene = 8;
            //////    }
            //////    else
            //////    {
            //////        scene.Image = HomeWork5.Properties.Resources.scene8;
            //////        currentScene = 8;
            //////    }
            //////}
            //////else if (currentScene == 7)
            //////{
            //////    if (choice == 1)
            //////    {
            //////        scene.Image = HomeWork5.Properties.Resources.scene6;
            //////        currentScene = 6;
            //////    }
            //////    else
            //////    {
            //////        scene.Image = HomeWork5.Properties.Resources.scene8;
            //////        currentScene = 8;
            //////    }
            //////}

            switch (currentScene)
            {
                case 0:
                    scene.Image = HomeWork5.Properties.Resources.scene1;
                    currentScene = 1;
                    break;

                case 1:
                    if (choice == 1)
                    {
                        scene.Image = HomeWork5.Properties.Resources.scene2;
                        currentScene = 2;
                    }
                    else
                    {
                        scene.Image = HomeWork5.Properties.Resources.scene3;
                        currentScene = 3;
                    }
                    break;

                case 2:
                    if (choice == 1)
                    {
                        scene.Image = HomeWork5.Properties.Resources.scene4;
                        currentScene = 4;
                    }
                    else
                    {
                        scene.Image = HomeWork5.Properties.Resources.scene5;
                        currentScene = 5;
                    }
                    break;

                case 3:
                    if (choice == 1)
                    {
                        scene.Image = HomeWork5.Properties.Resources.scene7;
                        currentScene = 7;
                    }
                    else
                    {
                        scene.Image = HomeWork5.Properties.Resources.scene8;
                        currentScene = 8;
                    }
                    break;

                case 4:
                    if (choice == 1)
                    {
                        scene.Image = HomeWork5.Properties.Resources.scene8;
                        currentScene = 8;
                    }
                    else
                    {
                        scene.Image = HomeWork5.Properties.Resources.scene8;
                        currentScene = 8;
                    }
                    break;

                case 7:
                    if (choice == 1)
                    {
                        scene.Image = HomeWork5.Properties.Resources.scene6;
                        currentScene = 6;
                    }
                    else
                    {
                        scene.Image = HomeWork5.Properties.Resources.scene8;
                        currentScene = 8;
                    }
                    break;

                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeScene(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeScene(2);
        }
    }
}