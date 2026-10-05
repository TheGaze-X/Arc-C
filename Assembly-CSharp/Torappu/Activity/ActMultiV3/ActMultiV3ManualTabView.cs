using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F55 RID: 28501
	[Token(Token = "0x2006F55")]
	public class ActMultiV3ManualTabView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060287A2 RID: 165794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287A2")]
		[Address(RVA = "0x23C73E0", Offset = "0x23C5FE0", VA = "0x1823C73E0")]
		public void Render(ActMultiV3ManualViewModel model)
		{
		}

		// Token: 0x060287A3 RID: 165795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287A3")]
		[Address(RVA = "0x23C7300", Offset = "0x23C5F00", VA = "0x1823C7300")]
		public void OnClickTab()
		{
		}

		// Token: 0x060287A4 RID: 165796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287A4")]
		[Address(RVA = "0x23C7760", Offset = "0x23C6360", VA = "0x1823C7760")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060287A5 RID: 165797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287A5")]
		[Address(RVA = "0x23C7910", Offset = "0x23C6510", VA = "0x1823C7910")]
		public ActMultiV3ManualTabView()
		{
		}

		// Token: 0x04039934 RID: 235828
		[Token(Token = "0x4039934")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _hotspotObj;

		// Token: 0x04039935 RID: 235829
		[Token(Token = "0x4039935")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _selectAnimLocation;

		// Token: 0x04039936 RID: 235830
		[Token(Token = "0x4039936")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ActMultiV3TabContentAbstractView _view;

		// Token: 0x04039937 RID: 235831
		[Token(Token = "0x4039937")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ManualTabType _tabType;

		// Token: 0x04039938 RID: 235832
		[Token(Token = "0x4039938")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _trackPointContainer;

		// Token: 0x04039939 RID: 235833
		[Token(Token = "0x4039939")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _trackPointObj;

		// Token: 0x0403993A RID: 235834
		[Token(Token = "0x403993A")]
		[FieldOffset(Offset = "0x50")]
		private bool m_inited;

		// Token: 0x0403993B RID: 235835
		[Token(Token = "0x403993B")]
		[FieldOffset(Offset = "0x54")]
		private int m_cachedInitSeqNum;

		// Token: 0x0403993C RID: 235836
		[Token(Token = "0x403993C")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403993D RID: 235837
		[Token(Token = "0x403993D")]
		[FieldOffset(Offset = "0x68")]
		private UISwitchTween m_selectTween;

		// Token: 0x0403993E RID: 235838
		[Token(Token = "0x403993E")]
		[FieldOffset(Offset = "0x70")]
		private GameObject m_trackPoint;

		// Token: 0x0403993F RID: 235839
		[Token(Token = "0x403993F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039940 RID: 235840
		[Token(Token = "0x4039940")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickTab;

		// Token: 0x04039941 RID: 235841
		[Token(Token = "0x4039941")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039942 RID: 235842
		[Token(Token = "0x4039942")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
