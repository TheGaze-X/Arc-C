using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056E2 RID: 22242
	[Token(Token = "0x20056E2")]
	public class RL04MenuFragmentObject : RoguelikeMenuObject<RL04MenuFragmentViewModel>, IHotfixable
	{
		// Token: 0x17004C75 RID: 19573
		// (get) Token: 0x060209E8 RID: 133608 RVA: 0x000B6880 File Offset: 0x000B4A80
		[Token(Token = "0x17004C75")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x60209E8")]
			[Address(RVA = "0x1AC5D60", Offset = "0x1AC4960", VA = "0x181AC5D60", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x060209E9 RID: 133609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209E9")]
		[Address(RVA = "0x1AC30F0", Offset = "0x1AC1CF0", VA = "0x181AC30F0", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x060209EA RID: 133610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209EA")]
		[Address(RVA = "0x1AC3B40", Offset = "0x1AC2740", VA = "0x181AC3B40", Slot = "16")]
		public override void Render(RL04MenuFragmentViewModel viewModel)
		{
		}

		// Token: 0x060209EB RID: 133611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209EB")]
		[Address(RVA = "0x1AC3850", Offset = "0x1AC2450", VA = "0x181AC3850", Slot = "8")]
		public override void OnMenuAdapterChanged(RoguelikeMenuAdapter adapter, bool fastMode)
		{
		}

		// Token: 0x060209EC RID: 133612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209EC")]
		[Address(RVA = "0x1AC3A60", Offset = "0x1AC2660", VA = "0x181AC3A60", Slot = "7")]
		public override void RenderSelection(RoguelikeMenuType type, bool fastMode)
		{
		}

		// Token: 0x060209ED RID: 133613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209ED")]
		[Address(RVA = "0x1AC5510", Offset = "0x1AC4110", VA = "0x181AC5510")]
		private void _UpdateRenderers()
		{
		}

		// Token: 0x060209EE RID: 133614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209EE")]
		[Address(RVA = "0x1AC51A0", Offset = "0x1AC3DA0", VA = "0x181AC51A0")]
		private void _RenderRenderers(bool fastMode)
		{
		}

		// Token: 0x060209EF RID: 133615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209EF")]
		[Address(RVA = "0x1AC5430", Offset = "0x1AC4030", VA = "0x181AC5430")]
		private void _RenderShowStatus(bool show, bool fastMode)
		{
		}

		// Token: 0x060209F0 RID: 133616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209F0")]
		[Address(RVA = "0x1AC50F0", Offset = "0x1AC3CF0", VA = "0x181AC50F0")]
		private void _RenderPanelBack(bool show, bool fastMode)
		{
		}

		// Token: 0x060209F1 RID: 133617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209F1")]
		[Address(RVA = "0x1AC5030", Offset = "0x1AC3C30", VA = "0x181AC5030")]
		private void _RenderForbidden(bool isShowForbidden, bool fastMode)
		{
		}

		// Token: 0x060209F2 RID: 133618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209F2")]
		[Address(RVA = "0x1AC4F50", Offset = "0x1AC3B50", VA = "0x181AC4F50")]
		private void _RenderForTips(bool isShow, bool isFastMode)
		{
		}

		// Token: 0x060209F3 RID: 133619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209F3")]
		[Address(RVA = "0x1AC4BF0", Offset = "0x1AC37F0", VA = "0x181AC4BF0")]
		private void _PlayWeightFragmentEntryAnim(FragmentBagStatus fragmentBagStatus)
		{
		}

		// Token: 0x060209F4 RID: 133620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209F4")]
		[Address(RVA = "0x1AC4D20", Offset = "0x1AC3920", VA = "0x181AC4D20")]
		private void _PlayWeightProgressTween(float weightProgress)
		{
		}

		// Token: 0x060209F5 RID: 133621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209F5")]
		[Address(RVA = "0x1AC4750", Offset = "0x1AC3350", VA = "0x181AC4750")]
		private void _PlayCurWeightTextTween(int curWeight)
		{
		}

		// Token: 0x060209F6 RID: 133622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209F6")]
		[Address(RVA = "0x1AC49A0", Offset = "0x1AC35A0", VA = "0x181AC49A0")]
		private void _PlayLimitWeightTextTween(int limitWeight)
		{
		}

		// Token: 0x060209F7 RID: 133623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209F7")]
		[Address(RVA = "0x1AC4420", Offset = "0x1AC3020", VA = "0x181AC4420")]
		private void _OnFragmentClicked()
		{
		}

		// Token: 0x060209F8 RID: 133624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209F8")]
		[Address(RVA = "0x1AC3710", Offset = "0x1AC2310", VA = "0x181AC3710", Slot = "12")]
		public override void OnClick()
		{
		}

		// Token: 0x060209F9 RID: 133625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209F9")]
		[Address(RVA = "0x1AC5CD0", Offset = "0x1AC48D0", VA = "0x181AC5CD0")]
		public RL04MenuFragmentObject()
		{
		}

		// Token: 0x06020A01 RID: 133633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A01")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x06020A02 RID: 133634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A02")]
		[Address(RVA = "0x190F350", Offset = "0x190DF50", VA = "0x18190F350")]
		private void <>xLuaBaseProxy_OnMenuAdapterChanged(RoguelikeMenuAdapter P0, bool P1)
		{
		}

		// Token: 0x06020A03 RID: 133635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A03")]
		[Address(RVA = "0x190F360", Offset = "0x190DF60", VA = "0x18190F360")]
		private void <>xLuaBaseProxy_RenderSelection(RoguelikeMenuType P0, bool P1)
		{
		}

		// Token: 0x06020A04 RID: 133636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020A04")]
		[Address(RVA = "0x1910390", Offset = "0x190EF90", VA = "0x181910390")]
		private void <>xLuaBaseProxy_OnClick()
		{
		}

		// Token: 0x0402C3C6 RID: 181190
		[Token(Token = "0x402C3C6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 HIDE_POS;

		// Token: 0x0402C3C7 RID: 181191
		[Token(Token = "0x402C3C7")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector2 SHOW_POS;

		// Token: 0x0402C3C8 RID: 181192
		[Token(Token = "0x402C3C8")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Type[] STATES_NOT_SHOW;

		// Token: 0x0402C3C9 RID: 181193
		[Token(Token = "0x402C3C9")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Type[] STATES_SHOW_CAN_USE;

		// Token: 0x0402C3CA RID: 181194
		[Token(Token = "0x402C3CA")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Type[] STATES_SELECTED;

		// Token: 0x0402C3CB RID: 181195
		[Token(Token = "0x402C3CB")]
		[FieldOffset(Offset = "0x28")]
		private static readonly Type[] STATES_FORBIDDEN;

		// Token: 0x0402C3CC RID: 181196
		[Token(Token = "0x402C3CC")]
		[FieldOffset(Offset = "0x30")]
		private static readonly Color LIGHT_WEIGHT_TEXT_COLOR;

		// Token: 0x0402C3CD RID: 181197
		[Token(Token = "0x402C3CD")]
		[FieldOffset(Offset = "0x40")]
		private static readonly Color MEDIUM_WEIGHT_TEXT_COLOR;

		// Token: 0x0402C3CE RID: 181198
		[Token(Token = "0x402C3CE")]
		[FieldOffset(Offset = "0x50")]
		private static readonly Color HEAVY_WEIGHT_TEXT_COLOR;

		// Token: 0x0402C3CF RID: 181199
		[Token(Token = "0x402C3CF")]
		[FieldOffset(Offset = "0x60")]
		private static readonly Color LIGHT_WEIGHT_PROGRESS_COLOR;

		// Token: 0x0402C3D0 RID: 181200
		[Token(Token = "0x402C3D0")]
		[FieldOffset(Offset = "0x70")]
		private static readonly Color MEDIUM_WEIGHT_PROGRESS_COLOR;

		// Token: 0x0402C3D1 RID: 181201
		[Token(Token = "0x402C3D1")]
		[FieldOffset(Offset = "0x80")]
		private static readonly Color HEAVY_WEIGHT_PROGRESS_COLOR;

		// Token: 0x0402C3D2 RID: 181202
		[Token(Token = "0x402C3D2")]
		private const float PROGRESS_CHANGE_DURATION = 0.7f;

		// Token: 0x0402C3D3 RID: 181203
		[Token(Token = "0x402C3D3")]
		private const float CUR_WEIGHT_CHANGE_DURATION = 0.7f;

		// Token: 0x0402C3D4 RID: 181204
		[Token(Token = "0x402C3D4")]
		private const float LIMIT_WEIGHT_CHANGE_DURATION = 0.7f;

		// Token: 0x0402C3D5 RID: 181205
		[Token(Token = "0x402C3D5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _pnlContent;

		// Token: 0x0402C3D6 RID: 181206
		[Token(Token = "0x402C3D6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pnlBack;

		// Token: 0x0402C3D7 RID: 181207
		[Token(Token = "0x402C3D7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _weightProgressImg;

		// Token: 0x0402C3D8 RID: 181208
		[Token(Token = "0x402C3D8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _curWeightText;

		// Token: 0x0402C3D9 RID: 181209
		[Token(Token = "0x402C3D9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _limitWeightText;

		// Token: 0x0402C3DA RID: 181210
		[Token(Token = "0x402C3DA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _lightWeightFragmentObj;

		// Token: 0x0402C3DB RID: 181211
		[Token(Token = "0x402C3DB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _mediumWeightFragmentObj;

		// Token: 0x0402C3DC RID: 181212
		[Token(Token = "0x402C3DC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _heavyWeightFragmentObj;

		// Token: 0x0402C3DD RID: 181213
		[Token(Token = "0x402C3DD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _fragmentWeightCharNotFullTipsGroup;

		// Token: 0x0402C3DE RID: 181214
		[Token(Token = "0x402C3DE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _weightFragmentEntryAnimLocation;

		// Token: 0x0402C3DF RID: 181215
		[Token(Token = "0x402C3DF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _fragmentForbiddenAnimLocation;

		// Token: 0x0402C3E0 RID: 181216
		[Token(Token = "0x402C3E0")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _ideaCnt;

		// Token: 0x0402C3E1 RID: 181217
		[Token(Token = "0x402C3E1")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeMenuViewRenderer<bool> m_showRenderer;

		// Token: 0x0402C3E2 RID: 181218
		[Token(Token = "0x402C3E2")]
		[FieldOffset(Offset = "0xA0")]
		private List<IRoguelikeMenuViewRenderer> m_renderers;

		// Token: 0x0402C3E3 RID: 181219
		[Token(Token = "0x402C3E3")]
		[FieldOffset(Offset = "0xA8")]
		private FadeTranslationSwitchTween m_showSwitchTween;

		// Token: 0x0402C3E4 RID: 181220
		[Token(Token = "0x402C3E4")]
		[FieldOffset(Offset = "0xB0")]
		private AnimationSwitchTween m_forbiddenSwitchTween;

		// Token: 0x0402C3E5 RID: 181221
		[Token(Token = "0x402C3E5")]
		[FieldOffset(Offset = "0xB8")]
		private FadeSwitchTween m_fragmentCharNotNullTipsFadeSwitchTween;

		// Token: 0x0402C3E6 RID: 181222
		[Token(Token = "0x402C3E6")]
		[FieldOffset(Offset = "0xC0")]
		private RL04MenuFragmentViewModel m_cachedModel;

		// Token: 0x0402C3E7 RID: 181223
		[Token(Token = "0x402C3E7")]
		[FieldOffset(Offset = "0xC8")]
		private RL04MenuFragmentObject.RL04FragmentObjectStatus m_cachedStatus;

		// Token: 0x0402C3E8 RID: 181224
		[Token(Token = "0x402C3E8")]
		[FieldOffset(Offset = "0xCC")]
		private bool m_cachedIsCanUse;

		// Token: 0x0402C3E9 RID: 181225
		[Token(Token = "0x402C3E9")]
		[FieldOffset(Offset = "0xCD")]
		private bool m_cachedStateShow;

		// Token: 0x0402C3EA RID: 181226
		[Token(Token = "0x402C3EA")]
		[FieldOffset(Offset = "0xD0")]
		private Tween m_weightFragmentEntryTween;

		// Token: 0x0402C3EB RID: 181227
		[Token(Token = "0x402C3EB")]
		[FieldOffset(Offset = "0xD8")]
		private Tween m_progressChangeTween;

		// Token: 0x0402C3EC RID: 181228
		[Token(Token = "0x402C3EC")]
		[FieldOffset(Offset = "0xE0")]
		private Tween m_curWeightTextTween;

		// Token: 0x0402C3ED RID: 181229
		[Token(Token = "0x402C3ED")]
		[FieldOffset(Offset = "0xE8")]
		private Tween m_limitWeightTextTween;

		// Token: 0x0402C3EE RID: 181230
		[Token(Token = "0x402C3EE")]
		[FieldOffset(Offset = "0xF0")]
		private FragmentBagStatus m_cachedFragmentBagStatus;

		// Token: 0x0402C3EF RID: 181231
		[Token(Token = "0x402C3EF")]
		[FieldOffset(Offset = "0xF4")]
		private float m_cachedWeightProgress;

		// Token: 0x0402C3F0 RID: 181232
		[Token(Token = "0x402C3F0")]
		[FieldOffset(Offset = "0xF8")]
		private int m_cachedCurWeight;

		// Token: 0x0402C3F1 RID: 181233
		[Token(Token = "0x402C3F1")]
		[FieldOffset(Offset = "0xFC")]
		private int m_cachedLimitWeight;

		// Token: 0x0402C3F2 RID: 181234
		[Token(Token = "0x402C3F2")]
		[FieldOffset(Offset = "0x100")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402C3F3 RID: 181235
		[Token(Token = "0x402C3F3")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402C3F4 RID: 181236
		[Token(Token = "0x402C3F4")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402C3F5 RID: 181237
		[Token(Token = "0x402C3F5")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C3F6 RID: 181238
		[Token(Token = "0x402C3F6")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnMenuAdapterChanged;

		// Token: 0x0402C3F7 RID: 181239
		[Token(Token = "0x402C3F7")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_RenderSelection;

		// Token: 0x0402C3F8 RID: 181240
		[Token(Token = "0x402C3F8")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__UpdateRenderers;

		// Token: 0x0402C3F9 RID: 181241
		[Token(Token = "0x402C3F9")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__RenderRenderers;

		// Token: 0x0402C3FA RID: 181242
		[Token(Token = "0x402C3FA")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__RenderShowStatus;

		// Token: 0x0402C3FB RID: 181243
		[Token(Token = "0x402C3FB")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__RenderPanelBack;

		// Token: 0x0402C3FC RID: 181244
		[Token(Token = "0x402C3FC")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__RenderForbidden;

		// Token: 0x0402C3FD RID: 181245
		[Token(Token = "0x402C3FD")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__RenderForTips;

		// Token: 0x0402C3FE RID: 181246
		[Token(Token = "0x402C3FE")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__PlayWeightFragmentEntryAnim;

		// Token: 0x0402C3FF RID: 181247
		[Token(Token = "0x402C3FF")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__PlayWeightProgressTween;

		// Token: 0x0402C400 RID: 181248
		[Token(Token = "0x402C400")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__PlayCurWeightTextTween;

		// Token: 0x0402C401 RID: 181249
		[Token(Token = "0x402C401")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__PlayLimitWeightTextTween;

		// Token: 0x0402C402 RID: 181250
		[Token(Token = "0x402C402")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__OnFragmentClicked;

		// Token: 0x0402C403 RID: 181251
		[Token(Token = "0x402C403")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402C404 RID: 181252
		[Token(Token = "0x402C404")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020056E3 RID: 22243
		[Token(Token = "0x20056E3")]
		public enum RL04FragmentObjectStatus
		{
			// Token: 0x0402C406 RID: 181254
			[Token(Token = "0x402C406")]
			NORMAL,
			// Token: 0x0402C407 RID: 181255
			[Token(Token = "0x402C407")]
			SELECTED,
			// Token: 0x0402C408 RID: 181256
			[Token(Token = "0x402C408")]
			FORBIDDEN
		}
	}
}
