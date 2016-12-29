using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


namespace evfa
{
    /*   [Activity(Label = "JobDetails")]
       public class JobDetails : Activity
       {
           protected override void OnCreate(Bundle savedInstanceState)
           {
               base.OnCreate(savedInstanceState);

               // Create your application here
           }
       }*/
    //from here
    [Activity(Label = "EVFAJob", MainLauncher = false, Icon = "@drawable/icon", ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]

    public class EVFAJob : Activity
    {

        public static bool isConnected;
        public static bool isSmsAvailable;

        // public static OBS1Tab o1t;
        //public static OBS1Tab o2t;




        protected override void OnCreate(Bundle bundle)
        {
            if (Android.OS.Build.VERSION.SdkInt > BuildVersionCodes.Gingerbread)
            {
                StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().PermitAll().Build();
                StrictMode.SetThreadPolicy(policy);
            }
            base.OnCreate(bundle);



            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.JobDetails);
            //      o1t = new OBS1Tab();
            //      o2t = new OBS1Tab();
            //Obs1Complete = o1t.completed;
            this.ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            this.ActionBar.SetIcon(Resource.Drawable.Icon);
            //this.ActionBar.
            //       AddTab("OBS1", Resource.Drawable.eye32321, o1t); // new OBS1Tab ());
            //       AddTab("OBS2", Resource.Drawable.eye32322, o2t); // new OBS1Tab ());
            //       AddTab("GCS", Resource.Drawable.gcs3232, new GCSTab());
            //       AddTab("Transmit", Resource.Drawable.transmitter, new SendTab());

            if (bundle != null)
                this.ActionBar.SelectTab(this.ActionBar.GetTabAt(bundle.GetInt("tab")));
            // check comms
            //      connstat();

        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            outState.PutInt("tab", this.ActionBar.SelectedNavigationIndex);

            base.OnSaveInstanceState(outState);

        }

        void AddTab(string tabText, int iconResourceId, Fragment view)
        {
            var tab = this.ActionBar.NewTab();
            tab.SetText(tabText);
            tab.SetIcon(iconResourceId);

            // must set event handler before adding tab
            tab.TabSelected += delegate (object sender, ActionBar.TabEventArgs e)
            {

                var fragment = this.FragmentManager.FindFragmentById(Resource.Id.fragmentContainer);

                if (fragment != null)
                {
                    e.FragmentTransaction.Remove(fragment);

                }
                e.FragmentTransaction.Add(Resource.Id.fragmentContainer, view, tabText);
                //	if(fragment.Tag == "OBS1" || fragment.Tag == "OBS2")
                //	{
                //		OBS1Tab.calcnewssepsis(); 
                //	}
            };
            tab.TabUnselected += delegate (object sender, ActionBar.TabEventArgs e)
            {
                var fragment = this.FragmentManager.FindFragmentById(Resource.Id.fragmentContainer);
                if (fragment != null)
                {
                    string s = fragment.Tag;
                }
                e.FragmentTransaction.Remove(view);
                /*				if(fragment.Tag == "OBS1")
                                {
                                    CheckBox oc = fragment.View.FindViewById<CheckBox> (Resource.Id.chkComplete);
                                    Obs1Complete = oc.Checked;	
                                    //Obs1Complete = fragment.Resources.GetBoolean(Resource.Id.chkComplete);
                                    //view.FindViewById<EditText> (Resource.Id.txtResp);
                                }
                                if(fragment.Tag == "OBS2")
                                {

                                    //view.FindViewById<EditText> (Resource.Id.txtResp);
                                    Obs2Complete = view.Resources.GetBoolean(Resource.Id.chkComplete);
                                }
                                if(view.Tag=="Transmit")
                                {
                                    CheckBox o1c = view.View.FindViewById<CheckBox> (Resource.Id.chkobs1);
                                    CheckBox o2c = view.View.FindViewById<CheckBox> (Resource.Id.chkobs2);

                                    //CheckBox o1c = view.Resources.  n(Resource.Id.chkobs1);
                                    //CheckBox o2c = view.FindViewById<CheckBox> (Resource.Id.chkobs2);
                                    //o1c.Checked = Obs1Complete;
                                    //o2c.Checked = Obs2Complete;
                                }
                */
            };

            this.ActionBar.AddTab(tab);
            this.FragmentManager.ExecutePendingTransactions();

        }

        //to here
    }
}