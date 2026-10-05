using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000BFB RID: 3067
	[Token(Token = "0x2000BFB")]
	public class PlayerSandboxPerm
	{
		// Token: 0x0600688F RID: 26767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600688F")]
		[Address(RVA = "0x1EFD350", Offset = "0x1EFBF50", VA = "0x181EFD350")]
		public PlayerSandboxPerm()
		{
		}

		// Token: 0x04003EB5 RID: 16053
		[Token(Token = "0x4003EB5")]
		[FieldOffset(Offset = "0x10")]
		public PlayerSandboxPerm.PlayerSandboxTemplateData template;

		// Token: 0x04003EB6 RID: 16054
		[Token(Token = "0x4003EB6")]
		[FieldOffset(Offset = "0x18")]
		public bool isClose;

		// Token: 0x02000BFC RID: 3068
		[Token(Token = "0x2000BFC")]
		public class PlayerSandboxTemplateData
		{
			// Token: 0x06006890 RID: 26768 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006890")]
			[Address(RVA = "0x1EFD430", Offset = "0x1EFC030", VA = "0x181EFD430")]
			public PlayerSandboxTemplateData()
			{
			}

			// Token: 0x04003EB7 RID: 16055
			[Token(Token = "0x4003EB7")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty("SANDBOX_V2")]
			public ListDict<string, PlayerSandboxV2> sandboxV2TemplateData;
		}
	}
}
