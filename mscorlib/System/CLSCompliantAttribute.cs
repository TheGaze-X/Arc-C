using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000BF RID: 191
	[Token(Token = "0x20000BF")]
	[System.AttributeUsage(System.AttributeTargets.All, Inherited = true, AllowMultiple = false)]
	[System.Serializable]
	public sealed class CLSCompliantAttribute : System.Attribute
	{
		// Token: 0x060004CF RID: 1231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x4EC7C0", Offset = "0x4EB3C0", VA = "0x1804EC7C0")]
		public CLSCompliantAttribute(bool isCompliant)
		{
		}

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x10")]
		private bool _compliant;
	}
}
