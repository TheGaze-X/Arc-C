using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001B3 RID: 435
	[Token(Token = "0x20001B3")]
	[Serializable]
	[StructLayout(0)]
	public class gameserveritem_t
	{
		// Token: 0x060009BC RID: 2492 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x4F19480", Offset = "0x4F18080", VA = "0x184F19480")]
		public string GetGameDir()
		{
			return null;
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x4F19800", Offset = "0x4F18400", VA = "0x184F19800")]
		public void SetGameDir(string dir)
		{
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x4F195C0", Offset = "0x4F181C0", VA = "0x184F195C0")]
		public string GetMap()
		{
			return null;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x4F19960", Offset = "0x4F18560", VA = "0x184F19960")]
		public void SetMap(string map)
		{
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x4F193E0", Offset = "0x4F17FE0", VA = "0x184F193E0")]
		public string GetGameDescription()
		{
			return null;
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x4F19750", Offset = "0x4F18350", VA = "0x184F19750")]
		public void SetGameDescription(string desc)
		{
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x4F19660", Offset = "0x4F18260", VA = "0x184F19660")]
		public string GetServerName()
		{
			return null;
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x4F19A10", Offset = "0x4F18610", VA = "0x184F19A10")]
		public void SetServerName(string name)
		{
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x4F19520", Offset = "0x4F18120", VA = "0x184F19520")]
		public string GetGameTags()
		{
			return null;
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x4F198B0", Offset = "0x4F184B0", VA = "0x184F198B0")]
		public void SetGameTags(string tags)
		{
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public gameserveritem_t()
		{
		}

		// Token: 0x04000AAA RID: 2730
		[Token(Token = "0x4000AAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public servernetadr_t m_NetAdr;

		// Token: 0x04000AAB RID: 2731
		[Token(Token = "0x4000AAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_nPing;

		// Token: 0x04000AAC RID: 2732
		[Token(Token = "0x4000AAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool m_bHadSuccessfulResponse;

		// Token: 0x04000AAD RID: 2733
		[Token(Token = "0x4000AAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool m_bDoNotRefresh;

		// Token: 0x04000AAE RID: 2734
		[Token(Token = "0x4000AAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private byte[] m_szGameDir;

		// Token: 0x04000AAF RID: 2735
		[Token(Token = "0x4000AAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] m_szMap;

		// Token: 0x04000AB0 RID: 2736
		[Token(Token = "0x4000AB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private byte[] m_szGameDescription;

		// Token: 0x04000AB1 RID: 2737
		[Token(Token = "0x4000AB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public uint m_nAppID;

		// Token: 0x04000AB2 RID: 2738
		[Token(Token = "0x4000AB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int m_nPlayers;

		// Token: 0x04000AB3 RID: 2739
		[Token(Token = "0x4000AB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int m_nMaxPlayers;

		// Token: 0x04000AB4 RID: 2740
		[Token(Token = "0x4000AB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int m_nBotPlayers;

		// Token: 0x04000AB5 RID: 2741
		[Token(Token = "0x4000AB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool m_bPassword;

		// Token: 0x04000AB6 RID: 2742
		[Token(Token = "0x4000AB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool m_bSecure;

		// Token: 0x04000AB7 RID: 2743
		[Token(Token = "0x4000AB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public uint m_ulTimeLastPlayed;

		// Token: 0x04000AB8 RID: 2744
		[Token(Token = "0x4000AB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int m_nServerVersion;

		// Token: 0x04000AB9 RID: 2745
		[Token(Token = "0x4000AB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private byte[] m_szServerName;

		// Token: 0x04000ABA RID: 2746
		[Token(Token = "0x4000ABA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private byte[] m_szGameTags;

		// Token: 0x04000ABB RID: 2747
		[Token(Token = "0x4000ABB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public CSteamID m_steamID;
	}
}
