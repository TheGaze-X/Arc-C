using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028DE RID: 10462
	[Token(Token = "0x20028DE")]
	public class LInputCardDelete : BasicLevelRune
	{
		// Token: 0x0601163D RID: 71229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601163D")]
		[Address(RVA = "0x940780", Offset = "0x93F380", VA = "0x180940780")]
		protected LInputCardDelete()
		{
		}

		// Token: 0x17002672 RID: 9842
		// (get) Token: 0x0601163E RID: 71230 RVA: 0x0006B028 File Offset: 0x00069228
		[Token(Token = "0x17002672")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x601163E")]
			[Address(RVA = "0x940820", Offset = "0x93F420", VA = "0x180940820", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x0601163F RID: 71231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601163F")]
		[Address(RVA = "0x940490", Offset = "0x93F090", VA = "0x180940490", Slot = "13")]
		public override void PreprocessBattlePlayerData(BattlePlayerData playerData)
		{
		}

		// Token: 0x06011640 RID: 71232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011640")]
		[Address(RVA = "0x940690", Offset = "0x93F290", VA = "0x180940690", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x06011641 RID: 71233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011641")]
		[Address(RVA = "0x940720", Offset = "0x93F320", VA = "0x180940720", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x06011642 RID: 71234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011642")]
		[Address(RVA = "0x93D570", Offset = "0x93C170", VA = "0x18093D570")]
		private void <>xLuaBaseProxy_PreprocessBattlePlayerData(BattlePlayerData P0)
		{
		}

		// Token: 0x040136F7 RID: 79607
		[Token(Token = "0x40136F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040136F8 RID: 79608
		[Token(Token = "0x40136F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040136F9 RID: 79609
		[Token(Token = "0x40136F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessBattlePlayerData;

		// Token: 0x040136FA RID: 79610
		[Token(Token = "0x40136FA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x040136FB RID: 79611
		[Token(Token = "0x40136FB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;
	}
}
