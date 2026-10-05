using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x02000405 RID: 1029
	[Token(Token = "0x2000405")]
	[System.Serializable]
	internal class FixupHolderList
	{
		// Token: 0x06002018 RID: 8216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002018")]
		[Address(RVA = "0x4B9A450", Offset = "0x4B99050", VA = "0x184B9A450")]
		internal FixupHolderList()
		{
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002019")]
		[Address(RVA = "0x4B9A3E0", Offset = "0x4B98FE0", VA = "0x184B9A3E0")]
		internal FixupHolderList(int startingSize)
		{
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201A")]
		[Address(RVA = "0x4B9A230", Offset = "0x4B98E30", VA = "0x184B9A230", Slot = "4")]
		internal virtual void Add(FixupHolder fixup)
		{
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201B")]
		[Address(RVA = "0x4B9A350", Offset = "0x4B98F50", VA = "0x184B9A350")]
		private void EnlargeArray()
		{
		}

		// Token: 0x040010DA RID: 4314
		[Token(Token = "0x40010DA")]
		[FieldOffset(Offset = "0x10")]
		internal FixupHolder[] m_values;

		// Token: 0x040010DB RID: 4315
		[Token(Token = "0x40010DB")]
		[FieldOffset(Offset = "0x18")]
		internal int m_count;
	}
}
