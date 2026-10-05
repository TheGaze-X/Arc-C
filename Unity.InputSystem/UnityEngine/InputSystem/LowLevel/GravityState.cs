using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x02000199 RID: 409
	[Token(Token = "0x2000199")]
	internal struct GravityState : IInputStateTypeInfo
	{
		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x00007F38 File Offset: 0x00006138
		[Token(Token = "0x1700044E")]
		public static FourCC kFormat
		{
			[Token(Token = "0x6000F8C")]
			[Address(RVA = "0x56D6080", Offset = "0x56D4C80", VA = "0x1856D6080")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x00007F50 File Offset: 0x00006150
		[Token(Token = "0x1700044F")]
		public FourCC format
		{
			[Token(Token = "0x6000F8D")]
			[Address(RVA = "0x56D6040", Offset = "0x56D4C40", VA = "0x1856D6040", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x04000975 RID: 2421
		[Token(Token = "0x4000975")]
		[FieldOffset(Offset = "0x0")]
		[InputControl(displayName = "Gravity", processors = "CompensateDirection", noisy = true)]
		public Vector3 gravity;
	}
}
