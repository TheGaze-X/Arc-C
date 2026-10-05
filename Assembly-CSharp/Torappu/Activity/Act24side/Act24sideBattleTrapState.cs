using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007574 RID: 30068
	[Token(Token = "0x2007574")]
	public class Act24sideBattleTrapState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0602A54F RID: 173391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A54F")]
		[Address(RVA = "0x25FA100", Offset = "0x25F8D00", VA = "0x1825FA100", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602A550 RID: 173392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A550")]
		[Address(RVA = "0x25FA160", Offset = "0x25F8D60", VA = "0x1825FA160", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602A551 RID: 173393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A551")]
		[Address(RVA = "0x25FAEB0", Offset = "0x25F9AB0", VA = "0x1825FAEB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A552 RID: 173394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A552")]
		[Address(RVA = "0x25FB080", Offset = "0x25F9C80", VA = "0x1825FB080")]
		private void _SendSetTrapConfirmRequest()
		{
		}

		// Token: 0x0602A553 RID: 173395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A553")]
		[Address(RVA = "0x25FA810", Offset = "0x25F9410", VA = "0x1825FA810")]
		private void _Close()
		{
		}

		// Token: 0x0602A554 RID: 173396 RVA: 0x000D8138 File Offset: 0x000D6338
		[Token(Token = "0x602A554")]
		[Address(RVA = "0x25FA740", Offset = "0x25F9340", VA = "0x1825FA740")]
		private bool _CheckIsTransiting()
		{
			return default(bool);
		}

		// Token: 0x0602A555 RID: 173397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A555")]
		[Address(RVA = "0x25FA510", Offset = "0x25F9110", VA = "0x1825FA510", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602A556 RID: 173398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A556")]
		[Address(RVA = "0x25F9EC0", Offset = "0x25F8AC0", VA = "0x1825F9EC0")]
		public void EventOnBtnExit()
		{
		}

		// Token: 0x0602A557 RID: 173399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A557")]
		[Address(RVA = "0x25FA9B0", Offset = "0x25F95B0", VA = "0x1825FA9B0")]
		private void _EventOnConfirmClick()
		{
		}

		// Token: 0x0602A558 RID: 173400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A558")]
		[Address(RVA = "0x25FAB30", Offset = "0x25F9730", VA = "0x1825FAB30")]
		private void _EventOnTrapClick(string trapId)
		{
		}

		// Token: 0x0602A559 RID: 173401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A559")]
		[Address(RVA = "0x25FB480", Offset = "0x25FA080", VA = "0x1825FB480")]
		public Act24sideBattleTrapState()
		{
		}

		// Token: 0x0602A55B RID: 173403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A55B")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403CE0E RID: 249358
		[Token(Token = "0x403CE0E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act24sideBattleTrapView _view;

		// Token: 0x0403CE0F RID: 249359
		[Token(Token = "0x403CE0F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _btnExitRt;

		// Token: 0x0403CE10 RID: 249360
		[Token(Token = "0x403CE10")]
		[NonSerialized]
		public const int MSG_CONFIRM_CLICKED = 1;

		// Token: 0x0403CE11 RID: 249361
		[Token(Token = "0x403CE11")]
		[NonSerialized]
		public const int MSG_TRAP_CLICKED = 2;

		// Token: 0x0403CE12 RID: 249362
		[Token(Token = "0x403CE12")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0403CE13 RID: 249363
		[Token(Token = "0x403CE13")]
		[FieldOffset(Offset = "0x88")]
		private Act24sideBattleTrapViewProperty m_property;

		// Token: 0x0403CE14 RID: 249364
		[Token(Token = "0x403CE14")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403CE15 RID: 249365
		[Token(Token = "0x403CE15")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403CE16 RID: 249366
		[Token(Token = "0x403CE16")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CE17 RID: 249367
		[Token(Token = "0x403CE17")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SendSetTrapConfirmRequest;

		// Token: 0x0403CE18 RID: 249368
		[Token(Token = "0x403CE18")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Close;

		// Token: 0x0403CE19 RID: 249369
		[Token(Token = "0x403CE19")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckIsTransiting;

		// Token: 0x0403CE1A RID: 249370
		[Token(Token = "0x403CE1A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403CE1B RID: 249371
		[Token(Token = "0x403CE1B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnBtnExit;

		// Token: 0x0403CE1C RID: 249372
		[Token(Token = "0x403CE1C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnConfirmClick;

		// Token: 0x0403CE1D RID: 249373
		[Token(Token = "0x403CE1D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnTrapClick;

		// Token: 0x0403CE1E RID: 249374
		[Token(Token = "0x403CE1E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
