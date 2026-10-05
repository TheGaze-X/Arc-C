using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using Il2CppDummyDll;
using Mono;

namespace System.Runtime.Remoting.Proxies
{
	// Token: 0x0200037F RID: 895
	[Token(Token = "0x200037F")]
	[StructLayout(0)]
	internal class TransparentProxy
	{
		// Token: 0x06001D3F RID: 7487 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D3F")]
		[Address(RVA = "0x4B91890", Offset = "0x4B90490", VA = "0x184B91890")]
		internal RuntimeType GetProxyType()
		{
			return null;
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x00012A68 File Offset: 0x00010C68
		[Token(Token = "0x1700035F")]
		private bool IsContextBoundObject
		{
			[Token(Token = "0x6001D40")]
			[Address(RVA = "0x4B921F0", Offset = "0x4B90DF0", VA = "0x184B921F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06001D41 RID: 7489 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000360")]
		private System.Runtime.Remoting.Contexts.Context TargetContext
		{
			[Token(Token = "0x6001D41")]
			[Address(RVA = "0x5B5460", Offset = "0x5B4060", VA = "0x1805B5460")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x00012A80 File Offset: 0x00010C80
		[Token(Token = "0x6001D42")]
		[Address(RVA = "0x4B91990", Offset = "0x4B90590", VA = "0x184B91990")]
		private bool InCurrentContext()
		{
			return default(bool);
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D43")]
		[Address(RVA = "0x4B91AC0", Offset = "0x4B906C0", VA = "0x184B91AC0")]
		internal object LoadRemoteFieldNew(System.IntPtr classPtr, System.IntPtr fieldPtr)
		{
			return null;
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D44")]
		[Address(RVA = "0x4B91E60", Offset = "0x4B90A60", VA = "0x184B91E60")]
		internal void StoreRemoteField(System.IntPtr classPtr, System.IntPtr fieldPtr, object arg)
		{
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D45")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TransparentProxy()
		{
		}

		// Token: 0x04000FA0 RID: 4000
		[Token(Token = "0x4000FA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RealProxy _rp;

		// Token: 0x04000FA1 RID: 4001
		[Token(Token = "0x4000FA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RuntimeRemoteClassHandle _class;

		// Token: 0x04000FA2 RID: 4002
		[Token(Token = "0x4000FA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _custom_type_info;
	}
}
