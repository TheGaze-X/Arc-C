using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x0200035D RID: 861
	[Token(Token = "0x200035D")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class ActivatedClientTypeEntry : TypeEntry
	{
		// Token: 0x06001C5D RID: 7261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C5D")]
		[Address(RVA = "0x4B52AF0", Offset = "0x4B516F0", VA = "0x184B52AF0")]
		public ActivatedClientTypeEntry(string typeName, string assemblyName, string appUrl)
		{
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000334")]
		public string ApplicationUrl
		{
			[Token(Token = "0x6001C5E")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000335")]
		public System.Runtime.Remoting.Contexts.IContextAttribute[] ContextAttributes
		{
			[Token(Token = "0x6001C5F")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000336")]
		public System.Type ObjectType
		{
			[Token(Token = "0x6001C60")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001C61")]
		[Address(RVA = "0x4B52AD0", Offset = "0x4B516D0", VA = "0x184B52AD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000F3E RID: 3902
		[Token(Token = "0x4000F3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string applicationUrl;

		// Token: 0x04000F3F RID: 3903
		[Token(Token = "0x4000F3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private System.Type obj_type;
	}
}
