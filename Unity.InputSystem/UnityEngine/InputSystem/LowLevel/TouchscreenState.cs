using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x0200019E RID: 414
	[Token(Token = "0x200019E")]
	[StructLayout(2)]
	internal struct TouchscreenState : IInputStateTypeInfo
	{
		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x000080E8 File Offset: 0x000062E8
		[Token(Token = "0x17000460")]
		public static FourCC Format
		{
			[Token(Token = "0x6000FA7")]
			[Address(RVA = "0x56E3F10", Offset = "0x56E2B10", VA = "0x1856E3F10")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000461")]
		public unsafe TouchState* primaryTouch
		{
			[Token(Token = "0x6000FA8")]
			[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000462")]
		public unsafe TouchState* touches
		{
			[Token(Token = "0x6000FA9")]
			[Address(RVA = "0x56E3F90", Offset = "0x56E2B90", VA = "0x1856E3F90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x00008100 File Offset: 0x00006300
		[Token(Token = "0x17000463")]
		public FourCC format
		{
			[Token(Token = "0x6000FAA")]
			[Address(RVA = "0x56E3F50", Offset = "0x56E2B50", VA = "0x1856E3F50", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x0400098C RID: 2444
		[Token(Token = "0x400098C")]
		public const int MaxTouches = 10;

		// Token: 0x0400098D RID: 2445
		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[InputControl(name = "pressure", useStateFrom = "primaryTouch/pressure")]
		[FixedBuffer(typeof(byte), 56)]
		[InputControl(name = "primaryTouch", displayName = "Primary Touch", layout = "Touch", synthetic = true)]
		[InputControl(name = "primaryTouch/tap", usage = "PrimaryAction")]
		[InputControl(name = "position", useStateFrom = "primaryTouch/position")]
		[InputControl(name = "delta", useStateFrom = "primaryTouch/delta", layout = "Delta")]
		[InputControl(name = "radius", useStateFrom = "primaryTouch/radius")]
		[InputControl(name = "press", useStateFrom = "primaryTouch/phase", layout = "TouchPress", synthetic = true, usages = new string[]
		{

		})]
		public TouchscreenState.<primaryTouchData>e__FixedBuffer primaryTouchData;

		// Token: 0x0400098E RID: 2446
		[Token(Token = "0x400098E")]
		internal const int kTouchDataOffset = 56;

		// Token: 0x0400098F RID: 2447
		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[FixedBuffer(typeof(byte), 560)]
		[InputControl(layout = "Touch", name = "touch", displayName = "Touch", arraySize = 10)]
		public TouchscreenState.<touchData>e__FixedBuffer touchData;

		// Token: 0x0200019F RID: 415
		[Token(Token = "0x200019F")]
		[CompilerGenerated]
		[UnsafeValueType]
		public struct <primaryTouchData>e__FixedBuffer
		{
			// Token: 0x04000990 RID: 2448
			[Token(Token = "0x4000990")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}

		// Token: 0x020001A0 RID: 416
		[Token(Token = "0x20001A0")]
		[CompilerGenerated]
		[UnsafeValueType]
		public struct <touchData>e__FixedBuffer
		{
			// Token: 0x04000991 RID: 2449
			[Token(Token = "0x4000991")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public byte FixedElementField;
		}
	}
}
