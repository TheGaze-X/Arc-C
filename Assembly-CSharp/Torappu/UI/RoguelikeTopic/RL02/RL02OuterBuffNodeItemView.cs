using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x0200461A RID: 17946
	[Token(Token = "0x200461A")]
	public class RL02OuterBuffNodeItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004100 RID: 16640
		// (get) Token: 0x0601B465 RID: 111717 RVA: 0x000A4CA0 File Offset: 0x000A2EA0
		[Token(Token = "0x17004100")]
		public RL02DevelopmentNodeType nodeType
		{
			[Token(Token = "0x601B465")]
			[Address(RVA = "0x14A0630", Offset = "0x149F230", VA = "0x1814A0630")]
			get
			{
				return RL02DevelopmentNodeType.NONE;
			}
		}

		// Token: 0x17004101 RID: 16641
		// (get) Token: 0x0601B466 RID: 111718 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B467 RID: 111719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004101")]
		public Action<string> onNodeClicked
		{
			[Token(Token = "0x601B466")]
			[Address(RVA = "0x14A0690", Offset = "0x149F290", VA = "0x1814A0690")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601B467")]
			[Address(RVA = "0x14A0750", Offset = "0x149F350", VA = "0x1814A0750")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004102 RID: 16642
		// (get) Token: 0x0601B468 RID: 111720 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B469 RID: 111721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004102")]
		public UIPage page
		{
			[Token(Token = "0x601B468")]
			[Address(RVA = "0x14A06F0", Offset = "0x149F2F0", VA = "0x1814A06F0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601B469")]
			[Address(RVA = "0x14A07D0", Offset = "0x149F3D0", VA = "0x1814A07D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B46A RID: 111722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B46A")]
		[Address(RVA = "0x149FB30", Offset = "0x149E730", VA = "0x18149FB30")]
		public void Render(RL02OuterBuffItemModel nodeModel, RL02OuterBuffNodeGroupView.RenderConfig config)
		{
		}

		// Token: 0x0601B46B RID: 111723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B46B")]
		[Address(RVA = "0x149FA40", Offset = "0x149E640", VA = "0x18149FA40")]
		public void OnClick()
		{
		}

		// Token: 0x0601B46C RID: 111724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B46C")]
		[Address(RVA = "0x14A0400", Offset = "0x149F000", VA = "0x1814A0400")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B46D RID: 111725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B46D")]
		[Address(RVA = "0x14A0240", Offset = "0x149EE40", VA = "0x1814A0240")]
		private void _GenerateUnlockOutlineLoopTween()
		{
		}

		// Token: 0x0601B46E RID: 111726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B46E")]
		[Address(RVA = "0x14A0160", Offset = "0x149ED60", VA = "0x1814A0160")]
		private void _ClearUnlockOutlineLoopTween()
		{
		}

		// Token: 0x0601B46F RID: 111727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B46F")]
		[Address(RVA = "0x14A05C0", Offset = "0x149F1C0", VA = "0x1814A05C0")]
		public RL02OuterBuffNodeItemView()
		{
		}

		// Token: 0x0402332A RID: 144170
		[Token(Token = "0x402332A")]
		private const float OUTLINE_LOOP_TIME = 3f;

		// Token: 0x0402332B RID: 144171
		[Token(Token = "0x402332B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RL02DevelopmentNodeType _nodeType;

		// Token: 0x0402332C RID: 144172
		[Token(Token = "0x402332C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0402332D RID: 144173
		[Token(Token = "0x402332D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _rectSelf;

		// Token: 0x0402332E RID: 144174
		[Token(Token = "0x402332E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textNodeName;

		// Token: 0x0402332F RID: 144175
		[Token(Token = "0x402332F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateFadeSwitcher _bgSwitcher;

		// Token: 0x04023330 RID: 144176
		[Token(Token = "0x4023330")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasGroupTextTitle;

		// Token: 0x04023331 RID: 144177
		[Token(Token = "0x4023331")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasGroupOutline;

		// Token: 0x04023332 RID: 144178
		[Token(Token = "0x4023332")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _rectSelectPanel;

		// Token: 0x04023333 RID: 144179
		[Token(Token = "0x4023333")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _canvasGroupSelectPanel;

		// Token: 0x04023334 RID: 144180
		[Token(Token = "0x4023334")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _selectLoopTime;

		// Token: 0x04023335 RID: 144181
		[Token(Token = "0x4023335")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIColorGraphic _imgIconGroup;

		// Token: 0x04023336 RID: 144182
		[Token(Token = "0x4023336")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _colorIconUnlock;

		// Token: 0x04023337 RID: 144183
		[Token(Token = "0x4023337")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Color _colorIconLocked;

		// Token: 0x04023338 RID: 144184
		[Token(Token = "0x4023338")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Color _colorTextUnlock;

		// Token: 0x04023339 RID: 144185
		[Token(Token = "0x4023339")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Color _colorTextLocked;

		// Token: 0x0402333A RID: 144186
		[Token(Token = "0x402333A")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_hasInited;

		// Token: 0x0402333B RID: 144187
		[Token(Token = "0x402333B")]
		[FieldOffset(Offset = "0xB8")]
		private string m_cachedNodeId;

		// Token: 0x0402333C RID: 144188
		[Token(Token = "0x402333C")]
		[FieldOffset(Offset = "0xC0")]
		private FadeSwitchTween m_textTitleSwitchTween;

		// Token: 0x0402333D RID: 144189
		[Token(Token = "0x402333D")]
		[FieldOffset(Offset = "0xC8")]
		private RL02OuterBuffNodeItemView.SelectSwitchTween m_selectSwitchTween;

		// Token: 0x0402333E RID: 144190
		[Token(Token = "0x402333E")]
		[FieldOffset(Offset = "0xD0")]
		private Tween m_outlineLoopTween;

		// Token: 0x04023341 RID: 144193
		[Token(Token = "0x4023341")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nodeType;

		// Token: 0x04023342 RID: 144194
		[Token(Token = "0x4023342")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onNodeClicked;

		// Token: 0x04023343 RID: 144195
		[Token(Token = "0x4023343")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onNodeClicked;

		// Token: 0x04023344 RID: 144196
		[Token(Token = "0x4023344")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x04023345 RID: 144197
		[Token(Token = "0x4023345")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x04023346 RID: 144198
		[Token(Token = "0x4023346")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023347 RID: 144199
		[Token(Token = "0x4023347")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04023348 RID: 144200
		[Token(Token = "0x4023348")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023349 RID: 144201
		[Token(Token = "0x4023349")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenerateUnlockOutlineLoopTween;

		// Token: 0x0402334A RID: 144202
		[Token(Token = "0x402334A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ClearUnlockOutlineLoopTween;

		// Token: 0x0402334B RID: 144203
		[Token(Token = "0x402334B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200461B RID: 17947
		[Token(Token = "0x200461B")]
		private class SelectSwitchTween : UISwitchTween, IHotfixable
		{
			// Token: 0x0601B470 RID: 111728 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B470")]
			[Address(RVA = "0x14A89B0", Offset = "0x14A75B0", VA = "0x1814A89B0")]
			public SelectSwitchTween(RL02OuterBuffNodeItemView closure)
			{
			}

			// Token: 0x0601B471 RID: 111729 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B471")]
			[Address(RVA = "0x14A8250", Offset = "0x14A6E50", VA = "0x1814A8250", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601B472 RID: 111730 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B472")]
			[Address(RVA = "0x14A8400", Offset = "0x14A7000", VA = "0x1814A8400", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601B473 RID: 111731 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B473")]
			[Address(RVA = "0x14A80B0", Offset = "0x14A6CB0", VA = "0x1814A80B0", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x0601B474 RID: 111732 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B474")]
			[Address(RVA = "0x14A8120", Offset = "0x14A6D20", VA = "0x1814A8120", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x0601B475 RID: 111733 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B475")]
			[Address(RVA = "0x14A8190", Offset = "0x14A6D90", VA = "0x1814A8190", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601B476 RID: 111734 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B476")]
			[Address(RVA = "0x14A8570", Offset = "0x14A7170", VA = "0x1814A8570", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601B477 RID: 111735 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B477")]
			[Address(RVA = "0x14A8880", Offset = "0x14A7480", VA = "0x1814A8880")]
			private void _GenerateLoopTween()
			{
			}

			// Token: 0x0601B478 RID: 111736 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B478")]
			[Address(RVA = "0x14A87F0", Offset = "0x14A73F0", VA = "0x1814A87F0")]
			private void _ClearLoopTween()
			{
			}

			// Token: 0x0601B479 RID: 111737 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B479")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x0601B47A RID: 111738 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B47A")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x0601B47B RID: 111739 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B47B")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0601B47C RID: 111740 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B47C")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402334C RID: 144204
			[Token(Token = "0x402334C")]
			private const float DEFAULT_TWEEN_DURATION = 0.16f;

			// Token: 0x0402334D RID: 144205
			[Token(Token = "0x402334D")]
			private const float SCALE_BEFORE_ENTER = 1.1f;

			// Token: 0x0402334E RID: 144206
			[Token(Token = "0x402334E")]
			[FieldOffset(Offset = "0x48")]
			private RL02OuterBuffNodeItemView m_closure;

			// Token: 0x0402334F RID: 144207
			[Token(Token = "0x402334F")]
			[FieldOffset(Offset = "0x50")]
			private Tween m_cachedLoopTween;

			// Token: 0x04023350 RID: 144208
			[Token(Token = "0x4023350")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04023351 RID: 144209
			[Token(Token = "0x4023351")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04023352 RID: 144210
			[Token(Token = "0x4023352")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04023353 RID: 144211
			[Token(Token = "0x4023353")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x04023354 RID: 144212
			[Token(Token = "0x4023354")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x04023355 RID: 144213
			[Token(Token = "0x4023355")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x04023356 RID: 144214
			[Token(Token = "0x4023356")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_ResetToState;

			// Token: 0x04023357 RID: 144215
			[Token(Token = "0x4023357")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__GenerateLoopTween;

			// Token: 0x04023358 RID: 144216
			[Token(Token = "0x4023358")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__ClearLoopTween;
		}
	}
}
