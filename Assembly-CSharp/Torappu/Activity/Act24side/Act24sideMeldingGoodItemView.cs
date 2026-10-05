using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075AA RID: 30122
	[Token(Token = "0x20075AA")]
	public class Act24sideMeldingGoodItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A62D RID: 173613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A62D")]
		[Address(RVA = "0x260C6D0", Offset = "0x260B2D0", VA = "0x18260C6D0")]
		public void Render(Act24sideMeldingGoodItemViewModel model)
		{
		}

		// Token: 0x0602A62E RID: 173614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A62E")]
		[Address(RVA = "0x260D1A0", Offset = "0x260BDA0", VA = "0x18260D1A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A62F RID: 173615 RVA: 0x000D8390 File Offset: 0x000D6590
		[Token(Token = "0x602A62F")]
		[Address(RVA = "0x260D090", Offset = "0x260BC90", VA = "0x18260D090")]
		private Color _GetRemainBgCol(bool isAllConsumed, string remainBgCol)
		{
			return default(Color);
		}

		// Token: 0x0602A630 RID: 173616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A630")]
		[Address(RVA = "0x260D470", Offset = "0x260C070", VA = "0x18260D470")]
		private void _UpdateReplicateInfo(Act24sideMeldingGoodItemViewModel model)
		{
		}

		// Token: 0x0602A631 RID: 173617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A631")]
		[Address(RVA = "0x260CE50", Offset = "0x260BA50", VA = "0x18260CE50")]
		private UIItemCard _EnsureRepItemCard()
		{
			return null;
		}

		// Token: 0x0602A632 RID: 173618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A632")]
		[Address(RVA = "0x260D2A0", Offset = "0x260BEA0", VA = "0x18260D2A0")]
		private void _OnClickItemButton(int index)
		{
		}

		// Token: 0x0602A633 RID: 173619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A633")]
		[Address(RVA = "0x260D360", Offset = "0x260BF60", VA = "0x18260D360")]
		private void _OnClickRepItemButton(int index)
		{
		}

		// Token: 0x0602A634 RID: 173620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A634")]
		[Address(RVA = "0x260D7C0", Offset = "0x260C3C0", VA = "0x18260D7C0")]
		public Act24sideMeldingGoodItemView()
		{
		}

		// Token: 0x0403CFBF RID: 249791
		[Token(Token = "0x403CFBF")]
		private const string ANIM_PARM = "replicate_shining";

		// Token: 0x0403CFC0 RID: 249792
		[Token(Token = "0x403CFC0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0403CFC1 RID: 249793
		[Token(Token = "0x403CFC1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _repItemContainer;

		// Token: 0x0403CFC2 RID: 249794
		[Token(Token = "0x403CFC2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelRepIcon;

		// Token: 0x0403CFC3 RID: 249795
		[Token(Token = "0x403CFC3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0403CFC4 RID: 249796
		[Token(Token = "0x403CFC4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtRemainCount;

		// Token: 0x0403CFC5 RID: 249797
		[Token(Token = "0x403CFC5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasAllConsumedMask;

		// Token: 0x0403CFC6 RID: 249798
		[Token(Token = "0x403CFC6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Changed with Color. For act24side")]
		private Graphic _imgHasCountBg;

		// Token: 0x0403CFC7 RID: 249799
		[Token(Token = "0x403CFC7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Changed with gameObject. For act50side")]
		private GameObject _objOnSell;

		// Token: 0x0403CFC8 RID: 249800
		[Token(Token = "0x403CFC8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Changed with gameObject. For act50side")]
		private GameObject _objOutOfSell;

		// Token: 0x0403CFC9 RID: 249801
		[Token(Token = "0x403CFC9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AnimationWrapper _replicateObj;

		// Token: 0x0403CFCA RID: 249802
		[Token(Token = "0x403CFCA")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x0403CFCB RID: 249803
		[Token(Token = "0x403CFCB")]
		[FieldOffset(Offset = "0x70")]
		private UIItemCard m_itemCard;

		// Token: 0x0403CFCC RID: 249804
		[Token(Token = "0x403CFCC")]
		[FieldOffset(Offset = "0x78")]
		private UIItemViewModel m_itemModel;

		// Token: 0x0403CFCD RID: 249805
		[Token(Token = "0x403CFCD")]
		[FieldOffset(Offset = "0x80")]
		private UIItemCard m_repItemCard;

		// Token: 0x0403CFCE RID: 249806
		[Token(Token = "0x403CFCE")]
		[FieldOffset(Offset = "0x88")]
		private UIItemViewModel m_repItemModel;

		// Token: 0x0403CFCF RID: 249807
		[Token(Token = "0x403CFCF")]
		[FieldOffset(Offset = "0x90")]
		private FadeSwitchTween m_tweenAllComsumedMask;

		// Token: 0x0403CFD0 RID: 249808
		[Token(Token = "0x403CFD0")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isReplicate;

		// Token: 0x0403CFD1 RID: 249809
		[Token(Token = "0x403CFD1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string COL_COUNT_ALL_CONSUMED_BG;

		// Token: 0x0403CFD2 RID: 249810
		[Token(Token = "0x403CFD2")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string UNLIMIT_TAG;

		// Token: 0x0403CFD3 RID: 249811
		[Token(Token = "0x403CFD3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CFD4 RID: 249812
		[Token(Token = "0x403CFD4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CFD5 RID: 249813
		[Token(Token = "0x403CFD5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetRemainBgCol;

		// Token: 0x0403CFD6 RID: 249814
		[Token(Token = "0x403CFD6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateReplicateInfo;

		// Token: 0x0403CFD7 RID: 249815
		[Token(Token = "0x403CFD7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EnsureRepItemCard;

		// Token: 0x0403CFD8 RID: 249816
		[Token(Token = "0x403CFD8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnClickItemButton;

		// Token: 0x0403CFD9 RID: 249817
		[Token(Token = "0x403CFD9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnClickRepItemButton;

		// Token: 0x0403CFDA RID: 249818
		[Token(Token = "0x403CFDA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
