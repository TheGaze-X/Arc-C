using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.DualShock.LowLevel
{
	// Token: 0x02000161 RID: 353
	[Token(Token = "0x2000161")]
	[StructLayout(2)]
	internal struct DualShock3HIDInputReport : IInputStateTypeInfo
	{
		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x000076F8 File Offset: 0x000058F8
		[Token(Token = "0x1700040A")]
		public FourCC format
		{
			[Token(Token = "0x6000F0A")]
			[Address(RVA = "0x56D1300", Offset = "0x56CFF00", VA = "0x1856D1300", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x040008BB RID: 2235
		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ushort padding1;

		// Token: 0x040008BC RID: 2236
		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		[InputControl(name = "leftStickPress", bit = 1U)]
		[InputControl(name = "select", displayName = "Share", bit = 0U)]
		[InputControl(name = "rightStickPress", bit = 2U)]
		[InputControl(name = "dpad", format = "BIT", layout = "Dpad", bit = 4U, sizeInBits = 4U)]
		[InputControl(name = "dpad/up", bit = 4U)]
		[InputControl(name = "dpad/right", bit = 5U)]
		[InputControl(name = "dpad/down", bit = 6U)]
		[InputControl(name = "dpad/left", bit = 7U)]
		[InputControl(name = "start", displayName = "Options", bit = 3U)]
		public byte buttons1;

		// Token: 0x040008BD RID: 2237
		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		[InputControl(name = "rightShoulder", bit = 3U)]
		[InputControl(name = "buttonNorth", displayName = "Triangle", bit = 4U)]
		[InputControl(name = "buttonWest", displayName = "Square", bit = 7U)]
		[InputControl(name = "leftShoulder", bit = 2U)]
		[InputControl(name = "rightTriggerButton", layout = "Button", bit = 1U, synthetic = true)]
		[InputControl(name = "leftTriggerButton", layout = "Button", bit = 0U, synthetic = true)]
		[InputControl(name = "buttonSouth", displayName = "Cross", bit = 6U)]
		[InputControl(name = "buttonEast", displayName = "Circle", bit = 5U)]
		public byte buttons2;

		// Token: 0x040008BE RID: 2238
		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[InputControl(name = "touchpadButton", layout = "Button", displayName = "Touchpad Press", bit = 1U)]
		[InputControl(name = "systemButton", layout = "Button", displayName = "System", bit = 0U)]
		public byte buttons3;

		// Token: 0x040008BF RID: 2239
		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		private byte padding2;

		// Token: 0x040008C0 RID: 2240
		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		[InputControl(name = "leftStick/down", offset = 1U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1,invert=false")]
		[InputControl(name = "leftStick/up", offset = 1U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "leftStick/y", offset = 1U, format = "BYTE", parameters = "invert,normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		[InputControl(name = "leftStick/right", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
		[InputControl(name = "leftStick/left", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "leftStick/x", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		[InputControl(name = "leftStick", layout = "Stick", format = "VC2B")]
		public byte leftStickX;

		// Token: 0x040008C1 RID: 2241
		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
		public byte leftStickY;

		// Token: 0x040008C2 RID: 2242
		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[InputControl(name = "rightStick", layout = "Stick", format = "VC2B")]
		[InputControl(name = "rightStick/x", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		[InputControl(name = "rightStick/left", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "rightStick/right", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
		[InputControl(name = "rightStick/y", offset = 1U, format = "BYTE", parameters = "invert,normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
		[InputControl(name = "rightStick/up", offset = 1U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "rightStick/down", offset = 1U, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1,invert=false")]
		public byte rightStickX;

		// Token: 0x040008C3 RID: 2243
		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public byte rightStickY;

		// Token: 0x040008C4 RID: 2244
		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		[FixedBuffer(typeof(byte), 8)]
		private DualShock3HIDInputReport.<padding3>e__FixedBuffer padding3;

		// Token: 0x040008C5 RID: 2245
		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		[InputControl(name = "leftTrigger", format = "BYTE")]
		public byte leftTrigger;

		// Token: 0x040008C6 RID: 2246
		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		[InputControl(name = "rightTrigger", format = "BYTE")]
		public byte rightTrigger;

		// Token: 0x02000162 RID: 354
		[Token(Token = "0x2000162")]
		[CompilerGenerated]
		[UnsafeValueType]
		public struct <padding3>e__FixedBuffer
		{
			// Token: 0x040008C7 RID: 2247
			[Token(Token = "0x40008C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
