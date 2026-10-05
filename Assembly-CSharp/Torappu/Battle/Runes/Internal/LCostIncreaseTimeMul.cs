using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028CA RID: 10442
	[Token(Token = "0x20028CA")]
	public class LCostIncreaseTimeMul : BasicLevelRune
	{
		// Token: 0x060115E8 RID: 71144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115E8")]
		[Address(RVA = "0x93D1D0", Offset = "0x93BDD0", VA = "0x18093D1D0")]
		protected LCostIncreaseTimeMul()
		{
		}

		// Token: 0x1700265C RID: 9820
		// (get) Token: 0x060115E9 RID: 71145 RVA: 0x0006ADD0 File Offset: 0x00068FD0
		[Token(Token = "0x1700265C")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x60115E9")]
			[Address(RVA = "0x93D270", Offset = "0x93BE70", VA = "0x18093D270", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x060115EA RID: 71146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115EA")]
		[Address(RVA = "0x93D100", Offset = "0x93BD00", VA = "0x18093D100", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x060115EB RID: 71147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115EB")]
		[Address(RVA = "0x93D070", Offset = "0x93BC70", VA = "0x18093D070", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x040136A4 RID: 79524
		[Token(Token = "0x40136A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040136A5 RID: 79525
		[Token(Token = "0x40136A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040136A6 RID: 79526
		[Token(Token = "0x40136A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;

		// Token: 0x040136A7 RID: 79527
		[Token(Token = "0x40136A7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;
	}
}
