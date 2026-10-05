using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Interactions
{
	// Token: 0x02000222 RID: 546
	[Token(Token = "0x2000222")]
	public class MultiTapInteraction : IInputInteraction<float>, IInputInteraction
	{
		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x0000A650 File Offset: 0x00008850
		[Token(Token = "0x170005AF")]
		private float tapTimeOrDefault
		{
			[Token(Token = "0x60013F4")]
			[Address(RVA = "0x560BDF0", Offset = "0x560A9F0", VA = "0x18560BDF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x0000A668 File Offset: 0x00008868
		[Token(Token = "0x170005B0")]
		internal float tapDelayOrDefault
		{
			[Token(Token = "0x60013F5")]
			[Address(RVA = "0x560BD80", Offset = "0x560A980", VA = "0x18560BD80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x0000A680 File Offset: 0x00008880
		[Token(Token = "0x170005B1")]
		private float pressPointOrDefault
		{
			[Token(Token = "0x60013F6")]
			[Address(RVA = "0x560BCB0", Offset = "0x560A8B0", VA = "0x18560BCB0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x0000A698 File Offset: 0x00008898
		[Token(Token = "0x170005B2")]
		private float releasePointOrDefault
		{
			[Token(Token = "0x60013F7")]
			[Address(RVA = "0x560BD00", Offset = "0x560A900", VA = "0x18560BD00")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F8")]
		[Address(RVA = "0x560BA00", Offset = "0x560A600", VA = "0x18560BA00", Slot = "4")]
		public void Process(ref InputInteractionContext context)
		{
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F9")]
		[Address(RVA = "0x560BC90", Offset = "0x560A890", VA = "0x18560BC90", Slot = "5")]
		public void Reset()
		{
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FA")]
		[Address(RVA = "0x560BCA0", Offset = "0x560A8A0", VA = "0x18560BCA0")]
		public MultiTapInteraction()
		{
		}

		// Token: 0x04000BCF RID: 3023
		[Token(Token = "0x4000BCF")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("The maximum time (in seconds) allowed to elapse between pressing and releasing a control for it to register as a tap.")]
		public float tapTime;

		// Token: 0x04000BD0 RID: 3024
		[Token(Token = "0x4000BD0")]
		[FieldOffset(Offset = "0x14")]
		[Tooltip("The maximum delay (in seconds) allowed between each tap. If this time is exceeded, the multi-tap is canceled.")]
		public float tapDelay;

		// Token: 0x04000BD1 RID: 3025
		[Token(Token = "0x4000BD1")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("How many taps need to be performed in succession. Two means double-tap, three means triple-tap, and so on.")]
		public int tapCount;

		// Token: 0x04000BD2 RID: 3026
		[Token(Token = "0x4000BD2")]
		[FieldOffset(Offset = "0x1C")]
		public float pressPoint;

		// Token: 0x04000BD3 RID: 3027
		[Token(Token = "0x4000BD3")]
		[FieldOffset(Offset = "0x20")]
		private MultiTapInteraction.TapPhase m_CurrentTapPhase;

		// Token: 0x04000BD4 RID: 3028
		[Token(Token = "0x4000BD4")]
		[FieldOffset(Offset = "0x24")]
		private int m_CurrentTapCount;

		// Token: 0x04000BD5 RID: 3029
		[Token(Token = "0x4000BD5")]
		[FieldOffset(Offset = "0x28")]
		private double m_CurrentTapStartTime;

		// Token: 0x04000BD6 RID: 3030
		[Token(Token = "0x4000BD6")]
		[FieldOffset(Offset = "0x30")]
		private double m_LastTapReleaseTime;

		// Token: 0x02000223 RID: 547
		[Token(Token = "0x2000223")]
		private enum TapPhase
		{
			// Token: 0x04000BD8 RID: 3032
			[Token(Token = "0x4000BD8")]
			None,
			// Token: 0x04000BD9 RID: 3033
			[Token(Token = "0x4000BD9")]
			WaitingForNextRelease,
			// Token: 0x04000BDA RID: 3034
			[Token(Token = "0x4000BDA")]
			WaitingForNextPress
		}
	}
}
