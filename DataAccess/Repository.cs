namespace Places;

public class Repository
{
    public static Write<Places.Place> Place
    {
        get
        {
            return new Write<Places.Place>(new PlacesContext());
        }
    }
}
