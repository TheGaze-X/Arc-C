using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000FA RID: 250
	[Token(Token = "0x20000FA")]
	[AttributeUsage(AttributeTargets.Class)]
	[UsedByNativeCode]
	public class DefaultExecutionOrder : Attribute
	{
		// Token: 0x06000917 RID: 2327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000917")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public DefaultExecutionOrder(int order)
		{
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x00005B08 File Offset: 0x00003D08
		[Token(Token = "0x170001EF")]
		public int order
		{
			[Token(Token = "0x6000918")]
			[Address(RVA = "0x592C450", Offset = "0x592B050", VA = "0x18592C450")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040004A1 RID: 1185
		[Token(Token = "0x40004A1")]
		[FieldOffset(Offset = "0x10")]
		private int m_Order;
	}
}
