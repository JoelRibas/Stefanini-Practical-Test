using System;

namespace Stefanini.Web
{
    public class ComboItem : IComparable<ComboItem>
    {
        public ComboItem(string valueMember, string displayMember)
        {
            this.Id = valueMember;
            this.Description = displayMember;
        }
        public string Id { get; set; }
        public string Description { get; set; }

        public static Comparison<ComboItem> ByDescription = delegate (ComboItem e1, ComboItem e2) { return e1.Description.CompareTo(e2.Description); };

        public int CompareTo(ComboItem e)
        {
            return Description.CompareTo(e.Description);
        }
    }
}