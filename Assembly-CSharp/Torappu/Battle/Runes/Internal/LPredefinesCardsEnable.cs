using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028E0 RID: 10464
	[Token(Token = "0x20028E0")]
	public class LPredefinesCardsEnable : BasicLevelRune
	{
		// Token: 0x06011648 RID: 71240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011648")]
		[Address(RVA = "0x941F00", Offset = "0x940B00", VA = "0x180941F00")]
		protected LPredefinesCardsEnable()
		{
		}

		// Token: 0x17002674 RID: 9844
		// (get) Token: 0x06011649 RID: 71241 RVA: 0x0006B070 File Offset: 0x00069270
		[Token(Token = "0x17002674")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x6011649")]
			[Address(RVA = "0x941FA0", Offset = "0x940BA0", VA = "0x180941FA0", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x0601164A RID: 71242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601164A")]
		[Address(RVA = "0x941C40", Offset = "0x940840", VA = "0x180941C40", Slot = "13")]
		public override void PreprocessBattlePlayerData(BattlePlayerData playerData)
		{
		}

		// Token: 0x0601164B RID: 71243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601164B")]
		[Address(RVA = "0x941E10", Offset = "0x940A10", VA = "0x180941E10", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x0601164C RID: 71244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601164C")]
		[Address(RVA = "0x941EA0", Offset = "0x940AA0", VA = "0x180941EA0", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x0601164D RID: 71245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601164D")]
		[Address(RVA = "0x93D570", Offset = "0x93C170", VA = "0x18093D570")]
		private void <>xLuaBaseProxy_PreprocessBattlePlayerData(BattlePlayerData P0)
		{
		}

		// Token: 0x04013702 RID: 79618
		[Token(Token = "0x4013702")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04013703 RID: 79619
		[Token(Token = "0x4013703")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x04013704 RID: 79620
		[Token(Token = "0x4013704")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessBattlePlayerData;

		// Token: 0x04013705 RID: 79621
		[Token(Token = "0x4013705")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x04013706 RID: 79622
		[Token(Token = "0x4013706")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;
	}
}
