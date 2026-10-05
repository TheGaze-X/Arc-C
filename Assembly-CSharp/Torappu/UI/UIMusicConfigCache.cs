using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037AC RID: 14252
	[Token(Token = "0x20037AC")]
	public class UIMusicConfigCache : Singleton<UIMusicConfigCache>
	{
		// Token: 0x060169AE RID: 92590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169AE")]
		[Address(RVA = "0xEFECF0", Offset = "0xEFD8F0", VA = "0x180EFECF0")]
		private UIMusicConfigCache()
		{
		}

		// Token: 0x060169AF RID: 92591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60169AF")]
		[Address(RVA = "0xEFEBD0", Offset = "0xEFD7D0", VA = "0x180EFEBD0")]
		private MemUserDataStore.Data<UIMusicConfigCache.Content> _GetMemCache()
		{
			return null;
		}

		// Token: 0x060169B0 RID: 92592 RVA: 0x00091F20 File Offset: 0x00090120
		[Token(Token = "0x60169B0")]
		[Address(RVA = "0xEFEA90", Offset = "0xEFD690", VA = "0x180EFEA90")]
		public bool TryGetMusicId(IUIMusicConfig config, out string musicId)
		{
			return default(bool);
		}

		// Token: 0x060169B1 RID: 92593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60169B1")]
		[Address(RVA = "0xEFE940", Offset = "0xEFD540", VA = "0x180EFE940")]
		public void SaveMusicToConfig(IUIMusicConfig config, string musicId)
		{
		}

		// Token: 0x0401B3F9 RID: 111609
		[Token(Token = "0x401B3F9")]
		[FieldOffset(Offset = "0x10")]
		private MemUserDataStore.Data<UIMusicConfigCache.Content> m_memCache;

		// Token: 0x0401B3FA RID: 111610
		[Token(Token = "0x401B3FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401B3FB RID: 111611
		[Token(Token = "0x401B3FB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetMemCache;

		// Token: 0x0401B3FC RID: 111612
		[Token(Token = "0x401B3FC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryGetMusicId;

		// Token: 0x0401B3FD RID: 111613
		[Token(Token = "0x401B3FD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SaveMusicToConfig;

		// Token: 0x020037AD RID: 14253
		[Token(Token = "0x20037AD")]
		private class Content
		{
			// Token: 0x060169B2 RID: 92594 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60169B2")]
			[Address(RVA = "0xEF2DB0", Offset = "0xEF19B0", VA = "0x180EF2DB0")]
			public Content()
			{
			}

			// Token: 0x0401B3FE RID: 111614
			[Token(Token = "0x401B3FE")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, string> keyToMusicId;
		}
	}
}
