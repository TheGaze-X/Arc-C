using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x02000404 RID: 1028
	[Token(Token = "0x2000404")]
	[System.Serializable]
	internal class FixupHolder
	{
		// Token: 0x06002017 RID: 8215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002017")]
		[Address(RVA = "0x4B9A4B0", Offset = "0x4B990B0", VA = "0x184B9A4B0")]
		internal FixupHolder(long id, object fixupInfo, int fixupType)
		{
		}

		// Token: 0x040010D7 RID: 4311
		[Token(Token = "0x40010D7")]
		[FieldOffset(Offset = "0x10")]
		internal long m_id;

		// Token: 0x040010D8 RID: 4312
		[Token(Token = "0x40010D8")]
		[FieldOffset(Offset = "0x18")]
		internal object m_fixupInfo;

		// Token: 0x040010D9 RID: 4313
		[Token(Token = "0x40010D9")]
		[FieldOffset(Offset = "0x20")]
		internal int m_fixupType;
	}
}
