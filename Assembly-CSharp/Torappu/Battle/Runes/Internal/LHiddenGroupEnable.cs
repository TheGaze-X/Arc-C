using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028D9 RID: 10457
	[Token(Token = "0x20028D9")]
	public class LHiddenGroupEnable : BasicLevelRune
	{
		// Token: 0x06011629 RID: 71209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011629")]
		[Address(RVA = "0x940110", Offset = "0x93ED10", VA = "0x180940110")]
		protected LHiddenGroupEnable()
		{
		}

		// Token: 0x1700266D RID: 9837
		// (get) Token: 0x0601162A RID: 71210 RVA: 0x0006AFB0 File Offset: 0x000691B0
		[Token(Token = "0x1700266D")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x601162A")]
			[Address(RVA = "0x9401B0", Offset = "0x93EDB0", VA = "0x1809401B0", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x0601162B RID: 71211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601162B")]
		[Address(RVA = "0x93FEF0", Offset = "0x93EAF0", VA = "0x18093FEF0", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x0601162C RID: 71212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601162C")]
		[Address(RVA = "0x9400B0", Offset = "0x93ECB0", VA = "0x1809400B0", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x040136E3 RID: 79587
		[Token(Token = "0x40136E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040136E4 RID: 79588
		[Token(Token = "0x40136E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040136E5 RID: 79589
		[Token(Token = "0x40136E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x040136E6 RID: 79590
		[Token(Token = "0x40136E6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;
	}
}
