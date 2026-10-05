using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x020063D1 RID: 25553
	[Token(Token = "0x20063D1")]
	public class AutoChessServiceTeamInfo
	{
		// Token: 0x17005704 RID: 22276
		// (get) Token: 0x06024D82 RID: 150914 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024D83 RID: 150915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005704")]
		public string teamID
		{
			[Token(Token = "0x6024D82")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024D83")]
			[Address(RVA = "0x1FC11F0", Offset = "0x1FBFDF0", VA = "0x181FC11F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005705 RID: 22277
		// (get) Token: 0x06024D84 RID: 150916 RVA: 0x000C5A18 File Offset: 0x000C3C18
		[Token(Token = "0x17005705")]
		public AutoChessTeamState state
		{
			[Token(Token = "0x6024D84")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return AutoChessTeamState.NONE;
			}
		}

		// Token: 0x17005706 RID: 22278
		// (get) Token: 0x06024D85 RID: 150917 RVA: 0x000C5A30 File Offset: 0x000C3C30
		[Token(Token = "0x17005706")]
		public bool closedTeam
		{
			[Token(Token = "0x6024D85")]
			[Address(RVA = "0x1FC1190", Offset = "0x1FBFD90", VA = "0x181FC1190")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005707 RID: 22279
		// (get) Token: 0x06024D86 RID: 150918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005707")]
		public List<MsgAutoChessPlayerStatus> playerStatus
		{
			[Token(Token = "0x6024D86")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005708 RID: 22280
		// (get) Token: 0x06024D87 RID: 150919 RVA: 0x000C5A48 File Offset: 0x000C3C48
		[Token(Token = "0x17005708")]
		public int playerCnt
		{
			[Token(Token = "0x6024D87")]
			[Address(RVA = "0x1FC11B0", Offset = "0x1FBFDB0", VA = "0x181FC11B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06024D88 RID: 150920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D88")]
		[Address(RVA = "0x1FC1110", Offset = "0x1FBFD10", VA = "0x181FC1110")]
		public void Fill(string teamId, AutoChessTeamStatus newStatus)
		{
		}

		// Token: 0x06024D89 RID: 150921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D89")]
		[Address(RVA = "0x1FC1100", Offset = "0x1FBFD00", VA = "0x181FC1100")]
		public void Clear()
		{
		}

		// Token: 0x06024D8A RID: 150922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D8A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessServiceTeamInfo()
		{
		}

		// Token: 0x04033837 RID: 210999
		[Token(Token = "0x4033837")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessTeamStatus teamStatus;
	}
}
