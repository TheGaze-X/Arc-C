using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001A7 RID: 423
	[Token(Token = "0x20001A7")]
	[StructLayout(2)]
	public struct DeviceResetEvent : IInputEventTypeInfo
	{
		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x00008310 File Offset: 0x00006510
		[Token(Token = "0x17000473")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000FCB")]
			[Address(RVA = "0x56CF730", Offset = "0x56CE330", VA = "0x1856CF730", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00008328 File Offset: 0x00006528
		[Token(Token = "0x6000FCC")]
		[Address(RVA = "0x56CF650", Offset = "0x56CE250", VA = "0x1856CF650")]
		public static DeviceResetEvent Create(int deviceId, bool hardReset = false, double time = -1.0)
		{
			return default(DeviceResetEvent);
		}

		// Token: 0x040009A5 RID: 2469
		[Token(Token = "0x40009A5")]
		public const int Type = 1146245972;

		// Token: 0x040009A6 RID: 2470
		[Token(Token = "0x40009A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputEvent baseEvent;

		// Token: 0x040009A7 RID: 2471
		[Token(Token = "0x40009A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool hardReset;
	}
}
