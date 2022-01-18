using System;
using System.Collections.Generic;
using SFML.Graphics;
using SFML.Audio;
namespace SortingAlgorithms
{
    class Program
    {
        static void  Main(string[] args)
        {
            Random random = new Random();
            float size = 5000;
            ElementList myElements = new ElementList();
            List<Element> bars = new List<Element>();
            Element myRect1 = new Element(25,450);
            Texture myTexture = new Texture(@"D:\PICTURES\9.png");
            Sprite mySprite = new Sprite(myTexture);



            Element myRect2 = new Element(50,850);

            uint windowSize = 0;
            int numBars = 500;
            float x = 0;
            float y = 0;
            for(int i = 0; i < numBars; i++)
            {
                x += 9;
                y += 25;
                myElements.elementList.Add(new Element(x, random.Next(1000)));
                //myElements.elementList.Add(new Element(x, y));
            }

            windowSize = (uint)numBars * 9;

            RenderWindow myWindow = new RenderWindow(new SFML.Window.VideoMode(windowSize, 1000), "My Window");
            myWindow.SetFramerateLimit(1000);
            //event handler for closing window
            myWindow.Closed += OnClose;



            while (myWindow.IsOpen)
            {

                /*
                //BUBBLE SORT

                for (int i = 0; i < myElements.elementList.Count - 1; i++)
                {
                    bool swapped = false;
                    for (int j = 0; j < myElements.elementList.Count - i - 1; j++)
                    {
                        if (myElements.elementList[j].size > myElements.elementList[j + 1].size)
                        {
                            Swap(myElements.elementList[j], myElements.elementList[j + 1]);
                            Element temp = myElements.elementList[j];
                            myElements.elementList[j] = myElements.elementList[j + 1];
                            myElements.elementList[j + 1] = temp;
                            swapped = true;
                            //mySound1.Play();
                        }

                        myWindow.DispatchEvents();
                        myWindow.Clear();
                        foreach (var bar in myElements.elementList)
                        {
                            myWindow.Draw(bar.rectangle);
                        }
                        myWindow.Display();



                    }

                    if (swapped == false)
                    {

                        break;

                    }
                }

                */
                   
                    for (int i = 1; i < myElements.elementList.Count; i++)
                    {

                        myWindow.DispatchEvents();
                        myWindow.Clear();

                        foreach (var bar in myElements.elementList)
                        {
                            myWindow.Draw(bar.rectangle);
                        }
                        myWindow.Display();

                        bool swapped = false;
                        if (myElements.elementList[i].size < myElements.elementList[i - 1].size)
                        {
                            for (int j = i; j > 0; j--)
                            {
                                if (myElements.elementList[j].size < myElements.elementList[j - 1].size)
                                {

                                    Swap(myElements.elementList[j], myElements.elementList[j - 1]);
                                    Element temp = myElements.elementList[j];
                                    myElements.elementList[j] = myElements.elementList[j - 1];
                                    myElements.elementList[j - 1] = temp;
                                    swapped = true;
                                    myWindow.DispatchEvents();
                                    myWindow.Clear();

                                    foreach (var bar in myElements.elementList)
                                    {
                                        myWindow.Draw(bar.rectangle);
                                    }
                                    myWindow.Display();
                                }

                            }
                            if (swapped == false)
                            {

                                break;

                            }
                        }



                    }
                



                /*
                //selection sort
                for (int i = 0; i < myElements.elementList.Count - 1; i++) 
                {
                    bool swapped = false;
                    int k = i;
                    for (int j = i; j < myElements.elementList.Count; j++)
                    {
                        if(myElements.elementList[j].size < myElements.elementList[k].size)
                        {
                            k = j;
                            swapped = true;
                        }

                    }
                    if(swapped == true)
                    {
                        Swap(myElements.elementList[i], myElements.elementList[k]);
                        Element temp = myElements.elementList[i];
                        myElements.elementList[i] = myElements.elementList[k];
                        myElements.elementList[k] = temp;
                        myWindow.DispatchEvents();
                        myWindow.Clear();
                        foreach (var mybars in myElements.elementList)
                        {
                            myWindow.Draw(mybars.rectangle);
                        }
                        myWindow.Display();
                    }

                }
               */
                //break;



            }
            
        }
        //event for closing window
        static void OnClose(object sender, EventArgs e)
        {
            // Close the window when OnClose event is received
            RenderWindow window = (RenderWindow)sender;
            window.Close();
        }
        //swap two bars position
        static void Swap(Element a,Element b)
        {
            float temp;
            temp = a.x;
            a.x = b.x;
            b.x = temp;
            a.rectangle.Position = new SFML.System.Vector2f(a.x, 0);
            b.rectangle.Position = new SFML.System.Vector2f(b.x, 0);
        }


    }


}

