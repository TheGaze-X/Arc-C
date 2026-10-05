using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x20000A3")]
	public class CriAtomExStandardVoicePool : CriAtomExVoicePool
	{
		// Token: 0x060005B8 RID: 1464 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x36F02F0", Offset = "0x36EEEF0", VA = "0x1836F02F0")]
		public static void SetDefaultConfigForStandardVoicePool(ref CriAtomExStandardVoicePool.Config config)
		{
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x36F0440", Offset = "0x36EF040", VA = "0x1836F0440")]
		public CriAtomExStandardVoicePool(CriAtomExStandardVoicePool.Config config)
		{
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x36F0550", Offset = "0x36EF150", VA = "0x1836F0550")]
		public CriAtomExStandardVoicePool(int numVoices, int maxChannels, int maxSamplingRate, bool streamingFlag, uint identifier = 0U)
		{
		}

		// Token: 0x060005BB RID: 1467
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x36F0710", Offset = "0x36EF310", VA = "0x1836F0710")]
		[PreserveSig]
		private static extern IntPtr criAtomExVoicePool_AllocateStandardVoicePool(ref CriAtomExStandardVoicePool.Config config, IntPtr work, int work_size);

		// Token: 0x060005BC RID: 1468
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x36F02F0", Offset = "0x36EEEF0", VA = "0x1836F02F0")]
		[PreserveSig]
		private static extern void CRIWAREC30E3A03(ref CriAtomExStandardVoicePool.Config config);

		// Token: 0x020000A4 RID: 164
		[Token(Token = "0x20000A4")]
		public struct Config
		{
			// Token: 0x060005BD RID: 1469 RVA: 0x0000389C File Offset: 0x00001A9C
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x36DEA40", Offset = "0x36DD640", VA = "0x1836DEA40")]
			public static CriAtomExStandardVoicePool.Config Default()
			{
				return default(CriAtomExStandardVoicePool.Config);
			}

			// Token: 0x04000328 RID: 808
			[Token(Token = "0x4000328")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint identifier;

			// Token: 0x04000329 RID: 809
			[Token(Token = "0x4000329")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int numVoices;

			// Token: 0x0400032A RID: 810
			[Token(Token = "0x400032A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public CriAtomExVoicePool.PlayerConfig playerConfig;

			// Token: 0x0400032B RID: 811
			[Token(Token = "0x400032B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isStreamingOnly;

			// Token: 0x0400032C RID: 812
			[Token(Token = "0x400032C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int minChannels;
		}
	}
}
