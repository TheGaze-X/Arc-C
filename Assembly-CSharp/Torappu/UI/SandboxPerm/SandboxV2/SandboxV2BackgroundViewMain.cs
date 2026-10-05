using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200423C RID: 16956
	[Token(Token = "0x200423C")]
	public class SandboxV2BackgroundViewMain : SandboxV2AbstractBackgroundView
	{
		// Token: 0x0601A238 RID: 107064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A238")]
		[Address(RVA = "0x12FEB60", Offset = "0x12FD760", VA = "0x1812FEB60", Slot = "4")]
		public override void Render(SandboxV2DungeonViewModel viewModel)
		{
		}

		// Token: 0x0601A239 RID: 107065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A239")]
		[Address(RVA = "0x12FED20", Offset = "0x12FD920", VA = "0x1812FED20")]
		public SandboxV2BackgroundViewMain()
		{
		}

		// Token: 0x04021025 RID: 135205
		[Token(Token = "0x4021025")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imageBkg;

		// Token: 0x04021026 RID: 135206
		[Token(Token = "0x4021026")]
		[FieldOffset(Offset = "0x28")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04021027 RID: 135207
		[Token(Token = "0x4021027")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021028 RID: 135208
		[Token(Token = "0x4021028")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
