using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001BE RID: 446
	[Token(Token = "0x20001BE")]
	[StructLayout(2)]
	public struct TextEvent : IInputEventTypeInfo
	{
		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x00008AC0 File Offset: 0x00006CC0
		[Token(Token = "0x170004B5")]
		public FourCC typeStatic
		{
			[Token(Token = "0x600109B")]
			[Address(RVA = "0x56FAEE0", Offset = "0x56F9AE0", VA = "0x1856FAEE0", Slot = "4")]
			get
			{
				return default(FourCC);
			}
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600109C")]
		[Address(RVA = "0x56FAD90", Offset = "0x56F9990", VA = "0x1856FAD90")]
		public unsafe static TextEvent* From(InputEventPtr eventPtr)
		{
			return null;
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x00008AD8 File Offset: 0x00006CD8
		[Token(Token = "0x600109D")]
		[Address(RVA = "0x56FACB0", Offset = "0x56F98B0", VA = "0x1856FACB0")]
		public static TextEvent Create(int deviceId, char character, double time = -1.0)
		{
			return default(TextEvent);
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x00008AF0 File Offset: 0x00006CF0
		[Token(Token = "0x600109E")]
		[Address(RVA = "0x56FAD20", Offset = "0x56F9920", VA = "0x1856FAD20")]
		public static TextEvent Create(int deviceId, int character, double time = -1.0)
		{
			return default(TextEvent);
		}

		// Token: 0x04000A04 RID: 2564
		[Token(Token = "0x4000A04")]
		public const int Type = 1413830740;

		// Token: 0x04000A05 RID: 2565
		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputEvent baseEvent;

		// Token: 0x04000A06 RID: 2566
		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int character;
	}
}
