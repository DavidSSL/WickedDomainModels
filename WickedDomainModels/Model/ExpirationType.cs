namespace WickedDomainModels.Model
{
	public class ExpirationType : Enumeration
	{
        private ExpirationType(int value, string displayName)
            : base(value, displayName)
        {
        }
        public static readonly ExpirationType Assignment = new ExpirationType(1, "Assignment");
        public static readonly ExpirationType Fixed = new ExpirationType(1, "Fixed");
	}
}