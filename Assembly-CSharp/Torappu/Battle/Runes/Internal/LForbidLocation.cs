using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028D0 RID: 10448
	[Token(Token = "0x20028D0")]
	public class LForbidLocation : BasicLevelRune
	{
		// Token: 0x17002662 RID: 9826
		// (get) Token: 0x06011600 RID: 71168 RVA: 0x0006AE60 File Offset: 0x00069060
		[Token(Token = "0x17002662")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x6011600")]
			[Address(RVA = "0x93DEB0", Offset = "0x93CAB0", VA = "0x18093DEB0", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x06011601 RID: 71169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011601")]
		[Address(RVA = "0x93DCA0", Offset = "0x93C8A0", VA = "0x18093DCA0", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x06011602 RID: 71170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011602")]
		[Address(RVA = "0x93DDB0", Offset = "0x93C9B0", VA = "0x18093DDB0", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x06011603 RID: 71171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011603")]
		[Address(RVA = "0x93DE10", Offset = "0x93CA10", VA = "0x18093DE10")]
		public LForbidLocation()
		{
		}

		// Token: 0x040136BC RID: 79548
		[Token(Token = "0x40136BC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040136BD RID: 79549
		[Token(Token = "0x40136BD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x040136BE RID: 79550
		[Token(Token = "0x40136BE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;

		// Token: 0x040136BF RID: 79551
		[Token(Token = "0x40136BF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
