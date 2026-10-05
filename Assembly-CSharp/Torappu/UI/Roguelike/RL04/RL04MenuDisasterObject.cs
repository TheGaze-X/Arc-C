using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056E0 RID: 22240
	[Token(Token = "0x20056E0")]
	public class RL04MenuDisasterObject : RoguelikeMenuObject<RL04MenuDisasterViewModel>
	{
		// Token: 0x17004C74 RID: 19572
		// (get) Token: 0x060209D7 RID: 133591 RVA: 0x000B6838 File Offset: 0x000B4A38
		[Token(Token = "0x17004C74")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x60209D7")]
			[Address(RVA = "0x1AC22E0", Offset = "0x1AC0EE0", VA = "0x181AC22E0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x060209D8 RID: 133592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209D8")]
		[Address(RVA = "0x1AC10E0", Offset = "0x1ABFCE0", VA = "0x181AC10E0", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x060209D9 RID: 133593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209D9")]
		[Address(RVA = "0x1AC1510", Offset = "0x1AC0110", VA = "0x181AC1510", Slot = "8")]
		public override void OnMenuAdapterChanged(RoguelikeMenuAdapter adapter, bool fastMode)
		{
		}

		// Token: 0x060209DA RID: 133594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209DA")]
		[Address(RVA = "0x1AC1650", Offset = "0x1AC0250", VA = "0x181AC1650", Slot = "16")]
		public override void Render(RL04MenuDisasterViewModel viewModel)
		{
		}

		// Token: 0x060209DB RID: 133595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209DB")]
		[Address(RVA = "0x1AC1E60", Offset = "0x1AC0A60", VA = "0x181AC1E60")]
		private void _Render(bool fastMode, bool isFromAdapterChange)
		{
		}

		// Token: 0x060209DC RID: 133596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209DC")]
		[Address(RVA = "0x1AC1FB0", Offset = "0x1AC0BB0", VA = "0x181AC1FB0")]
		private void _UpdateRenderers()
		{
		}

		// Token: 0x060209DD RID: 133597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209DD")]
		[Address(RVA = "0x1AC1C70", Offset = "0x1AC0870", VA = "0x181AC1C70")]
		private void _RenderShowStatus(bool show, bool fastMode)
		{
		}

		// Token: 0x060209DE RID: 133598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209DE")]
		[Address(RVA = "0x1AC1D20", Offset = "0x1AC0920", VA = "0x181AC1D20")]
		private void _RenderZone(string zoneId, bool fastMode)
		{
		}

		// Token: 0x060209DF RID: 133599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209DF")]
		[Address(RVA = "0x1AC1A70", Offset = "0x1AC0670", VA = "0x181AC1A70")]
		private void _RenderDisaster(RL04MenuDisasterObject.DisasterParam disasterParam, bool fastMode)
		{
		}

		// Token: 0x060209E0 RID: 133600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209E0")]
		[Address(RVA = "0x1AC17C0", Offset = "0x1AC03C0", VA = "0x181AC17C0")]
		private void _RenderDisasterPart(RL04MenuDisasterViewModel viewModel, ILoadAsset loader)
		{
		}

		// Token: 0x060209E1 RID: 133601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209E1")]
		[Address(RVA = "0x1AC2200", Offset = "0x1AC0E00", VA = "0x181AC2200")]
		public RL04MenuDisasterObject()
		{
		}

		// Token: 0x060209E6 RID: 133606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209E6")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x060209E7 RID: 133607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60209E7")]
		[Address(RVA = "0x190F350", Offset = "0x190DF50", VA = "0x18190F350")]
		private void <>xLuaBaseProxy_OnMenuAdapterChanged(RoguelikeMenuAdapter P0, bool P1)
		{
		}

		// Token: 0x0402C3A2 RID: 181154
		[Token(Token = "0x402C3A2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type[] STATES_NOT_SHOW;

		// Token: 0x0402C3A3 RID: 181155
		[Token(Token = "0x402C3A3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelContent;

		// Token: 0x0402C3A4 RID: 181156
		[Token(Token = "0x402C3A4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtZoneName;

		// Token: 0x0402C3A5 RID: 181157
		[Token(Token = "0x402C3A5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelNonDisasterBkg;

		// Token: 0x0402C3A6 RID: 181158
		[Token(Token = "0x402C3A6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelDisasterBkg;

		// Token: 0x0402C3A7 RID: 181159
		[Token(Token = "0x402C3A7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelDisaster;

		// Token: 0x0402C3A8 RID: 181160
		[Token(Token = "0x402C3A8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgZoneIcon;

		// Token: 0x0402C3A9 RID: 181161
		[Token(Token = "0x402C3A9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgDisaster;

		// Token: 0x0402C3AA RID: 181162
		[Token(Token = "0x402C3AA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _levelContainer;

		// Token: 0x0402C3AB RID: 181163
		[Token(Token = "0x402C3AB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _prefabLevel;

		// Token: 0x0402C3AC RID: 181164
		[Token(Token = "0x402C3AC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _txtStep;

		// Token: 0x0402C3AD RID: 181165
		[Token(Token = "0x402C3AD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button _btnDisaster;

		// Token: 0x0402C3AE RID: 181166
		[Token(Token = "0x402C3AE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _disasterFadeinLocation;

		// Token: 0x0402C3AF RID: 181167
		[Token(Token = "0x402C3AF")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _disasterFadeoutLocation;

		// Token: 0x0402C3B0 RID: 181168
		[Token(Token = "0x402C3B0")]
		[FieldOffset(Offset = "0xA0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402C3B1 RID: 181169
		[Token(Token = "0x402C3B1")]
		[FieldOffset(Offset = "0xB0")]
		private RoguelikeMenuViewRenderer<bool> m_showRenderer;

		// Token: 0x0402C3B2 RID: 181170
		[Token(Token = "0x402C3B2")]
		[FieldOffset(Offset = "0xB8")]
		private RoguelikeMenuViewRenderer<string> m_zoneRenderer;

		// Token: 0x0402C3B3 RID: 181171
		[Token(Token = "0x402C3B3")]
		[FieldOffset(Offset = "0xC0")]
		private RoguelikeMenuViewRenderer<RL04MenuDisasterObject.DisasterParam> m_disasterRenderer;

		// Token: 0x0402C3B4 RID: 181172
		[Token(Token = "0x402C3B4")]
		[FieldOffset(Offset = "0xC8")]
		private RL04MenuDisasterViewModel m_cachedModel;

		// Token: 0x0402C3B5 RID: 181173
		[Token(Token = "0x402C3B5")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_cachedStateShow;

		// Token: 0x0402C3B6 RID: 181174
		[Token(Token = "0x402C3B6")]
		[FieldOffset(Offset = "0xD8")]
		private List<GameObject> m_levelObjs;

		// Token: 0x0402C3B7 RID: 181175
		[Token(Token = "0x402C3B7")]
		[FieldOffset(Offset = "0xE0")]
		private UIBiAnimClipSwitchTween.Builder m_switchTweenBuilder;

		// Token: 0x0402C3B8 RID: 181176
		[Token(Token = "0x402C3B8")]
		[FieldOffset(Offset = "0x130")]
		private UIBiAnimClipSwitchTween m_switchTween;

		// Token: 0x0402C3B9 RID: 181177
		[Token(Token = "0x402C3B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402C3BA RID: 181178
		[Token(Token = "0x402C3BA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402C3BB RID: 181179
		[Token(Token = "0x402C3BB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMenuAdapterChanged;

		// Token: 0x0402C3BC RID: 181180
		[Token(Token = "0x402C3BC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C3BD RID: 181181
		[Token(Token = "0x402C3BD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0402C3BE RID: 181182
		[Token(Token = "0x402C3BE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateRenderers;

		// Token: 0x0402C3BF RID: 181183
		[Token(Token = "0x402C3BF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderShowStatus;

		// Token: 0x0402C3C0 RID: 181184
		[Token(Token = "0x402C3C0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderZone;

		// Token: 0x0402C3C1 RID: 181185
		[Token(Token = "0x402C3C1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderDisaster;

		// Token: 0x0402C3C2 RID: 181186
		[Token(Token = "0x402C3C2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderDisasterPart;

		// Token: 0x0402C3C3 RID: 181187
		[Token(Token = "0x402C3C3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020056E1 RID: 22241
		[Token(Token = "0x20056E1")]
		private struct DisasterParam
		{
			// Token: 0x0402C3C4 RID: 181188
			[Token(Token = "0x402C3C4")]
			[FieldOffset(Offset = "0x0")]
			public string disasterId;

			// Token: 0x0402C3C5 RID: 181189
			[Token(Token = "0x402C3C5")]
			[FieldOffset(Offset = "0x8")]
			public int disperseStep;
		}
	}
}
