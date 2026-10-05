using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem
{
	// Token: 0x020000AA RID: 170
	[Token(Token = "0x20000AA")]
	[InputControlLayout(isGenericTypeOfDevice = true)]
	public class Sensor : InputDevice
	{
		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x00005178 File Offset: 0x00003378
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000277")]
		public float samplingFrequency
		{
			[Token(Token = "0x6000988")]
			[Address(RVA = "0x5699E70", Offset = "0x5698A70", VA = "0x185699E70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000989")]
			[Address(RVA = "0x5699F50", Offset = "0x5698B50", VA = "0x185699F50")]
			set
			{
			}
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600098A")]
		[Address(RVA = "0x55DCFE0", Offset = "0x55DBBE0", VA = "0x1855DCFE0")]
		public Sensor()
		{
		}
	}
}
