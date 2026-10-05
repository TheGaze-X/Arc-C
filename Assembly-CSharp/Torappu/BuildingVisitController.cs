using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI.Friend;

namespace Torappu
{
	// Token: 0x020004B2 RID: 1202
	[Token(Token = "0x20004B2")]
	public static class BuildingVisitController
	{
		// Token: 0x06004D21 RID: 19745 RVA: 0x0002D6A8 File Offset: 0x0002B8A8
		[Token(Token = "0x6004D21")]
		[Address(RVA = "0x178D940", Offset = "0x178C540", VA = "0x18178D940")]
		public static bool StartVisit(string uid, List<FriendSortViewModel> friendList, [Optional] List<string> starFriendList)
		{
			return default(bool);
		}

		// Token: 0x06004D22 RID: 19746 RVA: 0x0002D6C0 File Offset: 0x0002B8C0
		[Token(Token = "0x6004D22")]
		[Address(RVA = "0x178DC80", Offset = "0x178C880", VA = "0x18178DC80")]
		public static bool VisitNext(string curUid, BuildingVisitContext context)
		{
			return default(bool);
		}

		// Token: 0x06004D23 RID: 19747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D23")]
		[Address(RVA = "0x178E2E0", Offset = "0x178CEE0", VA = "0x18178E2E0")]
		private static void _StartVisitProcess(string uid, bool hasVisitedToday, BuildingVisitContext context)
		{
		}

		// Token: 0x06004D24 RID: 19748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D24")]
		[Address(RVA = "0x178DE30", Offset = "0x178CA30", VA = "0x18178DE30")]
		private static List<BuildingVisitContext.FriendInfo> _CreateFriendList(string startUid, List<FriendSortViewModel> sortList, List<string> starFriendList)
		{
			return null;
		}

		// Token: 0x06004D25 RID: 19749 RVA: 0x0002D6D8 File Offset: 0x0002B8D8
		[Token(Token = "0x6004D25")]
		[Address(RVA = "0x178E270", Offset = "0x178CE70", VA = "0x18178E270")]
		private static int _PredicateNextOfNextFriend(string curUid, BuildingVisitContext context)
		{
			return 0;
		}

		// Token: 0x06004D26 RID: 19750 RVA: 0x0002D6F0 File Offset: 0x0002B8F0
		[Token(Token = "0x6004D26")]
		[Address(RVA = "0x178D870", Offset = "0x178C470", VA = "0x18178D870")]
		public static bool CheckIfVisitCurrentPlayerByUid(string uid)
		{
			return default(bool);
		}
	}
}
