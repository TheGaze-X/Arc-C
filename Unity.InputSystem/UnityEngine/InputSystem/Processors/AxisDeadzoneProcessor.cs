using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Processors
{
	// Token: 0x020001DF RID: 479
	[Token(Token = "0x20001DF")]
	public class AxisDeadzoneProcessor : InputProcessor<float>
	{
		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x000093D8 File Offset: 0x000075D8
		[Token(Token = "0x17000515")]
		private float minOrDefault
		{
			[Token(Token = "0x60011C0")]
			[Address(RVA = "0x56E46E0", Offset = "0x56E32E0", VA = "0x1856E46E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x060011C1 RID: 4545 RVA: 0x000093F0 File Offset: 0x000075F0
		[Token(Token = "0x17000516")]
		private float maxOrDefault
		{
			[Token(Token = "0x60011C1")]
			[Address(RVA = "0x56E4670", Offset = "0x56E3270", VA = "0x1856E4670")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00009408 File Offset: 0x00007608
		[Token(Token = "0x60011C2")]
		[Address(RVA = "0x56E43B0", Offset = "0x56E2FB0", VA = "0x1856E43B0", Slot = "7")]
		public override float Process(float value, [Optional] InputControl control)
		{
			return 0f;
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60011C3")]
		[Address(RVA = "0x56E44F0", Offset = "0x56E30F0", VA = "0x1856E44F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011C4")]
		[Address(RVA = "0x56E4630", Offset = "0x56E3230", VA = "0x1856E4630")]
		public AxisDeadzoneProcessor()
		{
		}

		// Token: 0x04000A8E RID: 2702
		[Token(Token = "0x4000A8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float min;

		// Token: 0x04000A8F RID: 2703
		[Token(Token = "0x4000A8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float max;
	}
}
