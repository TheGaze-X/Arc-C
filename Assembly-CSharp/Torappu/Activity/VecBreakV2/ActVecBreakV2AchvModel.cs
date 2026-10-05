using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DC1 RID: 28097
	[Token(Token = "0x2006DC1")]
	public class ActVecBreakV2AchvModel : IHotfixable
	{
		// Token: 0x17005E85 RID: 24197
		// (get) Token: 0x06028005 RID: 163845 RVA: 0x000D04B8 File Offset: 0x000CE6B8
		// (set) Token: 0x06028006 RID: 163846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E85")]
		public PlayerAvatarQuery avatarQuery
		{
			[Token(Token = "0x6028005")]
			[Address(RVA = "0x2346400", Offset = "0x2345000", VA = "0x182346400")]
			[CompilerGenerated]
			get
			{
				return default(PlayerAvatarQuery);
			}
			[Token(Token = "0x6028006")]
			[Address(RVA = "0x23466D0", Offset = "0x23452D0", VA = "0x1823466D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005E86 RID: 24198
		// (get) Token: 0x06028007 RID: 163847 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028008 RID: 163848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E86")]
		public string playerNickName
		{
			[Token(Token = "0x6028007")]
			[Address(RVA = "0x2346480", Offset = "0x2345080", VA = "0x182346480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028008")]
			[Address(RVA = "0x2346760", Offset = "0x2345360", VA = "0x182346760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005E87 RID: 24199
		// (get) Token: 0x06028009 RID: 163849 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602800A RID: 163850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E87")]
		public string playerNickNumber
		{
			[Token(Token = "0x6028009")]
			[Address(RVA = "0x23464E0", Offset = "0x23450E0", VA = "0x1823464E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602800A")]
			[Address(RVA = "0x23467E0", Offset = "0x23453E0", VA = "0x1823467E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005E88 RID: 24200
		// (get) Token: 0x0602800B RID: 163851 RVA: 0x000D04D0 File Offset: 0x000CE6D0
		[Token(Token = "0x17005E88")]
		public bool showNav
		{
			[Token(Token = "0x602800B")]
			[Address(RVA = "0x2346670", Offset = "0x2345270", VA = "0x182346670")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005E89 RID: 24201
		// (get) Token: 0x0602800C RID: 163852 RVA: 0x000D04E8 File Offset: 0x000CE6E8
		[Token(Token = "0x17005E89")]
		public int seasonCnt
		{
			[Token(Token = "0x602800C")]
			[Address(RVA = "0x2346540", Offset = "0x2345140", VA = "0x182346540")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005E8A RID: 24202
		// (get) Token: 0x0602800D RID: 163853 RVA: 0x000D0500 File Offset: 0x000CE700
		[Token(Token = "0x17005E8A")]
		public int selectIdx
		{
			[Token(Token = "0x602800D")]
			[Address(RVA = "0x23465A0", Offset = "0x23451A0", VA = "0x1823465A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005E8B RID: 24203
		// (get) Token: 0x0602800E RID: 163854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E8B")]
		public ActVecBreakV2AchvSeasonModel selectSeasonModel
		{
			[Token(Token = "0x602800E")]
			[Address(RVA = "0x2346600", Offset = "0x2345200", VA = "0x182346600")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602800F RID: 163855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602800F")]
		[Address(RVA = "0x2345C30", Offset = "0x2344830", VA = "0x182345C30")]
		public void LoadData(Dictionary<string, VecBreakV2SeasonAchvInfo> seasonInfoMap, long currTs)
		{
		}

		// Token: 0x06028010 RID: 163856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028010")]
		[Address(RVA = "0x23460B0", Offset = "0x2344CB0", VA = "0x1823460B0")]
		private void _LoadPlayerInfo()
		{
		}

		// Token: 0x06028011 RID: 163857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028011")]
		[Address(RVA = "0x2345FA0", Offset = "0x2344BA0", VA = "0x182345FA0")]
		public void NavToSeason(bool navToNext)
		{
		}

		// Token: 0x06028012 RID: 163858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028012")]
		[Address(RVA = "0x2346350", Offset = "0x2344F50", VA = "0x182346350")]
		public ActVecBreakV2AchvModel()
		{
		}

		// Token: 0x04038B75 RID: 232309
		[Token(Token = "0x4038B75")]
		[FieldOffset(Offset = "0x10")]
		private List<ActVecBreakV2AchvSeasonModel> m_seasonList;

		// Token: 0x04038B76 RID: 232310
		[Token(Token = "0x4038B76")]
		[FieldOffset(Offset = "0x18")]
		private int m_seasonCnt;

		// Token: 0x04038B77 RID: 232311
		[Token(Token = "0x4038B77")]
		[FieldOffset(Offset = "0x1C")]
		private int m_selectIdx;

		// Token: 0x04038B7B RID: 232315
		[Token(Token = "0x4038B7B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_avatarQuery;

		// Token: 0x04038B7C RID: 232316
		[Token(Token = "0x4038B7C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_avatarQuery;

		// Token: 0x04038B7D RID: 232317
		[Token(Token = "0x4038B7D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_playerNickName;

		// Token: 0x04038B7E RID: 232318
		[Token(Token = "0x4038B7E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_playerNickName;

		// Token: 0x04038B7F RID: 232319
		[Token(Token = "0x4038B7F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_playerNickNumber;

		// Token: 0x04038B80 RID: 232320
		[Token(Token = "0x4038B80")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_playerNickNumber;

		// Token: 0x04038B81 RID: 232321
		[Token(Token = "0x4038B81")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_showNav;

		// Token: 0x04038B82 RID: 232322
		[Token(Token = "0x4038B82")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_seasonCnt;

		// Token: 0x04038B83 RID: 232323
		[Token(Token = "0x4038B83")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_selectIdx;

		// Token: 0x04038B84 RID: 232324
		[Token(Token = "0x4038B84")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_selectSeasonModel;

		// Token: 0x04038B85 RID: 232325
		[Token(Token = "0x4038B85")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04038B86 RID: 232326
		[Token(Token = "0x4038B86")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LoadPlayerInfo;

		// Token: 0x04038B87 RID: 232327
		[Token(Token = "0x4038B87")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_NavToSeason;

		// Token: 0x04038B88 RID: 232328
		[Token(Token = "0x4038B88")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
