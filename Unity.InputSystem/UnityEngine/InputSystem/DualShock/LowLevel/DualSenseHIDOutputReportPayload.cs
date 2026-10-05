using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.DualShock.LowLevel
{
	// Token: 0x0200015C RID: 348
	[Token(Token = "0x200015C")]
	[StructLayout(2)]
	internal struct DualSenseHIDOutputReportPayload
	{
		// Token: 0x0400089D RID: 2205
		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte enableFlags1;

		// Token: 0x0400089E RID: 2206
		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte enableFlags2;

		// Token: 0x0400089F RID: 2207
		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public byte highFrequencyMotorSpeed;

		// Token: 0x040008A0 RID: 2208
		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public byte lowFrequencyMotorSpeed;

		// Token: 0x040008A1 RID: 2209
		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public byte redColor;

		// Token: 0x040008A2 RID: 2210
		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public byte greenColor;

		// Token: 0x040008A3 RID: 2211
		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
		public byte blueColor;
	}
}
