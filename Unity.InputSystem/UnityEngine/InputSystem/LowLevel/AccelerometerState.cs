using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x02000197 RID: 407
	[Token(Token = "0x2000197")]
	internal struct AccelerometerState : IInputStateTypeInfo
	{
		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x00007ED8 File Offset: 0x000060D8
		[Token(Token = "0x1700044A")]
		public static FourCC kFormat
		{
			[Token(Token = "0x6000F88")]
			[Address(RVA = "0x56CEAE0", Offset = "0x56CD6E0", VA = "0x1856CEAE0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x00007EF0 File Offset: 0x000060F0
		[Token(Token = "0x1700044B")]
		public FourCC format
		{
			[Token(Token = "0x6000F89")]
			[Address(RVA = "0x56CEAA0", Offset = "0x56CD6A0", VA = "0x1856CEAA0", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x04000973 RID: 2419
		[Token(Token = "0x4000973")]
		[FieldOffset(Offset = "0x0")]
		[InputControl(displayName = "Acceleration", processors = "CompensateDirection", noisy = true)]
		public Vector3 acceleration;
	}
}
