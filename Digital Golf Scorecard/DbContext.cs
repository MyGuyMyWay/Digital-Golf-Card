using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Golf_Scorecard;
public class DGSContext : DbContext
{
    public DbSet<Game> Games { get; set; }
    public DbSet<Hole> Holes { get; set; }

    public DGSContext()
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Data Source=MyGuy;Initial Catalog=\"Golf Score Card\";Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
}