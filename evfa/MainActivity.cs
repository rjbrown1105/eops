using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace evfa
{
    [Activity(Label = "evfa", MainLauncher = true, Icon = "@drawable/eops32")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button btnNormalDialog = FindViewById<Button>(Resource.Id.MyButton);
            btnNormalDialog.Click += methodInvokeBaseAlertDialog;
           // Button button = FindViewById<Button>(Resource.Id.MyButton);
            ImageView imgctrl = FindViewById<ImageView>(Resource.Id.imgmain);
            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            //  imgctrl.OnTouchEvent += OnTouchEvente();
        }
        public override bool OnTouchEvent(MotionEvent e)
        {

            if (e.Action == MotionEventActions.Down)
            {
                float fPositionX = e.GetX();
                float fPositionY = e.GetY();
                EventControl(fPositionX, fPositionY);
            }

            return base.OnTouchEvent(e);
        }
        private void InitControl()
        {
            //tvScreenSize = FindViewById<TextView>(Resource.Id.tvScreenSize);
        }

        void methodInvokeBaseAlertDialog(object sender, EventArgs e)
        {
            TextView tv1;
            AlertDialog dlgAlert = (new AlertDialog.Builder(this)).Create();
            dlgAlert.SetTitle("Job Alert");
            
            //dlgAlert.Window.SetFeatureDrawable(WindowFeatures.NoTitle,null);
            //dlgAlert.RequestWindowFeature(Window.SetTitle(.FEATURE_NO_TITLE);
            WindowManagerLayoutParams wmlp = dlgAlert.Window.Attributes;
            wmlp.Gravity = GravityFlags.Top | GravityFlags.Left;
            wmlp.X = 100;   //x position
            wmlp.Y = 100;   //y position
            //dlgAlert.Window.WindowManager.LayoutParams wmlp = dialog.getWindow().getAttributes();

            var viewAD = this.LayoutInflater.Inflate(Resource.Layout.JobAlert, null);
            tv1 = viewAD.FindViewById<TextView>(Resource.Id.txtLoc);
            tv1.SetText("Stixwold Rd RA", TextView.BufferType.Normal);
            tv1.SetTextSize(Android.Util.ComplexUnitType.Pt ,24);
           // viewAD.FindViewById<TextView>(Resource.Id.txtLoc).SetText("Stixwold Rd RA", TextView.BufferType.Normal);
            viewAD.FindViewById<TextView>(Resource.Id.txtPriority).SetText("A1", TextView.BufferType.Normal);
            viewAD.FindViewById<TextView>(Resource.Id.txtJobTime).SetText("12:46", TextView.BufferType.Normal);
            viewAD.FindViewById<TextView>(Resource.Id.txtDesc).SetText("RTC - Car v Ped", TextView.BufferType.Normal);
            



            dlgAlert.SetView(viewAD);
            dlgAlert.SetButton("OK", handllerNotingButton);
            dlgAlert.SetButton2("Reject", handllerNotingButton);
            dlgAlert.Show();
        }


        void handllerNotingButton(object sender, DialogClickEventArgs e)
        {
            AlertDialog objAlertDialog = sender as AlertDialog;
            Button btnClicked = objAlertDialog.GetButton(e.Which);
            Toast.MakeText(this, "you clicked on " + btnClicked.Text, ToastLength.Long).Show();
        }
        // snippets
        private void dispAlert()
        { 
        var alert = new AlertDialog.Builder(this);
        alert.SetView(LayoutInflater.Inflate(Resource.Layout.JobAlert, null));
alert.Create().Show();
    }




        private void EventControl(float fPosX, float fPosY)
        {
            // Sleepy
            if (fPosX >= 154 && fPosX <= 183 && fPosY >= 138 && fPosY <= 161)
            {
             /*   MessageBox.Show(this, "Sleepy", ToastLength.Short);
                myItent = new Intent(this, typeof(actMoodSelectScreen));
                myItent.PutExtra("PlanetName", "Sleepy");
                StartActivity(myItent);*/
    }

            // home
            if (fPosX >= 345 && fPosX <= 422 && fPosY >= 1056 && fPosY <= 1161)
            {
               /* MessageBox.Show(this, "Chilling", ToastLength.Short);
                myItent = new Intent(this, typeof(actMoodSelectScreen));
                myItent.PutExtra("PlanetName", "Chilling");
                StartActivity(myItent);*/
            }

            //new
            if (fPosX >= 108 && fPosX <= 181 && fPosY >= 957 && fPosY <= 1041)
            {
               // SetContentView(Resource.Layout.eJob);
               // Activity ac = new Job();
               // ac.SetContentView(Resource.Layout.eJob);
                StartActivity(typeof(Job));
               
                /*  MessageBox.Show(this, "Happy", ToastLength.Short);
                myItent = new Intent(this, typeof(actMoodSelectScreen));
                myItent.PutExtra("PlanetName", "Happy");
                StartActivity(myItent);*/
            }

            //right
            if (fPosX >= 596 && fPosX <= 676 && fPosY >= 954 && fPosY <= 1034)
            {
                // Intent myintent = new Intent(this, typeof(Job));
                //  StartActivity(myintent);
                StartActivity(typeof(Job));
                /* MessageBox.Show(this, "Upset", ToastLength.Short);
                 myItent = new Intent(this, typeof(actMoodSelectScreen));
                 myItent.PutExtra("PlanetName", "Upset");
                 StartActivity(myItent);*/
            }

            //top
            if (fPosX >= 340 && fPosX <= 422 && fPosY >= 917 && fPosY <= 997)
            {
               /* MessageBox.Show(this, "Hungry", ToastLength.Short);
                myItent = new Intent(this, typeof(actMoodSelectScreen));
                myItent.PutExtra("PlanetName", "Hungry");
                StartActivity(myItent);*/
            }
           // MessageBox.Show(this, "x: " + fPosX + " y: " + fPosY, ToastLength.Short);
        }
    }

    // from here

    }

