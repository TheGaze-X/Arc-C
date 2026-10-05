using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000B74 RID: 2932
	[Token(Token = "0x2000B74")]
	public class PlayerHomeConditionProgress
	{
		// Token: 0x06006812 RID: 26642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006812")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerHomeConditionProgress()
		{
		}

		// Token: 0x04003CF0 RID: 15600
		[Token(Token = "0x4003CF0")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty(PropertyName = "v")]
		public int curProgress;

		// Token: 0x04003CF1 RID: 15601
		[Token(Token = "0x4003CF1")]
		[FieldOffset(Offset = "0x14")]
		[JsonProperty(PropertyName = "t")]
		public int total;

		// Token: 0x04003CF2 RID: 15602
		[Token(Token = "0x4003CF2")]
		[FieldOffset(Offset = "0x0")]
		public static PlayerHomeConditionProgress DEFAULT;
	}
}
