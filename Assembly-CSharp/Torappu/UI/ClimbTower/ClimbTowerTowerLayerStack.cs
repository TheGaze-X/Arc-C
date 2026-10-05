using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CBC RID: 23740
	[Token(Token = "0x2005CBC")]
	public class ClimbTowerTowerLayerStack : MonoBehaviour, ILayoutElement, IHotfixable
	{
		// Token: 0x170050BE RID: 20670
		// (get) Token: 0x060225B9 RID: 140729 RVA: 0x000BD1F8 File Offset: 0x000BB3F8
		[Token(Token = "0x170050BE")]
		public float minWidth
		{
			[Token(Token = "0x60225B9")]
			[Address(RVA = "0x1CDA1D0", Offset = "0x1CD8DD0", VA = "0x181CDA1D0", Slot = "6")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170050BF RID: 20671
		// (get) Token: 0x060225BA RID: 140730 RVA: 0x000BD210 File Offset: 0x000BB410
		[Token(Token = "0x170050BF")]
		public float minHeight
		{
			[Token(Token = "0x60225BA")]
			[Address(RVA = "0x1CDA170", Offset = "0x1CD8D70", VA = "0x181CDA170", Slot = "9")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170050C0 RID: 20672
		// (get) Token: 0x060225BB RID: 140731 RVA: 0x000BD228 File Offset: 0x000BB428
		[Token(Token = "0x170050C0")]
		public float flexibleWidth
		{
			[Token(Token = "0x60225BB")]
			[Address(RVA = "0x1CDA050", Offset = "0x1CD8C50", VA = "0x181CDA050", Slot = "8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170050C1 RID: 20673
		// (get) Token: 0x060225BC RID: 140732 RVA: 0x000BD240 File Offset: 0x000BB440
		[Token(Token = "0x170050C1")]
		public float flexibleHeight
		{
			[Token(Token = "0x60225BC")]
			[Address(RVA = "0x1CD9FF0", Offset = "0x1CD8BF0", VA = "0x181CD9FF0", Slot = "11")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170050C2 RID: 20674
		// (get) Token: 0x060225BD RID: 140733 RVA: 0x000BD258 File Offset: 0x000BB458
		[Token(Token = "0x170050C2")]
		public int layoutPriority
		{
			[Token(Token = "0x60225BD")]
			[Address(RVA = "0x1CDA110", Offset = "0x1CD8D10", VA = "0x181CDA110", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170050C3 RID: 20675
		// (get) Token: 0x060225BE RID: 140734 RVA: 0x000BD270 File Offset: 0x000BB470
		[Token(Token = "0x170050C3")]
		public float preferredWidth
		{
			[Token(Token = "0x60225BE")]
			[Address(RVA = "0x1CDA290", Offset = "0x1CD8E90", VA = "0x181CDA290", Slot = "7")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170050C4 RID: 20676
		// (get) Token: 0x060225BF RID: 140735 RVA: 0x000BD288 File Offset: 0x000BB488
		[Token(Token = "0x170050C4")]
		public float preferredHeight
		{
			[Token(Token = "0x60225BF")]
			[Address(RVA = "0x1CDA230", Offset = "0x1CD8E30", VA = "0x181CDA230", Slot = "10")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060225C0 RID: 140736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225C0")]
		[Address(RVA = "0x1CD8F50", Offset = "0x1CD7B50", VA = "0x181CD8F50", Slot = "4")]
		public void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x060225C1 RID: 140737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225C1")]
		[Address(RVA = "0x1CD8FB0", Offset = "0x1CD7BB0", VA = "0x181CD8FB0", Slot = "5")]
		public void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x170050C5 RID: 20677
		// (set) Token: 0x060225C2 RID: 140738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170050C5")]
		public ClimbTowerTowerLayerStackAdapter adapter
		{
			[Token(Token = "0x60225C2")]
			[Address(RVA = "0x1CDA2F0", Offset = "0x1CD8EF0", VA = "0x181CDA2F0")]
			set
			{
			}
		}

		// Token: 0x170050C6 RID: 20678
		// (get) Token: 0x060225C3 RID: 140739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170050C6")]
		public UIAtlasImage imgLayerBg
		{
			[Token(Token = "0x60225C3")]
			[Address(RVA = "0x1CDA0B0", Offset = "0x1CD8CB0", VA = "0x181CDA0B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060225C4 RID: 140740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225C4")]
		[Address(RVA = "0x1CD93A0", Offset = "0x1CD7FA0", VA = "0x181CD93A0")]
		private void _ObserveAdapterConstructed(ClimbTowerTowerLayerStackAdapter adapter)
		{
		}

		// Token: 0x060225C5 RID: 140741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225C5")]
		[Address(RVA = "0x1CD9420", Offset = "0x1CD8020", VA = "0x181CD9420")]
		private void _ObserverAdapterUpdated(ClimbTowerTowerLayerStackAdapter adapter)
		{
		}

		// Token: 0x060225C6 RID: 140742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225C6")]
		[Address(RVA = "0x1CD9010", Offset = "0x1CD7C10", VA = "0x181CD9010")]
		private void _ConstructViews()
		{
		}

		// Token: 0x060225C7 RID: 140743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225C7")]
		[Address(RVA = "0x1CD94A0", Offset = "0x1CD80A0", VA = "0x181CD94A0")]
		private void _RefreshViews()
		{
		}

		// Token: 0x060225C8 RID: 140744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225C8")]
		[Address(RVA = "0x1CD9750", Offset = "0x1CD8350", VA = "0x181CD9750")]
		private void _RenderArrow(bool fastMode)
		{
		}

		// Token: 0x060225C9 RID: 140745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225C9")]
		[Address(RVA = "0x1CD9CC0", Offset = "0x1CD88C0", VA = "0x181CD9CC0")]
		private void _RenderGodCardLayerTips()
		{
		}

		// Token: 0x060225CA RID: 140746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225CA")]
		[Address(RVA = "0x1CD9AF0", Offset = "0x1CD86F0", VA = "0x181CD9AF0")]
		private void _RenderBg()
		{
		}

		// Token: 0x060225CB RID: 140747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225CB")]
		[Address(RVA = "0x1CD9F90", Offset = "0x1CD8B90", VA = "0x181CD9F90")]
		public ClimbTowerTowerLayerStack()
		{
		}

		// Token: 0x0402F366 RID: 193382
		[Token(Token = "0x402F366")]
		private const float ARROW_MOVE_DURATION = 0.23f;

		// Token: 0x0402F367 RID: 193383
		[Token(Token = "0x402F367")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("layer")]
		private ClimbTowerLayerCard _prefabNormal;

		// Token: 0x0402F368 RID: 193384
		[Token(Token = "0x402F368")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("layer")]
		private ClimbTowerLayerCard _prefabSpecial;

		// Token: 0x0402F369 RID: 193385
		[Token(Token = "0x402F369")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("layer")]
		private ClimbTowerLayerCard _prefabBoss;

		// Token: 0x0402F36A RID: 193386
		[Token(Token = "0x402F36A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("layer")]
		private int _paddingTop;

		// Token: 0x0402F36B RID: 193387
		[Token(Token = "0x402F36B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Group("layer")]
		private int _paddingBottom;

		// Token: 0x0402F36C RID: 193388
		[Token(Token = "0x402F36C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("layer")]
		private RectTransform _transLayerCardHolder;

		// Token: 0x0402F36D RID: 193389
		[Token(Token = "0x402F36D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("layer bg")]
		private UIAtlasImage _imgLayerBg;

		// Token: 0x0402F36E RID: 193390
		[Token(Token = "0x402F36E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("layer bg")]
		private UIAtlasObject _layerBgAtlas;

		// Token: 0x0402F36F RID: 193391
		[Token(Token = "0x402F36F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("arrow")]
		private RectTransform _transArrowHolder;

		// Token: 0x0402F370 RID: 193392
		[Token(Token = "0x402F370")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("god card")]
		private int _paddingBeforeGod;

		// Token: 0x0402F371 RID: 193393
		[Token(Token = "0x402F371")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[Group("god card")]
		private int _godCardOffset;

		// Token: 0x0402F372 RID: 193394
		[Token(Token = "0x402F372")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("god card")]
		private RectTransform _transGodCardTipsHolder;

		// Token: 0x0402F373 RID: 193395
		[Token(Token = "0x402F373")]
		private const string TOWER_BG_PREFIX = "tower_bg{0}";

		// Token: 0x0402F374 RID: 193396
		[Token(Token = "0x402F374")]
		[FieldOffset(Offset = "0x68")]
		private float m_sizeOnAxis;

		// Token: 0x0402F375 RID: 193397
		[Token(Token = "0x402F375")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_arrowMoveTween;

		// Token: 0x0402F376 RID: 193398
		[Token(Token = "0x402F376")]
		[FieldOffset(Offset = "0x78")]
		private ClimbTowerTowerLayerBaseSelectArrow m_selectArrow;

		// Token: 0x0402F377 RID: 193399
		[Token(Token = "0x402F377")]
		[FieldOffset(Offset = "0x80")]
		private ClimbTowerTowerLayerBaseGodCardTips m_godCardTips;

		// Token: 0x0402F378 RID: 193400
		[Token(Token = "0x402F378")]
		[FieldOffset(Offset = "0x88")]
		private ClimbTowerTowerLayerStackAdapter m_adapter;

		// Token: 0x0402F379 RID: 193401
		[Token(Token = "0x402F379")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_minWidth;

		// Token: 0x0402F37A RID: 193402
		[Token(Token = "0x402F37A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_minHeight;

		// Token: 0x0402F37B RID: 193403
		[Token(Token = "0x402F37B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_flexibleWidth;

		// Token: 0x0402F37C RID: 193404
		[Token(Token = "0x402F37C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_flexibleHeight;

		// Token: 0x0402F37D RID: 193405
		[Token(Token = "0x402F37D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_layoutPriority;

		// Token: 0x0402F37E RID: 193406
		[Token(Token = "0x402F37E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_preferredWidth;

		// Token: 0x0402F37F RID: 193407
		[Token(Token = "0x402F37F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_preferredHeight;

		// Token: 0x0402F380 RID: 193408
		[Token(Token = "0x402F380")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CalculateLayoutInputHorizontal;

		// Token: 0x0402F381 RID: 193409
		[Token(Token = "0x402F381")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CalculateLayoutInputVertical;

		// Token: 0x0402F382 RID: 193410
		[Token(Token = "0x402F382")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_adapter;

		// Token: 0x0402F383 RID: 193411
		[Token(Token = "0x402F383")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_imgLayerBg;

		// Token: 0x0402F384 RID: 193412
		[Token(Token = "0x402F384")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ObserveAdapterConstructed;

		// Token: 0x0402F385 RID: 193413
		[Token(Token = "0x402F385")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ObserverAdapterUpdated;

		// Token: 0x0402F386 RID: 193414
		[Token(Token = "0x402F386")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ConstructViews;

		// Token: 0x0402F387 RID: 193415
		[Token(Token = "0x402F387")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__RefreshViews;

		// Token: 0x0402F388 RID: 193416
		[Token(Token = "0x402F388")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RenderArrow;

		// Token: 0x0402F389 RID: 193417
		[Token(Token = "0x402F389")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RenderGodCardLayerTips;

		// Token: 0x0402F38A RID: 193418
		[Token(Token = "0x402F38A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__RenderBg;

		// Token: 0x0402F38B RID: 193419
		[Token(Token = "0x402F38B")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
