using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200239D RID: 9117
	[Token(Token = "0x200239D")]
	public class DynamicBuffWoodrdTile : DynamicBuffTile
	{
		// Token: 0x0600E733 RID: 59187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E733")]
		[Address(RVA = "0x5D0380", Offset = "0x5CEF80", VA = "0x1805D0380", Slot = "21")]
		public override void Init(TileData tileData, GridPosition pos)
		{
		}

		// Token: 0x0600E734 RID: 59188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E734")]
		[Address(RVA = "0x5D08F0", Offset = "0x5CF4F0", VA = "0x1805D08F0")]
		private void _DoExtraBattleLog(string key)
		{
		}

		// Token: 0x17001D07 RID: 7431
		// (get) Token: 0x0600E735 RID: 59189 RVA: 0x00054348 File Offset: 0x00052548
		[Token(Token = "0x17001D07")]
		public override bool triggerable
		{
			[Token(Token = "0x600E735")]
			[Address(RVA = "0x5D0A30", Offset = "0x5CF630", VA = "0x1805D0A30", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600E736 RID: 59190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E736")]
		[Address(RVA = "0x5D0730", Offset = "0x5CF330", VA = "0x1805D0730", Slot = "40")]
		protected override void OnTrigger()
		{
		}

		// Token: 0x0600E737 RID: 59191 RVA: 0x00054360 File Offset: 0x00052560
		[Token(Token = "0x600E737")]
		[Address(RVA = "0x5D07A0", Offset = "0x5CF3A0", VA = "0x1805D07A0", Slot = "49")]
		public override bool SwitchMode(int modeIndex)
		{
			return default(bool);
		}

		// Token: 0x0600E738 RID: 59192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E738")]
		[Address(RVA = "0x5D00B0", Offset = "0x5CECB0", VA = "0x1805D00B0")]
		private void CheckEnemiesFallDown()
		{
		}

		// Token: 0x0600E739 RID: 59193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E739")]
		[Address(RVA = "0x5D0600", Offset = "0x5CF200", VA = "0x1805D0600", Slot = "31")]
		protected override void OnEnemyEnter(Enemy enemy)
		{
		}

		// Token: 0x0600E73A RID: 59194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E73A")]
		[Address(RVA = "0x5D09D0", Offset = "0x5CF5D0", VA = "0x1805D09D0")]
		public DynamicBuffWoodrdTile()
		{
		}

		// Token: 0x0600E73B RID: 59195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E73B")]
		[Address(RVA = "0x50CDC0", Offset = "0x50B9C0", VA = "0x18050CDC0")]
		private void <>xLuaBaseProxy_Init(TileData P0, GridPosition P1)
		{
		}

		// Token: 0x0600E73C RID: 59196 RVA: 0x00054378 File Offset: 0x00052578
		[Token(Token = "0x600E73C")]
		[Address(RVA = "0x5D08E0", Offset = "0x5CF4E0", VA = "0x1805D08E0")]
		private bool <>xLuaBaseProxy_get_triggerable()
		{
			return default(bool);
		}

		// Token: 0x0600E73D RID: 59197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E73D")]
		[Address(RVA = "0x5B95E0", Offset = "0x5B81E0", VA = "0x1805B95E0")]
		private void <>xLuaBaseProxy_OnTrigger()
		{
		}

		// Token: 0x0600E73E RID: 59198 RVA: 0x00054390 File Offset: 0x00052590
		[Token(Token = "0x600E73E")]
		[Address(RVA = "0x5CFF70", Offset = "0x5CEB70", VA = "0x1805CFF70")]
		private bool <>xLuaBaseProxy_SwitchMode(int P0)
		{
			return default(bool);
		}

		// Token: 0x0600E73F RID: 59199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E73F")]
		[Address(RVA = "0x5D08D0", Offset = "0x5CF4D0", VA = "0x1805D08D0")]
		private void <>xLuaBaseProxy_OnEnemyEnter(Enemy P0)
		{
		}

		// Token: 0x0400FEA3 RID: 65187
		[Token(Token = "0x400FEA3")]
		private const string SPECIAL_UNIT_MARK_BUFF_KEY = "lpeopl_fly_a[mark]";

		// Token: 0x0400FEA4 RID: 65188
		[Token(Token = "0x400FEA4")]
		private const string LOGTYPE = "SIMPLE";

		// Token: 0x0400FEA5 RID: 65189
		[Token(Token = "0x400FEA5")]
		private const string LOGTARGET = "tile_woodrd";

		// Token: 0x0400FEA6 RID: 65190
		[Token(Token = "0x400FEA6")]
		private const string LOGBORN = "born";

		// Token: 0x0400FEA7 RID: 65191
		[Token(Token = "0x400FEA7")]
		private const string LOGKILL = "killed";

		// Token: 0x0400FEA8 RID: 65192
		[Token(Token = "0x400FEA8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400FEA9 RID: 65193
		[Token(Token = "0x400FEA9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__DoExtraBattleLog;

		// Token: 0x0400FEAA RID: 65194
		[Token(Token = "0x400FEAA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_triggerable;

		// Token: 0x0400FEAB RID: 65195
		[Token(Token = "0x400FEAB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTrigger;

		// Token: 0x0400FEAC RID: 65196
		[Token(Token = "0x400FEAC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SwitchMode;

		// Token: 0x0400FEAD RID: 65197
		[Token(Token = "0x400FEAD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckEnemiesFallDown;

		// Token: 0x0400FEAE RID: 65198
		[Token(Token = "0x400FEAE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnemyEnter;

		// Token: 0x0400FEAF RID: 65199
		[Token(Token = "0x400FEAF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
