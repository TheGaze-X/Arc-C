using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D90 RID: 15760
	[Token(Token = "0x2003D90")]
	public abstract class TemplateMissionCommonBigRewardIllustView : TemplateMissionBigRewardView, IHotfixable
	{
		// Token: 0x0601883B RID: 100411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601883B")]
		[Address(RVA = "0x1109BC0", Offset = "0x11087C0", VA = "0x181109BC0")]
		protected void LoadAndSetIllust(CharUISkinStruct skinStruct, RectTransform container, ref UICharacterIllust charIllust)
		{
		}

		// Token: 0x0601883C RID: 100412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601883C")]
		[Address(RVA = "0x1109DD0", Offset = "0x11089D0", VA = "0x181109DD0")]
		protected void RefreshCharIllustPos(UICharacterIllust charIllust, List<string> paramList)
		{
		}

		// Token: 0x0601883D RID: 100413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601883D")]
		[Address(RVA = "0x110A010", Offset = "0x1108C10", VA = "0x18110A010")]
		protected TemplateMissionCommonBigRewardIllustView()
		{
		}

		// Token: 0x0401E0C3 RID: 123075
		[Token(Token = "0x401E0C3")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401E0C4 RID: 123076
		[Token(Token = "0x401E0C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadAndSetIllust;

		// Token: 0x0401E0C5 RID: 123077
		[Token(Token = "0x401E0C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshCharIllustPos;

		// Token: 0x0401E0C6 RID: 123078
		[Token(Token = "0x401E0C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
