using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001B7 RID: 439
	[Token(Token = "0x20001B7")]
	[Serializable]
	public struct CSteamID : IEquatable<CSteamID>, IComparable<CSteamID>
	{
		// Token: 0x060009F2 RID: 2546 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x4EDB060", Offset = "0x4ED9C60", VA = "0x184EDB060")]
		public CSteamID(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x4EDB0F0", Offset = "0x4ED9CF0", VA = "0x184EDB0F0")]
		public CSteamID(AccountID_t unAccountID, uint unAccountInstance, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		public CSteamID(ulong ulSteamID)
		{
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x4EDAD30", Offset = "0x4ED9930", VA = "0x184EDAD30")]
		public void Set(AccountID_t unAccountID, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x4EDA8E0", Offset = "0x4ED94E0", VA = "0x184EDA8E0")]
		public void InstancedSet(AccountID_t unAccountID, uint unInstance, EUniverse eUniverse, EAccountType eAccountType)
		{
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x4BFAB30", Offset = "0x4BF9730", VA = "0x184BFAB30")]
		public void Clear()
		{
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x4EDA6D0", Offset = "0x4ED92D0", VA = "0x184EDA6D0")]
		public void CreateBlankAnonLogon(EUniverse eUniverse)
		{
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x4EDA770", Offset = "0x4ED9370", VA = "0x184EDA770")]
		public void CreateBlankAnonUserLogon(EUniverse eUniverse)
		{
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00008714 File Offset: 0x00006914
		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x4EDA370", Offset = "0x4ED8F70", VA = "0x184EDA370")]
		public bool BBlankAnonAccount()
		{
			return default(bool);
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0000872C File Offset: 0x0000692C
		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x4EDA580", Offset = "0x4ED9180", VA = "0x184EDA580")]
		public bool BGameServerAccount()
		{
			return default(bool);
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00008744 File Offset: 0x00006944
		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x4EDA680", Offset = "0x4ED9280", VA = "0x184EDA680")]
		public bool BPersistentGameServerAccount()
		{
			return default(bool);
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0000875C File Offset: 0x0000695C
		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x4EDA2D0", Offset = "0x4ED8ED0", VA = "0x184EDA2D0")]
		public bool BAnonGameServerAccount()
		{
			return default(bool);
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00008774 File Offset: 0x00006974
		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x4EDA530", Offset = "0x4ED9130", VA = "0x184EDA530")]
		public bool BContentServerAccount()
		{
			return default(bool);
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0000878C File Offset: 0x0000698C
		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x4EDA490", Offset = "0x4ED9090", VA = "0x184EDA490")]
		public bool BClanAccount()
		{
			return default(bool);
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x000087A4 File Offset: 0x000069A4
		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x4EDA440", Offset = "0x4ED9040", VA = "0x184EDA440")]
		public bool BChatAccount()
		{
			return default(bool);
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x000087BC File Offset: 0x000069BC
		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x4EDA9B0", Offset = "0x4ED95B0", VA = "0x184EDA9B0")]
		public bool IsLobby()
		{
			return default(bool);
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x000087D4 File Offset: 0x000069D4
		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x4EDA600", Offset = "0x4ED9200", VA = "0x184EDA600")]
		public bool BIndividualAccount()
		{
			return default(bool);
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x000087EC File Offset: 0x000069EC
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x4EDA250", Offset = "0x4ED8E50", VA = "0x184EDA250")]
		public bool BAnonAccount()
		{
			return default(bool);
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00008804 File Offset: 0x00006A04
		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x4EDA320", Offset = "0x4ED8F20", VA = "0x184EDA320")]
		public bool BAnonUserAccount()
		{
			return default(bool);
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x0000881C File Offset: 0x00006A1C
		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x4EDA4E0", Offset = "0x4ED90E0", VA = "0x184EDA4E0")]
		public bool BConsoleUserAccount()
		{
			return default(bool);
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x4EDAC60", Offset = "0x4ED9860", VA = "0x184EDAC60")]
		public void SetAccountID(AccountID_t other)
		{
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x4EDACD0", Offset = "0x4ED98D0", VA = "0x184EDACD0")]
		public void SetAccountInstance(uint other)
		{
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x4EDACF0", Offset = "0x4ED98F0", VA = "0x184EDACF0")]
		public void SetEAccountType(EAccountType other)
		{
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x4EDAD10", Offset = "0x4ED9910", VA = "0x184EDAD10")]
		public void SetEUniverse(EUniverse other)
		{
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00008834 File Offset: 0x00006A34
		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
		public AccountID_t GetAccountID()
		{
			return default(AccountID_t);
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x0000884C File Offset: 0x00006A4C
		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x4EDA8D0", Offset = "0x4ED94D0", VA = "0x184EDA8D0")]
		public uint GetUnAccountInstance()
		{
			return 0U;
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00008864 File Offset: 0x00006A64
		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x4EDA8B0", Offset = "0x4ED94B0", VA = "0x184EDA8B0")]
		public EAccountType GetEAccountType()
		{
			return EAccountType.k_EAccountTypeInvalid;
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x0000887C File Offset: 0x00006A7C
		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x4EDA8C0", Offset = "0x4ED94C0", VA = "0x184EDA8C0")]
		public EUniverse GetEUniverse()
		{
			return EUniverse.k_EUniverseInvalid;
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00008894 File Offset: 0x00006A94
		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x4EDAA30", Offset = "0x4ED9630", VA = "0x184EDAA30")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x4ED7AC0", Offset = "0x4ED66C0", VA = "0x184ED7AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x000088AC File Offset: 0x00006AAC
		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x4EDA810", Offset = "0x4ED9410", VA = "0x184EDA810", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x000088C4 File Offset: 0x00006AC4
		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x4ED7800", Offset = "0x4ED6400", VA = "0x184ED7800", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x000088DC File Offset: 0x00006ADC
		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x3D28B20", Offset = "0x3D27720", VA = "0x183D28B20")]
		public static bool operator ==(CSteamID x, CSteamID y)
		{
			return default(bool);
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x000088F4 File Offset: 0x00006AF4
		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x4EDB180", Offset = "0x4ED9D80", VA = "0x184EDB180")]
		public static bool operator !=(CSteamID x, CSteamID y)
		{
			return default(bool);
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0000890C File Offset: 0x00006B0C
		[Token(Token = "0x6000A14")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator CSteamID(ulong value)
		{
			return default(CSteamID);
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00008924 File Offset: 0x00006B24
		[Token(Token = "0x6000A15")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static explicit operator ulong(CSteamID that)
		{
			return 0UL;
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0000893C File Offset: 0x00006B3C
		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030", Slot = "4")]
		public bool Equals(CSteamID other)
		{
			return default(bool);
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00008954 File Offset: 0x00006B54
		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x35366D0", Offset = "0x35352D0", VA = "0x1835366D0", Slot = "5")]
		public int CompareTo(CSteamID other)
		{
			return 0;
		}

		// Token: 0x04000AC5 RID: 2757
		[Token(Token = "0x4000AC5")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CSteamID Nil;

		// Token: 0x04000AC6 RID: 2758
		[Token(Token = "0x4000AC6")]
		[FieldOffset(Offset = "0x8")]
		public static readonly CSteamID OutofDateGS;

		// Token: 0x04000AC7 RID: 2759
		[Token(Token = "0x4000AC7")]
		[FieldOffset(Offset = "0x10")]
		public static readonly CSteamID LanModeGS;

		// Token: 0x04000AC8 RID: 2760
		[Token(Token = "0x4000AC8")]
		[FieldOffset(Offset = "0x18")]
		public static readonly CSteamID NotInitYetGS;

		// Token: 0x04000AC9 RID: 2761
		[Token(Token = "0x4000AC9")]
		[FieldOffset(Offset = "0x20")]
		public static readonly CSteamID NonSteamGS;

		// Token: 0x04000ACA RID: 2762
		[Token(Token = "0x4000ACA")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_SteamID;
	}
}
