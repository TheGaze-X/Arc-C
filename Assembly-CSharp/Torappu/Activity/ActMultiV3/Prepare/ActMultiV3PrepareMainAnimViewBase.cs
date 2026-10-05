using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x0200703A RID: 28730
	[Token(Token = "0x200703A")]
	public abstract class ActMultiV3PrepareMainAnimViewBase : ActMultiV3PrepareMainViewBase
	{
		// Token: 0x1700605A RID: 24666
		// (get) Token: 0x06028C8A RID: 167050 RVA: 0x000D2FD8 File Offset: 0x000D11D8
		// (set) Token: 0x06028C8B RID: 167051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700605A")]
		public bool isShow
		{
			[Token(Token = "0x6028C8A")]
			[Address(RVA = "0x2404EF0", Offset = "0x2403AF0", VA = "0x182404EF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028C8B")]
			[Address(RVA = "0x2404F80", Offset = "0x2403B80", VA = "0x182404F80")]
			set
			{
			}
		}

		// Token: 0x06028C8C RID: 167052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C8C")]
		[Address(RVA = "0x2404D20", Offset = "0x2403920", VA = "0x182404D20")]
		protected void TryInitVisibleSwitcher(bool initialVisible)
		{
		}

		// Token: 0x06028C8D RID: 167053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C8D")]
		[Address(RVA = "0x2404E40", Offset = "0x2403A40", VA = "0x182404E40")]
		protected ActMultiV3PrepareMainAnimViewBase()
		{
		}

		// Token: 0x0403A257 RID: 238167
		[Token(Token = "0x403A257")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x0403A258 RID: 238168
		[Token(Token = "0x403A258")]
		[FieldOffset(Offset = "0x30")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x0403A259 RID: 238169
		[Token(Token = "0x403A259")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403A25A RID: 238170
		[Token(Token = "0x403A25A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isShow;

		// Token: 0x0403A25B RID: 238171
		[Token(Token = "0x403A25B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryInitVisibleSwitcher;

		// Token: 0x0403A25C RID: 238172
		[Token(Token = "0x403A25C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
