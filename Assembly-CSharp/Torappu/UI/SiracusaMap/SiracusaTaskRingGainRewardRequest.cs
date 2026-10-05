using System;
using Il2CppDummyDll;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F65 RID: 16229
	[Token(Token = "0x2003F65")]
	public class SiracusaTaskRingGainRewardRequest
	{
		// Token: 0x0601930A RID: 103178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601930A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SiracusaTaskRingGainRewardRequest()
		{
		}

		// Token: 0x0401F3BF RID: 127935
		[Token(Token = "0x401F3BF")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x0401F3C0 RID: 127936
		[Token(Token = "0x401F3C0")]
		[FieldOffset(Offset = "0x18")]
		public string taskRingId;
	}
}
