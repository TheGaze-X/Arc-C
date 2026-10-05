using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.DualShock.LowLevel
{
	// Token: 0x02000160 RID: 352
	[Token(Token = "0x2000160")]
	[StructLayout(2)]
	internal struct DualShock4HIDInputReport : IInputStateTypeInfo
	{
		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x000076E0 File Offset: 0x000058E0
		[Token(Token = "0x17000409")]
		public FourCC format
		{
			[Token(Token = "0x6000F08")]
			[Address(RVA = "0x56D2370", Offset = "0x56D0F70", VA = "0x1856D2370", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x040008B1 RID: 2225
		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static FourCC Format;

		// Token: 0x040008B2 RID: 2226
		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[InputControl(name = "leftStick", layout = "Stick", format = "VC2B")]
		[InputControl(name = "leftStick/down", offset = 1U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1,invert=false")]
		[InputControl(name = "leftStick/left", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "leftStick/right", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
		[InputControl(name = "leftStick/y", offset = 1U, format = "BYTE", parameters = "invert,normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		[InputControl(name = "leftStick/up", offset = 1U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "leftStick/x", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		public byte leftStickX;

		// Token: 0x040008B3 RID: 2227
		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte leftStickY;

		// Token: 0x040008B4 RID: 2228
		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		[InputControl(name = "rightStick/down", offset = 1U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1,invert=false")]
		[InputControl(name = "rightStick", layout = "Stick", format = "VC2B")]
		[InputControl(name = "rightStick/x", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		[InputControl(name = "rightStick/left", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "rightStick/right", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
		[InputControl(name = "rightStick/y", offset = 1U, format = "BYTE", parameters = "invert,normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		[InputControl(name = "rightStick/up", offset = 1U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		public byte rightStickX;

		// Token: 0x040008B5 RID: 2229
		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public byte rightStickY;

		// Token: 0x040008B6 RID: 2230
		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[InputControl(name = "dpad/left", format = "BIT", layout = "DiscreteButton", parameters = "minValue=5, maxValue=7", bit = 0U, sizeInBits = 4U)]
		[InputControl(name = "buttonWest", displayName = "Square", bit = 4U)]
		[InputControl(name = "dpad", format = "BIT", layout = "Dpad", sizeInBits = 4U, defaultState = 8)]
		[InputControl(name = "dpad/up", format = "BIT", layout = "DiscreteButton", parameters = "minValue=7,maxValue=1,nullValue=8,wrapAtValue=7", bit = 0U, sizeInBits = 4U)]
		[InputControl(name = "dpad/right", format = "BIT", layout = "DiscreteButton", parameters = "minValue=1,maxValue=3", bit = 0U, sizeInBits = 4U)]
		[InputControl(name = "dpad/down", format = "BIT", layout = "DiscreteButton", parameters = "minValue=3,maxValue=5", bit = 0U, sizeInBits = 4U)]
		[InputControl(name = "buttonNorth", displayName = "Triangle", bit = 7U)]
		[InputControl(name = "buttonSouth", displayName = "Cross", bit = 5U)]
		[InputControl(name = "buttonEast", displayName = "Circle", bit = 6U)]
		public byte buttons1;

		// Token: 0x040008B7 RID: 2231
		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		[InputControl(name = "rightStickPress", bit = 7U)]
		[InputControl(name = "leftStickPress", bit = 6U)]
		[InputControl(name = "start", displayName = "Options", bit = 5U)]
		[InputControl(name = "rightTriggerButton", layout = "Button", bit = 3U, synthetic = true)]
		[InputControl(name = "select", displayName = "Share", bit = 4U)]
		[InputControl(name = "rightShoulder", bit = 1U)]
		[InputControl(name = "leftTriggerButton", layout = "Button", bit = 2U, synthetic = true)]
		[InputControl(name = "leftShoulder", bit = 0U)]
		public byte buttons2;

		// Token: 0x040008B8 RID: 2232
		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		[InputControl(name = "touchpadButton", layout = "Button", displayName = "Touchpad Press", bit = 1U)]
		[InputControl(name = "systemButton", layout = "Button", displayName = "System", bit = 0U)]
		public byte buttons3;

		// Token: 0x040008B9 RID: 2233
		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
		[InputControl(name = "leftTrigger", format = "BYTE")]
		public byte leftTrigger;

		// Token: 0x040008BA RID: 2234
		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[InputControl(name = "rightTrigger", format = "BYTE")]
		public byte rightTrigger;
	}
}
