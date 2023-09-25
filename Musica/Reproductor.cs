using Android.App;
using Android.Content;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Musica
{
    [Activity(Label = "Reproductor", Theme = "@style/AppTheme", Icon = "@drawable/img1", MainLauncher = false)]
    public class Reproductor : Activity
    {
        int num = 1;
        int cont = 1;
        int rep = 1;
        Timer timer = new Timer();
        List<string> lstCanciones = new List<string>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Reproductor);
            // Create your application here

            var Caratula = FindViewById<ImageView>(Resource.Id.imageView1);
            var ProgressBar = FindViewById<ProgressBar>(Resource.Id.progressBar1);
            var spnCanciones = FindViewById<Spinner>(Resource.Id.spinner1);
            var linearBar = FindViewById<LinearLayout>(Resource.Id.linearLayout4);
            var linearTime = FindViewById<LinearLayout>(Resource.Id.linearLayout7);

            var txtMusica = FindViewById<TextView>(Resource.Id.textView1);
            var txtAutor = FindViewById<TextView>(Resource.Id.textView2);

            var txtTiemIni = FindViewById<TextView>(Resource.Id.textView3);
            var txtTiemFin = FindViewById<TextView>(Resource.Id.textView4);

            var btnAtras = FindViewById<Button>(Resource.Id.buttonAtras);
            var btnPlay = FindViewById<Button>(Resource.Id.buttonPlay);
            var btnSig = FindViewById<Button>(Resource.Id.buttonSig);
            var btnRandom = FindViewById<Button>(Resource.Id.buttonRandom);
            var btnRep = FindViewById<Button>(Resource.Id.buttonRep);

            linearBar.Visibility = ViewStates.Gone;
            linearTime.Visibility = ViewStates.Gone;
            var music = Musica();

            lstCanciones.Add("          Buscar Canción...");
            lstCanciones.Add("Adentro / Calle 13");
            lstCanciones.Add("A Dios Le Pido / Juanes");
            lstCanciones.Add("Brillas / León Larregui");
            lstCanciones.Add("Como Me Encanta / Kevin Kaarl");
            lstCanciones.Add("Es por Tí / Juanes");
            lstCanciones.Add("Hips Don't Lie / Wyclef Jean - Shakira");
            lstCanciones.Add("It's Time / Imagine Dragons");
            lstCanciones.Add("Labios Compartidos / Maná");
            lstCanciones.Add("La la la / Naughty Boy");
            lstCanciones.Add("La Perfecta Ocasión / Gocho");
            lstCanciones.Add("Love / Zoé");
            lstCanciones.Add("El Malo / Aventura");
            lstCanciones.Add("Ojos Color Sol / Calle 13");
            lstCanciones.Add("On Melancholy Hill / Gorillaz");
            lstCanciones.Add("Riptide / Vance Joy");
            lstCanciones.Add("Save Your Tears / The Weeknd");
            lstCanciones.Add("Somewhere Only We Know / Keane");
            lstCanciones.Add("Stole The Show / Kygo");
            lstCanciones.Add("Labios Rotos / Zoé");
            lstCanciones.Add("Luna / Zoé");
            lstCanciones.Add("Speed Of Sound / Coldplay");

            var adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerItem, lstCanciones);
            spnCanciones.Adapter = adapter;
            int gracias = 0;

            spnCanciones.ItemSelected += delegate
            {
                if (spnCanciones.SelectedItem.ToString() == "          Buscar Canción...")
                {
                    
                }
                if (spnCanciones.SelectedItem.ToString() == "Adentro / Calle 13")
                {
                    music.Stop();
                    num = 1;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                }
                if (spnCanciones.SelectedItem.ToString() == "A Dios Le Pido / Juanes")
                {
                    music.Stop();
                    num = 2;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                }
                if (spnCanciones.SelectedItem.ToString() == "Brillas / León Larregui")
                {
                    music.Stop();
                    num = 3;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                }
                if (spnCanciones.SelectedItem.ToString() == "Como Me Encanta / Kevin Kaarl")
                {
                    music.Stop();
                    num = 4;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                }
                if (spnCanciones.SelectedItem.ToString() == "Es por Tí / Juanes")
                {
                    music.Stop();
                    num = 5;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                }
                if (spnCanciones.SelectedItem.ToString() == "Hips Don't Lie / Wyclef Jean - Shakira")
                {
                    music.Stop();
                    num = 6;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                }
                if (spnCanciones.SelectedItem.ToString() == "It's Time / Imagine Dragons")
                {
                    music.Stop();
                    num = 7;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                }
                if (spnCanciones.SelectedItem.ToString() == "Labios Compartidos / Maná")
                {
                    music.Stop();
                    num = 8;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                }
                if (spnCanciones.SelectedItem.ToString() == "La la la / Naughty Boy")
                {
                    music.Stop();
                    num = 9;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                }
                if (spnCanciones.SelectedItem.ToString() == "La Perfecta Ocasión / Gocho")
                {
                    music.Stop();
                    num = 10;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                }
                if (spnCanciones.SelectedItem.ToString() == "Love / Zoé")
                {
                    music.Stop();
                    num = 11;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                }
                if (spnCanciones.SelectedItem.ToString() == "El Malo / Aventura")
                {
                    music.Stop();
                    num = 12;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                }
                if (spnCanciones.SelectedItem.ToString() == "Ojos Color Sol / Calle 13")
                {
                    music.Stop();
                    num = 13;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                }
                if (spnCanciones.SelectedItem.ToString() == "On Melancholy Hill / Gorillaz")
                {
                    music.Stop();
                    num = 14;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                }
                if (spnCanciones.SelectedItem.ToString() == "Riptide / Vance Joy")
                {
                    music.Stop();
                    num = 15;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                }
                if (spnCanciones.SelectedItem.ToString() == "Save Your Tears / The Weeknd")
                {
                    music.Stop();
                    num = 16;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                }
                if (spnCanciones.SelectedItem.ToString() == "Somewhere Only We Know / Keane")
                {
                    music.Stop();
                    num = 17;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                }
                if (spnCanciones.SelectedItem.ToString() == "Stole The Show / Kygo")
                {
                    music.Stop();
                    num = 18;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                }
                if (spnCanciones.SelectedItem.ToString() == "Labios Rotos / Zoé")
                {
                    music.Stop();
                    num = 19;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                }
                if (spnCanciones.SelectedItem.ToString() == "Luna / Zoé")
                {
                    music.Stop();
                    num = 20;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                }
                if (spnCanciones.SelectedItem.ToString() == "Speed Of Sound / Coldplay")
                {
                    music.Stop();
                    num = 21;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                }
            };

            btnAtras.Click += delegate { atras(); }; 
            btnSig.Click += delegate { sig(); };
            btnRandom.Click += delegate { random(); }; 
            btnRep.Click += delegate { rep(); };

            btnPlay.Click += delegate 
            {
                if (cont == 0)
                {
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                    music.Start();
                    cont++;
                }
                else
                {
                    btnPlay.SetBackgroundResource(Resource.Drawable.playN);
                    music.Pause();
                    cont = 0;
                }
                
            };

            void atras()
            {
                music.Stop();

                if (num == 1)
                {
                    num = 21;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                    spnCanciones.SetSelection(0);
                }
                else
                {
                    num = num - 1;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                    spnCanciones.SetSelection(0);
                }

            }
            void sig()
            {
                music.Stop();

                if (num == 21)
                {
                    num = 1;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                    spnCanciones.SetSelection(0);
                }
                else
                {
                    num = num + 1;
                    cont = 1;
                    music = Musica();
                    music.Start();
                    btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
                    spnCanciones.SetSelection(0);
                }
            }
            void random()
            {
                music.Stop();

                Random random = new Random();
                num = random.Next(1, 21);
                spnCanciones.SetSelection(0); 

                cont = 1;
                music = Musica();
                music.Start();
                btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);
            }
            void rep()
            {
                music.Stop();

                cont = 1;
                music = Musica();
                music.Start();
                btnPlay.SetBackgroundResource(Resource.Drawable.pausaN);

                gracias++;
                if (gracias%3 == 0)
                {
                    txtMusica.Text = "No lo implemente pero...";
                    txtAutor.Text = "Gracias";
                    Caratula.SetImageResource(Resource.Drawable.guia);
                }
            }

            MediaPlayer Musica()
            {
                switch (num)
                {
                    case 1:
                        MediaPlayer musica1 = MediaPlayer.Create(this, Resource.Mipmap.Adentro);
                        txtMusica.Text = "Adentro";
                        txtAutor.Text = "Calle 13";
                        Caratula.SetImageResource(Resource.Drawable.Adentro);
                        musica1.Start();

                        //ProgressBar.Progress = 0;
                        //txtTiemIni.Text = "0";

                        //int duracion = musica1.Duration;
                        //TimeSpan time = TimeSpan.FromMilliseconds(duracion);
                        //int segundos = Convert.ToInt32(time.TotalSeconds);
                        //txtTiemFin.Text = segundos.ToString();

                        //ProgressBar.Min = 0;
                        //ProgressBar.Max = segundos;
                        //timer.Interval = 1000;
                        //int segTrans = 0;

                        //timer.Elapsed += OnTimerElapsed;
                        //timer.Start();

                        //void OnTimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
                        //{
                        //    if (segTrans >= segundos)
                        //    {
                        //        timer.Stop();
                        //    }
                        //    segTrans++;
                        //    ProgressBar.Progress = segTrans;
                        //    txtTiemIni.Text = segTrans.ToString();
                        //}
                        return musica1;
                    case 2:
                        MediaPlayer musica2 = MediaPlayer.Create(this, Resource.Mipmap.ADiosLePido);
                        txtMusica.Text = "A Dios Le Pido";
                        txtAutor.Text = "Juanes";
                        Caratula.SetImageResource(Resource.Drawable.ADiosLePido);
                        musica2.Start();
                        return musica2;
                    case 3:
                        MediaPlayer musica3 = MediaPlayer.Create(this, Resource.Mipmap.Brillas);
                        txtMusica.Text = "Brillas";
                        txtAutor.Text = "León Larregui";
                        Caratula.SetImageResource(Resource.Drawable.Brillas);
                        musica3.Start();
                        return musica3;
                    case 4:
                        MediaPlayer musica4 = MediaPlayer.Create(this, Resource.Mipmap.Comomeencanta);
                        txtMusica.Text = "Como Me Encanta";
                        txtAutor.Text = "Kevin Kaarl";
                        Caratula.SetImageResource(Resource.Drawable.Comomeencanta);
                        musica4.Start();
                        return musica4;
                    case 5:
                        MediaPlayer musica5 = MediaPlayer.Create(this, Resource.Mipmap.EsPorTi);
                        txtMusica.Text = "Es Por Tí";
                        txtAutor.Text = "Juanes";
                        Caratula.SetImageResource(Resource.Drawable.EsPorTi);
                        musica5.Start();
                        return musica5;
                    case 6:
                        MediaPlayer musica6 = MediaPlayer.Create(this, Resource.Mipmap.HipsDontLie);
                        txtMusica.Text = "Hips Don't Lie";
                        txtAutor.Text = "Wyclef Jean - Shakira";
                        Caratula.SetImageResource(Resource.Drawable.HipsDondtLie);
                        musica6.Start();
                        return musica6;
                    case 7:
                        MediaPlayer musica7 = MediaPlayer.Create(this, Resource.Mipmap.ItsTime);
                        txtMusica.Text = "It's Time";
                        txtAutor.Text = "Imagine Dragons";
                        Caratula.SetImageResource(Resource.Drawable.ItsTime);
                        musica7.Start();
                        return musica7;
                    case 8:
                        MediaPlayer musica8 = MediaPlayer.Create(this, Resource.Mipmap.LabiosCompartidos);
                        txtMusica.Text = "Labios Compartidos";
                        txtAutor.Text = "Maná";
                        Caratula.SetImageResource(Resource.Drawable.LabiosCompartidos);
                        musica8.Start();
                        return musica8;
                    case 9:
                        MediaPlayer musica9 = MediaPlayer.Create(this, Resource.Mipmap.LaLaLa);
                        txtMusica.Text = "La la la";
                        txtAutor.Text = "Naughty Boy";
                        Caratula.SetImageResource(Resource.Drawable.Lalala);
                        musica9.Start();
                        return musica9;
                    case 10:
                        MediaPlayer musica10 = MediaPlayer.Create(this, Resource.Mipmap.LaPerfectaOcasion);
                        txtMusica.Text = "La Perfecta Ocasion";
                        txtAutor.Text = "Gocho";
                        Caratula.SetImageResource(Resource.Drawable.LaPerfectoOcasion);
                        musica10.Start();
                        return musica10;
                    case 11:
                        MediaPlayer musica11 = MediaPlayer.Create(this, Resource.Mipmap.Love);
                        txtMusica.Text = "Love";
                        txtAutor.Text = "Zoé";
                        Caratula.SetImageResource(Resource.Drawable.Love);
                        musica11.Start();
                        return musica11;
                    case 12:
                        MediaPlayer musica12 = MediaPlayer.Create(this, Resource.Mipmap.malo);
                        txtMusica.Text = "El Malo";
                        txtAutor.Text = "Aventura";
                        Caratula.SetImageResource(Resource.Drawable.ElMalo);
                        musica12.Start();
                        return musica12;
                    case 13:
                        MediaPlayer musica13 = MediaPlayer.Create(this, Resource.Mipmap.OjosColorSol);
                        txtMusica.Text = "Ojos Color Sol";
                        txtAutor.Text = "Calle 13";
                        Caratula.SetImageResource(Resource.Drawable.OjosColorSol);
                        musica13.Start();
                        return musica13;
                    case 14:
                        MediaPlayer musica14 = MediaPlayer.Create(this, Resource.Mipmap.OnMelancholyHill);
                        txtMusica.Text = "On Melancholy Hill";
                        txtAutor.Text = "Gorillaz";
                        Caratula.SetImageResource(Resource.Drawable.OnMelancolyHill);
                        musica14.Start();
                        return musica14;
                    case 15:
                        MediaPlayer musica15 = MediaPlayer.Create(this, Resource.Mipmap.Riptide);
                        txtMusica.Text = "Riptide";
                        txtAutor.Text = "Vance Joy";
                        Caratula.SetImageResource(Resource.Drawable.Riptide);
                        musica15.Start();
                        return musica15;
                    case 16:
                        MediaPlayer musica16 = MediaPlayer.Create(this, Resource.Mipmap.SaveYourTears);
                        txtMusica.Text = "Save Your Tears";
                        txtAutor.Text = "The Weeknd";
                        Caratula.SetImageResource(Resource.Drawable.SaveYourTears);
                        musica16.Start();
                        return musica16;
                    case 17:
                        MediaPlayer musica17 = MediaPlayer.Create(this, Resource.Mipmap.SomewhereOnlyWeKnow);
                        txtMusica.Text = "Somewhere Only We Know";
                        txtAutor.Text = "Keane";
                        Caratula.SetImageResource(Resource.Drawable.SomewhereOnlyWeKnow);
                        musica17.Start();
                        return musica17;
                    case 18:
                        MediaPlayer musica18 = MediaPlayer.Create(this, Resource.Mipmap.StoletheShow);
                        txtMusica.Text = "Stole The Show";
                        txtAutor.Text = "Kygo";
                        Caratula.SetImageResource(Resource.Drawable.StoleTheShow);
                        musica18.Start();
                        return musica18;
                    case 19:
                        MediaPlayer musica19 = MediaPlayer.Create(this, Resource.Mipmap.ZoeLabiosRotos);
                        txtMusica.Text = "Labios Rotos";
                        txtAutor.Text = "Zoé";
                        Caratula.SetImageResource(Resource.Drawable.LabiosRotos);
                        musica19.Start();
                        return musica19;
                    case 20:
                        MediaPlayer musica20 = MediaPlayer.Create(this, Resource.Mipmap.ZoeLuna);
                        txtMusica.Text = "Luna";
                        txtAutor.Text = "Zoé";
                        Caratula.SetImageResource(Resource.Drawable.Luna);
                        musica20.Start();
                        return musica20;
                    case 21:
                        MediaPlayer musica21 = MediaPlayer.Create(this, Resource.Mipmap.SpeedofSound);
                        txtMusica.Text = "Speed Of Sound";
                        txtAutor.Text = "Coldplay";
                        Caratula.SetImageResource(Resource.Drawable.SpeedofSound);
                        musica21.Start();
                        return musica21;
                    default:
                        return null;
                }
            }

        }

        public override void OnBackPressed()
        {
            // Dejar en blanco o devolver true para evitar el retroceso
        }

    }
}