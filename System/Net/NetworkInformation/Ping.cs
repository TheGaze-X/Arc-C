using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x0200037A RID: 890
	[Token(Token = "0x200037A")]
	[MonoTODO("IPv6 support is missing")]
	public class Ping : Component, IDisposable
	{
		// Token: 0x0600186B RID: 6251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186B")]
		[Address(RVA = "0x50A3F80", Offset = "0x50A2B80", VA = "0x1850A3F80")]
		public Ping()
		{
		}

		// Token: 0x0600186C RID: 6252
		[Token(Token = "0x600186C")]
		[Address(RVA = "0x50A4090", Offset = "0x50A2C90", VA = "0x1850A4090")]
		[PreserveSig]
		private static extern int capget(ref Ping.cap_user_header_t header, ref Ping.cap_user_data_t data);

		// Token: 0x0600186D RID: 6253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186D")]
		[Address(RVA = "0x50A20D0", Offset = "0x50A0CD0", VA = "0x1850A20D0")]
		private static void CheckLinuxCapabilities()
		{
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "10")]
		private void Dispose()
		{
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186F")]
		[Address(RVA = "0x50A2220", Offset = "0x50A0E20", VA = "0x1850A2220")]
		protected void OnPingCompleted(PingCompletedEventArgs e)
		{
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001870")]
		[Address(RVA = "0x50A39C0", Offset = "0x50A25C0", VA = "0x1850A39C0")]
		public PingReply Send(IPAddress address, int timeout, byte[] buffer, PingOptions options)
		{
			return null;
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001871")]
		[Address(RVA = "0x50A2770", Offset = "0x50A1370", VA = "0x1850A2770")]
		private PingReply SendPrivileged(IPAddress address, int timeout, byte[] buffer, PingOptions options)
		{
			return null;
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001872")]
		[Address(RVA = "0x50A3470", Offset = "0x50A2070", VA = "0x1850A3470")]
		private PingReply SendUnprivileged(IPAddress address, int timeout, byte[] buffer, PingOptions options)
		{
			return null;
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001873")]
		[Address(RVA = "0x50A1E50", Offset = "0x50A0A50", VA = "0x1850A1E50")]
		private string BuildPingArgs(IPAddress address, int timeout, PingOptions options)
		{
			return null;
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001874")]
		[Address(RVA = "0x50A26A0", Offset = "0x50A12A0", VA = "0x1850A26A0")]
		public Task<PingReply> SendPingAsync(string hostNameOrAddress, int timeout, byte[] buffer)
		{
			return null;
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001875")]
		[Address(RVA = "0x50A2630", Offset = "0x50A1230", VA = "0x1850A2630")]
		public Task<PingReply> SendPingAsync(string hostNameOrAddress, int timeout, byte[] buffer, PingOptions options)
		{
			return null;
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001876")]
		[Address(RVA = "0x50A2520", Offset = "0x50A1120", VA = "0x1850A2520")]
		public Task<PingReply> SendPingAsync(string hostNameOrAddress, int timeout)
		{
			return null;
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001877")]
		[Address(RVA = "0x50A22B0", Offset = "0x50A0EB0", VA = "0x1850A22B0")]
		public Task<PingReply> SendPingAsync(IPAddress address, int timeout, byte[] buffer, PingOptions options)
		{
			return null;
		}

		// Token: 0x04000EAE RID: 3758
		[Token(Token = "0x4000EAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string[] PingBinPaths;

		// Token: 0x04000EAF RID: 3759
		[Token(Token = "0x4000EAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly string PingBinPath;

		// Token: 0x04000EB0 RID: 3760
		[Token(Token = "0x4000EB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool canSendPrivileged;

		// Token: 0x04000EB1 RID: 3761
		[Token(Token = "0x4000EB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ushort identifier;

		// Token: 0x04000EB2 RID: 3762
		[Token(Token = "0x4000EB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly byte[] default_buffer;

		// Token: 0x04000EB3 RID: 3763
		[Token(Token = "0x4000EB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BackgroundWorker worker;

		// Token: 0x04000EB4 RID: 3764
		[Token(Token = "0x4000EB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private object user_async_state;

		// Token: 0x04000EB5 RID: 3765
		[Token(Token = "0x4000EB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CancellationTokenSource cts;

		// Token: 0x04000EB6 RID: 3766
		[Token(Token = "0x4000EB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[CompilerGenerated]
		private PingCompletedEventHandler PingCompleted;

		// Token: 0x0200037B RID: 891
		[Token(Token = "0x200037B")]
		private struct cap_user_header_t
		{
			// Token: 0x04000EB7 RID: 3767
			[Token(Token = "0x4000EB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint version;

			// Token: 0x04000EB8 RID: 3768
			[Token(Token = "0x4000EB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int pid;
		}

		// Token: 0x0200037C RID: 892
		[Token(Token = "0x200037C")]
		private struct cap_user_data_t
		{
			// Token: 0x04000EB9 RID: 3769
			[Token(Token = "0x4000EB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint effective;

			// Token: 0x04000EBA RID: 3770
			[Token(Token = "0x4000EBA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public uint permitted;

			// Token: 0x04000EBB RID: 3771
			[Token(Token = "0x4000EBB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public uint inheritable;
		}

		// Token: 0x0200037D RID: 893
		[Token(Token = "0x200037D")]
		private class IcmpMessage
		{
			// Token: 0x06001878 RID: 6264 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001878")]
			[Address(RVA = "0x509DC50", Offset = "0x509C850", VA = "0x18509DC50")]
			public IcmpMessage(byte[] bytes, int offset, int size)
			{
			}

			// Token: 0x06001879 RID: 6265 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001879")]
			[Address(RVA = "0x509DA50", Offset = "0x509C650", VA = "0x18509DA50")]
			public IcmpMessage(byte type, byte code, ushort identifier, ushort sequence, byte[] data)
			{
			}

			// Token: 0x1700055F RID: 1375
			// (get) Token: 0x0600187A RID: 6266 RVA: 0x0000B010 File Offset: 0x00009210
			[Token(Token = "0x1700055F")]
			public byte Type
			{
				[Token(Token = "0x600187A")]
				[Address(RVA = "0x509DF10", Offset = "0x509CB10", VA = "0x18509DF10")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000560 RID: 1376
			// (get) Token: 0x0600187B RID: 6267 RVA: 0x0000B028 File Offset: 0x00009228
			[Token(Token = "0x17000560")]
			public byte Code
			{
				[Token(Token = "0x600187B")]
				[Address(RVA = "0x36B1AC0", Offset = "0x36B06C0", VA = "0x1836B1AC0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000561 RID: 1377
			// (get) Token: 0x0600187C RID: 6268 RVA: 0x0000B040 File Offset: 0x00009240
			[Token(Token = "0x17000561")]
			public ushort Identifier
			{
				[Token(Token = "0x600187C")]
				[Address(RVA = "0x509DED0", Offset = "0x509CAD0", VA = "0x18509DED0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000562 RID: 1378
			// (get) Token: 0x0600187D RID: 6269 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000562")]
			public byte[] Data
			{
				[Token(Token = "0x600187D")]
				[Address(RVA = "0x509DCF0", Offset = "0x509C8F0", VA = "0x18509DCF0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600187E RID: 6270 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600187E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			public byte[] GetBytes()
			{
				return null;
			}

			// Token: 0x0600187F RID: 6271 RVA: 0x0000B058 File Offset: 0x00009258
			[Token(Token = "0x600187F")]
			[Address(RVA = "0x509D9D0", Offset = "0x509C5D0", VA = "0x18509D9D0")]
			private static ushort ComputeChecksum(byte[] data)
			{
				return 0;
			}

			// Token: 0x17000563 RID: 1379
			// (get) Token: 0x06001880 RID: 6272 RVA: 0x0000B070 File Offset: 0x00009270
			[Token(Token = "0x17000563")]
			public IPStatus IPStatus
			{
				[Token(Token = "0x6001880")]
				[Address(RVA = "0x509DD80", Offset = "0x509C980", VA = "0x18509DD80")]
				get
				{
					return IPStatus.Success;
				}
			}

			// Token: 0x04000EBC RID: 3772
			[Token(Token = "0x4000EBC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private byte[] bytes;
		}
	}
}
