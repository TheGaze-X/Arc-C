using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x020072F2 RID: 29426
	[Token(Token = "0x20072F2")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act42sideResUtil
	{
		// Token: 0x06029A41 RID: 170561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A41")]
		[Address(RVA = "0x2519760", Offset = "0x2518360", VA = "0x182519760")]
		public static Act42SideData GetAct42SideData(string actId)
		{
			return null;
		}

		// Token: 0x06029A42 RID: 170562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A42")]
		[Address(RVA = "0x2519830", Offset = "0x2518430", VA = "0x182519830")]
		public static PlayerActivity.PlayerAct42SideActivity GetActPlayerData(string actId)
		{
			return null;
		}

		// Token: 0x06029A43 RID: 170563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A43")]
		[Address(RVA = "0x2519E90", Offset = "0x2518A90", VA = "0x182519E90")]
		public static IEnumerator ReceiveItemsCoroutine(List<RewardItemModel> rewardList, Action onConfirm)
		{
			return null;
		}

		// Token: 0x06029A44 RID: 170564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A44")]
		[Address(RVA = "0x2519DD0", Offset = "0x25189D0", VA = "0x182519DD0")]
		public static void OpenTokenDetailDlg(Act42sideGunTaskPage gunTaskPage)
		{
		}

		// Token: 0x06029A45 RID: 170565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A45")]
		[Address(RVA = "0x2519970", Offset = "0x2518570", VA = "0x182519970")]
		public static string GetArchiveTrackType(string archiveId)
		{
			return null;
		}

		// Token: 0x06029A46 RID: 170566 RVA: 0x000D6200 File Offset: 0x000D4400
		[Token(Token = "0x6029A46")]
		[Address(RVA = "0x2519680", Offset = "0x2518280", VA = "0x182519680")]
		public static bool CheckIfShowArchiveTrackPoint(string archiveId)
		{
			return default(bool);
		}

		// Token: 0x06029A47 RID: 170567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A47")]
		[Address(RVA = "0x2519D40", Offset = "0x2518940", VA = "0x182519D40")]
		public static Sprite LoadTrustorAvatarSmall(string picId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06029A48 RID: 170568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A48")]
		[Address(RVA = "0x2519CB0", Offset = "0x25188B0", VA = "0x182519CB0")]
		public static Sprite LoadItemIcon(string picId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06029A49 RID: 170569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A49")]
		[Address(RVA = "0x2519B00", Offset = "0x2518700", VA = "0x182519B00")]
		public static Sprite LoadCharBg(string picId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06029A4A RID: 170570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A4A")]
		[Address(RVA = "0x2519B90", Offset = "0x2518790", VA = "0x182519B90")]
		public static Sprite LoadGunLargeImg(string picId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06029A4B RID: 170571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A4B")]
		[Address(RVA = "0x25199D0", Offset = "0x25185D0", VA = "0x1825199D0")]
		public static Sprite GetNumIcon(int num, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x06029A4C RID: 170572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A4C")]
		[Address(RVA = "0x2519C20", Offset = "0x2518820", VA = "0x182519C20")]
		public static Sprite LoadGunSmallIcon(string iconId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x06029A4D RID: 170573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A4D")]
		[Address(RVA = "0x2519A70", Offset = "0x2518670", VA = "0x182519A70")]
		public static Sprite GetTrustorAvatarLargeIcon(string iconId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0403B90B RID: 243979
		[Token(Token = "0x403B90B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAct42SideData;

		// Token: 0x0403B90C RID: 243980
		[Token(Token = "0x403B90C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetActPlayerData;

		// Token: 0x0403B90D RID: 243981
		[Token(Token = "0x403B90D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ReceiveItemsCoroutine;

		// Token: 0x0403B90E RID: 243982
		[Token(Token = "0x403B90E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OpenTokenDetailDlg;

		// Token: 0x0403B90F RID: 243983
		[Token(Token = "0x403B90F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetArchiveTrackType;

		// Token: 0x0403B910 RID: 243984
		[Token(Token = "0x403B910")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckIfShowArchiveTrackPoint;

		// Token: 0x0403B911 RID: 243985
		[Token(Token = "0x403B911")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadTrustorAvatarSmall;

		// Token: 0x0403B912 RID: 243986
		[Token(Token = "0x403B912")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadItemIcon;

		// Token: 0x0403B913 RID: 243987
		[Token(Token = "0x403B913")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadCharBg;

		// Token: 0x0403B914 RID: 243988
		[Token(Token = "0x403B914")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadGunLargeImg;

		// Token: 0x0403B915 RID: 243989
		[Token(Token = "0x403B915")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetNumIcon;

		// Token: 0x0403B916 RID: 243990
		[Token(Token = "0x403B916")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadGunSmallIcon;

		// Token: 0x0403B917 RID: 243991
		[Token(Token = "0x403B917")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetTrustorAvatarLargeIcon;
	}
}
