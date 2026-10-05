using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.DualShock.LowLevel
{
	// Token: 0x0200015D RID: 349
	[Token(Token = "0x200015D")]
	[StructLayout(2)]
	internal struct DualSenseHIDUSBOutputReport : IInputDeviceCommandInfo
	{
		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x00007650 File Offset: 0x00005850
		[Token(Token = "0x17000405")]
		public static FourCC Type
		{
			[Token(Token = "0x6000F02")]
			[Address(RVA = "0x56C9CB0", Offset = "0x56C88B0", VA = "0x1856C9CB0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x00007668 File Offset: 0x00005868
		[Token(Token = "0x17000406")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000F03")]
			[Address(RVA = "0x56C9CF0", Offset = "0x56C88F0", VA = "0x1856C9CF0", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00007680 File Offset: 0x00005880
		[Token(Token = "0x6000F04")]
		[Address(RVA = "0x56D1180", Offset = "0x56CFD80", VA = "0x1856D1180")]
		public static DualSenseHIDUSBOutputReport Create(DualSenseHIDOutputReportPayload payload)
		{
			return default(DualSenseHIDUSBOutputReport);
		}

		// Token: 0x040008A4 RID: 2212
		[Token(Token = "0x40008A4")]
		internal const int kSize = 56;

		// Token: 0x040008A5 RID: 2213
		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputDeviceCommand baseCommand;

		// Token: 0x040008A6 RID: 2214
		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte reportId;

		// Token: 0x040008A7 RID: 2215
		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public DualSenseHIDOutputReportPayload payload;
	}
}
