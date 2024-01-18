public class Role : BaseEntity
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public bool IsFeature { get; set; }
    public int Sequence { get; set; }
    public long? ParentId { get; set; }
}