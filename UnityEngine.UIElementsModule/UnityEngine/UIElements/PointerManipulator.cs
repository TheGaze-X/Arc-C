using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	public abstract class PointerManipulator : MouseManipulator
	{
		// Token: 0x06000233 RID: 563 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x5A3ADB0", Offset = "0x5A399B0", VA = "0x185A3ADB0")]
		protected bool CanStartManipulation(IPointerEvent e)
		{
			return default(bool);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x5A3AF90", Offset = "0x5A39B90", VA = "0x185A3AF90")]
		protected bool CanStopManipulation(IPointerEvent e)
		{
			return default(bool);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x5A37C10", Offset = "0x5A36810", VA = "0x185A37C10")]
		protected PointerManipulator()
		{
		}

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x30")]
		private int m_CurrentPointerId;
	}
}
