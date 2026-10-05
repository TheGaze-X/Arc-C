using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028C9 RID: 10441
	[Token(Token = "0x20028C9")]
	public class LInitCostAdd : BasicLevelRune
	{
		// Token: 0x1700265B RID: 9819
		// (get) Token: 0x060115E4 RID: 71140 RVA: 0x0006ADB8 File Offset: 0x00068FB8
		[Token(Token = "0x1700265B")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x60115E4")]
			[Address(RVA = "0x940430", Offset = "0x93F030", VA = "0x180940430", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x060115E5 RID: 71141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115E5")]
		[Address(RVA = "0x940390", Offset = "0x93EF90", VA = "0x180940390")]
		protected LInitCostAdd()
		{
		}

		// Token: 0x060115E6 RID: 71142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115E6")]
		[Address(RVA = "0x9402A0", Offset = "0x93EEA0", VA = "0x1809402A0", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x060115E7 RID: 71143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115E7")]
		[Address(RVA = "0x940210", Offset = "0x93EE10", VA = "0x180940210", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x040136A0 RID: 79520
		[Token(Token = "0x40136A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040136A1 RID: 79521
		[Token(Token = "0x40136A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040136A2 RID: 79522
		[Token(Token = "0x40136A2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;

		// Token: 0x040136A3 RID: 79523
		[Token(Token = "0x40136A3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;
	}
}
