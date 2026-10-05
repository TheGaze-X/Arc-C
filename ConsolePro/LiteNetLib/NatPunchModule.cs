using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using FlyingWormConsole3.LiteNetLib.Utils;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	public sealed class NatPunchModule
	{
		// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x369A9D0", Offset = "0x36995D0", VA = "0x18369A9D0")]
		internal NatPunchModule(NetSocket socket)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x369A5E0", Offset = "0x36991E0", VA = "0x18369A5E0")]
		internal void ProcessMessage(IPEndPoint senderEndPoint, NetPacket packet)
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
		public void Init(INatPunchListener listener)
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000085")]
		private void Send<T>(T packet, IPEndPoint target) where T : class, new()
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x3699C80", Offset = "0x3698880", VA = "0x183699C80")]
		public void NatIntroduce(IPEndPoint hostInternal, IPEndPoint hostExternal, IPEndPoint clientInternal, IPEndPoint clientExternal, string additionalInfo)
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x369A240", Offset = "0x3698E40", VA = "0x18369A240")]
		public void PollEvents()
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x369A6F0", Offset = "0x36992F0", VA = "0x18369A6F0")]
		public void SendNatIntroduceRequest(string host, int port, string additionalInfo)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x369A880", Offset = "0x3699480", VA = "0x18369A880")]
		public void SendNatIntroduceRequest(IPEndPoint masterServerEndPoint, string additionalInfo)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x3699DA0", Offset = "0x36989A0", VA = "0x183699DA0")]
		private void OnNatIntroductionRequest(NatPunchModule.NatIntroduceRequestPacket req, IPEndPoint senderEndPoint)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x3699F00", Offset = "0x3698B00", VA = "0x183699F00")]
		private void OnNatIntroductionResponse(NatPunchModule.NatIntroduceResponsePacket req)
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x369A0D0", Offset = "0x3698CD0", VA = "0x18369A0D0")]
		private void OnNatPunch(NatPunchModule.NatPunchPacket req, IPEndPoint senderEndPoint)
		{
		}

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x10")]
		private readonly NetSocket _socket;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x18")]
		private readonly Queue<NatPunchModule.RequestEventData> _requestEvents;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x20")]
		private readonly Queue<NatPunchModule.SuccessEventData> _successEvents;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x28")]
		private readonly NetDataReader _cacheReader;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x30")]
		private readonly NetDataWriter _cacheWriter;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x38")]
		private readonly NetPacketProcessor _netPacketProcessor;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x40")]
		private INatPunchListener _natPunchListener;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		public const int MaxTokenLength = 256;

		// Token: 0x0200001D RID: 29
		[Token(Token = "0x200001D")]
		private struct RequestEventData
		{
			// Token: 0x0400003A RID: 58
			[Token(Token = "0x400003A")]
			[FieldOffset(Offset = "0x0")]
			public IPEndPoint LocalEndPoint;

			// Token: 0x0400003B RID: 59
			[Token(Token = "0x400003B")]
			[FieldOffset(Offset = "0x8")]
			public IPEndPoint RemoteEndPoint;

			// Token: 0x0400003C RID: 60
			[Token(Token = "0x400003C")]
			[FieldOffset(Offset = "0x10")]
			public string Token;
		}

		// Token: 0x0200001E RID: 30
		[Token(Token = "0x200001E")]
		private struct SuccessEventData
		{
			// Token: 0x0400003D RID: 61
			[Token(Token = "0x400003D")]
			[FieldOffset(Offset = "0x0")]
			public IPEndPoint TargetEndPoint;

			// Token: 0x0400003E RID: 62
			[Token(Token = "0x400003E")]
			[FieldOffset(Offset = "0x8")]
			public NatAddressType Type;

			// Token: 0x0400003F RID: 63
			[Token(Token = "0x400003F")]
			[FieldOffset(Offset = "0x10")]
			public string Token;
		}

		// Token: 0x0200001F RID: 31
		[Token(Token = "0x200001F")]
		private class NatIntroduceRequestPacket
		{
			// Token: 0x17000003 RID: 3
			// (get) Token: 0x0600008D RID: 141 RVA: 0x000020B2 File Offset: 0x000002B2
			// (set) Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000003")]
			public IPEndPoint Internal
			{
				[Token(Token = "0x600008D")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600008E")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x0600008F RID: 143 RVA: 0x000020B2 File Offset: 0x000002B2
			// (set) Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000004")]
			public string Token
			{
				[Token(Token = "0x600008F")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000090")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NatIntroduceRequestPacket()
			{
			}
		}

		// Token: 0x02000020 RID: 32
		[Token(Token = "0x2000020")]
		private class NatIntroduceResponsePacket
		{
			// Token: 0x17000005 RID: 5
			// (get) Token: 0x06000092 RID: 146 RVA: 0x000020B2 File Offset: 0x000002B2
			// (set) Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000005")]
			public IPEndPoint Internal
			{
				[Token(Token = "0x6000092")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000093")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000094 RID: 148 RVA: 0x000020B2 File Offset: 0x000002B2
			// (set) Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000006")]
			public IPEndPoint External
			{
				[Token(Token = "0x6000094")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000095")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000096 RID: 150 RVA: 0x000020B2 File Offset: 0x000002B2
			// (set) Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000007")]
			public string Token
			{
				[Token(Token = "0x6000096")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000097")]
				[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NatIntroduceResponsePacket()
			{
			}
		}

		// Token: 0x02000021 RID: 33
		[Token(Token = "0x2000021")]
		private class NatPunchPacket
		{
			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000099 RID: 153 RVA: 0x000020B2 File Offset: 0x000002B2
			// (set) Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000008")]
			public string Token
			{
				[Token(Token = "0x6000099")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600009A")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x0600009B RID: 155 RVA: 0x000020B8 File Offset: 0x000002B8
			// (set) Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000009")]
			public bool IsExternal
			{
				[Token(Token = "0x600009B")]
				[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600009C")]
				[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NatPunchPacket()
			{
			}
		}
	}
}
