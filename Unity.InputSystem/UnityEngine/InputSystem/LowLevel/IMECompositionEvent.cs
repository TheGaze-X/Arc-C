using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001A9 RID: 425
	[Token(Token = "0x20001A9")]
	[StructLayout(2)]
	public struct IMECompositionEvent : IInputEventTypeInfo
	{
		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x00008340 File Offset: 0x00006540
		[Token(Token = "0x17000475")]
		public FourCC typeStatic
		{
			[Token(Token = "0x6000FCE")]
			[Address(RVA = "0x56D9800", Offset = "0x56D8400", VA = "0x1856D9800", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00008358 File Offset: 0x00006558
		[Token(Token = "0x6000FCF")]
		[Address(RVA = "0x56D9590", Offset = "0x56D8190", VA = "0x1856D9590")]
		public static IMECompositionEvent Create(int deviceId, string compositionString, double time)
		{
			return default(IMECompositionEvent);
		}

		// Token: 0x040009A8 RID: 2472
		[Token(Token = "0x40009A8")]
		internal const int kIMECharBufferSize = 64;

		// Token: 0x040009A9 RID: 2473
		[Token(Token = "0x40009A9")]
		public const int Type = 1229800787;

		// Token: 0x040009AA RID: 2474
		[Token(Token = "0x40009AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputEvent baseEvent;

		// Token: 0x040009AB RID: 2475
		[Token(Token = "0x40009AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public IMECompositionString compositionString;
	}
}
