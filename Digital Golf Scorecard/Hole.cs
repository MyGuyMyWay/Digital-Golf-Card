using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Golf_Scorecard;
public class Hole
{
    required public int Id { get; set; }
    required public int hole_num {  get; set; }
    public int? score {  get; set; }
}