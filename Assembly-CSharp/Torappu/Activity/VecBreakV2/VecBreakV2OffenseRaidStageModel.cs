using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E69 RID: 28265
	[Token(Token = "0x2006E69")]
	public class VecBreakV2OffenseRaidStageModel : VecBreakV2OffenseStageModelBase
	{
		// Token: 0x06028399 RID: 164761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028399")]
		[Address(RVA = "0x238AE30", Offset = "0x2389A30", VA = "0x18238AE30")]
		public void LoadData(string actId, ActVecBreakV2HardStageData hardStageData, Dictionary<string, ActVecBreakV2StageRewardData> stageRewardDict)
		{
		}

		// Token: 0x0602839A RID: 164762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602839A")]
		[Address(RVA = "0x238AF00", Offset = "0x2389B00", VA = "0x18238AF00")]
		public VecBreakV2OffenseRaidStageModel()
		{
		}

		// Token: 0x040392AE RID: 234158
		[Token(Token = "0x40392AE")]
		[FieldOffset(Offset = "0x58")]
		public ActVecBreakV2StageOrderType orderType;

		// Token: 0x040392AF RID: 234159
		[Token(Token = "0x40392AF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040392B0 RID: 234160
		[Token(Token = "0x40392B0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
