using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048D1 RID: 18641
	[Token(Token = "0x20048D1")]
	public class MiniActTrialNewTrialTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x170042CE RID: 17102
		// (get) Token: 0x0601C1E5 RID: 115173 RVA: 0x000A7508 File Offset: 0x000A5708
		[Token(Token = "0x170042CE")]
		public bool isShow
		{
			[Token(Token = "0x601C1E5")]
			[Address(RVA = "0x159B2E0", Offset = "0x1599EE0", VA = "0x18159B2E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601C1E6 RID: 115174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1E6")]
		[Address(RVA = "0x159B210", Offset = "0x1599E10", VA = "0x18159B210", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601C1E7 RID: 115175 RVA: 0x000A7520 File Offset: 0x000A5720
		[Token(Token = "0x601C1E7")]
		[Address(RVA = "0x159ADB0", Offset = "0x15999B0", VA = "0x18159ADB0")]
		public static bool GetShowFlag()
		{
			return default(bool);
		}

		// Token: 0x0601C1E8 RID: 115176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1E8")]
		[Address(RVA = "0x159AF60", Offset = "0x1599B60", VA = "0x18159AF60")]
		public static void SetAvailableTrialVisited()
		{
		}

		// Token: 0x0601C1E9 RID: 115177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1E9")]
		[Address(RVA = "0x159B280", Offset = "0x1599E80", VA = "0x18159B280")]
		public MiniActTrialNewTrialTrackPointModel()
		{
		}

		// Token: 0x04024C35 RID: 150581
		[Token(Token = "0x4024C35")]
		[FieldOffset(Offset = "0x10")]
		private bool m_showFlag;

		// Token: 0x04024C36 RID: 150582
		[Token(Token = "0x4024C36")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04024C37 RID: 150583
		[Token(Token = "0x4024C37")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04024C38 RID: 150584
		[Token(Token = "0x4024C38")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetShowFlag;

		// Token: 0x04024C39 RID: 150585
		[Token(Token = "0x4024C39")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetAvailableTrialVisited;

		// Token: 0x04024C3A RID: 150586
		[Token(Token = "0x4024C3A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
