using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C59 RID: 23641
	[Token(Token = "0x2005C59")]
	public class ClimbTowerEntryMissionItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700506A RID: 20586
		// (get) Token: 0x06022418 RID: 140312 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022419 RID: 140313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700506A")]
		public Action<string> onClicked
		{
			[Token(Token = "0x6022418")]
			[Address(RVA = "0x1CBAAB0", Offset = "0x1CB96B0", VA = "0x181CBAAB0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022419")]
			[Address(RVA = "0x1CBAB10", Offset = "0x1CB9710", VA = "0x181CBAB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602241A RID: 140314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602241A")]
		[Address(RVA = "0x1CBA380", Offset = "0x1CB8F80", VA = "0x181CBA380")]
		public void Render(ClimbTowerEntryMissionItemViewModel viewModel, UIPage page)
		{
		}

		// Token: 0x0602241B RID: 140315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602241B")]
		[Address(RVA = "0x1CBA2A0", Offset = "0x1CB8EA0", VA = "0x181CBA2A0")]
		public void OnClick()
		{
		}

		// Token: 0x0602241C RID: 140316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602241C")]
		[Address(RVA = "0x1CBA910", Offset = "0x1CB9510", VA = "0x181CBA910")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602241D RID: 140317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602241D")]
		[Address(RVA = "0x1CBAA40", Offset = "0x1CB9640", VA = "0x181CBAA40")]
		public ClimbTowerEntryMissionItemView()
		{
		}

		// Token: 0x0402F06A RID: 192618
		[Token(Token = "0x402F06A")]
		private const string PROGRESS_RICH_FORMAT = "<color=#ff6800>{0}</color>/{1}";

		// Token: 0x0402F06B RID: 192619
		[Token(Token = "0x402F06B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgTowerIcon;

		// Token: 0x0402F06C RID: 192620
		[Token(Token = "0x402F06C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _imgSeasonTitle;

		// Token: 0x0402F06D RID: 192621
		[Token(Token = "0x402F06D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _seasonNumTxt;

		// Token: 0x0402F06E RID: 192622
		[Token(Token = "0x402F06E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _seasonNameTxt;

		// Token: 0x0402F06F RID: 192623
		[Token(Token = "0x402F06F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelGodCard;

		// Token: 0x0402F070 RID: 192624
		[Token(Token = "0x402F070")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgGodCardIcon;

		// Token: 0x0402F071 RID: 192625
		[Token(Token = "0x402F071")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TwoStateToggle[] _toggleComplete;

		// Token: 0x0402F072 RID: 192626
		[Token(Token = "0x402F072")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Slider _sliderProgress;

		// Token: 0x0402F073 RID: 192627
		[Token(Token = "0x402F073")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x0402F074 RID: 192628
		[Token(Token = "0x402F074")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402F075 RID: 192629
		[Token(Token = "0x402F075")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIColorGraphic _graphicHotSpot;

		// Token: 0x0402F076 RID: 192630
		[Token(Token = "0x402F076")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelOutLight;

		// Token: 0x0402F077 RID: 192631
		[Token(Token = "0x402F077")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SimpleLayoutContent _rewardItemContent;

		// Token: 0x0402F078 RID: 192632
		[Token(Token = "0x402F078")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelReceived;

		// Token: 0x0402F079 RID: 192633
		[Token(Token = "0x402F079")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelNeedReceive;

		// Token: 0x0402F07A RID: 192634
		[Token(Token = "0x402F07A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x0402F07B RID: 192635
		[Token(Token = "0x402F07B")]
		[FieldOffset(Offset = "0x98")]
		private string m_cachedMissionId;

		// Token: 0x0402F07C RID: 192636
		[Token(Token = "0x402F07C")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_hasInited;

		// Token: 0x0402F07D RID: 192637
		[Token(Token = "0x402F07D")]
		[FieldOffset(Offset = "0xA8")]
		private ClimbTowerEntryMissionItemView.Adapter m_adapter;

		// Token: 0x0402F07E RID: 192638
		[Token(Token = "0x402F07E")]
		[FieldOffset(Offset = "0xB0")]
		private List<UIItemViewModel> m_rewardList;

		// Token: 0x0402F080 RID: 192640
		[Token(Token = "0x402F080")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClicked;

		// Token: 0x0402F081 RID: 192641
		[Token(Token = "0x402F081")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClicked;

		// Token: 0x0402F082 RID: 192642
		[Token(Token = "0x402F082")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F083 RID: 192643
		[Token(Token = "0x402F083")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402F084 RID: 192644
		[Token(Token = "0x402F084")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F085 RID: 192645
		[Token(Token = "0x402F085")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005C5A RID: 23642
		[Token(Token = "0x2005C5A")]
		public class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0602241E RID: 140318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602241E")]
			[Address(RVA = "0x1CB82C0", Offset = "0x1CB6EC0", VA = "0x181CB82C0")]
			public Adapter(ClimbTowerEntryMissionItemView closure)
			{
			}

			// Token: 0x1700506B RID: 20587
			// (get) Token: 0x0602241F RID: 140319 RVA: 0x000BCD48 File Offset: 0x000BAF48
			[Token(Token = "0x1700506B")]
			public override int count
			{
				[Token(Token = "0x602241F")]
				[Address(RVA = "0x1CB8680", Offset = "0x1CB7280", VA = "0x181CB8680", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022420 RID: 140320 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022420")]
			[Address(RVA = "0x1CB7810", Offset = "0x1CB6410", VA = "0x181CB7810", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402F086 RID: 192646
			[Token(Token = "0x402F086")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerEntryMissionItemView m_closure;

			// Token: 0x0402F087 RID: 192647
			[Token(Token = "0x402F087")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F088 RID: 192648
			[Token(Token = "0x402F088")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402F089 RID: 192649
			[Token(Token = "0x402F089")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
