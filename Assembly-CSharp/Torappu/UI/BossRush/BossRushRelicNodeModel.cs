using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x02006194 RID: 24980
	[Token(Token = "0x2006194")]
	public class BossRushRelicNodeModel : IHotfixable
	{
		// Token: 0x06024086 RID: 147590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024086")]
		[Address(RVA = "0x1EA46A0", Offset = "0x1EA32A0", VA = "0x181EA46A0")]
		public void InitData(ActivityBossRushData.RelicData relicData, ActivityBossRushData.RelicLevelInfoData relicLevelInfoData)
		{
		}

		// Token: 0x06024087 RID: 147591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024087")]
		[Address(RVA = "0x1EA47A0", Offset = "0x1EA33A0", VA = "0x181EA47A0")]
		public void UpdateData(PlayerActivity.PlayerBossRushActivity.RelicInfo data, bool refreshSelect = true)
		{
		}

		// Token: 0x06024088 RID: 147592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024088")]
		[Address(RVA = "0x1EA4A30", Offset = "0x1EA3630", VA = "0x181EA4A30")]
		public void UpdateSelect(string selectingRelicId)
		{
		}

		// Token: 0x06024089 RID: 147593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024089")]
		[Address(RVA = "0x1EA4AD0", Offset = "0x1EA36D0", VA = "0x181EA4AD0")]
		public BossRushRelicNodeModel()
		{
		}

		// Token: 0x0403210C RID: 205068
		[Token(Token = "0x403210C")]
		[FieldOffset(Offset = "0x10")]
		public string relicId;

		// Token: 0x0403210D RID: 205069
		[Token(Token = "0x403210D")]
		[FieldOffset(Offset = "0x18")]
		public int relicLevel;

		// Token: 0x0403210E RID: 205070
		[Token(Token = "0x403210E")]
		[FieldOffset(Offset = "0x1C")]
		public int maxLevel;

		// Token: 0x0403210F RID: 205071
		[Token(Token = "0x403210F")]
		[FieldOffset(Offset = "0x20")]
		public bool showNewPart;

		// Token: 0x04032110 RID: 205072
		[Token(Token = "0x4032110")]
		[FieldOffset(Offset = "0x24")]
		public BossRushRelicNodeModel.RELIC_STATE relicState;

		// Token: 0x04032111 RID: 205073
		[Token(Token = "0x4032111")]
		[FieldOffset(Offset = "0x28")]
		public bool selecting;

		// Token: 0x04032112 RID: 205074
		[Token(Token = "0x4032112")]
		[FieldOffset(Offset = "0x2C")]
		public int upgradeNeed;

		// Token: 0x04032113 RID: 205075
		[Token(Token = "0x4032113")]
		[FieldOffset(Offset = "0x30")]
		public PlayerActivity.PlayerBossRushActivity.RelicInfo relicInfo;

		// Token: 0x04032114 RID: 205076
		[Token(Token = "0x4032114")]
		[FieldOffset(Offset = "0x38")]
		public bool playSelectAnim;

		// Token: 0x04032115 RID: 205077
		[Token(Token = "0x4032115")]
		[FieldOffset(Offset = "0x39")]
		public bool playUnSelectAnim;

		// Token: 0x04032116 RID: 205078
		[Token(Token = "0x4032116")]
		[FieldOffset(Offset = "0x40")]
		public ActivityBossRushData.RelicData relicData;

		// Token: 0x04032117 RID: 205079
		[Token(Token = "0x4032117")]
		[FieldOffset(Offset = "0x48")]
		public ActivityBossRushData.RelicLevelInfoData relicLevelInfoData;

		// Token: 0x04032118 RID: 205080
		[Token(Token = "0x4032118")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04032119 RID: 205081
		[Token(Token = "0x4032119")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0403211A RID: 205082
		[Token(Token = "0x403211A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateSelect;

		// Token: 0x0403211B RID: 205083
		[Token(Token = "0x403211B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006195 RID: 24981
		[Token(Token = "0x2006195")]
		public enum RELIC_STATE
		{
			// Token: 0x0403211D RID: 205085
			[Token(Token = "0x403211D")]
			LOCKED,
			// Token: 0x0403211E RID: 205086
			[Token(Token = "0x403211E")]
			NORMAL,
			// Token: 0x0403211F RID: 205087
			[Token(Token = "0x403211F")]
			UPGRADE,
			// Token: 0x04032120 RID: 205088
			[Token(Token = "0x4032120")]
			MAX
		}
	}
}
