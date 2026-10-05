using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200765E RID: 30302
	[Token(Token = "0x200765E")]
	public class Act20sideCartCompSelectState : PopupFloatState
	{
		// Token: 0x0602A9EA RID: 174570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A9EA")]
		[Address(RVA = "0x2653DD0", Offset = "0x26529D0", VA = "0x182653DD0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0602A9EB RID: 174571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A9EB")]
		[Address(RVA = "0x2653B30", Offset = "0x2652730", VA = "0x182653B30", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602A9EC RID: 174572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9EC")]
		[Address(RVA = "0x2653B90", Offset = "0x2652790", VA = "0x182653B90", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602A9ED RID: 174573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9ED")]
		[Address(RVA = "0x2653C20", Offset = "0x2652820", VA = "0x182653C20")]
		public void SetComp(string compId)
		{
		}

		// Token: 0x0602A9EE RID: 174574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9EE")]
		[Address(RVA = "0x2653D00", Offset = "0x2652900", VA = "0x182653D00")]
		public void SetPos(CartComponents.CartAccessoryPos pos)
		{
		}

		// Token: 0x0602A9EF RID: 174575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9EF")]
		[Address(RVA = "0x2653A90", Offset = "0x2652690", VA = "0x182653A90")]
		public void ConfirmSelectComp()
		{
		}

		// Token: 0x0602A9F0 RID: 174576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9F0")]
		[Address(RVA = "0x26540A0", Offset = "0x2652CA0", VA = "0x1826540A0")]
		private void _ConfirmBattle()
		{
		}

		// Token: 0x0602A9F1 RID: 174577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9F1")]
		[Address(RVA = "0x26544C0", Offset = "0x26530C0", VA = "0x1826544C0")]
		private void _ConfirmExhibt()
		{
		}

		// Token: 0x0602A9F2 RID: 174578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9F2")]
		[Address(RVA = "0x2654900", Offset = "0x2653500", VA = "0x182654900")]
		public Act20sideCartCompSelectState()
		{
		}

		// Token: 0x0602A9F6 RID: 174582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A9F6")]
		[Address(RVA = "0x15A41D0", Offset = "0x15A2DD0", VA = "0x1815A41D0")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0602A9F7 RID: 174583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9F7")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403D610 RID: 251408
		[Token(Token = "0x403D610")]
		private const string ANIM_PARAM = "comp_selectin_anim";

		// Token: 0x0403D611 RID: 251409
		[Token(Token = "0x403D611")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act20sideCartCompSelectStateBean _stateBean;

		// Token: 0x0403D612 RID: 251410
		[Token(Token = "0x403D612")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0403D613 RID: 251411
		[Token(Token = "0x403D613")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403D614 RID: 251412
		[Token(Token = "0x403D614")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403D615 RID: 251413
		[Token(Token = "0x403D615")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403D616 RID: 251414
		[Token(Token = "0x403D616")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetComp;

		// Token: 0x0403D617 RID: 251415
		[Token(Token = "0x403D617")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetPos;

		// Token: 0x0403D618 RID: 251416
		[Token(Token = "0x403D618")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ConfirmSelectComp;

		// Token: 0x0403D619 RID: 251417
		[Token(Token = "0x403D619")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ConfirmBattle;

		// Token: 0x0403D61A RID: 251418
		[Token(Token = "0x403D61A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ConfirmExhibt;

		// Token: 0x0403D61B RID: 251419
		[Token(Token = "0x403D61B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
