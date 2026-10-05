using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028D1 RID: 10449
	[Token(Token = "0x20028D1")]
	public class LLogInfo : BasicLevelRune
	{
		// Token: 0x17002663 RID: 9827
		// (get) Token: 0x06011604 RID: 71172 RVA: 0x0006AE78 File Offset: 0x00069078
		[Token(Token = "0x17002663")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x6011604")]
			[Address(RVA = "0x941410", Offset = "0x940010", VA = "0x180941410", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x06011605 RID: 71173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011605")]
		[Address(RVA = "0x9411E0", Offset = "0x93FDE0", VA = "0x1809411E0", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x06011606 RID: 71174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011606")]
		[Address(RVA = "0x941310", Offset = "0x93FF10", VA = "0x180941310", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x06011607 RID: 71175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011607")]
		[Address(RVA = "0x941370", Offset = "0x93FF70", VA = "0x180941370")]
		public LLogInfo()
		{
		}

		// Token: 0x040136C0 RID: 79552
		[Token(Token = "0x40136C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040136C1 RID: 79553
		[Token(Token = "0x40136C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x040136C2 RID: 79554
		[Token(Token = "0x40136C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;

		// Token: 0x040136C3 RID: 79555
		[Token(Token = "0x40136C3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
