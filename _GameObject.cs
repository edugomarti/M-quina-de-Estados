using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FSM
{

    public enum STATE
    {
        UP,
        DOWN,
        LEFT,
        RIGHT,
        RUP,
        RDOWN,
        LUP,
        LDOWN
 
    };

    class _GameObject
    {
        Vector2 position;
        Point size;
        Texture2D texture;
        STATE state;
        Vector2 speed;
        static Random random;
        float currentTime;
        const float GAP = 0.5f;

        public _GameObject(Vector2 position, Point size, ref Texture2D texture)
        {
            this.position = position;
            this.size = size;
            this.texture = texture;
            this.state = STATE.UP;
            this.speed = new Vector2(100, 100);
            random = new Random();
            this.currentTime = 0;
            
 
        }

        public void Update(GameTime gameTime)
        {
            this.UpdateState(gameTime);

            this.currentTime += gameTime.ElapsedGameTime.Milliseconds * 0.001f;
            if (this.currentTime >= GAP)
            {
                this.currentTime = 0;
                this.ChangeState();
            }
        }

        public void Draw(SpriteBatch sb)
        {
            sb.Draw(this.texture, new Rectangle((int)this.position.X, (int)this.position.Y, this.size.X, this.size.Y), Color.White);
        }

        private void UpdateState(GameTime gameTime)
        {
            switch (state)
            {
 
                case STATE.UP:
                    this.position.Y -= this.speed.Y * gameTime.ElapsedGameTime.Milliseconds * 0.001f;
                    break;

                case STATE.DOWN:
                    this.position.Y += this.speed.Y * gameTime.ElapsedGameTime.Milliseconds * 0.001f;
                    break;

                case STATE.LEFT:
                    this.position.X -= this.speed.X * gameTime.ElapsedGameTime.Milliseconds * 0.001f;
                    break;

                case STATE.RIGHT:
                    this.position.X += this.speed.X * gameTime.ElapsedGameTime.Milliseconds * 0.001f;
                    break;

                case STATE.RUP:
                    this.position.X += this.speed.X * gameTime.ElapsedGameTime.Milliseconds * 0.001f;
                    this.position.Y -= this.speed.Y * gameTime.ElapsedGameTime.Milliseconds * 0.001f;
                    break;

                case STATE.RDOWN:
                    this.position.X += this.speed.X * gameTime.ElapsedGameTime.Milliseconds * 0.001f;
                    this.position.Y += this.speed.Y * gameTime.ElapsedGameTime.Milliseconds * 0.001f;
                    break;

                case STATE.LUP:
                    this.position.X -= this.speed.X * gameTime.ElapsedGameTime.Milliseconds * 0.001f;
                    this.position.Y -= this.speed.Y * gameTime.ElapsedGameTime.Milliseconds * 0.001f;
                    break;

                case STATE.LDOWN:
                    this.position.X -= this.speed.X * gameTime.ElapsedGameTime.Milliseconds * 0.001f;
                    this.position.Y += this.speed.Y * gameTime.ElapsedGameTime.Milliseconds * 0.001f;
                    break;

              
            } 
        }

        private void ChangeState()
        {
            int r = random.Next(7);
            switch (state) 
            {
                case STATE.UP:
                    switch (r)
                    {
                        case 0: this.state = STATE.DOWN; break;
                        case 1: this.state = STATE.LEFT; break;
                        case 2: this.state = STATE.RIGHT; break;

                        case 3: this.state = STATE.RUP; break;
                        case 4: this.state = STATE.RDOWN; break;
                        case 5: this.state = STATE.LUP; break;
                        case 6: this.state = STATE.LDOWN; break;
                    }
                    break;

                case STATE.DOWN:
                    switch (r)
                    {
                        case 0: this.state = STATE.UP; break;
                        case 1: this.state = STATE.LEFT; break;
                        case 2: this.state = STATE.RIGHT; break;
                        case 3: this.state = STATE.RUP; break;
                        case 4: this.state = STATE.RDOWN; break;
                        case 5: this.state = STATE.LUP; break;
                        case 6: this.state = STATE.LDOWN; break;

                    }
                    break;

                case STATE.LEFT:
                    switch (r)
                    {
                        case 0: this.state = STATE.UP; break;
                        case 1: this.state = STATE.DOWN; break;
                        case 2: this.state = STATE.RIGHT; break;
                        case 3: this.state = STATE.RUP; break;
                        case 4: this.state = STATE.RDOWN; break;
                        case 5: this.state = STATE.LUP; break;
                        case 6: this.state = STATE.LDOWN; break;
                    }
                    break;
                
                case STATE.RIGHT:
                    switch (r)
                    {
                        case 0: this.state = STATE.UP; break;
                        case 1: this.state = STATE.DOWN; break;
                        case 2: this.state = STATE.LEFT; break;
                        case 3: this.state = STATE.RUP; break;
                        case 4: this.state = STATE.RDOWN; break;
                        case 5: this.state = STATE.LUP; break;
                        case 6: this.state = STATE.LDOWN; break;
                    }
                    break;

                case STATE.RUP:
                    switch (r)
                    {
                        case 0: this.state = STATE.UP; break;
                        case 1: this.state = STATE.DOWN; break;
                        case 2: this.state = STATE.LEFT; break;
                        case 3: this.state = STATE.RIGHT; break;
                        case 4: this.state = STATE.RDOWN; break;
                        case 5: this.state = STATE.LUP; break;
                        case 6: this.state = STATE.LDOWN; break;
                    }
                    break;

                case STATE.RDOWN:
                    switch (r)
                    {
                        case 0: this.state = STATE.UP; break;
                        case 1: this.state = STATE.DOWN; break;
                        case 2: this.state = STATE.LEFT; break;
                        case 3: this.state = STATE.RIGHT; break;
                        case 4: this.state = STATE.RUP; break;
                        case 5: this.state = STATE.LUP; break;
                        case 6: this.state = STATE.LDOWN; break;
                    }
                    break;

                case STATE.LUP:
                    switch (r)
                    {
                        case 0: this.state = STATE.UP; break;
                        case 1: this.state = STATE.DOWN; break;
                        case 2: this.state = STATE.LEFT; break;
                        case 3: this.state = STATE.RIGHT; break;
                        case 4: this.state = STATE.RDOWN; break;
                        case 5: this.state = STATE.RUP; break;
                        case 6: this.state = STATE.LDOWN; break;
                    }
                    break;

                case STATE.LDOWN:
                    switch (r)
                    {
                        case 0: this.state = STATE.UP; break;
                        case 1: this.state = STATE.DOWN; break;
                        case 2: this.state = STATE.LEFT; break;
                        case 3: this.state = STATE.RIGHT; break;
                        case 4: this.state = STATE.RDOWN; break;
                        case 5: this.state = STATE.LUP; break;
                        case 6: this.state = STATE.RUP; break;
                    }
                    break;
            }
       
        }
    }
}

