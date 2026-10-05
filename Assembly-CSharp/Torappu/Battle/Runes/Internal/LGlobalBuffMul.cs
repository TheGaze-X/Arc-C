using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028D6 RID: 10454
	[Token(Token = "0x20028D6")]
	public class LGlobalBuffMul : BasicLevelRune
	{
		// Token: 0x06011619 RID: 71193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011619")]
		[Address(RVA = "0x93EA60", Offset = "0x93D660", VA = "0x18093EA60")]
		protected LGlobalBuffMul()
		{
		}

		// Token: 0x17002668 RID: 9832
		// (get) Token: 0x0601161A RID: 71194 RVA: 0x0006AF08 File Offset: 0x00069108
		[Token(Token = "0x17002668")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x601161A")]
			[Address(RVA = "0x93EB60", Offset = "0x93D760", VA = "0x18093EB60", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x17002669 RID: 9833
		// (get) Token: 0x0601161B RID: 71195 RVA: 0x0006AF20 File Offset: 0x00069120
		[Token(Token = "0x17002669")]
		public override int priorityQueue
		{
			[Token(Token = "0x601161B")]
			[Address(RVA = "0x93EB00", Offset = "0x93D700", VA = "0x18093EB00", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601161C RID: 71196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601161C")]
		[Address(RVA = "0x93E890", Offset = "0x93D490", VA = "0x18093E890", Slot = "8")]
		public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x0601161D RID: 71197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601161D")]
		[Address(RVA = "0x93EA00", Offset = "0x93D600", VA = "0x18093EA00", Slot = "7")]
		public override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x0601161E RID: 71198 RVA: 0x0006AF38 File Offset: 0x00069138
		[Token(Token = "0x601161E")]
		[Address(RVA = "0x937E80", Offset = "0x936A80", VA = "0x180937E80")]
		private int <>xLuaBaseProxy_get_priorityQueue()
		{
			return 0;
		}

		// Token: 0x040136D5 RID: 79573
		[Token(Token = "0x40136D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040136D6 RID: 79574
		[Token(Token = "0x40136D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040136D7 RID: 79575
		[Token(Token = "0x40136D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_priorityQueue;

		// Token: 0x040136D8 RID: 79576
		[Token(Token = "0x40136D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x040136D9 RID: 79577
		[Token(Token = "0x40136D9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;
	}
}
