using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x0200019A RID: 410
	[Token(Token = "0x200019A")]
	internal struct AttitudeState : IInputStateTypeInfo
	{
		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x00007F68 File Offset: 0x00006168
		[Token(Token = "0x17000450")]
		public static FourCC kFormat
		{
			[Token(Token = "0x6000F8E")]
			[Address(RVA = "0x56CEFA0", Offset = "0x56CDBA0", VA = "0x1856CEFA0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x00007F80 File Offset: 0x00006180
		[Token(Token = "0x17000451")]
		public FourCC format
		{
			[Token(Token = "0x6000F8F")]
			[Address(RVA = "0x56CEF60", Offset = "0x56CDB60", VA = "0x1856CEF60", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x04000976 RID: 2422
		[Token(Token = "0x4000976")]
		[FieldOffset(Offset = "0x0")]
		[InputControl(displayName = "Attitude", processors = "CompensateRotation", noisy = true)]
		public Quaternion attitude;
	}
}
