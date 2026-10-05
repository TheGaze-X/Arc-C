using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200333E RID: 13118
	[Token(Token = "0x200333E")]
	public class RL04Boss4MoveCameraState : UIStateNode
	{
		// Token: 0x170031A8 RID: 12712
		// (get) Token: 0x06014ED4 RID: 85716 RVA: 0x00089718 File Offset: 0x00087918
		[Token(Token = "0x170031A8")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6014ED4")]
			[Address(RVA = "0xD58EF0", Offset = "0xD57AF0", VA = "0x180D58EF0", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x170031A9 RID: 12713
		// (get) Token: 0x06014ED5 RID: 85717 RVA: 0x00089730 File Offset: 0x00087930
		[Token(Token = "0x170031A9")]
		public override bool enablePause
		{
			[Token(Token = "0x6014ED5")]
			[Address(RVA = "0xD58D70", Offset = "0xD57970", VA = "0x180D58D70", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170031AA RID: 12714
		// (get) Token: 0x06014ED6 RID: 85718 RVA: 0x00089748 File Offset: 0x00087948
		[Token(Token = "0x170031AA")]
		public override bool enableShowRange
		{
			[Token(Token = "0x6014ED6")]
			[Address(RVA = "0xD58E30", Offset = "0xD57A30", VA = "0x180D58E30", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170031AB RID: 12715
		// (get) Token: 0x06014ED7 RID: 85719 RVA: 0x00089760 File Offset: 0x00087960
		[Token(Token = "0x170031AB")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x6014ED7")]
			[Address(RVA = "0xD58E90", Offset = "0xD57A90", VA = "0x180D58E90", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170031AC RID: 12716
		// (get) Token: 0x06014ED8 RID: 85720 RVA: 0x00089778 File Offset: 0x00087978
		[Token(Token = "0x170031AC")]
		public override bool enablePerspectiveCanvas
		{
			[Token(Token = "0x6014ED8")]
			[Address(RVA = "0xD58DD0", Offset = "0xD579D0", VA = "0x180D58DD0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014ED9 RID: 85721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014ED9")]
		[Address(RVA = "0xD58C70", Offset = "0xD57870", VA = "0x180D58C70", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06014EDA RID: 85722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EDA")]
		[Address(RVA = "0xD58AE0", Offset = "0xD576E0", VA = "0x180D58AE0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06014EDB RID: 85723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EDB")]
		[Address(RVA = "0xD58BC0", Offset = "0xD577C0", VA = "0x180D58BC0", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x06014EDC RID: 85724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EDC")]
		[Address(RVA = "0xD58CD0", Offset = "0xD578D0", VA = "0x180D58CD0")]
		public RL04Boss4MoveCameraState()
		{
		}

		// Token: 0x06014EDD RID: 85725 RVA: 0x00089790 File Offset: 0x00087990
		[Token(Token = "0x6014EDD")]
		[Address(RVA = "0xD56A90", Offset = "0xD55690", VA = "0x180D56A90")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06014EDE RID: 85726 RVA: 0x000897A8 File Offset: 0x000879A8
		[Token(Token = "0x6014EDE")]
		[Address(RVA = "0xD56B50", Offset = "0xD55750", VA = "0x180D56B50")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x06014EDF RID: 85727 RVA: 0x000897C0 File Offset: 0x000879C0
		[Token(Token = "0x6014EDF")]
		[Address(RVA = "0xD56BB0", Offset = "0xD557B0", VA = "0x180D56BB0")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06014EE0 RID: 85728 RVA: 0x000897D8 File Offset: 0x000879D8
		[Token(Token = "0x6014EE0")]
		[Address(RVA = "0xD56AF0", Offset = "0xD556F0", VA = "0x180D56AF0")]
		private bool <>xLuaBaseProxy_get_enablePerspectiveCanvas()
		{
			return default(bool);
		}

		// Token: 0x06014EE1 RID: 85729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EE1")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06014EE2 RID: 85730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EE2")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x04018E33 RID: 101939
		[Token(Token = "0x4018E33")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04018E34 RID: 101940
		[Token(Token = "0x4018E34")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x04018E35 RID: 101941
		[Token(Token = "0x4018E35")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x04018E36 RID: 101942
		[Token(Token = "0x4018E36")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04018E37 RID: 101943
		[Token(Token = "0x4018E37")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enablePerspectiveCanvas;

		// Token: 0x04018E38 RID: 101944
		[Token(Token = "0x4018E38")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04018E39 RID: 101945
		[Token(Token = "0x4018E39")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04018E3A RID: 101946
		[Token(Token = "0x4018E3A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04018E3B RID: 101947
		[Token(Token = "0x4018E3B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
