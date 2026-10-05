using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028DD RID: 10461
	[Token(Token = "0x20028DD")]
	public class LLevelConfigBlackboardAdd : BasicLevelRune
	{
		// Token: 0x17002671 RID: 9841
		// (get) Token: 0x06011639 RID: 71225 RVA: 0x0006B010 File Offset: 0x00069210
		[Token(Token = "0x17002671")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x6011639")]
			[Address(RVA = "0x941180", Offset = "0x93FD80", VA = "0x180941180", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x0601163A RID: 71226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601163A")]
		[Address(RVA = "0x940E60", Offset = "0x93FA60", VA = "0x180940E60", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x0601163B RID: 71227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601163B")]
		[Address(RVA = "0x941080", Offset = "0x93FC80", VA = "0x180941080", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x0601163C RID: 71228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601163C")]
		[Address(RVA = "0x9410E0", Offset = "0x93FCE0", VA = "0x1809410E0")]
		public LLevelConfigBlackboardAdd()
		{
		}

		// Token: 0x040136F3 RID: 79603
		[Token(Token = "0x40136F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040136F4 RID: 79604
		[Token(Token = "0x40136F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x040136F5 RID: 79605
		[Token(Token = "0x40136F5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;

		// Token: 0x040136F6 RID: 79606
		[Token(Token = "0x40136F6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
