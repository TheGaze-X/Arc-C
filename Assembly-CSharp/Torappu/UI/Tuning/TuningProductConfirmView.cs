using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003D06 RID: 15622
	[Token(Token = "0x2003D06")]
	public class TuningProductConfirmView : DataBinder<TuningProductConfirmProperty>
	{
		// Token: 0x060185CD RID: 99789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185CD")]
		[Address(RVA = "0x10E1B80", Offset = "0x10E0780", VA = "0x1810E1B80", Slot = "7")]
		public override void OnValueChanged(TuningProductConfirmProperty property)
		{
		}

		// Token: 0x060185CE RID: 99790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185CE")]
		[Address(RVA = "0x10E2130", Offset = "0x10E0D30", VA = "0x1810E2130")]
		private void _RenderCircle(TuningProductConfirmViewModel model)
		{
		}

		// Token: 0x060185CF RID: 99791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185CF")]
		[Address(RVA = "0x10E23C0", Offset = "0x10E0FC0", VA = "0x1810E23C0")]
		private void _RenderDesc(TuningProductConfirmViewModel model)
		{
		}

		// Token: 0x060185D0 RID: 99792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185D0")]
		[Address(RVA = "0x10E2860", Offset = "0x10E1460", VA = "0x1810E2860")]
		private void _RenderEye(Act29SideData.Act29SideProductType productType)
		{
		}

		// Token: 0x060185D1 RID: 99793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185D1")]
		[Address(RVA = "0x10E29B0", Offset = "0x10E15B0", VA = "0x1810E29B0")]
		private void _ResetEye()
		{
		}

		// Token: 0x060185D2 RID: 99794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185D2")]
		[Address(RVA = "0x10E1AF0", Offset = "0x10E06F0", VA = "0x1810E1AF0")]
		public void OnClickBackgroundBtn()
		{
		}

		// Token: 0x060185D3 RID: 99795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185D3")]
		[Address(RVA = "0x10E2AD0", Offset = "0x10E16D0", VA = "0x1810E2AD0")]
		public TuningProductConfirmView()
		{
		}

		// Token: 0x0401DC84 RID: 121988
		[Token(Token = "0x401DC84")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Circle")]
		private TuningProductCircleView _circleView;

		// Token: 0x0401DC85 RID: 121989
		[Token(Token = "0x401DC85")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Circle")]
		private Color _circleColor;

		// Token: 0x0401DC86 RID: 121990
		[Token(Token = "0x401DC86")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Circle")]
		private List<TuningProductOrcheSelectView.OrcheTypeToFormEffectView> _orcheIdToFormEffectViewList;

		// Token: 0x0401DC87 RID: 121991
		[Token(Token = "0x401DC87")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Desc")]
		private Text _productTypeName;

		// Token: 0x0401DC88 RID: 121992
		[Token(Token = "0x401DC88")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Desc")]
		private Text _orcheName;

		// Token: 0x0401DC89 RID: 121993
		[Token(Token = "0x401DC89")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Desc")]
		private Text _formDesc;

		// Token: 0x0401DC8A RID: 121994
		[Token(Token = "0x401DC8A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Desc")]
		private Text _formDescFrontBracket;

		// Token: 0x0401DC8B RID: 121995
		[Token(Token = "0x401DC8B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Desc")]
		private Text _formDescBehindBracket;

		// Token: 0x0401DC8C RID: 121996
		[Token(Token = "0x401DC8C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Desc")]
		private GameObject _formObj;

		// Token: 0x0401DC8D RID: 121997
		[Token(Token = "0x401DC8D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Desc")]
		private GameObject _orcheObj;

		// Token: 0x0401DC8E RID: 121998
		[Token(Token = "0x401DC8E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _isNewProductTypeObj;

		// Token: 0x0401DC8F RID: 121999
		[Token(Token = "0x401DC8F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<TuningProductView.ProductEyeTypeToView> _productEyeToViewList;

		// Token: 0x0401DC90 RID: 122000
		[Token(Token = "0x401DC90")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Card")]
		private Transform _cardHolder;

		// Token: 0x0401DC91 RID: 122001
		[Token(Token = "0x401DC91")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Card")]
		private TuningCommonCard _commonCardPrefab;

		// Token: 0x0401DC92 RID: 122002
		[Token(Token = "0x401DC92")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Card")]
		private float _cardScaler;

		// Token: 0x0401DC93 RID: 122003
		[Token(Token = "0x401DC93")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAtlasImage _tintImg;

		// Token: 0x0401DC94 RID: 122004
		[Token(Token = "0x401DC94")]
		[FieldOffset(Offset = "0xA8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401DC95 RID: 122005
		[Token(Token = "0x401DC95")]
		[FieldOffset(Offset = "0xB8")]
		private int m_cachedEnterSequenceNum;

		// Token: 0x0401DC96 RID: 122006
		[Token(Token = "0x401DC96")]
		[FieldOffset(Offset = "0xC0")]
		private TuningCommonCard m_commonCard;

		// Token: 0x0401DC97 RID: 122007
		[Token(Token = "0x401DC97")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401DC98 RID: 122008
		[Token(Token = "0x401DC98")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderCircle;

		// Token: 0x0401DC99 RID: 122009
		[Token(Token = "0x401DC99")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderDesc;

		// Token: 0x0401DC9A RID: 122010
		[Token(Token = "0x401DC9A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderEye;

		// Token: 0x0401DC9B RID: 122011
		[Token(Token = "0x401DC9B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ResetEye;

		// Token: 0x0401DC9C RID: 122012
		[Token(Token = "0x401DC9C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClickBackgroundBtn;

		// Token: 0x0401DC9D RID: 122013
		[Token(Token = "0x401DC9D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
