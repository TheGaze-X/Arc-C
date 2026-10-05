using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000A7 RID: 167
	[Token(Token = "0x20000A7")]
	public class CriAtomExRawPcmVoicePool : CriAtomExVoicePool
	{
		// Token: 0x060005C4 RID: 1476 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x36EF870", Offset = "0x36EE470", VA = "0x1836EF870")]
		public CriAtomExRawPcmVoicePool(int numVoices, int maxChannels, int maxSamplingRate, CriAtomExRawPcmVoicePool.RawPcmFormat format, uint identifier = 0U)
		{
		}

		// Token: 0x060005C5 RID: 1477
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x36EFAA0", Offset = "0x36EE6A0", VA = "0x1836EFAA0")]
		[PreserveSig]
		private static extern IntPtr criAtomExVoicePool_AllocateRawPcmVoicePool(ref CriAtomExRawPcmVoicePool.RawPcmVoicePoolConfig config, IntPtr work, int work_size);

		// Token: 0x020000A8 RID: 168
		[Token(Token = "0x20000A8")]
		public enum RawPcmFormat
		{
			// Token: 0x04000333 RID: 819
			[Token(Token = "0x4000333")]
			Sint16,
			// Token: 0x04000334 RID: 820
			[Token(Token = "0x4000334")]
			Float32
		}

		// Token: 0x020000A9 RID: 169
		[Token(Token = "0x20000A9")]
		protected struct RawPcmPlayerConfig
		{
			// Token: 0x04000335 RID: 821
			[Token(Token = "0x4000335")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CriAtomExRawPcmVoicePool.RawPcmFormat format;

			// Token: 0x04000336 RID: 822
			[Token(Token = "0x4000336")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int maxChannels;

			// Token: 0x04000337 RID: 823
			[Token(Token = "0x4000337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int maxSamplingRate;

			// Token: 0x04000338 RID: 824
			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int soundRendererType;

			// Token: 0x04000339 RID: 825
			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int decodeLatency;

			// Token: 0x0400033A RID: 826
			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private IntPtr context;
		}

		// Token: 0x020000AA RID: 170
		[Token(Token = "0x20000AA")]
		protected struct RawPcmVoicePoolConfig
		{
			// Token: 0x0400033B RID: 827
			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint identifier;

			// Token: 0x0400033C RID: 828
			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int numVoices;

			// Token: 0x0400033D RID: 829
			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public CriAtomExRawPcmVoicePool.RawPcmPlayerConfig playerConfig;
		}
	}
}
