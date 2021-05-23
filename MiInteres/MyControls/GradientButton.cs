using System;
using System.Collections.Generic;
using MagicGradients;
using NControl.Abstractions;
using NGraphics;
using Xamarin.Forms;

namespace MiInteres.MyControls
{
    public class GradientButton : NControlView
    {
        public GradientButton()
        {
            var label = new Label
            {
                Text = "Test 1",
                TextColor = Xamarin.Forms.Color.White,
                VerticalTextAlignment = Xamarin.Forms.TextAlignment.Center,
                HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center

            };

            var gradient = new GradientView
            {
                GradientSource = new CssGradientSource
                {
                    Stylesheet = "radial-gradient(circle at 65% 15%, rgba(255,255,255,0.01) 0%, rgba(255,255,255,0.01) 3%,transparent 3%, transparent 100%),radial-gradient(circle at 40% 33%, rgba(255,255,255,0.03) 0%, rgba(255,255,255,0.03) 3%,transparent 3%, transparent 100%),radial-gradient(circle at 9% 92%, rgba(255,255,255,0.03) 0%, rgba(255,255,255,0.03) 3%,transparent 3%, transparent 100%),radial-gradient(circle at 84% 0%, rgba(255,255,255,0.01) 0%, rgba(255,255,255,0.01) 7%,transparent 7%, transparent 100%),radial-gradient(circle at 97% 94%, rgba(255,255,255,0.03) 0%, rgba(255,255,255,0.03) 7%,transparent 7%, transparent 100%),radial-gradient(circle at 13% 95%, rgba(255,255,255,0.02) 0%, rgba(255,255,255,0.02) 7%,transparent 7%, transparent 100%),radial-gradient(circle at 77% 8%, rgba(255,255,255,0.03) 0%, rgba(255,255,255,0.03) 7%,transparent 7%, transparent 100%),radial-gradient(circle at 58% 0%, rgba(255,255,255,0.03) 0%, rgba(255,255,255,0.03) 7%,transparent 7%, transparent 100%),radial-gradient(circle at 76% 71%, rgba(255,255,255,0.02) 0%, rgba(255,255,255,0.02) 7%,transparent 7%, transparent 100%),radial-gradient(circle at 88% 74%, rgba(255,255,255,0.01) 0%, rgba(255,255,255,0.01) 7%,transparent 7%, transparent 100%),radial-gradient(circle at 74% 99%, rgba(255,255,255,0.03) 0%, rgba(255,255,255,0.03) 7%,transparent 7%, transparent 100%),radial-gradient(circle at 16% 56%, rgba(255,255,255,0.02) 0%, rgba(255,255,255,0.02) 7%,transparent 7%, transparent 100%),radial-gradient(circle at 25% 4%, rgba(255,255,255,0.02) 0%, rgba(255,255,255,0.02) 5%,transparent 5%, transparent 100%),radial-gradient(circle at 54% 83%, rgba(255,255,255,0.03) 0%, rgba(255,255,255,0.03) 5%,transparent 5%, transparent 100%),radial-gradient(circle at 70% 60%, rgba(255,255,255,0.03) 0%, rgba(255,255,255,0.03) 5%,transparent 5%, transparent 100%),radial-gradient(circle at 23% 73%, rgba(255,255,255,0.03) 0%, rgba(255,255,255,0.03) 5%,transparent 5%, transparent 100%),radial-gradient(circle at 63% 81%, rgba(255,255,255,0.01) 0%, rgba(255,255,255,0.01) 5%,transparent 5%, transparent 100%),radial-gradient(circle at 56% 58%, rgba(255,255,255,0.03) 0%, rgba(255,255,255,0.03) 5%,transparent 5%, transparent 100%),radial-gradient(circle at 64% 68%, rgba(255,255,255,0.03) 0%, rgba(255,255,255,0.03) 5%,transparent 5%, transparent 100%),radial-gradient(circle at 52% 48%, rgba(255,255,255,0.01) 0%, rgba(255,255,255,0.01) 5%,transparent 5%, transparent 100%),linear-gradient(90deg, rgb(54, 51, 154),rgb(148, 25, 101))"

                }
            };

            Content = new Frame//para bordear
            {
                Content = new Grid
                {
                    Children =
                    {
                        gradient,
                        label
                    }

                },
                Padding = 0,
                CornerRadius= 15f
               
             };
        }

        //encojemos nuestro control cuando se presione
        public override bool TouchesBegan(IEnumerable<NGraphics.Point> points)
        {
            
            this.ScaleTo(0.96, 65, Easing.CubicInOut);//65 inidades
            return true;
        }

        public override bool TouchesCancelled(IEnumerable<NGraphics.Point> points)
        {
            this.ScaleTo(1, 65, Easing.CubicInOut);//1 escalamiento normalidad
            return true;
        }


        public override bool TouchesEnded(IEnumerable<NGraphics.Point> points)
        {
            this.ScaleTo(1, 65, Easing.CubicInOut);
            return true;
        }
    }

}

