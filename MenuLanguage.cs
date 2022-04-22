namespace WpfApp
{
    class MenuLanguage
    {
        public string File;
        public string Lang;
        public string Info;
        public string Deb;
        public MenuLanguage() {
            
        }

        public void Ru()
        {
            File = "Файл";
            Lang = "Язык";
            Info = "Инфо";
            Deb = "Дебаг";
        }
        public void En()
        {
            File = "File";
            Lang = "Languge";
            Info = "Info";
            Deb = "Debug";
        }
    }
}
