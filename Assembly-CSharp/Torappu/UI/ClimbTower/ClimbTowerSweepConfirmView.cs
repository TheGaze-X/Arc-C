using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CAD RID: 23725
	[Token(Token = "0x2005CAD")]
	public class ClimbTowerSweepConfirmView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602256A RID: 140650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602256A")]
		[Address(RVA = "0x1CC2E00", Offset = "0x1CC1A00", VA = "0x181CC2E00")]
		public void Render(ClimbTowerViewModel viewModel)
		{
		}

		// Token: 0x0602256B RID: 140651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602256B")]
		[Address(RVA = "0x1CC3840", Offset = "0x1CC2440", VA = "0x181CC3840")]
		private void _RenderItemIcon(ItemData lowData, ItemData highData)
		{
		}

		// Token: 0x0602256C RID: 140652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602256C")]
		[Address(RVA = "0x1CC3460", Offset = "0x1CC2060", VA = "0x181CC3460")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602256D RID: 140653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602256D")]
		[Address(RVA = "0x1CC2D70", Offset = "0x1CC1970", VA = "0x181CC2D70")]
		public void OnClickStartSweep()
		{
		}

		// Token: 0x0602256E RID: 140654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602256E")]
		[Address(RVA = "0x1CC2CE0", Offset = "0x1CC18E0", VA = "0x181CC2CE0")]
		public void OnClickCancelSweep()
		{
		}

		// Token: 0x0602256F RID: 140655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602256F")]
		[Address(RVA = "0x1CC3990", Offset = "0x1CC2590", VA = "0x181CC3990")]
		public ClimbTowerSweepConfirmView()
		{
		}

		// Token: 0x0402F2B1 RID: 193201
		[Token(Token = "0x402F2B1")]
		private const string TARGET_ITEM_FMT = "<color=#ff6800>{0}</color> /{1}";

		// Token: 0x0402F2B2 RID: 193202
		[Token(Token = "0x402F2B2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _floatGroup;

		// Token: 0x0402F2B3 RID: 193203
		[Token(Token = "0x402F2B3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textLayerCount;

		// Token: 0x0402F2B4 RID: 193204
		[Token(Token = "0x402F2B4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("low item")]
		private RectTransform _lowItemIconContainer;

		// Token: 0x0402F2B5 RID: 193205
		[Token(Token = "0x402F2B5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("low item")]
		private Text _textLowItemName;

		// Token: 0x0402F2B6 RID: 193206
		[Token(Token = "0x402F2B6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("low item")]
		private Slider _slideLowItemFrom;

		// Token: 0x0402F2B7 RID: 193207
		[Token(Token = "0x402F2B7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("low item")]
		private Slider _slideLowItemTo;

		// Token: 0x0402F2B8 RID: 193208
		[Token(Token = "0x402F2B8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("low item")]
		private Text _textLowItemFrom;

		// Token: 0x0402F2B9 RID: 193209
		[Token(Token = "0x402F2B9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("low item")]
		private Text _textLowItemTo;

		// Token: 0x0402F2BA RID: 193210
		[Token(Token = "0x402F2BA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("low item")]
		private Text _textLowItemAdd;

		// Token: 0x0402F2BB RID: 193211
		[Token(Token = "0x402F2BB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("high item")]
		private RectTransform _highItemIconContainer;

		// Token: 0x0402F2BC RID: 193212
		[Token(Token = "0x402F2BC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("high item")]
		private Text _textHighItemName;

		// Token: 0x0402F2BD RID: 193213
		[Token(Token = "0x402F2BD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("high item")]
		private Slider _slideHighItemFrom;

		// Token: 0x0402F2BE RID: 193214
		[Token(Token = "0x402F2BE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("high item")]
		private Slider _slideHighItemTo;

		// Token: 0x0402F2BF RID: 193215
		[Token(Token = "0x402F2BF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("high item")]
		private Text _textHighItemFrom;

		// Token: 0x0402F2C0 RID: 193216
		[Token(Token = "0x402F2C0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("high item")]
		private Text _textHighItemTo;

		// Token: 0x0402F2C1 RID: 193217
		[Token(Token = "0x402F2C1")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("high item")]
		private Text _textHighItemAdd;

		// Token: 0x0402F2C2 RID: 193218
		[Token(Token = "0x402F2C2")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _textConfirm;

		// Token: 0x0402F2C3 RID: 193219
		[Token(Token = "0x402F2C3")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private SimpleLayoutContent _layoutCostTkt;

		// Token: 0x0402F2C4 RID: 193220
		[Token(Token = "0x402F2C4")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _itemCardScaleFactor;

		// Token: 0x0402F2C5 RID: 193221
		[Token(Token = "0x402F2C5")]
		[FieldOffset(Offset = "0xB0")]
		private ClimbTowerViewModel m_viewModel;

		// Token: 0x0402F2C6 RID: 193222
		[Token(Token = "0x402F2C6")]
		[FieldOffset(Offset = "0xB8")]
		private ClimbTowerSweepConfirmView.TktAdapter m_tktAdapter;

		// Token: 0x0402F2C7 RID: 193223
		[Token(Token = "0x402F2C7")]
		[FieldOffset(Offset = "0xC0")]
		private UIItemCard m_lowItemCard;

		// Token: 0x0402F2C8 RID: 193224
		[Token(Token = "0x402F2C8")]
		[FieldOffset(Offset = "0xC8")]
		private UIItemCard m_highItemCard;

		// Token: 0x0402F2C9 RID: 193225
		[Token(Token = "0x402F2C9")]
		[FieldOffset(Offset = "0xD0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402F2CA RID: 193226
		[Token(Token = "0x402F2CA")]
		[FieldOffset(Offset = "0xE0")]
		private int m_resetSweepConfirmSeqNum;

		// Token: 0x0402F2CB RID: 193227
		[Token(Token = "0x402F2CB")]
		[FieldOffset(Offset = "0xE8")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x0402F2CC RID: 193228
		[Token(Token = "0x402F2CC")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_isInited;

		// Token: 0x0402F2CD RID: 193229
		[Token(Token = "0x402F2CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F2CE RID: 193230
		[Token(Token = "0x402F2CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderItemIcon;

		// Token: 0x0402F2CF RID: 193231
		[Token(Token = "0x402F2CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F2D0 RID: 193232
		[Token(Token = "0x402F2D0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickStartSweep;

		// Token: 0x0402F2D1 RID: 193233
		[Token(Token = "0x402F2D1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClickCancelSweep;

		// Token: 0x0402F2D2 RID: 193234
		[Token(Token = "0x402F2D2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005CAE RID: 23726
		[Token(Token = "0x2005CAE")]
		private class TktAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06022570 RID: 140656 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022570")]
			[Address(RVA = "0x1CC9710", Offset = "0x1CC8310", VA = "0x181CC9710")]
			public TktAdapter(ClimbTowerSweepConfirmView closure)
			{
			}

			// Token: 0x170050AB RID: 20651
			// (get) Token: 0x06022571 RID: 140657 RVA: 0x000BD120 File Offset: 0x000BB320
			[Token(Token = "0x170050AB")]
			public override int count
			{
				[Token(Token = "0x6022571")]
				[Address(RVA = "0x1CC9790", Offset = "0x1CC8390", VA = "0x181CC9790", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022572 RID: 140658 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022572")]
			[Address(RVA = "0x1CC9140", Offset = "0x1CC7D40", VA = "0x181CC9140", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06022573 RID: 140659 RVA: 0x000BD138 File Offset: 0x000BB338
			[Token(Token = "0x6022573")]
			[Address(RVA = "0x1CC9600", Offset = "0x1CC8200", VA = "0x181CC9600")]
			private int _GetSelectTktUseCountByInstId(int instId)
			{
				return 0;
			}

			// Token: 0x0402F2D3 RID: 193235
			[Token(Token = "0x402F2D3")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerSweepConfirmView m_closure;

			// Token: 0x0402F2D4 RID: 193236
			[Token(Token = "0x402F2D4")]
			[FieldOffset(Offset = "0x28")]
			public long updateCurTs;

			// Token: 0x0402F2D5 RID: 193237
			[Token(Token = "0x402F2D5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F2D6 RID: 193238
			[Token(Token = "0x402F2D6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402F2D7 RID: 193239
			[Token(Token = "0x402F2D7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402F2D8 RID: 193240
			[Token(Token = "0x402F2D8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__GetSelectTktUseCountByInstId;
		}
	}
}
