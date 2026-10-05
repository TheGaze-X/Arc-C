using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x0200758E RID: 30094
	[Token(Token = "0x200758E")]
	public class Act24sideEntryHuntWikiTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x170063B2 RID: 25522
		// (get) Token: 0x0602A5D1 RID: 173521 RVA: 0x000D82A0 File Offset: 0x000D64A0
		[Token(Token = "0x170063B2")]
		public bool isShow
		{
			[Token(Token = "0x602A5D1")]
			[Address(RVA = "0x2600C40", Offset = "0x25FF840", VA = "0x182600C40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602A5D2 RID: 173522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5D2")]
		[Address(RVA = "0x2600B00", Offset = "0x25FF700", VA = "0x182600B00", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0602A5D3 RID: 173523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5D3")]
		[Address(RVA = "0x2600BE0", Offset = "0x25FF7E0", VA = "0x182600BE0")]
		public Act24sideEntryHuntWikiTrackPoint()
		{
		}

		// Token: 0x0403CF13 RID: 249619
		[Token(Token = "0x403CF13")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0403CF14 RID: 249620
		[Token(Token = "0x403CF14")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403CF15 RID: 249621
		[Token(Token = "0x403CF15")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403CF16 RID: 249622
		[Token(Token = "0x403CF16")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200758F RID: 30095
		[Token(Token = "0x200758F")]
		public class Param
		{
			// Token: 0x0602A5D4 RID: 173524 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A5D4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0403CF17 RID: 249623
			[Token(Token = "0x403CF17")]
			[FieldOffset(Offset = "0x10")]
			public bool isHaveReward;
		}
	}
}
