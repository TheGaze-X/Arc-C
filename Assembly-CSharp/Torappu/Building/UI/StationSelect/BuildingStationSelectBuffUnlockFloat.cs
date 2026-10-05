using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C7D RID: 7293
	[Token(Token = "0x2001C7D")]
	public class BuildingStationSelectBuffUnlockFloat : PageSingleComponent
	{
		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x0600B531 RID: 46385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015CD")]
		protected FadeSwitchTween fadeTween
		{
			[Token(Token = "0x600B531")]
			[Address(RVA = "0x32EE440", Offset = "0x32ED040", VA = "0x1832EE440")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B532 RID: 46386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B532")]
		[Address(RVA = "0x32EDD50", Offset = "0x32EC950", VA = "0x1832EDD50", Slot = "7")]
		protected override void OnStart()
		{
		}

		// Token: 0x0600B533 RID: 46387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B533")]
		[Address(RVA = "0x32EDDD0", Offset = "0x32EC9D0", VA = "0x1832EDDD0")]
		public static void Show(UIPageFinder.Interface pageInterface, BuildingBuffDescStruct buffStruct, RectTransform buttonAnchor)
		{
		}

		// Token: 0x0600B534 RID: 46388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B534")]
		[Address(RVA = "0x32EE1A0", Offset = "0x32ECDA0", VA = "0x1832EE1A0")]
		private void _Show(BuildingBuffDescStruct buffStruct, RectTransform buttonAnchor)
		{
		}

		// Token: 0x0600B535 RID: 46389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B535")]
		[Address(RVA = "0x32EDCE0", Offset = "0x32EC8E0", VA = "0x1832EDCE0")]
		public void EventOnBlankClicked()
		{
		}

		// Token: 0x0600B536 RID: 46390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B536")]
		[Address(RVA = "0x32EE3E0", Offset = "0x32ECFE0", VA = "0x1832EE3E0")]
		public BuildingStationSelectBuffUnlockFloat()
		{
		}

		// Token: 0x0600B537 RID: 46391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B537")]
		[Address(RVA = "0xF53770", Offset = "0xF52370", VA = "0x180F53770")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x0400B13D RID: 45373
		[Token(Token = "0x400B13D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0400B13E RID: 45374
		[Token(Token = "0x400B13E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _panelContent;

		// Token: 0x0400B13F RID: 45375
		[Token(Token = "0x400B13F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textUnlockCond;

		// Token: 0x0400B140 RID: 45376
		[Token(Token = "0x400B140")]
		[FieldOffset(Offset = "0x38")]
		private FadeSwitchTween m_fadeTween;

		// Token: 0x0400B141 RID: 45377
		[Token(Token = "0x400B141")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_fadeTween;

		// Token: 0x0400B142 RID: 45378
		[Token(Token = "0x400B142")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0400B143 RID: 45379
		[Token(Token = "0x400B143")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0400B144 RID: 45380
		[Token(Token = "0x400B144")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Show;

		// Token: 0x0400B145 RID: 45381
		[Token(Token = "0x400B145")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnBlankClicked;

		// Token: 0x0400B146 RID: 45382
		[Token(Token = "0x400B146")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
