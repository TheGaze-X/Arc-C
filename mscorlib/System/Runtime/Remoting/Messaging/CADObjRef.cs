using System;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003C1 RID: 961
	[Token(Token = "0x20003C1")]
	internal class CADObjRef
	{
		// Token: 0x06001E6A RID: 7786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E6A")]
		[Address(RVA = "0x4B721F0", Offset = "0x4B70DF0", VA = "0x184B721F0")]
		public CADObjRef(ObjRef o, int sourceDomain)
		{
		}

		// Token: 0x0400102A RID: 4138
		[Token(Token = "0x400102A")]
		[FieldOffset(Offset = "0x10")]
		internal ObjRef objref;

		// Token: 0x0400102B RID: 4139
		[Token(Token = "0x400102B")]
		[FieldOffset(Offset = "0x18")]
		internal int SourceDomain;

		// Token: 0x0400102C RID: 4140
		[Token(Token = "0x400102C")]
		[FieldOffset(Offset = "0x20")]
		internal byte[] TypeInfo;
	}
}
