using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x02000187 RID: 391
	[Token(Token = "0x2000187")]
	[StructLayout(2)]
	public struct GamepadState : IInputStateTypeInfo
	{
		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000F6B RID: 3947 RVA: 0x00007D28 File Offset: 0x00005F28
		[Token(Token = "0x1700043C")]
		public static FourCC Format
		{
			[Token(Token = "0x6000F6B")]
			[Address(RVA = "0x56D5FC0", Offset = "0x56D4BC0", VA = "0x1856D5FC0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x00007D40 File Offset: 0x00005F40
		[Token(Token = "0x1700043D")]
		public FourCC format
		{
			[Token(Token = "0x6000F6C")]
			[Address(RVA = "0x56D6000", Offset = "0x56D4C00", VA = "0x1856D6000", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F6D")]
		[Address(RVA = "0x56D5F10", Offset = "0x56D4B10", VA = "0x1856D5F10")]
		public GamepadState(params GamepadButton[] buttons)
		{
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00007D58 File Offset: 0x00005F58
		[Token(Token = "0x6000F6E")]
		[Address(RVA = "0x56D5EC0", Offset = "0x56D4AC0", VA = "0x1856D5EC0")]
		public GamepadState WithButton(GamepadButton button, bool value = true)
		{
			return default(GamepadState);
		}

		// Token: 0x04000927 RID: 2343
		[Token(Token = "0x4000927")]
		internal const string ButtonSouthShortDisplayName = "A";

		// Token: 0x04000928 RID: 2344
		[Token(Token = "0x4000928")]
		internal const string ButtonNorthShortDisplayName = "Y";

		// Token: 0x04000929 RID: 2345
		[Token(Token = "0x4000929")]
		internal const string ButtonWestShortDisplayName = "X";

		// Token: 0x0400092A RID: 2346
		[Token(Token = "0x400092A")]
		internal const string ButtonEastShortDisplayName = "B";

		// Token: 0x0400092B RID: 2347
		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[InputControl(name = "select", layout = "Button", bit = 13U, displayName = "Select")]
		[InputControl(name = "dpad", layout = "Dpad", usage = "Hatswitch", displayName = "D-Pad", format = "BIT", sizeInBits = 4U, bit = 0U)]
		[InputControl(name = "buttonSouth", layout = "Button", bit = 6U, usages = new string[]
		{
			"PrimaryAction",
			"Submit"
		}, aliases = new string[]
		{
			"a",
			"cross"
		}, displayName = "Button South", shortDisplayName = "A")]
		[InputControl(name = "buttonWest", layout = "Button", bit = 7U, usage = "SecondaryAction", aliases = new string[]
		{
			"x",
			"square"
		}, displayName = "Button West", shortDisplayName = "X")]
		[InputControl(name = "buttonNorth", layout = "Button", bit = 4U, aliases = new string[]
		{
			"y",
			"triangle"
		}, displayName = "Button North", shortDisplayName = "Y")]
		[InputControl(name = "buttonEast", layout = "Button", bit = 5U, usages = new string[]
		{
			"Back",
			"Cancel"
		}, aliases = new string[]
		{
			"b",
			"circle"
		}, displayName = "Button East", shortDisplayName = "B")]
		[InputControl(name = "leftStickPress", layout = "Button", bit = 8U, displayName = "Left Stick Press")]
		[InputControl(name = "rightStickPress", layout = "Button", bit = 9U, displayName = "Right Stick Press")]
		[InputControl(name = "rightShoulder", layout = "Button", bit = 11U, displayName = "Right Shoulder", shortDisplayName = "RB")]
		[InputControl(name = "start", layout = "Button", bit = 12U, usage = "Menu", displayName = "Start")]
		[InputControl(name = "leftShoulder", layout = "Button", bit = 10U, displayName = "Left Shoulder", shortDisplayName = "LB")]
		public uint buttons;

		// Token: 0x0400092C RID: 2348
		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[InputControl(layout = "Stick", usage = "Primary2DMotion", processors = "stickDeadzone", displayName = "Left Stick", shortDisplayName = "LS")]
		public Vector2 leftStick;

		// Token: 0x0400092D RID: 2349
		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[InputControl(layout = "Stick", usage = "Secondary2DMotion", processors = "stickDeadzone", displayName = "Right Stick", shortDisplayName = "RS")]
		public Vector2 rightStick;

		// Token: 0x0400092E RID: 2350
		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[InputControl(layout = "Button", format = "FLT", usage = "SecondaryTrigger", displayName = "Left Trigger", shortDisplayName = "LT")]
		public float leftTrigger;

		// Token: 0x0400092F RID: 2351
		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[InputControl(layout = "Button", format = "FLT", usage = "SecondaryTrigger", displayName = "Right Trigger", shortDisplayName = "RT")]
		public float rightTrigger;
	}
}
