using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.DualShock.LowLevel
{
	// Token: 0x0200015B RID: 347
	[Token(Token = "0x200015B")]
	[StructLayout(2)]
	internal struct DualSenseHIDInputReport : IInputStateTypeInfo
	{
		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x00007638 File Offset: 0x00005838
		[Token(Token = "0x17000404")]
		public FourCC format
		{
			[Token(Token = "0x6000F00")]
			[Address(RVA = "0x56D1040", Offset = "0x56CFC40", VA = "0x1856D1040", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x04000893 RID: 2195
		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static FourCC Format;

		// Token: 0x04000894 RID: 2196
		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[InputControl(name = "leftStick", layout = "Stick", format = "VC2B")]
		[InputControl(name = "leftStick/x", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		[InputControl(name = "leftStick/left", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "leftStick/down", offset = 1U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1,invert=false")]
		[InputControl(name = "leftStick/up", offset = 1U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "leftStick/right", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
		[InputControl(name = "leftStick/y", offset = 1U, format = "BYTE", parameters = "invert,normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		public byte leftStickX;

		// Token: 0x04000895 RID: 2197
		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte leftStickY;

		// Token: 0x04000896 RID: 2198
		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		[InputControl(name = "rightStick/down", offset = 1U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1,invert=false")]
		[InputControl(name = "rightStick/y", offset = 1U, format = "BYTE", parameters = "invert,normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		[InputControl(name = "rightStick/right", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
		[InputControl(name = "rightStick/left", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "rightStick/x", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		[InputControl(name = "rightStick", layout = "Stick", format = "VC2B")]
		[InputControl(name = "rightStick/up", offset = 1U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		public byte rightStickX;

		// Token: 0x04000897 RID: 2199
		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public byte rightStickY;

		// Token: 0x04000898 RID: 2200
		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[InputControl(name = "leftTrigger", format = "BYTE")]
		public byte leftTrigger;

		// Token: 0x04000899 RID: 2201
		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		[InputControl(name = "rightTrigger", format = "BYTE")]
		public byte rightTrigger;

		// Token: 0x0400089A RID: 2202
		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		[InputControl(name = "dpad/right", format = "BIT", layout = "DiscreteButton", parameters = "minValue=1,maxValue=3", bit = 0U, sizeInBits = 4U)]
		[InputControl(name = "buttonWest", displayName = "Square", bit = 4U)]
		[InputControl(name = "dpad", format = "BIT", layout = "Dpad", sizeInBits = 4U, defaultState = 8)]
		[InputControl(name = "buttonNorth", displayName = "Triangle", bit = 7U)]
		[InputControl(name = "buttonEast", displayName = "Circle", bit = 6U)]
		[InputControl(name = "buttonSouth", displayName = "Cross", bit = 5U)]
		[InputControl(name = "dpad/up", format = "BIT", layout = "DiscreteButton", parameters = "minValue=7,maxValue=1,nullValue=8,wrapAtValue=7", bit = 0U, sizeInBits = 4U)]
		[InputControl(name = "dpad/down", format = "BIT", layout = "DiscreteButton", parameters = "minValue=3,maxValue=5", bit = 0U, sizeInBits = 4U)]
		[InputControl(name = "dpad/left", format = "BIT", layout = "DiscreteButton", parameters = "minValue=5, maxValue=7", bit = 0U, sizeInBits = 4U)]
		public byte buttons0;

		// Token: 0x0400089B RID: 2203
		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
		[InputControl(name = "leftTriggerButton", layout = "Button", bit = 2U)]
		[InputControl(name = "rightTriggerButton", layout = "Button", bit = 3U)]
		[InputControl(name = "select", displayName = "Share", bit = 4U)]
		[InputControl(name = "rightStickPress", bit = 7U)]
		[InputControl(name = "leftStickPress", bit = 6U)]
		[InputControl(name = "leftShoulder", bit = 0U)]
		[InputControl(name = "start", displayName = "Options", bit = 5U)]
		[InputControl(name = "rightShoulder", bit = 1U)]
		public byte buttons1;

		// Token: 0x0400089C RID: 2204
		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[InputControl(name = "micButton", layout = "Button", displayName = "Mic Mute", bit = 2U)]
		[InputControl(name = "touchpadButton", layout = "Button", displayName = "Touchpad Press", bit = 1U)]
		[InputControl(name = "systemButton", layout = "Button", displayName = "System", bit = 0U)]
		public byte buttons2;
	}
}
