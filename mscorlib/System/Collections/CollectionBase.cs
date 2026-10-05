using System;
using Il2CppDummyDll;

namespace System.Collections
{
	// Token: 0x020005CB RID: 1483
	[Token(Token = "0x20005CB")]
	[System.Serializable]
	public abstract class CollectionBase : IList, ICollection, IEnumerable
	{
		// Token: 0x06002BE7 RID: 11239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE7")]
		[Address(RVA = "0x4C5C3A0", Offset = "0x4C5AFA0", VA = "0x184C5C3A0")]
		protected CollectionBase()
		{
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06002BE8 RID: 11240 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170006D8")]
		protected ArrayList InnerList
		{
			[Token(Token = "0x6002BE8")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06002BE9 RID: 11241 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170006D9")]
		protected IList List
		{
			[Token(Token = "0x6002BE9")]
			[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06002BEA RID: 11242 RVA: 0x00018210 File Offset: 0x00016410
		[Token(Token = "0x170006DA")]
		public int Count
		{
			[Token(Token = "0x6002BEA")]
			[Address(RVA = "0x4C5C450", Offset = "0x4C5B050", VA = "0x184C5C450", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BEB")]
		[Address(RVA = "0x4C5B6D0", Offset = "0x4C5A2D0", VA = "0x184C5B6D0", Slot = "8")]
		public void Clear()
		{
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BEC")]
		[Address(RVA = "0x4C5B7E0", Offset = "0x4C5A3E0", VA = "0x184C5B7E0", Slot = "14")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06002BED RID: 11245 RVA: 0x00018228 File Offset: 0x00016428
		[Token(Token = "0x170006DB")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6002BED")]
			[Address(RVA = "0x4BAB670", Offset = "0x4BAA270", VA = "0x184BAB670", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06002BEE RID: 11246 RVA: 0x00018240 File Offset: 0x00016440
		[Token(Token = "0x170006DC")]
		private bool IsFixedSize
		{
			[Token(Token = "0x6002BEE")]
			[Address(RVA = "0x4C5C060", Offset = "0x4C5AC60", VA = "0x184C5C060", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06002BEF RID: 11247 RVA: 0x00018258 File Offset: 0x00016458
		[Token(Token = "0x170006DD")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6002BEF")]
			[Address(RVA = "0x4C5BA30", Offset = "0x4C5A630", VA = "0x184C5BA30", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06002BF0 RID: 11248 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170006DE")]
		private object SyncRoot
		{
			[Token(Token = "0x6002BF0")]
			[Address(RVA = "0x4C5BA80", Offset = "0x4C5A680", VA = "0x184C5BA80", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002BF1 RID: 11249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF1")]
		[Address(RVA = "0x4C5B9D0", Offset = "0x4C5A5D0", VA = "0x184C5B9D0", Slot = "15")]
		private void CopyTo(System.Array array, int index)
		{
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06002BF2 RID: 11250 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06002BF3 RID: 11251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006DF")]
		private object Item
		{
			[Token(Token = "0x6002BF2")]
			[Address(RVA = "0x4C5C0B0", Offset = "0x4C5ACB0", VA = "0x184C5C0B0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BF3")]
			[Address(RVA = "0x4C5C1B0", Offset = "0x4C5ADB0", VA = "0x184C5C1B0", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x00018270 File Offset: 0x00016470
		[Token(Token = "0x6002BF4")]
		[Address(RVA = "0x4C5BC40", Offset = "0x4C5A840", VA = "0x184C5BC40", Slot = "7")]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x06002BF5 RID: 11253 RVA: 0x00018288 File Offset: 0x00016488
		[Token(Token = "0x6002BF5")]
		[Address(RVA = "0x4C5BAD0", Offset = "0x4C5A6D0", VA = "0x184C5BAD0", Slot = "6")]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF6")]
		[Address(RVA = "0x4C5BE90", Offset = "0x4C5AA90", VA = "0x184C5BE90", Slot = "13")]
		private void Remove(object value)
		{
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x000182A0 File Offset: 0x000164A0
		[Token(Token = "0x6002BF7")]
		[Address(RVA = "0x4C5BCA0", Offset = "0x4C5A8A0", VA = "0x184C5BCA0", Slot = "11")]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF8")]
		[Address(RVA = "0x4C5BD00", Offset = "0x4C5A900", VA = "0x184C5BD00", Slot = "12")]
		private void Insert(int index, object value)
		{
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002BF9")]
		[Address(RVA = "0x4A88790", Offset = "0x4A87390", VA = "0x184A88790", Slot = "19")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BFA")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
		protected virtual void OnSet(int index, object oldValue, object newValue)
		{
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BFB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "21")]
		protected virtual void OnInsert(int index, object value)
		{
		}

		// Token: 0x06002BFC RID: 11260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BFC")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "22")]
		protected virtual void OnClear()
		{
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BFD")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "23")]
		protected virtual void OnRemove(int index, object value)
		{
		}

		// Token: 0x06002BFE RID: 11262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BFE")]
		[Address(RVA = "0x4C5B770", Offset = "0x4C5A370", VA = "0x184C5B770", Slot = "24")]
		protected virtual void OnValidate(object value)
		{
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BFF")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "25")]
		protected virtual void OnSetComplete(int index, object oldValue, object newValue)
		{
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C00")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "26")]
		protected virtual void OnInsertComplete(int index, object value)
		{
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C01")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "27")]
		protected virtual void OnClearComplete()
		{
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C02")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "28")]
		protected virtual void OnRemoveComplete(int index, object value)
		{
		}

		// Token: 0x0400198F RID: 6543
		[Token(Token = "0x400198F")]
		[FieldOffset(Offset = "0x10")]
		private ArrayList _list;
	}
}
