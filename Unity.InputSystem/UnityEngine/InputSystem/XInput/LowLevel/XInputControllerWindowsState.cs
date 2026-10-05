using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.XInput.LowLevel
{
	// Token: 0x020000FF RID: 255
	[Token(Token = "0x20000FF")]
	[StructLayout(2)]
	internal struct XInputControllerWindowsState : IInputStateTypeInfo
	{
		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x00005FA0 File Offset: 0x000041A0
		[Token(Token = "0x1700033E")]
		public FourCC format
		{
			[Token(Token = "0x6000C5D")]
			[Address(RVA = "0x56B50B0", Offset = "0x56B3CB0", VA = "0x1856B50B0", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00005FB8 File Offset: 0x000041B8
		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0x56B5080", Offset = "0x56B3C80", VA = "0x1856B5080")]
		public XInputControllerWindowsState WithButton(XInputControllerWindowsState.Button button)
		{
			return default(XInputControllerWindowsState);
		}

		// Token: 0x040005A3 RID: 1443
		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[InputControl(name = "buttonSouth", bit = 12U, displayName = "A")]
		[InputControl(name = "buttonEast", bit = 13U, displayName = "B")]
		[InputControl(name = "dpad/down", bit = 1U)]
		[InputControl(name = "dpad/left", bit = 2U)]
		[InputControl(name = "dpad/right", bit = 3U)]
		[InputControl(name = "start", bit = 4U, displayName = "Start")]
		[InputControl(name = "leftShoulder", bit = 8U)]
		[InputControl(name = "dpad", layout = "Dpad", sizeInBits = 4U, bit = 0U)]
		[InputControl(name = "buttonWest", bit = 14U, displayName = "X")]
		[InputControl(name = "rightStickPress", bit = 7U)]
		[InputControl(name = "rightShoulder", bit = 9U)]
		[InputControl(name = "leftStickPress", bit = 6U)]
		[InputControl(name = "dpad/up", bit = 0U)]
		[InputControl(name = "select", bit = 5U, displayName = "Select")]
		[InputControl(name = "buttonNorth", bit = 15U, displayName = "Y")]
		public ushort buttons;

		// Token: 0x040005A4 RID: 1444
		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		[InputControl(name = "leftTrigger", format = "BYTE")]
		public byte leftTrigger;

		// Token: 0x040005A5 RID: 1445
		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		[InputControl(name = "rightTrigger", format = "BYTE")]
		public byte rightTrigger;

		// Token: 0x040005A6 RID: 1446
		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[InputControl(name = "leftStick/left", offset = 0U, format = "SHRT")]
		[InputControl(name = "leftStick", layout = "Stick", format = "VC2S")]
		[InputControl(name = "leftStick/x", offset = 0U, format = "SHRT", parameters = "clamp=false,invert=false,normalize=false")]
		[InputControl(name = "leftStick/right", offset = 0U, format = "SHRT")]
		[InputControl(name = "leftStick/y", offset = 2U, format = "SHRT", parameters = "clamp=false,invert=false,normalize=false")]
		[InputControl(name = "leftStick/up", offset = 2U, format = "SHRT")]
		[InputControl(name = "leftStick/down", offset = 2U, format = "SHRT")]
		public short leftStickX;

		// Token: 0x040005A7 RID: 1447
		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public short leftStickY;

		// Token: 0x040005A8 RID: 1448
		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[InputControl(name = "rightStick", layout = "Stick", format = "VC2S")]
		[InputControl(name = "rightStick/x", offset = 0U, format = "SHRT", parameters = "clamp=false,invert=false,normalize=false")]
		[InputControl(name = "rightStick/left", offset = 0U, format = "SHRT")]
		[InputControl(name = "rightStick/right", offset = 0U, format = "SHRT")]
		[InputControl(name = "rightStick/y", offset = 2U, format = "SHRT", parameters = "clamp=false,invert=false,normalize=false")]
		[InputControl(name = "rightStick/down", offset = 2U, format = "SHRT")]
		[InputControl(name = "rightStick/up", offset = 2U, format = "SHRT")]
		public short rightStickX;

		// Token: 0x040005A9 RID: 1449
		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public short rightStickY;

		// Token: 0x02000100 RID: 256
		[Token(Token = "0x2000100")]
		public enum Button
		{
			// Token: 0x040005AB RID: 1451
			[Token(Token = "0x40005AB")]
			DPadUp,
			// Token: 0x040005AC RID: 1452
			[Token(Token = "0x40005AC")]
			DPadDown,
			// Token: 0x040005AD RID: 1453
			[Token(Token = "0x40005AD")]
			DPadLeft,
			// Token: 0x040005AE RID: 1454
			[Token(Token = "0x40005AE")]
			DPadRight,
			// Token: 0x040005AF RID: 1455
			[Token(Token = "0x40005AF")]
			Start,
			// Token: 0x040005B0 RID: 1456
			[Token(Token = "0x40005B0")]
			Select,
			// Token: 0x040005B1 RID: 1457
			[Token(Token = "0x40005B1")]
			LeftThumbstickPress,
			// Token: 0x040005B2 RID: 1458
			[Token(Token = "0x40005B2")]
			RightThumbstickPress,
			// Token: 0x040005B3 RID: 1459
			[Token(Token = "0x40005B3")]
			LeftShoulder,
			// Token: 0x040005B4 RID: 1460
			[Token(Token = "0x40005B4")]
			RightShoulder,
			// Token: 0x040005B5 RID: 1461
			[Token(Token = "0x40005B5")]
			A = 12,
			// Token: 0x040005B6 RID: 1462
			[Token(Token = "0x40005B6")]
			B,
			// Token: 0x040005B7 RID: 1463
			[Token(Token = "0x40005B7")]
			X,
			// Token: 0x040005B8 RID: 1464
			[Token(Token = "0x40005B8")]
			Y
		}
	}
}
