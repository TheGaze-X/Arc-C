using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200216A RID: 8554
	[Token(Token = "0x200216A")]
	[Serializable]
	public class BakedFrameData
	{
		// Token: 0x0600D2CD RID: 53965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D2CD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BakedFrameData()
		{
		}

		// Token: 0x0400E1C9 RID: 57801
		[Token(Token = "0x400E1C9")]
		[FieldOffset(Offset = "0x10")]
		public float[] position;

		// Token: 0x0400E1CA RID: 57802
		[Token(Token = "0x400E1CA")]
		[FieldOffset(Offset = "0x18")]
		public float[] rotation;

		// Token: 0x0400E1CB RID: 57803
		[Token(Token = "0x400E1CB")]
		[FieldOffset(Offset = "0x20")]
		public float[] scale;
	}
}
