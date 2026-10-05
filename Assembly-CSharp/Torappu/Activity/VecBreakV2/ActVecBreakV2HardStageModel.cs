using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DF7 RID: 28151
	[Token(Token = "0x2006DF7")]
	public class ActVecBreakV2HardStageModel : IHotfixable
	{
		// Token: 0x0602813C RID: 164156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602813C")]
		[Address(RVA = "0x234F810", Offset = "0x234E410", VA = "0x18234F810")]
		public ActVecBreakV2HardStageModel()
		{
		}

		// Token: 0x04038DAF RID: 232879
		[Token(Token = "0x4038DAF")]
		[FieldOffset(Offset = "0x10")]
		public ActVecBreakV2StageOrderType stageOrderType;

		// Token: 0x04038DB0 RID: 232880
		[Token(Token = "0x4038DB0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
