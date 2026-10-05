using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x0200019B RID: 411
	[Token(Token = "0x200019B")]
	internal struct LinearAccelerationState : IInputStateTypeInfo
	{
		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x00007F98 File Offset: 0x00006198
		[Token(Token = "0x17000452")]
		public static FourCC kFormat
		{
			[Token(Token = "0x6000F90")]
			[Address(RVA = "0x56DEC90", Offset = "0x56DD890", VA = "0x1856DEC90")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000F91 RID: 3985 RVA: 0x00007FB0 File Offset: 0x000061B0
		[Token(Token = "0x17000453")]
		public FourCC format
		{
			[Token(Token = "0x6000F91")]
			[Address(RVA = "0x56DEC50", Offset = "0x56DD850", VA = "0x1856DEC50", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x04000977 RID: 2423
		[Token(Token = "0x4000977")]
		[FieldOffset(Offset = "0x0")]
		[InputControl(displayName = "Acceleration", processors = "CompensateDirection", noisy = true)]
		public Vector3 acceleration;
	}
}
