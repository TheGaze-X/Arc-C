using System;
using System.Net.Sockets;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002A8 RID: 680
	[Token(Token = "0x20002A8")]
	[Serializable]
	public abstract class EndPoint
	{
		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x000094E0 File Offset: 0x000076E0
		[Token(Token = "0x17000402")]
		public virtual AddressFamily AddressFamily
		{
			[Token(Token = "0x6001330")]
			[Address(RVA = "0x519D2B0", Offset = "0x519BEB0", VA = "0x18519D2B0", Slot = "4")]
			get
			{
				return AddressFamily.Unspecified;
			}
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001331")]
		[Address(RVA = "0x519D280", Offset = "0x519BE80", VA = "0x18519D280", Slot = "5")]
		public virtual SocketAddress Serialize()
		{
			return null;
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001332")]
		[Address(RVA = "0x519D250", Offset = "0x519BE50", VA = "0x18519D250", Slot = "6")]
		public virtual EndPoint Create(SocketAddress socketAddress)
		{
			return null;
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001333")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected EndPoint()
		{
		}
	}
}
