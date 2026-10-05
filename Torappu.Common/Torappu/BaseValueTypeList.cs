using System;
using System.Collections.Generic;
using Hypergryph.ToolKits;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000D6")]
	public abstract class BaseValueTypeList<TWrapper> where TWrapper : class, new()
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x000059CC File Offset: 0x00003BCC
		[Token(Token = "0x17000064")]
		public int Count
		{
			[Token(Token = "0x600051C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600051D")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600051E")]
		public void Clear()
		{
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600051F")]
		protected TWrapper GetWrappr(int index)
		{
			return null;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000520")]
		protected TWrapper GetOrCreateWrapper(int index)
		{
			return null;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000521")]
		protected TWrapper AddWrapper()
		{
			return null;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000522")]
		protected TWrapper InsertWrapper(int index)
		{
			return null;
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x000059E4 File Offset: 0x00003BE4
		[Token(Token = "0x6000523")]
		protected List<TWrapper>.Enumerator CreateEnumerator()
		{
			return default(List<TWrapper>.Enumerator);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000524")]
		protected void SortWrapper()
		{
		}

		// Token: 0x06000525 RID: 1317
		[Token(Token = "0x6000525")]
		protected abstract Comparison<TWrapper> CreateComparison();

		// Token: 0x06000526 RID: 1318 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000526")]
		protected BaseValueTypeList()
		{
		}

		// Token: 0x040004E7 RID: 1255
		[Token(Token = "0x40004E7")]
		[FieldOffset(Offset = "0x0")]
		private List<TWrapper> m_innerList;

		// Token: 0x040004E8 RID: 1256
		[Token(Token = "0x40004E8")]
		[FieldOffset(Offset = "0x0")]
		private LocalGenericPool<TWrapper> m_pool;

		// Token: 0x040004E9 RID: 1257
		[Token(Token = "0x40004E9")]
		[FieldOffset(Offset = "0x0")]
		private Comparison<TWrapper> m_comparison;
	}
}
