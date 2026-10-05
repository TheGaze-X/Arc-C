using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building
{
	// Token: 0x020017D0 RID: 6096
	[Token(Token = "0x20017D0")]
	public abstract class BuildingMode<T> : SingletonMonoBehaviour<T>, ISingletonNotAutoCreate, IBuildingMode, StateMachine.IStateNode, IHotfixable where T : MonoBehaviour, IBuildingMode
	{
		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x06009A08 RID: 39432 RVA: 0x0003BC28 File Offset: 0x00039E28
		[Token(Token = "0x170010B2")]
		public bool isActiveNode
		{
			[Token(Token = "0x6009A08")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x06009A09 RID: 39433
		// (set) Token: 0x06009A0A RID: 39434
		[Token(Token = "0x170010B3")]
		public abstract bool isRaycastBlocked { [Token(Token = "0x6009A09")] get; [Token(Token = "0x6009A0A")] set; }

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x06009A0B RID: 39435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010B4")]
		public virtual RoomSlotModel selectedRoom
		{
			[Token(Token = "0x6009A0B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x06009A0C RID: 39436 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009A0D RID: 39437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170010B5")]
		private protected BuildingStateMachine stateMachine
		{
			[Token(Token = "0x6009A0C")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6009A0D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x06009A0E RID: 39438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010B6")]
		protected BuildingModel model
		{
			[Token(Token = "0x6009A0E")]
			get
			{
				return null;
			}
		}

		// Token: 0x06009A0F RID: 39439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A0F")]
		public void Register(BuildingStateMachine stateMachine)
		{
		}

		// Token: 0x06009A10 RID: 39440
		[Token(Token = "0x6009A10")]
		protected abstract void OnRegister();

		// Token: 0x06009A11 RID: 39441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A11")]
		public virtual void OnEnter(int lastState)
		{
		}

		// Token: 0x06009A12 RID: 39442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A12")]
		public virtual void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06009A13 RID: 39443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A13")]
		public virtual void OnExit(int nextState)
		{
		}

		// Token: 0x06009A14 RID: 39444 RVA: 0x0003BC40 File Offset: 0x00039E40
		[Token(Token = "0x6009A14")]
		public virtual bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x06009A15 RID: 39445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009A15")]
		public virtual IEnumerator ShowCoroutine(BuildingStateMachine.TransitionParam param)
		{
			return null;
		}

		// Token: 0x06009A16 RID: 39446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009A16")]
		public virtual IEnumerator HideCoroutine(BuildingStateMachine.TransitionParam param)
		{
			return null;
		}

		// Token: 0x06009A17 RID: 39447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A17")]
		protected BuildingMode()
		{
		}

		// Token: 0x0400909A RID: 37018
		[Token(Token = "0x400909A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isActiveNode;

		// Token: 0x0400909B RID: 37019
		[Token(Token = "0x400909B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedRoom;

		// Token: 0x0400909C RID: 37020
		[Token(Token = "0x400909C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stateMachine;

		// Token: 0x0400909D RID: 37021
		[Token(Token = "0x400909D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_stateMachine;

		// Token: 0x0400909E RID: 37022
		[Token(Token = "0x400909E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_model;

		// Token: 0x0400909F RID: 37023
		[Token(Token = "0x400909F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Register;

		// Token: 0x040090A0 RID: 37024
		[Token(Token = "0x40090A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040090A1 RID: 37025
		[Token(Token = "0x40090A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040090A2 RID: 37026
		[Token(Token = "0x40090A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x040090A3 RID: 37027
		[Token(Token = "0x40090A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x040090A4 RID: 37028
		[Token(Token = "0x40090A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x040090A5 RID: 37029
		[Token(Token = "0x40090A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x040090A6 RID: 37030
		[Token(Token = "0x40090A6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
