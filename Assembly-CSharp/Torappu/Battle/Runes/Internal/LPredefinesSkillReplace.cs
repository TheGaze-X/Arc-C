using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028E4 RID: 10468
	[Token(Token = "0x20028E4")]
	public class LPredefinesSkillReplace : BasicLevelRune
	{
		// Token: 0x0601165E RID: 71262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601165E")]
		[Address(RVA = "0x942AE0", Offset = "0x9416E0", VA = "0x180942AE0")]
		protected LPredefinesSkillReplace()
		{
		}

		// Token: 0x17002678 RID: 9848
		// (get) Token: 0x0601165F RID: 71263 RVA: 0x0006B0D0 File Offset: 0x000692D0
		[Token(Token = "0x17002678")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x601165F")]
			[Address(RVA = "0x942B80", Offset = "0x941780", VA = "0x180942B80", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x06011660 RID: 71264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011660")]
		[Address(RVA = "0x9423A0", Offset = "0x940FA0", VA = "0x1809423A0", Slot = "13")]
		public override void PreprocessBattlePlayerData(BattlePlayerData playerData)
		{
		}

		// Token: 0x06011661 RID: 71265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011661")]
		[Address(RVA = "0x942760", Offset = "0x941360", VA = "0x180942760", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x06011662 RID: 71266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011662")]
		[Address(RVA = "0x942A80", Offset = "0x941680", VA = "0x180942A80", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x06011663 RID: 71267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011663")]
		[Address(RVA = "0x93D570", Offset = "0x93C170", VA = "0x18093D570")]
		private void <>xLuaBaseProxy_PreprocessBattlePlayerData(BattlePlayerData P0)
		{
		}

		// Token: 0x04013715 RID: 79637
		[Token(Token = "0x4013715")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04013716 RID: 79638
		[Token(Token = "0x4013716")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x04013717 RID: 79639
		[Token(Token = "0x4013717")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessBattlePlayerData;

		// Token: 0x04013718 RID: 79640
		[Token(Token = "0x4013718")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x04013719 RID: 79641
		[Token(Token = "0x4013719")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;
	}
}
