using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052DC RID: 21212
	[Token(Token = "0x20052DC")]
	public class RoguelikeExpeditionView : DataBinder<RoguelikeExpeditionModelProperty>
	{
		// Token: 0x17004967 RID: 18791
		// (get) Token: 0x0601F490 RID: 128144 RVA: 0x000B16A8 File Offset: 0x000AF8A8
		[Token(Token = "0x17004967")]
		public bool hasCustomBkg
		{
			[Token(Token = "0x601F490")]
			[Address(RVA = "0x1902160", Offset = "0x1900D60", VA = "0x181902160")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004968 RID: 18792
		// (get) Token: 0x0601F491 RID: 128145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004968")]
		public RoguelikeExpeditionPluginContext pluginContext
		{
			[Token(Token = "0x601F491")]
			[Address(RVA = "0x19022E0", Offset = "0x1900EE0", VA = "0x1819022E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004969 RID: 18793
		// (get) Token: 0x0601F492 RID: 128146 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F493 RID: 128147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004969")]
		public Action<string> onCharItemClicked
		{
			[Token(Token = "0x601F492")]
			[Address(RVA = "0x1902220", Offset = "0x1900E20", VA = "0x181902220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F493")]
			[Address(RVA = "0x19023C0", Offset = "0x1900FC0", VA = "0x1819023C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700496A RID: 18794
		// (get) Token: 0x0601F494 RID: 128148 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F495 RID: 128149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700496A")]
		public Action onConfirmClick
		{
			[Token(Token = "0x601F494")]
			[Address(RVA = "0x1902280", Offset = "0x1900E80", VA = "0x181902280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F495")]
			[Address(RVA = "0x1902440", Offset = "0x1901040", VA = "0x181902440")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700496B RID: 18795
		// (get) Token: 0x0601F496 RID: 128150 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F497 RID: 128151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700496B")]
		public Action onBackClick
		{
			[Token(Token = "0x601F496")]
			[Address(RVA = "0x19021C0", Offset = "0x1900DC0", VA = "0x1819021C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601F497")]
			[Address(RVA = "0x1902340", Offset = "0x1900F40", VA = "0x181902340")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601F498 RID: 128152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F498")]
		[Address(RVA = "0x1901510", Offset = "0x1900110", VA = "0x181901510")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F499 RID: 128153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F499")]
		[Address(RVA = "0x1901E40", Offset = "0x1900A40", VA = "0x181901E40")]
		private void _RenderSelectingPart(RoguelikeExpeditionModel model)
		{
		}

		// Token: 0x0601F49A RID: 128154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F49A")]
		[Address(RVA = "0x1901B60", Offset = "0x1900760", VA = "0x181901B60")]
		private void _RenderCostPart(RoguelikeExpeditionModel model)
		{
		}

		// Token: 0x0601F49B RID: 128155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F49B")]
		[Address(RVA = "0x1901400", Offset = "0x1900000", VA = "0x181901400")]
		private void _FadeSelectingPart(bool isSelecting, bool isFastMode)
		{
		}

		// Token: 0x0601F49C RID: 128156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F49C")]
		[Address(RVA = "0x1900BA0", Offset = "0x18FF7A0", VA = "0x181900BA0", Slot = "7")]
		public override void OnValueChanged(RoguelikeExpeditionModelProperty property)
		{
		}

		// Token: 0x0601F49D RID: 128157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F49D")]
		[Address(RVA = "0x1900830", Offset = "0x18FF430", VA = "0x181900830")]
		public void InitAfterEventsSet()
		{
		}

		// Token: 0x0601F49E RID: 128158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F49E")]
		[Address(RVA = "0x19012D0", Offset = "0x18FFED0", VA = "0x1819012D0")]
		public void ResetViews()
		{
		}

		// Token: 0x0601F49F RID: 128159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F49F")]
		[Address(RVA = "0x1901F80", Offset = "0x1900B80", VA = "0x181901F80")]
		private void _UpdateTypePanels(RoguelikeExpeditionType expeditionType)
		{
		}

		// Token: 0x0601F4A0 RID: 128160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4A0")]
		[Address(RVA = "0x1901A40", Offset = "0x1900640", VA = "0x181901A40")]
		private void _OnCharItemClick(string charId)
		{
		}

		// Token: 0x0601F4A1 RID: 128161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4A1")]
		[Address(RVA = "0x1900A90", Offset = "0x18FF690", VA = "0x181900A90")]
		public void OnConfirmClick()
		{
		}

		// Token: 0x0601F4A2 RID: 128162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4A2")]
		[Address(RVA = "0x1900980", Offset = "0x18FF580", VA = "0x181900980")]
		public void OnBackClick()
		{
		}

		// Token: 0x0601F4A3 RID: 128163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4A3")]
		[Address(RVA = "0x19020F0", Offset = "0x1900CF0", VA = "0x1819020F0")]
		public RoguelikeExpeditionView()
		{
		}

		// Token: 0x0402A04D RID: 172109
		[Token(Token = "0x402A04D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _hasCustomBkg;

		// Token: 0x0402A04E RID: 172110
		[Token(Token = "0x402A04E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasSelected;

		// Token: 0x0402A04F RID: 172111
		[Token(Token = "0x402A04F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasNoSelect;

		// Token: 0x0402A050 RID: 172112
		[Token(Token = "0x402A050")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _selectingBeforeTransHolder;

		// Token: 0x0402A051 RID: 172113
		[Token(Token = "0x402A051")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _selectingAfterTransHolder;

		// Token: 0x0402A052 RID: 172114
		[Token(Token = "0x402A052")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtTipsSelect;

		// Token: 0x0402A053 RID: 172115
		[Token(Token = "0x402A053")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<Text> _txtTipsCosts;

		// Token: 0x0402A054 RID: 172116
		[Token(Token = "0x402A054")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RoguelikeExpeditionCharGridAdapter _charCardList;

		// Token: 0x0402A055 RID: 172117
		[Token(Token = "0x402A055")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LoopVerticalScrollRect _charListScrollRect;

		// Token: 0x0402A056 RID: 172118
		[Token(Token = "0x402A056")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RoguelikeExpeditionPluginContext _pluginContext;

		// Token: 0x0402A057 RID: 172119
		[Token(Token = "0x402A057")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<RoguelikeExpeditionView.ExpeditionTypePanel> _expeditionTypePanels;

		// Token: 0x0402A058 RID: 172120
		[Token(Token = "0x402A058")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RoguelikeExpeditionConfirmView _confirmView;

		// Token: 0x0402A05C RID: 172124
		[Token(Token = "0x402A05C")]
		[FieldOffset(Offset = "0x98")]
		private bool m_inited;

		// Token: 0x0402A05D RID: 172125
		[Token(Token = "0x402A05D")]
		[FieldOffset(Offset = "0xA0")]
		private RoguelikeExpeditionSelectingCharView m_selectingBeforeView;

		// Token: 0x0402A05E RID: 172126
		[Token(Token = "0x402A05E")]
		[FieldOffset(Offset = "0xA8")]
		private RoguelikeExpeditionSelectingCharView m_selectingAfterView;

		// Token: 0x0402A05F RID: 172127
		[Token(Token = "0x402A05F")]
		[FieldOffset(Offset = "0xB0")]
		private UISwitchTween m_showTweenNoSelect;

		// Token: 0x0402A060 RID: 172128
		[Token(Token = "0x402A060")]
		[FieldOffset(Offset = "0xB8")]
		private UISwitchTween m_showTweenSelect;

		// Token: 0x0402A061 RID: 172129
		[Token(Token = "0x402A061")]
		[FieldOffset(Offset = "0xC0")]
		private string m_cachedSelectedCharId;

		// Token: 0x0402A062 RID: 172130
		[Token(Token = "0x402A062")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasCustomBkg;

		// Token: 0x0402A063 RID: 172131
		[Token(Token = "0x402A063")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_pluginContext;

		// Token: 0x0402A064 RID: 172132
		[Token(Token = "0x402A064")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onCharItemClicked;

		// Token: 0x0402A065 RID: 172133
		[Token(Token = "0x402A065")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onCharItemClicked;

		// Token: 0x0402A066 RID: 172134
		[Token(Token = "0x402A066")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onConfirmClick;

		// Token: 0x0402A067 RID: 172135
		[Token(Token = "0x402A067")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onConfirmClick;

		// Token: 0x0402A068 RID: 172136
		[Token(Token = "0x402A068")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_onBackClick;

		// Token: 0x0402A069 RID: 172137
		[Token(Token = "0x402A069")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_onBackClick;

		// Token: 0x0402A06A RID: 172138
		[Token(Token = "0x402A06A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A06B RID: 172139
		[Token(Token = "0x402A06B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderSelectingPart;

		// Token: 0x0402A06C RID: 172140
		[Token(Token = "0x402A06C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderCostPart;

		// Token: 0x0402A06D RID: 172141
		[Token(Token = "0x402A06D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__FadeSelectingPart;

		// Token: 0x0402A06E RID: 172142
		[Token(Token = "0x402A06E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402A06F RID: 172143
		[Token(Token = "0x402A06F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_InitAfterEventsSet;

		// Token: 0x0402A070 RID: 172144
		[Token(Token = "0x402A070")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ResetViews;

		// Token: 0x0402A071 RID: 172145
		[Token(Token = "0x402A071")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UpdateTypePanels;

		// Token: 0x0402A072 RID: 172146
		[Token(Token = "0x402A072")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnCharItemClick;

		// Token: 0x0402A073 RID: 172147
		[Token(Token = "0x402A073")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnConfirmClick;

		// Token: 0x0402A074 RID: 172148
		[Token(Token = "0x402A074")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnBackClick;

		// Token: 0x0402A075 RID: 172149
		[Token(Token = "0x402A075")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020052DD RID: 21213
		[Token(Token = "0x20052DD")]
		[Serializable]
		public struct ExpeditionTypePanel
		{
			// Token: 0x0402A076 RID: 172150
			[Token(Token = "0x402A076")]
			[FieldOffset(Offset = "0x0")]
			public RoguelikeExpeditionType type;

			// Token: 0x0402A077 RID: 172151
			[Token(Token = "0x402A077")]
			[FieldOffset(Offset = "0x8")]
			public List<GameObject> panels;
		}
	}
}
