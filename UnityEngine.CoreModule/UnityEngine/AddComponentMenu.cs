using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x020000F3 RID: 243
	[Token(Token = "0x20000F3")]
	public sealed class AddComponentMenu : Attribute
	{
		// Token: 0x0600090A RID: 2314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090A")]
		[Address(RVA = "0x59471C0", Offset = "0x5945DC0", VA = "0x1859471C0")]
		public AddComponentMenu(string menuName)
		{
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090B")]
		[Address(RVA = "0x37442C0", Offset = "0x3742EC0", VA = "0x1837442C0")]
		public AddComponentMenu(string menuName, int order)
		{
		}

		// Token: 0x04000496 RID: 1174
		[Token(Token = "0x4000496")]
		[FieldOffset(Offset = "0x10")]
		private string m_AddComponentMenu;

		// Token: 0x04000497 RID: 1175
		[Token(Token = "0x4000497")]
		[FieldOffset(Offset = "0x18")]
		private int m_Ordering;
	}
}
