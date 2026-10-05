using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D73 RID: 19827
	[Token(Token = "0x2004D73")]
	[Serializable]
	public class FriendSortViewModel : IHotfixable
	{
		// Token: 0x0601DADC RID: 121564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DADC")]
		[Address(RVA = "0x1743450", Offset = "0x1742050", VA = "0x181743450")]
		public JObject GetActivityInfo(string activityId, string activityType)
		{
			return null;
		}

		// Token: 0x0601DADD RID: 121565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DADD")]
		[Address(RVA = "0x1743560", Offset = "0x1742160", VA = "0x181743560")]
		public FriendSortViewModel()
		{
		}

		// Token: 0x04027351 RID: 160593
		[Token(Token = "0x4027351")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		// Token: 0x04027352 RID: 160594
		[Token(Token = "0x4027352")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		// Token: 0x04027353 RID: 160595
		[Token(Token = "0x4027353")]
		[FieldOffset(Offset = "0x20")]
		public long infoShare;

		// Token: 0x04027354 RID: 160596
		[Token(Token = "0x4027354")]
		[FieldOffset(Offset = "0x28")]
		public int infoShareVisited;

		// Token: 0x04027355 RID: 160597
		[Token(Token = "0x4027355")]
		[FieldOffset(Offset = "0x2C")]
		public bool recentVisited;

		// Token: 0x04027356 RID: 160598
		[Token(Token = "0x4027356")]
		[FieldOffset(Offset = "0x30")]
		public DateTime lastOnlineTime;

		// Token: 0x04027357 RID: 160599
		[Token(Token = "0x4027357")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, Dictionary<string, JObject>> activity;

		// Token: 0x04027358 RID: 160600
		[Token(Token = "0x4027358")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetActivityInfo;

		// Token: 0x04027359 RID: 160601
		[Token(Token = "0x4027359")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
