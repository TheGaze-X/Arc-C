using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Building.UI;

namespace Torappu.Building
{
	// Token: 0x02001833 RID: 6195
	[Token(Token = "0x2001833")]
	public static class BuildingRouter
	{
		// Token: 0x06009CB9 RID: 40121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CB9")]
		[Address(RVA = "0x3176850", Offset = "0x3175450", VA = "0x183176850")]
		public static void AutoRouteByRoomType(BuildingData.RoomType roomType, [Optional] object param)
		{
		}

		// Token: 0x06009CBA RID: 40122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CBA")]
		[Address(RVA = "0x31771A0", Offset = "0x3175DA0", VA = "0x1831771A0")]
		public static void RouteToVaultSlot(string slotId, [Optional] Action cb)
		{
		}

		// Token: 0x06009CBB RID: 40123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CBB")]
		[Address(RVA = "0x3176D70", Offset = "0x3175970", VA = "0x183176D70")]
		public static void RouteToManufacture()
		{
		}

		// Token: 0x06009CBC RID: 40124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CBC")]
		[Address(RVA = "0x31772B0", Offset = "0x3175EB0", VA = "0x1831772B0")]
		public static void RouteToWorkshop(object param)
		{
		}

		// Token: 0x06009CBD RID: 40125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CBD")]
		[Address(RVA = "0x3176EA0", Offset = "0x3175AA0", VA = "0x183176EA0")]
		public static void RouteToMeeting([Optional] Action cb)
		{
		}

		// Token: 0x06009CBE RID: 40126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CBE")]
		[Address(RVA = "0x3177070", Offset = "0x3175C70", VA = "0x183177070")]
		public static void RouteToTrading()
		{
		}

		// Token: 0x06009CBF RID: 40127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CBF")]
		private static void _RouteToRoomWithPage<PageType>(BuildingData.RoomType roomType, string pageName, Func<string, object> getParamCb) where PageType : BuildingCommonPage
		{
		}

		// Token: 0x06009CC0 RID: 40128 RVA: 0x0003D530 File Offset: 0x0003B730
		[Token(Token = "0x6009CC0")]
		[Address(RVA = "0x3177440", Offset = "0x3176040", VA = "0x183177440")]
		private static bool _ShouldResetPageStackWhenRouting(string targetPageName)
		{
			return default(bool);
		}

		// Token: 0x06009CC1 RID: 40129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CC1")]
		[Address(RVA = "0x3176C10", Offset = "0x3175810", VA = "0x183176C10")]
		public static string FindFirstSlotOfRoom(BuildingData.RoomType roomType)
		{
			return null;
		}

		// Token: 0x06009CC2 RID: 40130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CC2")]
		[Address(RVA = "0x3177390", Offset = "0x3175F90", VA = "0x183177390")]
		private static IEnumerator _RouteToVaultSlotCoroutine(BuildingController buildingController, string slotId, Action cb)
		{
			return null;
		}

		// Token: 0x0400939A RID: 37786
		[Token(Token = "0x400939A")]
		private const float FOCUS_TIME = 0.5f;
	}
}
