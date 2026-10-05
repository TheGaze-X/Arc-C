using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F30 RID: 7984
	[Token(Token = "0x2001F30")]
	public class AVGReaderModePerformanceAdapter : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600C679 RID: 50809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C679")]
		[Address(RVA = "0x3472080", Offset = "0x3470C80", VA = "0x183472080")]
		public void Initialize()
		{
		}

		// Token: 0x0600C67A RID: 50810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C67A")]
		[Address(RVA = "0x3472000", Offset = "0x3470C00", VA = "0x183472000")]
		public void BindView(IAVGDataSubscriber<AVGReaderModePerformanceViewModel> subscriber)
		{
		}

		// Token: 0x0600C67B RID: 50811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C67B")]
		[Address(RVA = "0x3471ED0", Offset = "0x3470AD0", VA = "0x183471ED0")]
		public void BindView(IAVGDataSubscriber<AVGReaderModePerformanceViewModel> subscriber, Component owner)
		{
		}

		// Token: 0x0600C67C RID: 50812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C67C")]
		[Address(RVA = "0x3472820", Offset = "0x3471420", VA = "0x183472820")]
		public void UnBindViews()
		{
		}

		// Token: 0x0600C67D RID: 50813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C67D")]
		[Address(RVA = "0x34727B0", Offset = "0x34713B0", VA = "0x1834727B0")]
		public void UnBindViews(Component owner)
		{
		}

		// Token: 0x0600C67E RID: 50814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C67E")]
		[Address(RVA = "0x3472170", Offset = "0x3470D70", VA = "0x183472170")]
		public void ReaderModeSettingChanged()
		{
		}

		// Token: 0x0600C67F RID: 50815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C67F")]
		[Address(RVA = "0x3472D00", Offset = "0x3471900", VA = "0x183472D00")]
		private void _UnbindInternal()
		{
		}

		// Token: 0x0600C680 RID: 50816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C680")]
		[Address(RVA = "0x34721F0", Offset = "0x3470DF0", VA = "0x1834721F0")]
		public void RenderContext(IList<Command> commands)
		{
		}

		// Token: 0x0600C681 RID: 50817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C681")]
		[Address(RVA = "0x3472690", Offset = "0x3471290", VA = "0x183472690")]
		public void ResetState()
		{
		}

		// Token: 0x0600C682 RID: 50818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C682")]
		[Address(RVA = "0x3472AE0", Offset = "0x34716E0", VA = "0x183472AE0")]
		private void _ShowViewsWithFade()
		{
		}

		// Token: 0x0600C683 RID: 50819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C683")]
		[Address(RVA = "0x3472A60", Offset = "0x3471660", VA = "0x183472A60")]
		private void _ShowViewsImmediate()
		{
		}

		// Token: 0x0600C684 RID: 50820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C684")]
		[Address(RVA = "0x34728D0", Offset = "0x34714D0", VA = "0x1834728D0")]
		private void _HideViewsImmediate()
		{
		}

		// Token: 0x0600C685 RID: 50821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C685")]
		[Address(RVA = "0x3472C80", Offset = "0x3471880", VA = "0x183472C80")]
		private void _StopShowSwitchTween()
		{
		}

		// Token: 0x0600C686 RID: 50822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C686")]
		[Address(RVA = "0x3472950", Offset = "0x3471550", VA = "0x183472950")]
		private void _SetShowSwitchState(float alpha, bool enableInput)
		{
		}

		// Token: 0x0600C687 RID: 50823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C687")]
		[Address(RVA = "0x3472D80", Offset = "0x3471980", VA = "0x183472D80")]
		public AVGReaderModePerformanceAdapter()
		{
		}

		// Token: 0x0400CBC6 RID: 52166
		[Token(Token = "0x400CBC6")]
		private const float SHOW_SWITCH_FADE_DURATION = 0.2f;

		// Token: 0x0400CBC7 RID: 52167
		[Token(Token = "0x400CBC7")]
		[FieldOffset(Offset = "0x18")]
		private AVGReaderModePerformanceViewModel m_cachedViewModel;

		// Token: 0x0400CBC8 RID: 52168
		[Token(Token = "0x400CBC8")]
		[FieldOffset(Offset = "0x20")]
		private AVGDataDriver<AVGReaderModePerformanceViewModel> m_viewModelDriver;

		// Token: 0x0400CBC9 RID: 52169
		[Token(Token = "0x400CBC9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _showSwitchGroup;

		// Token: 0x0400CBCA RID: 52170
		[Token(Token = "0x400CBCA")]
		[FieldOffset(Offset = "0x30")]
		private bool m_showSwitchHidden;

		// Token: 0x0400CBCB RID: 52171
		[Token(Token = "0x400CBCB")]
		[FieldOffset(Offset = "0x38")]
		private Tween m_showSwitchTween;

		// Token: 0x0400CBCC RID: 52172
		[Token(Token = "0x400CBCC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Initialize;

		// Token: 0x0400CBCD RID: 52173
		[Token(Token = "0x400CBCD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BindView;

		// Token: 0x0400CBCE RID: 52174
		[Token(Token = "0x400CBCE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1_BindView;

		// Token: 0x0400CBCF RID: 52175
		[Token(Token = "0x400CBCF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UnBindViews;

		// Token: 0x0400CBD0 RID: 52176
		[Token(Token = "0x400CBD0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_UnBindViews;

		// Token: 0x0400CBD1 RID: 52177
		[Token(Token = "0x400CBD1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ReaderModeSettingChanged;

		// Token: 0x0400CBD2 RID: 52178
		[Token(Token = "0x400CBD2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UnbindInternal;

		// Token: 0x0400CBD3 RID: 52179
		[Token(Token = "0x400CBD3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RenderContext;

		// Token: 0x0400CBD4 RID: 52180
		[Token(Token = "0x400CBD4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ResetState;

		// Token: 0x0400CBD5 RID: 52181
		[Token(Token = "0x400CBD5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ShowViewsWithFade;

		// Token: 0x0400CBD6 RID: 52182
		[Token(Token = "0x400CBD6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ShowViewsImmediate;

		// Token: 0x0400CBD7 RID: 52183
		[Token(Token = "0x400CBD7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__HideViewsImmediate;

		// Token: 0x0400CBD8 RID: 52184
		[Token(Token = "0x400CBD8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__StopShowSwitchTween;

		// Token: 0x0400CBD9 RID: 52185
		[Token(Token = "0x400CBD9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__SetShowSwitchState;

		// Token: 0x0400CBDA RID: 52186
		[Token(Token = "0x400CBDA")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
