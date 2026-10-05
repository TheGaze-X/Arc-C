using System;
using System.ComponentModel;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Interactions
{
	// Token: 0x02000226 RID: 550
	[Token(Token = "0x2000226")]
	[DisplayName("Long Tap")]
	public class SlowTapInteraction : IInputInteraction
	{
		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x0000A6E0 File Offset: 0x000088E0
		[Token(Token = "0x170005B5")]
		private float durationOrDefault
		{
			[Token(Token = "0x6001400")]
			[Address(RVA = "0x560CA70", Offset = "0x560B670", VA = "0x18560CA70")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x0000A6F8 File Offset: 0x000088F8
		[Token(Token = "0x170005B6")]
		private float pressPointOrDefault
		{
			[Token(Token = "0x6001401")]
			[Address(RVA = "0x560CAE0", Offset = "0x560B6E0", VA = "0x18560CAE0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001402")]
		[Address(RVA = "0x560C8C0", Offset = "0x560B4C0", VA = "0x18560C8C0", Slot = "4")]
		public void Process(ref InputInteractionContext context)
		{
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001403")]
		[Address(RVA = "0x55FD200", Offset = "0x55FBE00", VA = "0x1855FD200", Slot = "5")]
		public void Reset()
		{
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001404")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SlowTapInteraction()
		{
		}

		// Token: 0x04000BE2 RID: 3042
		[Token(Token = "0x4000BE2")]
		[FieldOffset(Offset = "0x10")]
		public float duration;

		// Token: 0x04000BE3 RID: 3043
		[Token(Token = "0x4000BE3")]
		[FieldOffset(Offset = "0x14")]
		public float pressPoint;

		// Token: 0x04000BE4 RID: 3044
		[Token(Token = "0x4000BE4")]
		[FieldOffset(Offset = "0x18")]
		private double m_SlowTapStartTime;
	}
}
