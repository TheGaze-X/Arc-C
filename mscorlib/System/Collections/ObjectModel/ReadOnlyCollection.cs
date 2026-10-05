using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace System.Collections.ObjectModel
{
	// Token: 0x020005F4 RID: 1524
	[Token(Token = "0x20005F4")]
	[System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[System.Diagnostics.DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[System.Serializable]
	public class ReadOnlyCollection<T> : System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, IEnumerable, IList, ICollection, System.Collections.Generic.IReadOnlyList<T>, System.Collections.Generic.IReadOnlyCollection<T>
	{
		// Token: 0x06002DDD RID: 11741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DDD")]
		public ReadOnlyCollection(System.Collections.Generic.IList<T> list)
		{
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06002DDE RID: 11742 RVA: 0x00018F30 File Offset: 0x00017130
		[Token(Token = "0x17000760")]
		public int Count
		{
			[Token(Token = "0x6002DDE")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000761 RID: 1889
		[Token(Token = "0x17000761")]
		public T this[int index]
		{
			[Token(Token = "0x6002DDF")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x00018F48 File Offset: 0x00017148
		[Token(Token = "0x6002DE0")]
		public bool Contains(T value)
		{
			return default(bool);
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DE1")]
		public void CopyTo(T[] array, int index)
		{
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002DE2")]
		public System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x00018F60 File Offset: 0x00017160
		[Token(Token = "0x6002DE3")]
		public int IndexOf(T value)
		{
			return 0;
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06002DE4 RID: 11748 RVA: 0x00018F78 File Offset: 0x00017178
		[Token(Token = "0x17000762")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6002DE4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06002DE5 RID: 11749 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06002DE6 RID: 11750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000763")]
		private T Item
		{
			[Token(Token = "0x6002DE5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002DE6")]
			set
			{
			}
		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DE7")]
		private void Add(T value)
		{
		}

		// Token: 0x06002DE8 RID: 11752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DE8")]
		private void Clear()
		{
		}

		// Token: 0x06002DE9 RID: 11753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DE9")]
		private void Insert(int index, T value)
		{
		}

		// Token: 0x06002DEA RID: 11754 RVA: 0x00018F90 File Offset: 0x00017190
		[Token(Token = "0x6002DEA")]
		private bool Remove(T value)
		{
			return default(bool);
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DEB")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x06002DEC RID: 11756 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002DEC")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06002DED RID: 11757 RVA: 0x00018FA8 File Offset: 0x000171A8
		[Token(Token = "0x17000764")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6002DED")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06002DEE RID: 11758 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000765")]
		private object SyncRoot
		{
			[Token(Token = "0x6002DEE")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002DEF RID: 11759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DEF")]
		private void CopyTo(System.Array array, int index)
		{
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06002DF0 RID: 11760 RVA: 0x00018FC0 File Offset: 0x000171C0
		[Token(Token = "0x17000766")]
		private bool IsFixedSize
		{
			[Token(Token = "0x6002DF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06002DF1 RID: 11761 RVA: 0x00018FD8 File Offset: 0x000171D8
		[Token(Token = "0x17000767")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6002DF1")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06002DF2 RID: 11762 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06002DF3 RID: 11763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000768")]
		private object Item
		{
			[Token(Token = "0x6002DF2")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002DF3")]
			set
			{
			}
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x00018FF0 File Offset: 0x000171F0
		[Token(Token = "0x6002DF4")]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF5")]
		private void Clear()
		{
		}

		// Token: 0x06002DF6 RID: 11766 RVA: 0x00019008 File Offset: 0x00017208
		[Token(Token = "0x6002DF6")]
		private static bool IsCompatibleObject(object value)
		{
			return default(bool);
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x00019020 File Offset: 0x00017220
		[Token(Token = "0x6002DF7")]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x00019038 File Offset: 0x00017238
		[Token(Token = "0x6002DF8")]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF9")]
		private void Insert(int index, object value)
		{
		}

		// Token: 0x06002DFA RID: 11770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DFA")]
		private void Remove(object value)
		{
		}

		// Token: 0x06002DFB RID: 11771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DFB")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x04001A1B RID: 6683
		[Token(Token = "0x4001A1B")]
		[FieldOffset(Offset = "0x0")]
		private System.Collections.Generic.IList<T> list;

		// Token: 0x04001A1C RID: 6684
		[Token(Token = "0x4001A1C")]
		[FieldOffset(Offset = "0x0")]
		[System.NonSerialized]
		private object _syncRoot;
	}
}
