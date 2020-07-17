using System;

namespace Common.Extensions
{
    public class CustomId : IFormattable, IComparable, IComparable<CustomId>, IEquatable<CustomId>
    {
        private Guid id;

        public CustomId()
        {
            this.id = Guid.NewGuid();
        }

        public CustomId(Guid guid)
        {
            this.id = guid;
        }

        public CustomId(string validationCode, bool extractFromValidationCode)
        {
            int substringLen = validationCode.IndexOf("--");
            string guidAsString = validationCode.Substring(0, substringLen);
            this.id = new Guid(guidAsString);
        }

        public int CompareTo(object obj)
        {
            return this.id.CompareTo(((CustomId)obj).id);
        }

        public int CompareTo(CustomId other)
        {
            return this.id.CompareTo(other.id);
        }

        public bool Equals(CustomId other)
        {
            return this.id.Equals(other.id);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return this.id.ToString(format, formatProvider);
        }

        //public ServicePartitionKey GetPartitionKey()
        //{
        //    var key = new ServicePartitionKey(HashUtil.getLongHashCode(this.id.ToString()));
        //    return key;
        //}

        public static bool operator ==(CustomId item1, CustomId item2)
        {
            return item1.Equals(item2);
        }

        public static bool operator !=(CustomId item1, CustomId item2)
        {
            return !item1.Equals(item2);
        }

        public override bool Equals(object obj)
        {
            return (obj is CustomId) ? this.id.Equals(((CustomId)obj).id) : false;
        }

        public override int GetHashCode()
        {
            return this.id.GetHashCode();
        }

        public override string ToString()
        {
            return this.id.ToString();
        }

        public string ToString(string format)
        {
            return this.id.ToString(format);
        }
    }
}
