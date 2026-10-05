using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028E2 RID: 10466
	[Token(Token = "0x20028E2")]
	public class LDeckCardsEnable : BasicLevelRune
	{
		// Token: 0x06011654 RID: 71252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011654")]
		[Address(RVA = "0x93D580", Offset = "0x93C180", VA = "0x18093D580")]
		protected LDeckCardsEnable()
		{
		}

		// Token: 0x17002676 RID: 9846
		// (get) Token: 0x06011655 RID: 71253 RVA: 0x0006B0A0 File Offset: 0x000692A0
		[Token(Token = "0x17002676")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x6011655")]
			[Address(RVA = "0x93D620", Offset = "0x93C220", VA = "0x18093D620", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x06011656 RID: 71254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011656")]
		[Address(RVA = "0x93D2D0", Offset = "0x93BED0", VA = "0x18093D2D0", Slot = "13")]
		public override void PreprocessBattlePlayerData(BattlePlayerData playerData)
		{
		}

		// Token: 0x06011657 RID: 71255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011657")]
		[Address(RVA = "0x93D480", Offset = "0x93C080", VA = "0x18093D480", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x06011658 RID: 71256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011658")]
		[Address(RVA = "0x93D510", Offset = "0x93C110", VA = "0x18093D510", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x06011659 RID: 71257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011659")]
		[Address(RVA = "0x93D570", Offset = "0x93C170", VA = "0x18093D570")]
		private void <>xLuaBaseProxy_PreprocessBattlePlayerData(BattlePlayerData P0)
		{
		}

		// Token: 0x0401370C RID: 79628
		[Token(Token = "0x401370C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401370D RID: 79629
		[Token(Token = "0x401370D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x0401370E RID: 79630
		[Token(Token = "0x401370E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessBattlePlayerData;

		// Token: 0x0401370F RID: 79631
		[Token(Token = "0x401370F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x04013710 RID: 79632
		[Token(Token = "0x4013710")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;
	}
}
