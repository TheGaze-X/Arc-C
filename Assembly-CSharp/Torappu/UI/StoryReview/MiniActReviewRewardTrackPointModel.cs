using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048CA RID: 18634
	[Token(Token = "0x20048CA")]
	public class MiniActReviewRewardTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x170042BA RID: 17082
		// (get) Token: 0x0601C1BE RID: 115134 RVA: 0x000A7340 File Offset: 0x000A5540
		[Token(Token = "0x170042BA")]
		public bool isShow
		{
			[Token(Token = "0x601C1BE")]
			[Address(RVA = "0x1596B80", Offset = "0x1595780", VA = "0x181596B80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601C1BF RID: 115135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1BF")]
		[Address(RVA = "0x1596580", Offset = "0x1595180", VA = "0x181596580", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601C1C0 RID: 115136 RVA: 0x000A7358 File Offset: 0x000A5558
		[Token(Token = "0x601C1C0")]
		[Address(RVA = "0x1596710", Offset = "0x1595310", VA = "0x181596710")]
		private bool _GetShowFlag()
		{
			return default(bool);
		}

		// Token: 0x0601C1C1 RID: 115137 RVA: 0x000A7370 File Offset: 0x000A5570
		[Token(Token = "0x601C1C1")]
		[Address(RVA = "0x1596600", Offset = "0x1595200", VA = "0x181596600")]
		private bool _CheckStoryAvailable(StoryReviewGroupClientData db)
		{
			return default(bool);
		}

		// Token: 0x0601C1C2 RID: 115138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1C2")]
		[Address(RVA = "0x1596B20", Offset = "0x1595720", VA = "0x181596B20")]
		public MiniActReviewRewardTrackPointModel()
		{
		}

		// Token: 0x04024BFA RID: 150522
		[Token(Token = "0x4024BFA")]
		[FieldOffset(Offset = "0x10")]
		private bool m_showFlag;

		// Token: 0x04024BFB RID: 150523
		[Token(Token = "0x4024BFB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04024BFC RID: 150524
		[Token(Token = "0x4024BFC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04024BFD RID: 150525
		[Token(Token = "0x4024BFD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetShowFlag;

		// Token: 0x04024BFE RID: 150526
		[Token(Token = "0x4024BFE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckStoryAvailable;

		// Token: 0x04024BFF RID: 150527
		[Token(Token = "0x4024BFF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
