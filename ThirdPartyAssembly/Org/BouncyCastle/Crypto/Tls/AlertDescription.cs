using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200023D RID: 573
	[Token(Token = "0x200023D")]
	public abstract class AlertDescription
	{
		// Token: 0x06001416 RID: 5142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001416")]
		[Address(RVA = "0x5241100", Offset = "0x523FD00", VA = "0x185241100")]
		public static string GetName(byte alertDescription)
		{
			return null;
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001417")]
		[Address(RVA = "0x5241550", Offset = "0x5240150", VA = "0x185241550")]
		public static string GetText(byte alertDescription)
		{
			return null;
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001418")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected AlertDescription()
		{
		}

		// Token: 0x0400098C RID: 2444
		[Token(Token = "0x400098C")]
		public const byte close_notify = 0;

		// Token: 0x0400098D RID: 2445
		[Token(Token = "0x400098D")]
		public const byte unexpected_message = 10;

		// Token: 0x0400098E RID: 2446
		[Token(Token = "0x400098E")]
		public const byte bad_record_mac = 20;

		// Token: 0x0400098F RID: 2447
		[Token(Token = "0x400098F")]
		public const byte decryption_failed = 21;

		// Token: 0x04000990 RID: 2448
		[Token(Token = "0x4000990")]
		public const byte record_overflow = 22;

		// Token: 0x04000991 RID: 2449
		[Token(Token = "0x4000991")]
		public const byte decompression_failure = 30;

		// Token: 0x04000992 RID: 2450
		[Token(Token = "0x4000992")]
		public const byte handshake_failure = 40;

		// Token: 0x04000993 RID: 2451
		[Token(Token = "0x4000993")]
		public const byte no_certificate = 41;

		// Token: 0x04000994 RID: 2452
		[Token(Token = "0x4000994")]
		public const byte bad_certificate = 42;

		// Token: 0x04000995 RID: 2453
		[Token(Token = "0x4000995")]
		public const byte unsupported_certificate = 43;

		// Token: 0x04000996 RID: 2454
		[Token(Token = "0x4000996")]
		public const byte certificate_revoked = 44;

		// Token: 0x04000997 RID: 2455
		[Token(Token = "0x4000997")]
		public const byte certificate_expired = 45;

		// Token: 0x04000998 RID: 2456
		[Token(Token = "0x4000998")]
		public const byte certificate_unknown = 46;

		// Token: 0x04000999 RID: 2457
		[Token(Token = "0x4000999")]
		public const byte illegal_parameter = 47;

		// Token: 0x0400099A RID: 2458
		[Token(Token = "0x400099A")]
		public const byte unknown_ca = 48;

		// Token: 0x0400099B RID: 2459
		[Token(Token = "0x400099B")]
		public const byte access_denied = 49;

		// Token: 0x0400099C RID: 2460
		[Token(Token = "0x400099C")]
		public const byte decode_error = 50;

		// Token: 0x0400099D RID: 2461
		[Token(Token = "0x400099D")]
		public const byte decrypt_error = 51;

		// Token: 0x0400099E RID: 2462
		[Token(Token = "0x400099E")]
		public const byte export_restriction = 60;

		// Token: 0x0400099F RID: 2463
		[Token(Token = "0x400099F")]
		public const byte protocol_version = 70;

		// Token: 0x040009A0 RID: 2464
		[Token(Token = "0x40009A0")]
		public const byte insufficient_security = 71;

		// Token: 0x040009A1 RID: 2465
		[Token(Token = "0x40009A1")]
		public const byte internal_error = 80;

		// Token: 0x040009A2 RID: 2466
		[Token(Token = "0x40009A2")]
		public const byte user_canceled = 90;

		// Token: 0x040009A3 RID: 2467
		[Token(Token = "0x40009A3")]
		public const byte no_renegotiation = 100;

		// Token: 0x040009A4 RID: 2468
		[Token(Token = "0x40009A4")]
		public const byte unsupported_extension = 110;

		// Token: 0x040009A5 RID: 2469
		[Token(Token = "0x40009A5")]
		public const byte certificate_unobtainable = 111;

		// Token: 0x040009A6 RID: 2470
		[Token(Token = "0x40009A6")]
		public const byte unrecognized_name = 112;

		// Token: 0x040009A7 RID: 2471
		[Token(Token = "0x40009A7")]
		public const byte bad_certificate_status_response = 113;

		// Token: 0x040009A8 RID: 2472
		[Token(Token = "0x40009A8")]
		public const byte bad_certificate_hash_value = 114;

		// Token: 0x040009A9 RID: 2473
		[Token(Token = "0x40009A9")]
		public const byte unknown_psk_identity = 115;

		// Token: 0x040009AA RID: 2474
		[Token(Token = "0x40009AA")]
		public const byte inappropriate_fallback = 86;
	}
}
