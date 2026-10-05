using System;
using System.ComponentModel;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Interactions
{
	// Token: 0x02000221 RID: 545
	[Token(Token = "0x2000221")]
	[DisplayName("Hold")]
	public class HoldInteraction : IInputInteraction
	{
		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060013EF RID: 5103 RVA: 0x0000A620 File Offset: 0x00008820
		[Token(Token = "0x170005AD")]
		private float durationOrDefault
		{
			[Token(Token = "0x60013EF")]
			[Address(RVA = "0x55FD210", Offset = "0x55FBE10", VA = "0x1855FD210")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x0000A638 File Offset: 0x00008838
		[Token(Token = "0x170005AE")]
		private float pressPointOrDefault
		{
			[Token(Token = "0x60013F0")]
			[Address(RVA = "0x55FD280", Offset = "0x55FBE80", VA = "0x1855FD280")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F1")]
		[Address(RVA = "0x55FD0E0", Offset = "0x55FBCE0", VA = "0x1855FD0E0", Slot = "4")]
		public void Process(ref InputInteractionContext context)
		{
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F2")]
		[Address(RVA = "0x55FD200", Offset = "0x55FBE00", VA = "0x1855FD200", Slot = "5")]
		public void Reset()
		{
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HoldInteraction()
		{
		}

		// Token: 0x04000BCC RID: 3020
		[Token(Token = "0x4000BCC")]
		[FieldOffset(Offset = "0x10")]
		public float duration;

		// Token: 0x04000BCD RID: 3021
		[Token(Token = "0x4000BCD")]
		[FieldOffset(Offset = "0x14")]
		public float pressPoint;

		// Token: 0x04000BCE RID: 3022
		[Token(Token = "0x4000BCE")]
		[FieldOffset(Offset = "0x18")]
		private double m_TimePressed;
	}
}
