using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028DC RID: 10460
	[Token(Token = "0x20028DC")]
	public class LGlobalBlackboardAssign : BasicLevelRune
	{
		// Token: 0x17002670 RID: 9840
		// (get) Token: 0x06011635 RID: 71221 RVA: 0x0006AFF8 File Offset: 0x000691F8
		[Token(Token = "0x17002670")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x6011635")]
			[Address(RVA = "0x93E230", Offset = "0x93CE30", VA = "0x18093E230", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x06011636 RID: 71222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011636")]
		[Address(RVA = "0x93DF10", Offset = "0x93CB10", VA = "0x18093DF10", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x06011637 RID: 71223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011637")]
		[Address(RVA = "0x93E130", Offset = "0x93CD30", VA = "0x18093E130", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x06011638 RID: 71224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011638")]
		[Address(RVA = "0x93E190", Offset = "0x93CD90", VA = "0x18093E190")]
		public LGlobalBlackboardAssign()
		{
		}

		// Token: 0x040136EF RID: 79599
		[Token(Token = "0x40136EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040136F0 RID: 79600
		[Token(Token = "0x40136F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x040136F1 RID: 79601
		[Token(Token = "0x40136F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;

		// Token: 0x040136F2 RID: 79602
		[Token(Token = "0x40136F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
