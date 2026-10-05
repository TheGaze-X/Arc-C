using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037A8 RID: 14248
	[Token(Token = "0x20037A8")]
	public struct SimpleMusicConfig : IUIMusicConfig, IHotfixable
	{
		// Token: 0x060169A3 RID: 92579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60169A3")]
		[Address(RVA = "0xEFC050", Offset = "0xEFAC50", VA = "0x180EFC050", Slot = "4")]
		public string GenerateLocalCacheKey()
		{
			return null;
		}

		// Token: 0x060169A4 RID: 92580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60169A4")]
		[Address(RVA = "0xEFBFB0", Offset = "0xEFABB0", VA = "0x180EFBFB0", Slot = "5")]
		public string DefaultAudioEventName()
		{
			return null;
		}

		// Token: 0x0401B3E0 RID: 111584
		[Token(Token = "0x401B3E0")]
		[FieldOffset(Offset = "0x0")]
		public string localCacheKey;

		// Token: 0x0401B3E1 RID: 111585
		[Token(Token = "0x401B3E1")]
		[FieldOffset(Offset = "0x8")]
		public UIMusicManager.ChunkConfig defaultChunk;

		// Token: 0x0401B3E2 RID: 111586
		[Token(Token = "0x401B3E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenerateLocalCacheKey;

		// Token: 0x0401B3E3 RID: 111587
		[Token(Token = "0x401B3E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DefaultAudioEventName;
	}
}
