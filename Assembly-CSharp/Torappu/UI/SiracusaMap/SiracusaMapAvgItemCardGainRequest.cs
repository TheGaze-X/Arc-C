using System;
using Il2CppDummyDll;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F63 RID: 16227
	[Token(Token = "0x2003F63")]
	public class SiracusaMapAvgItemCardGainRequest
	{
		// Token: 0x06019308 RID: 103176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019308")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SiracusaMapAvgItemCardGainRequest()
		{
		}

		// Token: 0x0401F3BC RID: 127932
		[Token(Token = "0x401F3BC")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x0401F3BD RID: 127933
		[Token(Token = "0x401F3BD")]
		[FieldOffset(Offset = "0x18")]
		public string taskId;

		// Token: 0x0401F3BE RID: 127934
		[Token(Token = "0x401F3BE")]
		[FieldOffset(Offset = "0x20")]
		public string itemCardId;
	}
}
