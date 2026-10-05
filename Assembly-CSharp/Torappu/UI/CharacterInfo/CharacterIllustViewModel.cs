using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.HandBook;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005EFD RID: 24317
	[Token(Token = "0x2005EFD")]
	public class CharacterIllustViewModel
	{
		// Token: 0x17005351 RID: 21329
		// (get) Token: 0x060233B6 RID: 144310 RVA: 0x000C02D0 File Offset: 0x000BE4D0
		// (set) Token: 0x060233B7 RID: 144311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005351")]
		public CharUISkinStruct selectedSkin
		{
			[Token(Token = "0x60233B6")]
			[Address(RVA = "0x1DBF220", Offset = "0x1DBDE20", VA = "0x181DBF220")]
			get
			{
				return default(CharUISkinStruct);
			}
			[Token(Token = "0x60233B7")]
			[Address(RVA = "0x1DBF300", Offset = "0x1DBDF00", VA = "0x181DBF300")]
			set
			{
			}
		}

		// Token: 0x17005352 RID: 21330
		// (get) Token: 0x060233B8 RID: 144312 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060233B9 RID: 144313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005352")]
		public string charOrNpcId
		{
			[Token(Token = "0x60233B8")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60233B9")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005353 RID: 21331
		// (get) Token: 0x060233BA RID: 144314 RVA: 0x000C02E8 File Offset: 0x000BE4E8
		// (set) Token: 0x060233BB RID: 144315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005353")]
		public EvolvePhase evolvePhase
		{
			[Token(Token = "0x60233BA")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70")]
			[CompilerGenerated]
			get
			{
				return EvolvePhase.PHASE_0;
			}
			[Token(Token = "0x60233BB")]
			[Address(RVA = "0x927040", Offset = "0x925C40", VA = "0x180927040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005354 RID: 21332
		// (get) Token: 0x060233BC RID: 144316 RVA: 0x000C0300 File Offset: 0x000BE500
		[Token(Token = "0x17005354")]
		public bool isNPC
		{
			[Token(Token = "0x60233BC")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005355 RID: 21333
		// (get) Token: 0x060233BD RID: 144317 RVA: 0x000C0318 File Offset: 0x000BE518
		// (set) Token: 0x060233BE RID: 144318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005355")]
		public bool autoActivateIllust
		{
			[Token(Token = "0x60233BD")]
			[Address(RVA = "0x1DBF210", Offset = "0x1DBDE10", VA = "0x181DBF210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60233BE")]
			[Address(RVA = "0x1DBF2F0", Offset = "0x1DBDEF0", VA = "0x181DBF2F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005356 RID: 21334
		// (get) Token: 0x060233BF RID: 144319 RVA: 0x000C0330 File Offset: 0x000BE530
		// (set) Token: 0x060233C0 RID: 144320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005356")]
		public IllustNPCResType illustType
		{
			[Token(Token = "0x60233BF")]
			[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220")]
			[CompilerGenerated]
			get
			{
				return IllustNPCResType.NONE;
			}
			[Token(Token = "0x60233C0")]
			[Address(RVA = "0xE30780", Offset = "0xE2F380", VA = "0x180E30780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060233C1 RID: 144321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233C1")]
		[Address(RVA = "0x1DBEF00", Offset = "0x1DBDB00", VA = "0x181DBEF00")]
		public void LoadDefaultCharData(CharQuery charQuery, CharacterData charData)
		{
		}

		// Token: 0x060233C2 RID: 144322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233C2")]
		[Address(RVA = "0x1DBEEB0", Offset = "0x1DBDAB0", VA = "0x181DBEEB0")]
		public void LoadData(PlayerCharacter playerChar, CharacterData charData, bool autoActivateIllust = true)
		{
		}

		// Token: 0x060233C3 RID: 144323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233C3")]
		[Address(RVA = "0x1DBED30", Offset = "0x1DBD930", VA = "0x181DBED30")]
		public void LoadData(HandBookCardViewModel cardData)
		{
		}

		// Token: 0x060233C4 RID: 144324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233C4")]
		[Address(RVA = "0x1DBEFD0", Offset = "0x1DBDBD0", VA = "0x181DBEFD0")]
		private void _LoadChrDataInternal(int instId, string charId, EvolvePhase evolvePhase, IllustNPCResType resFolder)
		{
		}

		// Token: 0x060233C5 RID: 144325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233C5")]
		[Address(RVA = "0x1DBF090", Offset = "0x1DBDC90", VA = "0x181DBF090")]
		private void _LoadNpcDataInternal(string npcId, string illustId, IllustNPCResType resFolder)
		{
		}

		// Token: 0x060233C6 RID: 144326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233C6")]
		[Address(RVA = "0x1DBF190", Offset = "0x1DBDD90", VA = "0x181DBF190")]
		public CharacterIllustViewModel()
		{
		}

		// Token: 0x040308BC RID: 198844
		[Token(Token = "0x40308BC")]
		[FieldOffset(Offset = "0x10")]
		private CharUISkinStruct m_selectedSkin;

		// Token: 0x040308BD RID: 198845
		[Token(Token = "0x40308BD")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isNPC;

		// Token: 0x040308BE RID: 198846
		[Token(Token = "0x40308BE")]
		[FieldOffset(Offset = "0x2C")]
		private int m_instIdCache;
	}
}
