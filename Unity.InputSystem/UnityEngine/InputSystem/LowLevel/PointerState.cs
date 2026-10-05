using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x02000196 RID: 406
	[Token(Token = "0x2000196")]
	internal struct PointerState : IInputStateTypeInfo
	{
		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x00007EA8 File Offset: 0x000060A8
		[Token(Token = "0x17000448")]
		public static FourCC kFormat
		{
			[Token(Token = "0x6000F86")]
			[Address(RVA = "0x56DF070", Offset = "0x56DDC70", VA = "0x1856DF070")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000F87 RID: 3975 RVA: 0x00007EC0 File Offset: 0x000060C0
		[Token(Token = "0x17000449")]
		public FourCC format
		{
			[Token(Token = "0x6000F87")]
			[Address(RVA = "0x56DF030", Offset = "0x56DDC30", VA = "0x1856DF030", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x0400096C RID: 2412
		[Token(Token = "0x400096C")]
		[FieldOffset(Offset = "0x0")]
		private uint pointerId;

		// Token: 0x0400096D RID: 2413
		[Token(Token = "0x400096D")]
		[FieldOffset(Offset = "0x4")]
		[InputControl(layout = "Vector2", displayName = "Position", usage = "Point", dontReset = true)]
		public Vector2 position;

		// Token: 0x0400096E RID: 2414
		[Token(Token = "0x400096E")]
		[FieldOffset(Offset = "0xC")]
		[InputControl(layout = "Delta", displayName = "Delta", usage = "Secondary2DMotion")]
		public Vector2 delta;

		// Token: 0x0400096F RID: 2415
		[Token(Token = "0x400096F")]
		[FieldOffset(Offset = "0x14")]
		[InputControl(layout = "Analog", displayName = "Pressure", usage = "Pressure", defaultState = 1f)]
		public float pressure;

		// Token: 0x04000970 RID: 2416
		[Token(Token = "0x4000970")]
		[FieldOffset(Offset = "0x18")]
		[InputControl(layout = "Vector2", displayName = "Radius", usage = "Radius")]
		public Vector2 radius;

		// Token: 0x04000971 RID: 2417
		[Token(Token = "0x4000971")]
		[FieldOffset(Offset = "0x20")]
		[InputControl(name = "press", displayName = "Press", layout = "Button", format = "BIT", bit = 0U)]
		public ushort buttons;

		// Token: 0x04000972 RID: 2418
		[Token(Token = "0x4000972")]
		[FieldOffset(Offset = "0x22")]
		[InputControl(name = "displayIndex", layout = "Integer", displayName = "Display Index")]
		public ushort displayIndex;
	}
}
