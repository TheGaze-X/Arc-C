using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x02007308 RID: 29448
	[Token(Token = "0x2007308")]
	public class Act42SideEntryGunTaskViewModel : TemplateActivityViewModel, IHotfixable
	{
		// Token: 0x06029A74 RID: 170612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A74")]
		[Address(RVA = "0x250B150", Offset = "0x2509D50", VA = "0x18250B150")]
		public Act42SideEntryGunTaskViewModel(object param)
		{
		}

		// Token: 0x06029A75 RID: 170613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A75")]
		[Address(RVA = "0x250AE00", Offset = "0x2509A00", VA = "0x18250AE00")]
		public void RefreshData()
		{
		}

		// Token: 0x0403B958 RID: 244056
		[Token(Token = "0x403B958")]
		[FieldOffset(Offset = "0x20")]
		public string actId;

		// Token: 0x0403B959 RID: 244057
		[Token(Token = "0x403B959")]
		[FieldOffset(Offset = "0x28")]
		public Act42SideEntryGunTaskViewModel.Status status;

		// Token: 0x0403B95A RID: 244058
		[Token(Token = "0x403B95A")]
		[FieldOffset(Offset = "0x2C")]
		public bool isNew;

		// Token: 0x0403B95B RID: 244059
		[Token(Token = "0x403B95B")]
		[FieldOffset(Offset = "0x2D")]
		public bool hasNewTask;

		// Token: 0x0403B95C RID: 244060
		[Token(Token = "0x403B95C")]
		[FieldOffset(Offset = "0x2E")]
		public bool showTrack;

		// Token: 0x0403B95D RID: 244061
		[Token(Token = "0x403B95D")]
		[FieldOffset(Offset = "0x30")]
		public string lockToast;

		// Token: 0x0403B95E RID: 244062
		[Token(Token = "0x403B95E")]
		[FieldOffset(Offset = "0x38")]
		public string stageName;

		// Token: 0x0403B95F RID: 244063
		[Token(Token = "0x403B95F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403B960 RID: 244064
		[Token(Token = "0x403B960")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x02007309 RID: 29449
		[Token(Token = "0x2007309")]
		public class Input
		{
			// Token: 0x06029A76 RID: 170614 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029A76")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403B961 RID: 244065
			[Token(Token = "0x403B961")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}

		// Token: 0x0200730A RID: 29450
		[Token(Token = "0x200730A")]
		public enum Status
		{
			// Token: 0x0403B963 RID: 244067
			[Token(Token = "0x403B963")]
			LOCKED,
			// Token: 0x0403B964 RID: 244068
			[Token(Token = "0x403B964")]
			UNLOCK,
			// Token: 0x0403B965 RID: 244069
			[Token(Token = "0x403B965")]
			CLOSED
		}
	}
}
