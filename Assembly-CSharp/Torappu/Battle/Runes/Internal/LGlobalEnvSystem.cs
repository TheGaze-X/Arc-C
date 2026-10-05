using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028D2 RID: 10450
	[Token(Token = "0x20028D2")]
	public class LGlobalEnvSystem : BasicLevelRune
	{
		// Token: 0x17002664 RID: 9828
		// (get) Token: 0x06011608 RID: 71176 RVA: 0x0006AE90 File Offset: 0x00069090
		[Token(Token = "0x17002664")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x6011608")]
			[Address(RVA = "0x93F880", Offset = "0x93E480", VA = "0x18093F880", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x06011609 RID: 71177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011609")]
		[Address(RVA = "0x93F5F0", Offset = "0x93E1F0", VA = "0x18093F5F0", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x0601160A RID: 71178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601160A")]
		[Address(RVA = "0x93F780", Offset = "0x93E380", VA = "0x18093F780", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x0601160B RID: 71179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601160B")]
		[Address(RVA = "0x93F7E0", Offset = "0x93E3E0", VA = "0x18093F7E0")]
		public LGlobalEnvSystem()
		{
		}

		// Token: 0x040136C4 RID: 79556
		[Token(Token = "0x40136C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040136C5 RID: 79557
		[Token(Token = "0x40136C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x040136C6 RID: 79558
		[Token(Token = "0x40136C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;

		// Token: 0x040136C7 RID: 79559
		[Token(Token = "0x40136C7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
