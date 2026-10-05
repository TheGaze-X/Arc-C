using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1BossRush
{
	// Token: 0x020070B3 RID: 28851
	[Token(Token = "0x20070B3")]
	public class Act1BossRushMilestoneTrackPointModel : IHotfixable, ITrackPointModel
	{
		// Token: 0x17006139 RID: 24889
		// (get) Token: 0x06029036 RID: 167990 RVA: 0x000D4160 File Offset: 0x000D2360
		[Token(Token = "0x17006139")]
		public bool isShow
		{
			[Token(Token = "0x6029036")]
			[Address(RVA = "0x246AA80", Offset = "0x2469680", VA = "0x18246AA80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06029037 RID: 167991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029037")]
		[Address(RVA = "0x246A950", Offset = "0x2469550", VA = "0x18246A950", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06029038 RID: 167992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029038")]
		[Address(RVA = "0x246AA20", Offset = "0x2469620", VA = "0x18246AA20")]
		public Act1BossRushMilestoneTrackPointModel()
		{
		}

		// Token: 0x0403A8AB RID: 239787
		[Token(Token = "0x403A8AB")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0403A8AC RID: 239788
		[Token(Token = "0x403A8AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403A8AD RID: 239789
		[Token(Token = "0x403A8AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403A8AE RID: 239790
		[Token(Token = "0x403A8AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020070B4 RID: 28852
		[Token(Token = "0x20070B4")]
		public class Input
		{
			// Token: 0x06029039 RID: 167993 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029039")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403A8AF RID: 239791
			[Token(Token = "0x403A8AF")]
			[FieldOffset(Offset = "0x10")]
			public bool haveAbleToGetRewards;
		}
	}
}
