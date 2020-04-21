﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Engine;
namespace Farmio
{
    public class GameMap
    {

        public string[] array = new string[500];
        public string[,] formArray = new string[1300,805];
        string str;
        Random random = new Random();
        public void ArrayGen()
        { for (int i = 0; i < 500; i++)
            {
                
                //random.Next(1, max);
                int caseSwitch = random.Next(1, 32);
                //Console.WriteLine(caseSwitch);
                switch (caseSwitch)
                {
                    case 1:
                    case 2:
                    case 3:
                        str = "g1";
                        break;
                    case 4:
                    case 5:
                    case 6:
                        str = "g2";
                        break;
                    case 7:
                    case 8:
                    case 9:
                        str = "g3";
                        break;
                    case 10:
                    case 11:
                    case 12:
                        str = "g4";
                        break;
                    case 13:
                    case 14:
                    case 15:
                        str = "g5";
                        break;
                    case 16:
                    case 17:
                    case 18:
                        str = "g6";
                        break;
                    case 19:
                    case 20:
                    case 21:
                        str = "g7";
                        break;
                    case 22:
                    case 23:
                    case 24:
                        str = "g8";
                        break;
                    case 25:
                    case 26:
                        str = "t1";
                        break;
                    case 27:
                    case 28:
                        str = "t3";
                        break;
                    case 29:
                        str = "s1";
                        break;
                    case 30:
                        str = "s2";
                        break;
                    case 31:
                        str = "s3";
                        break;
                    //case 15:
                    //    str = "g15";
                    //    break;
                    default:
                        str = "g";
                        break;
                }
                     array[i] = str;
                }
             }
           
    




        public Image MapGen()
        {
            int x = 0, y = 0, img = 0;

            Bitmap[] bm;
            bm = new Bitmap[501];

            Image[] files;
            files = new Image[501];

            List<Bitmap> images = new List<Bitmap>();
            Bitmap bitmap;

            Bitmap finalImage = new Bitmap(1300, 805);

            // grass
            foreach (string itm in array)
            {
                if (itm != "g" && itm != "g1" && itm != "g2" && itm != "g3" && itm != "g4" && itm != "g5" && itm != "g6" && itm != "g7" && itm != "g8")
                    continue;

                int yr1 = random.Next(-49, 49);

                if (y + yr1 < 0)
                    continue;
                if (x > 1250)
                {
                    x = 0;
                    int yr = random.Next(50, 150);
                    y += yr; 
                }
                if (y+yr1 > 750)
                    break;

                // create the images!
                if (itm == "g")
                {
                    bm[img] = new Bitmap("grass1.png");
                    files[img] = new Bitmap(bm[img], 11, 8);
                    for (int i = y + yr1; i <= y + yr1 + 8; i++)
                        for (int j = x; j <= x + 11; j++)
                            formArray[j, i] = "g";
                }

                if (itm == "g1")
                {
                    bm[img] = new Bitmap("grass2.png");
                    files[img] = new Bitmap(bm[img], 10, 8);
                    for (int i = y + yr1; i <= y + yr1 + 8; i++)
                        for (int j = x; j <= x + 10; j++)
                            formArray[j, i] = "g1";
                }

                if (itm == "g2")
                {
                    bm[img] = new Bitmap("grass3.png");
                    files[img] = new Bitmap(bm[img], 16, 14);
                    for (int i = y + yr1; i <= y + yr1 + 14; i++)
                        for (int j = x; j <= x + 16; j++)
                            formArray[j, i] = "g2";
                }

                if (itm == "g3")
                {
                    bm[img] = new Bitmap("grass4.png");
                    files[img] = new Bitmap(bm[img], 13, 12);
                    for (int i = y + yr1; i <= y + yr1 + 12; i++)
                        for (int j = x; j <= x + 13; j++)
                            formArray[j, i] = "g3";
                }

                if (itm == "g4")
                {
                    bm[img] = new Bitmap("grass5.png");
                    files[img] = new Bitmap(bm[img], 10, 13);
                    for (int i = y + yr1; i <= y + yr1 + 13; i++)
                        for (int j = x; j <= x + 10; j++)
                            formArray[j, i] = "g4";
                }

                if (itm == "g5")
                {
                    bm[img] = new Bitmap("grass6.png");
                    files[img] = new Bitmap(bm[img], 12, 11);
                    for (int i = y + yr1; i <= y + yr1 + 11; i++)
                        for (int j = x; j <= x + 12; j++)
                            formArray[j, i] = "g5";
                }

                if (itm == "g6")
                {
                    bm[img] = new Bitmap("grass7.png");
                    files[img] = new Bitmap(bm[img], 13, 15);
                    for (int i = y + yr1; i <= y + yr1 + 15; i++)
                        for (int j = x; j <= x + 13; j++)
                            formArray[j, i] = "g6";
                }

                if (itm == "g7")
                {
                    bm[img] = new Bitmap("grass8.png");
                    files[img] = new Bitmap(bm[img], 15, 13);
                    for (int i = y + yr1; i <= y + yr1 + 13; i++)
                        for (int j = x; j <= x + 15; j++)
                            formArray[j, i] = "g7";
                }

                if (itm == "g8")
                {
                    bm[img] = new Bitmap("grass9.png");
                    files[img] = new Bitmap(bm[img], 25, 21);
                    for (int i = y + yr1; i <= y + yr1 + 21; i++)
                        for (int j = x; j <= x + 25; j++)
                            formArray[j, i] = "g8";
                }


                //if (itm == "g9")
                //{
                //    bm[img] = new Bitmap("grass9.png");
                //    files[img] = new Bitmap(bm[img], 50, 50);
                //}

                //if (itm == "g10")
                //{
                //    bm[img] = new Bitmap("grass10.png");
                //    files[img] = new Bitmap(bm[img], 50, 50);
                //}

                //if (itm == "g11")
                //{
                //    bm[img] = new Bitmap("grass11.png");
                //    files[img] = new Bitmap(bm[img], 50, 50);
                //}

                //if (itm == "g12")
                //{
                //    bm[img] = new Bitmap("grass12.png");
                //    files[img] = new Bitmap(bm[img], 50, 50);
                //}

                //if (itm == "g13")
                //{
                //    bm[img] = new Bitmap("grass13.png");
                //    files[img] = new Bitmap(bm[img], 50, 50);
                //}

                //if (itm == "g14")
                //{
                //    bm[img] = new Bitmap("grass14.png");
                //    files[img] = new Bitmap(bm[img], 50, 50);
                //}

                //if (itm == "g15")
                //{
                //    bm[img] = new Bitmap("grass15.png");
                //    files[img] = new Bitmap(bm[img], 50, 50);
                //}

                // now we add the image to the graphics engine
                using (Graphics g = Graphics.FromImage(finalImage))
                {
                    g.DrawImage(files[img], new Point(x, y+yr1));
                }

                img++;

                int xr = random.Next(50, 150);
                
                x += xr;

            }

            x = 0; y = 0; img = -1;
            // strones
            foreach (string itm in array)
            {
                int xr = random.Next(50, 130);

                img++;

                x += xr;

                int yr1 = random.Next(-10, 20);

                if (y + yr1 < 0)
                    continue;
                if (x > 1250)
                {
                    x = 0;
                    int yr = random.Next(50, 150);
                    y += yr;
                }
                if (y + yr1 > 750)
                    break;

                if (itm != "s1" && itm != "s2" && itm != "s3")
                    continue;
                
                if (itm == "s1")
                {
                    bm[img] = new Bitmap("stone1.png");
                    files[img] = new Bitmap(bm[img], 28, 16);
                    for (int i = y + yr1; i <= y + yr1 + 16; i++)
                        for (int j = x; j <= x + 28; j++)
                            formArray[j, i] = "s1";
                }

                if (itm == "s2")
                {
                    bm[img] = new Bitmap("stone2.png");
                    files[img] = new Bitmap(bm[img], 24, 16);
                    for (int i = y + yr1; i <= y + yr1 + 16; i++)
                        for (int j = x; j <= x + 24; j++)
                            formArray[j, i] = "s2";
                }

                if (itm == "s3")
                {
                    bm[img] = new Bitmap("stone3.png");
                    files[img] = new Bitmap(bm[img], 46, 39);
                    for (int i = y + yr1; i <= y + yr1 + 39; i++)
                        for (int j = x; j <= x + 46; j++)
                            formArray[j, i] = "s3";
                }

                // now we add the image to the graphics engine
                using (Graphics g = Graphics.FromImage(finalImage))
                {
                    g.DrawImage(files[img], new Point(x, y + yr1));
                }
            }


            x = 0; y = 0; img = -1;

            // trees
            foreach (string itm in array)
            {
                int xr = random.Next(50, 120);

                img++;

                x += xr;

                int yr1 = random.Next(-20, 20);

                if (y + yr1 < 0)
                    continue;
                if (x > 1199)
                {
                    x = 0;
                    int yr = random.Next(50, 150);
                    y += yr;
                }
                if (y + yr1 > 704)
                    break;

                if (itm != "t1" && itm != "t2" && itm != "t3")
                    continue;

                if (itm == "t1")
                {
                    bm[img] = new Bitmap("tree1.png");
                    files[img] = new Bitmap(bm[img], 64, 95);
                    for (int i = y + yr1; i <= y + yr1 + 95; i++)
                        for (int j = x; j <= x + 64; j++)
                            formArray[j, i] = "t1";
                }

                if (itm == "t2")
                {
                    bm[img] = new Bitmap("tree2.png");
                    files[img] = new Bitmap(bm[img], 112, 96);
                    for (int i = y + yr1; i <= y + yr1 + 96; i++)
                        for (int j = x; j <= x + 112; j++)
                            formArray[j, i] = "t2";
                }

                if (itm == "t3")
                {
                    bm[img] = new Bitmap("tree3.png");
                    files[img] = new Bitmap(bm[img], 69, 111);
                    for (int i = y + yr1; i <= y + yr1 + 111; i++)
                        for (int j = x; j <= x + 69; j++)
                            formArray[j, i] = "t3";
                }

                // now we add the image to the graphics engine
                using (Graphics g = Graphics.FromImage(finalImage))
                {
                    g.DrawImage(files[img], new Point(x, y + yr1));
                }

            }


            // buildings
            //TODO

            {
                bm[0] = new Bitmap("house1.png");
                files[0] = new Bitmap(bm[0], 94, 87);
                using (Graphics g = Graphics.FromImage(finalImage))
                {
                    g.DrawImage(files[0], new Point(1500, 400));
                }
            }


            return finalImage;


        }
    }
}
