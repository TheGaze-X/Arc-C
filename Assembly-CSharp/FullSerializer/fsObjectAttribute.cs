using System;
using Il2CppDummyDll;

namespace FullSerializer
{
	// Token: 0x02007B78 RID: 31608
	[Token(Token = "0x2007B78")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public sealed class fsObjectAttribute : Attribute
	{
		// Token: 0x0602C3D2 RID: 181202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3D2")]
		[Address(RVA = "0x28323A0", Offset = "0x2830FA0", VA = "0x1828323A0")]
		public fsObjectAttribute()
		{
		}

		// Token: 0x0602C3D3 RID: 181203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3D3")]
		[Address(RVA = "0x28323B0", Offset = "0x2830FB0", VA = "0x1828323B0")]
		public fsObjectAttribute(string versionString, params Type[] previousModels)
		{
		}

		// Token: 0x040401AE RID: 262574
		[Token(Token = "0x40401AE")]
		[FieldOffset(Offset = "0x10")]
		public Type[] PreviousModels;

		// Token: 0x040401AF RID: 262575
		[Token(Token = "0x40401AF")]
		[FieldOffset(Offset = "0x18")]
		public string VersionString;

		// Token: 0x040401B0 RID: 262576
		[Token(Token = "0x40401B0")]
		[FieldOffset(Offset = "0x20")]
		public fsMemberSerialization MemberSerialization;

		// Token: 0x040401B1 RID: 262577
		[Token(Token = "0x40401B1")]
		[FieldOffset(Offset = "0x28")]
		public Type Converter;

		// Token: 0x040401B2 RID: 262578
		[Token(Token = "0x40401B2")]
		[FieldOffset(Offset = "0x30")]
		public Type Processor;
	}
}
