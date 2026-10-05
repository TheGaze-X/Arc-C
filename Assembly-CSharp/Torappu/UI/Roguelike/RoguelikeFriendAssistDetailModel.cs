using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052E3 RID: 21219
	[Token(Token = "0x20052E3")]
	public class RoguelikeFriendAssistDetailModel
	{
		// Token: 0x1700496D RID: 18797
		// (get) Token: 0x0601F4BF RID: 128191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700496D")]
		public PlayerRoguelikeV2.CurrentData.Recruit.FriendAssistData friendAssistData
		{
			[Token(Token = "0x601F4BF")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700496E RID: 18798
		// (get) Token: 0x0601F4C0 RID: 128192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700496E")]
		public string ticketIndex
		{
			[Token(Token = "0x601F4C0")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700496F RID: 18799
		// (get) Token: 0x0601F4C1 RID: 128193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700496F")]
		public string profession
		{
			[Token(Token = "0x601F4C1")]
			[Address(RVA = "0x1902600", Offset = "0x1901200", VA = "0x181902600")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004970 RID: 18800
		// (get) Token: 0x0601F4C2 RID: 128194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004970")]
		public string assistUid
		{
			[Token(Token = "0x601F4C2")]
			[Address(RVA = "0x19025D0", Offset = "0x19011D0", VA = "0x1819025D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004971 RID: 18801
		// (get) Token: 0x0601F4C3 RID: 128195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004971")]
		public SharedCharData assistCharData
		{
			[Token(Token = "0x601F4C3")]
			[Address(RVA = "0x1902510", Offset = "0x1901110", VA = "0x181902510")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F4C4 RID: 128196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4C4")]
		[Address(RVA = "0x19024C0", Offset = "0x19010C0", VA = "0x1819024C0")]
		public void LoadData(string recruitIndex, ProfessionCategory profession, PlayerRoguelikeV2.CurrentData.Recruit.FriendAssistData assistData)
		{
		}

		// Token: 0x0601F4C5 RID: 128197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4C5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeFriendAssistDetailModel()
		{
		}

		// Token: 0x0402A095 RID: 172181
		[Token(Token = "0x402A095")]
		[FieldOffset(Offset = "0x10")]
		private string m_ticketIndex;

		// Token: 0x0402A096 RID: 172182
		[Token(Token = "0x402A096")]
		[FieldOffset(Offset = "0x18")]
		private ProfessionCategory m_profession;

		// Token: 0x0402A097 RID: 172183
		[Token(Token = "0x402A097")]
		[FieldOffset(Offset = "0x20")]
		private PlayerRoguelikeV2.CurrentData.Recruit.FriendAssistData m_friendAssistData;

		// Token: 0x0402A098 RID: 172184
		[Token(Token = "0x402A098")]
		[FieldOffset(Offset = "0x28")]
		public bool cacheStarFriendTabSelected;
	}
}
