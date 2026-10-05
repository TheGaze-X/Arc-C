using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200024A RID: 586
	[Token(Token = "0x200024A")]
	public abstract class CipherSuite
	{
		// Token: 0x06001467 RID: 5223 RVA: 0x0000AC08 File Offset: 0x00008E08
		[Token(Token = "0x6001467")]
		[Address(RVA = "0x5245C90", Offset = "0x5244890", VA = "0x185245C90")]
		public static bool IsScsv(int cipherSuite)
		{
			return default(bool);
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001468")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected CipherSuite()
		{
		}

		// Token: 0x040009C5 RID: 2501
		[Token(Token = "0x40009C5")]
		public const int TLS_NULL_WITH_NULL_NULL = 0;

		// Token: 0x040009C6 RID: 2502
		[Token(Token = "0x40009C6")]
		public const int TLS_RSA_WITH_NULL_MD5 = 1;

		// Token: 0x040009C7 RID: 2503
		[Token(Token = "0x40009C7")]
		public const int TLS_RSA_WITH_NULL_SHA = 2;

		// Token: 0x040009C8 RID: 2504
		[Token(Token = "0x40009C8")]
		public const int TLS_RSA_EXPORT_WITH_RC4_40_MD5 = 3;

		// Token: 0x040009C9 RID: 2505
		[Token(Token = "0x40009C9")]
		public const int TLS_RSA_WITH_RC4_128_MD5 = 4;

		// Token: 0x040009CA RID: 2506
		[Token(Token = "0x40009CA")]
		public const int TLS_RSA_WITH_RC4_128_SHA = 5;

		// Token: 0x040009CB RID: 2507
		[Token(Token = "0x40009CB")]
		public const int TLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5 = 6;

		// Token: 0x040009CC RID: 2508
		[Token(Token = "0x40009CC")]
		public const int TLS_RSA_WITH_IDEA_CBC_SHA = 7;

		// Token: 0x040009CD RID: 2509
		[Token(Token = "0x40009CD")]
		public const int TLS_RSA_EXPORT_WITH_DES40_CBC_SHA = 8;

		// Token: 0x040009CE RID: 2510
		[Token(Token = "0x40009CE")]
		public const int TLS_RSA_WITH_DES_CBC_SHA = 9;

		// Token: 0x040009CF RID: 2511
		[Token(Token = "0x40009CF")]
		public const int TLS_RSA_WITH_3DES_EDE_CBC_SHA = 10;

		// Token: 0x040009D0 RID: 2512
		[Token(Token = "0x40009D0")]
		public const int TLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA = 11;

		// Token: 0x040009D1 RID: 2513
		[Token(Token = "0x40009D1")]
		public const int TLS_DH_DSS_WITH_DES_CBC_SHA = 12;

		// Token: 0x040009D2 RID: 2514
		[Token(Token = "0x40009D2")]
		public const int TLS_DH_DSS_WITH_3DES_EDE_CBC_SHA = 13;

		// Token: 0x040009D3 RID: 2515
		[Token(Token = "0x40009D3")]
		public const int TLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA = 14;

		// Token: 0x040009D4 RID: 2516
		[Token(Token = "0x40009D4")]
		public const int TLS_DH_RSA_WITH_DES_CBC_SHA = 15;

		// Token: 0x040009D5 RID: 2517
		[Token(Token = "0x40009D5")]
		public const int TLS_DH_RSA_WITH_3DES_EDE_CBC_SHA = 16;

		// Token: 0x040009D6 RID: 2518
		[Token(Token = "0x40009D6")]
		public const int TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA = 17;

		// Token: 0x040009D7 RID: 2519
		[Token(Token = "0x40009D7")]
		public const int TLS_DHE_DSS_WITH_DES_CBC_SHA = 18;

		// Token: 0x040009D8 RID: 2520
		[Token(Token = "0x40009D8")]
		public const int TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA = 19;

		// Token: 0x040009D9 RID: 2521
		[Token(Token = "0x40009D9")]
		public const int TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA = 20;

		// Token: 0x040009DA RID: 2522
		[Token(Token = "0x40009DA")]
		public const int TLS_DHE_RSA_WITH_DES_CBC_SHA = 21;

		// Token: 0x040009DB RID: 2523
		[Token(Token = "0x40009DB")]
		public const int TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA = 22;

		// Token: 0x040009DC RID: 2524
		[Token(Token = "0x40009DC")]
		public const int TLS_DH_anon_EXPORT_WITH_RC4_40_MD5 = 23;

		// Token: 0x040009DD RID: 2525
		[Token(Token = "0x40009DD")]
		public const int TLS_DH_anon_WITH_RC4_128_MD5 = 24;

		// Token: 0x040009DE RID: 2526
		[Token(Token = "0x40009DE")]
		public const int TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA = 25;

		// Token: 0x040009DF RID: 2527
		[Token(Token = "0x40009DF")]
		public const int TLS_DH_anon_WITH_DES_CBC_SHA = 26;

		// Token: 0x040009E0 RID: 2528
		[Token(Token = "0x40009E0")]
		public const int TLS_DH_anon_WITH_3DES_EDE_CBC_SHA = 27;

		// Token: 0x040009E1 RID: 2529
		[Token(Token = "0x40009E1")]
		public const int TLS_RSA_WITH_AES_128_CBC_SHA = 47;

		// Token: 0x040009E2 RID: 2530
		[Token(Token = "0x40009E2")]
		public const int TLS_DH_DSS_WITH_AES_128_CBC_SHA = 48;

		// Token: 0x040009E3 RID: 2531
		[Token(Token = "0x40009E3")]
		public const int TLS_DH_RSA_WITH_AES_128_CBC_SHA = 49;

		// Token: 0x040009E4 RID: 2532
		[Token(Token = "0x40009E4")]
		public const int TLS_DHE_DSS_WITH_AES_128_CBC_SHA = 50;

		// Token: 0x040009E5 RID: 2533
		[Token(Token = "0x40009E5")]
		public const int TLS_DHE_RSA_WITH_AES_128_CBC_SHA = 51;

		// Token: 0x040009E6 RID: 2534
		[Token(Token = "0x40009E6")]
		public const int TLS_DH_anon_WITH_AES_128_CBC_SHA = 52;

		// Token: 0x040009E7 RID: 2535
		[Token(Token = "0x40009E7")]
		public const int TLS_RSA_WITH_AES_256_CBC_SHA = 53;

		// Token: 0x040009E8 RID: 2536
		[Token(Token = "0x40009E8")]
		public const int TLS_DH_DSS_WITH_AES_256_CBC_SHA = 54;

		// Token: 0x040009E9 RID: 2537
		[Token(Token = "0x40009E9")]
		public const int TLS_DH_RSA_WITH_AES_256_CBC_SHA = 55;

		// Token: 0x040009EA RID: 2538
		[Token(Token = "0x40009EA")]
		public const int TLS_DHE_DSS_WITH_AES_256_CBC_SHA = 56;

		// Token: 0x040009EB RID: 2539
		[Token(Token = "0x40009EB")]
		public const int TLS_DHE_RSA_WITH_AES_256_CBC_SHA = 57;

		// Token: 0x040009EC RID: 2540
		[Token(Token = "0x40009EC")]
		public const int TLS_DH_anon_WITH_AES_256_CBC_SHA = 58;

		// Token: 0x040009ED RID: 2541
		[Token(Token = "0x40009ED")]
		public const int TLS_RSA_WITH_CAMELLIA_128_CBC_SHA = 65;

		// Token: 0x040009EE RID: 2542
		[Token(Token = "0x40009EE")]
		public const int TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA = 66;

		// Token: 0x040009EF RID: 2543
		[Token(Token = "0x40009EF")]
		public const int TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA = 67;

		// Token: 0x040009F0 RID: 2544
		[Token(Token = "0x40009F0")]
		public const int TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA = 68;

		// Token: 0x040009F1 RID: 2545
		[Token(Token = "0x40009F1")]
		public const int TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA = 69;

		// Token: 0x040009F2 RID: 2546
		[Token(Token = "0x40009F2")]
		public const int TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA = 70;

		// Token: 0x040009F3 RID: 2547
		[Token(Token = "0x40009F3")]
		public const int TLS_RSA_WITH_CAMELLIA_256_CBC_SHA = 132;

		// Token: 0x040009F4 RID: 2548
		[Token(Token = "0x40009F4")]
		public const int TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA = 133;

		// Token: 0x040009F5 RID: 2549
		[Token(Token = "0x40009F5")]
		public const int TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA = 134;

		// Token: 0x040009F6 RID: 2550
		[Token(Token = "0x40009F6")]
		public const int TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA = 135;

		// Token: 0x040009F7 RID: 2551
		[Token(Token = "0x40009F7")]
		public const int TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA = 136;

		// Token: 0x040009F8 RID: 2552
		[Token(Token = "0x40009F8")]
		public const int TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA = 137;

		// Token: 0x040009F9 RID: 2553
		[Token(Token = "0x40009F9")]
		public const int TLS_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 186;

		// Token: 0x040009FA RID: 2554
		[Token(Token = "0x40009FA")]
		public const int TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 187;

		// Token: 0x040009FB RID: 2555
		[Token(Token = "0x40009FB")]
		public const int TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 188;

		// Token: 0x040009FC RID: 2556
		[Token(Token = "0x40009FC")]
		public const int TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 189;

		// Token: 0x040009FD RID: 2557
		[Token(Token = "0x40009FD")]
		public const int TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 190;

		// Token: 0x040009FE RID: 2558
		[Token(Token = "0x40009FE")]
		public const int TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256 = 191;

		// Token: 0x040009FF RID: 2559
		[Token(Token = "0x40009FF")]
		public const int TLS_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 192;

		// Token: 0x04000A00 RID: 2560
		[Token(Token = "0x4000A00")]
		public const int TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 193;

		// Token: 0x04000A01 RID: 2561
		[Token(Token = "0x4000A01")]
		public const int TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 194;

		// Token: 0x04000A02 RID: 2562
		[Token(Token = "0x4000A02")]
		public const int TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 195;

		// Token: 0x04000A03 RID: 2563
		[Token(Token = "0x4000A03")]
		public const int TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 196;

		// Token: 0x04000A04 RID: 2564
		[Token(Token = "0x4000A04")]
		public const int TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256 = 197;

		// Token: 0x04000A05 RID: 2565
		[Token(Token = "0x4000A05")]
		public const int TLS_RSA_WITH_SEED_CBC_SHA = 150;

		// Token: 0x04000A06 RID: 2566
		[Token(Token = "0x4000A06")]
		public const int TLS_DH_DSS_WITH_SEED_CBC_SHA = 151;

		// Token: 0x04000A07 RID: 2567
		[Token(Token = "0x4000A07")]
		public const int TLS_DH_RSA_WITH_SEED_CBC_SHA = 152;

		// Token: 0x04000A08 RID: 2568
		[Token(Token = "0x4000A08")]
		public const int TLS_DHE_DSS_WITH_SEED_CBC_SHA = 153;

		// Token: 0x04000A09 RID: 2569
		[Token(Token = "0x4000A09")]
		public const int TLS_DHE_RSA_WITH_SEED_CBC_SHA = 154;

		// Token: 0x04000A0A RID: 2570
		[Token(Token = "0x4000A0A")]
		public const int TLS_DH_anon_WITH_SEED_CBC_SHA = 155;

		// Token: 0x04000A0B RID: 2571
		[Token(Token = "0x4000A0B")]
		public const int TLS_PSK_WITH_RC4_128_SHA = 138;

		// Token: 0x04000A0C RID: 2572
		[Token(Token = "0x4000A0C")]
		public const int TLS_PSK_WITH_3DES_EDE_CBC_SHA = 139;

		// Token: 0x04000A0D RID: 2573
		[Token(Token = "0x4000A0D")]
		public const int TLS_PSK_WITH_AES_128_CBC_SHA = 140;

		// Token: 0x04000A0E RID: 2574
		[Token(Token = "0x4000A0E")]
		public const int TLS_PSK_WITH_AES_256_CBC_SHA = 141;

		// Token: 0x04000A0F RID: 2575
		[Token(Token = "0x4000A0F")]
		public const int TLS_DHE_PSK_WITH_RC4_128_SHA = 142;

		// Token: 0x04000A10 RID: 2576
		[Token(Token = "0x4000A10")]
		public const int TLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA = 143;

		// Token: 0x04000A11 RID: 2577
		[Token(Token = "0x4000A11")]
		public const int TLS_DHE_PSK_WITH_AES_128_CBC_SHA = 144;

		// Token: 0x04000A12 RID: 2578
		[Token(Token = "0x4000A12")]
		public const int TLS_DHE_PSK_WITH_AES_256_CBC_SHA = 145;

		// Token: 0x04000A13 RID: 2579
		[Token(Token = "0x4000A13")]
		public const int TLS_RSA_PSK_WITH_RC4_128_SHA = 146;

		// Token: 0x04000A14 RID: 2580
		[Token(Token = "0x4000A14")]
		public const int TLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA = 147;

		// Token: 0x04000A15 RID: 2581
		[Token(Token = "0x4000A15")]
		public const int TLS_RSA_PSK_WITH_AES_128_CBC_SHA = 148;

		// Token: 0x04000A16 RID: 2582
		[Token(Token = "0x4000A16")]
		public const int TLS_RSA_PSK_WITH_AES_256_CBC_SHA = 149;

		// Token: 0x04000A17 RID: 2583
		[Token(Token = "0x4000A17")]
		public const int TLS_ECDH_ECDSA_WITH_NULL_SHA = 49153;

		// Token: 0x04000A18 RID: 2584
		[Token(Token = "0x4000A18")]
		public const int TLS_ECDH_ECDSA_WITH_RC4_128_SHA = 49154;

		// Token: 0x04000A19 RID: 2585
		[Token(Token = "0x4000A19")]
		public const int TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA = 49155;

		// Token: 0x04000A1A RID: 2586
		[Token(Token = "0x4000A1A")]
		public const int TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA = 49156;

		// Token: 0x04000A1B RID: 2587
		[Token(Token = "0x4000A1B")]
		public const int TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA = 49157;

		// Token: 0x04000A1C RID: 2588
		[Token(Token = "0x4000A1C")]
		public const int TLS_ECDHE_ECDSA_WITH_NULL_SHA = 49158;

		// Token: 0x04000A1D RID: 2589
		[Token(Token = "0x4000A1D")]
		public const int TLS_ECDHE_ECDSA_WITH_RC4_128_SHA = 49159;

		// Token: 0x04000A1E RID: 2590
		[Token(Token = "0x4000A1E")]
		public const int TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA = 49160;

		// Token: 0x04000A1F RID: 2591
		[Token(Token = "0x4000A1F")]
		public const int TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA = 49161;

		// Token: 0x04000A20 RID: 2592
		[Token(Token = "0x4000A20")]
		public const int TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA = 49162;

		// Token: 0x04000A21 RID: 2593
		[Token(Token = "0x4000A21")]
		public const int TLS_ECDH_RSA_WITH_NULL_SHA = 49163;

		// Token: 0x04000A22 RID: 2594
		[Token(Token = "0x4000A22")]
		public const int TLS_ECDH_RSA_WITH_RC4_128_SHA = 49164;

		// Token: 0x04000A23 RID: 2595
		[Token(Token = "0x4000A23")]
		public const int TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA = 49165;

		// Token: 0x04000A24 RID: 2596
		[Token(Token = "0x4000A24")]
		public const int TLS_ECDH_RSA_WITH_AES_128_CBC_SHA = 49166;

		// Token: 0x04000A25 RID: 2597
		[Token(Token = "0x4000A25")]
		public const int TLS_ECDH_RSA_WITH_AES_256_CBC_SHA = 49167;

		// Token: 0x04000A26 RID: 2598
		[Token(Token = "0x4000A26")]
		public const int TLS_ECDHE_RSA_WITH_NULL_SHA = 49168;

		// Token: 0x04000A27 RID: 2599
		[Token(Token = "0x4000A27")]
		public const int TLS_ECDHE_RSA_WITH_RC4_128_SHA = 49169;

		// Token: 0x04000A28 RID: 2600
		[Token(Token = "0x4000A28")]
		public const int TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA = 49170;

		// Token: 0x04000A29 RID: 2601
		[Token(Token = "0x4000A29")]
		public const int TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA = 49171;

		// Token: 0x04000A2A RID: 2602
		[Token(Token = "0x4000A2A")]
		public const int TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA = 49172;

		// Token: 0x04000A2B RID: 2603
		[Token(Token = "0x4000A2B")]
		public const int TLS_ECDH_anon_WITH_NULL_SHA = 49173;

		// Token: 0x04000A2C RID: 2604
		[Token(Token = "0x4000A2C")]
		public const int TLS_ECDH_anon_WITH_RC4_128_SHA = 49174;

		// Token: 0x04000A2D RID: 2605
		[Token(Token = "0x4000A2D")]
		public const int TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA = 49175;

		// Token: 0x04000A2E RID: 2606
		[Token(Token = "0x4000A2E")]
		public const int TLS_ECDH_anon_WITH_AES_128_CBC_SHA = 49176;

		// Token: 0x04000A2F RID: 2607
		[Token(Token = "0x4000A2F")]
		public const int TLS_ECDH_anon_WITH_AES_256_CBC_SHA = 49177;

		// Token: 0x04000A30 RID: 2608
		[Token(Token = "0x4000A30")]
		public const int TLS_PSK_WITH_NULL_SHA = 44;

		// Token: 0x04000A31 RID: 2609
		[Token(Token = "0x4000A31")]
		public const int TLS_DHE_PSK_WITH_NULL_SHA = 45;

		// Token: 0x04000A32 RID: 2610
		[Token(Token = "0x4000A32")]
		public const int TLS_RSA_PSK_WITH_NULL_SHA = 46;

		// Token: 0x04000A33 RID: 2611
		[Token(Token = "0x4000A33")]
		public const int TLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA = 49178;

		// Token: 0x04000A34 RID: 2612
		[Token(Token = "0x4000A34")]
		public const int TLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA = 49179;

		// Token: 0x04000A35 RID: 2613
		[Token(Token = "0x4000A35")]
		public const int TLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA = 49180;

		// Token: 0x04000A36 RID: 2614
		[Token(Token = "0x4000A36")]
		public const int TLS_SRP_SHA_WITH_AES_128_CBC_SHA = 49181;

		// Token: 0x04000A37 RID: 2615
		[Token(Token = "0x4000A37")]
		public const int TLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA = 49182;

		// Token: 0x04000A38 RID: 2616
		[Token(Token = "0x4000A38")]
		public const int TLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA = 49183;

		// Token: 0x04000A39 RID: 2617
		[Token(Token = "0x4000A39")]
		public const int TLS_SRP_SHA_WITH_AES_256_CBC_SHA = 49184;

		// Token: 0x04000A3A RID: 2618
		[Token(Token = "0x4000A3A")]
		public const int TLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA = 49185;

		// Token: 0x04000A3B RID: 2619
		[Token(Token = "0x4000A3B")]
		public const int TLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA = 49186;

		// Token: 0x04000A3C RID: 2620
		[Token(Token = "0x4000A3C")]
		public const int TLS_RSA_WITH_NULL_SHA256 = 59;

		// Token: 0x04000A3D RID: 2621
		[Token(Token = "0x4000A3D")]
		public const int TLS_RSA_WITH_AES_128_CBC_SHA256 = 60;

		// Token: 0x04000A3E RID: 2622
		[Token(Token = "0x4000A3E")]
		public const int TLS_RSA_WITH_AES_256_CBC_SHA256 = 61;

		// Token: 0x04000A3F RID: 2623
		[Token(Token = "0x4000A3F")]
		public const int TLS_DH_DSS_WITH_AES_128_CBC_SHA256 = 62;

		// Token: 0x04000A40 RID: 2624
		[Token(Token = "0x4000A40")]
		public const int TLS_DH_RSA_WITH_AES_128_CBC_SHA256 = 63;

		// Token: 0x04000A41 RID: 2625
		[Token(Token = "0x4000A41")]
		public const int TLS_DHE_DSS_WITH_AES_128_CBC_SHA256 = 64;

		// Token: 0x04000A42 RID: 2626
		[Token(Token = "0x4000A42")]
		public const int TLS_DHE_RSA_WITH_AES_128_CBC_SHA256 = 103;

		// Token: 0x04000A43 RID: 2627
		[Token(Token = "0x4000A43")]
		public const int TLS_DH_DSS_WITH_AES_256_CBC_SHA256 = 104;

		// Token: 0x04000A44 RID: 2628
		[Token(Token = "0x4000A44")]
		public const int TLS_DH_RSA_WITH_AES_256_CBC_SHA256 = 105;

		// Token: 0x04000A45 RID: 2629
		[Token(Token = "0x4000A45")]
		public const int TLS_DHE_DSS_WITH_AES_256_CBC_SHA256 = 106;

		// Token: 0x04000A46 RID: 2630
		[Token(Token = "0x4000A46")]
		public const int TLS_DHE_RSA_WITH_AES_256_CBC_SHA256 = 107;

		// Token: 0x04000A47 RID: 2631
		[Token(Token = "0x4000A47")]
		public const int TLS_DH_anon_WITH_AES_128_CBC_SHA256 = 108;

		// Token: 0x04000A48 RID: 2632
		[Token(Token = "0x4000A48")]
		public const int TLS_DH_anon_WITH_AES_256_CBC_SHA256 = 109;

		// Token: 0x04000A49 RID: 2633
		[Token(Token = "0x4000A49")]
		public const int TLS_RSA_WITH_AES_128_GCM_SHA256 = 156;

		// Token: 0x04000A4A RID: 2634
		[Token(Token = "0x4000A4A")]
		public const int TLS_RSA_WITH_AES_256_GCM_SHA384 = 157;

		// Token: 0x04000A4B RID: 2635
		[Token(Token = "0x4000A4B")]
		public const int TLS_DHE_RSA_WITH_AES_128_GCM_SHA256 = 158;

		// Token: 0x04000A4C RID: 2636
		[Token(Token = "0x4000A4C")]
		public const int TLS_DHE_RSA_WITH_AES_256_GCM_SHA384 = 159;

		// Token: 0x04000A4D RID: 2637
		[Token(Token = "0x4000A4D")]
		public const int TLS_DH_RSA_WITH_AES_128_GCM_SHA256 = 160;

		// Token: 0x04000A4E RID: 2638
		[Token(Token = "0x4000A4E")]
		public const int TLS_DH_RSA_WITH_AES_256_GCM_SHA384 = 161;

		// Token: 0x04000A4F RID: 2639
		[Token(Token = "0x4000A4F")]
		public const int TLS_DHE_DSS_WITH_AES_128_GCM_SHA256 = 162;

		// Token: 0x04000A50 RID: 2640
		[Token(Token = "0x4000A50")]
		public const int TLS_DHE_DSS_WITH_AES_256_GCM_SHA384 = 163;

		// Token: 0x04000A51 RID: 2641
		[Token(Token = "0x4000A51")]
		public const int TLS_DH_DSS_WITH_AES_128_GCM_SHA256 = 164;

		// Token: 0x04000A52 RID: 2642
		[Token(Token = "0x4000A52")]
		public const int TLS_DH_DSS_WITH_AES_256_GCM_SHA384 = 165;

		// Token: 0x04000A53 RID: 2643
		[Token(Token = "0x4000A53")]
		public const int TLS_DH_anon_WITH_AES_128_GCM_SHA256 = 166;

		// Token: 0x04000A54 RID: 2644
		[Token(Token = "0x4000A54")]
		public const int TLS_DH_anon_WITH_AES_256_GCM_SHA384 = 167;

		// Token: 0x04000A55 RID: 2645
		[Token(Token = "0x4000A55")]
		public const int TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256 = 49187;

		// Token: 0x04000A56 RID: 2646
		[Token(Token = "0x4000A56")]
		public const int TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384 = 49188;

		// Token: 0x04000A57 RID: 2647
		[Token(Token = "0x4000A57")]
		public const int TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256 = 49189;

		// Token: 0x04000A58 RID: 2648
		[Token(Token = "0x4000A58")]
		public const int TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384 = 49190;

		// Token: 0x04000A59 RID: 2649
		[Token(Token = "0x4000A59")]
		public const int TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256 = 49191;

		// Token: 0x04000A5A RID: 2650
		[Token(Token = "0x4000A5A")]
		public const int TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384 = 49192;

		// Token: 0x04000A5B RID: 2651
		[Token(Token = "0x4000A5B")]
		public const int TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256 = 49193;

		// Token: 0x04000A5C RID: 2652
		[Token(Token = "0x4000A5C")]
		public const int TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384 = 49194;

		// Token: 0x04000A5D RID: 2653
		[Token(Token = "0x4000A5D")]
		public const int TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256 = 49195;

		// Token: 0x04000A5E RID: 2654
		[Token(Token = "0x4000A5E")]
		public const int TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384 = 49196;

		// Token: 0x04000A5F RID: 2655
		[Token(Token = "0x4000A5F")]
		public const int TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256 = 49197;

		// Token: 0x04000A60 RID: 2656
		[Token(Token = "0x4000A60")]
		public const int TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384 = 49198;

		// Token: 0x04000A61 RID: 2657
		[Token(Token = "0x4000A61")]
		public const int TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256 = 49199;

		// Token: 0x04000A62 RID: 2658
		[Token(Token = "0x4000A62")]
		public const int TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384 = 49200;

		// Token: 0x04000A63 RID: 2659
		[Token(Token = "0x4000A63")]
		public const int TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256 = 49201;

		// Token: 0x04000A64 RID: 2660
		[Token(Token = "0x4000A64")]
		public const int TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384 = 49202;

		// Token: 0x04000A65 RID: 2661
		[Token(Token = "0x4000A65")]
		public const int TLS_PSK_WITH_AES_128_GCM_SHA256 = 168;

		// Token: 0x04000A66 RID: 2662
		[Token(Token = "0x4000A66")]
		public const int TLS_PSK_WITH_AES_256_GCM_SHA384 = 169;

		// Token: 0x04000A67 RID: 2663
		[Token(Token = "0x4000A67")]
		public const int TLS_DHE_PSK_WITH_AES_128_GCM_SHA256 = 170;

		// Token: 0x04000A68 RID: 2664
		[Token(Token = "0x4000A68")]
		public const int TLS_DHE_PSK_WITH_AES_256_GCM_SHA384 = 171;

		// Token: 0x04000A69 RID: 2665
		[Token(Token = "0x4000A69")]
		public const int TLS_RSA_PSK_WITH_AES_128_GCM_SHA256 = 172;

		// Token: 0x04000A6A RID: 2666
		[Token(Token = "0x4000A6A")]
		public const int TLS_RSA_PSK_WITH_AES_256_GCM_SHA384 = 173;

		// Token: 0x04000A6B RID: 2667
		[Token(Token = "0x4000A6B")]
		public const int TLS_PSK_WITH_AES_128_CBC_SHA256 = 174;

		// Token: 0x04000A6C RID: 2668
		[Token(Token = "0x4000A6C")]
		public const int TLS_PSK_WITH_AES_256_CBC_SHA384 = 175;

		// Token: 0x04000A6D RID: 2669
		[Token(Token = "0x4000A6D")]
		public const int TLS_PSK_WITH_NULL_SHA256 = 176;

		// Token: 0x04000A6E RID: 2670
		[Token(Token = "0x4000A6E")]
		public const int TLS_PSK_WITH_NULL_SHA384 = 177;

		// Token: 0x04000A6F RID: 2671
		[Token(Token = "0x4000A6F")]
		public const int TLS_DHE_PSK_WITH_AES_128_CBC_SHA256 = 178;

		// Token: 0x04000A70 RID: 2672
		[Token(Token = "0x4000A70")]
		public const int TLS_DHE_PSK_WITH_AES_256_CBC_SHA384 = 179;

		// Token: 0x04000A71 RID: 2673
		[Token(Token = "0x4000A71")]
		public const int TLS_DHE_PSK_WITH_NULL_SHA256 = 180;

		// Token: 0x04000A72 RID: 2674
		[Token(Token = "0x4000A72")]
		public const int TLS_DHE_PSK_WITH_NULL_SHA384 = 181;

		// Token: 0x04000A73 RID: 2675
		[Token(Token = "0x4000A73")]
		public const int TLS_RSA_PSK_WITH_AES_128_CBC_SHA256 = 182;

		// Token: 0x04000A74 RID: 2676
		[Token(Token = "0x4000A74")]
		public const int TLS_RSA_PSK_WITH_AES_256_CBC_SHA384 = 183;

		// Token: 0x04000A75 RID: 2677
		[Token(Token = "0x4000A75")]
		public const int TLS_RSA_PSK_WITH_NULL_SHA256 = 184;

		// Token: 0x04000A76 RID: 2678
		[Token(Token = "0x4000A76")]
		public const int TLS_RSA_PSK_WITH_NULL_SHA384 = 185;

		// Token: 0x04000A77 RID: 2679
		[Token(Token = "0x4000A77")]
		public const int TLS_ECDHE_PSK_WITH_RC4_128_SHA = 49203;

		// Token: 0x04000A78 RID: 2680
		[Token(Token = "0x4000A78")]
		public const int TLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA = 49204;

		// Token: 0x04000A79 RID: 2681
		[Token(Token = "0x4000A79")]
		public const int TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA = 49205;

		// Token: 0x04000A7A RID: 2682
		[Token(Token = "0x4000A7A")]
		public const int TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA = 49206;

		// Token: 0x04000A7B RID: 2683
		[Token(Token = "0x4000A7B")]
		public const int TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256 = 49207;

		// Token: 0x04000A7C RID: 2684
		[Token(Token = "0x4000A7C")]
		public const int TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384 = 49208;

		// Token: 0x04000A7D RID: 2685
		[Token(Token = "0x4000A7D")]
		public const int TLS_ECDHE_PSK_WITH_NULL_SHA = 49209;

		// Token: 0x04000A7E RID: 2686
		[Token(Token = "0x4000A7E")]
		public const int TLS_ECDHE_PSK_WITH_NULL_SHA256 = 49210;

		// Token: 0x04000A7F RID: 2687
		[Token(Token = "0x4000A7F")]
		public const int TLS_ECDHE_PSK_WITH_NULL_SHA384 = 49211;

		// Token: 0x04000A80 RID: 2688
		[Token(Token = "0x4000A80")]
		public const int TLS_EMPTY_RENEGOTIATION_INFO_SCSV = 255;

		// Token: 0x04000A81 RID: 2689
		[Token(Token = "0x4000A81")]
		public const int TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49266;

		// Token: 0x04000A82 RID: 2690
		[Token(Token = "0x4000A82")]
		public const int TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49267;

		// Token: 0x04000A83 RID: 2691
		[Token(Token = "0x4000A83")]
		public const int TLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49268;

		// Token: 0x04000A84 RID: 2692
		[Token(Token = "0x4000A84")]
		public const int TLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49269;

		// Token: 0x04000A85 RID: 2693
		[Token(Token = "0x4000A85")]
		public const int TLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49270;

		// Token: 0x04000A86 RID: 2694
		[Token(Token = "0x4000A86")]
		public const int TLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49271;

		// Token: 0x04000A87 RID: 2695
		[Token(Token = "0x4000A87")]
		public const int TLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49272;

		// Token: 0x04000A88 RID: 2696
		[Token(Token = "0x4000A88")]
		public const int TLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49273;

		// Token: 0x04000A89 RID: 2697
		[Token(Token = "0x4000A89")]
		public const int TLS_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49274;

		// Token: 0x04000A8A RID: 2698
		[Token(Token = "0x4000A8A")]
		public const int TLS_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49275;

		// Token: 0x04000A8B RID: 2699
		[Token(Token = "0x4000A8B")]
		public const int TLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49276;

		// Token: 0x04000A8C RID: 2700
		[Token(Token = "0x4000A8C")]
		public const int TLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49277;

		// Token: 0x04000A8D RID: 2701
		[Token(Token = "0x4000A8D")]
		public const int TLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49278;

		// Token: 0x04000A8E RID: 2702
		[Token(Token = "0x4000A8E")]
		public const int TLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49279;

		// Token: 0x04000A8F RID: 2703
		[Token(Token = "0x4000A8F")]
		public const int TLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49280;

		// Token: 0x04000A90 RID: 2704
		[Token(Token = "0x4000A90")]
		public const int TLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49281;

		// Token: 0x04000A91 RID: 2705
		[Token(Token = "0x4000A91")]
		public const int TLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49282;

		// Token: 0x04000A92 RID: 2706
		[Token(Token = "0x4000A92")]
		public const int TLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49283;

		// Token: 0x04000A93 RID: 2707
		[Token(Token = "0x4000A93")]
		public const int TLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256 = 49284;

		// Token: 0x04000A94 RID: 2708
		[Token(Token = "0x4000A94")]
		public const int TLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384 = 49285;

		// Token: 0x04000A95 RID: 2709
		[Token(Token = "0x4000A95")]
		public const int TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49286;

		// Token: 0x04000A96 RID: 2710
		[Token(Token = "0x4000A96")]
		public const int TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49287;

		// Token: 0x04000A97 RID: 2711
		[Token(Token = "0x4000A97")]
		public const int TLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49288;

		// Token: 0x04000A98 RID: 2712
		[Token(Token = "0x4000A98")]
		public const int TLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49289;

		// Token: 0x04000A99 RID: 2713
		[Token(Token = "0x4000A99")]
		public const int TLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49290;

		// Token: 0x04000A9A RID: 2714
		[Token(Token = "0x4000A9A")]
		public const int TLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49291;

		// Token: 0x04000A9B RID: 2715
		[Token(Token = "0x4000A9B")]
		public const int TLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49292;

		// Token: 0x04000A9C RID: 2716
		[Token(Token = "0x4000A9C")]
		public const int TLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49293;

		// Token: 0x04000A9D RID: 2717
		[Token(Token = "0x4000A9D")]
		public const int TLS_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49294;

		// Token: 0x04000A9E RID: 2718
		[Token(Token = "0x4000A9E")]
		public const int TLS_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49295;

		// Token: 0x04000A9F RID: 2719
		[Token(Token = "0x4000A9F")]
		public const int TLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49296;

		// Token: 0x04000AA0 RID: 2720
		[Token(Token = "0x4000AA0")]
		public const int TLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49297;

		// Token: 0x04000AA1 RID: 2721
		[Token(Token = "0x4000AA1")]
		public const int TLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49298;

		// Token: 0x04000AA2 RID: 2722
		[Token(Token = "0x4000AA2")]
		public const int TLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49299;

		// Token: 0x04000AA3 RID: 2723
		[Token(Token = "0x4000AA3")]
		public const int TLS_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49300;

		// Token: 0x04000AA4 RID: 2724
		[Token(Token = "0x4000AA4")]
		public const int TLS_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49301;

		// Token: 0x04000AA5 RID: 2725
		[Token(Token = "0x4000AA5")]
		public const int TLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49302;

		// Token: 0x04000AA6 RID: 2726
		[Token(Token = "0x4000AA6")]
		public const int TLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49303;

		// Token: 0x04000AA7 RID: 2727
		[Token(Token = "0x4000AA7")]
		public const int TLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49304;

		// Token: 0x04000AA8 RID: 2728
		[Token(Token = "0x4000AA8")]
		public const int TLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49305;

		// Token: 0x04000AA9 RID: 2729
		[Token(Token = "0x4000AA9")]
		public const int TLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49306;

		// Token: 0x04000AAA RID: 2730
		[Token(Token = "0x4000AAA")]
		public const int TLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49307;

		// Token: 0x04000AAB RID: 2731
		[Token(Token = "0x4000AAB")]
		public const int TLS_RSA_WITH_AES_128_CCM = 49308;

		// Token: 0x04000AAC RID: 2732
		[Token(Token = "0x4000AAC")]
		public const int TLS_RSA_WITH_AES_256_CCM = 49309;

		// Token: 0x04000AAD RID: 2733
		[Token(Token = "0x4000AAD")]
		public const int TLS_DHE_RSA_WITH_AES_128_CCM = 49310;

		// Token: 0x04000AAE RID: 2734
		[Token(Token = "0x4000AAE")]
		public const int TLS_DHE_RSA_WITH_AES_256_CCM = 49311;

		// Token: 0x04000AAF RID: 2735
		[Token(Token = "0x4000AAF")]
		public const int TLS_RSA_WITH_AES_128_CCM_8 = 49312;

		// Token: 0x04000AB0 RID: 2736
		[Token(Token = "0x4000AB0")]
		public const int TLS_RSA_WITH_AES_256_CCM_8 = 49313;

		// Token: 0x04000AB1 RID: 2737
		[Token(Token = "0x4000AB1")]
		public const int TLS_DHE_RSA_WITH_AES_128_CCM_8 = 49314;

		// Token: 0x04000AB2 RID: 2738
		[Token(Token = "0x4000AB2")]
		public const int TLS_DHE_RSA_WITH_AES_256_CCM_8 = 49315;

		// Token: 0x04000AB3 RID: 2739
		[Token(Token = "0x4000AB3")]
		public const int TLS_PSK_WITH_AES_128_CCM = 49316;

		// Token: 0x04000AB4 RID: 2740
		[Token(Token = "0x4000AB4")]
		public const int TLS_PSK_WITH_AES_256_CCM = 49317;

		// Token: 0x04000AB5 RID: 2741
		[Token(Token = "0x4000AB5")]
		public const int TLS_DHE_PSK_WITH_AES_128_CCM = 49318;

		// Token: 0x04000AB6 RID: 2742
		[Token(Token = "0x4000AB6")]
		public const int TLS_DHE_PSK_WITH_AES_256_CCM = 49319;

		// Token: 0x04000AB7 RID: 2743
		[Token(Token = "0x4000AB7")]
		public const int TLS_PSK_WITH_AES_128_CCM_8 = 49320;

		// Token: 0x04000AB8 RID: 2744
		[Token(Token = "0x4000AB8")]
		public const int TLS_PSK_WITH_AES_256_CCM_8 = 49321;

		// Token: 0x04000AB9 RID: 2745
		[Token(Token = "0x4000AB9")]
		public const int TLS_PSK_DHE_WITH_AES_128_CCM_8 = 49322;

		// Token: 0x04000ABA RID: 2746
		[Token(Token = "0x4000ABA")]
		public const int TLS_PSK_DHE_WITH_AES_256_CCM_8 = 49323;

		// Token: 0x04000ABB RID: 2747
		[Token(Token = "0x4000ABB")]
		public const int TLS_ECDHE_ECDSA_WITH_AES_128_CCM = 49324;

		// Token: 0x04000ABC RID: 2748
		[Token(Token = "0x4000ABC")]
		public const int TLS_ECDHE_ECDSA_WITH_AES_256_CCM = 49325;

		// Token: 0x04000ABD RID: 2749
		[Token(Token = "0x4000ABD")]
		public const int TLS_ECDHE_ECDSA_WITH_AES_128_CCM_8 = 49326;

		// Token: 0x04000ABE RID: 2750
		[Token(Token = "0x4000ABE")]
		public const int TLS_ECDHE_ECDSA_WITH_AES_256_CCM_8 = 49327;

		// Token: 0x04000ABF RID: 2751
		[Token(Token = "0x4000ABF")]
		public const int TLS_FALLBACK_SCSV = 22016;

		// Token: 0x04000AC0 RID: 2752
		[Token(Token = "0x4000AC0")]
		public const int DRAFT_TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52392;

		// Token: 0x04000AC1 RID: 2753
		[Token(Token = "0x4000AC1")]
		public const int DRAFT_TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256 = 52393;

		// Token: 0x04000AC2 RID: 2754
		[Token(Token = "0x4000AC2")]
		public const int DRAFT_TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52394;

		// Token: 0x04000AC3 RID: 2755
		[Token(Token = "0x4000AC3")]
		public const int DRAFT_TLS_PSK_WITH_CHACHA20_POLY1305_SHA256 = 52395;

		// Token: 0x04000AC4 RID: 2756
		[Token(Token = "0x4000AC4")]
		public const int DRAFT_TLS_ECDHE_PSK_WITH_CHACHA20_POLY1305_SHA256 = 52396;

		// Token: 0x04000AC5 RID: 2757
		[Token(Token = "0x4000AC5")]
		public const int DRAFT_TLS_DHE_PSK_WITH_CHACHA20_POLY1305_SHA256 = 52397;

		// Token: 0x04000AC6 RID: 2758
		[Token(Token = "0x4000AC6")]
		public const int DRAFT_TLS_RSA_PSK_WITH_CHACHA20_POLY1305_SHA256 = 52398;

		// Token: 0x04000AC7 RID: 2759
		[Token(Token = "0x4000AC7")]
		public const int DRAFT_TLS_DHE_RSA_WITH_AES_128_OCB = 65280;

		// Token: 0x04000AC8 RID: 2760
		[Token(Token = "0x4000AC8")]
		public const int DRAFT_TLS_DHE_RSA_WITH_AES_256_OCB = 65281;

		// Token: 0x04000AC9 RID: 2761
		[Token(Token = "0x4000AC9")]
		public const int DRAFT_TLS_ECDHE_RSA_WITH_AES_128_OCB = 65282;

		// Token: 0x04000ACA RID: 2762
		[Token(Token = "0x4000ACA")]
		public const int DRAFT_TLS_ECDHE_RSA_WITH_AES_256_OCB = 65283;

		// Token: 0x04000ACB RID: 2763
		[Token(Token = "0x4000ACB")]
		public const int DRAFT_TLS_ECDHE_ECDSA_WITH_AES_128_OCB = 65284;

		// Token: 0x04000ACC RID: 2764
		[Token(Token = "0x4000ACC")]
		public const int DRAFT_TLS_ECDHE_ECDSA_WITH_AES_256_OCB = 65285;

		// Token: 0x04000ACD RID: 2765
		[Token(Token = "0x4000ACD")]
		public const int DRAFT_TLS_PSK_WITH_AES_128_OCB = 65296;

		// Token: 0x04000ACE RID: 2766
		[Token(Token = "0x4000ACE")]
		public const int DRAFT_TLS_PSK_WITH_AES_256_OCB = 65297;

		// Token: 0x04000ACF RID: 2767
		[Token(Token = "0x4000ACF")]
		public const int DRAFT_TLS_DHE_PSK_WITH_AES_128_OCB = 65298;

		// Token: 0x04000AD0 RID: 2768
		[Token(Token = "0x4000AD0")]
		public const int DRAFT_TLS_DHE_PSK_WITH_AES_256_OCB = 65299;

		// Token: 0x04000AD1 RID: 2769
		[Token(Token = "0x4000AD1")]
		public const int DRAFT_TLS_ECDHE_PSK_WITH_AES_128_OCB = 65300;

		// Token: 0x04000AD2 RID: 2770
		[Token(Token = "0x4000AD2")]
		public const int DRAFT_TLS_ECDHE_PSK_WITH_AES_256_OCB = 65301;
	}
}
