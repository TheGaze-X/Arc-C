using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D4B RID: 7499
	[Token(Token = "0x2001D4B")]
	public class BuildingMusicPlayerStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0600B92E RID: 47406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B92E")]
		[Address(RVA = "0x3362B10", Offset = "0x3361710", VA = "0x183362B10")]
		public void InitData()
		{
		}

		// Token: 0x0600B92F RID: 47407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B92F")]
		[Address(RVA = "0x3362ED0", Offset = "0x3361AD0", VA = "0x183362ED0")]
		public void RefreshData()
		{
		}

		// Token: 0x0600B930 RID: 47408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B930")]
		[Address(RVA = "0x3362D40", Offset = "0x3361940", VA = "0x183362D40")]
		public void InitDefaultModeData()
		{
		}

		// Token: 0x0600B931 RID: 47409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B931")]
		[Address(RVA = "0x3362E10", Offset = "0x3361A10", VA = "0x183362E10")]
		public void InitVisitModeData()
		{
		}

		// Token: 0x0600B932 RID: 47410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B932")]
		[Address(RVA = "0x3363050", Offset = "0x3361C50", VA = "0x183363050")]
		public void RefreshDefaultModeData()
		{
		}

		// Token: 0x0600B933 RID: 47411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B933")]
		[Address(RVA = "0x3362A50", Offset = "0x3361650", VA = "0x183362A50")]
		public void ChangeSortOrder()
		{
		}

		// Token: 0x0600B934 RID: 47412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B934")]
		[Address(RVA = "0x3363100", Offset = "0x3361D00", VA = "0x183363100")]
		public void SetPlayingMusic(string bgmId)
		{
		}

		// Token: 0x0600B935 RID: 47413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B935")]
		[Address(RVA = "0x33631E0", Offset = "0x3361DE0", VA = "0x1833631E0")]
		public BuildingMusicPlayerStateBean()
		{
		}

		// Token: 0x0400B76E RID: 46958
		[Token(Token = "0x400B76E")]
		[FieldOffset(Offset = "0x10")]
		public MusicPlayerProperty musicPlayerProp;

		// Token: 0x0400B76F RID: 46959
		[Token(Token = "0x400B76F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0400B770 RID: 46960
		[Token(Token = "0x400B770")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0400B771 RID: 46961
		[Token(Token = "0x400B771")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitDefaultModeData;

		// Token: 0x0400B772 RID: 46962
		[Token(Token = "0x400B772")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitVisitModeData;

		// Token: 0x0400B773 RID: 46963
		[Token(Token = "0x400B773")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RefreshDefaultModeData;

		// Token: 0x0400B774 RID: 46964
		[Token(Token = "0x400B774")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ChangeSortOrder;

		// Token: 0x0400B775 RID: 46965
		[Token(Token = "0x400B775")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetPlayingMusic;

		// Token: 0x0400B776 RID: 46966
		[Token(Token = "0x400B776")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
