using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028CC RID: 10444
	[Token(Token = "0x20028CC")]
	public class LMaxLifePointSet : BasicLevelRune
	{
		// Token: 0x060115F0 RID: 71152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115F0")]
		[Address(RVA = "0x941B40", Offset = "0x940740", VA = "0x180941B40")]
		protected LMaxLifePointSet()
		{
		}

		// Token: 0x1700265E RID: 9822
		// (get) Token: 0x060115F1 RID: 71153 RVA: 0x0006AE00 File Offset: 0x00069000
		[Token(Token = "0x1700265E")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x60115F1")]
			[Address(RVA = "0x941BE0", Offset = "0x9407E0", VA = "0x180941BE0", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x060115F2 RID: 71154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115F2")]
		[Address(RVA = "0x941A80", Offset = "0x940680", VA = "0x180941A80", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x060115F3 RID: 71155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115F3")]
		[Address(RVA = "0x9419F0", Offset = "0x9405F0", VA = "0x1809419F0", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x040136AC RID: 79532
		[Token(Token = "0x40136AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040136AD RID: 79533
		[Token(Token = "0x40136AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040136AE RID: 79534
		[Token(Token = "0x40136AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;

		// Token: 0x040136AF RID: 79535
		[Token(Token = "0x40136AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;
	}
}
