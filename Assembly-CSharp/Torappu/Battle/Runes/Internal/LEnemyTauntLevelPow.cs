using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028CF RID: 10447
	[Token(Token = "0x20028CF")]
	public class LEnemyTauntLevelPow : BasicLevelRune
	{
		// Token: 0x060115FC RID: 71164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115FC")]
		[Address(RVA = "0x93DBA0", Offset = "0x93C7A0", VA = "0x18093DBA0")]
		protected LEnemyTauntLevelPow()
		{
		}

		// Token: 0x17002661 RID: 9825
		// (get) Token: 0x060115FD RID: 71165 RVA: 0x0006AE48 File Offset: 0x00069048
		[Token(Token = "0x17002661")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x60115FD")]
			[Address(RVA = "0x93DC40", Offset = "0x93C840", VA = "0x18093DC40", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x060115FE RID: 71166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115FE")]
		[Address(RVA = "0x93DAE0", Offset = "0x93C6E0", VA = "0x18093DAE0", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x060115FF RID: 71167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115FF")]
		[Address(RVA = "0x93DA50", Offset = "0x93C650", VA = "0x18093DA50", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x040136B8 RID: 79544
		[Token(Token = "0x40136B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040136B9 RID: 79545
		[Token(Token = "0x40136B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040136BA RID: 79546
		[Token(Token = "0x40136BA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;

		// Token: 0x040136BB RID: 79547
		[Token(Token = "0x40136BB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;
	}
}
