using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x0200030C RID: 780
	[Token(Token = "0x200030C")]
	public static class Dns
	{
		// Token: 0x0600155F RID: 5471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600155F")]
		[Address(RVA = "0x506D090", Offset = "0x506BC90", VA = "0x18506D090")]
		public static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state)
		{
			return null;
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001560")]
		[Address(RVA = "0x506D300", Offset = "0x506BF00", VA = "0x18506D300")]
		public static IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult)
		{
			return null;
		}

		// Token: 0x06001561 RID: 5473
		[Token(Token = "0x6001561")]
		[Address(RVA = "0x506D9E0", Offset = "0x506C5E0", VA = "0x18506D9E0")]
		[MethodImpl(4096)]
		private static extern bool GetHostByName_icall(string host, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint);

		// Token: 0x06001562 RID: 5474
		[Token(Token = "0x6001562")]
		[Address(RVA = "0x506D8A0", Offset = "0x506C4A0", VA = "0x18506D8A0")]
		[MethodImpl(4096)]
		private static extern bool GetHostByAddr_icall(string addr, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint);

		// Token: 0x06001563 RID: 5475
		[Token(Token = "0x6001563")]
		[Address(RVA = "0x506DF70", Offset = "0x506CB70", VA = "0x18506DF70")]
		[MethodImpl(4096)]
		private static extern bool GetHostName_icall(out string h_name);

		// Token: 0x06001564 RID: 5476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001564")]
		[Address(RVA = "0x506D4E0", Offset = "0x506C0E0", VA = "0x18506D4E0")]
		private static void Error_11001(string hostName)
		{
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001565")]
		[Address(RVA = "0x506DFC0", Offset = "0x506CBC0", VA = "0x18506DFC0")]
		private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist)
		{
			return null;
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001566")]
		[Address(RVA = "0x506D8B0", Offset = "0x506C4B0", VA = "0x18506D8B0")]
		private static IPHostEntry GetHostByAddressFromString(string address, bool parse)
		{
			return null;
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001567")]
		[Address(RVA = "0x506DAF0", Offset = "0x506C6F0", VA = "0x18506DAF0")]
		public static IPHostEntry GetHostEntry(string hostNameOrAddress)
		{
			return null;
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001568")]
		[Address(RVA = "0x506DDF0", Offset = "0x506C9F0", VA = "0x18506DDF0")]
		public static IPHostEntry GetHostEntry(IPAddress address)
		{
			return null;
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001569")]
		[Address(RVA = "0x506D680", Offset = "0x506C280", VA = "0x18506D680")]
		public static IPAddress[] GetHostAddresses(string hostNameOrAddress)
		{
			return null;
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156A")]
		[Address(RVA = "0x506D9F0", Offset = "0x506C5F0", VA = "0x18506D9F0")]
		[Obsolete("Use GetHostEntry instead")]
		public static IPHostEntry GetHostByName(string hostName)
		{
			return null;
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156B")]
		[Address(RVA = "0x506DF80", Offset = "0x506CB80", VA = "0x18506DF80")]
		public static string GetHostName()
		{
			return null;
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600156C")]
		[Address(RVA = "0x506D560", Offset = "0x506C160", VA = "0x18506D560")]
		public static Task<IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress)
		{
			return null;
		}

		// Token: 0x0200030D RID: 781
		// (Invoke) Token: 0x0600156E RID: 5486
		[Token(Token = "0x200030D")]
		private delegate IPAddress[] GetHostAddressesCallback(string hostName);
	}
}
