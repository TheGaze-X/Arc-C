using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Home;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D4E RID: 7502
	[Token(Token = "0x2001D4E")]
	public class BuildingMusicPlayerViewModel : IHotfixable
	{
		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x0600B937 RID: 47415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700168D")]
		public List<BuildingMusicItemViewModel> musicList
		{
			[Token(Token = "0x600B937")]
			[Address(RVA = "0x3364450", Offset = "0x3363050", VA = "0x183364450")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B938 RID: 47416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B938")]
		[Address(RVA = "0x33632D0", Offset = "0x3361ED0", VA = "0x1833632D0")]
		public void LoadData()
		{
		}

		// Token: 0x0600B939 RID: 47417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B939")]
		[Address(RVA = "0x3363720", Offset = "0x3362320", VA = "0x183363720")]
		public void LoadVisitModeData()
		{
		}

		// Token: 0x0600B93A RID: 47418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B93A")]
		[Address(RVA = "0x3363D80", Offset = "0x3362980", VA = "0x183363D80")]
		public void UpdatePlayerData()
		{
		}

		// Token: 0x0600B93B RID: 47419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B93B")]
		[Address(RVA = "0x3363A30", Offset = "0x3362630", VA = "0x183363A30")]
		public void RefreshMusicStatus()
		{
		}

		// Token: 0x0600B93C RID: 47420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B93C")]
		[Address(RVA = "0x3363CA0", Offset = "0x33628A0", VA = "0x183363CA0")]
		public void RegenerateList()
		{
		}

		// Token: 0x0600B93D RID: 47421 RVA: 0x00045918 File Offset: 0x00043B18
		[Token(Token = "0x600B93D")]
		[Address(RVA = "0x3364280", Offset = "0x3362E80", VA = "0x183364280")]
		private int _CompareByTime(BuildingMusicItemViewModel x, BuildingMusicItemViewModel y)
		{
			return 0;
		}

		// Token: 0x0600B93E RID: 47422 RVA: 0x00045930 File Offset: 0x00043B30
		[Token(Token = "0x600B93E")]
		[Address(RVA = "0x3364070", Offset = "0x3362C70", VA = "0x183364070")]
		private bool _CheckHomeBGDisplay(BuildingData.MusicSingleData musicData, Dictionary<string, PlayerHomeUnlockStatus> homeBgList)
		{
			return default(bool);
		}

		// Token: 0x0600B93F RID: 47423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B93F")]
		[Address(RVA = "0x3364360", Offset = "0x3362F60", VA = "0x183364360")]
		public BuildingMusicPlayerViewModel()
		{
		}

		// Token: 0x0400B785 RID: 46981
		[Token(Token = "0x400B785")]
		private const string MAIN_BG = "MainBG";

		// Token: 0x0400B786 RID: 46982
		[Token(Token = "0x400B786")]
		[FieldOffset(Offset = "0x10")]
		public bool visitMode;

		// Token: 0x0400B787 RID: 46983
		[Token(Token = "0x400B787")]
		[FieldOffset(Offset = "0x18")]
		public string currBgmId;

		// Token: 0x0400B788 RID: 46984
		[Token(Token = "0x400B788")]
		[FieldOffset(Offset = "0x20")]
		public bool sortAscending;

		// Token: 0x0400B789 RID: 46985
		[Token(Token = "0x400B789")]
		[FieldOffset(Offset = "0x28")]
		public string playingBgmId;

		// Token: 0x0400B78A RID: 46986
		[Token(Token = "0x400B78A")]
		[FieldOffset(Offset = "0x30")]
		public string playingBgmName;

		// Token: 0x0400B78B RID: 46987
		[Token(Token = "0x400B78B")]
		[FieldOffset(Offset = "0x38")]
		public string playingBgmDes;

		// Token: 0x0400B78C RID: 46988
		[Token(Token = "0x400B78C")]
		[FieldOffset(Offset = "0x40")]
		public bool playingBgmCanClick;

		// Token: 0x0400B78D RID: 46989
		[Token(Token = "0x400B78D")]
		[FieldOffset(Offset = "0x41")]
		public bool needRebuildList;

		// Token: 0x0400B78E RID: 46990
		[Token(Token = "0x400B78E")]
		[FieldOffset(Offset = "0x44")]
		public int focusIdx;

		// Token: 0x0400B78F RID: 46991
		[Token(Token = "0x400B78F")]
		[FieldOffset(Offset = "0x48")]
		private List<BuildingMusicItemViewModel> m_musicModels;

		// Token: 0x0400B790 RID: 46992
		[Token(Token = "0x400B790")]
		[FieldOffset(Offset = "0x50")]
		private CommonLimitObtainModel m_cachedCommonLimitObtainModel;

		// Token: 0x0400B791 RID: 46993
		[Token(Token = "0x400B791")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_musicList;

		// Token: 0x0400B792 RID: 46994
		[Token(Token = "0x400B792")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0400B793 RID: 46995
		[Token(Token = "0x400B793")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadVisitModeData;

		// Token: 0x0400B794 RID: 46996
		[Token(Token = "0x400B794")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdatePlayerData;

		// Token: 0x0400B795 RID: 46997
		[Token(Token = "0x400B795")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RefreshMusicStatus;

		// Token: 0x0400B796 RID: 46998
		[Token(Token = "0x400B796")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegenerateList;

		// Token: 0x0400B797 RID: 46999
		[Token(Token = "0x400B797")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CompareByTime;

		// Token: 0x0400B798 RID: 47000
		[Token(Token = "0x400B798")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckHomeBGDisplay;

		// Token: 0x0400B799 RID: 47001
		[Token(Token = "0x400B799")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
