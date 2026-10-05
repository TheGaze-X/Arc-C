using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1BossRush
{
	// Token: 0x020070C6 RID: 28870
	[Token(Token = "0x20070C6")]
	public class Act1BossRushMileStoneItemViewModel : IHotfixable
	{
		// Token: 0x06029079 RID: 168057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029079")]
		[Address(RVA = "0x2467950", Offset = "0x2466550", VA = "0x182467950")]
		public Act1BossRushMileStoneItemViewModel()
		{
		}

		// Token: 0x0403A910 RID: 239888
		[Token(Token = "0x403A910")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0403A911 RID: 239889
		[Token(Token = "0x403A911")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		// Token: 0x0403A912 RID: 239890
		[Token(Token = "0x403A912")]
		[FieldOffset(Offset = "0x1C")]
		public int needPointCnt;

		// Token: 0x0403A913 RID: 239891
		[Token(Token = "0x403A913")]
		[FieldOffset(Offset = "0x20")]
		public ItemBundle reward;

		// Token: 0x0403A914 RID: 239892
		[Token(Token = "0x403A914")]
		[FieldOffset(Offset = "0x28")]
		public Act1BossRushMileStoneItemViewModel.State state;

		// Token: 0x0403A915 RID: 239893
		[Token(Token = "0x403A915")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020070C7 RID: 28871
		[Token(Token = "0x20070C7")]
		public enum State
		{
			// Token: 0x0403A917 RID: 239895
			[Token(Token = "0x403A917")]
			NOTAVAIL,
			// Token: 0x0403A918 RID: 239896
			[Token(Token = "0x403A918")]
			AVAIL,
			// Token: 0x0403A919 RID: 239897
			[Token(Token = "0x403A919")]
			FINISH
		}
	}
}
