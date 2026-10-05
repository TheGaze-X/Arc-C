using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000A5 RID: 165
	[Token(Token = "0x20000A5")]
	public class CriAtomExWaveVoicePool : CriAtomExVoicePool
	{
		// Token: 0x060005BE RID: 1470 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x36F1D00", Offset = "0x36F0900", VA = "0x1836F1D00")]
		public static void SetDefaultConfigForWaveVoicePool(ref CriAtomExWaveVoicePool.Config config)
		{
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x36F2010", Offset = "0x36F0C10", VA = "0x1836F2010")]
		public CriAtomExWaveVoicePool(CriAtomExWaveVoicePool.Config config)
		{
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x36F1E50", Offset = "0x36F0A50", VA = "0x1836F1E50")]
		public CriAtomExWaveVoicePool(int numVoices, int maxChannels, int maxSamplingRate, bool streamingFlag, uint identifier = 0U)
		{
		}

		// Token: 0x060005C1 RID: 1473
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x36F2120", Offset = "0x36F0D20", VA = "0x1836F2120")]
		[PreserveSig]
		private static extern IntPtr criAtomExVoicePool_AllocateWaveVoicePool(ref CriAtomExWaveVoicePool.Config config, IntPtr work, int work_size);

		// Token: 0x060005C2 RID: 1474
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x36F1D00", Offset = "0x36F0900", VA = "0x1836F1D00")]
		[PreserveSig]
		private static extern void CRIWARE5C13B6E7(ref CriAtomExWaveVoicePool.Config config);

		// Token: 0x020000A6 RID: 166
		[Token(Token = "0x20000A6")]
		public struct Config
		{
			// Token: 0x060005C3 RID: 1475 RVA: 0x000038B4 File Offset: 0x00001AB4
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x36DEBA0", Offset = "0x36DD7A0", VA = "0x1836DEBA0")]
			public static CriAtomExWaveVoicePool.Config Default()
			{
				return default(CriAtomExWaveVoicePool.Config);
			}

			// Token: 0x0400032D RID: 813
			[Token(Token = "0x400032D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint identifier;

			// Token: 0x0400032E RID: 814
			[Token(Token = "0x400032E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int numVoices;

			// Token: 0x0400032F RID: 815
			[Token(Token = "0x400032F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public CriAtomExVoicePool.PlayerConfig playerConfig;

			// Token: 0x04000330 RID: 816
			[Token(Token = "0x4000330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isStreamingOnly;

			// Token: 0x04000331 RID: 817
			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int minChannels;
		}
	}
}
