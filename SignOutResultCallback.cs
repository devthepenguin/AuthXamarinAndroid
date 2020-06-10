using System;
using Android.Gms.Common.Apis;
using Java.Interop;

namespace GoogleSignIn
{
	public class SignOutResultCallback : Java.Lang.Object, IResultCallback
	{
		public MainActivity Activity { get; set; }

        public void OnResult(System.Object result)
		{
			Activity.UpdateUI(false);
		}

        public void OnResult(Java.Lang.Object result)
        {
            // TODO
        }
    }
}