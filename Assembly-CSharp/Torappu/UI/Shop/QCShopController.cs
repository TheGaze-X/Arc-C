using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AF9 RID: 23289
	[Token(Token = "0x2005AF9")]
	public class QCShopController : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021D84 RID: 138628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D84")]
		[Address(RVA = "0x1C485E0", Offset = "0x1C471E0", VA = "0x181C485E0")]
		private void _InitIfNot(ShopPage page)
		{
		}

		// Token: 0x06021D85 RID: 138629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D85")]
		[Address(RVA = "0x1C48370", Offset = "0x1C46F70", VA = "0x181C48370")]
		private void _DealWithQCResponse(IQCShopGetResponse response)
		{
		}

		// Token: 0x06021D86 RID: 138630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D86")]
		[Address(RVA = "0x1C48190", Offset = "0x1C46D90", VA = "0x181C48190")]
		public void RefreshData(ShopPage page)
		{
		}

		// Token: 0x06021D87 RID: 138631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D87")]
		[Address(RVA = "0x1C47A00", Offset = "0x1C46600", VA = "0x181C47A00")]
		public void ApplyQCState(QCShopDetailShopEnum detailState, ShopPage page, UnityAction detailCick)
		{
		}

		// Token: 0x06021D88 RID: 138632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D88")]
		[Address(RVA = "0x1C48E90", Offset = "0x1C47A90", VA = "0x181C48E90")]
		public QCShopController()
		{
		}

		// Token: 0x0402E592 RID: 189842
		[Token(Token = "0x402E592")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIQCShopEvent _clickEvent;

		// Token: 0x0402E593 RID: 189843
		[Token(Token = "0x402E593")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<QCShopControllerObj> _objList;

		// Token: 0x0402E594 RID: 189844
		[Token(Token = "0x402E594")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private QCShopHighView _highView;

		// Token: 0x0402E595 RID: 189845
		[Token(Token = "0x402E595")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private QCShopLowView _lowView;

		// Token: 0x0402E596 RID: 189846
		[Token(Token = "0x402E596")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private QCShopClassicView _classicView;

		// Token: 0x0402E597 RID: 189847
		[Token(Token = "0x402E597")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private QCShopExtraView _extraView;

		// Token: 0x0402E598 RID: 189848
		[Token(Token = "0x402E598")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private QCShopREPView _repView;

		// Token: 0x0402E599 RID: 189849
		[Token(Token = "0x402E599")]
		[FieldOffset(Offset = "0x50")]
		private QCShopLMTGSView m_sLMTGSView;

		// Token: 0x0402E59A RID: 189850
		[Token(Token = "0x402E59A")]
		[FieldOffset(Offset = "0x58")]
		private QCShopEPGSView m_sEPGSView;

		// Token: 0x0402E59B RID: 189851
		[Token(Token = "0x402E59B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _sLMTGSContainer;

		// Token: 0x0402E59C RID: 189852
		[Token(Token = "0x402E59C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _sEPGSContainer;

		// Token: 0x0402E59D RID: 189853
		[Token(Token = "0x402E59D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _sLMTGSButtonContainer;

		// Token: 0x0402E59E RID: 189854
		[Token(Token = "0x402E59E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _sEPGSButtonContainer;

		// Token: 0x0402E59F RID: 189855
		[Token(Token = "0x402E59F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _qcDetail;

		// Token: 0x0402E5A0 RID: 189856
		[Token(Token = "0x402E5A0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _limitDetail;

		// Token: 0x0402E5A1 RID: 189857
		[Token(Token = "0x402E5A1")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _extraQCDetail;

		// Token: 0x0402E5A2 RID: 189858
		[Token(Token = "0x402E5A2")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _repQCDetail;

		// Token: 0x0402E5A3 RID: 189859
		[Token(Token = "0x402E5A3")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _classicDetail;

		// Token: 0x0402E5A4 RID: 189860
		[Token(Token = "0x402E5A4")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _classicLeftButton;

		// Token: 0x0402E5A5 RID: 189861
		[Token(Token = "0x402E5A5")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Transform _limitDetailButtonContainer;

		// Token: 0x0402E5A6 RID: 189862
		[Token(Token = "0x402E5A6")]
		[FieldOffset(Offset = "0xB8")]
		private Button m_limitDetailButton;

		// Token: 0x0402E5A7 RID: 189863
		[Token(Token = "0x402E5A7")]
		[FieldOffset(Offset = "0xC0")]
		private LMTGSControllerButton m_button;

		// Token: 0x0402E5A8 RID: 189864
		[Token(Token = "0x402E5A8")]
		[FieldOffset(Offset = "0xC8")]
		private List<QCShopControllerObj> m_objList;

		// Token: 0x0402E5A9 RID: 189865
		[Token(Token = "0x402E5A9")]
		private const QCShopDetailShopEnum DEFAULT_STATE = QCShopDetailShopEnum.HIGH;

		// Token: 0x0402E5AA RID: 189866
		[Token(Token = "0x402E5AA")]
		[FieldOffset(Offset = "0xD0")]
		private QCShopDetailShopEnum m_currentState;

		// Token: 0x0402E5AB RID: 189867
		[Token(Token = "0x402E5AB")]
		[FieldOffset(Offset = "0xD4")]
		private bool m_isInited;

		// Token: 0x0402E5AC RID: 189868
		[Token(Token = "0x402E5AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402E5AD RID: 189869
		[Token(Token = "0x402E5AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__DealWithQCResponse;

		// Token: 0x0402E5AE RID: 189870
		[Token(Token = "0x402E5AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0402E5AF RID: 189871
		[Token(Token = "0x402E5AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyQCState;

		// Token: 0x0402E5B0 RID: 189872
		[Token(Token = "0x402E5B0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
