namespace Places;

public class PlacesContext : DatabaseContext
{
    public override string ConnectionStringName => "Places";

    public DbSet<Places.Place> Places { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
