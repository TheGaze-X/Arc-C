using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DF6 RID: 28150
	[Token(Token = "0x2006DF6")]
	public class ActVecBreakV2OffenseStageModel : IHotfixable
	{
		// Token: 0x0602813B RID: 164155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602813B")]
		[Address(RVA = "0x2354A70", Offset = "0x2353670", VA = "0x182354A70")]
		public ActVecBreakV2OffenseStageModel()
		{
		}

		// Token: 0x04038DAC RID: 232876
		[Token(Token = "0x4038DAC")]
		[FieldOffset(Offset = "0x10")]
		public bool isNormal;

		// Token: 0x04038DAD RID: 232877
		[Token(Token = "0x4038DAD")]
		[FieldOffset(Offset = "0x14")]
		public int stageLevel;

		// Token: 0x04038DAE RID: 232878
		[Token(Token = "0x4038DAE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
