using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200440B RID: 17419
	[Token(Token = "0x200440B")]
	public class SandboxV2MonthBattleStartRequest
	{
		// Token: 0x0601A9C7 RID: 108999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9C7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2MonthBattleStartRequest()
		{
		}

		// Token: 0x04021EC7 RID: 138951
		[Token(Token = "0x4021EC7")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021EC8 RID: 138952
		[Token(Token = "0x4021EC8")]
		[FieldOffset(Offset = "0x18")]
		public int squadIdx;

		// Token: 0x04021EC9 RID: 138953
		[Token(Token = "0x4021EC9")]
		[FieldOffset(Offset = "0x20")]
		public string monthRushId;
	}
}
