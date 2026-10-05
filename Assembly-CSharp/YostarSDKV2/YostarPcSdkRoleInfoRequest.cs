using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YostarSDKV2
{
	// Token: 0x02000082 RID: 130
	[Token(Token = "0x2000082")]
	public sealed class YostarPcSdkRoleInfoRequest
	{
		// Token: 0x060001FC RID: 508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public YostarPcSdkRoleInfoRequest()
		{
		}

		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x10")]
		public string serverId;

		// Token: 0x04000275 RID: 629
		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x18")]
		public string roleId;

		// Token: 0x04000276 RID: 630
		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x20")]
		public string roleName;

		// Token: 0x04000277 RID: 631
		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, string> customFields;
	}
}
