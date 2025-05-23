using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Golf_Scorecard;
public class Game
{
    required public int id;
    public string? course_name;
    required public List<Hole> game_scores;
}