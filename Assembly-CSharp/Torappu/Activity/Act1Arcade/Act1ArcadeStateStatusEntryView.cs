using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x020079A3 RID: 31139
	[Token(Token = "0x20079A3")]
	public class Act1ArcadeStateStatusEntryView : Act1ArcadeStateStatusBaseView
	{
		// Token: 0x0602BAEA RID: 178922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAEA")]
		[Address(RVA = "0x27A7D70", Offset = "0x27A6970", VA = "0x1827A7D70", Slot = "5")]
		public override void PreResumeView(bool isFromStack)
		{
		}

		// Token: 0x0602BAEB RID: 178923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAEB")]
		[Address(RVA = "0x27A7CB0", Offset = "0x27A68B0", VA = "0x1827A7CB0", Slot = "7")]
		public override void LeaveView()
		{
		}

		// Token: 0x0602BAEC RID: 178924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAEC")]
		[Address(RVA = "0x27A7FE0", Offset = "0x27A6BE0", VA = "0x1827A7FE0")]
		public Act1ArcadeStateStatusEntryView()
		{
		}

		// Token: 0x0602BAED RID: 178925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAED")]
		[Address(RVA = "0x27A7FD0", Offset = "0x27A6BD0", VA = "0x1827A7FD0")]
		private void <>xLuaBaseProxy_PreResumeView(bool P0)
		{
		}

		// Token: 0x0602BAEE RID: 178926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAEE")]
		[Address(RVA = "0x27A7A60", Offset = "0x27A6660", VA = "0x1827A7A60")]
		private void <>xLuaBaseProxy_LeaveView()
		{
		}

		// Token: 0x0403F338 RID: 258872
		[Token(Token = "0x403F338")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x0403F339 RID: 258873
		[Token(Token = "0x403F339")]
		[FieldOffset(Offset = "0x28")]
		private Tween m_animTween;

		// Token: 0x0403F33A RID: 258874
		[Token(Token = "0x403F33A")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403F33B RID: 258875
		[Token(Token = "0x403F33B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PreResumeView;

		// Token: 0x0403F33C RID: 258876
		[Token(Token = "0x403F33C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LeaveView;

		// Token: 0x0403F33D RID: 258877
		[Token(Token = "0x403F33D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
