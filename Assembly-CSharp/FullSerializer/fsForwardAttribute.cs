using System;
using Il2CppDummyDll;

namespace FullSerializer
{
	// Token: 0x02007B62 RID: 31586
	[Token(Token = "0x2007B62")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
	public sealed class fsForwardAttribute : Attribute
	{
		// Token: 0x0602C35B RID: 181083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C35B")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public fsForwardAttribute(string memberName)
		{
		}

		// Token: 0x0404017A RID: 262522
		[Token(Token = "0x404017A")]
		[FieldOffset(Offset = "0x10")]
		public string MemberName;
	}
}
