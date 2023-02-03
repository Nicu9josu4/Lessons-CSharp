namespace MoveMouser
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            int i = 0;
            while (i < 10)
            {
                Cursor.Position = new Point(950, 500);
                Thread.Sleep(200);
                Cursor.Position = new Point(900, 500);
                Thread.Sleep(200);
                Cursor.Position = new Point(900, 550);
                Thread.Sleep(200);
                Cursor.Position = new Point(950, 550);
                Thread.Sleep(200);
                i++;
            }
        }
    }
}