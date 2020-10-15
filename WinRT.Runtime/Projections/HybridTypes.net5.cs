using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using WinRT;

#pragma warning disable 0169 // warning CS0169: The field '...' is never used
#pragma warning disable 0649 // warning CS0169: Field '...' is never assigned to

namespace ABI.System.Collections
{
    [DynamicInterfaceCastableImplementation]
    interface IEnumerableHybrid : global::System.Collections.IEnumerable
    {
        private static IEnumerable GetHelper(IWinRTObject _this)
        {
            return (IEnumerable)_this.GetOrCreateTypeHelperData(typeof(ABI.System.Collections.IEnumerableHybrid).TypeHandle,
                () => throw new InvalidOperationException("Hybrid type should not have been stored as helper type : hybrid type is IEnumerableHybrid"));
        }

        IEnumerator global::System.Collections.IEnumerable.GetEnumerator() => GetHelper((IWinRTObject)this).GetEnumerator();
    }
}

namespace ABI.System.Collections
{
    [DynamicInterfaceCastableImplementation]
    interface IReadOnlyCollectionHybrid<T> : global::System.Collections.Generic.IReadOnlyCollection<T>
    {
        private static IReadOnlyCollection<T> GetHelper(IWinRTObject _this)
        {
            return (IReadOnlyCollection<T>)_this.GetOrCreateTypeHelperData(typeof(ABI.System.Collections.IReadOnlyCollectionHybrid<T>).TypeHandle,
                () => throw new InvalidOperationException("Hybrid type should not have been stored as helper type : hybrid type is IReadOnlyCollectionHybrid"));
        }

        Int32 global::System.Collections.Generic.IReadOnlyCollection<T>.Count 
            => GetHelper((IWinRTObject)this).Count;

        IEnumerator global::System.Collections.IEnumerable.GetEnumerator() 
            => GetHelper((IWinRTObject)this).GetEnumerator();

        global::System.Collections.Generic.IEnumerator<T> global::System.Collections.Generic.IEnumerable<T>.GetEnumerator() 
            => GetHelper((IWinRTObject)this).GetEnumerator();
    }
}

namespace ABI.System.Collections
{
    [DynamicInterfaceCastableImplementation]
    interface ICollectionHybrid<T> : global::System.Collections.Generic.ICollection<T>
    {
        private static ICollection<T> GetHelper(IWinRTObject _this)
        {
            return (ICollection<T>)_this.GetOrCreateTypeHelperData(typeof(ABI.System.Collections.ICollectionHybrid<T>).TypeHandle,
                () => throw new InvalidOperationException("Hybrid type should not have been stored as helper type : hybrid type is ICollectionHybrid"));
        }

        Int32 global::System.Collections.Generic.ICollection<T>.Count
            => GetHelper((IWinRTObject)this).Count;

        bool global::System.Collections.Generic.ICollection<T>.IsReadOnly
            => GetHelper((IWinRTObject)this).IsReadOnly;

        void global::System.Collections.Generic.ICollection<T>.Add(T item)
            => GetHelper((IWinRTObject)this).Add(item);

        void global::System.Collections.Generic.ICollection<T>.Clear()
            => GetHelper((IWinRTObject)this).Clear();

        bool global::System.Collections.Generic.ICollection<T>.Contains(T item)
            => GetHelper((IWinRTObject)this).Contains(item);

        void global::System.Collections.Generic.ICollection<T>.CopyTo(T[] array, int arrayIndex)
            => GetHelper((IWinRTObject)this).CopyTo(array, arrayIndex);

        bool global::System.Collections.Generic.ICollection<T>.Remove(T item)
            => GetHelper((IWinRTObject)this).Remove(item);

        IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
            => GetHelper((IWinRTObject)this).GetEnumerator();

        global::System.Collections.Generic.IEnumerator<T> global::System.Collections.Generic.IEnumerable<T>.GetEnumerator()
            => GetHelper((IWinRTObject)this).GetEnumerator();
    }
}
