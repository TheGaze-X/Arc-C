using System;
using System.ComponentModel;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Interactions
{
	// Token: 0x02000227 RID: 551
	[Token(Token = "0x2000227")]
	[DisplayName("Tap")]
	public class TapInteraction : IInputInteraction
	{
		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x0000A710 File Offset: 0x00008910
		[Token(Token = "0x170005B7")]
		private float durationOrDefault
		{
			[Token(Token = "0x6001405")]
			[Address(RVA = "0x560CE00", Offset = "0x560BA00", VA = "0x18560CE00")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x0000A728 File Offset: 0x00008928
		[Token(Token = "0x170005B8")]
		private float pressPointOrDefault
		{
			[Token(Token = "0x6001406")]
			[Address(RVA = "0x560CE70", Offset = "0x560BA70", VA = "0x18560CE70")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x0000A740 File Offset: 0x00008940
		[Token(Token = "0x170005B9")]
		private float releasePointOrDefault
		{
			[Token(Token = "0x6001407")]
			[Address(RVA = "0x560CEC0", Offset = "0x560BAC0", VA = "0x18560CEC0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001408")]
		[Address(RVA = "0x560CC40", Offset = "0x560B840", VA = "0x18560CC40", Slot = "4")]
		public void Process(ref InputInteractionContext context)
		{
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001409")]
		[Address(RVA = "0x55FD200", Offset = "0x55FBE00", VA = "0x1855FD200", Slot = "5")]
		public void Reset()
		{
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600140A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TapInteraction()
		{
		}

		// Token: 0x04000BE5 RID: 3045
		[Token(Token = "0x4000BE5")]
		[FieldOffset(Offset = "0x10")]
		public float duration;

		// Token: 0x04000BE6 RID: 3046
		[Token(Token = "0x4000BE6")]
		[FieldOffset(Offset = "0x14")]
		public float pressPoint;

		// Token: 0x04000BE7 RID: 3047
		[Token(Token = "0x4000BE7")]
		[FieldOffset(Offset = "0x18")]
		private double m_TapStartTime;
	}
}
