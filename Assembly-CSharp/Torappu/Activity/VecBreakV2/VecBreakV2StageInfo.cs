using System;
using Il2CppDummyDll;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E97 RID: 28311
	[Token(Token = "0x2006E97")]
	public class VecBreakV2StageInfo
	{
		// Token: 0x060284B1 RID: 165041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284B1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VecBreakV2StageInfo()
		{
		}

		// Token: 0x04039438 RID: 234552
		[Token(Token = "0x4039438")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04039439 RID: 234553
		[Token(Token = "0x4039439")]
		[FieldOffset(Offset = "0x18")]
		public PlayerStageState state;
	}
}
