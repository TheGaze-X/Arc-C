using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act45Side
{
	// Token: 0x020072CE RID: 29390
	[Token(Token = "0x20072CE")]
	public class Act45SideStageLiveView : Act45SideStageBaseView
	{
		// Token: 0x0602998F RID: 170383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602998F")]
		[Address(RVA = "0x24FD3A0", Offset = "0x24FBFA0", VA = "0x1824FD3A0", Slot = "5")]
		public override void OnCurtainOut(bool isActive)
		{
		}

		// Token: 0x06029990 RID: 170384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029990")]
		[Address(RVA = "0x24FD280", Offset = "0x24FBE80", VA = "0x1824FD280", Slot = "6")]
		public override void OnBgmReplay()
		{
		}

		// Token: 0x06029991 RID: 170385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029991")]
		[Address(RVA = "0x24FD650", Offset = "0x24FC250", VA = "0x1824FD650", Slot = "8")]
		protected override void _SetUpIfNot(Act45SideLiveViewModel viewModel)
		{
		}

		// Token: 0x06029992 RID: 170386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029992")]
		[Address(RVA = "0x24FD5A0", Offset = "0x24FC1A0", VA = "0x1824FD5A0")]
		private IEnumerator _ReplayLiveLoopAnim()
		{
			return null;
		}

		// Token: 0x06029993 RID: 170387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029993")]
		[Address(RVA = "0x24FD470", Offset = "0x24FC070", VA = "0x1824FD470")]
		private void Update()
		{
		}

		// Token: 0x06029994 RID: 170388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029994")]
		[Address(RVA = "0x24FD730", Offset = "0x24FC330", VA = "0x1824FD730")]
		public Act45SideStageLiveView()
		{
		}

		// Token: 0x06029995 RID: 170389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029995")]
		[Address(RVA = "0x24FD450", Offset = "0x24FC050", VA = "0x1824FD450")]
		private void <>xLuaBaseProxy_OnCurtainOut(bool P0)
		{
		}

		// Token: 0x06029996 RID: 170390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029996")]
		[Address(RVA = "0x24FCC40", Offset = "0x24FB840", VA = "0x1824FCC40")]
		private void <>xLuaBaseProxy_OnBgmReplay()
		{
		}

		// Token: 0x06029997 RID: 170391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029997")]
		[Address(RVA = "0x24FD460", Offset = "0x24FC060", VA = "0x1824FD460")]
		private void <>xLuaBaseProxy__SetUpIfNot(Act45SideLiveViewModel P0)
		{
		}

		// Token: 0x0403B7E8 RID: 243688
		[Token(Token = "0x403B7E8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _liveLoopAnim;

		// Token: 0x0403B7E9 RID: 243689
		[Token(Token = "0x403B7E9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _bgmFadeInTime;

		// Token: 0x0403B7EA RID: 243690
		[Token(Token = "0x403B7EA")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private int _animFrameOffset;

		// Token: 0x0403B7EB RID: 243691
		[Token(Token = "0x403B7EB")]
		[FieldOffset(Offset = "0x70")]
		private bool m_needUpdateAnim;

		// Token: 0x0403B7EC RID: 243692
		[Token(Token = "0x403B7EC")]
		[FieldOffset(Offset = "0x78")]
		private AnimationWrapper m_animWrapper;

		// Token: 0x0403B7ED RID: 243693
		[Token(Token = "0x403B7ED")]
		[FieldOffset(Offset = "0x80")]
		private string m_animName;

		// Token: 0x0403B7EE RID: 243694
		[Token(Token = "0x403B7EE")]
		[FieldOffset(Offset = "0x88")]
		private float m_animLength;

		// Token: 0x0403B7EF RID: 243695
		[Token(Token = "0x403B7EF")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403B7F0 RID: 243696
		[Token(Token = "0x403B7F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCurtainOut;

		// Token: 0x0403B7F1 RID: 243697
		[Token(Token = "0x403B7F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnBgmReplay;

		// Token: 0x0403B7F2 RID: 243698
		[Token(Token = "0x403B7F2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetUpIfNot;

		// Token: 0x0403B7F3 RID: 243699
		[Token(Token = "0x403B7F3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ReplayLiveLoopAnim;

		// Token: 0x0403B7F4 RID: 243700
		[Token(Token = "0x403B7F4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0403B7F5 RID: 243701
		[Token(Token = "0x403B7F5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
