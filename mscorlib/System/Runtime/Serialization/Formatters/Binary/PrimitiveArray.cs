using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000451 RID: 1105
	[Token(Token = "0x2000451")]
	internal sealed class PrimitiveArray
	{
		// Token: 0x060021F2 RID: 8690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F2")]
		[Address(RVA = "0x4BC25F0", Offset = "0x4BC11F0", VA = "0x184BC25F0")]
		internal PrimitiveArray(InternalPrimitiveTypeE code, System.Array array)
		{
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F3")]
		[Address(RVA = "0x4BC1C10", Offset = "0x4BC0810", VA = "0x184BC1C10")]
		internal void Init(InternalPrimitiveTypeE code, System.Array array)
		{
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F4")]
		[Address(RVA = "0x4BC21D0", Offset = "0x4BC0DD0", VA = "0x184BC21D0")]
		internal void SetValue(string value, int index)
		{
		}

		// Token: 0x040012F6 RID: 4854
		[Token(Token = "0x40012F6")]
		[FieldOffset(Offset = "0x10")]
		private InternalPrimitiveTypeE code;

		// Token: 0x040012F7 RID: 4855
		[Token(Token = "0x40012F7")]
		[FieldOffset(Offset = "0x18")]
		private bool[] booleanA;

		// Token: 0x040012F8 RID: 4856
		[Token(Token = "0x40012F8")]
		[FieldOffset(Offset = "0x20")]
		private char[] charA;

		// Token: 0x040012F9 RID: 4857
		[Token(Token = "0x40012F9")]
		[FieldOffset(Offset = "0x28")]
		private double[] doubleA;

		// Token: 0x040012FA RID: 4858
		[Token(Token = "0x40012FA")]
		[FieldOffset(Offset = "0x30")]
		private short[] int16A;

		// Token: 0x040012FB RID: 4859
		[Token(Token = "0x40012FB")]
		[FieldOffset(Offset = "0x38")]
		private int[] int32A;

		// Token: 0x040012FC RID: 4860
		[Token(Token = "0x40012FC")]
		[FieldOffset(Offset = "0x40")]
		private long[] int64A;

		// Token: 0x040012FD RID: 4861
		[Token(Token = "0x40012FD")]
		[FieldOffset(Offset = "0x48")]
		private sbyte[] sbyteA;

		// Token: 0x040012FE RID: 4862
		[Token(Token = "0x40012FE")]
		[FieldOffset(Offset = "0x50")]
		private float[] singleA;

		// Token: 0x040012FF RID: 4863
		[Token(Token = "0x40012FF")]
		[FieldOffset(Offset = "0x58")]
		private ushort[] uint16A;

		// Token: 0x04001300 RID: 4864
		[Token(Token = "0x4001300")]
		[FieldOffset(Offset = "0x60")]
		private uint[] uint32A;

		// Token: 0x04001301 RID: 4865
		[Token(Token = "0x4001301")]
		[FieldOffset(Offset = "0x68")]
		private ulong[] uint64A;
	}
}
