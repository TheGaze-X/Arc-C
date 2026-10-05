using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028E3 RID: 10467
	[Token(Token = "0x20028E3")]
	public class LEnemyKeyReplace : BasicLevelRune
	{
		// Token: 0x0601165A RID: 71258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601165A")]
		[Address(RVA = "0x93D950", Offset = "0x93C550", VA = "0x18093D950")]
		protected LEnemyKeyReplace()
		{
		}

		// Token: 0x17002677 RID: 9847
		// (get) Token: 0x0601165B RID: 71259 RVA: 0x0006B0B8 File Offset: 0x000692B8
		[Token(Token = "0x17002677")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x601165B")]
			[Address(RVA = "0x93D9F0", Offset = "0x93C5F0", VA = "0x18093D9F0", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x0601165C RID: 71260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601165C")]
		[Address(RVA = "0x93D680", Offset = "0x93C280", VA = "0x18093D680", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x0601165D RID: 71261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601165D")]
		[Address(RVA = "0x93D8F0", Offset = "0x93C4F0", VA = "0x18093D8F0", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x04013711 RID: 79633
		[Token(Token = "0x4013711")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04013712 RID: 79634
		[Token(Token = "0x4013712")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x04013713 RID: 79635
		[Token(Token = "0x4013713")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x04013714 RID: 79636
		[Token(Token = "0x4013714")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;
	}
}
