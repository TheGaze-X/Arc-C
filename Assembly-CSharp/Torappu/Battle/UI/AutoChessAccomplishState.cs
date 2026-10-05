using System;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032A2 RID: 12962
	[Token(Token = "0x20032A2")]
	public class AutoChessAccomplishState : UIStateNode
	{
		// Token: 0x170030BF RID: 12479
		// (get) Token: 0x06014975 RID: 84341 RVA: 0x00087A08 File Offset: 0x00085C08
		[Token(Token = "0x170030BF")]
		public override bool enablePerspectiveCanvas
		{
			[Token(Token = "0x6014975")]
			[Address(RVA = "0xCC46C0", Offset = "0xCC32C0", VA = "0x180CC46C0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170030C0 RID: 12480
		// (get) Token: 0x06014976 RID: 84342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030C0")]
		private AutoChessCameraPlugin cameraPlugin
		{
			[Token(Token = "0x6014976")]
			[Address(RVA = "0xCC45B0", Offset = "0xCC31B0", VA = "0x180CC45B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030C1 RID: 12481
		// (get) Token: 0x06014977 RID: 84343 RVA: 0x00087A20 File Offset: 0x00085C20
		[Token(Token = "0x170030C1")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6014977")]
			[Address(RVA = "0xCC4720", Offset = "0xCC3320", VA = "0x180CC4720", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x170030C2 RID: 12482
		// (get) Token: 0x06014978 RID: 84344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030C2")]
		private UIAnimationPerform accomplishedPerform
		{
			[Token(Token = "0x6014978")]
			[Address(RVA = "0xCC4530", Offset = "0xCC3130", VA = "0x180CC4530")]
			get
			{
				return null;
			}
		}

		// Token: 0x06014979 RID: 84345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014979")]
		[Address(RVA = "0xCC3FA0", Offset = "0xCC2BA0", VA = "0x180CC3FA0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x0601497A RID: 84346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601497A")]
		[Address(RVA = "0xCC4060", Offset = "0xCC2C60", VA = "0x180CC4060", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0601497B RID: 84347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601497B")]
		[Address(RVA = "0xCC40C0", Offset = "0xCC2CC0", VA = "0x180CC40C0")]
		private void _PlayPerform()
		{
		}

		// Token: 0x0601497C RID: 84348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601497C")]
		[Address(RVA = "0xCC44D0", Offset = "0xCC30D0", VA = "0x180CC44D0")]
		public AutoChessAccomplishState()
		{
		}

		// Token: 0x0601497D RID: 84349 RVA: 0x00087A38 File Offset: 0x00085C38
		[Token(Token = "0x601497D")]
		[Address(RVA = "0x962380", Offset = "0x960F80", VA = "0x180962380")]
		private bool <>xLuaBaseProxy_get_enablePerspectiveCanvas()
		{
			return default(bool);
		}

		// Token: 0x0601497E RID: 84350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601497E")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x040185DB RID: 99803
		[Token(Token = "0x40185DB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _preformOffset;

		// Token: 0x040185DC RID: 99804
		[Token(Token = "0x40185DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_enablePerspectiveCanvas;

		// Token: 0x040185DD RID: 99805
		[Token(Token = "0x40185DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cameraPlugin;

		// Token: 0x040185DE RID: 99806
		[Token(Token = "0x40185DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x040185DF RID: 99807
		[Token(Token = "0x40185DF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_accomplishedPerform;

		// Token: 0x040185E0 RID: 99808
		[Token(Token = "0x40185E0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040185E1 RID: 99809
		[Token(Token = "0x40185E1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040185E2 RID: 99810
		[Token(Token = "0x40185E2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayPerform;

		// Token: 0x040185E3 RID: 99811
		[Token(Token = "0x40185E3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
