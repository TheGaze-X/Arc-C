using System;
using System.Net;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public class EventBasedNatPunchListener : INatPunchListener
	{
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000A")]
		public event EventBasedNatPunchListener.OnNatIntroductionRequest NatIntroductionRequest
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x3698AA0", Offset = "0x36976A0", VA = "0x183698AA0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x3698BE0", Offset = "0x36977E0", VA = "0x183698BE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000B")]
		public event EventBasedNatPunchListener.OnNatIntroductionSuccess NatIntroductionSuccess
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x3698B40", Offset = "0x3697740", VA = "0x183698B40")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x3698C80", Offset = "0x3697880", VA = "0x183698C80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x3698A60", Offset = "0x3697660", VA = "0x183698A60", Slot = "4")]
		private void OnNatIntroductionRequest(IPEndPoint localEndPoint, IPEndPoint remoteEndPoint, string token)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x3698A80", Offset = "0x3697680", VA = "0x183698A80", Slot = "5")]
		private void OnNatIntroductionSuccess(IPEndPoint targetEndPoint, NatAddressType type, string token)
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EventBasedNatPunchListener()
		{
		}

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x0600007B RID: 123
		[Token(Token = "0x200001A")]
		public delegate void OnNatIntroductionRequest(IPEndPoint localEndPoint, IPEndPoint remoteEndPoint, string token);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x0600007F RID: 127
		[Token(Token = "0x200001B")]
		public delegate void OnNatIntroductionSuccess(IPEndPoint targetEndPoint, NatAddressType type, string token);
	}
}
