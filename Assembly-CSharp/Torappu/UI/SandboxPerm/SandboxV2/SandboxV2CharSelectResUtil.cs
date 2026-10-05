using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004035 RID: 16437
	[Token(Token = "0x2004035")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SandboxV2CharSelectResUtil
	{
		// Token: 0x060196FB RID: 104187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60196FB")]
		[Address(RVA = "0x121FDF0", Offset = "0x121E9F0", VA = "0x18121FDF0")]
		public static SandboxV2CharSelectPluginHolder LoadPluginHolder(SandboxV2AdminCharSelectStateMode state, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060196FC RID: 104188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60196FC")]
		[Address(RVA = "0x121FFE0", Offset = "0x121EBE0", VA = "0x18121FFE0")]
		public static SandboxV2AdminCharSelectRecycleAdapter LoadScrollRect(SandboxV2CharSelectCharCardType type, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060196FD RID: 104189 RVA: 0x0009E040 File Offset: 0x0009C240
		[Token(Token = "0x60196FD")]
		[Address(RVA = "0x121FD70", Offset = "0x121E970", VA = "0x18121FD70")]
		public static SandboxV2CharSelectCharCardType GetLinkCardType(SandboxV2AdminCharSelectStateMode state)
		{
			return SandboxV2CharSelectCharCardType.CHAR_SELECT;
		}

		// Token: 0x0401FAE3 RID: 129763
		[Token(Token = "0x401FAE3")]
		[FieldOffset(Offset = "0x0")]
		public static string SINGLE_SELECT_PATH;

		// Token: 0x0401FAE4 RID: 129764
		[Token(Token = "0x401FAE4")]
		[FieldOffset(Offset = "0x8")]
		public static string MULTI_SELECT_PATH;

		// Token: 0x0401FAE5 RID: 129765
		[Token(Token = "0x401FAE5")]
		[FieldOffset(Offset = "0x10")]
		public static string CHAR_SHOW_PATH;

		// Token: 0x0401FAE6 RID: 129766
		[Token(Token = "0x401FAE6")]
		[FieldOffset(Offset = "0x18")]
		public static string EXPEDITION_SELECT_PATH;

		// Token: 0x0401FAE7 RID: 129767
		[Token(Token = "0x401FAE7")]
		[FieldOffset(Offset = "0x20")]
		public static string SUPPLY_SELECT_PATH;

		// Token: 0x0401FAE8 RID: 129768
		[Token(Token = "0x401FAE8")]
		[FieldOffset(Offset = "0x28")]
		public static string CHAR_SELECT_COMMON_LAYOUT_PATH;

		// Token: 0x0401FAE9 RID: 129769
		[Token(Token = "0x401FAE9")]
		[FieldOffset(Offset = "0x30")]
		public static string CHAR_SELECT_SUPPLY_LAYOUT_PATH;

		// Token: 0x0401FAEA RID: 129770
		[Token(Token = "0x401FAEA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadPluginHolder;

		// Token: 0x0401FAEB RID: 129771
		[Token(Token = "0x401FAEB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadScrollRect;

		// Token: 0x0401FAEC RID: 129772
		[Token(Token = "0x401FAEC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetLinkCardType;
	}
}
