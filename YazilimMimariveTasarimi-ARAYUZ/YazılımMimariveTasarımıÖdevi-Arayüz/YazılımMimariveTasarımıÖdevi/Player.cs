using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMimariveTasarımıÖdevi
{
    public class Player
    {
        private IPlayer player;

        public Player(IPlayer ply)
        {
            player=ply;
        }
        public string Play()
        {
            return player.Play();
        }
        public string Stop()
        {
            return player.Stop();
        }
    }

    
}
