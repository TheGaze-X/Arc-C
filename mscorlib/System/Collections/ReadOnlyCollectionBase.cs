using System;
using Il2CppDummyDll;

namespace System.Collections
{
	// Token: 0x020005CF RID: 1487
	[Token(Token = "0x20005CF")]
	[System.Serializable]
	public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable
	{
		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06002C17 RID: 11287 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170006E4")]
		protected ArrayList InnerList
		{
			[Token(Token = "0x6002C17")]
			[Address(RVA = "0x4C6AFF0", Offset = "0x4C69BF0", VA = "0x184C6AFF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06002C18 RID: 11288 RVA: 0x00018300 File Offset: 0x00016500
		[Token(Token = "0x170006E5")]
		public virtual int Count
		{
			[Token(Token = "0x6002C18")]
			[Address(RVA = "0x4C6AFA0", Offset = "0x4C69BA0", VA = "0x184C6AFA0", Slot = "9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06002C19 RID: 11289 RVA: 0x00018318 File Offset: 0x00016518
		[Token(Token = "0x170006E6")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6002C19")]
			[Address(RVA = "0x4C6AF00", Offset = "0x4C69B00", VA = "0x184C6AF00", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06002C1A RID: 11290 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170006E7")]
		private object SyncRoot
		{
			[Token(Token = "0x6002C1A")]
			[Address(RVA = "0x4C6AF50", Offset = "0x4C69B50", VA = "0x184C6AF50", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C1B")]
		[Address(RVA = "0x4C6AE90", Offset = "0x4C69A90", VA = "0x184C6AE90", Slot = "4")]
		private void CopyTo(System.Array array, int index)
		{
		}

		// Token: 0x06002C1C RID: 11292 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002C1C")]
		[Address(RVA = "0x4C6AE40", Offset = "0x4C69A40", VA = "0x184C6AE40", Slot = "10")]
		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002C1D RID: 11293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C1D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ReadOnlyCollectionBase()
		{
		}

		// Token: 0x0400199B RID: 6555
		[Token(Token = "0x400199B")]
		[FieldOffset(Offset = "0x10")]
		private ArrayList _list;
	}
}
