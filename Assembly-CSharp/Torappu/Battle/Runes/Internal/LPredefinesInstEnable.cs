using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028DB RID: 10459
	[Token(Token = "0x20028DB")]
	public class LPredefinesInstEnable : BasicLevelRune
	{
		// Token: 0x06011631 RID: 71217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011631")]
		[Address(RVA = "0x9422A0", Offset = "0x940EA0", VA = "0x1809422A0")]
		protected LPredefinesInstEnable()
		{
		}

		// Token: 0x1700266F RID: 9839
		// (get) Token: 0x06011632 RID: 71218 RVA: 0x0006AFE0 File Offset: 0x000691E0
		[Token(Token = "0x1700266F")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x6011632")]
			[Address(RVA = "0x942340", Offset = "0x940F40", VA = "0x180942340", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x06011633 RID: 71219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011633")]
		[Address(RVA = "0x942000", Offset = "0x940C00", VA = "0x180942000", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x06011634 RID: 71220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011634")]
		[Address(RVA = "0x942240", Offset = "0x940E40", VA = "0x180942240", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x040136EB RID: 79595
		[Token(Token = "0x40136EB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040136EC RID: 79596
		[Token(Token = "0x40136EC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040136ED RID: 79597
		[Token(Token = "0x40136ED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x040136EE RID: 79598
		[Token(Token = "0x40136EE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;
	}
}
