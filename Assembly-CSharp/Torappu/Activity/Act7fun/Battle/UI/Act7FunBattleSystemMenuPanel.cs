using System;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act7Fun.Battle.UI
{
	// Token: 0x020071A2 RID: 29090
	[Token(Token = "0x20071A2")]
	[RequireComponent(typeof(CanvasGroup))]
	public class Act7FunBattleSystemMenuPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x170061B0 RID: 25008
		// (get) Token: 0x06029461 RID: 169057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170061B0")]
		private GameModeFactory.Act7FunGameMode gamMode
		{
			[Token(Token = "0x6029461")]
			[Address(RVA = "0x24BA330", Offset = "0x24B8F30", VA = "0x1824BA330")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029462 RID: 169058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029462")]
		[Address(RVA = "0x24BA000", Offset = "0x24B8C00", VA = "0x1824BA000")]
		public void Show()
		{
		}

		// Token: 0x06029463 RID: 169059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029463")]
		[Address(RVA = "0x24B9D00", Offset = "0x24B8900", VA = "0x1824B9D00")]
		public void Hide()
		{
		}

		// Token: 0x06029464 RID: 169060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029464")]
		[Address(RVA = "0x24B9D90", Offset = "0x24B8990", VA = "0x1824B9D90")]
		public void OnCancel()
		{
		}

		// Token: 0x06029465 RID: 169061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029465")]
		[Address(RVA = "0x24B9F80", Offset = "0x24B8B80", VA = "0x1824B9F80")]
		public void OnRestartForBattle()
		{
		}

		// Token: 0x06029466 RID: 169062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029466")]
		[Address(RVA = "0x24B9E40", Offset = "0x24B8A40", VA = "0x1824B9E40")]
		public void OnConfirmFinish()
		{
		}

		// Token: 0x06029467 RID: 169063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029467")]
		[Address(RVA = "0x24BA190", Offset = "0x24B8D90", VA = "0x1824BA190")]
		private void _SwitchToBattleFinish()
		{
		}

		// Token: 0x06029468 RID: 169064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029468")]
		[Address(RVA = "0x24B9C80", Offset = "0x24B8880", VA = "0x1824B9C80")]
		private void Awake()
		{
		}

		// Token: 0x06029469 RID: 169065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029469")]
		[Address(RVA = "0x24BA2A0", Offset = "0x24B8EA0", VA = "0x1824BA2A0")]
		public Act7FunBattleSystemMenuPanel()
		{
		}

		// Token: 0x0403AF30 RID: 241456
		[Token(Token = "0x403AF30")]
		private const string LOG_GIVE_UP = "SIMPLE,give_up";

		// Token: 0x0403AF31 RID: 241457
		[Token(Token = "0x403AF31")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0403AF32 RID: 241458
		[Token(Token = "0x403AF32")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _animName;

		// Token: 0x0403AF33 RID: 241459
		[Token(Token = "0x403AF33")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _unityStyle;

		// Token: 0x0403AF34 RID: 241460
		[Token(Token = "0x403AF34")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _winStyle;

		// Token: 0x0403AF35 RID: 241461
		[Token(Token = "0x403AF35")]
		[FieldOffset(Offset = "0x38")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x0403AF36 RID: 241462
		[Token(Token = "0x403AF36")]
		[FieldOffset(Offset = "0x40")]
		private GameModeFactory.Act7FunGameMode m_gameMode;

		// Token: 0x0403AF37 RID: 241463
		[Token(Token = "0x403AF37")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_gamMode;

		// Token: 0x0403AF38 RID: 241464
		[Token(Token = "0x403AF38")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0403AF39 RID: 241465
		[Token(Token = "0x403AF39")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0403AF3A RID: 241466
		[Token(Token = "0x403AF3A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x0403AF3B RID: 241467
		[Token(Token = "0x403AF3B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRestartForBattle;

		// Token: 0x0403AF3C RID: 241468
		[Token(Token = "0x403AF3C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnConfirmFinish;

		// Token: 0x0403AF3D RID: 241469
		[Token(Token = "0x403AF3D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SwitchToBattleFinish;

		// Token: 0x0403AF3E RID: 241470
		[Token(Token = "0x403AF3E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0403AF3F RID: 241471
		[Token(Token = "0x403AF3F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
