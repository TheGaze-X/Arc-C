using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005861 RID: 22625
	[Token(Token = "0x2005861")]
	public class RL03TotemBuffMapNodeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004D87 RID: 19847
		// (get) Token: 0x060210BA RID: 135354 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060210BB RID: 135355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004D87")]
		public Action<int, int> onNodeClicked
		{
			[Token(Token = "0x60210BA")]
			[Address(RVA = "0x1B642E0", Offset = "0x1B62EE0", VA = "0x181B642E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60210BB")]
			[Address(RVA = "0x1B64340", Offset = "0x1B62F40", VA = "0x181B64340")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060210BC RID: 135356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210BC")]
		[Address(RVA = "0x1B63230", Offset = "0x1B61E30", VA = "0x181B63230")]
		public void Render(RL03TotemBuffMapNodeViewModel nodeViewModel, bool hasNodeSelected)
		{
		}

		// Token: 0x060210BD RID: 135357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60210BD")]
		[Address(RVA = "0x1B63170", Offset = "0x1B61D70", VA = "0x181B63170")]
		public RoguelikeCurve GetCurve(int index)
		{
			return null;
		}

		// Token: 0x060210BE RID: 135358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60210BE")]
		[Address(RVA = "0x1B63070", Offset = "0x1B61C70", VA = "0x181B63070")]
		public RectTransform GetConnector(bool isFromConnector, int index)
		{
			return null;
		}

		// Token: 0x060210BF RID: 135359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210BF")]
		[Address(RVA = "0x1B635C0", Offset = "0x1B621C0", VA = "0x181B635C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060210C0 RID: 135360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210C0")]
		[Address(RVA = "0x1B63A40", Offset = "0x1B62640", VA = "0x181B63A40")]
		private void _RenderNodeInfo(RL03TotemBuffMapNodeViewModel nodeViewModel, RoguelikeDungeonNode node, bool hasNodeSelected)
		{
		}

		// Token: 0x060210C1 RID: 135361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210C1")]
		[Address(RVA = "0x1B63760", Offset = "0x1B62360", VA = "0x181B63760")]
		private void _RenderCurves(RoguelikeDungeonNode node)
		{
		}

		// Token: 0x060210C2 RID: 135362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210C2")]
		[Address(RVA = "0x1B63480", Offset = "0x1B62080", VA = "0x181B63480")]
		private void _DealWithSingleSelectable(bool needShow)
		{
		}

		// Token: 0x060210C3 RID: 135363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210C3")]
		[Address(RVA = "0x1B62F80", Offset = "0x1B61B80", VA = "0x181B62F80")]
		public void EventOnClick()
		{
		}

		// Token: 0x060210C4 RID: 135364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210C4")]
		[Address(RVA = "0x1B64270", Offset = "0x1B62E70", VA = "0x181B64270")]
		public RL03TotemBuffMapNodeView()
		{
		}

		// Token: 0x0402CF55 RID: 184149
		[Token(Token = "0x402CF55")]
		private const int MAX_BUFF_COUNT = 7;

		// Token: 0x0402CF56 RID: 184150
		[Token(Token = "0x402CF56")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeNodeViewData _viewData;

		// Token: 0x0402CF57 RID: 184151
		[Token(Token = "0x402CF57")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgBkg;

		// Token: 0x0402CF58 RID: 184152
		[Token(Token = "0x402CF58")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgCantReachBkg;

		// Token: 0x0402CF59 RID: 184153
		[Token(Token = "0x402CF59")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0402CF5A RID: 184154
		[Token(Token = "0x402CF5A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Graphic _graphicBoss;

		// Token: 0x0402CF5B RID: 184155
		[Token(Token = "0x402CF5B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _imgCurrent;

		// Token: 0x0402CF5C RID: 184156
		[Token(Token = "0x402CF5C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<RoguelikeCurve> _curves;

		// Token: 0x0402CF5D RID: 184157
		[Token(Token = "0x402CF5D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<RectTransform> _fromConnectors;

		// Token: 0x0402CF5E RID: 184158
		[Token(Token = "0x402CF5E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<RectTransform> _toConnectors;

		// Token: 0x0402CF5F RID: 184159
		[Token(Token = "0x402CF5F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _verticalLine;

		// Token: 0x0402CF60 RID: 184160
		[Token(Token = "0x402CF60")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Graphic _graphicVerticalLine;

		// Token: 0x0402CF61 RID: 184161
		[Token(Token = "0x402CF61")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Focus")]
		private CanvasGroup _canvasGroupSingleSelect;

		// Token: 0x0402CF62 RID: 184162
		[Token(Token = "0x402CF62")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Focus")]
		private CanvasGroup _canvasGroupMultiSelect;

		// Token: 0x0402CF63 RID: 184163
		[Token(Token = "0x402CF63")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button _btnNode;

		// Token: 0x0402CF64 RID: 184164
		[Token(Token = "0x402CF64")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _colorSelectableIcon;

		// Token: 0x0402CF65 RID: 184165
		[Token(Token = "0x402CF65")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Color _colorNormalIcon;

		// Token: 0x0402CF66 RID: 184166
		[Token(Token = "0x402CF66")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Color _colorReachableCurve;

		// Token: 0x0402CF67 RID: 184167
		[Token(Token = "0x402CF67")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Color _colorCantReachCurve;

		// Token: 0x0402CF68 RID: 184168
		[Token(Token = "0x402CF68")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Color _colorNormalBoss;

		// Token: 0x0402CF69 RID: 184169
		[Token(Token = "0x402CF69")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Color _colorFinalBoss;

		// Token: 0x0402CF6A RID: 184170
		[Token(Token = "0x402CF6A")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private RectTransform _rectTransformBuffNode;

		// Token: 0x0402CF6B RID: 184171
		[Token(Token = "0x402CF6B")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private float _buffNodeStep;

		// Token: 0x0402CF6C RID: 184172
		[Token(Token = "0x402CF6C")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private UIAnimationLocation _singleSelectableAnim;

		// Token: 0x0402CF6E RID: 184174
		[Token(Token = "0x402CF6E")]
		[FieldOffset(Offset = "0x110")]
		private RoguelikeDungeonNode m_node;

		// Token: 0x0402CF6F RID: 184175
		[Token(Token = "0x402CF6F")]
		[FieldOffset(Offset = "0x118")]
		private bool m_isInited;

		// Token: 0x0402CF70 RID: 184176
		[Token(Token = "0x402CF70")]
		[FieldOffset(Offset = "0x120")]
		private Tween m_singleSelectableTween;

		// Token: 0x0402CF71 RID: 184177
		[Token(Token = "0x402CF71")]
		[FieldOffset(Offset = "0x128")]
		private FadeSwitchTween m_singleSelectTween;

		// Token: 0x0402CF72 RID: 184178
		[Token(Token = "0x402CF72")]
		[FieldOffset(Offset = "0x130")]
		private FadeSwitchTween m_multiSelectTween;

		// Token: 0x0402CF73 RID: 184179
		[Token(Token = "0x402CF73")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onNodeClicked;

		// Token: 0x0402CF74 RID: 184180
		[Token(Token = "0x402CF74")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onNodeClicked;

		// Token: 0x0402CF75 RID: 184181
		[Token(Token = "0x402CF75")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CF76 RID: 184182
		[Token(Token = "0x402CF76")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCurve;

		// Token: 0x0402CF77 RID: 184183
		[Token(Token = "0x402CF77")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetConnector;

		// Token: 0x0402CF78 RID: 184184
		[Token(Token = "0x402CF78")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402CF79 RID: 184185
		[Token(Token = "0x402CF79")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderNodeInfo;

		// Token: 0x0402CF7A RID: 184186
		[Token(Token = "0x402CF7A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderCurves;

		// Token: 0x0402CF7B RID: 184187
		[Token(Token = "0x402CF7B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DealWithSingleSelectable;

		// Token: 0x0402CF7C RID: 184188
		[Token(Token = "0x402CF7C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0402CF7D RID: 184189
		[Token(Token = "0x402CF7D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
