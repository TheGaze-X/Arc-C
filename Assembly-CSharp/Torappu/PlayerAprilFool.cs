using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000B79 RID: 2937
	[Token(Token = "0x2000B79")]
	public class PlayerAprilFool
	{
		// Token: 0x06006818 RID: 26648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006818")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerAprilFool()
		{
		}

		// Token: 0x04003CF9 RID: 15609
		[Token(Token = "0x4003CF9")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("act3fun")]
		public PlayerActFun3 actFun3;

		// Token: 0x04003CFA RID: 15610
		[Token(Token = "0x4003CFA")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("act4fun")]
		public PlayerActFun4 actFun4;

		// Token: 0x04003CFB RID: 15611
		[Token(Token = "0x4003CFB")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("act5fun")]
		public PlayerActFun5 actFun5;

		// Token: 0x04003CFC RID: 15612
		[Token(Token = "0x4003CFC")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("act6fun")]
		public PlayerActFun6 actFun6;

		// Token: 0x04003CFD RID: 15613
		[Token(Token = "0x4003CFD")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("act7fun")]
		public PlayerActFun7 actFun7;
	}
}
