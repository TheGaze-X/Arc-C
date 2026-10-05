using System;
using System.Net.Sockets;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x0200028A RID: 650
	[Token(Token = "0x200028A")]
	[Serializable]
	public class IPEndPoint : EndPoint
	{
		// Token: 0x170003BA RID: 954
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x00008E50 File Offset: 0x00007050
		[Token(Token = "0x170003BA")]
		public override AddressFamily AddressFamily
		{
			[Token(Token = "0x600124C")]
			[Address(RVA = "0x51B1BF0", Offset = "0x51B07F0", VA = "0x1851B1BF0", Slot = "4")]
			get
			{
				return AddressFamily.Unspecified;
			}
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600124D")]
		[Address(RVA = "0x51B1AF0", Offset = "0x51B06F0", VA = "0x1851B1AF0")]
		public IPEndPoint(IPAddress address, int port)
		{
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BB")]
		public IPAddress Address
		{
			[Token(Token = "0x600124E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x0600124F RID: 4687 RVA: 0x00008E68 File Offset: 0x00007068
		[Token(Token = "0x170003BC")]
		public int Port
		{
			[Token(Token = "0x600124F")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001250")]
		[Address(RVA = "0x51B1830", Offset = "0x51B0430", VA = "0x1851B1830", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001251")]
		[Address(RVA = "0x51B17B0", Offset = "0x51B03B0", VA = "0x1851B17B0", Slot = "5")]
		public override SocketAddress Serialize()
		{
			return null;
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001252")]
		[Address(RVA = "0x51B13D0", Offset = "0x51AFFD0", VA = "0x1851B13D0", Slot = "6")]
		public override EndPoint Create(SocketAddress socketAddress)
		{
			return null;
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x00008E80 File Offset: 0x00007080
		[Token(Token = "0x6001253")]
		[Address(RVA = "0x51B1650", Offset = "0x51B0250", VA = "0x1851B1650", Slot = "0")]
		public override bool Equals(object comparand)
		{
			return default(bool);
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x00008E98 File Offset: 0x00007098
		[Token(Token = "0x6001254")]
		[Address(RVA = "0x51B1750", Offset = "0x51B0350", VA = "0x1851B1750", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400092C RID: 2348
		[Token(Token = "0x400092C")]
		public const int MinPort = 0;

		// Token: 0x0400092D RID: 2349
		[Token(Token = "0x400092D")]
		public const int MaxPort = 65535;

		// Token: 0x0400092E RID: 2350
		[Token(Token = "0x400092E")]
		[FieldOffset(Offset = "0x10")]
		private IPAddress _address;

		// Token: 0x0400092F RID: 2351
		[Token(Token = "0x400092F")]
		[FieldOffset(Offset = "0x18")]
		private int _port;

		// Token: 0x04000930 RID: 2352
		[Token(Token = "0x4000930")]
		internal const int AnyPort = 0;

		// Token: 0x04000931 RID: 2353
		[Token(Token = "0x4000931")]
		[FieldOffset(Offset = "0x0")]
		internal static IPEndPoint Any;

		// Token: 0x04000932 RID: 2354
		[Token(Token = "0x4000932")]
		[FieldOffset(Offset = "0x8")]
		internal static IPEndPoint IPv6Any;
	}
}
