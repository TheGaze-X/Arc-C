using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001B5 RID: 437
	[Token(Token = "0x20001B5")]
	[Serializable]
	public struct CGameID : IEquatable<CGameID>, IComparable<CGameID>
	{
		// Token: 0x060009D9 RID: 2521 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public CGameID(ulong GameID)
		{
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x4ED7B60", Offset = "0x4ED6760", VA = "0x184ED7B60")]
		public CGameID(AppId_t nAppID)
		{
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x4ED7AE0", Offset = "0x4ED66E0", VA = "0x184ED7AE0")]
		public CGameID(AppId_t nAppID, uint nModID)
		{
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00008594 File Offset: 0x00006794
		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x4ED7840", Offset = "0x4ED6440", VA = "0x184ED7840")]
		public bool IsSteamApp()
		{
			return default(bool);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x000085AC File Offset: 0x000067AC
		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x4ED7810", Offset = "0x4ED6410", VA = "0x184ED7810")]
		public bool IsMod()
		{
			return default(bool);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x000085C4 File Offset: 0x000067C4
		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x4ED7830", Offset = "0x4ED6430", VA = "0x184ED7830")]
		public bool IsShortcut()
		{
			return default(bool);
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x000085DC File Offset: 0x000067DC
		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x4ED7820", Offset = "0x4ED6420", VA = "0x184ED7820")]
		public bool IsP2PFile()
		{
			return default(bool);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x000085F4 File Offset: 0x000067F4
		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x4ED7760", Offset = "0x4ED6360", VA = "0x184ED7760")]
		public AppId_t AppID()
		{
			return default(AppId_t);
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0000860C File Offset: 0x0000680C
		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x4ED7AD0", Offset = "0x4ED66D0", VA = "0x184ED7AD0")]
		public CGameID.EGameIDType Type()
		{
			return CGameID.EGameIDType.k_EGameIDTypeApp;
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00008624 File Offset: 0x00006824
		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x4ED7A00", Offset = "0x4ED6600", VA = "0x184ED7A00")]
		public uint ModID()
		{
			return 0U;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0000863C File Offset: 0x0000683C
		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x4ED7850", Offset = "0x4ED6450", VA = "0x184ED7850")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x4BFAB30", Offset = "0x4BF9730", VA = "0x184BFAB30")]
		public void Reset()
		{
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public void Set(ulong GameID)
		{
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x4ED7A10", Offset = "0x4ED6610", VA = "0x184ED7A10")]
		private void SetAppID(AppId_t other)
		{
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x4ED7AA0", Offset = "0x4ED66A0", VA = "0x184ED7AA0")]
		private void SetType(CGameID.EGameIDType other)
		{
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x4ED7A80", Offset = "0x4ED6680", VA = "0x184ED7A80")]
		private void SetModID(uint other)
		{
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x4ED7AC0", Offset = "0x4ED66C0", VA = "0x184ED7AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00008654 File Offset: 0x00006854
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x4ED7770", Offset = "0x4ED6370", VA = "0x184ED7770", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x0000866C File Offset: 0x0000686C
		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x4ED7800", Offset = "0x4ED6400", VA = "0x184ED7800", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00008684 File Offset: 0x00006884
		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(CGameID x, CGameID y)
		{
			return default(bool);
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0000869C File Offset: 0x0000689C
		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x4D00430", Offset = "0x4CFF030", VA = "0x184D00430")]
		public static bool operator !=(CGameID x, CGameID y)
		{
			return default(bool);
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x000086B4 File Offset: 0x000068B4
		[Token(Token = "0x60009EE")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator CGameID(ulong value)
		{
			return default(CGameID);
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x000086CC File Offset: 0x000068CC
		[Token(Token = "0x60009EF")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator ulong(CGameID that)
		{
			return 0UL;
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x000086E4 File Offset: 0x000068E4
		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "4")]
		public bool Equals(CGameID other)
		{
			return default(bool);
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x000086FC File Offset: 0x000068FC
		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x35366D0", Offset = "0x35352D0", VA = "0x1835366D0", Slot = "5")]
		public int CompareTo(CGameID other)
		{
			return 0;
		}

		// Token: 0x04000ABF RID: 2751
		[Token(Token = "0x4000ABF")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_GameID;

		// Token: 0x020001B6 RID: 438
		[Token(Token = "0x20001B6")]
		public enum EGameIDType
		{
			// Token: 0x04000AC1 RID: 2753
			[Token(Token = "0x4000AC1")]
			k_EGameIDTypeApp,
			// Token: 0x04000AC2 RID: 2754
			[Token(Token = "0x4000AC2")]
			k_EGameIDTypeGameMod,
			// Token: 0x04000AC3 RID: 2755
			[Token(Token = "0x4000AC3")]
			k_EGameIDTypeShortcut,
			// Token: 0x04000AC4 RID: 2756
			[Token(Token = "0x4000AC4")]
			k_EGameIDTypeP2P
		}
	}
}
