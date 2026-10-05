using System;
using Il2CppDummyDll;
using Torappu.UI;
using U8.SDK;
using UnityEngine;
using XLua;

namespace YostarSDKV2
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000098")]
	public class YostarV2LoginJPDialog : UICustomDialog<YostarV2LoginJPDialog.Options>
	{
		// Token: 0x060002AF RID: 687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x5236A0", Offset = "0x5222A0", VA = "0x1805236A0", Slot = "7")]
		protected override void OnRender(YostarV2LoginJPDialog.Options options)
		{
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x523290", Offset = "0x521E90", VA = "0x180523290")]
		public void EventOnLoginClicked()
		{
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x523500", Offset = "0x522100", VA = "0x180523500")]
		public void EventOnUserCenterClicked()
		{
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x5231D0", Offset = "0x521DD0", VA = "0x1805231D0")]
		public void EventOnFeedbackClicked()
		{
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x5234A0", Offset = "0x5220A0", VA = "0x1805234A0")]
		public void EventOnPreAnnounceClicked()
		{
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x5233C0", Offset = "0x521FC0", VA = "0x1805233C0")]
		public void EventOnMigrateClicked()
		{
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x5235C0", Offset = "0x5221C0", VA = "0x1805235C0", Slot = "12")]
		protected override UISwitchTween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x523820", Offset = "0x522420", VA = "0x180523820")]
		private bool _CheckIfLoginReady()
		{
			return default(bool);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x523900", Offset = "0x522500", VA = "0x180523900")]
		private void _OnBackPressed()
		{
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x523890", Offset = "0x522490", VA = "0x180523890")]
		private void _Login()
		{
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x523A40", Offset = "0x522640", VA = "0x180523A40")]
		public YostarV2LoginJPDialog()
		{
		}

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _btnUserCenter;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _btnMigrate;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _rootCanvasGroup;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _hideDuration;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x60")]
		private YostarV2LoginJPDialog.Options m_options;

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isShowingDialog;

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x70")]
		private YostarSDKV2 m_sdk;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnLoginClicked;

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnUserCenterClicked;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnFeedbackClicked;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnPreAnnounceClicked;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnMigrateClicked;

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckIfLoginReady;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnBackPressed;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__Login;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02000099 RID: 153
		[Token(Token = "0x2000099")]
		public class Options
		{
			// Token: 0x060002BB RID: 699 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x04000306 RID: 774
			[Token(Token = "0x4000306")]
			[FieldOffset(Offset = "0x10")]
			public ExternalPluginLoginParams loginParams;

			// Token: 0x04000307 RID: 775
			[Token(Token = "0x4000307")]
			[FieldOffset(Offset = "0x38")]
			public YostarSDKV2 sdk;

			// Token: 0x04000308 RID: 776
			[Token(Token = "0x4000308")]
			[FieldOffset(Offset = "0x40")]
			public bool hasCachedUser;
		}
	}
}
