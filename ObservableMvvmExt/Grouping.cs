using System;
using System.Collections.Generic;

namespace ObservableMvvmExt
{
    /// <summary>
    /// Grouping of items by key into ObservableRangeExt.
    /// </summary>
    public class Grouping<TKey, TItem> : ObservableRangeCollectionExt<TItem>
    {
        /// <summary>
        /// Gets the grouping key.
        /// </summary>
        /// <value>The grouping key.</value>
        public TKey GroupingKey { get; }

        /// <summary>
        /// Return the list of items in the grouping
        /// </summary>
        /// <value>The items.</value>
        public new IList<TItem> Items => base.Items;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ObservableMvvmExt.Grouping`2"/> class.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="items">Items.</param>
        public Grouping(TKey key, IEnumerable<TItem> items)
        {
            GroupingKey = key;
            AddRange(items);
        }
    }

    /// <summary>
    /// Grouping of items by key into ObservableRangeExt.
    /// </summary>
    public class Grouping<TKey, TSubKey, TItem> : ObservableRangeCollectionExt<TItem>
    {
        /// <summary>
        /// Gets the grouping key.
        /// </summary>
        /// <value>The grouping key.</value>
        public TKey GroupingKey { get; }

        /// <summary>
        /// Gets the grouping subkey.
        /// </summary>
        /// <value>The grouping subkey.</value>
        public TSubKey GroupingSubKey { get; }

        /// <summary>
        /// Return the list of items in the grouping
        /// </summary>
        /// <value>The items.</value>
        public new IList<TItem> Items => base.Items;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ObservableMvvmExt.Grouping`2"/> class.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="items">Items.</param>
        public Grouping(TKey key, TSubKey subKey, IEnumerable<TItem> items)
        {
            GroupingKey = key;
            GroupingSubKey = subKey;
            AddRange(items);
        }
    }
}
