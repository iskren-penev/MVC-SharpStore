namespace SharpStore.ViewModels
{
    public class PurchaseViewModel
    {
        public int KnifeId { get; set; }

        public override string ToString()
        {
            string representation = $"<input type=\"number\" hidden=\"hidden\" name=\"knifeId\" value=\"{this.KnifeId}\" />";
            return representation;
        }
    }
}
