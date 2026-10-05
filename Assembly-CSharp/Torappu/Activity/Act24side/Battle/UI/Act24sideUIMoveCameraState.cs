using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using XLua;

namespace Torappu.Activity.Act24side.Battle.UI
{
	// Token: 0x0200761E RID: 30238
	[Token(Token = "0x200761E")]
	public class Act24sideUIMoveCameraState : UIStateNode
	{
		// Token: 0x17006424 RID: 25636
		// (get) Token: 0x0602A917 RID: 174359 RVA: 0x000D90C8 File Offset: 0x000D72C8
		[Token(Token = "0x17006424")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x602A917")]
			[Address(RVA = "0x2663FB0", Offset = "0x2662BB0", VA = "0x182663FB0", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17006425 RID: 25637
		// (get) Token: 0x0602A918 RID: 174360 RVA: 0x000D90E0 File Offset: 0x000D72E0
		[Token(Token = "0x17006425")]
		public override bool enablePause
		{
			[Token(Token = "0x602A918")]
			[Address(RVA = "0x2663E30", Offset = "0x2662A30", VA = "0x182663E30", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006426 RID: 25638
		// (get) Token: 0x0602A919 RID: 174361 RVA: 0x000D90F8 File Offset: 0x000D72F8
		[Token(Token = "0x17006426")]
		public override bool enableShowRange
		{
			[Token(Token = "0x602A919")]
			[Address(RVA = "0x2663EF0", Offset = "0x2662AF0", VA = "0x182663EF0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006427 RID: 25639
		// (get) Token: 0x0602A91A RID: 174362 RVA: 0x000D9110 File Offset: 0x000D7310
		[Token(Token = "0x17006427")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x602A91A")]
			[Address(RVA = "0x2663F50", Offset = "0x2662B50", VA = "0x182663F50", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006428 RID: 25640
		// (get) Token: 0x0602A91B RID: 174363 RVA: 0x000D9128 File Offset: 0x000D7328
		[Token(Token = "0x17006428")]
		public override bool enablePerspectiveCanvas
		{
			[Token(Token = "0x602A91B")]
			[Address(RVA = "0x2663E90", Offset = "0x2662A90", VA = "0x182663E90", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602A91C RID: 174364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A91C")]
		[Address(RVA = "0x2663D70", Offset = "0x2662970", VA = "0x182663D70", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0602A91D RID: 174365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A91D")]
		[Address(RVA = "0x2663BE0", Offset = "0x26627E0", VA = "0x182663BE0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x0602A91E RID: 174366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A91E")]
		[Address(RVA = "0x2663CC0", Offset = "0x26628C0", VA = "0x182663CC0", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x0602A91F RID: 174367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A91F")]
		[Address(RVA = "0x2663DD0", Offset = "0x26629D0", VA = "0x182663DD0")]
		public Act24sideUIMoveCameraState()
		{
		}

		// Token: 0x0602A920 RID: 174368 RVA: 0x000D9140 File Offset: 0x000D7340
		[Token(Token = "0x602A920")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x0602A921 RID: 174369 RVA: 0x000D9158 File Offset: 0x000D7358
		[Token(Token = "0x602A921")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x0602A922 RID: 174370 RVA: 0x000D9170 File Offset: 0x000D7370
		[Token(Token = "0x602A922")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x0602A923 RID: 174371 RVA: 0x000D9188 File Offset: 0x000D7388
		[Token(Token = "0x602A923")]
		[Address(RVA = "0x962380", Offset = "0x960F80", VA = "0x180962380")]
		private bool <>xLuaBaseProxy_get_enablePerspectiveCanvas()
		{
			return default(bool);
		}

		// Token: 0x0602A924 RID: 174372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A924")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x0602A925 RID: 174373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A925")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x0403D4A3 RID: 251043
		[Token(Token = "0x403D4A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x0403D4A4 RID: 251044
		[Token(Token = "0x403D4A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x0403D4A5 RID: 251045
		[Token(Token = "0x403D4A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x0403D4A6 RID: 251046
		[Token(Token = "0x403D4A6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x0403D4A7 RID: 251047
		[Token(Token = "0x403D4A7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enablePerspectiveCanvas;

		// Token: 0x0403D4A8 RID: 251048
		[Token(Token = "0x403D4A8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0403D4A9 RID: 251049
		[Token(Token = "0x403D4A9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403D4AA RID: 251050
		[Token(Token = "0x403D4AA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403D4AB RID: 251051
		[Token(Token = "0x403D4AB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
