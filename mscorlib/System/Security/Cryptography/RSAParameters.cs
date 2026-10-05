using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000317 RID: 791
	[Token(Token = "0x2000317")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public struct RSAParameters
	{
		// Token: 0x04000E19 RID: 3609
		[Token(Token = "0x4000E19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte[] Exponent;

		// Token: 0x04000E1A RID: 3610
		[Token(Token = "0x4000E1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] Modulus;

		// Token: 0x04000E1B RID: 3611
		[Token(Token = "0x4000E1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[System.NonSerialized]
		public byte[] P;

		// Token: 0x04000E1C RID: 3612
		[Token(Token = "0x4000E1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[System.NonSerialized]
		public byte[] Q;

		// Token: 0x04000E1D RID: 3613
		[Token(Token = "0x4000E1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[System.NonSerialized]
		public byte[] DP;

		// Token: 0x04000E1E RID: 3614
		[Token(Token = "0x4000E1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[System.NonSerialized]
		public byte[] DQ;

		// Token: 0x04000E1F RID: 3615
		[Token(Token = "0x4000E1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[System.NonSerialized]
		public byte[] InverseQ;

		// Token: 0x04000E20 RID: 3616
		[Token(Token = "0x4000E20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[System.NonSerialized]
		public byte[] D;
	}
}
