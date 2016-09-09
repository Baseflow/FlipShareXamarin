using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using System;
using ME.Wangyuwei.Flipshare;
using Android.Graphics;

namespace Sample
{
    [Activity(Label = "FlipShare", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/AppTheme")]
    public class MainActivity : Activity, View.IOnClickListener
    {
        private Button mBtnLeftTop;
        private Button mBtnMiddleTop;
        private Button mBtnRightTop;
        private Button mBtnLeftBottom;
        private Button mBtnMiddleBottom;
        private Button mBtnRightBottom;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            mBtnLeftTop = FindViewById<Button>(Resource.Id.btn_left_top);
            mBtnMiddleTop = FindViewById<Button>(Resource.Id.btn_middle_top);
            mBtnRightTop = FindViewById<Button>(Resource.Id.btn_right_top);
            mBtnLeftBottom = FindViewById<Button>(Resource.Id.btn_left_bottom);
            mBtnMiddleBottom = FindViewById<Button>(Resource.Id.btn_middle_bottom);
            mBtnRightBottom = FindViewById<Button>(Resource.Id.btn_right_bottom);
            mBtnLeftTop.SetOnClickListener(this);
            mBtnMiddleTop.SetOnClickListener(this);
            mBtnRightTop.SetOnClickListener(this);
            mBtnLeftBottom.SetOnClickListener(this);
            mBtnMiddleBottom.SetOnClickListener(this);
            mBtnRightBottom.SetOnClickListener(this);
        }

        public void OnClick(View v)
        {
            switch (v.Id)
            {
                case Resource.Id.btn_left_top:
                    FlipShareView share = new FlipShareView.Builder(this, mBtnLeftTop)
                        .AddItem(new ShareItem("Facebook", Color.White, unchecked((int)0xff43549C), BitmapFactory.DecodeResource(Resources, Resource.Mipmap.ic_facebook)))
                        .AddItem(new ShareItem("Twitter", Color.White, unchecked((int)0xff4999F0), BitmapFactory.DecodeResource(Resources, Resource.Mipmap.ic_twitter)))
                        .AddItem(new ShareItem("Google+", Color.White, unchecked((int)0xffD9392D), BitmapFactory.DecodeResource(Resources, Resource.Mipmap.ic_google)))
                        .AddItem(new ShareItem("http://www.wangyuwei.me", Color.White, unchecked((int)0xff57708A)))
                            .SetBackgroundColor(0x60000000)
                            .Create();

                    break;
                case Resource.Id.btn_middle_top:

                    new FlipShareView.Builder(this, mBtnMiddleTop)
                    .AddItem(new ShareItem("Facebook", Color.White, unchecked((int)0xff43549C), BitmapFactory.DecodeResource(Resources, Resource.Mipmap.ic_facebook)))
                                     .AddItem(new ShareItem("Wangyuwei", Color.White, unchecked((int)0xff4999F0)))
                                     .AddItem(new ShareItem("Wangyuweiwangyuwei", Color.White, unchecked((int)0xffD9392D)))
                                     .AddItem(new ShareItem("纯文字也可以", Color.White, unchecked((int)0xff57708A)))
                            .SetAnimType(FlipShareView.TypeHorizontal)
                            .Create();
                    break;
                case Resource.Id.btn_right_top:
                    new FlipShareView.Builder(this, mBtnRightTop)
                                     .AddItem(new ShareItem("Facebook", Color.White, unchecked((int)0xff43549C), BitmapFactory.DecodeResource(Resources, Resource.Mipmap.ic_facebook)))
                                     .AddItem(new ShareItem("Twitter", Color.White, unchecked((int)0xff4999F0), BitmapFactory.DecodeResource(Resources, Resource.Mipmap.ic_twitter)))
                                     .AddItem(new ShareItem("Google+", Color.White, unchecked((int)0xffD9392D), BitmapFactory.DecodeResource(Resources, Resource.Mipmap.ic_google)))
                                     .AddItem(new ShareItem("http://www.wangyuwei.me", Color.White, unchecked((int)0xff57708A)))
                            .SetItemDuration(500)
                            .SetBackgroundColor(0x60000000)
                            .SetAnimType(FlipShareView.TypeSlide)
                            .Create();
                    break;
                case Resource.Id.btn_left_bottom:
                    new FlipShareView.Builder(this, mBtnLeftBottom)
                            .AddItem(new ShareItem("Facebook"))
                            .AddItem(new ShareItem("Twitter"))
                            .AddItem(new ShareItem("Google+"))
                                     .AddItem(new ShareItem("http://www.wangyuwei.me", Color.White, unchecked((int)0xff57708A)))
                                     .AddItem(new ShareItem("http://www.wangyuwei.me", Color.White, unchecked((int)0xff57708A)))
                            .SetSeparateLineColor(0x30000000)
                            .SetAnimType(FlipShareView.TypeHorizontal)
                            .Create();
                    break;
                case Resource.Id.btn_middle_bottom:
                    new FlipShareView.Builder(this, mBtnMiddleBottom)
                            .AddItem(new ShareItem("Facebook"))
                            .AddItem(new ShareItem("Twitter"))
                            .AddItem(new ShareItem("Google+"))
                                     .AddItem(new ShareItem("http://www.wangyuwei.me", Color.White, unchecked((int)0xff57708A)))
                            .SetSeparateLineColor(0x30000000)
                            .SetBackgroundColor(0x60000000)
                            .SetAnimType(FlipShareView.TypeSlide)
                            .Create();
                    break;
                case Resource.Id.btn_right_bottom:
                    new FlipShareView.Builder(this, mBtnRightBottom)
                                     .AddItem(new ShareItem("Facebook", Color.White, unchecked((int)0xff43549C), BitmapFactory.DecodeResource(Resources, Resource.Mipmap.ic_facebook)))
                                     .AddItem(new ShareItem("Twitter", Color.White, unchecked((int)0xff4999F0), BitmapFactory.DecodeResource(Resources, Resource.Mipmap.ic_twitter)))
                                     .AddItem(new ShareItem("Google+", Color.White, unchecked((int)0xffD9392D), BitmapFactory.DecodeResource(Resources, Resource.Mipmap.ic_google)))
                                     .AddItem(new ShareItem("http://www.wangyuwei.me", Color.White, unchecked((int)0xff57708A)))
                        .Create();
                    break;
            }
        }
    }
}