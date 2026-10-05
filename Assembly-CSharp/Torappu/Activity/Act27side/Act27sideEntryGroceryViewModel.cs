using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.Activity.Act27side
{
	// Token: 0x020074B9 RID: 29881
	[Token(Token = "0x20074B9")]
	public class Act27sideEntryGroceryViewModel : TemplateActivityViewModel, IHotfixable
	{
		// Token: 0x0602A252 RID: 172626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A252")]
		[Address(RVA = "0x25D1960", Offset = "0x25D0560", VA = "0x1825D1960")]
		public Act27sideEntryGroceryViewModel(object param)
		{
		}

		// Token: 0x0602A253 RID: 172627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A253")]
		[Address(RVA = "0x25D1760", Offset = "0x25D0360", VA = "0x1825D1760")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x0403C8AB RID: 247979
		[Token(Token = "0x403C8AB")]
		[FieldOffset(Offset = "0x20")]
		public Act27sideEntryGroceryViewModel.Status currStatus;

		// Token: 0x0403C8AC RID: 247980
		[Token(Token = "0x403C8AC")]
		[FieldOffset(Offset = "0x28")]
		public string lockedToastDesc;

		// Token: 0x0403C8AD RID: 247981
		[Token(Token = "0x403C8AD")]
		[FieldOffset(Offset = "0x30")]
		public string lockedDesc;

		// Token: 0x0403C8AE RID: 247982
		[Token(Token = "0x403C8AE")]
		[FieldOffset(Offset = "0x38")]
		private string m_actId;

		// Token: 0x0403C8AF RID: 247983
		[Token(Token = "0x403C8AF")]
		[FieldOffset(Offset = "0x40")]
		private DateTime m_actEndTs;

		// Token: 0x0403C8B0 RID: 247984
		[Token(Token = "0x403C8B0")]
		[FieldOffset(Offset = "0x48")]
		private DateTime m_actRewardEndTs;

		// Token: 0x0403C8B1 RID: 247985
		[Token(Token = "0x403C8B1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403C8B2 RID: 247986
		[Token(Token = "0x403C8B2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x020074BA RID: 29882
		[Token(Token = "0x20074BA")]
		public class Input
		{
			// Token: 0x0602A254 RID: 172628 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A254")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403C8B3 RID: 247987
			[Token(Token = "0x403C8B3")]
			[FieldOffset(Offset = "0x10")]
			public Act27SideData gameData;

			// Token: 0x0403C8B4 RID: 247988
			[Token(Token = "0x403C8B4")]
			[FieldOffset(Offset = "0x18")]
			public ActivityBasicInfo actBasicInfo;
		}

		// Token: 0x020074BB RID: 29883
		[Token(Token = "0x20074BB")]
		public enum Status
		{
			// Token: 0x0403C8B6 RID: 247990
			[Token(Token = "0x403C8B6")]
			LOCKED,
			// Token: 0x0403C8B7 RID: 247991
			[Token(Token = "0x403C8B7")]
			UNLOCK,
			// Token: 0x0403C8B8 RID: 247992
			[Token(Token = "0x403C8B8")]
			TIME_OUT
		}
	}
}
