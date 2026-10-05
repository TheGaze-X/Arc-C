using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000181 RID: 385
	[Token(Token = "0x2000181")]
	[System.Serializable]
	internal sealed class Empty : System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06000DFD RID: 3581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private Empty()
		{
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000DFE")]
		[Address(RVA = "0x4D16F90", Offset = "0x4D15B90", VA = "0x184D16F90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFF")]
		[Address(RVA = "0x4D16F00", Offset = "0x4D15B00", VA = "0x184D16F00", Slot = "4")]
		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x040005FE RID: 1534
		[Token(Token = "0x40005FE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Empty Value;
	}
}
