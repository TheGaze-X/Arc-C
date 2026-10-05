using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012C3 RID: 4803
	[Token(Token = "0x20012C3")]
	public class SandboxV2EventSceneData
	{
		// Token: 0x0600723C RID: 29244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600723C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2EventSceneData()
		{
		}

		// Token: 0x04006A1B RID: 27163
		[Token(Token = "0x4006A1B")]
		[FieldOffset(Offset = "0x10")]
		public string eventSceneId;

		// Token: 0x04006A1C RID: 27164
		[Token(Token = "0x4006A1C")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		// Token: 0x04006A1D RID: 27165
		[Token(Token = "0x4006A1D")]
		[FieldOffset(Offset = "0x20")]
		public string desc;

		// Token: 0x04006A1E RID: 27166
		[Token(Token = "0x4006A1E")]
		[FieldOffset(Offset = "0x28")]
		public List<string> choiceIds;
	}
}
