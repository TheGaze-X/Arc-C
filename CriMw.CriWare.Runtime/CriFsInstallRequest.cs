using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000C3 RID: 195
	[Token(Token = "0x20000C3")]
	public class CriFsInstallRequest : CriFsRequest
	{
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000073")]
		public string sourcePath
		{
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000074")]
		public string destinationPath
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x00003B9C File Offset: 0x00001D9C
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000075")]
		public float progress
		{
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x1251100", Offset = "0x124FD00", VA = "0x181251100")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000670")]
			[Address(RVA = "0x1692870", Offset = "0x1691470", VA = "0x181692870")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x36F3310", Offset = "0x36F1F10", VA = "0x1836F3310")]
		public CriFsInstallRequest()
		{
		}
	}
}
