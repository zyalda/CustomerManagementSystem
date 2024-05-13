namespace CMS.BL
{
    public enum EntityStateOption
    {
        Activate,
        Delete
    }
    public abstract class EntityBase
    {
        public EntityStateOption entityState { get; set; }
        public bool HasChanges { get; set; }
        public bool Isnew { get; set; }
        public bool IsValid => Validate();

        public abstract bool Validate();
    }
}
