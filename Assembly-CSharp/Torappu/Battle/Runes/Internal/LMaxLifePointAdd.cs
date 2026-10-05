using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028CD RID: 10445
	[Token(Token = "0x20028CD")]
	public class LMaxLifePointAdd : BasicLevelRune
	{
		// Token: 0x060115F4 RID: 71156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115F4")]
		[Address(RVA = "0x9418F0", Offset = "0x9404F0", VA = "0x1809418F0")]
		protected LMaxLifePointAdd()
		{
		}

		// Token: 0x1700265F RID: 9823
		// (get) Token: 0x060115F5 RID: 71157 RVA: 0x0006AE18 File Offset: 0x00069018
		[Token(Token = "0x1700265F")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x60115F5")]
			[Address(RVA = "0x941990", Offset = "0x940590", VA = "0x180941990", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x060115F6 RID: 71158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115F6")]
		[Address(RVA = "0x941830", Offset = "0x940430", VA = "0x180941830", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x060115F7 RID: 71159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115F7")]
		[Address(RVA = "0x9417A0", Offset = "0x9403A0", VA = "0x1809417A0", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x040136B0 RID: 79536
		[Token(Token = "0x40136B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040136B1 RID: 79537
		[Token(Token = "0x40136B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040136B2 RID: 79538
		[Token(Token = "0x40136B2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;

		// Token: 0x040136B3 RID: 79539
		[Token(Token = "0x40136B3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;
	}
}
