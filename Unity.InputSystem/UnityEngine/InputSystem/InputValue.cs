using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem
{
	// Token: 0x020000CE RID: 206
	[Token(Token = "0x20000CE")]
	[DebuggerDisplay("Value = {Get()}")]
	public class InputValue
	{
		// Token: 0x06000B0F RID: 2831 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x56A5340", Offset = "0x56A3F40", VA = "0x1856A5340")]
		public object Get()
		{
			return null;
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B10")]
		public TValue Get<TValue>() where TValue : struct
		{
			return null;
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x00005850 File Offset: 0x00003A50
		[Token(Token = "0x170002D6")]
		public bool isPressed
		{
			[Token(Token = "0x6000B11")]
			[Address(RVA = "0x56A53A0", Offset = "0x56A3FA0", VA = "0x1856A53A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public InputValue()
		{
		}

		// Token: 0x040004BC RID: 1212
		[Token(Token = "0x40004BC")]
		[FieldOffset(Offset = "0x10")]
		internal InputAction.CallbackContext? m_Context;
	}
}
