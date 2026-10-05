using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028CE RID: 10446
	[Token(Token = "0x20028CE")]
	public class LCharacterLimitAdd : BasicLevelRune
	{
		// Token: 0x060115F8 RID: 71160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115F8")]
		[Address(RVA = "0x93CF70", Offset = "0x93BB70", VA = "0x18093CF70")]
		protected LCharacterLimitAdd()
		{
		}

		// Token: 0x17002660 RID: 9824
		// (get) Token: 0x060115F9 RID: 71161 RVA: 0x0006AE30 File Offset: 0x00069030
		[Token(Token = "0x17002660")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x60115F9")]
			[Address(RVA = "0x93D010", Offset = "0x93BC10", VA = "0x18093D010", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x060115FA RID: 71162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115FA")]
		[Address(RVA = "0x93CEB0", Offset = "0x93BAB0", VA = "0x18093CEB0", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x060115FB RID: 71163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115FB")]
		[Address(RVA = "0x93CE20", Offset = "0x93BA20", VA = "0x18093CE20", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x040136B4 RID: 79540
		[Token(Token = "0x40136B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040136B5 RID: 79541
		[Token(Token = "0x40136B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040136B6 RID: 79542
		[Token(Token = "0x40136B6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;

		// Token: 0x040136B7 RID: 79543
		[Token(Token = "0x40136B7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;
	}
}
