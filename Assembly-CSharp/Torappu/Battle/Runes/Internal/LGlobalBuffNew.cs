using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028D4 RID: 10452
	[Token(Token = "0x20028D4")]
	public class LGlobalBuffNew : BasicLevelRune
	{
		// Token: 0x06011610 RID: 71184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011610")]
		[Address(RVA = "0x93F4F0", Offset = "0x93E0F0", VA = "0x18093F4F0")]
		protected LGlobalBuffNew()
		{
		}

		// Token: 0x17002666 RID: 9830
		// (get) Token: 0x06011611 RID: 71185 RVA: 0x0006AEC0 File Offset: 0x000690C0
		[Token(Token = "0x17002666")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x6011611")]
			[Address(RVA = "0x93F590", Offset = "0x93E190", VA = "0x18093F590", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x06011612 RID: 71186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011612")]
		[Address(RVA = "0x93F230", Offset = "0x93DE30", VA = "0x18093F230", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x06011613 RID: 71187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011613")]
		[Address(RVA = "0x93F490", Offset = "0x93E090", VA = "0x18093F490", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x040136CC RID: 79564
		[Token(Token = "0x40136CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040136CD RID: 79565
		[Token(Token = "0x40136CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040136CE RID: 79566
		[Token(Token = "0x40136CE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x040136CF RID: 79567
		[Token(Token = "0x40136CF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;
	}
}
