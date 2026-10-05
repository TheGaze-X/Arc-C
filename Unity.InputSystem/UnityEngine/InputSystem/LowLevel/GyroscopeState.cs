using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x02000198 RID: 408
	[Token(Token = "0x2000198")]
	internal struct GyroscopeState : IInputStateTypeInfo
	{
		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x00007F08 File Offset: 0x00006108
		[Token(Token = "0x1700044C")]
		public static FourCC kFormat
		{
			[Token(Token = "0x6000F8A")]
			[Address(RVA = "0x56D6100", Offset = "0x56D4D00", VA = "0x1856D6100")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000F8B RID: 3979 RVA: 0x00007F20 File Offset: 0x00006120
		[Token(Token = "0x1700044D")]
		public FourCC format
		{
			[Token(Token = "0x6000F8B")]
			[Address(RVA = "0x56D60C0", Offset = "0x56D4CC0", VA = "0x1856D60C0", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x04000974 RID: 2420
		[Token(Token = "0x4000974")]
		[FieldOffset(Offset = "0x0")]
		[InputControl(displayName = "Angular Velocity", processors = "CompensateDirection", noisy = true)]
		public Vector3 angularVelocity;
	}
}
