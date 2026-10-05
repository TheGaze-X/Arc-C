using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000523 RID: 1315
	[Token(Token = "0x2000523")]
	public abstract class MilestoneSnapshot : IHotfixable
	{
		// Token: 0x06004F6E RID: 20334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F6E")]
		[Address(RVA = "0x1AF5EB0", Offset = "0x1AF4AB0", VA = "0x181AF5EB0")]
		public void Load(int curPoint, int curAdd)
		{
		}

		// Token: 0x06004F6F RID: 20335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F6F")]
		[Address(RVA = "0x1AF6110", Offset = "0x1AF4D10", VA = "0x181AF6110")]
		private MilestoneSnapshot.IMilestoneItem _GetMilestoneItem(int point)
		{
			return null;
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06004F70 RID: 20336
		[Token(Token = "0x1700024A")]
		protected abstract int milestoneCount { [Token(Token = "0x6004F70")] get; }

		// Token: 0x06004F71 RID: 20337
		[Token(Token = "0x6004F71")]
		protected abstract MilestoneSnapshot.IMilestoneItem _GetMilestoneItemAt(int idx);

		// Token: 0x06004F72 RID: 20338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F72")]
		[Address(RVA = "0x1AF6230", Offset = "0x1AF4E30", VA = "0x181AF6230")]
		protected MilestoneSnapshot()
		{
		}

		// Token: 0x040013F6 RID: 5110
		[Token(Token = "0x40013F6")]
		[FieldOffset(Offset = "0x10")]
		public int addPoint;

		// Token: 0x040013F7 RID: 5111
		[Token(Token = "0x40013F7")]
		[FieldOffset(Offset = "0x14")]
		public bool levelUp;

		// Token: 0x040013F8 RID: 5112
		[Token(Token = "0x40013F8")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		// Token: 0x040013F9 RID: 5113
		[Token(Token = "0x40013F9")]
		[FieldOffset(Offset = "0x1C")]
		public bool levelMax;

		// Token: 0x040013FA RID: 5114
		[Token(Token = "0x40013FA")]
		[FieldOffset(Offset = "0x20")]
		public float prg;

		// Token: 0x040013FB RID: 5115
		[Token(Token = "0x40013FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x040013FC RID: 5116
		[Token(Token = "0x40013FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetMilestoneItem;

		// Token: 0x040013FD RID: 5117
		[Token(Token = "0x40013FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02000524 RID: 1316
		[Token(Token = "0x2000524")]
		public interface IMilestoneItem
		{
			// Token: 0x1700024B RID: 587
			// (get) Token: 0x06004F73 RID: 20339
			[Token(Token = "0x1700024B")]
			int level { [Token(Token = "0x6004F73")] get; }

			// Token: 0x1700024C RID: 588
			// (get) Token: 0x06004F74 RID: 20340
			[Token(Token = "0x1700024C")]
			int point { [Token(Token = "0x6004F74")] get; }
		}
	}
}
