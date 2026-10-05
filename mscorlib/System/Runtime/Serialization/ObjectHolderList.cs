using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x02000407 RID: 1031
	[Token(Token = "0x2000407")]
	internal class ObjectHolderList
	{
		// Token: 0x06002025 RID: 8229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002025")]
		[Address(RVA = "0x4BA1FC0", Offset = "0x4BA0BC0", VA = "0x184BA1FC0")]
		internal ObjectHolderList()
		{
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002026")]
		[Address(RVA = "0x4BA2020", Offset = "0x4BA0C20", VA = "0x184BA2020")]
		internal ObjectHolderList(int startingSize)
		{
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002027")]
		[Address(RVA = "0x4BA1D80", Offset = "0x4BA0980", VA = "0x184BA1D80", Slot = "4")]
		internal virtual void Add(ObjectHolder value)
		{
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002028")]
		[Address(RVA = "0x4BA1F30", Offset = "0x4BA0B30", VA = "0x184BA1F30")]
		internal ObjectHolderListEnumerator GetFixupEnumerator()
		{
			return null;
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002029")]
		[Address(RVA = "0x4BA1EA0", Offset = "0x4BA0AA0", VA = "0x184BA1EA0")]
		private void EnlargeArray()
		{
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x0600202A RID: 8234 RVA: 0x00013470 File Offset: 0x00011670
		[Token(Token = "0x17000440")]
		internal int Version
		{
			[Token(Token = "0x600202A")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x0600202B RID: 8235 RVA: 0x00013488 File Offset: 0x00011688
		[Token(Token = "0x17000441")]
		internal int Count
		{
			[Token(Token = "0x600202B")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040010E0 RID: 4320
		[Token(Token = "0x40010E0")]
		[FieldOffset(Offset = "0x10")]
		internal ObjectHolder[] m_values;

		// Token: 0x040010E1 RID: 4321
		[Token(Token = "0x40010E1")]
		[FieldOffset(Offset = "0x18")]
		internal int m_count;
	}
}
