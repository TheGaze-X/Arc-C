using System;
using System.Collections;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007970 RID: 31088
	[Token(Token = "0x2007970")]
	public class Act1ArcadeSettlementStatusBadgeView : Act1ArcadeSettlementStatusBaseView
	{
		// Token: 0x17006638 RID: 26168
		// (get) Token: 0x0602B9B1 RID: 178609 RVA: 0x000DC908 File Offset: 0x000DAB08
		[Token(Token = "0x17006638")]
		public override Act1ArcadeSettlementModel.SettlementViewStatus viewStatus
		{
			[Token(Token = "0x602B9B1")]
			[Address(RVA = "0x2783720", Offset = "0x2782320", VA = "0x182783720", Slot = "4")]
			get
			{
				return Act1ArcadeSettlementModel.SettlementViewStatus.None;
			}
		}

		// Token: 0x17006639 RID: 26169
		// (get) Token: 0x0602B9B2 RID: 178610 RVA: 0x000DC920 File Offset: 0x000DAB20
		[Token(Token = "0x17006639")]
		public override Act1ArcadeSettlementModel.SettlementViewStatus nextViewStatus
		{
			[Token(Token = "0x602B9B2")]
			[Address(RVA = "0x27836C0", Offset = "0x27822C0", VA = "0x1827836C0", Slot = "5")]
			get
			{
				return Act1ArcadeSettlementModel.SettlementViewStatus.None;
			}
		}

		// Token: 0x0602B9B3 RID: 178611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9B3")]
		[Address(RVA = "0x27832C0", Offset = "0x2781EC0", VA = "0x1827832C0", Slot = "6")]
		public override void SetToDefaultShow()
		{
		}

		// Token: 0x0602B9B4 RID: 178612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9B4")]
		[Address(RVA = "0x2783000", Offset = "0x2781C00", VA = "0x182783000", Slot = "7")]
		public override void ChangeInStatusAndRender(Act1ArcadeSettlementModel model)
		{
		}

		// Token: 0x0602B9B5 RID: 178613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B9B5")]
		[Address(RVA = "0x2783510", Offset = "0x2782110", VA = "0x182783510")]
		private IEnumerator _PlayAnim(UIAnimationLocation anim, [Optional] TweenCallback onComplete)
		{
			return null;
		}

		// Token: 0x0602B9B6 RID: 178614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9B6")]
		[Address(RVA = "0x2783180", Offset = "0x2781D80", VA = "0x182783180", Slot = "8")]
		public override void LeaveStatus()
		{
		}

		// Token: 0x0602B9B7 RID: 178615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9B7")]
		[Address(RVA = "0x27834A0", Offset = "0x27820A0", VA = "0x1827834A0")]
		private void _OnLeaveAnimEnd()
		{
		}

		// Token: 0x0602B9B8 RID: 178616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9B8")]
		[Address(RVA = "0x27830E0", Offset = "0x2781CE0", VA = "0x1827830E0")]
		public void EventOnClickBg()
		{
		}

		// Token: 0x0602B9B9 RID: 178617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9B9")]
		[Address(RVA = "0x2783620", Offset = "0x2782220", VA = "0x182783620")]
		public Act1ArcadeSettlementStatusBadgeView()
		{
		}

		// Token: 0x0602B9BA RID: 178618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9BA")]
		[Address(RVA = "0x2783440", Offset = "0x2782040", VA = "0x182783440")]
		private void <>xLuaBaseProxy_SetToDefaultShow()
		{
		}

		// Token: 0x0602B9BB RID: 178619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9BB")]
		[Address(RVA = "0x2783370", Offset = "0x2781F70", VA = "0x182783370")]
		private void <>xLuaBaseProxy_ChangeInStatusAndRender(Act1ArcadeSettlementModel P0)
		{
		}

		// Token: 0x0602B9BC RID: 178620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9BC")]
		[Address(RVA = "0x27833E0", Offset = "0x2781FE0", VA = "0x1827833E0")]
		private void <>xLuaBaseProxy_LeaveStatus()
		{
		}

		// Token: 0x0403F155 RID: 258389
		[Token(Token = "0x403F155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x0403F156 RID: 258390
		[Token(Token = "0x403F156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _leaveAnim;

		// Token: 0x0403F157 RID: 258391
		[Token(Token = "0x403F157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Arc1ArcadeSettlementBadgeHolder _badgeHolder;

		// Token: 0x0403F158 RID: 258392
		[Token(Token = "0x403F158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_blockClick;

		// Token: 0x0403F159 RID: 258393
		[Token(Token = "0x403F159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Act1ArcadeSettlementModel m_model;

		// Token: 0x0403F15A RID: 258394
		[Token(Token = "0x403F15A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403F15B RID: 258395
		[Token(Token = "0x403F15B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewStatus;

		// Token: 0x0403F15C RID: 258396
		[Token(Token = "0x403F15C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_nextViewStatus;

		// Token: 0x0403F15D RID: 258397
		[Token(Token = "0x403F15D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetToDefaultShow;

		// Token: 0x0403F15E RID: 258398
		[Token(Token = "0x403F15E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ChangeInStatusAndRender;

		// Token: 0x0403F15F RID: 258399
		[Token(Token = "0x403F15F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x0403F160 RID: 258400
		[Token(Token = "0x403F160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LeaveStatus;

		// Token: 0x0403F161 RID: 258401
		[Token(Token = "0x403F161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnLeaveAnimEnd;

		// Token: 0x0403F162 RID: 258402
		[Token(Token = "0x403F162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnClickBg;

		// Token: 0x0403F163 RID: 258403
		[Token(Token = "0x403F163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
