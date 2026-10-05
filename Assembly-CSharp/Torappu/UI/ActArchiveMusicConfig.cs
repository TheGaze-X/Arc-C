using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037AB RID: 14251
	[Token(Token = "0x20037AB")]
	public struct ActArchiveMusicConfig : IUIMusicConfig, IHotfixable
	{
		// Token: 0x060169AB RID: 92587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169AB")]
		[Address(RVA = "0xEEF210", Offset = "0xEEDE10", VA = "0x180EEF210")]
		public ActArchiveMusicConfig(string actId)
		{
		}

		// Token: 0x060169AC RID: 92588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60169AC")]
		[Address(RVA = "0xEEF190", Offset = "0xEEDD90", VA = "0x180EEF190", Slot = "4")]
		public string GenerateLocalCacheKey()
		{
			return null;
		}

		// Token: 0x060169AD RID: 92589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60169AD")]
		[Address(RVA = "0xEEF0E0", Offset = "0xEEDCE0", VA = "0x180EEF0E0", Slot = "5")]
		public string DefaultAudioEventName()
		{
			return null;
		}

		// Token: 0x0401B3F2 RID: 111602
		[Token(Token = "0x401B3F2")]
		private const string CACHE_KEY = "archive_music_config_{0}";

		// Token: 0x0401B3F3 RID: 111603
		[Token(Token = "0x401B3F3")]
		[FieldOffset(Offset = "0x0")]
		private string m_actId;

		// Token: 0x0401B3F4 RID: 111604
		[Token(Token = "0x401B3F4")]
		[FieldOffset(Offset = "0x8")]
		private string m_localCacheKey;

		// Token: 0x0401B3F5 RID: 111605
		[Token(Token = "0x401B3F5")]
		[FieldOffset(Offset = "0x10")]
		private UIMusicManager.ChunkConfig m_defaultChunk;

		// Token: 0x0401B3F6 RID: 111606
		[Token(Token = "0x401B3F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401B3F7 RID: 111607
		[Token(Token = "0x401B3F7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateLocalCacheKey;

		// Token: 0x0401B3F8 RID: 111608
		[Token(Token = "0x401B3F8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DefaultAudioEventName;
	}
}
