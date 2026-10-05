using System;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x02000365 RID: 869
	[Token(Token = "0x2000365")]
	internal class ClientIdentity : Identity
	{
		// Token: 0x06001C79 RID: 7289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C79")]
		[Address(RVA = "0x4B57B80", Offset = "0x4B56780", VA = "0x184B57B80")]
		public ClientIdentity(string objectUri, ObjRef objRef)
		{
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001C7A RID: 7290 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001C7B RID: 7291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000343")]
		public System.MarshalByRefObject ClientProxy
		{
			[Token(Token = "0x6001C7A")]
			[Address(RVA = "0x4B57C80", Offset = "0x4B56880", VA = "0x184B57C80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C7B")]
			[Address(RVA = "0x4B57DB0", Offset = "0x4B569B0", VA = "0x184B57DB0")]
			set
			{
			}
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001C7C")]
		[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "4")]
		public override ObjRef CreateObjRef(System.Type requestedType)
		{
			return null;
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06001C7D RID: 7293 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000344")]
		public string TargetUri
		{
			[Token(Token = "0x6001C7D")]
			[Address(RVA = "0x4B57D60", Offset = "0x4B56960", VA = "0x184B57D60")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F4D RID: 3917
		[Token(Token = "0x4000F4D")]
		[FieldOffset(Offset = "0x48")]
		private System.WeakReference _proxyReference;
	}
}
