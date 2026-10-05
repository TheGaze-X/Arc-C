using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x02000363 RID: 867
	[Token(Token = "0x2000363")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public interface IRemotingTypeInfo
	{
		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001C69 RID: 7273
		[Token(Token = "0x1700033B")]
		string TypeName { [Token(Token = "0x6001C69")] get; }

		// Token: 0x06001C6A RID: 7274
		[Token(Token = "0x6001C6A")]
		bool CanCastTo(System.Type fromType, object o);
	}
}
