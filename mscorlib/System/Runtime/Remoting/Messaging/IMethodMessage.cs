using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003D4 RID: 980
	[Token(Token = "0x20003D4")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public interface IMethodMessage : IMessage
	{
		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001EBE RID: 7870
		[Token(Token = "0x170003CA")]
		int ArgCount { [Token(Token = "0x6001EBE")] get; }

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001EBF RID: 7871
		[Token(Token = "0x170003CB")]
		object[] Args { [Token(Token = "0x6001EBF")] get; }

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001EC0 RID: 7872
		[Token(Token = "0x170003CC")]
		LogicalCallContext LogicalCallContext { [Token(Token = "0x6001EC0")] get; }

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001EC1 RID: 7873
		[Token(Token = "0x170003CD")]
		System.Reflection.MethodBase MethodBase { [Token(Token = "0x6001EC1")] get; }

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001EC2 RID: 7874
		[Token(Token = "0x170003CE")]
		string MethodName { [Token(Token = "0x6001EC2")] get; }

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001EC3 RID: 7875
		[Token(Token = "0x170003CF")]
		object MethodSignature { [Token(Token = "0x6001EC3")] get; }

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001EC4 RID: 7876
		[Token(Token = "0x170003D0")]
		string TypeName { [Token(Token = "0x6001EC4")] get; }

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001EC5 RID: 7877
		[Token(Token = "0x170003D1")]
		string Uri { [Token(Token = "0x6001EC5")] get; }

		// Token: 0x06001EC6 RID: 7878
		[Token(Token = "0x6001EC6")]
		object GetArg(int argNum);
	}
}
