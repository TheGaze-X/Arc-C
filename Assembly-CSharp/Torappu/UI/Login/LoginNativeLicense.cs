using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.SDK;
using XLua;

namespace Torappu.UI.Login
{
	// Token: 0x020049D4 RID: 18900
	[Token(Token = "0x20049D4")]
	public class LoginNativeLicense : Singleton<LoginNativeLicense>, IDisposable
	{
		// Token: 0x0601C761 RID: 116577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C761")]
		[Address(RVA = "0x15E1BE0", Offset = "0x15E07E0", VA = "0x1815E1BE0")]
		private LoginNativeLicense()
		{
		}

		// Token: 0x0601C762 RID: 116578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C762")]
		[Address(RVA = "0x15E1AA0", Offset = "0x15E06A0", VA = "0x1815E1AA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C763 RID: 116579 RVA: 0x000A8768 File Offset: 0x000A6968
		[Token(Token = "0x601C763")]
		[Address(RVA = "0x15E1080", Offset = "0x15DFC80", VA = "0x1815E1080")]
		public bool IsInvoking()
		{
			return default(bool);
		}

		// Token: 0x0601C764 RID: 116580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C764")]
		[Address(RVA = "0x15E0AE0", Offset = "0x15DF6E0", VA = "0x1815E0AE0")]
		public void InvokeLicense(LoginNativeLicense.Callback callback)
		{
		}

		// Token: 0x0601C765 RID: 116581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C765")]
		[Address(RVA = "0x15E1880", Offset = "0x15E0480", VA = "0x1815E1880")]
		private void _HookAlertNativeLicenseDialog()
		{
		}

		// Token: 0x0601C766 RID: 116582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C766")]
		[Address(RVA = "0x15E0A00", Offset = "0x15DF600", VA = "0x1815E0A00", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0601C767 RID: 116583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C767")]
		[Address(RVA = "0x15E1350", Offset = "0x15DFF50", VA = "0x1815E1350")]
		private static string _CreateInvokeParam()
		{
			return null;
		}

		// Token: 0x0601C768 RID: 116584 RVA: 0x000A8780 File Offset: 0x000A6980
		[Token(Token = "0x601C768")]
		[Address(RVA = "0x15E1280", Offset = "0x15DFE80", VA = "0x1815E1280")]
		public static bool UseNativeLicense()
		{
			return default(bool);
		}

		// Token: 0x0601C769 RID: 116585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C769")]
		[Address(RVA = "0x15E10E0", Offset = "0x15DFCE0", VA = "0x1815E10E0")]
		public static void ShowLicense4Display()
		{
		}

		// Token: 0x0601C76A RID: 116586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C76A")]
		[Address(RVA = "0x15E14B0", Offset = "0x15E00B0", VA = "0x1815E14B0")]
		private void _EventOnLicenseRetMessage(SDKExtraInfoHandler.NativeLicenseRet licenseRet)
		{
		}

		// Token: 0x040254AB RID: 152747
		[Token(Token = "0x40254AB")]
		[FieldOffset(Offset = "0x10")]
		private HashSet<LoginNativeLicense.Callback> m_callbacks;

		// Token: 0x040254AC RID: 152748
		[Token(Token = "0x40254AC")]
		[FieldOffset(Offset = "0x18")]
		private bool m_isLicenseInvoking;

		// Token: 0x040254AD RID: 152749
		[Token(Token = "0x40254AD")]
		[FieldOffset(Offset = "0x19")]
		private bool m_isInited;

		// Token: 0x040254AE RID: 152750
		[Token(Token = "0x40254AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040254AF RID: 152751
		[Token(Token = "0x40254AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040254B0 RID: 152752
		[Token(Token = "0x40254B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsInvoking;

		// Token: 0x040254B1 RID: 152753
		[Token(Token = "0x40254B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InvokeLicense;

		// Token: 0x040254B2 RID: 152754
		[Token(Token = "0x40254B2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__HookAlertNativeLicenseDialog;

		// Token: 0x040254B3 RID: 152755
		[Token(Token = "0x40254B3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x040254B4 RID: 152756
		[Token(Token = "0x40254B4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CreateInvokeParam;

		// Token: 0x040254B5 RID: 152757
		[Token(Token = "0x40254B5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UseNativeLicense;

		// Token: 0x040254B6 RID: 152758
		[Token(Token = "0x40254B6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ShowLicense4Display;

		// Token: 0x040254B7 RID: 152759
		[Token(Token = "0x40254B7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnLicenseRetMessage;

		// Token: 0x020049D5 RID: 18901
		[Token(Token = "0x20049D5")]
		public enum Failure
		{
			// Token: 0x040254B9 RID: 152761
			[Token(Token = "0x40254B9")]
			NONE,
			// Token: 0x040254BA RID: 152762
			[Token(Token = "0x40254BA")]
			INVALID_MSG,
			// Token: 0x040254BB RID: 152763
			[Token(Token = "0x40254BB")]
			USER_CANCEL,
			// Token: 0x040254BC RID: 152764
			[Token(Token = "0x40254BC")]
			VERSION_CHECK_FAIL,
			// Token: 0x040254BD RID: 152765
			[Token(Token = "0x40254BD")]
			VERSION_SUBMIT_FAIL
		}

		// Token: 0x020049D6 RID: 18902
		[Token(Token = "0x20049D6")]
		public class Callback
		{
			// Token: 0x0601C76D RID: 116589 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C76D")]
			[Address(RVA = "0x15DCC90", Offset = "0x15DB890", VA = "0x1815DCC90")]
			public void NotifyRet(LoginNativeLicense.Failure reason)
			{
			}

			// Token: 0x0601C76E RID: 116590 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C76E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Callback()
			{
			}

			// Token: 0x040254BE RID: 152766
			[Token(Token = "0x40254BE")]
			[FieldOffset(Offset = "0x10")]
			public Action onLicenseAgreed;

			// Token: 0x040254BF RID: 152767
			[Token(Token = "0x40254BF")]
			[FieldOffset(Offset = "0x18")]
			public Action<LoginNativeLicense.Failure> onLicenseFailed;
		}
	}
}
