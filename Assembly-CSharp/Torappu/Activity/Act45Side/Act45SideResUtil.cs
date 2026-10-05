using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act45Side
{
	// Token: 0x020072B2 RID: 29362
	[Token(Token = "0x20072B2")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act45SideResUtil
	{
		// Token: 0x06029915 RID: 170261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029915")]
		[Address(RVA = "0x24FC460", Offset = "0x24FB060", VA = "0x1824FC460")]
		public static Act45SideData GetAct45SideData(string actId)
		{
			return null;
		}

		// Token: 0x06029916 RID: 170262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029916")]
		[Address(RVA = "0x24FC530", Offset = "0x24FB130", VA = "0x1824FC530")]
		public static PlayerActivity.PlayerAct45SideActivity GetActPlayerData(string actId)
		{
			return null;
		}

		// Token: 0x06029917 RID: 170263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029917")]
		[Address(RVA = "0x24FC770", Offset = "0x24FB370", VA = "0x1824FC770")]
		public static Sprite LoadMailImg(string picId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06029918 RID: 170264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029918")]
		[Address(RVA = "0x24FC670", Offset = "0x24FB270", VA = "0x1824FC670")]
		public static Sprite LoadCharCardImg(string picId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0403B6FD RID: 243453
		[Token(Token = "0x403B6FD")]
		public const string LIVE_PAGE = "mujica_live_page";

		// Token: 0x0403B6FE RID: 243454
		[Token(Token = "0x403B6FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAct45SideData;

		// Token: 0x0403B6FF RID: 243455
		[Token(Token = "0x403B6FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetActPlayerData;

		// Token: 0x0403B700 RID: 243456
		[Token(Token = "0x403B700")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadMailImg;

		// Token: 0x0403B701 RID: 243457
		[Token(Token = "0x403B701")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadCharCardImg;
	}
}
