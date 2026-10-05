using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000276 RID: 630
	[Token(Token = "0x2000276")]
	public sealed class SessionParameters
	{
		// Token: 0x0600153B RID: 5435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600153B")]
		[Address(RVA = "0x524FFA0", Offset = "0x524EBA0", VA = "0x18524FFA0")]
		private SessionParameters(int cipherSuite, byte compressionAlgorithm, byte[] masterSecret, Certificate peerCertificate, byte[] pskIdentity, byte[] srpIdentity, byte[] encodedServerExtensions)
		{
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600153C")]
		[Address(RVA = "0x524FE20", Offset = "0x524EA20", VA = "0x18524FE20")]
		public void Clear()
		{
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153D")]
		[Address(RVA = "0x524FE40", Offset = "0x524EA40", VA = "0x18524FE40")]
		public SessionParameters Copy()
		{
			return null;
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x0000AF98 File Offset: 0x00009198
		[Token(Token = "0x170002FA")]
		public int CipherSuite
		{
			[Token(Token = "0x600153E")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x0000AFB0 File Offset: 0x000091B0
		[Token(Token = "0x170002FB")]
		public byte CompressionAlgorithm
		{
			[Token(Token = "0x600153F")]
			[Address(RVA = "0x4E8AE0", Offset = "0x4E76E0", VA = "0x1804E8AE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FC")]
		public byte[] MasterSecret
		{
			[Token(Token = "0x6001540")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FD")]
		public Certificate PeerCertificate
		{
			[Token(Token = "0x6001541")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FE")]
		public byte[] PskIdentity
		{
			[Token(Token = "0x6001542")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FF")]
		public byte[] SrpIdentity
		{
			[Token(Token = "0x6001543")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001544")]
		[Address(RVA = "0x524FF00", Offset = "0x524EB00", VA = "0x18524FF00")]
		public IDictionary ReadServerExtensions()
		{
			return null;
		}

		// Token: 0x04000BDE RID: 3038
		[Token(Token = "0x4000BDE")]
		[FieldOffset(Offset = "0x10")]
		private int mCipherSuite;

		// Token: 0x04000BDF RID: 3039
		[Token(Token = "0x4000BDF")]
		[FieldOffset(Offset = "0x14")]
		private byte mCompressionAlgorithm;

		// Token: 0x04000BE0 RID: 3040
		[Token(Token = "0x4000BE0")]
		[FieldOffset(Offset = "0x18")]
		private byte[] mMasterSecret;

		// Token: 0x04000BE1 RID: 3041
		[Token(Token = "0x4000BE1")]
		[FieldOffset(Offset = "0x20")]
		private Certificate mPeerCertificate;

		// Token: 0x04000BE2 RID: 3042
		[Token(Token = "0x4000BE2")]
		[FieldOffset(Offset = "0x28")]
		private byte[] mPskIdentity;

		// Token: 0x04000BE3 RID: 3043
		[Token(Token = "0x4000BE3")]
		[FieldOffset(Offset = "0x30")]
		private byte[] mSrpIdentity;

		// Token: 0x04000BE4 RID: 3044
		[Token(Token = "0x4000BE4")]
		[FieldOffset(Offset = "0x38")]
		private byte[] mEncodedServerExtensions;

		// Token: 0x02000277 RID: 631
		[Token(Token = "0x2000277")]
		public sealed class Builder
		{
			// Token: 0x06001545 RID: 5445 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001545")]
			[Address(RVA = "0x5241A00", Offset = "0x5240600", VA = "0x185241A00")]
			public Builder()
			{
			}

			// Token: 0x06001546 RID: 5446 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001546")]
			[Address(RVA = "0x5241710", Offset = "0x5240310", VA = "0x185241710")]
			public SessionParameters Build()
			{
				return null;
			}

			// Token: 0x06001547 RID: 5447 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001547")]
			[Address(RVA = "0x5241850", Offset = "0x5240450", VA = "0x185241850")]
			public SessionParameters.Builder SetCipherSuite(int cipherSuite)
			{
				return null;
			}

			// Token: 0x06001548 RID: 5448 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001548")]
			[Address(RVA = "0x5241860", Offset = "0x5240460", VA = "0x185241860")]
			public SessionParameters.Builder SetCompressionAlgorithm(byte compressionAlgorithm)
			{
				return null;
			}

			// Token: 0x06001549 RID: 5449 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001549")]
			[Address(RVA = "0x17967C0", Offset = "0x17953C0", VA = "0x1817967C0")]
			public SessionParameters.Builder SetMasterSecret(byte[] masterSecret)
			{
				return null;
			}

			// Token: 0x0600154A RID: 5450 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600154A")]
			[Address(RVA = "0x46B3FE0", Offset = "0x46B2BE0", VA = "0x1846B3FE0")]
			public SessionParameters.Builder SetPeerCertificate(Certificate peerCertificate)
			{
				return null;
			}

			// Token: 0x0600154B RID: 5451 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600154B")]
			[Address(RVA = "0x3736E20", Offset = "0x3735A20", VA = "0x183736E20")]
			public SessionParameters.Builder SetPskIdentity(byte[] pskIdentity)
			{
				return null;
			}

			// Token: 0x0600154C RID: 5452 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600154C")]
			[Address(RVA = "0x5241950", Offset = "0x5240550", VA = "0x185241950")]
			public SessionParameters.Builder SetSrpIdentity(byte[] srpIdentity)
			{
				return null;
			}

			// Token: 0x0600154D RID: 5453 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600154D")]
			[Address(RVA = "0x5241870", Offset = "0x5240470", VA = "0x185241870")]
			public SessionParameters.Builder SetServerExtensions(IDictionary serverExtensions)
			{
				return null;
			}

			// Token: 0x0600154E RID: 5454 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600154E")]
			[Address(RVA = "0x5241970", Offset = "0x5240570", VA = "0x185241970")]
			private void Validate(bool condition, string parameter)
			{
			}

			// Token: 0x04000BE5 RID: 3045
			[Token(Token = "0x4000BE5")]
			[FieldOffset(Offset = "0x10")]
			private int mCipherSuite;

			// Token: 0x04000BE6 RID: 3046
			[Token(Token = "0x4000BE6")]
			[FieldOffset(Offset = "0x14")]
			private short mCompressionAlgorithm;

			// Token: 0x04000BE7 RID: 3047
			[Token(Token = "0x4000BE7")]
			[FieldOffset(Offset = "0x18")]
			private byte[] mMasterSecret;

			// Token: 0x04000BE8 RID: 3048
			[Token(Token = "0x4000BE8")]
			[FieldOffset(Offset = "0x20")]
			private Certificate mPeerCertificate;

			// Token: 0x04000BE9 RID: 3049
			[Token(Token = "0x4000BE9")]
			[FieldOffset(Offset = "0x28")]
			private byte[] mPskIdentity;

			// Token: 0x04000BEA RID: 3050
			[Token(Token = "0x4000BEA")]
			[FieldOffset(Offset = "0x30")]
			private byte[] mSrpIdentity;

			// Token: 0x04000BEB RID: 3051
			[Token(Token = "0x4000BEB")]
			[FieldOffset(Offset = "0x38")]
			private byte[] mEncodedServerExtensions;
		}
	}
}
