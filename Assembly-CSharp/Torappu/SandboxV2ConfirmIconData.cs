using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012E9 RID: 4841
	[Token(Token = "0x20012E9")]
	public class SandboxV2ConfirmIconData
	{
		// Token: 0x06007262 RID: 29282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007262")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2ConfirmIconData()
		{
		}

		// Token: 0x04006AF2 RID: 27378
		[Token(Token = "0x4006AF2")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2ConfirmIconType iconType;

		// Token: 0x04006AF3 RID: 27379
		[Token(Token = "0x4006AF3")]
		[FieldOffset(Offset = "0x18")]
		public string iconPicId;
	}
}
