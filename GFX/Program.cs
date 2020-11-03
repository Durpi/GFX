using System;
using Raylib_cs;

namespace GFX
{
    class Program
    {
        static void Main(string[] args)
        {
            Font f1 = Raylib.LoadFont(@"Metrophobic.ttf");

            Color myColor = new Color(0, 255, 128, 255);

            float x = 0;

            float y = 0;

            Rectangle player = new Rectangle((int)x, (int)y, 20, 20);

            Rectangle uppLeft = new Rectangle(300, 300, 40, 40);
            Rectangle uppRight = new Rectangle(uppLeft.x + uppLeft.width, uppLeft.y, uppLeft.width, uppLeft.height);
            Rectangle downLeft = new Rectangle(uppLeft.x, uppLeft.y + uppLeft.height, uppLeft.width, uppLeft.height);
            Rectangle downRight = new Rectangle(downLeft.x + downLeft.width, downLeft.y, downLeft.width, downLeft.height);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.GOLD);



                if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
                {
                    player.x += 0.1f;
                    
                }
                else if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                {
                    player.x -= 0.1f;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
                {
                    player.y += 0.1f;
                    
                }
                else if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
                {
                    player.y -= 0.1f;
                }

                
                Raylib.BeginDrawing();

                Raylib.ClearBackground(myColor);

                Raylib.DrawRectangleRec(uppLeft, Color.BLUE);
                Raylib.DrawRectangleRec(uppRight, Color.BLUE);
                Raylib.DrawRectangleRec(downLeft, Color.BLUE);
                Raylib.DrawRectangleRec(downRight, Color.BLUE);

                Raylib.DrawRectangleRec(player, Color.BLACK);

                if (x > 780)
                {
                    x = 780;
                }
                else if (x < 0)
                {
                    x = 0;
                }
                else if (y > 580)
                {
                    y = 580;
                }
                else if (y < 0)
                {
                    y = 0;
                }
                
                
                bool isCollidingUppLeft = Raylib.CheckCollisionRecs(player, uppLeft);
                bool isCollidingUppRight = Raylib.CheckCollisionRecs(player, uppRight);
                bool isCollidingDownLeft = Raylib.CheckCollisionRecs(player, downLeft);
                bool isCollidingDownRight = Raylib.CheckCollisionRecs(player, downRight);

                if (isCollidingUppLeft == true)
                {
                    player.x -= 0.1f;
                    player.y -= 0.1f;
                }
                if (isCollidingUppRight == true)
                {
                    player.x += 0.1f;
                    player.y -= 0.1f;
                }
                if (isCollidingDownLeft == true)
                {
                    player.x -= 0.1f;
                    player.y += 0.1f;
                }
                if (isCollidingDownRight == true)
                {
                    player.x += 0.1f;
                    player.y += 0.1f;
                }
                

                Raylib.EndDrawing();

            }
        }
    }
}
