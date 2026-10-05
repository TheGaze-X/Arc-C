using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003327 RID: 13095
	[Token(Token = "0x2003327")]
	public class UIShowCardState : UIStateNode
	{
		// Token: 0x17003163 RID: 12643
		// (get) Token: 0x06014D5E RID: 85342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003163")]
		private UICharacterInfoPanel characterInfo
		{
			[Token(Token = "0x6014D5E")]
			[Address(RVA = "0xD4D630", Offset = "0xD4C230", VA = "0x180D4D630")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003164 RID: 12644
		// (get) Token: 0x06014D5F RID: 85343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003164")]
		private UICardList cardList
		{
			[Token(Token = "0x6014D5F")]
			[Address(RVA = "0xD4D5D0", Offset = "0xD4C1D0", VA = "0x180D4D5D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003165 RID: 12645
		// (get) Token: 0x06014D60 RID: 85344 RVA: 0x00088D28 File Offset: 0x00086F28
		[Token(Token = "0x17003165")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6014D60")]
			[Address(RVA = "0xD4D710", Offset = "0xD4C310", VA = "0x180D4D710", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17003166 RID: 12646
		// (get) Token: 0x06014D61 RID: 85345 RVA: 0x00088D40 File Offset: 0x00086F40
		[Token(Token = "0x17003166")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x6014D61")]
			[Address(RVA = "0xD4D6B0", Offset = "0xD4C2B0", VA = "0x180D4D6B0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014D62 RID: 85346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D62")]
		[Address(RVA = "0xD4CDC0", Offset = "0xD4B9C0", VA = "0x180D4CDC0")]
		private void _OnCardToggled(object _)
		{
		}

		// Token: 0x06014D63 RID: 85347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D63")]
		[Address(RVA = "0xD4C870", Offset = "0xD4B470", VA = "0x180D4C870", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06014D64 RID: 85348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D64")]
		[Address(RVA = "0xD4C2D0", Offset = "0xD4AED0", VA = "0x180D4C2D0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06014D65 RID: 85349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D65")]
		[Address(RVA = "0xD4CA20", Offset = "0xD4B620", VA = "0x180D4CA20", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06014D66 RID: 85350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D66")]
		[Address(RVA = "0xD4C6D0", Offset = "0xD4B2D0", VA = "0x180D4C6D0", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x06014D67 RID: 85351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D67")]
		[Address(RVA = "0xD4D1B0", Offset = "0xD4BDB0", VA = "0x180D4D1B0")]
		private void _OnTileClicked(Tile tile)
		{
		}

		// Token: 0x06014D68 RID: 85352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D68")]
		[Address(RVA = "0xD4D570", Offset = "0xD4C170", VA = "0x180D4D570")]
		public UIShowCardState()
		{
		}

		// Token: 0x06014D6A RID: 85354 RVA: 0x00088D58 File Offset: 0x00086F58
		[Token(Token = "0x6014D6A")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06014D6B RID: 85355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D6B")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x06014D6C RID: 85356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D6C")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06014D6D RID: 85357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D6D")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x04018C63 RID: 101475
		[Token(Token = "0x4018C63")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICardList _cardList;

		// Token: 0x04018C64 RID: 101476
		[Token(Token = "0x4018C64")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_characterInfo;

		// Token: 0x04018C65 RID: 101477
		[Token(Token = "0x4018C65")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cardList;

		// Token: 0x04018C66 RID: 101478
		[Token(Token = "0x4018C66")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04018C67 RID: 101479
		[Token(Token = "0x4018C67")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04018C68 RID: 101480
		[Token(Token = "0x4018C68")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnCardToggled;

		// Token: 0x04018C69 RID: 101481
		[Token(Token = "0x4018C69")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04018C6A RID: 101482
		[Token(Token = "0x4018C6A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04018C6B RID: 101483
		[Token(Token = "0x4018C6B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04018C6C RID: 101484
		[Token(Token = "0x4018C6C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04018C6D RID: 101485
		[Token(Token = "0x4018C6D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnTileClicked;

		// Token: 0x04018C6E RID: 101486
		[Token(Token = "0x4018C6E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
