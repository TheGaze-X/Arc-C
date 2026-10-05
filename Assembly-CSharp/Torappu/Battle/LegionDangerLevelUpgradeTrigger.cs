using System;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200256B RID: 9579
	[Token(Token = "0x200256B")]
	public class LegionDangerLevelUpgradeTrigger : TargetTrigger
	{
		// Token: 0x1700206A RID: 8298
		// (get) Token: 0x0600F72F RID: 63279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700206A")]
		public override Entity target
		{
			[Token(Token = "0x600F72F")]
			[Address(RVA = "0x710340", Offset = "0x70EF40", VA = "0x180710340", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F730 RID: 63280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F730")]
		[Address(RVA = "0x7100D0", Offset = "0x70ECD0", VA = "0x1807100D0", Slot = "11")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x1700206B RID: 8299
		// (get) Token: 0x0600F731 RID: 63281 RVA: 0x0005C478 File Offset: 0x0005A678
		[Token(Token = "0x1700206B")]
		public override bool isReadyToTrig
		{
			[Token(Token = "0x600F731")]
			[Address(RVA = "0x7102E0", Offset = "0x70EEE0", VA = "0x1807102E0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F732 RID: 63282 RVA: 0x0005C490 File Offset: 0x0005A690
		[Token(Token = "0x600F732")]
		[Address(RVA = "0x710040", Offset = "0x70EC40", VA = "0x180710040", Slot = "13")]
		public override bool Search(bool force)
		{
			return default(bool);
		}

		// Token: 0x0600F733 RID: 63283 RVA: 0x0005C4A8 File Offset: 0x0005A6A8
		[Token(Token = "0x600F733")]
		[Address(RVA = "0x70FFD0", Offset = "0x70EBD0", VA = "0x18070FFD0", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F734 RID: 63284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F734")]
		[Address(RVA = "0x710230", Offset = "0x70EE30", VA = "0x180710230")]
		public LegionDangerLevelUpgradeTrigger()
		{
		}

		// Token: 0x0600F735 RID: 63285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F735")]
		[Address(RVA = "0x70D9A0", Offset = "0x70C5A0", VA = "0x18070D9A0")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0600F736 RID: 63286 RVA: 0x0005C4C0 File Offset: 0x0005A6C0
		[Token(Token = "0x600F736")]
		[Address(RVA = "0x6EF7F0", Offset = "0x6EE3F0", VA = "0x1806EF7F0")]
		private bool <>xLuaBaseProxy_get_isReadyToTrig()
		{
			return default(bool);
		}

		// Token: 0x0401129C RID: 70300
		[Token(Token = "0x401129C")]
		[FieldOffset(Offset = "0x20")]
		private int m_curLevel;

		// Token: 0x0401129D RID: 70301
		[Token(Token = "0x401129D")]
		[FieldOffset(Offset = "0x28")]
		private GameModeFactory.LegionGameMode m_gameMode;

		// Token: 0x0401129E RID: 70302
		[Token(Token = "0x401129E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_target;

		// Token: 0x0401129F RID: 70303
		[Token(Token = "0x401129F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040112A0 RID: 70304
		[Token(Token = "0x40112A0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isReadyToTrig;

		// Token: 0x040112A1 RID: 70305
		[Token(Token = "0x40112A1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Search;

		// Token: 0x040112A2 RID: 70306
		[Token(Token = "0x40112A2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x040112A3 RID: 70307
		[Token(Token = "0x40112A3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
