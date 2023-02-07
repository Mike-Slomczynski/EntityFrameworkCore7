namespace EntityFrameworkCore7
{
    public class MyEntity
    {
        public virtual Guid a { get; set; }
        public virtual string b { get; set; } = String.Empty;
        public virtual int c { get; set; }
        public virtual int? d { get; set; }
        public virtual bool? e { get; set; }
        public virtual Guid? f { get; set; }
    }
}