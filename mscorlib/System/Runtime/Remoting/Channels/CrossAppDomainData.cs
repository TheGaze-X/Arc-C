using System;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x0200039B RID: 923
	[Token(Token = "0x200039B")]
	[System.Serializable]
	internal class CrossAppDomainData
	{
		// Token: 0x06001DD6 RID: 7638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DD6")]
		[Address(RVA = "0x4B7B300", Offset = "0x4B79F00", VA = "0x184B7B300")]
		internal CrossAppDomainData(int domainId)
		{
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x00012CA8 File Offset: 0x00010EA8
		[Token(Token = "0x1700037A")]
		internal int DomainID
		{
			[Token(Token = "0x6001DD7")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700037B")]
		internal string ProcessID
		{
			[Token(Token = "0x6001DD8")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000FE0 RID: 4064
		[Token(Token = "0x4000FE0")]
		[FieldOffset(Offset = "0x10")]
		private object _ContextID;

		// Token: 0x04000FE1 RID: 4065
		[Token(Token = "0x4000FE1")]
		[FieldOffset(Offset = "0x18")]
		private int _DomainID;

		// Token: 0x04000FE2 RID: 4066
		[Token(Token = "0x4000FE2")]
		[FieldOffset(Offset = "0x20")]
		private string _processGuid;
	}
}
