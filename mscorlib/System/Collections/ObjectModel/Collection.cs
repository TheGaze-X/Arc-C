using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace System.Collections.ObjectModel
{
	// Token: 0x020005F3 RID: 1523
	[Token(Token = "0x20005F3")]
	[System.Diagnostics.DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[System.Serializable]
	public class Collection<T> : System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, IEnumerable, IList, ICollection, System.Collections.Generic.IReadOnlyList<T>, System.Collections.Generic.IReadOnlyCollection<T>
	{
		// Token: 0x06002DBB RID: 11707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DBB")]
		public Collection()
		{
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DBC")]
		public Collection(System.Collections.Generic.IList<T> list)
		{
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06002DBD RID: 11709 RVA: 0x00018E10 File Offset: 0x00017010
		[Token(Token = "0x17000757")]
		public int Count
		{
			[Token(Token = "0x6002DBD")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06002DBE RID: 11710 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000758")]
		protected System.Collections.Generic.IList<T> Items
		{
			[Token(Token = "0x6002DBE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000759 RID: 1881
		[Token(Token = "0x17000759")]
		public T this[int index]
		{
			[Token(Token = "0x6002DBF")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002DC0")]
			set
			{
			}
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC1")]
		public void Add(T item)
		{
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC2")]
		public void Clear()
		{
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC3")]
		public void CopyTo(T[] array, int index)
		{
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x00018E28 File Offset: 0x00017028
		[Token(Token = "0x6002DC4")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x06002DC5 RID: 11717 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002DC5")]
		public System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x00018E40 File Offset: 0x00017040
		[Token(Token = "0x6002DC6")]
		public int IndexOf(T item)
		{
			return 0;
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC7")]
		public void Insert(int index, T item)
		{
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x00018E58 File Offset: 0x00017058
		[Token(Token = "0x6002DC8")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		// Token: 0x06002DC9 RID: 11721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC9")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DCA")]
		protected virtual void ClearItems()
		{
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DCB")]
		protected virtual void InsertItem(int index, T item)
		{
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DCC")]
		protected virtual void RemoveItem(int index)
		{
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DCD")]
		protected virtual void SetItem(int index, T item)
		{
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06002DCE RID: 11726 RVA: 0x00018E70 File Offset: 0x00017070
		[Token(Token = "0x1700075A")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6002DCE")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002DCF")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06002DD0 RID: 11728 RVA: 0x00018E88 File Offset: 0x00017088
		[Token(Token = "0x1700075B")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6002DD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06002DD1 RID: 11729 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700075C")]
		private object SyncRoot
		{
			[Token(Token = "0x6002DD1")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD2")]
		private void CopyTo(System.Array array, int index)
		{
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06002DD3 RID: 11731 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06002DD4 RID: 11732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700075D")]
		private object Item
		{
			[Token(Token = "0x6002DD3")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002DD4")]
			set
			{
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06002DD5 RID: 11733 RVA: 0x00018EA0 File Offset: 0x000170A0
		[Token(Token = "0x1700075E")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6002DD5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06002DD6 RID: 11734 RVA: 0x00018EB8 File Offset: 0x000170B8
		[Token(Token = "0x1700075F")]
		private bool IsFixedSize
		{
			[Token(Token = "0x6002DD6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x00018ED0 File Offset: 0x000170D0
		[Token(Token = "0x6002DD7")]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x06002DD8 RID: 11736 RVA: 0x00018EE8 File Offset: 0x000170E8
		[Token(Token = "0x6002DD8")]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x00018F00 File Offset: 0x00017100
		[Token(Token = "0x6002DD9")]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DDA")]
		private void Insert(int index, object value)
		{
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DDB")]
		private void Remove(object value)
		{
		}

		// Token: 0x06002DDC RID: 11740 RVA: 0x00018F18 File Offset: 0x00017118
		[Token(Token = "0x6002DDC")]
		private static bool IsCompatibleObject(object value)
		{
			return default(bool);
		}

		// Token: 0x04001A1A RID: 6682
		[Token(Token = "0x4001A1A")]
		[FieldOffset(Offset = "0x0")]
		private System.Collections.Generic.IList<T> items;
	}
}
