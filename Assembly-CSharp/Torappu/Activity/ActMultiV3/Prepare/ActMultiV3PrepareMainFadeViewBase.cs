using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007039 RID: 28729
	[Token(Token = "0x2007039")]
	public abstract class ActMultiV3PrepareMainFadeViewBase : ActMultiV3PrepareMainViewBase
	{
		// Token: 0x17006059 RID: 24665
		// (get) Token: 0x06028C86 RID: 167046 RVA: 0x000D2FC0 File Offset: 0x000D11C0
		// (set) Token: 0x06028C87 RID: 167047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006059")]
		public bool isShow
		{
			[Token(Token = "0x6028C86")]
			[Address(RVA = "0x2405C00", Offset = "0x2404800", VA = "0x182405C00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028C87")]
			[Address(RVA = "0x2405C90", Offset = "0x2404890", VA = "0x182405C90")]
			set
			{
			}
		}

		// Token: 0x06028C88 RID: 167048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C88")]
		[Address(RVA = "0x2405A50", Offset = "0x2404650", VA = "0x182405A50")]
		protected void TryInitVisibleSwitcher(bool initialVisible)
		{
		}

		// Token: 0x06028C89 RID: 167049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C89")]
		[Address(RVA = "0x2405B50", Offset = "0x2404750", VA = "0x182405B50")]
		protected ActMultiV3PrepareMainFadeViewBase()
		{
		}

		// Token: 0x0403A251 RID: 238161
		[Token(Token = "0x403A251")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvas;

		// Token: 0x0403A252 RID: 238162
		[Token(Token = "0x403A252")]
		[FieldOffset(Offset = "0x28")]
		private FadeSwitchTween m_switchTween;

		// Token: 0x0403A253 RID: 238163
		[Token(Token = "0x403A253")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403A254 RID: 238164
		[Token(Token = "0x403A254")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isShow;

		// Token: 0x0403A255 RID: 238165
		[Token(Token = "0x403A255")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryInitVisibleSwitcher;

		// Token: 0x0403A256 RID: 238166
		[Token(Token = "0x403A256")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
