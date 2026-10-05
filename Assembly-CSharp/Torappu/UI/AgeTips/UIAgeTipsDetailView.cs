using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Network;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AgeTips
{
	// Token: 0x02006658 RID: 26200
	[Token(Token = "0x2006658")]
	public class UIAgeTipsDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025A0C RID: 154124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A0C")]
		[Address(RVA = "0x20A1090", Offset = "0x209FC90", VA = "0x1820A1090")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025A0D RID: 154125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A0D")]
		[Address(RVA = "0x20A0F40", Offset = "0x209FB40", VA = "0x1820A0F40")]
		private void Start()
		{
		}

		// Token: 0x06025A0E RID: 154126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A0E")]
		[Address(RVA = "0x20A0910", Offset = "0x209F510", VA = "0x1820A0910")]
		public void Show(UIAgeTipsEntry.Config config)
		{
		}

		// Token: 0x06025A0F RID: 154127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A0F")]
		[Address(RVA = "0x20A1340", Offset = "0x209FF40", VA = "0x1820A1340")]
		private void _OnContentSuc(UISender.MIMEObject response)
		{
		}

		// Token: 0x06025A10 RID: 154128 RVA: 0x000C8970 File Offset: 0x000C6B70
		[Token(Token = "0x6025A10")]
		[Address(RVA = "0x20A1240", Offset = "0x209FE40", VA = "0x1820A1240")]
		private bool _OnContentFail(ResponseError error)
		{
			return default(bool);
		}

		// Token: 0x06025A11 RID: 154129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A11")]
		[Address(RVA = "0x20A13F0", Offset = "0x209FFF0", VA = "0x1820A13F0")]
		private void _RenderCurrentContent()
		{
		}

		// Token: 0x06025A12 RID: 154130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A12")]
		[Address(RVA = "0x20A0860", Offset = "0x209F460", VA = "0x1820A0860")]
		public void EventOnCloseClicked()
		{
		}

		// Token: 0x06025A13 RID: 154131 RVA: 0x000C8988 File Offset: 0x000C6B88
		[Token(Token = "0x6025A13")]
		[Address(RVA = "0x20A0FA0", Offset = "0x209FBA0", VA = "0x1820A0FA0")]
		private bool _CheckIfViewOpen()
		{
			return default(bool);
		}

		// Token: 0x06025A14 RID: 154132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A14")]
		[Address(RVA = "0x20A1010", Offset = "0x209FC10", VA = "0x1820A1010")]
		private void _Dismiss()
		{
		}

		// Token: 0x06025A15 RID: 154133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025A15")]
		[Address(RVA = "0x20A0B40", Offset = "0x209F740", VA = "0x1820A0B40")]
		public static List<string> SplitLicenseToSegments(string content)
		{
			return null;
		}

		// Token: 0x06025A16 RID: 154134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A16")]
		[Address(RVA = "0x20A1560", Offset = "0x20A0160", VA = "0x1820A1560")]
		private static void _SplitLongString(string longStr, List<string> outputList)
		{
		}

		// Token: 0x06025A17 RID: 154135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A17")]
		[Address(RVA = "0x20A1670", Offset = "0x20A0270", VA = "0x1820A1670")]
		public UIAgeTipsDetailView()
		{
		}

		// Token: 0x04034DAE RID: 216494
		[Token(Token = "0x4034DAE")]
		private const int MAX_TEXT_STRLEN = 10000;

		// Token: 0x04034DAF RID: 216495
		[Token(Token = "0x4034DAF")]
		private const int MIN_TEXT_STRLEN = 1000;

		// Token: 0x04034DB0 RID: 216496
		[Token(Token = "0x4034DB0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _contentHolder;

		// Token: 0x04034DB1 RID: 216497
		[Token(Token = "0x4034DB1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _titlePrefab;

		// Token: 0x04034DB2 RID: 216498
		[Token(Token = "0x4034DB2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _contentPrefab;

		// Token: 0x04034DB3 RID: 216499
		[Token(Token = "0x4034DB3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04034DB4 RID: 216500
		[Token(Token = "0x4034DB4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _btnClose;

		// Token: 0x04034DB5 RID: 216501
		[Token(Token = "0x4034DB5")]
		[FieldOffset(Offset = "0x40")]
		private List<string> m_content;

		// Token: 0x04034DB6 RID: 216502
		[Token(Token = "0x4034DB6")]
		[FieldOffset(Offset = "0x48")]
		private FadeSwitchTween m_fadeTween;

		// Token: 0x04034DB7 RID: 216503
		[Token(Token = "0x4034DB7")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x04034DB8 RID: 216504
		[Token(Token = "0x4034DB8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034DB9 RID: 216505
		[Token(Token = "0x4034DB9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04034DBA RID: 216506
		[Token(Token = "0x4034DBA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04034DBB RID: 216507
		[Token(Token = "0x4034DBB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnContentSuc;

		// Token: 0x04034DBC RID: 216508
		[Token(Token = "0x4034DBC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnContentFail;

		// Token: 0x04034DBD RID: 216509
		[Token(Token = "0x4034DBD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderCurrentContent;

		// Token: 0x04034DBE RID: 216510
		[Token(Token = "0x4034DBE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnCloseClicked;

		// Token: 0x04034DBF RID: 216511
		[Token(Token = "0x4034DBF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckIfViewOpen;

		// Token: 0x04034DC0 RID: 216512
		[Token(Token = "0x4034DC0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__Dismiss;

		// Token: 0x04034DC1 RID: 216513
		[Token(Token = "0x4034DC1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SplitLicenseToSegments;

		// Token: 0x04034DC2 RID: 216514
		[Token(Token = "0x4034DC2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SplitLongString;

		// Token: 0x04034DC3 RID: 216515
		[Token(Token = "0x4034DC3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
