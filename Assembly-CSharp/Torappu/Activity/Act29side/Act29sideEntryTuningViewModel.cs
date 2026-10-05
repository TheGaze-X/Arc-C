using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.Activity.Act29side
{
	// Token: 0x020074AE RID: 29870
	[Token(Token = "0x20074AE")]
	public class Act29sideEntryTuningViewModel : TemplateActivityViewModel, IHotfixable
	{
		// Token: 0x0602A207 RID: 172551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A207")]
		[Address(RVA = "0x25AEA50", Offset = "0x25AD650", VA = "0x1825AEA50")]
		public Act29sideEntryTuningViewModel(object param)
		{
		}

		// Token: 0x0602A208 RID: 172552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A208")]
		[Address(RVA = "0x25AE8E0", Offset = "0x25AD4E0", VA = "0x1825AE8E0")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x0403C7F5 RID: 247797
		[Token(Token = "0x403C7F5")]
		[FieldOffset(Offset = "0x20")]
		private DateTime m_actEndTs;

		// Token: 0x0403C7F6 RID: 247798
		[Token(Token = "0x403C7F6")]
		[FieldOffset(Offset = "0x28")]
		private DateTime m_actRewardEndTs;

		// Token: 0x0403C7F7 RID: 247799
		[Token(Token = "0x403C7F7")]
		[FieldOffset(Offset = "0x30")]
		public Act29sideEntryTuningViewModel.Status currStatus;

		// Token: 0x0403C7F8 RID: 247800
		[Token(Token = "0x403C7F8")]
		[FieldOffset(Offset = "0x38")]
		public string lockedToastDesc;

		// Token: 0x0403C7F9 RID: 247801
		[Token(Token = "0x403C7F9")]
		[FieldOffset(Offset = "0x40")]
		public string lockedDesc;

		// Token: 0x0403C7FA RID: 247802
		[Token(Token = "0x403C7FA")]
		[FieldOffset(Offset = "0x48")]
		public string crossDayTrackId;

		// Token: 0x0403C7FB RID: 247803
		[Token(Token = "0x403C7FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403C7FC RID: 247804
		[Token(Token = "0x403C7FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x020074AF RID: 29871
		[Token(Token = "0x20074AF")]
		public class Input
		{
			// Token: 0x0602A209 RID: 172553 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A209")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403C7FD RID: 247805
			[Token(Token = "0x403C7FD")]
			[FieldOffset(Offset = "0x10")]
			public Act29SideData gameData;

			// Token: 0x0403C7FE RID: 247806
			[Token(Token = "0x403C7FE")]
			[FieldOffset(Offset = "0x18")]
			public ActivityBasicInfo actBasicInfo;
		}

		// Token: 0x020074B0 RID: 29872
		[Token(Token = "0x20074B0")]
		public enum Status
		{
			// Token: 0x0403C800 RID: 247808
			[Token(Token = "0x403C800")]
			LOCKED,
			// Token: 0x0403C801 RID: 247809
			[Token(Token = "0x403C801")]
			UNLOCK,
			// Token: 0x0403C802 RID: 247810
			[Token(Token = "0x403C802")]
			TIME_OUT
		}
	}
}
