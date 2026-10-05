using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001A5 RID: 421
	[Token(Token = "0x20001A5")]
	[StructLayout(2)]
	public struct DeviceConfigurationEvent : IInputEventTypeInfo
	{
		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x00008280 File Offset: 0x00006480
		[Token(Token = "0x17000471")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000FC5")]
			[Address(RVA = "0x56CF570", Offset = "0x56CE170", VA = "0x1856CF570", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x00008298 File Offset: 0x00006498
		[Token(Token = "0x6000FC6")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public InputEventPtr ToEventPtr()
		{
			return default(InputEventPtr);
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x000082B0 File Offset: 0x000064B0
		[Token(Token = "0x6000FC7")]
		[Address(RVA = "0x56CF4B0", Offset = "0x56CE0B0", VA = "0x1856CF4B0")]
		public static DeviceConfigurationEvent Create(int deviceId, double time)
		{
			return default(DeviceConfigurationEvent);
		}

		// Token: 0x040009A1 RID: 2465
		[Token(Token = "0x40009A1")]
		public const int Type = 1145259591;

		// Token: 0x040009A2 RID: 2466
		[Token(Token = "0x40009A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputEvent baseEvent;
	}
}
