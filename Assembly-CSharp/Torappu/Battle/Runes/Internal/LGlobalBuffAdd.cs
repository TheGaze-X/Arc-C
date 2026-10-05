using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028D7 RID: 10455
	[Token(Token = "0x20028D7")]
	public class LGlobalBuffAdd : BasicLevelRune
	{
		// Token: 0x0601161F RID: 71199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601161F")]
		[Address(RVA = "0x93E790", Offset = "0x93D390", VA = "0x18093E790")]
		protected LGlobalBuffAdd()
		{
		}

		// Token: 0x1700266A RID: 9834
		// (get) Token: 0x06011620 RID: 71200 RVA: 0x0006AF50 File Offset: 0x00069150
		[Token(Token = "0x1700266A")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x6011620")]
			[Address(RVA = "0x93E830", Offset = "0x93D430", VA = "0x18093E830", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x06011621 RID: 71201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011621")]
		[Address(RVA = "0x93E5C0", Offset = "0x93D1C0", VA = "0x18093E5C0", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x06011622 RID: 71202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011622")]
		[Address(RVA = "0x93E730", Offset = "0x93D330", VA = "0x18093E730", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x040136DA RID: 79578
		[Token(Token = "0x40136DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040136DB RID: 79579
		[Token(Token = "0x40136DB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040136DC RID: 79580
		[Token(Token = "0x40136DC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x040136DD RID: 79581
		[Token(Token = "0x40136DD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;
	}
}
