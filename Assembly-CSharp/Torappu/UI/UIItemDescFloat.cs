using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.ItemRepo;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200372A RID: 14122
	[Token(Token = "0x200372A")]
	public class UIItemDescFloat : PageSingleComponent
	{
		// Token: 0x060166DD RID: 91869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60166DD")]
		[Address(RVA = "0xEE9100", Offset = "0xEE7D00", VA = "0x180EE9100")]
		private UIItemDescFloat.ContentAlphaHandler _EnsureContentAlpha()
		{
			return null;
		}

		// Token: 0x170035C4 RID: 13764
		// (set) Token: 0x060166DE RID: 91870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035C4")]
		public RectTransform panelDescTextBound
		{
			[Token(Token = "0x60166DE")]
			[Address(RVA = "0xEEB5F0", Offset = "0xEEA1F0", VA = "0x180EEB5F0")]
			set
			{
			}
		}

		// Token: 0x170035C5 RID: 13765
		// (set) Token: 0x060166DF RID: 91871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035C5")]
		public Action<UIItemDescFloat.ClosePanelRequest> closePanelRequest
		{
			[Token(Token = "0x60166DF")]
			[Address(RVA = "0xEEB210", Offset = "0xEE9E10", VA = "0x180EEB210")]
			set
			{
			}
		}

		// Token: 0x170035C6 RID: 13766
		// (get) Token: 0x060166E0 RID: 91872 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060166E1 RID: 91873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035C6")]
		public Action onRouteToDropInfo
		{
			[Token(Token = "0x60166E0")]
			[Address(RVA = "0xEEB190", Offset = "0xEE9D90", VA = "0x180EEB190")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60166E1")]
			[Address(RVA = "0xEEB560", Offset = "0xEEA160", VA = "0x180EEB560")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170035C7 RID: 13767
		// (get) Token: 0x060166E2 RID: 91874 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060166E3 RID: 91875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035C7")]
		protected GameObject itemCardShadow
		{
			[Token(Token = "0x60166E2")]
			[Address(RVA = "0xEEB110", Offset = "0xEE9D10", VA = "0x180EEB110")]
			get
			{
				return null;
			}
			[Token(Token = "0x60166E3")]
			[Address(RVA = "0xEEB2A0", Offset = "0xEE9EA0", VA = "0x180EEB2A0")]
			set
			{
			}
		}

		// Token: 0x060166E4 RID: 91876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166E4")]
		[Address(RVA = "0xEE81B0", Offset = "0xEE6DB0", VA = "0x180EE81B0")]
		public void Render(UIItemDescViewModel viewModel, float scaling = 1f)
		{
		}

		// Token: 0x060166E5 RID: 91877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166E5")]
		[Address(RVA = "0xEE7E60", Offset = "0xEE6A60", VA = "0x180EE7E60")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060166E6 RID: 91878 RVA: 0x000913F8 File Offset: 0x0008F5F8
		[Token(Token = "0x60166E6")]
		[Address(RVA = "0xEE8CA0", Offset = "0xEE78A0", VA = "0x180EE8CA0")]
		private bool _CheckIfTargetInvalid()
		{
			return default(bool);
		}

		// Token: 0x060166E7 RID: 91879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166E7")]
		[Address(RVA = "0xEE9550", Offset = "0xEE8150", VA = "0x180EE9550")]
		private void _OnPanelHide()
		{
		}

		// Token: 0x060166E8 RID: 91880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166E8")]
		[Address(RVA = "0xEE9670", Offset = "0xEE8270", VA = "0x180EE9670")]
		private void _OnPanelShow()
		{
		}

		// Token: 0x060166E9 RID: 91881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166E9")]
		[Address(RVA = "0xEEA140", Offset = "0xEE8D40", VA = "0x180EEA140")]
		private void _RequestToClosePanel(bool isTargetValid)
		{
		}

		// Token: 0x060166EA RID: 91882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166EA")]
		[Address(RVA = "0xEE9A30", Offset = "0xEE8630", VA = "0x180EE9A30")]
		private void _OnRouteToStageDropInfo(UIItemDescFloatStageDropDetail.RouteTarget target)
		{
		}

		// Token: 0x060166EB RID: 91883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166EB")]
		[Address(RVA = "0xEE9770", Offset = "0xEE8370", VA = "0x180EE9770")]
		private void _OnRouteToRoomInfo(BuildingData.RoomType roomType, ItemBundle item)
		{
		}

		// Token: 0x060166EC RID: 91884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166EC")]
		[Address(RVA = "0xEE9C30", Offset = "0xEE8830", VA = "0x180EE9C30")]
		private void _OnRouteToVoucherRelationInfo(ItemUtil.ConsumableInfo voucherInfo, ItemType voucherType, UIItemDescFloatVoucherRelation.VoucherRouteFocus focus)
		{
		}

		// Token: 0x060166ED RID: 91885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166ED")]
		[Address(RVA = "0xEE9970", Offset = "0xEE8570", VA = "0x180EE9970")]
		private void _OnRouteToShopInfo(ItemData.ShopRelateInfo info)
		{
		}

		// Token: 0x060166EE RID: 91886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166EE")]
		[Address(RVA = "0xEE7D20", Offset = "0xEE6920", VA = "0x180EE7D20")]
		public void EventOnBlankClick()
		{
		}

		// Token: 0x060166EF RID: 91887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166EF")]
		[Address(RVA = "0xEE7FF0", Offset = "0xEE6BF0", VA = "0x180EE7FF0")]
		public static void RegisterFocusItemStatic(GameObject itemCard, UIItemViewModel itemModel)
		{
		}

		// Token: 0x060166F0 RID: 91888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166F0")]
		[Address(RVA = "0xEE80F0", Offset = "0xEE6CF0", VA = "0x180EE80F0")]
		public void RegisterFocusItem(GameObject itemCard, UIItemViewModel itemModel)
		{
		}

		// Token: 0x060166F1 RID: 91889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60166F1")]
		[Address(RVA = "0xEE7DA0", Offset = "0xEE69A0", VA = "0x180EE7DA0")]
		public CanvasGroup ExportAlphaHandler()
		{
			return null;
		}

		// Token: 0x060166F2 RID: 91890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166F2")]
		[Address(RVA = "0xEE9430", Offset = "0xEE8030", VA = "0x180EE9430")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060166F3 RID: 91891 RVA: 0x00091410 File Offset: 0x0008F610
		[Token(Token = "0x60166F3")]
		[Address(RVA = "0xEE94C0", Offset = "0xEE80C0", VA = "0x180EE94C0")]
		private bool _IsPanelShown()
		{
			return default(bool);
		}

		// Token: 0x060166F4 RID: 91892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60166F4")]
		[Address(RVA = "0xEEAD30", Offset = "0xEE9930", VA = "0x180EEAD30")]
		private IEnumerator _UpdateTransitionCoroutine(UIItemDescViewModel viewModel)
		{
			return null;
		}

		// Token: 0x060166F5 RID: 91893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60166F5")]
		[Address(RVA = "0xEEA1F0", Offset = "0xEE8DF0", VA = "0x180EEA1F0")]
		private IEnumerator _ShowPanelCorotuine(UIItemDescViewModel viewModel)
		{
			return null;
		}

		// Token: 0x060166F6 RID: 91894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60166F6")]
		[Address(RVA = "0xEE9370", Offset = "0xEE7F70", VA = "0x180EE9370")]
		private IEnumerator _HidePanelCoroutine()
		{
			return null;
		}

		// Token: 0x060166F7 RID: 91895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166F7")]
		[Address(RVA = "0xEEA5F0", Offset = "0xEE91F0", VA = "0x180EEA5F0")]
		private void _UpdateContent(UIItemDescViewModel descModel)
		{
		}

		// Token: 0x060166F8 RID: 91896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166F8")]
		[Address(RVA = "0xEE89C0", Offset = "0xEE75C0", VA = "0x180EE89C0")]
		public static void UpdateItemPackContent(UIItemViewModel itemModel, Transform packInfoContainer, ref ItemRepoItemPackContentView contentView)
		{
		}

		// Token: 0x060166F9 RID: 91897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166F9")]
		[Address(RVA = "0xEEA460", Offset = "0xEE9060", VA = "0x180EEA460")]
		private static void _TryInstantiatePackContentView(Transform packInfoContainer, ref ItemRepoItemPackContentView contentView)
		{
		}

		// Token: 0x060166FA RID: 91898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166FA")]
		[Address(RVA = "0xEEA8F0", Offset = "0xEE94F0", VA = "0x180EEA8F0")]
		private void _UpdateItemDropInfo(UIItemViewModel itemModel, UIItemDescViewModel descModel)
		{
		}

		// Token: 0x060166FB RID: 91899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166FB")]
		[Address(RVA = "0xEE9F10", Offset = "0xEE8B10", VA = "0x180EE9F10")]
		private void _RenderApSupplyTips(UIItemViewModel model)
		{
		}

		// Token: 0x060166FC RID: 91900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166FC")]
		private void _DestroyViews<ViewType>(IDictionary<string, ViewType> views) where ViewType : MonoBehaviour
		{
		}

		// Token: 0x060166FD RID: 91901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60166FD")]
		[Address(RVA = "0xEEAC70", Offset = "0xEE9870", VA = "0x180EEAC70")]
		private IEnumerator _UpdateLayout()
		{
			return null;
		}

		// Token: 0x060166FE RID: 91902 RVA: 0x00091428 File Offset: 0x0008F628
		[Token(Token = "0x60166FE")]
		[Address(RVA = "0xEE8F90", Offset = "0xEE7B90", VA = "0x180EE8F90")]
		private static bool _CheckIfTargetPosChanged(Vector2 initPos, Vector2 targetPos)
		{
			return default(bool);
		}

		// Token: 0x060166FF RID: 91903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166FF")]
		[Address(RVA = "0xEEA2E0", Offset = "0xEE8EE0", VA = "0x180EEA2E0")]
		private void _StartDataUpdateTransition(UIItemDescViewModel viewModel)
		{
		}

		// Token: 0x06016700 RID: 91904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016700")]
		[Address(RVA = "0xEE8690", Offset = "0xEE7290", VA = "0x180EE8690")]
		public static void RouteToStageDropInfo(UIItemDescFloatStageDropDetail.RouteTarget target)
		{
		}

		// Token: 0x06016701 RID: 91905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016701")]
		[Address(RVA = "0xEE8300", Offset = "0xEE6F00", VA = "0x180EE8300")]
		public static void RouteToRoomInfo(BuildingData.RoomType roomType, ItemBundle targetItem)
		{
		}

		// Token: 0x06016702 RID: 91906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016702")]
		[Address(RVA = "0xEE8430", Offset = "0xEE7030", VA = "0x180EE8430")]
		public static void RouteToShop(ItemData.ShopRelateInfo shopInfo)
		{
		}

		// Token: 0x06016703 RID: 91907 RVA: 0x00091440 File Offset: 0x0008F640
		[Token(Token = "0x6016703")]
		[Address(RVA = "0xEE9280", Offset = "0xEE7E80", VA = "0x180EE9280")]
		private static ShopRouteTarget _GetShopRouteTargetByShopType(ItemDropShopType shopType)
		{
			return ShopRouteTarget.RECOMMENDSHOP;
		}

		// Token: 0x06016704 RID: 91908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016704")]
		[Address(RVA = "0xEE87B0", Offset = "0xEE73B0", VA = "0x180EE87B0")]
		public void RouteToVoucherRelationInfo(ItemUtil.ConsumableInfo voucherInfo, ItemType voucherType, UIItemDescFloatVoucherRelation.VoucherRouteFocus focus)
		{
		}

		// Token: 0x06016705 RID: 91909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016705")]
		[Address(RVA = "0xEE7F00", Offset = "0xEE6B00", VA = "0x180EE7F00")]
		public void OpenMaterialPage(ItemGetMaterialPage.Param param)
		{
		}

		// Token: 0x06016706 RID: 91910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016706")]
		[Address(RVA = "0xEEAEF0", Offset = "0xEE9AF0", VA = "0x180EEAEF0")]
		public UIItemDescFloat()
		{
		}

		// Token: 0x0401AFE4 RID: 110564
		[Token(Token = "0x401AFE4")]
		public const float TWEEN_DURATION = 0.2f;

		// Token: 0x0401AFE5 RID: 110565
		[Token(Token = "0x401AFE5")]
		private const float POS_CHANGE_DIS = 0.5f;

		// Token: 0x0401AFE6 RID: 110566
		[Token(Token = "0x401AFE6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ListSet<ItemType> DONT_SHOW_COUNT_ITEM_TYPES;

		// Token: 0x0401AFE7 RID: 110567
		[Token(Token = "0x401AFE7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("The common anchor position base of the managed views")]
		private RectTransform _panelLocal;

		// Token: 0x0401AFE8 RID: 110568
		[Token(Token = "0x401AFE8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _panelDescText;

		// Token: 0x0401AFE9 RID: 110569
		[Token(Token = "0x401AFE9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _panelItemCardContainer;

		// Token: 0x0401AFEA RID: 110570
		[Token(Token = "0x401AFEA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _raycastBlocker;

		// Token: 0x0401AFEB RID: 110571
		[Token(Token = "0x401AFEB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _paddingX;

		// Token: 0x0401AFEC RID: 110572
		[Token(Token = "0x401AFEC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x0401AFED RID: 110573
		[Token(Token = "0x401AFED")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textUsage;

		// Token: 0x0401AFEE RID: 110574
		[Token(Token = "0x401AFEE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0401AFEF RID: 110575
		[Token(Token = "0x401AFEF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _countPart;

		// Token: 0x0401AFF0 RID: 110576
		[Token(Token = "0x401AFF0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0401AFF1 RID: 110577
		[Token(Token = "0x401AFF1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x0401AFF2 RID: 110578
		[Token(Token = "0x401AFF2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backGround;

		// Token: 0x0401AFF3 RID: 110579
		[Token(Token = "0x401AFF3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Tooltip("Delta to make background be suitable for its content. Adjust this if background image chnaged.")]
		private float _backGroundDeltaY;

		// Token: 0x0401AFF4 RID: 110580
		[Token(Token = "0x401AFF4")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		[Tooltip("Max non-scroll size of \"pack info\" part. Adjust this when content layout rule changed.")]
		private float _packInfoMaxY;

		// Token: 0x0401AFF5 RID: 110581
		[Token(Token = "0x401AFF5")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Tooltip("Max non-scroll size of \"drop info\" part. Adjust this when content layout rule changed.")]
		private float _dropInfoMaxY;

		// Token: 0x0401AFF6 RID: 110582
		[Token(Token = "0x401AFF6")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Transform _packInfoContainer;

		// Token: 0x0401AFF7 RID: 110583
		[Token(Token = "0x401AFF7")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Transform _dropInfoContainer;

		// Token: 0x0401AFF8 RID: 110584
		[Token(Token = "0x401AFF8")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Transform _tipsContainer;

		// Token: 0x0401AFF9 RID: 110585
		[Token(Token = "0x401AFF9")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RectTransform _secondaryInfoPanel;

		// Token: 0x0401AFFA RID: 110586
		[Token(Token = "0x401AFFA")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private CancelDragIfFits _cancelContentDrag;

		// Token: 0x0401AFFB RID: 110587
		[Token(Token = "0x401AFFB")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("DisplayControl")]
		private CanvasGroup _contentAlphaHandler;

		// Token: 0x0401AFFC RID: 110588
		[Token(Token = "0x401AFFC")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("DisplayControl")]
		private CanvasGroup _contentSwitch;

		// Token: 0x0401AFFD RID: 110589
		[Token(Token = "0x401AFFD")]
		[FieldOffset(Offset = "0xC8")]
		private RectTransform m_panelDescTextBound;

		// Token: 0x0401AFFE RID: 110590
		[Token(Token = "0x401AFFE")]
		[FieldOffset(Offset = "0xD0")]
		private GameObject m_apSupplyTips;

		// Token: 0x0401AFFF RID: 110591
		[Token(Token = "0x401AFFF")]
		[FieldOffset(Offset = "0xD8")]
		private Action m_closePanelRequestImpl;

		// Token: 0x0401B000 RID: 110592
		[Token(Token = "0x401B000")]
		[FieldOffset(Offset = "0xE0")]
		private Action<UIItemDescFloat.ClosePanelRequest> m_closePanelRequest;

		// Token: 0x0401B001 RID: 110593
		[Token(Token = "0x401B001")]
		[FieldOffset(Offset = "0xE8")]
		private float m_itemCardScaling;

		// Token: 0x0401B002 RID: 110594
		[Token(Token = "0x401B002")]
		[FieldOffset(Offset = "0xF0")]
		private TargetPosCalculator m_calcTargetPos;

		// Token: 0x0401B003 RID: 110595
		[Token(Token = "0x401B003")]
		[FieldOffset(Offset = "0xF8")]
		private ListDict<string, UIItemDescFloatStageDropDetail> m_zoneDropList;

		// Token: 0x0401B004 RID: 110596
		[Token(Token = "0x401B004")]
		[FieldOffset(Offset = "0x100")]
		private ListDict<string, UIItemDescFloatStageDropDetail> m_stageDropList;

		// Token: 0x0401B005 RID: 110597
		[Token(Token = "0x401B005")]
		[FieldOffset(Offset = "0x108")]
		private ListDict<string, UIItemDescFloatBuildingProduct> m_buildingProductList;

		// Token: 0x0401B006 RID: 110598
		[Token(Token = "0x401B006")]
		[FieldOffset(Offset = "0x110")]
		private List<string> m_campaignStages;

		// Token: 0x0401B007 RID: 110599
		[Token(Token = "0x401B007")]
		[FieldOffset(Offset = "0x118")]
		private bool m_dropInfoInitFlag;

		// Token: 0x0401B008 RID: 110600
		[Token(Token = "0x401B008")]
		[FieldOffset(Offset = "0x120")]
		private ItemRepoDropInfoView m_dropItemInfo;

		// Token: 0x0401B009 RID: 110601
		[Token(Token = "0x401B009")]
		[FieldOffset(Offset = "0x128")]
		private ItemRepoItemPackContentView m_itemPackContent;

		// Token: 0x0401B00A RID: 110602
		[Token(Token = "0x401B00A")]
		[FieldOffset(Offset = "0x130")]
		private UIItemDescFloat.ContentAlphaHandler m_contentAlphaHandler;

		// Token: 0x0401B00C RID: 110604
		[Token(Token = "0x401B00C")]
		[FieldOffset(Offset = "0x140")]
		private GameObject m_itemCardCache;

		// Token: 0x0401B00D RID: 110605
		[Token(Token = "0x401B00D")]
		[FieldOffset(Offset = "0x148")]
		private UIItemViewModel m_itemModelCache;

		// Token: 0x0401B00E RID: 110606
		[Token(Token = "0x401B00E")]
		[FieldOffset(Offset = "0x150")]
		private GameObject m_itemCardShadow;

		// Token: 0x0401B00F RID: 110607
		[Token(Token = "0x401B00F")]
		[FieldOffset(Offset = "0x158")]
		private Vector2 m_itemInitPos;

		// Token: 0x0401B010 RID: 110608
		[Token(Token = "0x401B010")]
		[FieldOffset(Offset = "0x160")]
		private UIItemDescViewModel m_pendDataChange;

		// Token: 0x0401B011 RID: 110609
		[Token(Token = "0x401B011")]
		[FieldOffset(Offset = "0x168")]
		private bool m_isInited;

		// Token: 0x0401B012 RID: 110610
		[Token(Token = "0x401B012")]
		[FieldOffset(Offset = "0x169")]
		private bool m_isTransiting;

		// Token: 0x0401B013 RID: 110611
		[Token(Token = "0x401B013")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureContentAlpha;

		// Token: 0x0401B014 RID: 110612
		[Token(Token = "0x401B014")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_panelDescTextBound;

		// Token: 0x0401B015 RID: 110613
		[Token(Token = "0x401B015")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_closePanelRequest;

		// Token: 0x0401B016 RID: 110614
		[Token(Token = "0x401B016")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onRouteToDropInfo;

		// Token: 0x0401B017 RID: 110615
		[Token(Token = "0x401B017")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onRouteToDropInfo;

		// Token: 0x0401B018 RID: 110616
		[Token(Token = "0x401B018")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_itemCardShadow;

		// Token: 0x0401B019 RID: 110617
		[Token(Token = "0x401B019")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_itemCardShadow;

		// Token: 0x0401B01A RID: 110618
		[Token(Token = "0x401B01A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401B01B RID: 110619
		[Token(Token = "0x401B01B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x0401B01C RID: 110620
		[Token(Token = "0x401B01C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckIfTargetInvalid;

		// Token: 0x0401B01D RID: 110621
		[Token(Token = "0x401B01D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnPanelHide;

		// Token: 0x0401B01E RID: 110622
		[Token(Token = "0x401B01E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnPanelShow;

		// Token: 0x0401B01F RID: 110623
		[Token(Token = "0x401B01F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RequestToClosePanel;

		// Token: 0x0401B020 RID: 110624
		[Token(Token = "0x401B020")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnRouteToStageDropInfo;

		// Token: 0x0401B021 RID: 110625
		[Token(Token = "0x401B021")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnRouteToRoomInfo;

		// Token: 0x0401B022 RID: 110626
		[Token(Token = "0x401B022")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnRouteToVoucherRelationInfo;

		// Token: 0x0401B023 RID: 110627
		[Token(Token = "0x401B023")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnRouteToShopInfo;

		// Token: 0x0401B024 RID: 110628
		[Token(Token = "0x401B024")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_EventOnBlankClick;

		// Token: 0x0401B025 RID: 110629
		[Token(Token = "0x401B025")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_RegisterFocusItemStatic;

		// Token: 0x0401B026 RID: 110630
		[Token(Token = "0x401B026")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_RegisterFocusItem;

		// Token: 0x0401B027 RID: 110631
		[Token(Token = "0x401B027")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_ExportAlphaHandler;

		// Token: 0x0401B028 RID: 110632
		[Token(Token = "0x401B028")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401B029 RID: 110633
		[Token(Token = "0x401B029")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__IsPanelShown;

		// Token: 0x0401B02A RID: 110634
		[Token(Token = "0x401B02A")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__UpdateTransitionCoroutine;

		// Token: 0x0401B02B RID: 110635
		[Token(Token = "0x401B02B")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__ShowPanelCorotuine;

		// Token: 0x0401B02C RID: 110636
		[Token(Token = "0x401B02C")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__HidePanelCoroutine;

		// Token: 0x0401B02D RID: 110637
		[Token(Token = "0x401B02D")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__UpdateContent;

		// Token: 0x0401B02E RID: 110638
		[Token(Token = "0x401B02E")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_UpdateItemPackContent;

		// Token: 0x0401B02F RID: 110639
		[Token(Token = "0x401B02F")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__TryInstantiatePackContentView;

		// Token: 0x0401B030 RID: 110640
		[Token(Token = "0x401B030")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__UpdateItemDropInfo;

		// Token: 0x0401B031 RID: 110641
		[Token(Token = "0x401B031")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__RenderApSupplyTips;

		// Token: 0x0401B032 RID: 110642
		[Token(Token = "0x401B032")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__DestroyViews;

		// Token: 0x0401B033 RID: 110643
		[Token(Token = "0x401B033")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__UpdateLayout;

		// Token: 0x0401B034 RID: 110644
		[Token(Token = "0x401B034")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__CheckIfTargetPosChanged;

		// Token: 0x0401B035 RID: 110645
		[Token(Token = "0x401B035")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__StartDataUpdateTransition;

		// Token: 0x0401B036 RID: 110646
		[Token(Token = "0x401B036")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_RouteToStageDropInfo;

		// Token: 0x0401B037 RID: 110647
		[Token(Token = "0x401B037")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_RouteToRoomInfo;

		// Token: 0x0401B038 RID: 110648
		[Token(Token = "0x401B038")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_RouteToShop;

		// Token: 0x0401B039 RID: 110649
		[Token(Token = "0x401B039")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__GetShopRouteTargetByShopType;

		// Token: 0x0401B03A RID: 110650
		[Token(Token = "0x401B03A")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_RouteToVoucherRelationInfo;

		// Token: 0x0401B03B RID: 110651
		[Token(Token = "0x401B03B")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_OpenMaterialPage;

		// Token: 0x0401B03C RID: 110652
		[Token(Token = "0x401B03C")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200372B RID: 14123
		[Token(Token = "0x200372B")]
		public interface IItemCard : IHotfixable
		{
			// Token: 0x170035C8 RID: 13768
			// (get) Token: 0x06016708 RID: 91912
			// (set) Token: 0x06016709 RID: 91913
			[Token(Token = "0x170035C8")]
			bool isCardClickable { [Token(Token = "0x6016708")] get; [Token(Token = "0x6016709")] set; }
		}

		// Token: 0x0200372C RID: 14124
		[Token(Token = "0x200372C")]
		private class ContentAlphaHandler : IHotfixable
		{
			// Token: 0x0601670A RID: 91914 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601670A")]
			[Address(RVA = "0xED9190", Offset = "0xED7D90", VA = "0x180ED9190")]
			public ContentAlphaHandler(CanvasGroup canvasGroup)
			{
			}

			// Token: 0x0601670B RID: 91915 RVA: 0x00091458 File Offset: 0x0008F658
			[Token(Token = "0x601670B")]
			[Address(RVA = "0xED9100", Offset = "0xED7D00", VA = "0x180ED9100")]
			private bool _CheckIfValid()
			{
				return default(bool);
			}

			// Token: 0x0601670C RID: 91916 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601670C")]
			[Address(RVA = "0xED8FC0", Offset = "0xED7BC0", VA = "0x180ED8FC0")]
			public void SetAlpha(float alpha)
			{
			}

			// Token: 0x0601670D RID: 91917 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601670D")]
			[Address(RVA = "0xED9050", Offset = "0xED7C50", VA = "0x180ED9050")]
			public IEnumerator ShowCoroutine()
			{
				return null;
			}

			// Token: 0x0601670E RID: 91918 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601670E")]
			[Address(RVA = "0xED8F10", Offset = "0xED7B10", VA = "0x180ED8F10")]
			public IEnumerator HideCoroutine()
			{
				return null;
			}

			// Token: 0x0601670F RID: 91919 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601670F")]
			[Address(RVA = "0xED8EB0", Offset = "0xED7AB0", VA = "0x180ED8EB0")]
			public CanvasGroup Disable()
			{
				return null;
			}

			// Token: 0x0401B03D RID: 110653
			[Token(Token = "0x401B03D")]
			[FieldOffset(Offset = "0x10")]
			private CanvasGroup m_canvasGroup;

			// Token: 0x0401B03E RID: 110654
			[Token(Token = "0x401B03E")]
			[FieldOffset(Offset = "0x18")]
			private bool m_isEnabled;

			// Token: 0x0401B03F RID: 110655
			[Token(Token = "0x401B03F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401B040 RID: 110656
			[Token(Token = "0x401B040")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__CheckIfValid;

			// Token: 0x0401B041 RID: 110657
			[Token(Token = "0x401B041")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_SetAlpha;

			// Token: 0x0401B042 RID: 110658
			[Token(Token = "0x401B042")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ShowCoroutine;

			// Token: 0x0401B043 RID: 110659
			[Token(Token = "0x401B043")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_HideCoroutine;

			// Token: 0x0401B044 RID: 110660
			[Token(Token = "0x401B044")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Disable;
		}

		// Token: 0x0200372F RID: 14127
		[Token(Token = "0x200372F")]
		public struct ClosePanelRequest
		{
			// Token: 0x0401B04D RID: 110669
			[Token(Token = "0x401B04D")]
			[FieldOffset(Offset = "0x0")]
			public bool isTargetValid;
		}
	}
}
