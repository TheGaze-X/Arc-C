using System;
using Il2CppDummyDll;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200047B RID: 1147
	[Token(Token = "0x200047B")]
	[System.AttributeUsage(System.AttributeTargets.Field | System.AttributeTargets.Parameter | System.AttributeTargets.ReturnValue, Inherited = false)]
	[ComVisible(true)]
	[StructLayout(0)]
	public sealed class MarshalAsAttribute : System.Attribute
	{
		// Token: 0x060022A7 RID: 8871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022A7")]
		[Address(RVA = "0x4BD80A0", Offset = "0x4BD6CA0", VA = "0x184BD80A0")]
		public MarshalAsAttribute(UnmanagedType unmanagedType)
		{
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x060022A8 RID: 8872 RVA: 0x00013F08 File Offset: 0x00012108
		[Token(Token = "0x17000470")]
		public UnmanagedType Value
		{
			[Token(Token = "0x60022A8")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			get
			{
				return (UnmanagedType)0;
			}
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60022A9")]
		[Address(RVA = "0x4BD8040", Offset = "0x4BD6C40", VA = "0x184BD8040")]
		internal MarshalAsAttribute Copy()
		{
			return null;
		}

		// Token: 0x040013BA RID: 5050
		[Token(Token = "0x40013BA")]
		[FieldOffset(Offset = "0x10")]
		public string MarshalCookie;

		// Token: 0x040013BB RID: 5051
		[Token(Token = "0x40013BB")]
		[FieldOffset(Offset = "0x18")]
		[ComVisible(true)]
		public string MarshalType;

		// Token: 0x040013BC RID: 5052
		[Token(Token = "0x40013BC")]
		[FieldOffset(Offset = "0x20")]
		[ComVisible(true)]
		public System.Type MarshalTypeRef;

		// Token: 0x040013BD RID: 5053
		[Token(Token = "0x40013BD")]
		[FieldOffset(Offset = "0x28")]
		public System.Type SafeArrayUserDefinedSubType;

		// Token: 0x040013BE RID: 5054
		[Token(Token = "0x40013BE")]
		[FieldOffset(Offset = "0x30")]
		private UnmanagedType utype;

		// Token: 0x040013BF RID: 5055
		[Token(Token = "0x40013BF")]
		[FieldOffset(Offset = "0x34")]
		public UnmanagedType ArraySubType;

		// Token: 0x040013C0 RID: 5056
		[Token(Token = "0x40013C0")]
		[FieldOffset(Offset = "0x38")]
		public VarEnum SafeArraySubType;

		// Token: 0x040013C1 RID: 5057
		[Token(Token = "0x40013C1")]
		[FieldOffset(Offset = "0x3C")]
		public int SizeConst;

		// Token: 0x040013C2 RID: 5058
		[Token(Token = "0x40013C2")]
		[FieldOffset(Offset = "0x40")]
		public int IidParameterIndex;

		// Token: 0x040013C3 RID: 5059
		[Token(Token = "0x40013C3")]
		[FieldOffset(Offset = "0x44")]
		public short SizeParamIndex;
	}
}
