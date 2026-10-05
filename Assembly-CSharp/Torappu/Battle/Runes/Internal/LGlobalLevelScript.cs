using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028D3 RID: 10451
	[Token(Token = "0x20028D3")]
	public class LGlobalLevelScript : BasicLevelRune
	{
		// Token: 0x17002665 RID: 9829
		// (get) Token: 0x0601160C RID: 71180 RVA: 0x0006AEA8 File Offset: 0x000690A8
		[Token(Token = "0x17002665")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x601160C")]
			[Address(RVA = "0x93FB70", Offset = "0x93E770", VA = "0x18093FB70", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x0601160D RID: 71181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601160D")]
		[Address(RVA = "0x93F8E0", Offset = "0x93E4E0", VA = "0x18093F8E0", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x0601160E RID: 71182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601160E")]
		[Address(RVA = "0x93FA70", Offset = "0x93E670", VA = "0x18093FA70", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x0601160F RID: 71183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601160F")]
		[Address(RVA = "0x93FAD0", Offset = "0x93E6D0", VA = "0x18093FAD0")]
		public LGlobalLevelScript()
		{
		}

		// Token: 0x040136C8 RID: 79560
		[Token(Token = "0x40136C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040136C9 RID: 79561
		[Token(Token = "0x40136C9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x040136CA RID: 79562
		[Token(Token = "0x40136CA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;

		// Token: 0x040136CB RID: 79563
		[Token(Token = "0x40136CB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
