using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B18 RID: 23320
	[Token(Token = "0x2005B18")]
	public class QCShopLowView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021DE9 RID: 138729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DE9")]
		[Address(RVA = "0x1C5D5B0", Offset = "0x1C5C1B0", VA = "0x181C5D5B0")]
		public void OnEnter(ShopPage page)
		{
		}

		// Token: 0x06021DEA RID: 138730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DEA")]
		[Address(RVA = "0x1C5DFE0", Offset = "0x1C5CBE0", VA = "0x181C5DFE0")]
		public void _RenderCountDownValue()
		{
		}

		// Token: 0x06021DEB RID: 138731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DEB")]
		[Address(RVA = "0x1C5D3E0", Offset = "0x1C5BFE0", VA = "0x181C5D3E0")]
		public void ApplyData(GetLowGoodListResponse response)
		{
		}

		// Token: 0x06021DEC RID: 138732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DEC")]
		[Address(RVA = "0x1C5D360", Offset = "0x1C5BF60", VA = "0x181C5D360")]
		public void ApplyCurrentGroup(int index)
		{
		}

		// Token: 0x06021DED RID: 138733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DED")]
		[Address(RVA = "0x1C5DA20", Offset = "0x1C5C620", VA = "0x181C5DA20")]
		private void _ApplyGroupWithIndex(int index)
		{
		}

		// Token: 0x06021DEE RID: 138734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DEE")]
		[Address(RVA = "0x1C5D9B0", Offset = "0x1C5C5B0", VA = "0x181C5D9B0")]
		private void Update()
		{
		}

		// Token: 0x06021DEF RID: 138735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DEF")]
		[Address(RVA = "0x1C5E5A0", Offset = "0x1C5D1A0", VA = "0x181C5E5A0")]
		public QCShopLowView()
		{
		}

		// Token: 0x0402E670 RID: 190064
		[Token(Token = "0x402E670")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<QCShopLowGroupView> _groupList;

		// Token: 0x0402E671 RID: 190065
		[Token(Token = "0x402E671")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<TwoStateToggle> _buttonList;

		// Token: 0x0402E672 RID: 190066
		[Token(Token = "0x402E672")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _backDownTime;

		// Token: 0x0402E673 RID: 190067
		[Token(Token = "0x402E673")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _bottomUnlockProgress;

		// Token: 0x0402E674 RID: 190068
		[Token(Token = "0x402E674")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _bottomUnlockTitle;

		// Token: 0x0402E675 RID: 190069
		[Token(Token = "0x402E675")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _bottomUnlockDesc;

		// Token: 0x0402E676 RID: 190070
		[Token(Token = "0x402E676")]
		[FieldOffset(Offset = "0x48")]
		private QCShopLowViewModel m_viewModel;

		// Token: 0x0402E677 RID: 190071
		[Token(Token = "0x402E677")]
		[FieldOffset(Offset = "0x50")]
		private CountDownTask m_countDownTask;

		// Token: 0x0402E678 RID: 190072
		[Token(Token = "0x402E678")]
		[FieldOffset(Offset = "0x58")]
		private int m_currentGroupIndex;

		// Token: 0x0402E679 RID: 190073
		[Token(Token = "0x402E679")]
		[FieldOffset(Offset = "0x60")]
		private List<QCCommonObj> _objList;

		// Token: 0x0402E67A RID: 190074
		[Token(Token = "0x402E67A")]
		[FieldOffset(Offset = "0x68")]
		private DateTime m_timeLimit;

		// Token: 0x0402E67B RID: 190075
		[Token(Token = "0x402E67B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402E67C RID: 190076
		[Token(Token = "0x402E67C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderCountDownValue;

		// Token: 0x0402E67D RID: 190077
		[Token(Token = "0x402E67D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E67E RID: 190078
		[Token(Token = "0x402E67E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyCurrentGroup;

		// Token: 0x0402E67F RID: 190079
		[Token(Token = "0x402E67F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ApplyGroupWithIndex;

		// Token: 0x0402E680 RID: 190080
		[Token(Token = "0x402E680")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0402E681 RID: 190081
		[Token(Token = "0x402E681")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
