namespace Infrastructure
{
   public static class Utility : object
    {
        static Utility()
        {
        }
        public static Models.User AuthenticatedUser { get; set; }



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





    }
}
