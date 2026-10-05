using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x020063D5 RID: 25557
	[Token(Token = "0x20063D5")]
	public class AutoChessServiceParam
	{
		// Token: 0x06024D95 RID: 150933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D95")]
		[Address(RVA = "0x1FC0F90", Offset = "0x1FBFB90", VA = "0x181FC0F90")]
		public AutoChessServiceParam()
		{
		}

		// Token: 0x04033842 RID: 211010
		[Token(Token = "0x4033842")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessService.Setting setting;

		// Token: 0x04033843 RID: 211011
		[Token(Token = "0x4033843")]
		[FieldOffset(Offset = "0x30")]
		public string activityId;
	}
}
