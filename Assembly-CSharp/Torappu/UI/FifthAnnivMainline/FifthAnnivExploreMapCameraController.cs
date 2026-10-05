using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004ECE RID: 20174
	[Token(Token = "0x2004ECE")]
	public class FifthAnnivExploreMapCameraController : DataBinder<FifthAnnivExploreProperty>
	{
		// Token: 0x0601E198 RID: 123288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E198")]
		[Address(RVA = "0x17CBCE0", Offset = "0x17CA8E0", VA = "0x1817CBCE0", Slot = "7")]
		public override void OnValueChanged(FifthAnnivExploreProperty property)
		{
		}

		// Token: 0x0601E199 RID: 123289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E199")]
		[Address(RVA = "0x17CBEB0", Offset = "0x17CAAB0", VA = "0x1817CBEB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E19A RID: 123290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E19A")]
		[Address(RVA = "0x17CC010", Offset = "0x17CAC10", VA = "0x1817CC010")]
		public FifthAnnivExploreMapCameraController()
		{
		}

		// Token: 0x040280B6 RID: 164022
		[Token(Token = "0x40280B6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Camera _mapCamera;

		// Token: 0x040280B7 RID: 164023
		[Token(Token = "0x40280B7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BlurScreenTexGenerator _blurGenerator;

		// Token: 0x040280B8 RID: 164024
		[Token(Token = "0x40280B8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIBlendRTHost _blendRTHost;

		// Token: 0x040280B9 RID: 164025
		[Token(Token = "0x40280B9")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x040280BA RID: 164026
		[Token(Token = "0x40280BA")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040280BB RID: 164027
		[Token(Token = "0x40280BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040280BC RID: 164028
		[Token(Token = "0x40280BC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040280BD RID: 164029
		[Token(Token = "0x40280BD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
