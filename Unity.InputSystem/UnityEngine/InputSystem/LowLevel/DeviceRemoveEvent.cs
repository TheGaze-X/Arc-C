using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001A6 RID: 422
	[Token(Token = "0x20001A6")]
	[StructLayout(2)]
	public struct DeviceRemoveEvent : IInputEventTypeInfo
	{
		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x000082C8 File Offset: 0x000064C8
		[Token(Token = "0x17000472")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000FC8")]
			[Address(RVA = "0x56CF640", Offset = "0x56CE240", VA = "0x1856CF640", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x000082E0 File Offset: 0x000064E0
		[Token(Token = "0x6000FC9")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public InputEventPtr ToEventPtr()
		{
			return default(InputEventPtr);
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x000082F8 File Offset: 0x000064F8
		[Token(Token = "0x6000FCA")]
		[Address(RVA = "0x56CF580", Offset = "0x56CE180", VA = "0x1856CF580")]
		public static DeviceRemoveEvent Create(int deviceId, double time = -1.0)
		{
			return default(DeviceRemoveEvent);
		}

		// Token: 0x040009A3 RID: 2467
		[Token(Token = "0x40009A3")]
		public const int Type = 1146242381;

		// Token: 0x040009A4 RID: 2468
		[Token(Token = "0x40009A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputEvent baseEvent;
	}
}
