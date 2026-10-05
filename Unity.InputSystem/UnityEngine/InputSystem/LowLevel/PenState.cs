using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x02000195 RID: 405
	[Token(Token = "0x2000195")]
	[StructLayout(2)]
	public struct PenState : IInputStateTypeInfo
	{
		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x00007E60 File Offset: 0x00006060
		[Token(Token = "0x17000446")]
		public static FourCC Format
		{
			[Token(Token = "0x6000F83")]
			[Address(RVA = "0x56DEFB0", Offset = "0x56DDBB0", VA = "0x1856DEFB0")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00007E78 File Offset: 0x00006078
		[Token(Token = "0x6000F84")]
		[Address(RVA = "0x56DEF60", Offset = "0x56DDB60", VA = "0x1856DEF60")]
		public PenState WithButton(PenButton button, bool state = true)
		{
			return default(PenState);
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x00007E90 File Offset: 0x00006090
		[Token(Token = "0x17000447")]
		public FourCC format
		{
			[Token(Token = "0x6000F85")]
			[Address(RVA = "0x56DEFF0", Offset = "0x56DDBF0", VA = "0x1856DEFF0", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x04000965 RID: 2405
		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[InputControl(usage = "Point", dontReset = true)]
		public Vector2 position;

		// Token: 0x04000966 RID: 2406
		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[InputControl(usage = "Secondary2DMotion", layout = "Delta")]
		public Vector2 delta;

		// Token: 0x04000967 RID: 2407
		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[InputControl(layout = "Vector2", displayName = "Tilt", usage = "Tilt")]
		public Vector2 tilt;

		// Token: 0x04000968 RID: 2408
		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[InputControl(layout = "Analog", usage = "Pressure", defaultState = 0f)]
		public float pressure;

		// Token: 0x04000969 RID: 2409
		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[InputControl(layout = "Axis", displayName = "Twist", usage = "Twist")]
		public float twist;

		// Token: 0x0400096A RID: 2410
		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[InputControl(name = "tip", displayName = "Tip", layout = "Button", bit = 0U, usage = "PrimaryAction")]
		[InputControl(name = "press", useStateFrom = "tip", synthetic = true, usages = new string[]
		{

		})]
		[InputControl(name = "eraser", displayName = "Eraser", layout = "Button", bit = 1U)]
		[InputControl(name = "inRange", displayName = "In Range?", layout = "Button", bit = 4U, synthetic = true)]
		[InputControl(name = "barrel1", displayName = "Barrel Button #1", layout = "Button", bit = 2U, alias = "barrelFirst", usage = "SecondaryAction")]
		[InputControl(name = "barrel2", displayName = "Barrel Button #2", layout = "Button", bit = 3U, alias = "barrelSecond")]
		[InputControl(name = "barrel3", displayName = "Barrel Button #3", layout = "Button", bit = 5U, alias = "barrelThird")]
		[InputControl(name = "barrel4", displayName = "Barrel Button #4", layout = "Button", bit = 6U, alias = "barrelFourth")]
		[InputControl(name = "radius", layout = "Vector2", format = "VEC2", sizeInBits = 64U, usage = "Radius", offset = 4294967294U)]
		[InputControl(name = "pointerId", layout = "Digital", format = "UINT", sizeInBits = 32U, offset = 4294967294U)]
		public ushort buttons;

		// Token: 0x0400096B RID: 2411
		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		private ushort displayIndex;
	}
}
