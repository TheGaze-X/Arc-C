using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	public struct InputInteractionContext
	{
		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000156")]
		public InputAction action
		{
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x5628F60", Offset = "0x5627B60", VA = "0x185628F60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000157")]
		public InputControl control
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x5628FB0", Offset = "0x5627BB0", VA = "0x185628FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00004068 File Offset: 0x00002268
		[Token(Token = "0x17000158")]
		public InputActionPhase phase
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return InputActionPhase.Disabled;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x00004080 File Offset: 0x00002280
		[Token(Token = "0x17000159")]
		public double time
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x28615D0", Offset = "0x28601D0", VA = "0x1828615D0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00004098 File Offset: 0x00002298
		[Token(Token = "0x1700015A")]
		public double startTime
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x161D230", Offset = "0x161BE30", VA = "0x18161D230")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x000040B0 File Offset: 0x000022B0
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015B")]
		public bool timerHasExpired
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x561B0B0", Offset = "0x5619CB0", VA = "0x18561B0B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x561B1F0", Offset = "0x5619DF0", VA = "0x18561B1F0")]
			internal set
			{
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x000040C8 File Offset: 0x000022C8
		[Token(Token = "0x1700015C")]
		public bool isWaiting
		{
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x5629000", Offset = "0x5627C00", VA = "0x185629000")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x000040E0 File Offset: 0x000022E0
		[Token(Token = "0x1700015D")]
		public bool isStarted
		{
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x5628FF0", Offset = "0x5627BF0", VA = "0x185628FF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x000040F8 File Offset: 0x000022F8
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x194DD70", Offset = "0x194C970", VA = "0x18194DD70")]
		public float ComputeMagnitude()
		{
			return 0f;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00004110 File Offset: 0x00002310
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x5628CF0", Offset = "0x56278F0", VA = "0x185628CF0")]
		public bool ControlIsActuated(float threshold = 0f)
		{
			return default(bool);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x5628ED0", Offset = "0x5627AD0", VA = "0x185628ED0")]
		public void Started()
		{
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x5628DA0", Offset = "0x56279A0", VA = "0x185628DA0")]
		public void Performed()
		{
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x5628D50", Offset = "0x5627950", VA = "0x185628D50")]
		public void PerformedAndStayStarted()
		{
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x5628D00", Offset = "0x5627900", VA = "0x185628D00")]
		public void PerformedAndStayPerformed()
		{
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x5628CB0", Offset = "0x56278B0", VA = "0x185628CB0")]
		public void Canceled()
		{
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x5628F20", Offset = "0x5627B20", VA = "0x185628F20")]
		public void Waiting()
		{
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x5628DF0", Offset = "0x56279F0", VA = "0x185628DF0")]
		public void SetTimeout(float seconds)
		{
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x5628E20", Offset = "0x5627A20", VA = "0x185628E20")]
		public void SetTotalTimeoutCompletionTime(float seconds)
		{
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600047A")]
		public TValue ReadValue<TValue>() where TValue : struct
		{
			return null;
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00004128 File Offset: 0x00002328
		[Token(Token = "0x1700015E")]
		internal int mapIndex
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x4EEB50", Offset = "0x4ED750", VA = "0x1804EEB50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00004140 File Offset: 0x00002340
		[Token(Token = "0x1700015F")]
		internal int controlIndex
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x5628FA0", Offset = "0x5627BA0", VA = "0x185628FA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x00004158 File Offset: 0x00002358
		[Token(Token = "0x17000160")]
		internal int bindingIndex
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x5628F90", Offset = "0x5627B90", VA = "0x185628F90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00004170 File Offset: 0x00002370
		[Token(Token = "0x17000161")]
		internal int interactionIndex
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x5628FE0", Offset = "0x5627BE0", VA = "0x185628FE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x0")]
		internal InputActionState m_State;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x8")]
		internal InputInteractionContext.Flags m_Flags;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x10")]
		internal InputActionState.TriggerState m_TriggerState;

		// Token: 0x02000064 RID: 100
		[Token(Token = "0x2000064")]
		[Flags]
		internal enum Flags
		{
			// Token: 0x04000234 RID: 564
			[Token(Token = "0x4000234")]
			TimerHasExpired = 2
		}
	}
}
