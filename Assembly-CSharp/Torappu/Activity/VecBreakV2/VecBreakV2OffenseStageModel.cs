using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E65 RID: 28261
	[Token(Token = "0x2006E65")]
	public class VecBreakV2OffenseStageModel : VecBreakV2OffenseStageModelBase, IComparable<VecBreakV2OffenseStageModel>
	{
		// Token: 0x06028389 RID: 164745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028389")]
		[Address(RVA = "0x238B770", Offset = "0x238A370", VA = "0x18238B770")]
		public void LoadData(string actId, int maxLevel, ActVecBreakV2OffenseStageData offenseStageData, Dictionary<string, ActVecBreakV2StageRewardData> stageRewardDict)
		{
		}

		// Token: 0x0602838A RID: 164746 RVA: 0x000D0EF0 File Offset: 0x000CF0F0
		[Token(Token = "0x602838A")]
		[Address(RVA = "0x238B6F0", Offset = "0x238A2F0", VA = "0x18238B6F0", Slot = "4")]
		public int CompareTo(VecBreakV2OffenseStageModel other)
		{
			return 0;
		}

		// Token: 0x0602838B RID: 164747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602838B")]
		[Address(RVA = "0x238B870", Offset = "0x238A470", VA = "0x18238B870")]
		public VecBreakV2OffenseStageModel()
		{
		}

		// Token: 0x0403928E RID: 234126
		[Token(Token = "0x403928E")]
		[FieldOffset(Offset = "0x58")]
		public int level;

		// Token: 0x0403928F RID: 234127
		[Token(Token = "0x403928F")]
		[FieldOffset(Offset = "0x60")]
		public string levelLayout;

		// Token: 0x04039290 RID: 234128
		[Token(Token = "0x4039290")]
		[FieldOffset(Offset = "0x68")]
		public bool isTopLevel;

		// Token: 0x04039291 RID: 234129
		[Token(Token = "0x4039291")]
		[FieldOffset(Offset = "0x6C")]
		public ActVecBreakV2ParticleType particleType;

		// Token: 0x04039292 RID: 234130
		[Token(Token = "0x4039292")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04039293 RID: 234131
		[Token(Token = "0x4039293")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04039294 RID: 234132
		[Token(Token = "0x4039294")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
