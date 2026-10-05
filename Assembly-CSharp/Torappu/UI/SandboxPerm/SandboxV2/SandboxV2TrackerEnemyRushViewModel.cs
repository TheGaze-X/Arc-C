using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200422B RID: 16939
	[Token(Token = "0x200422B")]
	public class SandboxV2TrackerEnemyRushViewModel
	{
		// Token: 0x0601A203 RID: 107011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A203")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2TrackerEnemyRushViewModel()
		{
		}

		// Token: 0x04020FAB RID: 135083
		[Token(Token = "0x4020FAB")]
		[FieldOffset(Offset = "0x10")]
		public string nodeId;

		// Token: 0x04020FAC RID: 135084
		[Token(Token = "0x4020FAC")]
		[FieldOffset(Offset = "0x18")]
		public int day;

		// Token: 0x04020FAD RID: 135085
		[Token(Token = "0x4020FAD")]
		[FieldOffset(Offset = "0x20")]
		public string enemyRushId;

		// Token: 0x04020FAE RID: 135086
		[Token(Token = "0x4020FAE")]
		[FieldOffset(Offset = "0x28")]
		public string iconId;

		// Token: 0x04020FAF RID: 135087
		[Token(Token = "0x4020FAF")]
		[FieldOffset(Offset = "0x30")]
		public string desc;

		// Token: 0x04020FB0 RID: 135088
		[Token(Token = "0x4020FB0")]
		[FieldOffset(Offset = "0x38")]
		public float ratio;

		// Token: 0x04020FB1 RID: 135089
		[Token(Token = "0x4020FB1")]
		[FieldOffset(Offset = "0x3C")]
		public SandboxV2EnemyRushType type;

		// Token: 0x04020FB2 RID: 135090
		[Token(Token = "0x4020FB2")]
		[FieldOffset(Offset = "0x40")]
		public SandboxV2QuestLineBadgeType badgeType;

		// Token: 0x04020FB3 RID: 135091
		[Token(Token = "0x4020FB3")]
		[FieldOffset(Offset = "0x44")]
		public SandboxV2FloatAppearanceType appearanceType;
	}
}
