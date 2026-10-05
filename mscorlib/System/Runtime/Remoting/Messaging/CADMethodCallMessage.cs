using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003C4 RID: 964
	[Token(Token = "0x20003C4")]
	internal class CADMethodCallMessage : CADMessageBase
	{
		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001E7A RID: 7802 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003B2")]
		internal string Uri
		{
			[Token(Token = "0x6001E7A")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E7B")]
		[Address(RVA = "0x4B70C00", Offset = "0x4B6F800", VA = "0x184B70C00")]
		internal static CADMethodCallMessage Create(IMessage callMsg)
		{
			return null;
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E7C")]
		[Address(RVA = "0x4B70DF0", Offset = "0x4B6F9F0", VA = "0x184B70DF0")]
		internal CADMethodCallMessage(IMethodCallMessage callMsg)
		{
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E7D")]
		[Address(RVA = "0x4B70CA0", Offset = "0x4B6F8A0", VA = "0x184B70CA0")]
		internal System.Collections.ArrayList GetArguments()
		{
			return null;
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E7E")]
		[Address(RVA = "0x4B70C90", Offset = "0x4B6F890", VA = "0x184B70C90")]
		internal object[] GetArgs(System.Collections.ArrayList args)
		{
			return null;
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001E7F RID: 7807 RVA: 0x00012ED0 File Offset: 0x000110D0
		[Token(Token = "0x170003B3")]
		internal int PropertiesCount
		{
			[Token(Token = "0x6001E7F")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04001037 RID: 4151
		[Token(Token = "0x4001037")]
		[FieldOffset(Offset = "0x38")]
		private string _uri;
	}
}
