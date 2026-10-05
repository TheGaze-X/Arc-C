using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003DB4 RID: 15796
	[Token(Token = "0x2003DB4")]
	public class TemplateMissionViewModelBasePlugin : ITemplateMissionViewModelPlugin, IHotfixable
	{
		// Token: 0x060188F3 RID: 100595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188F3")]
		[Address(RVA = "0x1117820", Offset = "0x1116420", VA = "0x181117820", Slot = "4")]
		public void SetContext(TemplateMissionViewModel viewModel)
		{
		}

		// Token: 0x060188F4 RID: 100596 RVA: 0x0009ABF0 File Offset: 0x00098DF0
		[Token(Token = "0x60188F4")]
		[Address(RVA = "0x11177C0", Offset = "0x11163C0", VA = "0x1811177C0", Slot = "5")]
		public int GetShowClaimAllBtnNeedCount()
		{
			return 0;
		}

		// Token: 0x060188F5 RID: 100597 RVA: 0x0009AC08 File Offset: 0x00098E08
		[Token(Token = "0x60188F5")]
		[Address(RVA = "0x1117460", Offset = "0x1116060", VA = "0x181117460", Slot = "6")]
		public bool CheckMissionShowAbleFlag(ITemplateMissionListItemViewModel item)
		{
			return default(bool);
		}

		// Token: 0x060188F6 RID: 100598 RVA: 0x0009AC20 File Offset: 0x00098E20
		[Token(Token = "0x60188F6")]
		[Address(RVA = "0x11174D0", Offset = "0x11160D0", VA = "0x1811174D0", Slot = "7")]
		public bool Compare(ITemplateMissionListItemViewModel a, ITemplateMissionListItemViewModel b, out int result)
		{
			return default(bool);
		}

		// Token: 0x060188F7 RID: 100599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188F7")]
		[Address(RVA = "0x11178A0", Offset = "0x11164A0", VA = "0x1811178A0")]
		public TemplateMissionViewModelBasePlugin()
		{
		}

		// Token: 0x0401E1C9 RID: 123337
		[Token(Token = "0x401E1C9")]
		private const int SHOW_CLAIM_ALL_BTN_MISSION_ITEM_NEED_COUNT = 1;

		// Token: 0x0401E1CA RID: 123338
		[Token(Token = "0x401E1CA")]
		[FieldOffset(Offset = "0x10")]
		protected TemplateMissionViewModel m_context;

		// Token: 0x0401E1CB RID: 123339
		[Token(Token = "0x401E1CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetContext;

		// Token: 0x0401E1CC RID: 123340
		[Token(Token = "0x401E1CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetShowClaimAllBtnNeedCount;

		// Token: 0x0401E1CD RID: 123341
		[Token(Token = "0x401E1CD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckMissionShowAbleFlag;

		// Token: 0x0401E1CE RID: 123342
		[Token(Token = "0x401E1CE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Compare;

		// Token: 0x0401E1CF RID: 123343
		[Token(Token = "0x401E1CF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
