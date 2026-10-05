using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000272 RID: 626
	[Token(Token = "0x2000272")]
	public class SecurityParameters
	{
		// Token: 0x0600151E RID: 5406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600151E")]
		[Address(RVA = "0x524EB90", Offset = "0x524D790", VA = "0x18524EB90", Slot = "4")]
		internal virtual void Clear()
		{
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x0000AEF0 File Offset: 0x000090F0
		[Token(Token = "0x170002EB")]
		public virtual int Entity
		{
			[Token(Token = "0x600151F")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06001520 RID: 5408 RVA: 0x0000AF08 File Offset: 0x00009108
		[Token(Token = "0x170002EC")]
		public virtual int CipherSuite
		{
			[Token(Token = "0x6001520")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x0000AF20 File Offset: 0x00009120
		[Token(Token = "0x170002ED")]
		public byte CompressionAlgorithm
		{
			[Token(Token = "0x6001521")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x0000AF38 File Offset: 0x00009138
		[Token(Token = "0x170002EE")]
		public virtual int PrfAlgorithm
		{
			[Token(Token = "0x6001522")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06001523 RID: 5411 RVA: 0x0000AF50 File Offset: 0x00009150
		[Token(Token = "0x170002EF")]
		public virtual int VerifyDataLength
		{
			[Token(Token = "0x6001523")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06001524 RID: 5412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F0")]
		public virtual byte[] MasterSecret
		{
			[Token(Token = "0x6001524")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06001525 RID: 5413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F1")]
		public virtual byte[] ClientRandom
		{
			[Token(Token = "0x6001525")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06001526 RID: 5414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F2")]
		public virtual byte[] ServerRandom
		{
			[Token(Token = "0x6001526")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06001527 RID: 5415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F3")]
		public virtual byte[] SessionHash
		{
			[Token(Token = "0x6001527")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06001528 RID: 5416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F4")]
		public virtual byte[] PskIdentity
		{
			[Token(Token = "0x6001528")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06001529 RID: 5417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F5")]
		public virtual byte[] SrpIdentity
		{
			[Token(Token = "0x6001529")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600152A")]
		[Address(RVA = "0x524EBD0", Offset = "0x524D7D0", VA = "0x18524EBD0")]
		public SecurityParameters()
		{
		}

		// Token: 0x04000BCB RID: 3019
		[Token(Token = "0x4000BCB")]
		[FieldOffset(Offset = "0x10")]
		internal int entity;

		// Token: 0x04000BCC RID: 3020
		[Token(Token = "0x4000BCC")]
		[FieldOffset(Offset = "0x14")]
		internal int cipherSuite;

		// Token: 0x04000BCD RID: 3021
		[Token(Token = "0x4000BCD")]
		[FieldOffset(Offset = "0x18")]
		internal byte compressionAlgorithm;

		// Token: 0x04000BCE RID: 3022
		[Token(Token = "0x4000BCE")]
		[FieldOffset(Offset = "0x1C")]
		internal int prfAlgorithm;

		// Token: 0x04000BCF RID: 3023
		[Token(Token = "0x4000BCF")]
		[FieldOffset(Offset = "0x20")]
		internal int verifyDataLength;

		// Token: 0x04000BD0 RID: 3024
		[Token(Token = "0x4000BD0")]
		[FieldOffset(Offset = "0x28")]
		internal byte[] masterSecret;

		// Token: 0x04000BD1 RID: 3025
		[Token(Token = "0x4000BD1")]
		[FieldOffset(Offset = "0x30")]
		internal byte[] clientRandom;

		// Token: 0x04000BD2 RID: 3026
		[Token(Token = "0x4000BD2")]
		[FieldOffset(Offset = "0x38")]
		internal byte[] serverRandom;

		// Token: 0x04000BD3 RID: 3027
		[Token(Token = "0x4000BD3")]
		[FieldOffset(Offset = "0x40")]
		internal byte[] sessionHash;

		// Token: 0x04000BD4 RID: 3028
		[Token(Token = "0x4000BD4")]
		[FieldOffset(Offset = "0x48")]
		internal byte[] pskIdentity;

		// Token: 0x04000BD5 RID: 3029
		[Token(Token = "0x4000BD5")]
		[FieldOffset(Offset = "0x50")]
		internal byte[] srpIdentity;

		// Token: 0x04000BD6 RID: 3030
		[Token(Token = "0x4000BD6")]
		[FieldOffset(Offset = "0x58")]
		internal short maxFragmentLength;

		// Token: 0x04000BD7 RID: 3031
		[Token(Token = "0x4000BD7")]
		[FieldOffset(Offset = "0x5A")]
		internal bool truncatedHMac;

		// Token: 0x04000BD8 RID: 3032
		[Token(Token = "0x4000BD8")]
		[FieldOffset(Offset = "0x5B")]
		internal bool encryptThenMac;

		// Token: 0x04000BD9 RID: 3033
		[Token(Token = "0x4000BD9")]
		[FieldOffset(Offset = "0x5C")]
		internal bool extendedMasterSecret;
	}
}
