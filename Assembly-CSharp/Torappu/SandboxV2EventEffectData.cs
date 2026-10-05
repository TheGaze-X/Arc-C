using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012C6 RID: 4806
	[Token(Token = "0x20012C6")]
	public class SandboxV2EventEffectData
	{
		// Token: 0x0600723F RID: 29247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600723F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2EventEffectData()
		{
		}

		// Token: 0x04006A2F RID: 27183
		[Token(Token = "0x4006A2F")]
		[FieldOffset(Offset = "0x10")]
		public string eventEffectId;

		// Token: 0x04006A30 RID: 27184
		[Token(Token = "0x4006A30")]
		[FieldOffset(Offset = "0x18")]
		public string buffId;

		// Token: 0x04006A31 RID: 27185
		[Token(Token = "0x4006A31")]
		[FieldOffset(Offset = "0x20")]
		public int duration;

		// Token: 0x04006A32 RID: 27186
		[Token(Token = "0x4006A32")]
		[FieldOffset(Offset = "0x28")]
		public string desc;
	}
}
