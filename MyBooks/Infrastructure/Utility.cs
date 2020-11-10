namespace Infrastructure
{
   public static class Utility : object
    {
        static Utility()
        {
        }
        public static Models.User AuthenticatedUser { get; set; }

        public static System.Drawing.Color FormBackcolor { get; set; }
        public static System.Drawing.Color FormTextColor { get; set; }
        public static System.Drawing.Color FormButtonBackColor { get; set; }

        private static MyApplication.LanguageForm languageForm;
        public static MyApplication.LanguageForm LanguageForm
        {
            get
            {
                if (languageForm == null || languageForm.IsDisposed==true)
                {
                    languageForm = new MyApplication.LanguageForm(); 
                }
                return languageForm;
            }
        }

        private static MyApplication.LoginForm loginForm;
        public static MyApplication.LoginForm LoginForm
        {
            get
            {
                if (loginForm == null || loginForm.IsDisposed == true)
                {
                    loginForm = new MyApplication.LoginForm();
                }
                return loginForm;
            }
        }

        private static MyApplication.RegisterForm registerForm;
        public static MyApplication.RegisterForm RegisterForm
        {
            get
            {
                if (registerForm == null || registerForm.IsDisposed == true)
                {
                    registerForm = new MyApplication.RegisterForm();
                }
                return registerForm;
            }
        }

    }
}
