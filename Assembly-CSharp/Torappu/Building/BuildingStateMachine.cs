using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Building
{
	// Token: 0x020017D4 RID: 6100
	[Token(Token = "0x20017D4")]
	public class BuildingStateMachine : TypeStateMachine
	{
		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x06009A26 RID: 39462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010BB")]
		public IBuildingMode currentMode
		{
			[Token(Token = "0x6009A26")]
			[Address(RVA = "0x313B4A0", Offset = "0x313A0A0", VA = "0x18313B4A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x06009A27 RID: 39463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010BC")]
		public BuildingModel model
		{
			[Token(Token = "0x6009A27")]
			[Address(RVA = "0x313B4E0", Offset = "0x313A0E0", VA = "0x18313B4E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x06009A28 RID: 39464 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009A29 RID: 39465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170010BD")]
		private protected BuildingController controller
		{
			[Token(Token = "0x6009A28")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6009A29")]
			[Address(RVA = "0x18480D0", Offset = "0x1846CD0", VA = "0x1818480D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x06009A2A RID: 39466 RVA: 0x0003BC88 File Offset: 0x00039E88
		[Token(Token = "0x170010BE")]
		public bool isTransiting
		{
			[Token(Token = "0x6009A2A")]
			[Address(RVA = "0x1A88D30", Offset = "0x1A87930", VA = "0x181A88D30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06009A2B RID: 39467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A2B")]
		[Address(RVA = "0x313B410", Offset = "0x313A010", VA = "0x18313B410")]
		public BuildingStateMachine(BuildingController controller)
		{
		}

		// Token: 0x06009A2C RID: 39468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A2C")]
		[Address(RVA = "0x313B210", Offset = "0x3139E10", VA = "0x18313B210")]
		public void RegisterState(IBuildingMode stateNode, bool asDefault = false)
		{
		}

		// Token: 0x06009A2D RID: 39469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A2D")]
		public void SwitchMode<T>(BuildingStateMachine.TransitionParam param) where T : IBuildingMode
		{
		}

		// Token: 0x06009A2E RID: 39470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009A2E")]
		public T GetMode<T>() where T : IBuildingMode
		{
			return null;
		}

		// Token: 0x06009A2F RID: 39471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A2F")]
		public void Start<T>() where T : IBuildingMode
		{
		}

		// Token: 0x06009A30 RID: 39472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A30")]
		public void SetDefaultMode<T>() where T : IBuildingMode
		{
		}

		// Token: 0x06009A31 RID: 39473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009A31")]
		[Address(RVA = "0x313B330", Offset = "0x3139F30", VA = "0x18313B330")]
		private IEnumerator _DoModeTransition(BuildingStateMachine.TransitionParam param, IBuildingMode fromMode, IBuildingMode toMode)
		{
			return null;
		}

		// Token: 0x040090AB RID: 37035
		[Token(Token = "0x40090AB")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isTransiting;

		// Token: 0x020017D5 RID: 6101
		[Token(Token = "0x20017D5")]
		public struct TransitionParam
		{
			// Token: 0x040090AD RID: 37037
			[Token(Token = "0x40090AD")]
			[FieldOffset(Offset = "0x0")]
			public static readonly BuildingStateMachine.TransitionParam DEFAULT;

			// Token: 0x040090AE RID: 37038
			[Token(Token = "0x40090AE")]
			[FieldOffset(Offset = "0x0")]
			public BuildingStateMachine.TransitionParam.TransitionType transitionType;

			// Token: 0x040090AF RID: 37039
			[Token(Token = "0x40090AF")]
			[FieldOffset(Offset = "0x8")]
			public RoomSlotModel targetRoom;

			// Token: 0x040090B0 RID: 37040
			[Token(Token = "0x40090B0")]
			[FieldOffset(Offset = "0x10")]
			public IBuildingMode fromMode;

			// Token: 0x020017D6 RID: 6102
			[Token(Token = "0x20017D6")]
			public enum TransitionType
			{
				// Token: 0x040090B2 RID: 37042
				[Token(Token = "0x40090B2")]
				NONE,
				// Token: 0x040090B3 RID: 37043
				[Token(Token = "0x40090B3")]
				ZOOM_IN_TO_VAULT,
				// Token: 0x040090B4 RID: 37044
				[Token(Token = "0x40090B4")]
				ZOOM_OUT_TO_BP
			}
		}
	}
}
