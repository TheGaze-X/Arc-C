using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028DA RID: 10458
	[Token(Token = "0x20028DA")]
	public class LHiddenGroupDisable : BasicLevelRune
	{
		// Token: 0x0601162D RID: 71213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601162D")]
		[Address(RVA = "0x93FDF0", Offset = "0x93E9F0", VA = "0x18093FDF0")]
		protected LHiddenGroupDisable()
		{
		}

		// Token: 0x1700266E RID: 9838
		// (get) Token: 0x0601162E RID: 71214 RVA: 0x0006AFC8 File Offset: 0x000691C8
		[Token(Token = "0x1700266E")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x601162E")]
			[Address(RVA = "0x93FE90", Offset = "0x93EA90", VA = "0x18093FE90", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x0601162F RID: 71215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601162F")]
		[Address(RVA = "0x93FBD0", Offset = "0x93E7D0", VA = "0x18093FBD0", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x06011630 RID: 71216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011630")]
		[Address(RVA = "0x93FD90", Offset = "0x93E990", VA = "0x18093FD90", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x040136E7 RID: 79591
		[Token(Token = "0x40136E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040136E8 RID: 79592
		[Token(Token = "0x40136E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040136E9 RID: 79593
		[Token(Token = "0x40136E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x040136EA RID: 79594
		[Token(Token = "0x40136EA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;
	}
}
