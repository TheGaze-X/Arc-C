using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Processors
{
	// Token: 0x020001EC RID: 492
	[Token(Token = "0x20001EC")]
	public class StickDeadzoneProcessor : InputProcessor<Vector2>
	{
		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x000095A0 File Offset: 0x000077A0
		[Token(Token = "0x17000519")]
		private float minOrDefault
		{
			[Token(Token = "0x60011ED")]
			[Address(RVA = "0x56FAC40", Offset = "0x56F9840", VA = "0x1856FAC40")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x000095B8 File Offset: 0x000077B8
		[Token(Token = "0x1700051A")]
		private float maxOrDefault
		{
			[Token(Token = "0x60011EE")]
			[Address(RVA = "0x56FABD0", Offset = "0x56F97D0", VA = "0x1856FABD0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x000095D0 File Offset: 0x000077D0
		[Token(Token = "0x60011EF")]
		[Address(RVA = "0x56FA890", Offset = "0x56F9490", VA = "0x1856FA890", Slot = "7")]
		public override Vector2 Process(Vector2 value, [Optional] InputControl control)
		{
			return default(Vector2);
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x000095E8 File Offset: 0x000077E8
		[Token(Token = "0x60011F0")]
		[Address(RVA = "0x56FA750", Offset = "0x56F9350", VA = "0x1856FA750")]
		private float GetDeadZoneAdjustedValue(float value)
		{
			return 0f;
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60011F1")]
		[Address(RVA = "0x56FAA50", Offset = "0x56F9650", VA = "0x1856FAA50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F2")]
		[Address(RVA = "0x56FAB90", Offset = "0x56F9790", VA = "0x1856FAB90")]
		public StickDeadzoneProcessor()
		{
		}

		// Token: 0x04000AA0 RID: 2720
		[Token(Token = "0x4000AA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float min;

		// Token: 0x04000AA1 RID: 2721
		[Token(Token = "0x4000AA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float max;
	}
}
