using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act33Sign
{
	// Token: 0x0200747F RID: 29823
	[Token(Token = "0x200747F")]
	public class Act33SignRedpackDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A0FE RID: 172286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A0FE")]
		[Address(RVA = "0x25BF600", Offset = "0x25BE200", VA = "0x1825BF600")]
		private FadeSwitchTween _EnsureSwitchTween()
		{
			return null;
		}

		// Token: 0x0602A0FF RID: 172287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0FF")]
		[Address(RVA = "0x25BFED0", Offset = "0x25BEAD0", VA = "0x1825BFED0")]
		private void _Render(Act33SignRedpackViewModel viewModel)
		{
		}

		// Token: 0x0602A100 RID: 172288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A100")]
		[Address(RVA = "0x25BF750", Offset = "0x25BE350", VA = "0x1825BF750")]
		private void _InitRedpackStack()
		{
		}

		// Token: 0x0602A101 RID: 172289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A101")]
		[Address(RVA = "0x25BF9A0", Offset = "0x25BE5A0", VA = "0x1825BF9A0")]
		private void _PlayEntryAnim()
		{
		}

		// Token: 0x0602A102 RID: 172290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A102")]
		[Address(RVA = "0x25BFAE0", Offset = "0x25BE6E0", VA = "0x1825BFAE0")]
		private void _PlayLoopAnim()
		{
		}

		// Token: 0x0602A103 RID: 172291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A103")]
		[Address(RVA = "0x25C0230", Offset = "0x25BEE30", VA = "0x1825C0230")]
		private void _SendOpenRedpackWithTween()
		{
		}

		// Token: 0x0602A104 RID: 172292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A104")]
		[Address(RVA = "0x25BF530", Offset = "0x25BE130", VA = "0x1825BF530")]
		private void _ClearAnim()
		{
		}

		// Token: 0x0602A105 RID: 172293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A105")]
		[Address(RVA = "0x25BFC00", Offset = "0x25BE800", VA = "0x1825BFC00")]
		private void _RefreshPanel()
		{
		}

		// Token: 0x0602A106 RID: 172294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A106")]
		[Address(RVA = "0x25BF2E0", Offset = "0x25BDEE0", VA = "0x1825BF2E0")]
		public void OnRedpackCheckIn()
		{
		}

		// Token: 0x0602A107 RID: 172295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A107")]
		[Address(RVA = "0x25C0360", Offset = "0x25BEF60", VA = "0x1825C0360")]
		private void _SendOpenRedpack()
		{
		}

		// Token: 0x0602A108 RID: 172296 RVA: 0x000D75B0 File Offset: 0x000D57B0
		[Token(Token = "0x602A108")]
		[Address(RVA = "0x25BF8F0", Offset = "0x25BE4F0", VA = "0x1825BF8F0")]
		private bool _JudgeViewClosed(UISwitchTween switchTw)
		{
			return default(bool);
		}

		// Token: 0x0602A109 RID: 172297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A109")]
		[Address(RVA = "0x25BF1C0", Offset = "0x25BDDC0", VA = "0x1825BF1C0")]
		public void CloseView()
		{
		}

		// Token: 0x0602A10A RID: 172298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A10A")]
		[Address(RVA = "0x25BF450", Offset = "0x25BE050", VA = "0x1825BF450")]
		public void Show(Act33SignRedpackViewModel viewModel)
		{
		}

		// Token: 0x0602A10B RID: 172299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A10B")]
		[Address(RVA = "0x25BF250", Offset = "0x25BDE50", VA = "0x1825BF250")]
		public void Hide()
		{
		}

		// Token: 0x0602A10C RID: 172300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A10C")]
		[Address(RVA = "0x25C0520", Offset = "0x25BF120", VA = "0x1825C0520")]
		public Act33SignRedpackDetailView()
		{
		}

		// Token: 0x0403C5B8 RID: 247224
		[Token(Token = "0x403C5B8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act33SignRedpackItemView _redpack;

		// Token: 0x0403C5B9 RID: 247225
		[Token(Token = "0x403C5B9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationWrapper _wrapper;

		// Token: 0x0403C5BA RID: 247226
		[Token(Token = "0x403C5BA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403C5BB RID: 247227
		[Token(Token = "0x403C5BB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIBlurFloatPanel _blurPanel;

		// Token: 0x0403C5BC RID: 247228
		[Token(Token = "0x403C5BC")]
		private const string ANIM_LOOP = "act33sign_redpack_loop";

		// Token: 0x0403C5BD RID: 247229
		[Token(Token = "0x403C5BD")]
		private const string ANIM_ENTRY = "act33sign_redpack_entry";

		// Token: 0x0403C5BE RID: 247230
		[Token(Token = "0x403C5BE")]
		private const string ANIM_CHECKIN = "act33sign_redpack_open";

		// Token: 0x0403C5BF RID: 247231
		[Token(Token = "0x403C5BF")]
		private const string EXTRA_REDPACK_CODE = "ex";

		// Token: 0x0403C5C0 RID: 247232
		[Token(Token = "0x403C5C0")]
		private const float ALPHA_ONE = 1f;

		// Token: 0x0403C5C1 RID: 247233
		[Token(Token = "0x403C5C1")]
		private const float ALPHA_ZERO = 0f;

		// Token: 0x0403C5C2 RID: 247234
		[Token(Token = "0x403C5C2")]
		private const float TWEEN_DURATION = 0.13f;

		// Token: 0x0403C5C3 RID: 247235
		[Token(Token = "0x403C5C3")]
		[FieldOffset(Offset = "0x38")]
		private Act33SignRedpackViewModel m_viewModel;

		// Token: 0x0403C5C4 RID: 247236
		[Token(Token = "0x403C5C4")]
		[FieldOffset(Offset = "0x40")]
		private Act33SignRedpackItemViewModel m_currentPack;

		// Token: 0x0403C5C5 RID: 247237
		[Token(Token = "0x403C5C5")]
		[FieldOffset(Offset = "0x48")]
		private Queue<Act33SignRedpackItemViewModel> m_redpackQueue;

		// Token: 0x0403C5C6 RID: 247238
		[Token(Token = "0x403C5C6")]
		[FieldOffset(Offset = "0x50")]
		private bool m_consumed;

		// Token: 0x0403C5C7 RID: 247239
		[Token(Token = "0x403C5C7")]
		[FieldOffset(Offset = "0x58")]
		private FadeSwitchTween m_switchTween;

		// Token: 0x0403C5C8 RID: 247240
		[Token(Token = "0x403C5C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__EnsureSwitchTween;

		// Token: 0x0403C5C9 RID: 247241
		[Token(Token = "0x403C5C9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403C5CA RID: 247242
		[Token(Token = "0x403C5CA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitRedpackStack;

		// Token: 0x0403C5CB RID: 247243
		[Token(Token = "0x403C5CB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayEntryAnim;

		// Token: 0x0403C5CC RID: 247244
		[Token(Token = "0x403C5CC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayLoopAnim;

		// Token: 0x0403C5CD RID: 247245
		[Token(Token = "0x403C5CD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SendOpenRedpackWithTween;

		// Token: 0x0403C5CE RID: 247246
		[Token(Token = "0x403C5CE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ClearAnim;

		// Token: 0x0403C5CF RID: 247247
		[Token(Token = "0x403C5CF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RefreshPanel;

		// Token: 0x0403C5D0 RID: 247248
		[Token(Token = "0x403C5D0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnRedpackCheckIn;

		// Token: 0x0403C5D1 RID: 247249
		[Token(Token = "0x403C5D1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SendOpenRedpack;

		// Token: 0x0403C5D2 RID: 247250
		[Token(Token = "0x403C5D2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__JudgeViewClosed;

		// Token: 0x0403C5D3 RID: 247251
		[Token(Token = "0x403C5D3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CloseView;

		// Token: 0x0403C5D4 RID: 247252
		[Token(Token = "0x403C5D4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0403C5D5 RID: 247253
		[Token(Token = "0x403C5D5")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0403C5D6 RID: 247254
		[Token(Token = "0x403C5D6")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
