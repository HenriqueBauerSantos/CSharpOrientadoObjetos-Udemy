
using System.Globalization;
using System.Text;

namespace ExercAula142.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; protected set; }

        public ImportedProduct() 
        {
        }

        public ImportedProduct(string name, double price, double customFee) : base(name,price)
        {
            CustomFee = customFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" $ ");
            sb.Append(TotalPrice().ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(" (Customs fee: $ ");
            sb.Append(CustomFee.ToString("F2", CultureInfo.InvariantCulture));
            sb.AppendLine(")");

            return sb.ToString();
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }

    }
}
