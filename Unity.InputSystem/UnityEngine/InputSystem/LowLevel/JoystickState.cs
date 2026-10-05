using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x0200018F RID: 399
	[Token(Token = "0x200018F")]
	internal struct JoystickState : IInputStateTypeInfo
	{
		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000F78 RID: 3960 RVA: 0x00007DB8 File Offset: 0x00005FB8
		[Token(Token = "0x17000440")]
		public static FourCC kFormat
		{
			[Token(Token = "0x6000F78")]
			[Address(RVA = "0x56DEAA0", Offset = "0x56DD6A0", VA = "0x1856DEAA0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x00007DD0 File Offset: 0x00005FD0
		[Token(Token = "0x17000441")]
		public FourCC format
		{
			[Token(Token = "0x6000F79")]
			[Address(RVA = "0x56DEA60", Offset = "0x56DD660", VA = "0x1856DEA60", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x0400094D RID: 2381
		[Token(Token = "0x400094D")]
		[FieldOffset(Offset = "0x0")]
		[InputControl(name = "trigger", displayName = "Trigger", layout = "Button", usages = new string[]
		{
			"PrimaryTrigger",
			"PrimaryAction",
			"Submit"
		}, bit = 4U)]
		public int buttons;

		// Token: 0x0400094E RID: 2382
		[Token(Token = "0x400094E")]
		[FieldOffset(Offset = "0x4")]
		[InputControl(displayName = "Stick", layout = "Stick", usage = "Primary2DMotion", processors = "stickDeadzone")]
		public Vector2 stick;

		// Token: 0x02000190 RID: 400
		[Token(Token = "0x2000190")]
		public enum Button
		{
			// Token: 0x04000950 RID: 2384
			[Token(Token = "0x4000950")]
			HatSwitchUp,
			// Token: 0x04000951 RID: 2385
			[Token(Token = "0x4000951")]
			HatSwitchDown,
			// Token: 0x04000952 RID: 2386
			[Token(Token = "0x4000952")]
			HatSwitchLeft,
			// Token: 0x04000953 RID: 2387
			[Token(Token = "0x4000953")]
			HatSwitchRight,
			// Token: 0x04000954 RID: 2388
			[Token(Token = "0x4000954")]
			Trigger
		}
	}
}
