using System;
using Il2CppDummyDll;
using Torappu.UI;
using U8.SDK;
using UnityEngine;
using XLua;

namespace YostarSDKV2
{
	// Token: 0x0200009D RID: 157
	[Token(Token = "0x200009D")]
	public class YostarV2LoginTempDialog : UICustomDialog<YostarV2LoginTempDialog.Options>
	{
		// Token: 0x060002C2 RID: 706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x524780", Offset = "0x523380", VA = "0x180524780", Slot = "7")]
		protected override void OnRender(YostarV2LoginTempDialog.Options options)
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x524160", Offset = "0x522D60", VA = "0x180524160")]
		public void EventOnLoginClicked()
		{
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x524350", Offset = "0x522F50", VA = "0x180524350")]
		public void EventOnUserCenterClicked()
		{
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x524290", Offset = "0x522E90", VA = "0x180524290")]
		public void EventOnSwitchAccountClicked()
		{
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x5240A0", Offset = "0x522CA0", VA = "0x1805240A0")]
		public void EventOnFeedbackClicked()
		{
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x524410", Offset = "0x523010", VA = "0x180524410")]
		public void EventOnYostarAccountCenter()
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x524580", Offset = "0x523180", VA = "0x180524580")]
		public void EventOnYostarMigrationClicked()
		{
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x524020", Offset = "0x522C20", VA = "0x180524020")]
		public void EventOnAnnouncementClicked()
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x5246A0", Offset = "0x5232A0", VA = "0x1805246A0", Slot = "12")]
		protected override UISwitchTween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x524940", Offset = "0x523540", VA = "0x180524940")]
		private bool _CheckIfLoginReady()
		{
			return default(bool);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x524A20", Offset = "0x523620", VA = "0x180524A20")]
		private void _OnBackPressed()
		{
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x5249B0", Offset = "0x5235B0", VA = "0x1805249B0")]
		private void _Login()
		{
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x524B60", Offset = "0x523760", VA = "0x180524B60")]
		public YostarV2LoginTempDialog()
		{
		}

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _btnUserCenter;

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _btnSwitchAccount;

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelBottomBanner;

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _rootCanvasGroup;

		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _hideDuration;

		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x68")]
		private YostarV2LoginTempDialog.Options m_options;

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isShowingDialog;

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x78")]
		private YostarSDKV2 m_sdk;

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnLoginClicked;

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnUserCenterClicked;

		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnSwitchAccountClicked;

		// Token: 0x0400031F RID: 799
		[Token(Token = "0x400031F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnFeedbackClicked;

		// Token: 0x04000320 RID: 800
		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnYostarAccountCenter;

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnYostarMigrationClicked;

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnAnnouncementClicked;

		// Token: 0x04000323 RID: 803
		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x04000324 RID: 804
		[Token(Token = "0x4000324")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckIfLoginReady;

		// Token: 0x04000325 RID: 805
		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnBackPressed;

		// Token: 0x04000326 RID: 806
		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__Login;

		// Token: 0x04000327 RID: 807
		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200009E RID: 158
		[Token(Token = "0x200009E")]
		public class Options
		{
			// Token: 0x060002D0 RID: 720 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x04000328 RID: 808
			[Token(Token = "0x4000328")]
			[FieldOffset(Offset = "0x10")]
			public ExternalPluginLoginParams loginParams;

			// Token: 0x04000329 RID: 809
			[Token(Token = "0x4000329")]
			[FieldOffset(Offset = "0x38")]
			public YostarSDKV2 sdk;

			// Token: 0x0400032A RID: 810
			[Token(Token = "0x400032A")]
			[FieldOffset(Offset = "0x40")]
			public bool hasCachedUser;
		}
	}
}
