using System;
using System.Collections;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	public sealed class PKCS8
	{
		// Token: 0x02000051 RID: 81
		[Token(Token = "0x2000051")]
		public class PrivateKeyInfo
		{
			// Token: 0x060001C0 RID: 448 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x4AA2240", Offset = "0x4AA0E40", VA = "0x184AA2240")]
			public PrivateKeyInfo()
			{
			}

			// Token: 0x060001C1 RID: 449 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x4AA22C0", Offset = "0x4AA0EC0", VA = "0x184AA22C0")]
			public PrivateKeyInfo(byte[] data)
			{
			}

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060001C3 RID: 451 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000081")]
			public string Algorithm
			{
				[Token(Token = "0x60001C2")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001C3")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				set
				{
				}
			}

			// Token: 0x17000082 RID: 130
			// (get) Token: 0x060001C4 RID: 452 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060001C5 RID: 453 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000082")]
			public byte[] PrivateKey
			{
				[Token(Token = "0x60001C4")]
				[Address(RVA = "0x4AA2360", Offset = "0x4AA0F60", VA = "0x184AA2360")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001C5")]
				[Address(RVA = "0x4AA23E0", Offset = "0x4AA0FE0", VA = "0x184AA23E0")]
				set
				{
				}
			}

			// Token: 0x060001C6 RID: 454 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x4AA1370", Offset = "0x4A9FF70", VA = "0x184AA1370")]
			private void Decode(byte[] data)
			{
			}

			// Token: 0x060001C7 RID: 455 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x4AA1C40", Offset = "0x4AA0840", VA = "0x184AA1C40")]
			public byte[] GetBytes()
			{
				return null;
			}

			// Token: 0x060001C8 RID: 456 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x4AA2190", Offset = "0x4AA0D90", VA = "0x184AA2190")]
			private static byte[] RemoveLeadingZero(byte[] bigInt)
			{
				return null;
			}

			// Token: 0x060001C9 RID: 457 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x4AA20E0", Offset = "0x4AA0CE0", VA = "0x184AA20E0")]
			private static byte[] Normalize(byte[] bigInt, int length)
			{
				return null;
			}

			// Token: 0x060001CA RID: 458 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x4AA0E40", Offset = "0x4A9FA40", VA = "0x184AA0E40")]
			public static RSA DecodeRSA(byte[] keypair)
			{
				return null;
			}

			// Token: 0x060001CB RID: 459 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x4AA1750", Offset = "0x4AA0350", VA = "0x184AA1750")]
			public static byte[] Encode(RSA rsa)
			{
				return null;
			}

			// Token: 0x060001CC RID: 460 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x4AA0CB0", Offset = "0x4A9F8B0", VA = "0x184AA0CB0")]
			public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters)
			{
				return null;
			}

			// Token: 0x060001CD RID: 461 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x4AA16B0", Offset = "0x4AA02B0", VA = "0x184AA16B0")]
			public static byte[] Encode(DSA dsa)
			{
				return null;
			}

			// Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x4AA1980", Offset = "0x4AA0580", VA = "0x184AA1980")]
			public static byte[] Encode(AsymmetricAlgorithm aa)
			{
				return null;
			}

			// Token: 0x04000222 RID: 546
			[Token(Token = "0x4000222")]
			[FieldOffset(Offset = "0x10")]
			private int _version;

			// Token: 0x04000223 RID: 547
			[Token(Token = "0x4000223")]
			[FieldOffset(Offset = "0x18")]
			private string _algorithm;

			// Token: 0x04000224 RID: 548
			[Token(Token = "0x4000224")]
			[FieldOffset(Offset = "0x20")]
			private byte[] _key;

			// Token: 0x04000225 RID: 549
			[Token(Token = "0x4000225")]
			[FieldOffset(Offset = "0x28")]
			private ArrayList _list;
		}

		// Token: 0x02000052 RID: 82
		[Token(Token = "0x2000052")]
		public class EncryptedPrivateKeyInfo
		{
			// Token: 0x060001CF RID: 463 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EncryptedPrivateKeyInfo()
			{
			}

			// Token: 0x060001D0 RID: 464 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x4A98C20", Offset = "0x4A97820", VA = "0x184A98C20")]
			public EncryptedPrivateKeyInfo(byte[] data)
			{
			}

			// Token: 0x17000083 RID: 131
			// (get) Token: 0x060001D1 RID: 465 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060001D2 RID: 466 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000083")]
			public string Algorithm
			{
				[Token(Token = "0x60001D1")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001D2")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				set
				{
				}
			}

			// Token: 0x17000084 RID: 132
			// (get) Token: 0x060001D3 RID: 467 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000084")]
			public byte[] EncryptedData
			{
				[Token(Token = "0x60001D3")]
				[Address(RVA = "0x4A98C50", Offset = "0x4A97850", VA = "0x184A98C50")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001D4")]
				[Address(RVA = "0x4A98DC0", Offset = "0x4A979C0", VA = "0x184A98DC0")]
				set
				{
				}
			}

			// Token: 0x17000085 RID: 133
			// (get) Token: 0x060001D5 RID: 469 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000085")]
			public byte[] Salt
			{
				[Token(Token = "0x60001D5")]
				[Address(RVA = "0x4A98CD0", Offset = "0x4A978D0", VA = "0x184A98CD0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000086 RID: 134
			// (get) Token: 0x060001D6 RID: 470 RVA: 0x00002850 File Offset: 0x00000A50
			// (set) Token: 0x060001D7 RID: 471 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000086")]
			public int IterationCount
			{
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
				get
				{
					return 0;
				}
				[Token(Token = "0x60001D7")]
				[Address(RVA = "0x4A98E60", Offset = "0x4A97A60", VA = "0x184A98E60")]
				set
				{
				}
			}

			// Token: 0x060001D8 RID: 472 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x4A98620", Offset = "0x4A97220", VA = "0x184A98620")]
			private void Decode(byte[] data)
			{
			}

			// Token: 0x060001D9 RID: 473 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x4A98A00", Offset = "0x4A97600", VA = "0x184A98A00")]
			public byte[] GetBytes()
			{
				return null;
			}

			// Token: 0x04000226 RID: 550
			[Token(Token = "0x4000226")]
			[FieldOffset(Offset = "0x10")]
			private string _algorithm;

			// Token: 0x04000227 RID: 551
			[Token(Token = "0x4000227")]
			[FieldOffset(Offset = "0x18")]
			private byte[] _salt;

			// Token: 0x04000228 RID: 552
			[Token(Token = "0x4000228")]
			[FieldOffset(Offset = "0x20")]
			private int _iterations;

			// Token: 0x04000229 RID: 553
			[Token(Token = "0x4000229")]
			[FieldOffset(Offset = "0x28")]
			private byte[] _data;
		}
	}
}
