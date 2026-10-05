using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E63 RID: 28259
	[Token(Token = "0x2006E63")]
	public class VecBreakV2OffenseStageModelBase : IHotfixable
	{
		// Token: 0x17005F00 RID: 24320
		// (get) Token: 0x06028382 RID: 164738 RVA: 0x000D0E90 File Offset: 0x000CF090
		[Token(Token = "0x17005F00")]
		public bool isUnlocked
		{
			[Token(Token = "0x6028382")]
			[Address(RVA = "0x238B680", Offset = "0x238A280", VA = "0x18238B680")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005F01 RID: 24321
		// (get) Token: 0x06028383 RID: 164739 RVA: 0x000D0EA8 File Offset: 0x000CF0A8
		[Token(Token = "0x17005F01")]
		public bool isCompleted
		{
			[Token(Token = "0x6028383")]
			[Address(RVA = "0x238B620", Offset = "0x238A220", VA = "0x18238B620")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005F02 RID: 24322
		// (get) Token: 0x06028384 RID: 164740 RVA: 0x000D0EC0 File Offset: 0x000CF0C0
		[Token(Token = "0x17005F02")]
		public bool hasBoss
		{
			[Token(Token = "0x6028384")]
			[Address(RVA = "0x238B5B0", Offset = "0x238A1B0", VA = "0x18238B5B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06028385 RID: 164741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028385")]
		[Address(RVA = "0x238AF60", Offset = "0x2389B60", VA = "0x18238AF60")]
		public void LoadBasicData(string actId, string stageId, string storyDesc, ActVecBreakV2BossData bossData, Dictionary<string, ActVecBreakV2StageRewardData> stageRewardDict)
		{
		}

		// Token: 0x06028386 RID: 164742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028386")]
		[Address(RVA = "0x238B2C0", Offset = "0x2389EC0", VA = "0x18238B2C0")]
		protected void UpdatePlayerData()
		{
		}

		// Token: 0x06028387 RID: 164743 RVA: 0x000D0ED8 File Offset: 0x000CF0D8
		[Token(Token = "0x6028387")]
		[Address(RVA = "0x238B3E0", Offset = "0x2389FE0", VA = "0x18238B3E0")]
		protected VecBreakV2OffenseStageModelBase.StageStatus _CalcStageStatus()
		{
			return VecBreakV2OffenseStageModelBase.StageStatus.NONE;
		}

		// Token: 0x06028388 RID: 164744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028388")]
		[Address(RVA = "0x238B4C0", Offset = "0x238A0C0", VA = "0x18238B4C0")]
		public VecBreakV2OffenseStageModelBase()
		{
		}

		// Token: 0x04039278 RID: 234104
		[Token(Token = "0x4039278")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04039279 RID: 234105
		[Token(Token = "0x4039279")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x0403927A RID: 234106
		[Token(Token = "0x403927A")]
		[FieldOffset(Offset = "0x20")]
		public string code;

		// Token: 0x0403927B RID: 234107
		[Token(Token = "0x403927B")]
		[FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x0403927C RID: 234108
		[Token(Token = "0x403927C")]
		[FieldOffset(Offset = "0x30")]
		public string stageDesc;

		// Token: 0x0403927D RID: 234109
		[Token(Token = "0x403927D")]
		[FieldOffset(Offset = "0x38")]
		public string storyDesc;

		// Token: 0x0403927E RID: 234110
		[Token(Token = "0x403927E")]
		[FieldOffset(Offset = "0x40")]
		public VecBreakV2OffenseBossModel bossModel;

		// Token: 0x0403927F RID: 234111
		[Token(Token = "0x403927F")]
		[FieldOffset(Offset = "0x48")]
		public VecBreakV2OffenseStageModelBase.StageStatus stageStatus;

		// Token: 0x04039280 RID: 234112
		[Token(Token = "0x4039280")]
		[FieldOffset(Offset = "0x4C")]
		public int commonRewardCnt;

		// Token: 0x04039281 RID: 234113
		[Token(Token = "0x4039281")]
		[FieldOffset(Offset = "0x50")]
		public int firstRewardCnt;

		// Token: 0x04039282 RID: 234114
		[Token(Token = "0x4039282")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isUnlocked;

		// Token: 0x04039283 RID: 234115
		[Token(Token = "0x4039283")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isCompleted;

		// Token: 0x04039284 RID: 234116
		[Token(Token = "0x4039284")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hasBoss;

		// Token: 0x04039285 RID: 234117
		[Token(Token = "0x4039285")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadBasicData;

		// Token: 0x04039286 RID: 234118
		[Token(Token = "0x4039286")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePlayerData;

		// Token: 0x04039287 RID: 234119
		[Token(Token = "0x4039287")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CalcStageStatus;

		// Token: 0x04039288 RID: 234120
		[Token(Token = "0x4039288")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E64 RID: 28260
		[Token(Token = "0x2006E64")]
		public enum StageStatus
		{
			// Token: 0x0403928A RID: 234122
			[Token(Token = "0x403928A")]
			NONE,
			// Token: 0x0403928B RID: 234123
			[Token(Token = "0x403928B")]
			LOCK,
			// Token: 0x0403928C RID: 234124
			[Token(Token = "0x403928C")]
			TODO,
			// Token: 0x0403928D RID: 234125
			[Token(Token = "0x403928D")]
			FINISH
		}
	}
}
