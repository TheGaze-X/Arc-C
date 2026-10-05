using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.Activity.Act46Side
{
	// Token: 0x020072A2 RID: 29346
	[Token(Token = "0x20072A2")]
	public class Act46SideEntryMonopolyViewModel : TemplateActivityViewModel
	{
		// Token: 0x060298D5 RID: 170197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298D5")]
		[Address(RVA = "0x24FE330", Offset = "0x24FCF30", VA = "0x1824FE330")]
		public Act46SideEntryMonopolyViewModel(object param)
		{
		}

		// Token: 0x060298D6 RID: 170198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298D6")]
		[Address(RVA = "0x24FE170", Offset = "0x24FCD70", VA = "0x1824FE170")]
		public void RefreshData()
		{
		}

		// Token: 0x0403B66E RID: 243310
		[Token(Token = "0x403B66E")]
		[FieldOffset(Offset = "0x20")]
		public Act46SideEntryMonopolyViewModel.Status status;

		// Token: 0x0403B66F RID: 243311
		[Token(Token = "0x403B66F")]
		[FieldOffset(Offset = "0x28")]
		public string lockDesc;

		// Token: 0x0403B670 RID: 243312
		[Token(Token = "0x403B670")]
		[FieldOffset(Offset = "0x30")]
		public string lockToast;

		// Token: 0x0403B671 RID: 243313
		[Token(Token = "0x403B671")]
		[FieldOffset(Offset = "0x38")]
		public string actId;

		// Token: 0x0403B672 RID: 243314
		[Token(Token = "0x403B672")]
		[FieldOffset(Offset = "0x40")]
		public bool showNewTrackPoint;

		// Token: 0x0403B673 RID: 243315
		[Token(Token = "0x403B673")]
		[FieldOffset(Offset = "0x48")]
		private DateTime m_actEndTs;

		// Token: 0x0403B674 RID: 243316
		[Token(Token = "0x403B674")]
		[FieldOffset(Offset = "0x50")]
		private DateTime m_actRewardEndTs;

		// Token: 0x0403B675 RID: 243317
		[Token(Token = "0x403B675")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403B676 RID: 243318
		[Token(Token = "0x403B676")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x020072A3 RID: 29347
		[Token(Token = "0x20072A3")]
		public class Input
		{
			// Token: 0x060298D7 RID: 170199 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60298D7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403B677 RID: 243319
			[Token(Token = "0x403B677")]
			[FieldOffset(Offset = "0x10")]
			public Act46SideData actData;

			// Token: 0x0403B678 RID: 243320
			[Token(Token = "0x403B678")]
			[FieldOffset(Offset = "0x18")]
			public ActivityBasicInfo actBasicInfo;
		}

		// Token: 0x020072A4 RID: 29348
		[Token(Token = "0x20072A4")]
		public enum Status
		{
			// Token: 0x0403B67A RID: 243322
			[Token(Token = "0x403B67A")]
			LOCK,
			// Token: 0x0403B67B RID: 243323
			[Token(Token = "0x403B67B")]
			UNLOCK,
			// Token: 0x0403B67C RID: 243324
			[Token(Token = "0x403B67C")]
			TIMEOUT
		}
	}
}
