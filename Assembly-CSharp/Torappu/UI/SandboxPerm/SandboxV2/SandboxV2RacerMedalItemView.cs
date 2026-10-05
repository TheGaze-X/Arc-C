using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004372 RID: 17266
	[Token(Token = "0x2004372")]
	public class SandboxV2RacerMedalItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A7D3 RID: 108499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7D3")]
		[Address(RVA = "0x13963D0", Offset = "0x1394FD0", VA = "0x1813963D0")]
		public void Render(SandboxV2RacerMedalModel model)
		{
		}

		// Token: 0x0601A7D4 RID: 108500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7D4")]
		[Address(RVA = "0x13965B0", Offset = "0x13951B0", VA = "0x1813965B0")]
		public SandboxV2RacerMedalItemView()
		{
		}

		// Token: 0x04021B71 RID: 138097
		[Token(Token = "0x4021B71")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x04021B72 RID: 138098
		[Token(Token = "0x4021B72")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04021B73 RID: 138099
		[Token(Token = "0x4021B73")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04021B74 RID: 138100
		[Token(Token = "0x4021B74")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04021B75 RID: 138101
		[Token(Token = "0x4021B75")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021B76 RID: 138102
		[Token(Token = "0x4021B76")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
