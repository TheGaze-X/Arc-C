using System;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	public class CloudGameUtil
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x000028AC File Offset: 0x00000AAC
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000048")]
		public static int ThinClientPlatform
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x4A0ABE0", Offset = "0x4A097E0", VA = "0x184A0ABE0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x4A0ACA0", Offset = "0x4A098A0", VA = "0x184A0ACA0")]
			set
			{
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x000020C6 File Offset: 0x000002C6
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000049")]
		public static string ThinClientDeviceProperties
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x4A0AB90", Offset = "0x4A09790", VA = "0x184A0AB90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x4A0AC30", Offset = "0x4A09830", VA = "0x184A0AC30")]
			set
			{
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x000028C4 File Offset: 0x00000AC4
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x4A0A8E0", Offset = "0x4A094E0", VA = "0x184A0A8E0")]
		public static bool IsCloudGame()
		{
			return default(bool);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CloudGameUtil()
		{
		}

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x0")]
		private static int m_thinClientPlatform;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x8")]
		private static string m_thinClientDeviceProperties;
	}
}
