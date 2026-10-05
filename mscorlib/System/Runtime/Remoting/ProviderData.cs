using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x0200036B RID: 875
	[Token(Token = "0x200036B")]
	internal class ProviderData
	{
		// Token: 0x06001CC3 RID: 7363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CC3")]
		[Address(RVA = "0x4B84F80", Offset = "0x4B83B80", VA = "0x184B84F80")]
		public void CopyFrom(ProviderData other)
		{
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CC4")]
		[Address(RVA = "0x4B85660", Offset = "0x4B84260", VA = "0x184B85660")]
		public ProviderData()
		{
		}

		// Token: 0x04000F73 RID: 3955
		[Token(Token = "0x4000F73")]
		[FieldOffset(Offset = "0x10")]
		internal string Ref;

		// Token: 0x04000F74 RID: 3956
		[Token(Token = "0x4000F74")]
		[FieldOffset(Offset = "0x18")]
		internal string Type;

		// Token: 0x04000F75 RID: 3957
		[Token(Token = "0x4000F75")]
		[FieldOffset(Offset = "0x20")]
		internal string Id;

		// Token: 0x04000F76 RID: 3958
		[Token(Token = "0x4000F76")]
		[FieldOffset(Offset = "0x28")]
		internal System.Collections.Hashtable CustomProperties;

		// Token: 0x04000F77 RID: 3959
		[Token(Token = "0x4000F77")]
		[FieldOffset(Offset = "0x30")]
		internal System.Collections.IList CustomData;
	}
}
