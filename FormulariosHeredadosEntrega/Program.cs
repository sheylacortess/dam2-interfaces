namespace FormulariosHeredadosEntrega
{
    internal static class Program
    {
        // lista publica global para compartir los cliantes entre los formularios
        public static List<Cliente> ListaClientes = new List<Cliente>();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmBase());

        }
    }
}