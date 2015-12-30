using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyGame.Game
{
    class MainGame
    {
        public ObservableCollection<Player> Players { get; set; }
        public ObservableCollection<CategoryModel> Categories { get; set; }
    }
}
