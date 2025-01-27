namespace HomeWork14
{
    public static class EnumerableExtension
    {
        public static TCollection Top<T, TCollection>(this TCollection source, int percent)
        where TCollection : IEnumerable<T>, ICollection<T>, new()
        {
            if (percent > 100 || percent < 1)
                throw new ArgumentException("The percentage must be between 1 and 100");
            int count = (int)Math.Round((double)source.Count() / 100 * percent);
            var result = new TCollection();
            foreach (var item in source.OrderDescending().Take(count))
            {
                result.Add(item);
            };
            return result;
        }

        public static TCollection Top<T, TCollection>(this TCollection source, int percent, Func<T,int> selector)
        where TCollection : IEnumerable<T>, ICollection<T>, new()
        {
            if (percent > 100 || percent < 1)
                throw new ArgumentException("The percentage must be between 1 and 100");
            int count = (int)Math.Round((double)source.Count() / 100 * percent);
            var result = new TCollection();
            foreach (var item in source.OrderByDescending(selector).Take(count))
            {
                result.Add(item);
            };
            return result;
        }
    }


    public static class EnumerableExtension2
    {
        public static IEnumerable<T> Top<T>(this IEnumerable<T> source, int percent)
        {
            if (percent > 100 || percent < 1)
                throw new ArgumentException("The percentage must be between 1 and 100");
            int count = (int)Math.Round((double)source.Count() / 100 * percent);
            return source.OrderDescending().Take(count);
        }

        public static IEnumerable<T> Top<T>(this IEnumerable<T> source, int percent, Func<T, int> selector)
        {
            if (percent > 100 || percent < 1)
                throw new ArgumentException("The percentage must be between 1 and 100");
            int count = (int)Math.Round((double)source.Count() / 100 * percent);
            return source.OrderByDescending(selector).Take(count);
        }
    }
}
