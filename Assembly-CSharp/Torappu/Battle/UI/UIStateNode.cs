using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003351 RID: 13137
	[Token(Token = "0x2003351")]
	public abstract class UIStateNode : MonoBehaviour, IUIStateNode, StateMachine.IStateNode, IHotfixable
	{
		// Token: 0x170031B8 RID: 12728
		// (get) Token: 0x06014F65 RID: 85861 RVA: 0x00089BE0 File Offset: 0x00087DE0
		[Token(Token = "0x170031B8")]
		public bool isActiveNode
		{
			[Token(Token = "0x6014F65")]
			[Address(RVA = "0xD66310", Offset = "0xD64F10", VA = "0x180D66310", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170031B9 RID: 12729
		// (get) Token: 0x06014F66 RID: 85862 RVA: 0x00089BF8 File Offset: 0x00087DF8
		[Token(Token = "0x170031B9")]
		public virtual bool enablePause
		{
			[Token(Token = "0x6014F66")]
			[Address(RVA = "0xD56A90", Offset = "0xD55690", VA = "0x180D56A90", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170031BA RID: 12730
		// (get) Token: 0x06014F67 RID: 85863 RVA: 0x00089C10 File Offset: 0x00087E10
		[Token(Token = "0x170031BA")]
		public virtual bool enableSpeedSwitch
		{
			[Token(Token = "0x6014F67")]
			[Address(RVA = "0xD56BB0", Offset = "0xD557B0", VA = "0x180D56BB0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170031BB RID: 12731
		// (get) Token: 0x06014F68 RID: 85864 RVA: 0x00089C28 File Offset: 0x00087E28
		[Token(Token = "0x170031BB")]
		public virtual bool enableShowRange
		{
			[Token(Token = "0x6014F68")]
			[Address(RVA = "0xD56B50", Offset = "0xD55750", VA = "0x180D56B50", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170031BC RID: 12732
		// (get) Token: 0x06014F69 RID: 85865 RVA: 0x00089C40 File Offset: 0x00087E40
		[Token(Token = "0x170031BC")]
		public virtual bool enablePerspectiveCanvas
		{
			[Token(Token = "0x6014F69")]
			[Address(RVA = "0xD56AF0", Offset = "0xD556F0", VA = "0x180D56AF0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170031BD RID: 12733
		// (get) Token: 0x06014F6A RID: 85866 RVA: 0x00089C58 File Offset: 0x00087E58
		[Token(Token = "0x170031BD")]
		public virtual bool enableBackpress
		{
			[Token(Token = "0x6014F6A")]
			[Address(RVA = "0xD66250", Offset = "0xD64E50", VA = "0x180D66250", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170031BE RID: 12734
		// (get) Token: 0x06014F6B RID: 85867 RVA: 0x00089C70 File Offset: 0x00087E70
		[Token(Token = "0x170031BE")]
		public virtual bool enableCameraDrag
		{
			[Token(Token = "0x6014F6B")]
			[Address(RVA = "0xD662B0", Offset = "0xD64EB0", VA = "0x180D662B0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170031BF RID: 12735
		// (get) Token: 0x06014F6C RID: 85868
		[Token(Token = "0x170031BF")]
		public abstract UIStateEnum uiState { [Token(Token = "0x6014F6C")] get; }

		// Token: 0x170031C0 RID: 12736
		// (get) Token: 0x06014F6D RID: 85869 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06014F6E RID: 85870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170031C0")]
		private protected UIStateMachine stateMachine
		{
			[Token(Token = "0x6014F6D")]
			[Address(RVA = "0xD66420", Offset = "0xD65020", VA = "0x180D66420")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6014F6E")]
			[Address(RVA = "0xD66480", Offset = "0xD65080", VA = "0x180D66480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06014F6F RID: 85871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F6F")]
		[Address(RVA = "0xD660F0", Offset = "0xD64CF0", VA = "0x180D660F0", Slot = "24")]
		public virtual void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06014F70 RID: 85872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F70")]
		[Address(RVA = "0xD65FD0", Offset = "0xD64BD0", VA = "0x180D65FD0", Slot = "25")]
		public virtual void OnEnter(int lastState)
		{
		}

		// Token: 0x06014F71 RID: 85873
		[Token(Token = "0x6014F71")]
		public abstract void OnTick(FP deltaTime);

		// Token: 0x06014F72 RID: 85874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F72")]
		[Address(RVA = "0xD66060", Offset = "0xD64C60", VA = "0x180D66060", Slot = "27")]
		public virtual void OnExit(int nextState)
		{
		}

		// Token: 0x06014F73 RID: 85875 RVA: 0x00089C88 File Offset: 0x00087E88
		[Token(Token = "0x6014F73")]
		[Address(RVA = "0xD65F60", Offset = "0xD64B60", VA = "0x180D65F60", Slot = "28")]
		public virtual bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x06014F74 RID: 85876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F74")]
		[Address(RVA = "0xD661F0", Offset = "0xD64DF0", VA = "0x180D661F0")]
		protected UIStateNode()
		{
		}

		// Token: 0x04018EF7 RID: 102135
		[Token(Token = "0x4018EF7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isActiveNode;

		// Token: 0x04018EF8 RID: 102136
		[Token(Token = "0x4018EF8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x04018EF9 RID: 102137
		[Token(Token = "0x4018EF9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04018EFA RID: 102138
		[Token(Token = "0x4018EFA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x04018EFB RID: 102139
		[Token(Token = "0x4018EFB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enablePerspectiveCanvas;

		// Token: 0x04018EFC RID: 102140
		[Token(Token = "0x4018EFC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_enableBackpress;

		// Token: 0x04018EFD RID: 102141
		[Token(Token = "0x4018EFD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_enableCameraDrag;

		// Token: 0x04018EFE RID: 102142
		[Token(Token = "0x4018EFE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_stateMachine;

		// Token: 0x04018EFF RID: 102143
		[Token(Token = "0x4018EFF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_stateMachine;

		// Token: 0x04018F00 RID: 102144
		[Token(Token = "0x4018F00")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04018F01 RID: 102145
		[Token(Token = "0x4018F01")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04018F02 RID: 102146
		[Token(Token = "0x4018F02")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04018F03 RID: 102147
		[Token(Token = "0x4018F03")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x04018F04 RID: 102148
		[Token(Token = "0x4018F04")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
