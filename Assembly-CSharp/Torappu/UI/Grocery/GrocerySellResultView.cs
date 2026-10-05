using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D1A RID: 19738
	[Token(Token = "0x2004D1A")]
	public class GrocerySellResultView : DataBinder<GrocerySellResultProperty>, IHotfixable
	{
		// Token: 0x17004574 RID: 17780
		// (get) Token: 0x0601D934 RID: 121140 RVA: 0x000AC020 File Offset: 0x000AA220
		[Token(Token = "0x17004574")]
		public int ringCount
		{
			[Token(Token = "0x601D934")]
			[Address(RVA = "0x1732D00", Offset = "0x1731900", VA = "0x181732D00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601D935 RID: 121141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D935")]
		[Address(RVA = "0x1732200", Offset = "0x1730E00", VA = "0x181732200", Slot = "7")]
		public override void OnValueChanged(GrocerySellResultProperty property)
		{
		}

		// Token: 0x0601D936 RID: 121142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D936")]
		[Address(RVA = "0x1732170", Offset = "0x1730D70", VA = "0x181732170")]
		public void OnNextClicked()
		{
		}

		// Token: 0x0601D937 RID: 121143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D937")]
		[Address(RVA = "0x1732690", Offset = "0x1731290", VA = "0x181732690")]
		public void PlayDiagramTweenWithIndex(int index, float duration)
		{
		}

		// Token: 0x0601D938 RID: 121144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D938")]
		[Address(RVA = "0x17327F0", Offset = "0x17313F0", VA = "0x1817327F0")]
		public void PlayTextTween(float duration)
		{
		}

		// Token: 0x0601D939 RID: 121145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D939")]
		[Address(RVA = "0x17328A0", Offset = "0x17314A0", VA = "0x1817328A0")]
		public IEnumerator ResetDiagramTweenAtBegin()
		{
			return null;
		}

		// Token: 0x0601D93A RID: 121146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D93A")]
		[Address(RVA = "0x1732950", Offset = "0x1731550", VA = "0x181732950")]
		public IEnumerator ResetTextTweenAtBegin()
		{
			return null;
		}

		// Token: 0x0601D93B RID: 121147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D93B")]
		[Address(RVA = "0x1732A00", Offset = "0x1731600", VA = "0x181732A00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D93C RID: 121148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D93C")]
		[Address(RVA = "0x1732BE0", Offset = "0x17317E0", VA = "0x181732BE0")]
		public GrocerySellResultView()
		{
		}

		// Token: 0x040270DE RID: 159966
		[Token(Token = "0x40270DE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _sellStateIcons;

		// Token: 0x040270DF RID: 159967
		[Token(Token = "0x40270DF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _goodIcon;

		// Token: 0x040270E0 RID: 159968
		[Token(Token = "0x40270E0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GrocerySellResultDiagramRingItem[] _rings;

		// Token: 0x040270E1 RID: 159969
		[Token(Token = "0x40270E1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GrocerySellSpacingTextItem _totalIncomeText;

		// Token: 0x040270E2 RID: 159970
		[Token(Token = "0x40270E2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GrocerySellResultRankItem _rankItemPrefab;

		// Token: 0x040270E3 RID: 159971
		[Token(Token = "0x40270E3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform[] _rankItemParents;

		// Token: 0x040270E4 RID: 159972
		[Token(Token = "0x40270E4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TwoStateToggle _nextButtonToggle;

		// Token: 0x040270E5 RID: 159973
		[Token(Token = "0x40270E5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _sellGoodNameText;

		// Token: 0x040270E6 RID: 159974
		[Token(Token = "0x40270E6")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040270E7 RID: 159975
		[Token(Token = "0x40270E7")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x040270E8 RID: 159976
		[Token(Token = "0x40270E8")]
		[FieldOffset(Offset = "0x78")]
		private List<GrocerySellResultRankItem> m_rankItems;

		// Token: 0x040270E9 RID: 159977
		[Token(Token = "0x40270E9")]
		[FieldOffset(Offset = "0x80")]
		private List<Tween> m_ringTweens;

		// Token: 0x040270EA RID: 159978
		[Token(Token = "0x40270EA")]
		[FieldOffset(Offset = "0x88")]
		private GrocerySellResultTextTween m_incomeTween;

		// Token: 0x040270EB RID: 159979
		[Token(Token = "0x40270EB")]
		[FieldOffset(Offset = "0x90")]
		private List<GrocerySellResultStateSellViewModel.SellInfo> m_cachedSellInfo;

		// Token: 0x040270EC RID: 159980
		[Token(Token = "0x40270EC")]
		[FieldOffset(Offset = "0x98")]
		private int m_cachedTotalIncome;

		// Token: 0x040270ED RID: 159981
		[Token(Token = "0x40270ED")]
		[FieldOffset(Offset = "0x9C")]
		private int m_cachedPlayerTotalIncome;

		// Token: 0x040270EE RID: 159982
		[Token(Token = "0x40270EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ringCount;

		// Token: 0x040270EF RID: 159983
		[Token(Token = "0x40270EF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040270F0 RID: 159984
		[Token(Token = "0x40270F0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnNextClicked;

		// Token: 0x040270F1 RID: 159985
		[Token(Token = "0x40270F1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PlayDiagramTweenWithIndex;

		// Token: 0x040270F2 RID: 159986
		[Token(Token = "0x40270F2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PlayTextTween;

		// Token: 0x040270F3 RID: 159987
		[Token(Token = "0x40270F3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ResetDiagramTweenAtBegin;

		// Token: 0x040270F4 RID: 159988
		[Token(Token = "0x40270F4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ResetTextTweenAtBegin;

		// Token: 0x040270F5 RID: 159989
		[Token(Token = "0x40270F5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040270F6 RID: 159990
		[Token(Token = "0x40270F6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
