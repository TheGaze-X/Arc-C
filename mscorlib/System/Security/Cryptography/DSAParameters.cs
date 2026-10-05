using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002FB RID: 763
	[Token(Token = "0x20002FB")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public struct DSAParameters
	{
		// Token: 0x04000DC9 RID: 3529
		[Token(Token = "0x4000DC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte[] P;

		// Token: 0x04000DCA RID: 3530
		[Token(Token = "0x4000DCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] Q;

		// Token: 0x04000DCB RID: 3531
		[Token(Token = "0x4000DCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] G;

		// Token: 0x04000DCC RID: 3532
		[Token(Token = "0x4000DCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte[] Y;

		// Token: 0x04000DCD RID: 3533
		[Token(Token = "0x4000DCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public byte[] J;

		// Token: 0x04000DCE RID: 3534
		[Token(Token = "0x4000DCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[System.NonSerialized]
		public byte[] X;

		// Token: 0x04000DCF RID: 3535
		[Token(Token = "0x4000DCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public byte[] Seed;

		// Token: 0x04000DD0 RID: 3536
		[Token(Token = "0x4000DD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int Counter;
	}
}
