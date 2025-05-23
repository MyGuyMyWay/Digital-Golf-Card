using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Golf_Scorecard;
public class Game
{
    required public int Id { get; set; }
    public string? course_name { get; set; }
    required public List<Hole> game_scores { get; set; }
}