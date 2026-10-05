using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000235 RID: 565
	[Token(Token = "0x2000235")]
	internal abstract class AbstractTlsContext : TlsContext
	{
		// Token: 0x060013BD RID: 5053 RVA: 0x0000A908 File Offset: 0x00008B08
		[Token(Token = "0x60013BD")]
		[Address(RVA = "0x523F460", Offset = "0x523E060", VA = "0x18523F460")]
		private static long NextCounterValue()
		{
			return 0L;
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013BE")]
		[Address(RVA = "0x523F510", Offset = "0x523E110", VA = "0x18523F510")]
		internal AbstractTlsContext(SecureRandom secureRandom, SecurityParameters securityParameters)
		{
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BB")]
		public virtual IRandomGenerator NonceRandomGenerator
		{
			[Token(Token = "0x60013BF")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060013C0 RID: 5056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BC")]
		public virtual SecureRandom SecureRandom
		{
			[Token(Token = "0x60013C0")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BD")]
		public virtual SecurityParameters SecurityParameters
		{
			[Token(Token = "0x60013C1")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060013C2 RID: 5058
		[Token(Token = "0x170002BE")]
		public abstract bool IsServer { [Token(Token = "0x60013C2")] get; }

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BF")]
		public virtual ProtocolVersion ClientVersion
		{
			[Token(Token = "0x60013C3")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013C4")]
		[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0", Slot = "19")]
		internal virtual void SetClientVersion(ProtocolVersion clientVersion)
		{
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C0")]
		public virtual ProtocolVersion ServerVersion
		{
			[Token(Token = "0x60013C5")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013C6")]
		[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30", Slot = "21")]
		internal virtual void SetServerVersion(ProtocolVersion serverVersion)
		{
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C1")]
		public virtual TlsSession ResumableSession
		{
			[Token(Token = "0x60013C7")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013C8")]
		[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990", Slot = "23")]
		internal virtual void SetResumableSession(TlsSession session)
		{
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060013CA RID: 5066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002C2")]
		public virtual object UserObject
		{
			[Token(Token = "0x60013C9")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "24")]
			get
			{
				return null;
			}
			[Token(Token = "0x60013CA")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013CB")]
		[Address(RVA = "0x523F130", Offset = "0x523DD30", VA = "0x18523F130", Slot = "26")]
		public virtual byte[] ExportKeyingMaterial(string asciiLabel, byte[] context_value, int length)
		{
			return null;
		}

		// Token: 0x0400096E RID: 2414
		[Token(Token = "0x400096E")]
		[FieldOffset(Offset = "0x0")]
		private static long counter;

		// Token: 0x0400096F RID: 2415
		[Token(Token = "0x400096F")]
		[FieldOffset(Offset = "0x10")]
		private readonly IRandomGenerator mNonceRandom;

		// Token: 0x04000970 RID: 2416
		[Token(Token = "0x4000970")]
		[FieldOffset(Offset = "0x18")]
		private readonly SecureRandom mSecureRandom;

		// Token: 0x04000971 RID: 2417
		[Token(Token = "0x4000971")]
		[FieldOffset(Offset = "0x20")]
		private readonly SecurityParameters mSecurityParameters;

		// Token: 0x04000972 RID: 2418
		[Token(Token = "0x4000972")]
		[FieldOffset(Offset = "0x28")]
		private ProtocolVersion mClientVersion;

		// Token: 0x04000973 RID: 2419
		[Token(Token = "0x4000973")]
		[FieldOffset(Offset = "0x30")]
		private ProtocolVersion mServerVersion;

		// Token: 0x04000974 RID: 2420
		[Token(Token = "0x4000974")]
		[FieldOffset(Offset = "0x38")]
		private TlsSession mSession;

		// Token: 0x04000975 RID: 2421
		[Token(Token = "0x4000975")]
		[FieldOffset(Offset = "0x40")]
		private object mUserObject;
	}
}
