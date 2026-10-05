using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028CB RID: 10443
	[Token(Token = "0x20028CB")]
	public class LMaxCostSet : BasicLevelRune
	{
		// Token: 0x1700265D RID: 9821
		// (get) Token: 0x060115EC RID: 71148 RVA: 0x0006ADE8 File Offset: 0x00068FE8
		[Token(Token = "0x1700265D")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x60115EC")]
			[Address(RVA = "0x941740", Offset = "0x940340", VA = "0x180941740", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x060115ED RID: 71149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115ED")]
		[Address(RVA = "0x9416A0", Offset = "0x9402A0", VA = "0x1809416A0")]
		protected LMaxCostSet()
		{
		}

		// Token: 0x060115EE RID: 71150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115EE")]
		[Address(RVA = "0x941500", Offset = "0x940100", VA = "0x180941500", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x060115EF RID: 71151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115EF")]
		[Address(RVA = "0x941470", Offset = "0x940070", VA = "0x180941470", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x040136A8 RID: 79528
		[Token(Token = "0x40136A8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040136A9 RID: 79529
		[Token(Token = "0x40136A9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040136AA RID: 79530
		[Token(Token = "0x40136AA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;

		// Token: 0x040136AB RID: 79531
		[Token(Token = "0x40136AB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;
	}
}
