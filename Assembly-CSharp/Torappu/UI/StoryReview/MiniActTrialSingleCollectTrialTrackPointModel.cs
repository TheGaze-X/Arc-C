using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048D2 RID: 18642
	[Token(Token = "0x20048D2")]
	public class MiniActTrialSingleCollectTrialTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x170042CF RID: 17103
		// (get) Token: 0x0601C1EA RID: 115178 RVA: 0x000A7538 File Offset: 0x000A5738
		[Token(Token = "0x170042CF")]
		public bool isShow
		{
			[Token(Token = "0x601C1EA")]
			[Address(RVA = "0x159CDB0", Offset = "0x159B9B0", VA = "0x18159CDB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601C1EB RID: 115179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1EB")]
		[Address(RVA = "0x159CC90", Offset = "0x159B890", VA = "0x18159CC90", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601C1EC RID: 115180 RVA: 0x000A7550 File Offset: 0x000A5750
		[Token(Token = "0x601C1EC")]
		[Address(RVA = "0x159C9A0", Offset = "0x159B5A0", VA = "0x18159C9A0")]
		public static bool GetShowFlag(string actId)
		{
			return default(bool);
		}

		// Token: 0x0601C1ED RID: 115181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1ED")]
		[Address(RVA = "0x159CD50", Offset = "0x159B950", VA = "0x18159CD50")]
		public MiniActTrialSingleCollectTrialTrackPointModel()
		{
		}

		// Token: 0x04024C3B RID: 150587
		[Token(Token = "0x4024C3B")]
		[FieldOffset(Offset = "0x10")]
		private bool m_showFlag;

		// Token: 0x04024C3C RID: 150588
		[Token(Token = "0x4024C3C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04024C3D RID: 150589
		[Token(Token = "0x4024C3D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04024C3E RID: 150590
		[Token(Token = "0x4024C3E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetShowFlag;

		// Token: 0x04024C3F RID: 150591
		[Token(Token = "0x4024C3F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
