using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D16 RID: 7446
	[Token(Token = "0x2001D16")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class MessageLeaveBoardUtil
	{
		// Token: 0x0600B7CB RID: 47051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B7CB")]
		[Address(RVA = "0x334D0D0", Offset = "0x334BCD0", VA = "0x18334D0D0")]
		private static PlayerBuildingMessageLeave _GetMessageLeaveBoardData()
		{
			return null;
		}

		// Token: 0x0600B7CC RID: 47052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B7CC")]
		[Address(RVA = "0x334CB00", Offset = "0x334B700", VA = "0x18334CB00")]
		public static PlayerBuildingMessageLeave GetTargetPlayerMessageLeaveBoardData(PlayerDataModel playerDataModel)
		{
			return null;
		}

		// Token: 0x0600B7CD RID: 47053 RVA: 0x00045240 File Offset: 0x00043440
		[Token(Token = "0x600B7CD")]
		[Address(RVA = "0x334C8C0", Offset = "0x334B4C0", VA = "0x18334C8C0")]
		public static bool GetMessageLeaveBoardAvail()
		{
			return default(bool);
		}

		// Token: 0x0600B7CE RID: 47054 RVA: 0x00045258 File Offset: 0x00043458
		[Token(Token = "0x600B7CE")]
		[Address(RVA = "0x334CA20", Offset = "0x334B620", VA = "0x18334CA20")]
		public static int GetSocialPointTotalGetLastWeek()
		{
			return 0;
		}

		// Token: 0x0600B7CF RID: 47055 RVA: 0x00045270 File Offset: 0x00043470
		[Token(Token = "0x600B7CF")]
		[Address(RVA = "0x334CA90", Offset = "0x334B690", VA = "0x18334CA90")]
		public static int GetSocialPointTotalGetThisWeek()
		{
			return 0;
		}

		// Token: 0x0600B7D0 RID: 47056 RVA: 0x00045288 File Offset: 0x00043488
		[Token(Token = "0x600B7D0")]
		[Address(RVA = "0x334C920", Offset = "0x334B520", VA = "0x18334C920")]
		public static int GetSocialPointCanGetThisWeek()
		{
			return 0;
		}

		// Token: 0x0600B7D1 RID: 47057 RVA: 0x000452A0 File Offset: 0x000434A0
		[Token(Token = "0x600B7D1")]
		[Address(RVA = "0x334CBE0", Offset = "0x334B7E0", VA = "0x18334CBE0")]
		public static int GetTargetPlayerSocialPointCanGetThisWeek(PlayerDataModel playerDataModel)
		{
			return 0;
		}

		// Token: 0x0600B7D2 RID: 47058 RVA: 0x000452B8 File Offset: 0x000434B8
		[Token(Token = "0x600B7D2")]
		[Address(RVA = "0x334C9A0", Offset = "0x334B5A0", VA = "0x18334C9A0")]
		public static int GetSocialPointMaxNumPerWeek()
		{
			return 0;
		}

		// Token: 0x0600B7D3 RID: 47059 RVA: 0x000452D0 File Offset: 0x000434D0
		[Token(Token = "0x600B7D3")]
		[Address(RVA = "0x334C810", Offset = "0x334B410", VA = "0x18334C810")]
		public static bool GetIfShowToDoNotify()
		{
			return default(bool);
		}

		// Token: 0x0600B7D4 RID: 47060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7D4")]
		[Address(RVA = "0x334CE70", Offset = "0x334BA70", VA = "0x18334CE70")]
		public static void OnGetPlayerMessageBoardRequest()
		{
		}

		// Token: 0x0600B7D5 RID: 47061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7D5")]
		[Address(RVA = "0x334D2B0", Offset = "0x334BEB0", VA = "0x18334D2B0")]
		private static void _OpenPlayerMessageLeavePage(BuildingPayloadGetMessageBoardContentResponse response)
		{
		}

		// Token: 0x0600B7D6 RID: 47062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7D6")]
		[Address(RVA = "0x334CC60", Offset = "0x334B860", VA = "0x18334CC60")]
		public static void OnGetOtherMessageBoardRequest(string targetUid)
		{
		}

		// Token: 0x0600B7D7 RID: 47063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7D7")]
		[Address(RVA = "0x334D150", Offset = "0x334BD50", VA = "0x18334D150")]
		private static void _OpenOtherMessageLeavePage(BuildingPayloadGetOthersMessageBoardContentResponse response)
		{
		}

		// Token: 0x0400B5AC RID: 46508
		[Token(Token = "0x400B5AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetMessageLeaveBoardData;

		// Token: 0x0400B5AD RID: 46509
		[Token(Token = "0x400B5AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetTargetPlayerMessageLeaveBoardData;

		// Token: 0x0400B5AE RID: 46510
		[Token(Token = "0x400B5AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetMessageLeaveBoardAvail;

		// Token: 0x0400B5AF RID: 46511
		[Token(Token = "0x400B5AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSocialPointTotalGetLastWeek;

		// Token: 0x0400B5B0 RID: 46512
		[Token(Token = "0x400B5B0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSocialPointTotalGetThisWeek;

		// Token: 0x0400B5B1 RID: 46513
		[Token(Token = "0x400B5B1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetSocialPointCanGetThisWeek;

		// Token: 0x0400B5B2 RID: 46514
		[Token(Token = "0x400B5B2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetTargetPlayerSocialPointCanGetThisWeek;

		// Token: 0x0400B5B3 RID: 46515
		[Token(Token = "0x400B5B3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetSocialPointMaxNumPerWeek;

		// Token: 0x0400B5B4 RID: 46516
		[Token(Token = "0x400B5B4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetIfShowToDoNotify;

		// Token: 0x0400B5B5 RID: 46517
		[Token(Token = "0x400B5B5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnGetPlayerMessageBoardRequest;

		// Token: 0x0400B5B6 RID: 46518
		[Token(Token = "0x400B5B6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OpenPlayerMessageLeavePage;

		// Token: 0x0400B5B7 RID: 46519
		[Token(Token = "0x400B5B7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnGetOtherMessageBoardRequest;

		// Token: 0x0400B5B8 RID: 46520
		[Token(Token = "0x400B5B8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OpenOtherMessageLeavePage;
	}
}
