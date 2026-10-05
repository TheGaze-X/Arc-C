using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ButtonChecker
{
	// Token: 0x02005C29 RID: 23593
	[Token(Token = "0x2005C29")]
	public class UIButtonLink : IUIButtonLink, IHotfixable
	{
		// Token: 0x0602233D RID: 140093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602233D")]
		[Address(RVA = "0x1CB5870", Offset = "0x1CB4470", VA = "0x181CB5870", Slot = "5")]
		public void PlayAudio(UIButton.AudioModule audio)
		{
		}

		// Token: 0x0602233E RID: 140094 RVA: 0x000BCA30 File Offset: 0x000BAC30
		[Token(Token = "0x602233E")]
		[Address(RVA = "0x1CB54B0", Offset = "0x1CB40B0", VA = "0x181CB54B0", Slot = "4")]
		public bool CheckClickFunc(UIButton uiButton)
		{
			return default(bool);
		}

		// Token: 0x0602233F RID: 140095 RVA: 0x000BCA48 File Offset: 0x000BAC48
		[Token(Token = "0x602233F")]
		[Address(RVA = "0x1CB5C80", Offset = "0x1CB4880", VA = "0x181CB5C80")]
		private bool _CheckPageAvail(UIButton.ClickGuardEnum detailEnum, UIButton button)
		{
			return default(bool);
		}

		// Token: 0x06022340 RID: 140096 RVA: 0x000BCA60 File Offset: 0x000BAC60
		[Token(Token = "0x6022340")]
		[Address(RVA = "0x1CB5DA0", Offset = "0x1CB49A0", VA = "0x181CB5DA0")]
		private bool _CheckStateAvail(UIButton.ClickGuardEnum detailEnum, UIButton button)
		{
			return default(bool);
		}

		// Token: 0x06022341 RID: 140097 RVA: 0x000BCA78 File Offset: 0x000BAC78
		[Token(Token = "0x6022341")]
		[Address(RVA = "0x1CB5B70", Offset = "0x1CB4770", VA = "0x181CB5B70")]
		private bool _CheckDialogAvail(UIButton.ClickGuardEnum detailEnum, UIButton button)
		{
			return default(bool);
		}

		// Token: 0x06022342 RID: 140098 RVA: 0x000BCA90 File Offset: 0x000BAC90
		[Token(Token = "0x6022342")]
		[Address(RVA = "0x1CB5A60", Offset = "0x1CB4660", VA = "0x181CB5A60")]
		private bool _CheckCommonAvail(UIButton.ClickGuardEnum detailEnum, UIButton button)
		{
			return default(bool);
		}

		// Token: 0x06022343 RID: 140099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022343")]
		[Address(RVA = "0x1CB5EB0", Offset = "0x1CB4AB0", VA = "0x181CB5EB0")]
		public UIButtonLink()
		{
		}

		// Token: 0x0402EEAF RID: 192175
		[Token(Token = "0x402EEAF")]
		[FieldOffset(Offset = "0x10")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402EEB0 RID: 192176
		[Token(Token = "0x402EEB0")]
		[FieldOffset(Offset = "0x20")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402EEB1 RID: 192177
		[Token(Token = "0x402EEB1")]
		[FieldOffset(Offset = "0x30")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x0402EEB2 RID: 192178
		[Token(Token = "0x402EEB2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PlayAudio;

		// Token: 0x0402EEB3 RID: 192179
		[Token(Token = "0x402EEB3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckClickFunc;

		// Token: 0x0402EEB4 RID: 192180
		[Token(Token = "0x402EEB4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckPageAvail;

		// Token: 0x0402EEB5 RID: 192181
		[Token(Token = "0x402EEB5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckStateAvail;

		// Token: 0x0402EEB6 RID: 192182
		[Token(Token = "0x402EEB6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckDialogAvail;

		// Token: 0x0402EEB7 RID: 192183
		[Token(Token = "0x402EEB7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckCommonAvail;

		// Token: 0x0402EEB8 RID: 192184
		[Token(Token = "0x402EEB8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
