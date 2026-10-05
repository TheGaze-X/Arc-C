using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000287 RID: 647
	[Token(Token = "0x2000287")]
	[Serializable]
	public class IPAddress
	{
		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x0600121F RID: 4639 RVA: 0x00008C88 File Offset: 0x00006E88
		[Token(Token = "0x170003B4")]
		private bool IsIPv4
		{
			[Token(Token = "0x600121F")]
			[Address(RVA = "0x1F00EC0", Offset = "0x1EFFAC0", VA = "0x181F00EC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001220 RID: 4640 RVA: 0x00008CA0 File Offset: 0x00006EA0
		[Token(Token = "0x170003B5")]
		private bool IsIPv6
		{
			[Token(Token = "0x6001220")]
			[Address(RVA = "0x142F770", Offset = "0x142E370", VA = "0x18142F770")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x00008CB8 File Offset: 0x00006EB8
		// (set) Token: 0x06001222 RID: 4642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B6")]
		private uint PrivateAddress
		{
			[Token(Token = "0x6001221")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001222")]
			[Address(RVA = "0x51B1390", Offset = "0x51AFF90", VA = "0x1851B1390")]
			set
			{
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x00008CD0 File Offset: 0x00006ED0
		// (set) Token: 0x06001224 RID: 4644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B7")]
		private uint PrivateScopeId
		{
			[Token(Token = "0x6001223")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001224")]
			[Address(RVA = "0x51B1390", Offset = "0x51AFF90", VA = "0x1851B1390")]
			set
			{
			}
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001225")]
		[Address(RVA = "0x51B0EA0", Offset = "0x51AFAA0", VA = "0x1851B0EA0")]
		public IPAddress(long newAddress)
		{
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001226")]
		[Address(RVA = "0x51B0D30", Offset = "0x51AF930", VA = "0x1851B0D30")]
		public IPAddress(byte[] address, long scopeid)
		{
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001227")]
		[Address(RVA = "0x51B1100", Offset = "0x51AFD00", VA = "0x1851B1100")]
		public IPAddress(ReadOnlySpan<byte> address, long scopeid)
		{
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001228")]
		[Address(RVA = "0x51B0DD0", Offset = "0x51AF9D0", VA = "0x1851B0DD0")]
		internal unsafe IPAddress(ushort* numbers, int numbersLength, uint scopeid)
		{
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001229")]
		[Address(RVA = "0x51B0CD0", Offset = "0x51AF8D0", VA = "0x1851B0CD0")]
		private IPAddress(ushort[] numbers, uint scopeid)
		{
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600122A")]
		[Address(RVA = "0x51B0C40", Offset = "0x51AF840", VA = "0x1851B0C40")]
		public IPAddress(byte[] address)
		{
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600122B")]
		[Address(RVA = "0x51B0F40", Offset = "0x51AFB40", VA = "0x1851B0F40")]
		public IPAddress(ReadOnlySpan<byte> address)
		{
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x00008CE8 File Offset: 0x00006EE8
		[Token(Token = "0x600122C")]
		[Address(RVA = "0x51B0580", Offset = "0x51AF180", VA = "0x1851B0580")]
		public static bool TryParse(string ipString, out IPAddress address)
		{
			return default(bool);
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600122D")]
		[Address(RVA = "0x51B0400", Offset = "0x51AF000", VA = "0x1851B0400")]
		public static IPAddress Parse(string ipString)
		{
			return null;
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x00008D00 File Offset: 0x00006F00
		[Token(Token = "0x600122E")]
		[Address(RVA = "0x51B0630", Offset = "0x51AF230", VA = "0x1851B0630")]
		public bool TryWriteBytes(Span<byte> destination, out int bytesWritten)
		{
			return default(bool);
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600122F")]
		[Address(RVA = "0x5199460", Offset = "0x5198060", VA = "0x185199460")]
		[MethodImpl(256)]
		private void WriteIPv6Bytes(Span<byte> destination)
		{
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001230")]
		[Address(RVA = "0x51B0740", Offset = "0x51AF340", VA = "0x1851B0740")]
		[MethodImpl(256)]
		private void WriteIPv4Bytes(Span<byte> destination)
		{
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001231")]
		[Address(RVA = "0x51AFA90", Offset = "0x51AE690", VA = "0x1851AFA90")]
		public byte[] GetAddressBytes()
		{
			return null;
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x00008D18 File Offset: 0x00006F18
		[Token(Token = "0x170003B8")]
		public AddressFamily AddressFamily
		{
			[Token(Token = "0x6001232")]
			[Address(RVA = "0x51B1300", Offset = "0x51AFF00", VA = "0x1851B1300")]
			get
			{
				return AddressFamily.Unspecified;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x00008D30 File Offset: 0x00006F30
		[Token(Token = "0x170003B9")]
		public long ScopeId
		{
			[Token(Token = "0x6001233")]
			[Address(RVA = "0x51B1320", Offset = "0x51AFF20", VA = "0x1851B1320")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001234")]
		[Address(RVA = "0x51B0520", Offset = "0x51AF120", VA = "0x1851B0520", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x00008D48 File Offset: 0x00006F48
		[Token(Token = "0x6001235")]
		[Address(RVA = "0x51B00A0", Offset = "0x51AECA0", VA = "0x1851B00A0")]
		public static int HostToNetworkOrder(int host)
		{
			return 0;
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00008D60 File Offset: 0x00006F60
		[Token(Token = "0x6001236")]
		[Address(RVA = "0x51B0340", Offset = "0x51AEF40", VA = "0x1851B0340")]
		public static int NetworkToHostOrder(int network)
		{
			return 0;
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00008D78 File Offset: 0x00006F78
		[Token(Token = "0x6001237")]
		[Address(RVA = "0x51B0130", Offset = "0x51AED30", VA = "0x1851B0130")]
		public static bool IsLoopback(IPAddress address)
		{
			return default(bool);
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x00008D90 File Offset: 0x00006F90
		[Token(Token = "0x6001238")]
		[Address(RVA = "0x51AF930", Offset = "0x51AE530", VA = "0x1851AF930")]
		internal bool Equals(object comparandObj, bool compareScopeId)
		{
			return default(bool);
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x00008DA8 File Offset: 0x00006FA8
		[Token(Token = "0x6001239")]
		[Address(RVA = "0x51AF920", Offset = "0x51AE520", VA = "0x1851AF920", Slot = "0")]
		public override bool Equals(object comparand)
		{
			return default(bool);
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x00008DC0 File Offset: 0x00006FC0
		[Token(Token = "0x600123A")]
		[Address(RVA = "0x51AFC10", Offset = "0x51AE810", VA = "0x1851AFC10", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600123B")]
		[Address(RVA = "0x51B0220", Offset = "0x51AEE20", VA = "0x1851B0220")]
		public IPAddress MapToIPv6()
		{
			return null;
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600123C")]
		[Address(RVA = "0x51B04C0", Offset = "0x51AF0C0", VA = "0x1851B04C0")]
		private static byte[] ThrowAddressNullException()
		{
			return null;
		}

		// Token: 0x0400091F RID: 2335
		[Token(Token = "0x400091F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly IPAddress Any;

		// Token: 0x04000920 RID: 2336
		[Token(Token = "0x4000920")]
		[FieldOffset(Offset = "0x8")]
		public static readonly IPAddress Loopback;

		// Token: 0x04000921 RID: 2337
		[Token(Token = "0x4000921")]
		[FieldOffset(Offset = "0x10")]
		public static readonly IPAddress Broadcast;

		// Token: 0x04000922 RID: 2338
		[Token(Token = "0x4000922")]
		[FieldOffset(Offset = "0x18")]
		public static readonly IPAddress None;

		// Token: 0x04000923 RID: 2339
		[Token(Token = "0x4000923")]
		internal const long LoopbackMask = 255L;

		// Token: 0x04000924 RID: 2340
		[Token(Token = "0x4000924")]
		[FieldOffset(Offset = "0x20")]
		public static readonly IPAddress IPv6Any;

		// Token: 0x04000925 RID: 2341
		[Token(Token = "0x4000925")]
		[FieldOffset(Offset = "0x28")]
		public static readonly IPAddress IPv6Loopback;

		// Token: 0x04000926 RID: 2342
		[Token(Token = "0x4000926")]
		[FieldOffset(Offset = "0x30")]
		public static readonly IPAddress IPv6None;

		// Token: 0x04000927 RID: 2343
		[Token(Token = "0x4000927")]
		[FieldOffset(Offset = "0x10")]
		private uint _addressOrScopeId;

		// Token: 0x04000928 RID: 2344
		[Token(Token = "0x4000928")]
		[FieldOffset(Offset = "0x18")]
		private readonly ushort[] _numbers;

		// Token: 0x04000929 RID: 2345
		[Token(Token = "0x4000929")]
		[FieldOffset(Offset = "0x20")]
		private string _toString;

		// Token: 0x0400092A RID: 2346
		[Token(Token = "0x400092A")]
		[FieldOffset(Offset = "0x28")]
		private int _hashCode;

		// Token: 0x0400092B RID: 2347
		[Token(Token = "0x400092B")]
		internal const int NumberOfLabels = 8;

		// Token: 0x02000288 RID: 648
		[Token(Token = "0x2000288")]
		private sealed class ReadOnlyIPAddress : IPAddress
		{
			// Token: 0x0600123E RID: 4670 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600123E")]
			[Address(RVA = "0x51B4A00", Offset = "0x51B3600", VA = "0x1851B4A00")]
			public ReadOnlyIPAddress(long newAddress)
			{
			}
		}
	}
}
