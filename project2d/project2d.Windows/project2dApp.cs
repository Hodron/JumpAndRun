using SiliconStudio.Xenko.Engine;

namespace project2d
{
    class project2dApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
