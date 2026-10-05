using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001EAB RID: 7851
	[Token(Token = "0x2001EAB")]
	public class AVGSettingView : MonoBehaviour, IAVGDataSubscriber<AVGStoryCache>, IHotfixable
	{
		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x0600C26D RID: 49773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001743")]
		private CanvasGroup canvasGroup
		{
			[Token(Token = "0x600C26D")]
			[Address(RVA = "0x33FB810", Offset = "0x33FA410", VA = "0x1833FB810")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001744 RID: 5956
		// (get) Token: 0x0600C26E RID: 49774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001744")]
		private FadeSwitchTween fadeSwitchTween
		{
			[Token(Token = "0x600C26E")]
			[Address(RVA = "0x33FB8E0", Offset = "0x33FA4E0", VA = "0x1833FB8E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600C26F RID: 49775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C26F")]
		[Address(RVA = "0x33FA240", Offset = "0x33F8E40", VA = "0x1833FA240", Slot = "4")]
		public void OnValueChanged(AVGStoryCache cache)
		{
		}

		// Token: 0x0600C270 RID: 49776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C270")]
		[Address(RVA = "0x33FAEF0", Offset = "0x33F9AF0", VA = "0x1833FAEF0")]
		private void _RenderAVGSetting(AVGStoryCache viewModel)
		{
		}

		// Token: 0x0600C271 RID: 49777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C271")]
		[Address(RVA = "0x33FB260", Offset = "0x33F9E60", VA = "0x1833FB260")]
		private void _RenderWidgetStatus(AVGStoryCache viewModel)
		{
		}

		// Token: 0x0600C272 RID: 49778 RVA: 0x000475C8 File Offset: 0x000457C8
		[Token(Token = "0x600C272")]
		[Address(RVA = "0x33FA650", Offset = "0x33F9250", VA = "0x1833FA650")]
		private int _GetSelectedIndex(AVGStoryCache viewModel)
		{
			return 0;
		}

		// Token: 0x0600C273 RID: 49779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C273")]
		[Address(RVA = "0x33FAAB0", Offset = "0x33F96B0", VA = "0x1833FAAB0")]
		private void _RefreshPresetMapping()
		{
		}

		// Token: 0x0600C274 RID: 49780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C274")]
		[Address(RVA = "0x33FA8C0", Offset = "0x33F94C0", VA = "0x1833FA8C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600C275 RID: 49781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C275")]
		[Address(RVA = "0x33FA2E0", Offset = "0x33F8EE0", VA = "0x1833FA2E0")]
		private void _BindEvent()
		{
		}

		// Token: 0x0600C276 RID: 49782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C276")]
		[Address(RVA = "0x33FA3B0", Offset = "0x33F8FB0", VA = "0x1833FA3B0")]
		private void _EventOnFontSettingToggleChanged(int idx)
		{
		}

		// Token: 0x0600C277 RID: 49783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C277")]
		[Address(RVA = "0x33FB580", Offset = "0x33FA180", VA = "0x1833FB580")]
		private void _UpdateShown(bool value, bool force)
		{
		}

		// Token: 0x0600C278 RID: 49784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C278")]
		[Address(RVA = "0x33FB390", Offset = "0x33F9F90", VA = "0x1833FB390")]
		private void _ResumeAvgAutoIfNeeded()
		{
		}

		// Token: 0x0600C279 RID: 49785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C279")]
		[Address(RVA = "0x33FB450", Offset = "0x33FA050", VA = "0x1833FB450")]
		private void _ResumeReaderAutoIfNeeded()
		{
		}

		// Token: 0x17001745 RID: 5957
		// (get) Token: 0x0600C27A RID: 49786 RVA: 0x000475E0 File Offset: 0x000457E0
		// (set) Token: 0x0600C27B RID: 49787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001745")]
		public bool isShown
		{
			[Token(Token = "0x600C27A")]
			[Address(RVA = "0x33FBA50", Offset = "0x33FA650", VA = "0x1833FBA50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600C27B")]
			[Address(RVA = "0x33FBAC0", Offset = "0x33FA6C0", VA = "0x1833FBAC0")]
			set
			{
			}
		}

		// Token: 0x0600C27C RID: 49788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C27C")]
		[Address(RVA = "0x33F9EE0", Offset = "0x33F8AE0", VA = "0x1833F9EE0")]
		public void EventOnCloseBtnClicked()
		{
		}

		// Token: 0x0600C27D RID: 49789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C27D")]
		[Address(RVA = "0x33FB6D0", Offset = "0x33FA2D0", VA = "0x1833FB6D0")]
		public AVGSettingView()
		{
		}

		// Token: 0x0400C43F RID: 50239
		[Token(Token = "0x400C43F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ToggleGroupWatcher _fontSetting;

		// Token: 0x0400C440 RID: 50240
		[Token(Token = "0x400C440")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AVGFontPreset[] _fontSets;

		// Token: 0x0400C441 RID: 50241
		[Token(Token = "0x400C441")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<int> m_indexToPresetId;

		// Token: 0x0400C442 RID: 50242
		[Token(Token = "0x400C442")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<int, int> m_presetIdToIndex;

		// Token: 0x0400C443 RID: 50243
		[Token(Token = "0x400C443")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<int> m_indexToFallbackFontSize;

		// Token: 0x0400C444 RID: 50244
		[Token(Token = "0x400C444")]
		[FieldOffset(Offset = "0x40")]
		private bool m_useDisplayMetaPresets;

		// Token: 0x0400C445 RID: 50245
		[Token(Token = "0x400C445")]
		[FieldOffset(Offset = "0x41")]
		private bool m_missingDisplayMetaLogged;

		// Token: 0x0400C446 RID: 50246
		[Token(Token = "0x400C446")]
		[FieldOffset(Offset = "0x42")]
		private bool m_isInit;

		// Token: 0x0400C447 RID: 50247
		[Token(Token = "0x400C447")]
		[FieldOffset(Offset = "0x48")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x0400C448 RID: 50248
		[Token(Token = "0x400C448")]
		[FieldOffset(Offset = "0x50")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x0400C449 RID: 50249
		[Token(Token = "0x400C449")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_canvasGroup;

		// Token: 0x0400C44A RID: 50250
		[Token(Token = "0x400C44A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_fadeSwitchTween;

		// Token: 0x0400C44B RID: 50251
		[Token(Token = "0x400C44B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400C44C RID: 50252
		[Token(Token = "0x400C44C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderAVGSetting;

		// Token: 0x0400C44D RID: 50253
		[Token(Token = "0x400C44D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderWidgetStatus;

		// Token: 0x0400C44E RID: 50254
		[Token(Token = "0x400C44E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetSelectedIndex;

		// Token: 0x0400C44F RID: 50255
		[Token(Token = "0x400C44F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshPresetMapping;

		// Token: 0x0400C450 RID: 50256
		[Token(Token = "0x400C450")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400C451 RID: 50257
		[Token(Token = "0x400C451")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__BindEvent;

		// Token: 0x0400C452 RID: 50258
		[Token(Token = "0x400C452")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnFontSettingToggleChanged;

		// Token: 0x0400C453 RID: 50259
		[Token(Token = "0x400C453")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateShown;

		// Token: 0x0400C454 RID: 50260
		[Token(Token = "0x400C454")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ResumeAvgAutoIfNeeded;

		// Token: 0x0400C455 RID: 50261
		[Token(Token = "0x400C455")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ResumeReaderAutoIfNeeded;

		// Token: 0x0400C456 RID: 50262
		[Token(Token = "0x400C456")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_isShown;

		// Token: 0x0400C457 RID: 50263
		[Token(Token = "0x400C457")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_isShown;

		// Token: 0x0400C458 RID: 50264
		[Token(Token = "0x400C458")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventOnCloseBtnClicked;

		// Token: 0x0400C459 RID: 50265
		[Token(Token = "0x400C459")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
