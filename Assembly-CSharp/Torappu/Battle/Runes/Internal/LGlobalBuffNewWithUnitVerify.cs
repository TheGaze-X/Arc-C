using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028D5 RID: 10453
	[Token(Token = "0x20028D5")]
	public class LGlobalBuffNewWithUnitVerify : BasicLevelRune
	{
		// Token: 0x06011614 RID: 71188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011614")]
		[Address(RVA = "0x93F130", Offset = "0x93DD30", VA = "0x18093F130")]
		protected LGlobalBuffNewWithUnitVerify()
		{
		}

		// Token: 0x17002667 RID: 9831
		// (get) Token: 0x06011615 RID: 71189 RVA: 0x0006AED8 File Offset: 0x000690D8
		[Token(Token = "0x17002667")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x6011615")]
			[Address(RVA = "0x93F1D0", Offset = "0x93DDD0", VA = "0x18093F1D0", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x06011616 RID: 71190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011616")]
		[Address(RVA = "0x93EBC0", Offset = "0x93D7C0", VA = "0x18093EBC0", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x06011617 RID: 71191 RVA: 0x0006AEF0 File Offset: 0x000690F0
		[Token(Token = "0x6011617")]
		[Address(RVA = "0x93EF00", Offset = "0x93DB00", VA = "0x18093EF00")]
		public bool UnitVerify(Unit unit, Blackboard blackboard)
		{
			return default(bool);
		}

		// Token: 0x06011618 RID: 71192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011618")]
		[Address(RVA = "0x93EEA0", Offset = "0x93DAA0", VA = "0x18093EEA0", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x040136D0 RID: 79568
		[Token(Token = "0x40136D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040136D1 RID: 79569
		[Token(Token = "0x40136D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040136D2 RID: 79570
		[Token(Token = "0x40136D2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x040136D3 RID: 79571
		[Token(Token = "0x40136D3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UnitVerify;

		// Token: 0x040136D4 RID: 79572
		[Token(Token = "0x40136D4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;
	}
}
