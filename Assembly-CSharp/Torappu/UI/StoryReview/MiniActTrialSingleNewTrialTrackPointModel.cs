using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048D3 RID: 18643
	[Token(Token = "0x20048D3")]
	public class MiniActTrialSingleNewTrialTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x170042D0 RID: 17104
		// (get) Token: 0x0601C1EE RID: 115182 RVA: 0x000A7568 File Offset: 0x000A5768
		[Token(Token = "0x170042D0")]
		public bool isShow
		{
			[Token(Token = "0x601C1EE")]
			[Address(RVA = "0x159D1B0", Offset = "0x159BDB0", VA = "0x18159D1B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601C1EF RID: 115183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1EF")]
		[Address(RVA = "0x159D0A0", Offset = "0x159BCA0", VA = "0x18159D0A0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601C1F0 RID: 115184 RVA: 0x000A7580 File Offset: 0x000A5780
		[Token(Token = "0x601C1F0")]
		[Address(RVA = "0x159CE10", Offset = "0x159BA10", VA = "0x18159CE10")]
		public static bool GetShowFlag(string actId)
		{
			return default(bool);
		}

		// Token: 0x0601C1F1 RID: 115185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1F1")]
		[Address(RVA = "0x159D150", Offset = "0x159BD50", VA = "0x18159D150")]
		public MiniActTrialSingleNewTrialTrackPointModel()
		{
		}

		// Token: 0x04024C40 RID: 150592
		[Token(Token = "0x4024C40")]
		[FieldOffset(Offset = "0x10")]
		private bool m_showFlag;

		// Token: 0x04024C41 RID: 150593
		[Token(Token = "0x4024C41")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04024C42 RID: 150594
		[Token(Token = "0x4024C42")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04024C43 RID: 150595
		[Token(Token = "0x4024C43")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetShowFlag;

		// Token: 0x04024C44 RID: 150596
		[Token(Token = "0x4024C44")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
