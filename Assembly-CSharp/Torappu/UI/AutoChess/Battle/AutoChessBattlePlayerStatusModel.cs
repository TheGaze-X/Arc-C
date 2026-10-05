using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064EB RID: 25835
	[Token(Token = "0x20064EB")]
	public class AutoChessBattlePlayerStatusModel : IHotfixable
	{
		// Token: 0x17005792 RID: 22418
		// (get) Token: 0x060251EE RID: 152046 RVA: 0x000C6930 File Offset: 0x000C4B30
		[Token(Token = "0x17005792")]
		public SeqNumSource hpSeqSrc
		{
			[Token(Token = "0x60251EE")]
			[Address(RVA = "0x2013D20", Offset = "0x2012920", VA = "0x182013D20")]
			get
			{
				return default(SeqNumSource);
			}
		}

		// Token: 0x17005793 RID: 22419
		// (get) Token: 0x060251EF RID: 152047 RVA: 0x000C6948 File Offset: 0x000C4B48
		// (set) Token: 0x060251F0 RID: 152048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005793")]
		public PlayerAvatarQuery avatarQuery
		{
			[Token(Token = "0x60251EF")]
			[Address(RVA = "0x2013BF0", Offset = "0x20127F0", VA = "0x182013BF0")]
			[CompilerGenerated]
			get
			{
				return default(PlayerAvatarQuery);
			}
			[Token(Token = "0x60251F0")]
			[Address(RVA = "0x20142C0", Offset = "0x2012EC0", VA = "0x1820142C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005794 RID: 22420
		// (get) Token: 0x060251F1 RID: 152049 RVA: 0x000C6960 File Offset: 0x000C4B60
		// (set) Token: 0x060251F2 RID: 152050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005794")]
		public int hp
		{
			[Token(Token = "0x60251F1")]
			[Address(RVA = "0x2013DA0", Offset = "0x20129A0", VA = "0x182013DA0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60251F2")]
			[Address(RVA = "0x2014350", Offset = "0x2012F50", VA = "0x182014350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005795 RID: 22421
		// (get) Token: 0x060251F3 RID: 152051 RVA: 0x000C6978 File Offset: 0x000C4B78
		// (set) Token: 0x060251F4 RID: 152052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005795")]
		public bool isDead
		{
			[Token(Token = "0x60251F3")]
			[Address(RVA = "0x2013EE0", Offset = "0x2012AE0", VA = "0x182013EE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60251F4")]
			[Address(RVA = "0x2014430", Offset = "0x2013030", VA = "0x182014430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005796 RID: 22422
		// (get) Token: 0x060251F5 RID: 152053 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060251F6 RID: 152054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005796")]
		public string nickName
		{
			[Token(Token = "0x60251F5")]
			[Address(RVA = "0x2014120", Offset = "0x2012D20", VA = "0x182014120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60251F6")]
			[Address(RVA = "0x20144A0", Offset = "0x20130A0", VA = "0x1820144A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005797 RID: 22423
		// (get) Token: 0x060251F7 RID: 152055 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060251F8 RID: 152056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005797")]
		public string nickNumber
		{
			[Token(Token = "0x60251F7")]
			[Address(RVA = "0x2014180", Offset = "0x2012D80", VA = "0x182014180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60251F8")]
			[Address(RVA = "0x2014520", Offset = "0x2013120", VA = "0x182014520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005798 RID: 22424
		// (get) Token: 0x060251F9 RID: 152057 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060251FA RID: 152058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005798")]
		public string uid
		{
			[Token(Token = "0x60251F9")]
			[Address(RVA = "0x2014260", Offset = "0x2012E60", VA = "0x182014260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60251FA")]
			[Address(RVA = "0x20145A0", Offset = "0x20131A0", VA = "0x1820145A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005799 RID: 22425
		// (get) Token: 0x060251FB RID: 152059 RVA: 0x000C6990 File Offset: 0x000C4B90
		// (set) Token: 0x060251FC RID: 152060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005799")]
		public int index
		{
			[Token(Token = "0x60251FB")]
			[Address(RVA = "0x2013E00", Offset = "0x2012A00", VA = "0x182013E00")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60251FC")]
			[Address(RVA = "0x20143C0", Offset = "0x2012FC0", VA = "0x1820143C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700579A RID: 22426
		// (get) Token: 0x060251FD RID: 152061 RVA: 0x000C69A8 File Offset: 0x000C4BA8
		[Token(Token = "0x1700579A")]
		public bool deadOrQuit
		{
			[Token(Token = "0x60251FD")]
			[Address(RVA = "0x2013C70", Offset = "0x2012870", VA = "0x182013C70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700579B RID: 22427
		// (get) Token: 0x060251FE RID: 152062 RVA: 0x000C69C0 File Offset: 0x000C4BC0
		[Token(Token = "0x1700579B")]
		public bool isReconnect
		{
			[Token(Token = "0x60251FE")]
			[Address(RVA = "0x2014070", Offset = "0x2012C70", VA = "0x182014070")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700579C RID: 22428
		// (get) Token: 0x060251FF RID: 152063 RVA: 0x000C69D8 File Offset: 0x000C4BD8
		[Token(Token = "0x1700579C")]
		public bool isQuit
		{
			[Token(Token = "0x60251FF")]
			[Address(RVA = "0x2013FC0", Offset = "0x2012BC0", VA = "0x182013FC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700579D RID: 22429
		// (get) Token: 0x06025200 RID: 152064 RVA: 0x000C69F0 File Offset: 0x000C4BF0
		[Token(Token = "0x1700579D")]
		public bool showHp
		{
			[Token(Token = "0x6025200")]
			[Address(RVA = "0x20141E0", Offset = "0x2012DE0", VA = "0x1820141E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700579E RID: 22430
		// (get) Token: 0x06025201 RID: 152065 RVA: 0x000C6A08 File Offset: 0x000C4C08
		[Token(Token = "0x1700579E")]
		public bool isMoving
		{
			[Token(Token = "0x6025201")]
			[Address(RVA = "0x2013F40", Offset = "0x2012B40", VA = "0x182013F40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700579F RID: 22431
		// (get) Token: 0x06025202 RID: 152066 RVA: 0x000C6A20 File Offset: 0x000C4C20
		[Token(Token = "0x1700579F")]
		public bool isComplete
		{
			[Token(Token = "0x6025202")]
			[Address(RVA = "0x2013E60", Offset = "0x2012A60", VA = "0x182013E60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06025203 RID: 152067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025203")]
		[Address(RVA = "0x2013780", Offset = "0x2012380", VA = "0x182013780")]
		public void LoadData(AutoChessPlayerDataModel.ScenePlayerData playerInfo, AutoChessBattlePlayerStatusGroupModel.ActionState theActionState, bool inBossRound)
		{
		}

		// Token: 0x06025204 RID: 152068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025204")]
		[Address(RVA = "0x2013B70", Offset = "0x2012770", VA = "0x182013B70")]
		public AutoChessBattlePlayerStatusModel()
		{
		}

		// Token: 0x04034082 RID: 213122
		[Token(Token = "0x4034082")]
		[FieldOffset(Offset = "0x10")]
		private AutoChessBattlePlayerStatusGroupModel.ActionState m_actionState;

		// Token: 0x04034083 RID: 213123
		[Token(Token = "0x4034083")]
		[FieldOffset(Offset = "0x14")]
		private AutoChessPlayerConnectStateType m_connectState;

		// Token: 0x04034084 RID: 213124
		[Token(Token = "0x4034084")]
		[FieldOffset(Offset = "0x18")]
		private SeqNumSource m_hpSeqSrc;

		// Token: 0x04034085 RID: 213125
		[Token(Token = "0x4034085")]
		[FieldOffset(Offset = "0x24")]
		private bool m_inBossRound;

		// Token: 0x0403408D RID: 213133
		[Token(Token = "0x403408D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hpSeqSrc;

		// Token: 0x0403408E RID: 213134
		[Token(Token = "0x403408E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_avatarQuery;

		// Token: 0x0403408F RID: 213135
		[Token(Token = "0x403408F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_avatarQuery;

		// Token: 0x04034090 RID: 213136
		[Token(Token = "0x4034090")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_hp;

		// Token: 0x04034091 RID: 213137
		[Token(Token = "0x4034091")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_hp;

		// Token: 0x04034092 RID: 213138
		[Token(Token = "0x4034092")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isDead;

		// Token: 0x04034093 RID: 213139
		[Token(Token = "0x4034093")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_isDead;

		// Token: 0x04034094 RID: 213140
		[Token(Token = "0x4034094")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_nickName;

		// Token: 0x04034095 RID: 213141
		[Token(Token = "0x4034095")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_nickName;

		// Token: 0x04034096 RID: 213142
		[Token(Token = "0x4034096")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_nickNumber;

		// Token: 0x04034097 RID: 213143
		[Token(Token = "0x4034097")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_nickNumber;

		// Token: 0x04034098 RID: 213144
		[Token(Token = "0x4034098")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_uid;

		// Token: 0x04034099 RID: 213145
		[Token(Token = "0x4034099")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_uid;

		// Token: 0x0403409A RID: 213146
		[Token(Token = "0x403409A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_index;

		// Token: 0x0403409B RID: 213147
		[Token(Token = "0x403409B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_index;

		// Token: 0x0403409C RID: 213148
		[Token(Token = "0x403409C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_deadOrQuit;

		// Token: 0x0403409D RID: 213149
		[Token(Token = "0x403409D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_isReconnect;

		// Token: 0x0403409E RID: 213150
		[Token(Token = "0x403409E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_isQuit;

		// Token: 0x0403409F RID: 213151
		[Token(Token = "0x403409F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_showHp;

		// Token: 0x040340A0 RID: 213152
		[Token(Token = "0x40340A0")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_isMoving;

		// Token: 0x040340A1 RID: 213153
		[Token(Token = "0x40340A1")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_isComplete;

		// Token: 0x040340A2 RID: 213154
		[Token(Token = "0x40340A2")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040340A3 RID: 213155
		[Token(Token = "0x40340A3")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
