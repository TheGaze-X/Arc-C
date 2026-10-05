using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062A5 RID: 25253
	[Token(Token = "0x20062A5")]
	public class AutoChessBattleReadyState : AutoChessPrepareBaseState, IAutoChessPrepareStateHandler, IHotfixable
	{
		// Token: 0x06024676 RID: 149110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024676")]
		[Address(RVA = "0x1F29F20", Offset = "0x1F28B20", VA = "0x181F29F20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06024677 RID: 149111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024677")]
		[Address(RVA = "0x1F2A120", Offset = "0x1F28D20", VA = "0x181F2A120", Slot = "31")]
		protected override void OnStateEnter()
		{
		}

		// Token: 0x06024678 RID: 149112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024678")]
		[Address(RVA = "0x1F29F80", Offset = "0x1F28B80", VA = "0x181F29F80", Slot = "32")]
		public void OnDataChanged(AutoChessPrepareModel prepareModel)
		{
		}

		// Token: 0x06024679 RID: 149113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024679")]
		[Address(RVA = "0x1F2A5D0", Offset = "0x1F291D0", VA = "0x181F2A5D0")]
		private void _PlayEnterAnim()
		{
		}

		// Token: 0x0602467A RID: 149114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602467A")]
		[Address(RVA = "0x1F2A530", Offset = "0x1F29130", VA = "0x181F2A530")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602467B RID: 149115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602467B")]
		[Address(RVA = "0x1F2A740", Offset = "0x1F29340", VA = "0x181F2A740")]
		public AutoChessBattleReadyState()
		{
		}

		// Token: 0x0602467C RID: 149116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602467C")]
		[Address(RVA = "0x1F25FB0", Offset = "0x1F24BB0", VA = "0x181F25FB0")]
		private void <>xLuaBaseProxy_OnStateEnter()
		{
		}

		// Token: 0x04032A8A RID: 207498
		[Token(Token = "0x4032A8A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04032A8B RID: 207499
		[Token(Token = "0x4032A8B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AutoChessBattleReadyGroupView _groupView;

		// Token: 0x04032A8C RID: 207500
		[Token(Token = "0x4032A8C")]
		[FieldOffset(Offset = "0x98")]
		private AutoChessBattleReadyStateBean m_stateBean;

		// Token: 0x04032A8D RID: 207501
		[Token(Token = "0x4032A8D")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_hasInited;

		// Token: 0x04032A8E RID: 207502
		[Token(Token = "0x4032A8E")]
		[FieldOffset(Offset = "0xA8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04032A8F RID: 207503
		[Token(Token = "0x4032A8F")]
		[FieldOffset(Offset = "0xB8")]
		private Tween m_enterAnim;

		// Token: 0x04032A90 RID: 207504
		[Token(Token = "0x4032A90")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04032A91 RID: 207505
		[Token(Token = "0x4032A91")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStateEnter;

		// Token: 0x04032A92 RID: 207506
		[Token(Token = "0x4032A92")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDataChanged;

		// Token: 0x04032A93 RID: 207507
		[Token(Token = "0x4032A93")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x04032A94 RID: 207508
		[Token(Token = "0x4032A94")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032A95 RID: 207509
		[Token(Token = "0x4032A95")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
