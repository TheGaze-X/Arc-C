using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C4B RID: 23627
	[Token(Token = "0x2005C4B")]
	public class ClimbTowerEntryGodCardDetailView : DataBinder<ClimbTowerEntryGodCardDetailProperty>, IHotfixable
	{
		// Token: 0x1700505B RID: 20571
		// (get) Token: 0x060223DC RID: 140252 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060223DD RID: 140253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700505B")]
		public UIPage page
		{
			[Token(Token = "0x60223DC")]
			[Address(RVA = "0x1CA7290", Offset = "0x1CA5E90", VA = "0x181CA7290")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60223DD")]
			[Address(RVA = "0x1CA72F0", Offset = "0x1CA5EF0", VA = "0x181CA72F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060223DE RID: 140254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223DE")]
		[Address(RVA = "0x1CA6C20", Offset = "0x1CA5820", VA = "0x181CA6C20", Slot = "7")]
		public override void OnValueChanged(ClimbTowerEntryGodCardDetailProperty property)
		{
		}

		// Token: 0x060223DF RID: 140255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223DF")]
		[Address(RVA = "0x1CA6FD0", Offset = "0x1CA5BD0", VA = "0x181CA6FD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060223E0 RID: 140256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223E0")]
		[Address(RVA = "0x1CA7220", Offset = "0x1CA5E20", VA = "0x181CA7220")]
		public ClimbTowerEntryGodCardDetailView()
		{
		}

		// Token: 0x0402EFD7 RID: 192471
		[Token(Token = "0x402EFD7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _seasonNumberTxt;

		// Token: 0x0402EFD8 RID: 192472
		[Token(Token = "0x402EFD8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgCardIcon;

		// Token: 0x0402EFD9 RID: 192473
		[Token(Token = "0x402EFD9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textCardName;

		// Token: 0x0402EFDA RID: 192474
		[Token(Token = "0x402EFDA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textCardDesc;

		// Token: 0x0402EFDB RID: 192475
		[Token(Token = "0x402EFDB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelTip;

		// Token: 0x0402EFDC RID: 192476
		[Token(Token = "0x402EFDC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textBindTowerName;

		// Token: 0x0402EFDD RID: 192477
		[Token(Token = "0x402EFDD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ClimbTowerEntryGodCardSubCardView[] _panelSubCardView;

		// Token: 0x0402EFDE RID: 192478
		[Token(Token = "0x402EFDE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TwoStateToggle _toggleGradient;

		// Token: 0x0402EFDF RID: 192479
		[Token(Token = "0x402EFDF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SimpleLayoutContent _towerContent;

		// Token: 0x0402EFE0 RID: 192480
		[Token(Token = "0x402EFE0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _unCompleteObj;

		// Token: 0x0402EFE1 RID: 192481
		[Token(Token = "0x402EFE1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _completeObj;

		// Token: 0x0402EFE2 RID: 192482
		[Token(Token = "0x402EFE2")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x0402EFE3 RID: 192483
		[Token(Token = "0x402EFE3")]
		[FieldOffset(Offset = "0x80")]
		private List<ClimbTowerEntryGodCardModel.GodCardBindTowerStatus> m_towerStatus;

		// Token: 0x0402EFE4 RID: 192484
		[Token(Token = "0x402EFE4")]
		[FieldOffset(Offset = "0x88")]
		private ClimbTowerEntryGodCardDetailView.Adapter m_adapter;

		// Token: 0x0402EFE6 RID: 192486
		[Token(Token = "0x402EFE6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402EFE7 RID: 192487
		[Token(Token = "0x402EFE7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x0402EFE8 RID: 192488
		[Token(Token = "0x402EFE8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402EFE9 RID: 192489
		[Token(Token = "0x402EFE9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402EFEA RID: 192490
		[Token(Token = "0x402EFEA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005C4C RID: 23628
		[Token(Token = "0x2005C4C")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x060223E1 RID: 140257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60223E1")]
			[Address(RVA = "0x1CA0D30", Offset = "0x1C9F930", VA = "0x181CA0D30")]
			public Adapter(ClimbTowerEntryGodCardDetailView closure)
			{
			}

			// Token: 0x1700505C RID: 20572
			// (get) Token: 0x060223E2 RID: 140258 RVA: 0x000BCCE8 File Offset: 0x000BAEE8
			[Token(Token = "0x1700505C")]
			public override int count
			{
				[Token(Token = "0x60223E2")]
				[Address(RVA = "0x1CA0FB0", Offset = "0x1C9FBB0", VA = "0x181CA0FB0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060223E3 RID: 140259 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60223E3")]
			[Address(RVA = "0x1CA0880", Offset = "0x1C9F480", VA = "0x181CA0880", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402EFEB RID: 192491
			[Token(Token = "0x402EFEB")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerEntryGodCardDetailView m_closure;

			// Token: 0x0402EFEC RID: 192492
			[Token(Token = "0x402EFEC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402EFED RID: 192493
			[Token(Token = "0x402EFED")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402EFEE RID: 192494
			[Token(Token = "0x402EFEE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
