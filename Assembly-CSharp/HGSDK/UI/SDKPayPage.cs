using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x0200019F RID: 415
	[Token(Token = "0x200019F")]
	public class SDKPayPage : HGSDK.UIPage
	{
		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x00003690 File Offset: 0x00001890
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000E4")]
		private SDKPayPage.PayState state
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x1AE0A60", Offset = "0x1ADF660", VA = "0x181AE0A60")]
			get
			{
				return SDKPayPage.PayState.DEFAULT_STATE;
			}
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x1AE0AE0", Offset = "0x1ADF6E0", VA = "0x181AE0AE0")]
			set
			{
			}
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x1AE0120", Offset = "0x1ADED20", VA = "0x181AE0120")]
		public void SetCallbacks(Action<HGSDK.PayResult> onSuc, Action onFail)
		{
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x1ADFBC0", Offset = "0x1ADE7C0", VA = "0x181ADFBC0")]
		public void NotifyPayResult(HGSDK.PayResult payResult)
		{
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x170000E5")]
		protected override float fadeDuration
		{
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x1AE0A00", Offset = "0x1ADF600", VA = "0x181AE0A00", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x1ADF690", Offset = "0x1ADE290", VA = "0x181ADF690")]
		public void DoPasswordLogin(string username, string password, Action<HGSDK.LoginResult> onSuc, Action onFail)
		{
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x1AE01D0", Offset = "0x1ADEDD0", VA = "0x181AE01D0")]
		public void StartUpgradeGuestAfterLogin(HGSDK.LoginResult result)
		{
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x1ADF830", Offset = "0x1ADE430", VA = "0x181ADF830")]
		public void EventOnCloseClicked()
		{
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x1ADFA00", Offset = "0x1ADE600", VA = "0x181ADFA00")]
		public void EventOnGotoPasswdLogin()
		{
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x1ADF9A0", Offset = "0x1ADE5A0", VA = "0x181ADF9A0")]
		public void EventOnGotoCaptchaLogin()
		{
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x1ADFB10", Offset = "0x1ADE710", VA = "0x181ADFB10")]
		public void EventOnOpenRegisterLicense()
		{
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x1ADFA60", Offset = "0x1ADE660", VA = "0x181ADFA60")]
		public void EventOnOpenPrivacyLicense()
		{
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x1ADFD90", Offset = "0x1ADE990", VA = "0x181ADFD90", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x1AE00C0", Offset = "0x1ADECC0", VA = "0x181AE00C0", Slot = "6")]
		protected override void OnOpen()
		{
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x1ADFC50", Offset = "0x1ADE850", VA = "0x181ADFC50", Slot = "7")]
		protected override void OnClose()
		{
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x1AE0370", Offset = "0x1ADEF70", VA = "0x181AE0370")]
		private void Update()
		{
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x1AE0580", Offset = "0x1ADF180", VA = "0x181AE0580")]
		private void _OnStateTransitting(SDKPayPage.UIState curState, SDKPayPage.UIState nextState)
		{
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x1AE0440", Offset = "0x1ADF040", VA = "0x181AE0440")]
		private UIStateMachine<SDKPayPage.PayState> _ConstructStateMachine()
		{
			return null;
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1AE0920", Offset = "0x1ADF520", VA = "0x181AE0920")]
		public SDKPayPage()
		{
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x000036C0 File Offset: 0x000018C0
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x1ACFF70", Offset = "0x1ACEB70", VA = "0x181ACFF70")]
		private float <>xLuaBaseProxy_get_fadeDuration()
		{
			return 0f;
		}

		// Token: 0x040008BD RID: 2237
		[Token(Token = "0x40008BD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SDKPayPage.UIState[] _states;

		// Token: 0x040008BE RID: 2238
		[Token(Token = "0x40008BE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIRenderTextureImage _blurImage;

		// Token: 0x040008BF RID: 2239
		[Token(Token = "0x40008BF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _backPanelImage;

		// Token: 0x040008C0 RID: 2240
		[Token(Token = "0x40008C0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _closeBtn;

		// Token: 0x040008C1 RID: 2241
		[Token(Token = "0x40008C1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SDKPopupWebView _popupWebView;

		// Token: 0x040008C2 RID: 2242
		[Token(Token = "0x40008C2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Fade")]
		private float _fadeDuration;

		// Token: 0x040008C3 RID: 2243
		[Token(Token = "0x40008C3")]
		[FieldOffset(Offset = "0x68")]
		private UIStateMachine<SDKPayPage.PayState> m_stateMachine;

		// Token: 0x040008C4 RID: 2244
		[Token(Token = "0x40008C4")]
		[FieldOffset(Offset = "0x70")]
		private RectTransform m_backPanelRectTransform;

		// Token: 0x040008C5 RID: 2245
		[Token(Token = "0x40008C5")]
		[FieldOffset(Offset = "0x78")]
		private Action<HGSDK.PayResult> m_onSuc;

		// Token: 0x040008C6 RID: 2246
		[Token(Token = "0x40008C6")]
		[FieldOffset(Offset = "0x80")]
		private Action m_onFail;

		// Token: 0x040008C7 RID: 2247
		[Token(Token = "0x40008C7")]
		[FieldOffset(Offset = "0x88")]
		private HGSDK.PayResult m_payResult;

		// Token: 0x040008C8 RID: 2248
		[Token(Token = "0x40008C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x040008C9 RID: 2249
		[Token(Token = "0x40008C9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_state;

		// Token: 0x040008CA RID: 2250
		[Token(Token = "0x40008CA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetCallbacks;

		// Token: 0x040008CB RID: 2251
		[Token(Token = "0x40008CB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_NotifyPayResult;

		// Token: 0x040008CC RID: 2252
		[Token(Token = "0x40008CC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_fadeDuration;

		// Token: 0x040008CD RID: 2253
		[Token(Token = "0x40008CD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoPasswordLogin;

		// Token: 0x040008CE RID: 2254
		[Token(Token = "0x40008CE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_StartUpgradeGuestAfterLogin;

		// Token: 0x040008CF RID: 2255
		[Token(Token = "0x40008CF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnCloseClicked;

		// Token: 0x040008D0 RID: 2256
		[Token(Token = "0x40008D0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnGotoPasswdLogin;

		// Token: 0x040008D1 RID: 2257
		[Token(Token = "0x40008D1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnGotoCaptchaLogin;

		// Token: 0x040008D2 RID: 2258
		[Token(Token = "0x40008D2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnOpenRegisterLicense;

		// Token: 0x040008D3 RID: 2259
		[Token(Token = "0x40008D3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnOpenPrivacyLicense;

		// Token: 0x040008D4 RID: 2260
		[Token(Token = "0x40008D4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040008D5 RID: 2261
		[Token(Token = "0x40008D5")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnOpen;

		// Token: 0x040008D6 RID: 2262
		[Token(Token = "0x40008D6")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnClose;

		// Token: 0x040008D7 RID: 2263
		[Token(Token = "0x40008D7")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040008D8 RID: 2264
		[Token(Token = "0x40008D8")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnStateTransitting;

		// Token: 0x040008D9 RID: 2265
		[Token(Token = "0x40008D9")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ConstructStateMachine;

		// Token: 0x040008DA RID: 2266
		[Token(Token = "0x40008DA")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020001A0 RID: 416
		[Token(Token = "0x20001A0")]
		public enum PayState
		{
			// Token: 0x040008DC RID: 2268
			[Token(Token = "0x40008DC")]
			DEFAULT_STATE,
			// Token: 0x040008DD RID: 2269
			[Token(Token = "0x40008DD")]
			INIT,
			// Token: 0x040008DE RID: 2270
			[Token(Token = "0x40008DE")]
			UPGRADE_MENU,
			// Token: 0x040008DF RID: 2271
			[Token(Token = "0x40008DF")]
			PASSWD_LOGIN,
			// Token: 0x040008E0 RID: 2272
			[Token(Token = "0x40008E0")]
			CAPTCHA_LOGIN,
			// Token: 0x040008E1 RID: 2273
			[Token(Token = "0x40008E1")]
			REGISTER,
			// Token: 0x040008E2 RID: 2274
			[Token(Token = "0x40008E2")]
			IDENTITY_VERIFY,
			// Token: 0x040008E3 RID: 2275
			[Token(Token = "0x40008E3")]
			PROCESS_PAYMENT,
			// Token: 0x040008E4 RID: 2276
			[Token(Token = "0x40008E4")]
			FINISHED,
			// Token: 0x040008E5 RID: 2277
			[Token(Token = "0x40008E5")]
			TERMINAL_STATE = -1
		}

		// Token: 0x020001A1 RID: 417
		[Token(Token = "0x20001A1")]
		[RequireComponent(typeof(RectTransform))]
		public abstract class UIState : UIStateMachine<SDKPayPage.PayState>.UIStateBehaviour
		{
			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x060006D2 RID: 1746 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000E6")]
			protected HGSDK sdk
			{
				[Token(Token = "0x60006D2")]
				[Address(RVA = "0x1AE93E0", Offset = "0x1AE7FE0", VA = "0x181AE93E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000E7")]
			protected new SDKPayPage page
			{
				[Token(Token = "0x60006D3")]
				[Address(RVA = "0x1AE8E00", Offset = "0x1AE7A00", VA = "0x181AE8E00")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x060006D4 RID: 1748
			[Token(Token = "0x170000E8")]
			public abstract bool showBackPanel { [Token(Token = "0x60006D4")] get; }

			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x060006D5 RID: 1749 RVA: 0x000036D8 File Offset: 0x000018D8
			[Token(Token = "0x170000E9")]
			public virtual bool isCloseable
			{
				[Token(Token = "0x60006D5")]
				[Address(RVA = "0x1AD4220", Offset = "0x1AD2E20", VA = "0x181AD4220", Slot = "25")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170000EA RID: 234
			// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000EA")]
			public RectTransform rectTransform
			{
				[Token(Token = "0x60006D6")]
				[Address(RVA = "0x1AE9110", Offset = "0x1AE7D10", VA = "0x181AE9110")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000EB RID: 235
			// (get) Token: 0x060006D7 RID: 1751 RVA: 0x000036F0 File Offset: 0x000018F0
			// (set) Token: 0x060006D8 RID: 1752 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170000EB")]
			protected SDKPayPage.PayState pageState
			{
				[Token(Token = "0x60006D7")]
				[Address(RVA = "0x1AE8BA0", Offset = "0x1AE77A0", VA = "0x181AE8BA0")]
				get
				{
					return SDKPayPage.PayState.DEFAULT_STATE;
				}
				[Token(Token = "0x60006D8")]
				[Address(RVA = "0x1AE96B0", Offset = "0x1AE82B0", VA = "0x181AE96B0")]
				set
				{
				}
			}

			// Token: 0x060006D9 RID: 1753 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x1AE8380", Offset = "0x1AE6F80", VA = "0x181AE8380")]
			protected void SetWarningHints(IWarningHint[] warningHints)
			{
			}

			// Token: 0x060006DA RID: 1754 RVA: 0x00003708 File Offset: 0x00001908
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x1AE8510", Offset = "0x1AE7110", VA = "0x181AE8510")]
			protected bool ValidateAndUpdateWarningHints(bool forceShowIfNotPass)
			{
				return default(bool);
			}

			// Token: 0x060006DB RID: 1755 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x1AE77B0", Offset = "0x1AE63B0", VA = "0x181AE77B0")]
			protected void CloseMyPage()
			{
			}

			// Token: 0x060006DC RID: 1756 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x1AE89F0", Offset = "0x1AE75F0", VA = "0x181AE89F0")]
			protected UIState()
			{
			}

			// Token: 0x040008E6 RID: 2278
			[Token(Token = "0x40008E6")]
			[FieldOffset(Offset = "0x38")]
			private RectTransform m_rectTransform;

			// Token: 0x040008E7 RID: 2279
			[Token(Token = "0x40008E7")]
			[FieldOffset(Offset = "0x40")]
			private IWarningHint[] m_warningHints;

			// Token: 0x040008E8 RID: 2280
			[Token(Token = "0x40008E8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_sdk;

			// Token: 0x040008E9 RID: 2281
			[Token(Token = "0x40008E9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_page;

			// Token: 0x040008EA RID: 2282
			[Token(Token = "0x40008EA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_isCloseable;

			// Token: 0x040008EB RID: 2283
			[Token(Token = "0x40008EB")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_rectTransform;

			// Token: 0x040008EC RID: 2284
			[Token(Token = "0x40008EC")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_pageState;

			// Token: 0x040008ED RID: 2285
			[Token(Token = "0x40008ED")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_pageState;

			// Token: 0x040008EE RID: 2286
			[Token(Token = "0x40008EE")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_SetWarningHints;

			// Token: 0x040008EF RID: 2287
			[Token(Token = "0x40008EF")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ValidateAndUpdateWarningHints;

			// Token: 0x040008F0 RID: 2288
			[Token(Token = "0x40008F0")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_CloseMyPage;

			// Token: 0x040008F1 RID: 2289
			[Token(Token = "0x40008F1")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
