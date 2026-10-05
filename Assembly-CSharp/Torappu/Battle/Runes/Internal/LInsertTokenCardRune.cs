using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028E5 RID: 10469
	[Token(Token = "0x20028E5")]
	public class LInsertTokenCardRune : BasicLevelRune
	{
		// Token: 0x17002679 RID: 9849
		// (get) Token: 0x06011664 RID: 71268 RVA: 0x0006B0E8 File Offset: 0x000692E8
		[Token(Token = "0x17002679")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x6011664")]
			[Address(RVA = "0x940E00", Offset = "0x93FA00", VA = "0x180940E00", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x06011665 RID: 71269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011665")]
		[Address(RVA = "0x940D60", Offset = "0x93F960", VA = "0x180940D60")]
		protected LInsertTokenCardRune()
		{
		}

		// Token: 0x06011666 RID: 71270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011666")]
		[Address(RVA = "0x940880", Offset = "0x93F480", VA = "0x180940880", Slot = "13")]
		public override void PreprocessBattlePlayerData(BattlePlayerData playerData)
		{
		}

		// Token: 0x06011667 RID: 71271 RVA: 0x0006B100 File Offset: 0x00069300
		[Token(Token = "0x6011667")]
		[Address(RVA = "0x940C00", Offset = "0x93F800", VA = "0x180940C00")]
		private bool _TryAddCntIfAlreadyExist(BattlePlayerData playerData, Blackboard blackboard)
		{
			return default(bool);
		}

		// Token: 0x06011668 RID: 71272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011668")]
		[Address(RVA = "0x940B10", Offset = "0x93F710", VA = "0x180940B10", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x06011669 RID: 71273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011669")]
		[Address(RVA = "0x940BA0", Offset = "0x93F7A0", VA = "0x180940BA0", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x0601166A RID: 71274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601166A")]
		[Address(RVA = "0x93D570", Offset = "0x93C170", VA = "0x18093D570")]
		private void <>xLuaBaseProxy_PreprocessBattlePlayerData(BattlePlayerData P0)
		{
		}

		// Token: 0x0401371A RID: 79642
		[Token(Token = "0x401371A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x0401371B RID: 79643
		[Token(Token = "0x401371B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401371C RID: 79644
		[Token(Token = "0x401371C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessBattlePlayerData;

		// Token: 0x0401371D RID: 79645
		[Token(Token = "0x401371D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryAddCntIfAlreadyExist;

		// Token: 0x0401371E RID: 79646
		[Token(Token = "0x401371E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x0401371F RID: 79647
		[Token(Token = "0x401371F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;
	}
}
