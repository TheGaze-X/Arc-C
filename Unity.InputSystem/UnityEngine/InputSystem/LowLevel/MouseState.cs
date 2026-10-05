using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x02000193 RID: 403
	[Token(Token = "0x2000193")]
	[StructLayout(2)]
	public struct MouseState : IInputStateTypeInfo
	{
		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x00007E18 File Offset: 0x00006018
		[Token(Token = "0x17000444")]
		public static FourCC Format
		{
			[Token(Token = "0x6000F80")]
			[Address(RVA = "0x56DED20", Offset = "0x56DD920", VA = "0x1856DED20")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00007E30 File Offset: 0x00006030
		[Token(Token = "0x6000F81")]
		[Address(RVA = "0x56DECD0", Offset = "0x56DD8D0", VA = "0x1856DECD0")]
		public MouseState WithButton(MouseButton button, bool state = true)
		{
			return default(MouseState);
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x00007E48 File Offset: 0x00006048
		[Token(Token = "0x17000445")]
		public FourCC format
		{
			[Token(Token = "0x6000F82")]
			[Address(RVA = "0x56DED60", Offset = "0x56DD960", VA = "0x1856DED60", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x04000959 RID: 2393
		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[InputControl(usage = "Point", dontReset = true)]
		public Vector2 position;

		// Token: 0x0400095A RID: 2394
		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[InputControl(usage = "Secondary2DMotion", layout = "Delta")]
		public Vector2 delta;

		// Token: 0x0400095B RID: 2395
		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[InputControl(name = "scroll/y", aliases = new string[]
		{
			"vertical"
		}, usage = "ScrollVertical", displayName = "Up/Down", shortDisplayName = "Wheel")]
		[InputControl(displayName = "Scroll", layout = "Delta")]
		[InputControl(name = "scroll/x", aliases = new string[]
		{
			"horizontal"
		}, usage = "ScrollHorizontal", displayName = "Left/Right")]
		public Vector2 scroll;

		// Token: 0x0400095C RID: 2396
		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[InputControl(name = "press", useStateFrom = "leftButton", synthetic = true, usages = new string[]
		{

		})]
		[InputControl(name = "leftButton", layout = "Button", bit = 0U, usage = "PrimaryAction", displayName = "Left Button", shortDisplayName = "LMB")]
		[InputControl(name = "rightButton", layout = "Button", bit = 1U, usage = "SecondaryAction", displayName = "Right Button", shortDisplayName = "RMB")]
		[InputControl(name = "middleButton", layout = "Button", bit = 2U, displayName = "Middle Button", shortDisplayName = "MMB")]
		[InputControl(name = "forwardButton", layout = "Button", bit = 3U, usage = "Forward", displayName = "Forward")]
		[InputControl(name = "backButton", layout = "Button", bit = 4U, usage = "Back", displayName = "Back")]
		[InputControl(name = "pressure", layout = "Axis", usage = "Pressure", offset = 4294967294U, format = "FLT", sizeInBits = 32U)]
		[InputControl(name = "radius", layout = "Vector2", usage = "Radius", offset = 4294967294U, format = "VEC2", sizeInBits = 64U)]
		[InputControl(name = "pointerId", layout = "Digital", format = "BIT", sizeInBits = 1U, offset = 4294967294U)]
		public ushort buttons;

		// Token: 0x0400095D RID: 2397
		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[InputControl(name = "displayIndex", layout = "Integer", displayName = "Display Index")]
		public ushort displayIndex;

		// Token: 0x0400095E RID: 2398
		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[InputControl(name = "clickCount", layout = "Integer", displayName = "Click Count", synthetic = true)]
		public ushort clickCount;
	}
}
