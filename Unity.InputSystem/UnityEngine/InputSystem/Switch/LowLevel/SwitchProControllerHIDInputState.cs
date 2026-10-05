using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Switch.LowLevel
{
	// Token: 0x02000129 RID: 297
	[Token(Token = "0x2000129")]
	[StructLayout(2)]
	internal struct SwitchProControllerHIDInputState : IInputStateTypeInfo
	{
		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x00006C90 File Offset: 0x00004E90
		[Token(Token = "0x170003AB")]
		public FourCC format
		{
			[Token(Token = "0x6000DD0")]
			[Address(RVA = "0x56CA0E0", Offset = "0x56C8CE0", VA = "0x1856CA0E0", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00006CA8 File Offset: 0x00004EA8
		[Token(Token = "0x6000DD1")]
		[Address(RVA = "0x56C9F80", Offset = "0x56C8B80", VA = "0x1856C9F80")]
		[MethodImpl(256)]
		public SwitchProControllerHIDInputState WithButton(SwitchProControllerHIDInputState.Button button, bool value = true)
		{
			return default(SwitchProControllerHIDInputState);
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD2")]
		[Address(RVA = "0x56C9F10", Offset = "0x56C8B10", VA = "0x1856C9F10")]
		[MethodImpl(256)]
		public void Set(SwitchProControllerHIDInputState.Button button, bool state)
		{
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0x56C9DF0", Offset = "0x56C89F0", VA = "0x1856C9DF0")]
		[MethodImpl(256)]
		public void Press(SwitchProControllerHIDInputState.Button button)
		{
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0x56C9E80", Offset = "0x56C8A80", VA = "0x1856C9E80")]
		[MethodImpl(256)]
		public void Release(SwitchProControllerHIDInputState.Button button)
		{
		}

		// Token: 0x040006C3 RID: 1731
		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static FourCC Format;

		// Token: 0x040006C4 RID: 1732
		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[InputControl(name = "leftStick/x", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5")]
		[InputControl(name = "leftStick", layout = "Stick", format = "VC2B")]
		[InputControl(name = "leftStick/left", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.15,clampMax=0.5,invert")]
		[InputControl(name = "leftStick/right", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=0.85")]
		[InputControl(name = "leftStick/y", offset = 1U, format = "BYTE", parameters = "invert,normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5")]
		[InputControl(name = "leftStick/up", offset = 1U, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.15,clampMax=0.5,invert")]
		[InputControl(name = "leftStick/down", offset = 1U, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=0.85,invert=false")]
		public byte leftStickX;

		// Token: 0x040006C5 RID: 1733
		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte leftStickY;

		// Token: 0x040006C6 RID: 1734
		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		[InputControl(name = "rightStick", layout = "Stick", format = "VC2B")]
		[InputControl(name = "rightStick/x", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5")]
		[InputControl(name = "rightStick/left", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
		[InputControl(name = "rightStick/right", offset = 0U, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
		[InputControl(name = "rightStick/y", offset = 1U, format = "BYTE", parameters = "invert,normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5")]
		[InputControl(name = "rightStick/up", offset = 1U, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.15,clampMax=0.5,invert")]
		[InputControl(name = "rightStick/down", offset = 1U, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=0.85,invert=false")]
		public byte rightStickX;

		// Token: 0x040006C7 RID: 1735
		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public byte rightStickY;

		// Token: 0x040006C8 RID: 1736
		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[InputControl(name = "buttonEast", displayName = "A", shortDisplayName = "A", bit = 7U, usage = "PrimaryAction")]
		[InputControl(name = "dpad", format = "BIT", bit = 0U, sizeInBits = 4U)]
		[InputControl(name = "buttonSouth", displayName = "B", shortDisplayName = "B", bit = 6U, usage = "Back")]
		[InputControl(name = "dpad/up", bit = 0U)]
		[InputControl(name = "dpad/left", bit = 3U)]
		[InputControl(name = "buttonWest", displayName = "Y", shortDisplayName = "Y", bit = 4U, usage = "SecondaryAction")]
		[InputControl(name = "buttonNorth", displayName = "X", shortDisplayName = "X", bit = 5U)]
		[InputControl(name = "select", displayName = "Minus", bit = 15U)]
		[InputControl(name = "start", displayName = "Plus", bit = 14U, usage = "Menu")]
		[InputControl(name = "rightTrigger", displayName = "ZR", shortDisplayName = "ZR", format = "BIT", bit = 13U)]
		[InputControl(name = "leftTrigger", displayName = "ZL", shortDisplayName = "ZL", format = "BIT", bit = 12U)]
		[InputControl(name = "rightStickPress", displayName = "Right Stick", bit = 11U)]
		[InputControl(name = "leftStickPress", displayName = "Left Stick", bit = 10U)]
		[InputControl(name = "rightShoulder", displayName = "R", shortDisplayName = "R", bit = 9U)]
		[InputControl(name = "leftShoulder", displayName = "L", shortDisplayName = "L", bit = 8U)]
		[InputControl(name = "dpad/down", bit = 2U)]
		[InputControl(name = "dpad/right", bit = 1U)]
		public ushort buttons1;

		// Token: 0x040006C9 RID: 1737
		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		[InputControl(name = "home", layout = "Button", displayName = "Home", bit = 1U)]
		[InputControl(name = "capture", layout = "Button", displayName = "Capture", bit = 0U)]
		public byte buttons2;

		// Token: 0x0200012A RID: 298
		[Token(Token = "0x200012A")]
		public enum Button
		{
			// Token: 0x040006CB RID: 1739
			[Token(Token = "0x40006CB")]
			Up,
			// Token: 0x040006CC RID: 1740
			[Token(Token = "0x40006CC")]
			Right,
			// Token: 0x040006CD RID: 1741
			[Token(Token = "0x40006CD")]
			Down,
			// Token: 0x040006CE RID: 1742
			[Token(Token = "0x40006CE")]
			Left,
			// Token: 0x040006CF RID: 1743
			[Token(Token = "0x40006CF")]
			West,
			// Token: 0x040006D0 RID: 1744
			[Token(Token = "0x40006D0")]
			North,
			// Token: 0x040006D1 RID: 1745
			[Token(Token = "0x40006D1")]
			South,
			// Token: 0x040006D2 RID: 1746
			[Token(Token = "0x40006D2")]
			East,
			// Token: 0x040006D3 RID: 1747
			[Token(Token = "0x40006D3")]
			L,
			// Token: 0x040006D4 RID: 1748
			[Token(Token = "0x40006D4")]
			R,
			// Token: 0x040006D5 RID: 1749
			[Token(Token = "0x40006D5")]
			StickL,
			// Token: 0x040006D6 RID: 1750
			[Token(Token = "0x40006D6")]
			StickR,
			// Token: 0x040006D7 RID: 1751
			[Token(Token = "0x40006D7")]
			ZL,
			// Token: 0x040006D8 RID: 1752
			[Token(Token = "0x40006D8")]
			ZR,
			// Token: 0x040006D9 RID: 1753
			[Token(Token = "0x40006D9")]
			Plus,
			// Token: 0x040006DA RID: 1754
			[Token(Token = "0x40006DA")]
			Minus,
			// Token: 0x040006DB RID: 1755
			[Token(Token = "0x40006DB")]
			Capture,
			// Token: 0x040006DC RID: 1756
			[Token(Token = "0x40006DC")]
			Home,
			// Token: 0x040006DD RID: 1757
			[Token(Token = "0x40006DD")]
			X = 5,
			// Token: 0x040006DE RID: 1758
			[Token(Token = "0x40006DE")]
			B,
			// Token: 0x040006DF RID: 1759
			[Token(Token = "0x40006DF")]
			Y = 4,
			// Token: 0x040006E0 RID: 1760
			[Token(Token = "0x40006E0")]
			A = 7
		}
	}
}
