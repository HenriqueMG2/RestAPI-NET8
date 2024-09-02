namespace RestAPI.Util
{
    public class Verification
    {
        public static bool IsNumeric(string value)
        {
            return double.TryParse(
                value,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out double number
            );
        }
        public static decimal ConvertToDecimal(string number)
        {
            if (decimal.TryParse(number, out decimal decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }
    }
}