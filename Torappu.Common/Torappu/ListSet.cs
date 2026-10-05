using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000C2 RID: 194
	[Token(Token = "0x20000C2")]
	[Serializable]
	public class ListSet<TItem> : IEnumerable, IEnumerable<TItem>
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x0000560C File Offset: 0x0000380C
		[Token(Token = "0x1700005E")]
		public int count
		{
			[Token(Token = "0x60004AB")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x00005624 File Offset: 0x00003824
		[Token(Token = "0x1700005F")]
		public bool isEmpty
		{
			[Token(Token = "0x60004AC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000060 RID: 96
		[Token(Token = "0x17000060")]
		public TItem this[int index]
		{
			[Token(Token = "0x60004AD")]
			get
			{
				return null;
			}
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004AE")]
		public ListSet()
		{
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004AF")]
		public ListSet(int capacity)
		{
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004B0")]
		public void Clear()
		{
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0000563C File Offset: 0x0000383C
		[Token(Token = "0x60004B1")]
		public bool Contains(TItem item)
		{
			return default(bool);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00005654 File Offset: 0x00003854
		[Token(Token = "0x60004B2")]
		public bool Add(TItem item)
		{
			return default(bool);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004B3")]
		public void AddRange(IList<TItem> items)
		{
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004B4")]
		public void RemoveRange(IEnumerable<TItem> items)
		{
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0000566C File Offset: 0x0000386C
		[Token(Token = "0x60004B5")]
		public bool Remove(TItem item)
		{
			return default(bool);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004B6")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B7")]
		public IEnumerator<TItem> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B8")]
		public TItem[] ToArray()
		{
			return null;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B9")]
		public List<TItem> GetInternalList()
		{
			return null;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BA")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x040004BD RID: 1213
		[Token(Token = "0x40004BD")]
		[FieldOffset(Offset = "0x0")]
		private List<TItem> m_items;
	}
}
