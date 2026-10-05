using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028D8 RID: 10456
	[Token(Token = "0x20028D8")]
	public class LGlobalBuffAddWithHigherPriority : BasicLevelRune
	{
		// Token: 0x06011623 RID: 71203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011623")]
		[Address(RVA = "0x93E460", Offset = "0x93D060", VA = "0x18093E460")]
		protected LGlobalBuffAddWithHigherPriority()
		{
		}

		// Token: 0x1700266B RID: 9835
		// (get) Token: 0x06011624 RID: 71204 RVA: 0x0006AF68 File Offset: 0x00069168
		[Token(Token = "0x1700266B")]
		public override int priorityQueue
		{
			[Token(Token = "0x6011624")]
			[Address(RVA = "0x93E500", Offset = "0x93D100", VA = "0x18093E500", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700266C RID: 9836
		// (get) Token: 0x06011625 RID: 71205 RVA: 0x0006AF80 File Offset: 0x00069180
		[Token(Token = "0x1700266C")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x6011625")]
			[Address(RVA = "0x93E560", Offset = "0x93D160", VA = "0x18093E560", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x06011626 RID: 71206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011626")]
		[Address(RVA = "0x93E290", Offset = "0x93CE90", VA = "0x18093E290", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x06011627 RID: 71207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011627")]
		[Address(RVA = "0x93E400", Offset = "0x93D000", VA = "0x18093E400", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x06011628 RID: 71208 RVA: 0x0006AF98 File Offset: 0x00069198
		[Token(Token = "0x6011628")]
		[Address(RVA = "0x937E80", Offset = "0x936A80", VA = "0x180937E80")]
		private int <>xLuaBaseProxy_get_priorityQueue()
		{
			return 0;
		}

		// Token: 0x040136DE RID: 79582
		[Token(Token = "0x40136DE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040136DF RID: 79583
		[Token(Token = "0x40136DF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_priorityQueue;

		// Token: 0x040136E0 RID: 79584
		[Token(Token = "0x40136E0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040136E1 RID: 79585
		[Token(Token = "0x40136E1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x040136E2 RID: 79586
		[Token(Token = "0x40136E2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;
	}
}
