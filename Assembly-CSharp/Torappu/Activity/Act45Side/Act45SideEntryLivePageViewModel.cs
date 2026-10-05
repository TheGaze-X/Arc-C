using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act45Side
{
	// Token: 0x020072B9 RID: 29369
	[Token(Token = "0x20072B9")]
	public class Act45SideEntryLivePageViewModel : TemplateActivityViewModel, IHotfixable
	{
		// Token: 0x06029921 RID: 170273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029921")]
		[Address(RVA = "0x24F37F0", Offset = "0x24F23F0", VA = "0x1824F37F0")]
		public Act45SideEntryLivePageViewModel(object param)
		{
		}

		// Token: 0x06029922 RID: 170274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029922")]
		[Address(RVA = "0x24F3450", Offset = "0x24F2050", VA = "0x1824F3450")]
		public void RefreshData()
		{
		}

		// Token: 0x0403B714 RID: 243476
		[Token(Token = "0x403B714")]
		[FieldOffset(Offset = "0x20")]
		public string actId;

		// Token: 0x0403B715 RID: 243477
		[Token(Token = "0x403B715")]
		[FieldOffset(Offset = "0x28")]
		public Act45SideEntryLivePageViewModel.Status status;

		// Token: 0x0403B716 RID: 243478
		[Token(Token = "0x403B716")]
		[FieldOffset(Offset = "0x30")]
		public string lockToast;

		// Token: 0x0403B717 RID: 243479
		[Token(Token = "0x403B717")]
		[FieldOffset(Offset = "0x38")]
		public bool hasNewChar;

		// Token: 0x0403B718 RID: 243480
		[Token(Token = "0x403B718")]
		[FieldOffset(Offset = "0x39")]
		public bool hasNewMail;

		// Token: 0x0403B719 RID: 243481
		[Token(Token = "0x403B719")]
		[FieldOffset(Offset = "0x3A")]
		public bool gotAllMail;

		// Token: 0x0403B71A RID: 243482
		[Token(Token = "0x403B71A")]
		[FieldOffset(Offset = "0x40")]
		public string mailTime;

		// Token: 0x0403B71B RID: 243483
		[Token(Token = "0x403B71B")]
		[FieldOffset(Offset = "0x48")]
		private long m_nextMailTime;

		// Token: 0x0403B71C RID: 243484
		[Token(Token = "0x403B71C")]
		[FieldOffset(Offset = "0x50")]
		private string m_mailTimeFormat;

		// Token: 0x0403B71D RID: 243485
		[Token(Token = "0x403B71D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403B71E RID: 243486
		[Token(Token = "0x403B71E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x020072BA RID: 29370
		[Token(Token = "0x20072BA")]
		public class Input
		{
			// Token: 0x06029923 RID: 170275 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029923")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403B71F RID: 243487
			[Token(Token = "0x403B71F")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}

		// Token: 0x020072BB RID: 29371
		[Token(Token = "0x20072BB")]
		public enum Status
		{
			// Token: 0x0403B721 RID: 243489
			[Token(Token = "0x403B721")]
			LOCKED,
			// Token: 0x0403B722 RID: 243490
			[Token(Token = "0x403B722")]
			UNLOCK,
			// Token: 0x0403B723 RID: 243491
			[Token(Token = "0x403B723")]
			CLOSED
		}
	}
}
