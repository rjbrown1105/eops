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
    [Activity(Label = "prf")]
    public class prf : Activity
    {
        private prfTabpd ptpd;
        private OBSTab o1t;
        private OBSTab o2t;
        private prfDetails pdet;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "prf" layout resource
            SetContentView(Resource.Layout.eprfTab);
            ptpd = new prfTabpd();
            o1t = new OBSTab();
            o2t = new OBSTab();
            pdet = new prfDetails();
// setup action bar
            this.ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            this.ActionBar.SetIcon(Resource.Drawable.Icon);
//add tabs            
            AddTab("P Det", Resource.Drawable.Users, ptpd); 
            AddTab("OBS1", Resource.Drawable.eye32321, o1t); // new OBS1Tab ());
            AddTab("OBS2", Resource.Drawable.eye32322, o2t); // new OBS2Tab ());
            AddTab("Details", Resource.Drawable.Details, pdet);

            if (savedInstanceState != null)
                this.ActionBar.SelectTab(this.ActionBar.GetTabAt(savedInstanceState.GetInt("tab")));

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

            };
            tab.TabUnselected += delegate (object sender, ActionBar.TabEventArgs e) {
                var fragment = this.FragmentManager.FindFragmentById(Resource.Id.fragmentContainer);
                if (fragment != null)
                {
                    string s = fragment.Tag;
                }
                e.FragmentTransaction.Remove(view);

            };

            this.ActionBar.AddTab(tab);
            this.FragmentManager.ExecutePendingTransactions();

        }
    }

    class prfTabpd : Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.prfTabpd, container, false);
            return view;
        }
    }
        class prfDetails : Fragment
        {
            public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
            {
                base.OnCreateView(inflater, container, savedInstanceState);

                var view = inflater.Inflate(Resource.Layout.prfDetails, container, false);
                return view;
            }
        }

        public class OBSTab : Fragment
    {
        public bool completed = false;
        private EditText txtResp;
        private EditText txtO2Sats;
        private CheckBox chkonO2;
        private EditText txtTemp;
        private EditText txtPulse;
        private EditText txtBPSys;
        private EditText txtBPDia;
        private RadioButton rbAVPUA;
        private RadioGroup rgavpu;
        private EditText txtCBG;
        private CheckBox chkInf;
        private TextView txtNews;
        private TextView txtSepsis;
        private TextView txtTime;
        private TextView txtError;
        private Button btnSave;
        private CheckBox chkComplete;
        private int news = 0;
        private int sepsis = 0;
        private static int obsno = 0;

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {

        }

        public override void OnViewStateRestored(Bundle savedInstanceState)
        {
            base.OnViewStateRestored(savedInstanceState);
            refresh_scrn();

        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.ObsTab, container, false);
            var sampleTextView = view.FindViewById<TextView>(Resource.Id.sampleTextView);
            //sampleTextView.Text = "First Observations";
            txtResp = view.FindViewById<EditText>(Resource.Id.txtResp);
            txtO2Sats = view.FindViewById<EditText>(Resource.Id.txtO2sats);
            chkonO2 = view.FindViewById<CheckBox>(Resource.Id.chkonO2);
            txtTemp = view.FindViewById<EditText>(Resource.Id.txtTemp);
            txtPulse = view.FindViewById<EditText>(Resource.Id.txtPulse);
            txtBPSys = view.FindViewById<EditText>(Resource.Id.txtBPSys);
            txtBPDia = view.FindViewById<EditText>(Resource.Id.txtBPDia);
            rgavpu = view.FindViewById<RadioGroup>(Resource.Id.ctvavpu);

            rbAVPUA = view.FindViewById<RadioButton>(Resource.Id.rbAVPUA);
            txtCBG = view.FindViewById<EditText>(Resource.Id.txtCBG);
            chkInf = view.FindViewById<CheckBox>(Resource.Id.chkInf);
            txtNews = view.FindViewById<TextView>(Resource.Id.txtNews);
            txtSepsis = view.FindViewById<TextView>(Resource.Id.txtSepsis);
            txtError = view.FindViewById<TextView>(Resource.Id.txtError);
            txtTime = view.FindViewById<TextView>(Resource.Id.txtTime);
            btnSave = view.FindViewById<Button>(Resource.Id.btnSave);
            chkComplete = view.FindViewById<CheckBox>(Resource.Id.chkComplete);
            txtResp.FocusChange += TxtResp_FocusChange;
            txtO2Sats.FocusChange += TxtO2Sats_FocusChange;
            chkonO2.CheckedChange += ChkonO2_CheckedChange;
            txtTemp.FocusChange += TxtTemp_FocusChange;
            rgavpu.CheckedChange += Rgavpu_CheckedChange;
            /*	rgavpu.SetOnCheckedChangeListener(new OnCheckedChangeListener() 
                    {
                        public void onCheckedChanged(RadioGroup group, int checkedId) 
                        {

                            if(tea.isChecked())
                            {
                                Toast.makeText(MainActivity.this,"Tea is selected", Toast.LENGTH_SHORT).show();
                            }
                        })*/
            //rgavpu = new RadioGroup();

            rbAVPUA.FocusChange += RbAVPUA_FocusChange;
            txtPulse.FocusChange += TxtPulse_FocusChange;
            txtBPSys.FocusChange += TxtBPSys_FocusChange;
            txtBPDia.FocusChange += TxtBPDia_FocusChange;
            txtCBG.FocusChange += TxtCBG_FocusChange;

            btnSave.Click += BtnSave_Click;
            var fragment = this.FragmentManager.FindFragmentById(Resource.Id.fragmentContainer);
            if (fragment.Tag == "OBS1")
            {
                obsno = 1;
                sampleTextView.Text = "First Observations";
            }

            else
            {
                obsno = 2;
                sampleTextView.Text = "Second Observations";
            }

            return view;
        }

        private void Rgavpu_CheckedChange(object sender, RadioGroup.CheckedChangeEventArgs e)
        {
            calcnewssepsis();
        }

        void RbAVPUA_FocusChange(object sender, View.FocusChangeEventArgs e)
        {
            calcnewssepsis();
        }


        public void clrdown()
        {

            news = 0;
            sepsis = 0;
            obsno = 0;
            rbAVPUA.Text = "A";
            txtResp.Text = "";
            txtResp.SetBackgroundColor(Android.Graphics.Color.Black);
            txtPulse.Text = "";
            txtPulse.SetBackgroundColor(Android.Graphics.Color.Black);
            txtO2Sats.Text = "";
            txtO2Sats.SetBackgroundColor(Android.Graphics.Color.Black);
            txtBPSys.Text = "";
            txtBPSys.SetBackgroundColor(Android.Graphics.Color.Black);
            txtBPDia.Text = "";
            txtBPDia.SetBackgroundColor(Android.Graphics.Color.Black);
            txtCBG.Text = "";
            txtCBG.SetBackgroundColor(Android.Graphics.Color.Black);
            chkonO2.Checked = false;
            chkInf.Checked = false;
            txtNews.Text = "";
            txtNews.SetBackgroundColor(Android.Graphics.Color.Black);
            txtSepsis.Text = "";
            txtSepsis.SetBackgroundColor(Android.Graphics.Color.Black);
            txtError.Text = "";
            txtError.SetBackgroundColor(Android.Graphics.Color.Black);
            txtTime.Text = "";
            chkComplete.Checked = false;



        }

        void BtnSave_Click(object sender, EventArgs e)
        {
            calcnewssepsis();
        }

        void TxtCBG_FocusChange(object sender, View.FocusChangeEventArgs e)
        {
            if (txtCBG.Text.Length > 0)
            {
                int a = calccbg();
            }
        }

        void TxtBPSys_FocusChange(object sender, View.FocusChangeEventArgs e)
        {
            if (txtBPSys.Text.Length > 0)
            {
                int a = calcbp();
            }
        }
        void TxtBPDia_FocusChange(object sender, View.FocusChangeEventArgs e)
        {
            if (txtBPSys.Text.Length > 0)
            {
                int a = calcbp();
            }
        }
        void TxtPulse_FocusChange(object sender, View.FocusChangeEventArgs e)
        {
            if (txtPulse.Text.Length > 0)
            {
                int a = calcpulse();
            }
        }

        void TxtTemp_FocusChange(object sender, View.FocusChangeEventArgs e)
        {
            if (txtTemp.Text.Length > 0)
            {
                int a = calctemp();
            }
        }

        void ChkonO2_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            int a = calcono2();
        }

        void TxtResp_FocusChange(object sender, View.FocusChangeEventArgs e)
        {
            if (txtResp.Text.Length > 0)
            {
                int a = calcnewsresps();
            }
        }

        void TxtO2Sats_FocusChange(object sender, View.FocusChangeEventArgs e)
        {
            if (txtO2Sats.Text.Length > 0)
            {
                int a = calcnewso2sats();
            }
        }

        private int calcnewsresps()
        {
            int res = 0;
            int resps = 0;

            resps = Convert.ToInt32(txtResp.Text);

            if (resps <= 8) res = 3;
            if (resps >= 9 && resps <= 11) res = 1;
            if (resps >= 12 && resps <= 20) res = 0;
            if (resps >= 21 && resps <= 24) res = 2;
            if (resps >= 25) res = 3;
            if (res == 0)
            {
                txtResp.SetBackgroundColor(Android.Graphics.Color.Green);
                txtResp.SetTextColor(Android.Graphics.Color.Black);
            }
            if (res > 0 && res < 3)
            {
                txtResp.SetBackgroundColor(Android.Graphics.Color.Orange);
                txtResp.SetTextColor(Android.Graphics.Color.White);
            }
            if (res == 3)
            {
                txtResp.SetBackgroundColor(Android.Graphics.Color.Red);
                txtResp.SetTextColor(Android.Graphics.Color.White);
            }
            return res;
        }

        private int calcnewso2sats()
        {
            int res = 0;
            int o2sats = 0;

            o2sats = Convert.ToInt32(txtO2Sats.Text);
            if (o2sats <= 91) res = 3;
            if (o2sats >= 92 && o2sats <= 93) res = 2;
            if (o2sats >= 94 && o2sats <= 95) res = 1;
            if (o2sats >= 96) res = 0;
            if (res == 0)
            {
                txtO2Sats.SetBackgroundColor(Android.Graphics.Color.Green);
                txtO2Sats.SetTextColor(Android.Graphics.Color.Black);
            }
            if (res > 0 && res < 3)
            {
                txtO2Sats.SetBackgroundColor(Android.Graphics.Color.Orange);
                txtO2Sats.SetTextColor(Android.Graphics.Color.White);
            }
            if (res == 3)
            {
                txtO2Sats.SetBackgroundColor(Android.Graphics.Color.Red);
                txtO2Sats.SetTextColor(Android.Graphics.Color.White);
            }
            return res;
        }

        private int calcono2()
        {
            int retval = 0;

            if (chkonO2.Checked) retval = 2;
            return retval;
        }
        private int calctemp()
        {
            int res = 0;
            double temp = 0;

            temp = Convert.ToDouble(txtTemp.Text);
            if (temp <= 35) res = 3;
            if (temp >= 35.1 && temp <= 36) res = 1;
            if (temp >= 36.1 && temp <= 38) res = 0;
            if (temp >= 38.1 && temp <= 39) res = 1;
            if (temp >= 39.1) res = 2;
            if (res == 0)
            {
                txtTemp.SetBackgroundColor(Android.Graphics.Color.Green);
                txtTemp.SetTextColor(Android.Graphics.Color.Black);
            }
            if (res > 0 && res < 3)
            {
                txtTemp.SetBackgroundColor(Android.Graphics.Color.Orange);
                txtTemp.SetTextColor(Android.Graphics.Color.White);
            }
            if (res == 3)
            {
                txtTemp.SetBackgroundColor(Android.Graphics.Color.Red);
                txtTemp.SetTextColor(Android.Graphics.Color.White);
            }

            return res;
        }
        private int calcpulse()
        {
            int res = 0;
            double pulse = 0;

            pulse = Convert.ToDouble(txtPulse.Text);
            if (pulse <= 40) res = 3;
            if (pulse >= 41 && pulse <= 50) res = 1;
            if (pulse >= 51 && pulse <= 90) res = 0;
            if (pulse >= 91 && pulse <= 110) res = 1;
            if (pulse >= 111 && pulse <= 130) res = 2;
            if (pulse >= 131) res = 3;
            if (res == 0)
            {
                txtPulse.SetBackgroundColor(Android.Graphics.Color.Green);
                txtPulse.SetTextColor(Android.Graphics.Color.Black);
            }
            if (res > 0 && res < 3)
            {
                txtPulse.SetBackgroundColor(Android.Graphics.Color.Orange);
                txtPulse.SetTextColor(Android.Graphics.Color.White);
            }
            if (res == 3)
            {
                txtPulse.SetBackgroundColor(Android.Graphics.Color.Red);
                txtPulse.SetTextColor(Android.Graphics.Color.White);
            }

            return res;
        }

        private int calcbp()
        {
            int res = 0;
            int bp = 0;
            bp = Convert.ToInt32(txtBPSys.Text);
            if (bp <= 90) res = 3;
            if (bp >= 91 && bp <= 100) res = 1;
            if (bp >= 101 && bp <= 110) res = 1;
            if (bp >= 111 && bp <= 219) res = 0;
            if (bp >= 220) res = 3;
            if (res == 0)
            {
                txtBPSys.SetBackgroundColor(Android.Graphics.Color.Green);
                txtBPSys.SetTextColor(Android.Graphics.Color.Black);
            }
            if (res > 0 && res < 3)
            {
                txtBPSys.SetBackgroundColor(Android.Graphics.Color.Orange);
                txtBPSys.SetTextColor(Android.Graphics.Color.White);
            }
            if (res == 3)
            {
                txtBPSys.SetBackgroundColor(Android.Graphics.Color.Red);
                txtBPSys.SetTextColor(Android.Graphics.Color.White);
            }
            if (txtBPDia.Text.Length > 0)
            {
                if (res == 0)
                {
                    txtBPDia.SetBackgroundColor(Android.Graphics.Color.Green);
                    txtBPDia.SetTextColor(Android.Graphics.Color.Black);
                }
                if (res > 0 && res < 3)
                {
                    txtBPDia.SetBackgroundColor(Android.Graphics.Color.Orange);
                    txtBPDia.SetTextColor(Android.Graphics.Color.White);
                }
                if (res == 3)
                {
                    txtBPDia.SetBackgroundColor(Android.Graphics.Color.Red);
                    txtBPDia.SetTextColor(Android.Graphics.Color.White);
                }

            }
            return res;
        }
        private int calcavpu()
        {
            int res = 3;
            //  RadioButton rbAVPUs = this.f res view.FindViewById<RadioButton>(Resource.Id.rbAVPUA);
            // get selected radio button from radioGroup
            int selectedId = rgavpu.CheckedRadioButtonId;

            // find the radiobutton by returned id
            RadioButton radioButton = (RadioButton)View.FindViewById(selectedId);
            if (radioButton.Text == "A")
            {
                res = 0;
            }
            return res;
        }
        private int calccbg()
        {
            //sepsis only
            int res = 0;
            double cbg = 0;

            cbg = Convert.ToDouble(txtCBG.Text);


            if (cbg >= 7.7) res = 1;
            if (res == 0)
            {
                txtCBG.SetBackgroundColor(Android.Graphics.Color.Green);
                txtCBG.SetTextColor(Android.Graphics.Color.Black);
            }
            if (res > 0 && res < 3)
            {
                txtCBG.SetBackgroundColor(Android.Graphics.Color.Orange);
                txtCBG.SetTextColor(Android.Graphics.Color.White);
            }
            if (res == 3)
            {
                txtCBG.SetBackgroundColor(Android.Graphics.Color.Red);
                txtCBG.SetTextColor(Android.Graphics.Color.White);
            }

            return res;
        }
        private int calcinf()
        {
            int retval = 0;
            if (chkInf.Selected)
                retval = 1;

            return retval;
        }
        public bool all_filled()
        {
            bool retval = false;
            int ret = 0;

            if (txtBPDia.Text.Length > 0)
            {
                ret++;
                //lblo1bpdia.Visible = false;
            }
            else
            {
                //lblo1bpdia.Visible = true;
            }
            if (txtBPSys.Text.Length > 0)
            {
                ret++;
            }
            else
            {
                //lblo1bpdia.Visible = true;
            }
            if (txtCBG.Text.Length > 0) ret++;
            if (txtPulse.Text.Length > 0) ret++;
            if (txtResp.Text.Length > 0) ret++;
            if (txtO2Sats.Text.Length > 0) ret++;
            if (txtTemp.Text.Length > 0) ret++;
            //if (chkInf.Selected) ret++;
            //if (dd_o1avpu.SelectedIndex > 0) ret++;

            if (ret == 7)
            {
                if (txtTime.Text.Length == 0)
                {
                    txtTime.Text = DateTime.Now.ToString("HH:mm:ss");
                }
                retval = true;
            }


            return retval;
        }

        public void refresh_scrn()
        {
            int tmp = 0;
            if (txtBPDia.Text.Length > 0 && txtBPSys.Text.Length > 0) tmp += calcbp();
            if (txtCBG.Text.Length > 0) tmp += calccbg();
            if (txtPulse.Text.Length > 0) tmp += calcpulse();
            if (txtTemp.Text.Length > 0) tmp += calctemp();
            if (txtO2Sats.Text.Length > 0) tmp += calcnewso2sats();
            if (txtResp.Text.Length > 0) tmp += calcnewsresps();
        }

        public void calcnewssepsis()
        {
            int tmp = 0;
            news = 0;
            sepsis = 0;

            if (all_filled())
            {
                tmp = calcnewsresps();
                news += tmp;
                if (tmp > 1)
                {
                    sepsis += 1;
                }
                tmp = calctemp();
                if (tmp > 0)
                {
                    sepsis += 1;
                }
                news += tmp;
                tmp = calcpulse();
                if (tmp > 0)
                {
                    sepsis += 1;
                }
                //if (tmp < 0) {
                //	tmp = tmp * -1;
                //}
                news += tmp;
                news += calcbp();
                tmp = calcavpu();
                news += tmp;
                if (tmp > 0)
                {
                    sepsis += 1;
                }
                news += calcnewso2sats();
                news += calcono2();
                sepsis += calccbg();
                sepsis += calcinf();

                if (news < 5)
                {
                    txtNews.SetBackgroundColor(Android.Graphics.Color.Green);
                    txtNews.SetTextColor(Android.Graphics.Color.Black);
                }
                if (news == 5 || news == 6)
                {
                    txtNews.SetBackgroundColor(Android.Graphics.Color.Orange);
                    txtNews.SetTextColor(Android.Graphics.Color.White);
                }
                if (news > 6)
                {
                    txtNews.SetBackgroundColor(Android.Graphics.Color.Red);
                    txtNews.SetTextColor(Android.Graphics.Color.White);
                }
                if (sepsis < 4)
                {
                    txtSepsis.SetBackgroundColor(Android.Graphics.Color.Green);
                    txtSepsis.SetTextColor(Android.Graphics.Color.Black);
                }
                //if (sepsis ==5 || news ==6)
                //	txtSepsis.SetBackgroundColor (Android.Graphics.Color.Orange);
                if (sepsis >= 4)
                {
                    txtSepsis.SetBackgroundColor(Android.Graphics.Color.Red);
                    txtSepsis.SetTextColor(Android.Graphics.Color.White);
                }


                txtNews.Text = news.ToString();
                txtSepsis.Text = sepsis.ToString();
                if (txtNews.Text.Trim().Length > 0)
                {
                    txtTime.Text = DateTime.Now.ToString("HH:mm:ss");
                    completed = true;
                }

                //tb.Focus();
            }
            else
            {
                completed = false;
            }
            chkComplete.Checked = completed;




          //  CASAct.setcompleted(obsno, completed);
          //  CASAct.stashop(obsno, makesavestring());
        }

        private string makesavestring()
        {
            string savestring = "";
            savestring += rbAVPUA.Text + "|";
            savestring += txtResp.Text + "|";
            savestring += txtPulse.Text + "|";
            savestring += txtO2Sats.Text + "|";
            if (chkonO2.Checked)
            {
                savestring += "Y|";
            }
            else
            {
                savestring += "N|";
            }
            savestring += txtTemp.Text + "|";
            savestring += txtBPSys.Text + "|";
            savestring += txtBPDia.Text + "|";
            savestring += txtCBG.Text + "|";
            if (chkInf.Checked)
            {
                savestring += "Y|";
            }
            else
            {
                savestring += "N|";
            }
            savestring += txtNews.Text + "|";
            savestring += txtSepsis.Text + "|";
            savestring += txtTime.Text + "|";
            savestring += DateTime.Now.Date.ToString("dd-MM-yyyy");
            return savestring;
        }

    }


}