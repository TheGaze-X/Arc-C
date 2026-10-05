using System;
using Il2CppDummyDll;
using Torappu.Building.UI.Train;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.BP
{
	// Token: 0x02001ABD RID: 6845
	[Token(Token = "0x2001ABD")]
	public class BTrainingRoom : BFunctionRoom
	{
		// Token: 0x0600ACEC RID: 44268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACEC")]
		[Address(RVA = "0x3279990", Offset = "0x3278590", VA = "0x183279990")]
		private void _InitData(object _object)
		{
		}

		// Token: 0x0600ACED RID: 44269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACED")]
		[Address(RVA = "0x3279920", Offset = "0x3278520", VA = "0x183279920")]
		private void Update()
		{
		}

		// Token: 0x0600ACEE RID: 44270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACEE")]
		[Address(RVA = "0x327A0B0", Offset = "0x3278CB0", VA = "0x18327A0B0")]
		private void _UpdateCountDownStatus()
		{
		}

		// Token: 0x0600ACEF RID: 44271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACEF")]
		[Address(RVA = "0x32795E0", Offset = "0x32781E0", VA = "0x1832795E0", Slot = "5")]
		protected override void OnInit(BRoomSlot roomSlot, RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600ACF0 RID: 44272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACF0")]
		[Address(RVA = "0x3279740", Offset = "0x3278340", VA = "0x183279740", Slot = "8")]
		protected override void OnRoomDestroy()
		{
		}

		// Token: 0x0600ACF1 RID: 44273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACF1")]
		[Address(RVA = "0x327A2C0", Offset = "0x3278EC0", VA = "0x18327A2C0")]
		public BTrainingRoom()
		{
		}

		// Token: 0x0600ACF3 RID: 44275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACF3")]
		[Address(RVA = "0x326DA20", Offset = "0x326C620", VA = "0x18326DA20")]
		private void <>xLuaBaseProxy_OnInit(BRoomSlot P0, RoomSlotModel P1)
		{
		}

		// Token: 0x0600ACF4 RID: 44276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACF4")]
		[Address(RVA = "0x326BF00", Offset = "0x326AB00", VA = "0x18326BF00")]
		private void <>xLuaBaseProxy_OnRoomDestroy()
		{
		}

		// Token: 0x0400A521 RID: 42273
		[Token(Token = "0x400A521")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private PiecewiseProgressBar _progressBar;

		// Token: 0x0400A522 RID: 42274
		[Token(Token = "0x400A522")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _isFinish;

		// Token: 0x0400A523 RID: 42275
		[Token(Token = "0x400A523")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _stateText;

		// Token: 0x0400A524 RID: 42276
		[Token(Token = "0x400A524")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Animator _shiningAnimator;

		// Token: 0x0400A525 RID: 42277
		[Token(Token = "0x400A525")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image _startImage;

		// Token: 0x0400A526 RID: 42278
		[Token(Token = "0x400A526")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Image _finishImage;

		// Token: 0x0400A527 RID: 42279
		[Token(Token = "0x400A527")]
		[FieldOffset(Offset = "0xB8")]
		private PlayerBuildingTraining m_trainingViewModel;

		// Token: 0x0400A528 RID: 42280
		[Token(Token = "0x400A528")]
		[FieldOffset(Offset = "0xC0")]
		private LevelUpSnapshot m_trainSnapshot;

		// Token: 0x0400A529 RID: 42281
		[Token(Token = "0x400A529")]
		[FieldOffset(Offset = "0xF0")]
		private CountDownTask m_countDown;

		// Token: 0x0400A52A RID: 42282
		[Token(Token = "0x400A52A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitData;

		// Token: 0x0400A52B RID: 42283
		[Token(Token = "0x400A52B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400A52C RID: 42284
		[Token(Token = "0x400A52C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateCountDownStatus;

		// Token: 0x0400A52D RID: 42285
		[Token(Token = "0x400A52D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400A52E RID: 42286
		[Token(Token = "0x400A52E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRoomDestroy;

		// Token: 0x0400A52F RID: 42287
		[Token(Token = "0x400A52F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
