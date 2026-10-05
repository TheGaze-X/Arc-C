using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037A9 RID: 14249
	[Token(Token = "0x20037A9")]
	public struct RogueArchiveMusicConfig : IUIMusicConfig, IHotfixable
	{
		// Token: 0x060169A5 RID: 92581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169A5")]
		[Address(RVA = "0xEFB840", Offset = "0xEFA440", VA = "0x180EFB840")]
		public RogueArchiveMusicConfig(string topicId)
		{
		}

		// Token: 0x060169A6 RID: 92582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60169A6")]
		[Address(RVA = "0xEFB7C0", Offset = "0xEFA3C0", VA = "0x180EFB7C0", Slot = "4")]
		public string GenerateLocalCacheKey()
		{
			return null;
		}

		// Token: 0x060169A7 RID: 92583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60169A7")]
		[Address(RVA = "0xEFB710", Offset = "0xEFA310", VA = "0x180EFB710", Slot = "5")]
		public string DefaultAudioEventName()
		{
			return null;
		}

		// Token: 0x0401B3E4 RID: 111588
		[Token(Token = "0x401B3E4")]
		private const string CACHE_KEY = "archive_music_config_{0}";

		// Token: 0x0401B3E5 RID: 111589
		[Token(Token = "0x401B3E5")]
		[FieldOffset(Offset = "0x0")]
		private string m_topicId;

		// Token: 0x0401B3E6 RID: 111590
		[Token(Token = "0x401B3E6")]
		[FieldOffset(Offset = "0x8")]
		private string m_localCacheKey;

		// Token: 0x0401B3E7 RID: 111591
		[Token(Token = "0x401B3E7")]
		[FieldOffset(Offset = "0x10")]
		private UIMusicManager.ChunkConfig m_defaultChunk;

		// Token: 0x0401B3E8 RID: 111592
		[Token(Token = "0x401B3E8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401B3E9 RID: 111593
		[Token(Token = "0x401B3E9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateLocalCacheKey;

		// Token: 0x0401B3EA RID: 111594
		[Token(Token = "0x401B3EA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DefaultAudioEventName;
	}
}
