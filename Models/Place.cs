namespace Places;

public class Place : IEntity, IGuid, ISlug, IKey, IOrder
{
    public Place()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid Guid { get; set; }

    public string Name { get; set; }

    public string Key { get; set; }

    public long Order { get; set; }

    public string Slug { get; set; }

    public dynamic RelatedItems { get; set; }
}
