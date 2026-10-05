using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037AA RID: 14250
	[Token(Token = "0x20037AA")]
	public struct SandboxV2ArchiveMusicConfig : IUIMusicConfig, IHotfixable
	{
		// Token: 0x060169A8 RID: 92584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169A8")]
		[Address(RVA = "0xEFBE00", Offset = "0xEFAA00", VA = "0x180EFBE00")]
		public SandboxV2ArchiveMusicConfig(string topicId)
		{
		}

		// Token: 0x060169A9 RID: 92585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60169A9")]
		[Address(RVA = "0xEFBD80", Offset = "0xEFA980", VA = "0x180EFBD80", Slot = "4")]
		public string GenerateLocalCacheKey()
		{
			return null;
		}

		// Token: 0x060169AA RID: 92586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60169AA")]
		[Address(RVA = "0xEFBCD0", Offset = "0xEFA8D0", VA = "0x180EFBCD0", Slot = "5")]
		public string DefaultAudioEventName()
		{
			return null;
		}

		// Token: 0x0401B3EB RID: 111595
		[Token(Token = "0x401B3EB")]
		private const string CACHE_KEY = "archive_music_config_{0}";

		// Token: 0x0401B3EC RID: 111596
		[Token(Token = "0x401B3EC")]
		[FieldOffset(Offset = "0x0")]
		private string m_topicId;

		// Token: 0x0401B3ED RID: 111597
		[Token(Token = "0x401B3ED")]
		[FieldOffset(Offset = "0x8")]
		private string m_localCacheKey;

		// Token: 0x0401B3EE RID: 111598
		[Token(Token = "0x401B3EE")]
		[FieldOffset(Offset = "0x10")]
		private UIMusicManager.ChunkConfig m_defaultChunk;

		// Token: 0x0401B3EF RID: 111599
		[Token(Token = "0x401B3EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401B3F0 RID: 111600
		[Token(Token = "0x401B3F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateLocalCacheKey;

		// Token: 0x0401B3F1 RID: 111601
		[Token(Token = "0x401B3F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DefaultAudioEventName;
	}
}
