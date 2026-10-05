using System;
using Il2CppDummyDll;
using Torappu.UI;
using U8.SDK;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.V2
{
	// Token: 0x02000179 RID: 377
	[Token(Token = "0x2000179")]
	public class HGSDKV2LoginDialog : UICustomDialog<HGSDKV2LoginDialog.Options>
	{
		// Token: 0x060005DF RID: 1503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x1AD10E0", Offset = "0x1ACFCE0", VA = "0x181AD10E0", Slot = "12")]
		protected override UISwitchTween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x1AD11C0", Offset = "0x1ACFDC0", VA = "0x181AD11C0", Slot = "7")]
		protected override void OnRender(HGSDKV2LoginDialog.Options options)
		{
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x1AD0DE0", Offset = "0x1ACF9E0", VA = "0x181AD0DE0")]
		public void EventOnLogin()
		{
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x1AD0FC0", Offset = "0x1ACFBC0", VA = "0x181AD0FC0")]
		public void EventOnSwitchAccount()
		{
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x1AD0D60", Offset = "0x1ACF960", VA = "0x181AD0D60")]
		public void EventOnAnnounceClicked()
		{
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x1AD0F00", Offset = "0x1ACFB00", VA = "0x181AD0F00")]
		public void EventOnScanLogin()
		{
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x1AD1440", Offset = "0x1AD0040", VA = "0x181AD1440")]
		private bool _CheckIfLoginReady()
		{
			return default(bool);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1AD1660", Offset = "0x1AD0260", VA = "0x181AD1660")]
		private void _Login()
		{
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x1AD1860", Offset = "0x1AD0460", VA = "0x181AD1860")]
		private void _SwitchAccount()
		{
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x1AD14B0", Offset = "0x1AD00B0", VA = "0x181AD14B0")]
		private void _LoginImpl(int type, string phoneNum)
		{
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x1AD16F0", Offset = "0x1AD02F0", VA = "0x181AD16F0")]
		private void _OnBackPressed()
		{
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x1AD18C0", Offset = "0x1AD04C0", VA = "0x181AD18C0")]
		public HGSDKV2LoginDialog()
		{
		}

		// Token: 0x04000797 RID: 1943
		[Token(Token = "0x4000797")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _btnLogin;

		// Token: 0x04000798 RID: 1944
		[Token(Token = "0x4000798")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _btnRegister;

		// Token: 0x04000799 RID: 1945
		[Token(Token = "0x4000799")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _btnSwitchAccount;

		// Token: 0x0400079A RID: 1946
		[Token(Token = "0x400079A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _btnScanLogin;

		// Token: 0x0400079B RID: 1947
		[Token(Token = "0x400079B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelUserInfo;

		// Token: 0x0400079C RID: 1948
		[Token(Token = "0x400079C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0400079D RID: 1949
		[Token(Token = "0x400079D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _rootCanvasGroup;

		// Token: 0x0400079E RID: 1950
		[Token(Token = "0x400079E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _hideDuration;

		// Token: 0x0400079F RID: 1951
		[Token(Token = "0x400079F")]
		[FieldOffset(Offset = "0x80")]
		private HGSDKV2LoginDialog.Options m_options;

		// Token: 0x040007A0 RID: 1952
		[Token(Token = "0x40007A0")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isShowingDialog;

		// Token: 0x040007A1 RID: 1953
		[Token(Token = "0x40007A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x040007A2 RID: 1954
		[Token(Token = "0x40007A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040007A3 RID: 1955
		[Token(Token = "0x40007A3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnLogin;

		// Token: 0x040007A4 RID: 1956
		[Token(Token = "0x40007A4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnSwitchAccount;

		// Token: 0x040007A5 RID: 1957
		[Token(Token = "0x40007A5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnAnnounceClicked;

		// Token: 0x040007A6 RID: 1958
		[Token(Token = "0x40007A6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnScanLogin;

		// Token: 0x040007A7 RID: 1959
		[Token(Token = "0x40007A7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckIfLoginReady;

		// Token: 0x040007A8 RID: 1960
		[Token(Token = "0x40007A8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__Login;

		// Token: 0x040007A9 RID: 1961
		[Token(Token = "0x40007A9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SwitchAccount;

		// Token: 0x040007AA RID: 1962
		[Token(Token = "0x40007AA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoginImpl;

		// Token: 0x040007AB RID: 1963
		[Token(Token = "0x40007AB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnBackPressed;

		// Token: 0x040007AC RID: 1964
		[Token(Token = "0x40007AC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200017A RID: 378
		[Token(Token = "0x200017A")]
		public class Options
		{
			// Token: 0x060005EC RID: 1516 RVA: 0x00003378 File Offset: 0x00001578
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xAC8CE0", Offset = "0xAC78E0", VA = "0x180AC8CE0")]
			public bool HasCachedUser()
			{
				return default(bool);
			}

			// Token: 0x060005ED RID: 1517 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x040007AD RID: 1965
			[Token(Token = "0x40007AD")]
			[FieldOffset(Offset = "0x10")]
			public string curUserName;

			// Token: 0x040007AE RID: 1966
			[Token(Token = "0x40007AE")]
			[FieldOffset(Offset = "0x18")]
			public ExternalPluginLoginParams loginParams;

			// Token: 0x040007AF RID: 1967
			[Token(Token = "0x40007AF")]
			[FieldOffset(Offset = "0x40")]
			public HGSDKV2 sdk;
		}
	}
}
