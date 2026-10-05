using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048CB RID: 18635
	[Token(Token = "0x20048CB")]
	public class MiniActTrialCollectTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x170042BB RID: 17083
		// (get) Token: 0x0601C1C3 RID: 115139 RVA: 0x000A7388 File Offset: 0x000A5588
		[Token(Token = "0x170042BB")]
		public bool isShow
		{
			[Token(Token = "0x601C1C3")]
			[Address(RVA = "0x1597760", Offset = "0x1596360", VA = "0x181597760", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601C1C4 RID: 115140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1C4")]
		[Address(RVA = "0x1597630", Offset = "0x1596230", VA = "0x181597630", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601C1C5 RID: 115141 RVA: 0x000A73A0 File Offset: 0x000A55A0
		[Token(Token = "0x601C1C5")]
		[Address(RVA = "0x1597480", Offset = "0x1596080", VA = "0x181597480")]
		public static bool GetShowFlag()
		{
			return default(bool);
		}

		// Token: 0x0601C1C6 RID: 115142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1C6")]
		[Address(RVA = "0x1597700", Offset = "0x1596300", VA = "0x181597700")]
		public MiniActTrialCollectTrackPointModel()
		{
		}

		// Token: 0x04024C00 RID: 150528
		[Token(Token = "0x4024C00")]
		[FieldOffset(Offset = "0x10")]
		private bool m_showFlag;

		// Token: 0x04024C01 RID: 150529
		[Token(Token = "0x4024C01")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04024C02 RID: 150530
		[Token(Token = "0x4024C02")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04024C03 RID: 150531
		[Token(Token = "0x4024C03")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetShowFlag;

		// Token: 0x04024C04 RID: 150532
		[Token(Token = "0x4024C04")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
