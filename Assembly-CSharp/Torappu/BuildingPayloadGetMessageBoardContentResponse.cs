using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu
{
	// Token: 0x0200068F RID: 1679
	[Token(Token = "0x200068F")]
	public class BuildingPayloadGetMessageBoardContentResponse : PlayerDeltaResponse
	{
		// Token: 0x060062C5 RID: 25285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062C5")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuildingPayloadGetMessageBoardContentResponse()
		{
		}

		// Token: 0x04002E59 RID: 11865
		[Token(Token = "0x4002E59")]
		[FieldOffset(Offset = "0x28")]
		public List<BuildingPayloadGetMessageBoardContentResponse.PayloadMessageBoardThisWeekVisitor> thisWeekVisitors;

		// Token: 0x04002E5A RID: 11866
		[Token(Token = "0x4002E5A")]
		[FieldOffset(Offset = "0x30")]
		public List<BuildingPayloadGetMessageBoardContentResponse.PayloadMessageBoardLastWeekVisitor> lastWeekVisitors;

		// Token: 0x04002E5B RID: 11867
		[Token(Token = "0x4002E5B")]
		[FieldOffset(Offset = "0x38")]
		public int todayVisit;

		// Token: 0x04002E5C RID: 11868
		[Token(Token = "0x4002E5C")]
		[FieldOffset(Offset = "0x3C")]
		public int weeklyVisit;

		// Token: 0x04002E5D RID: 11869
		[Token(Token = "0x4002E5D")]
		[FieldOffset(Offset = "0x40")]
		public int lastWeekVisit;

		// Token: 0x04002E5E RID: 11870
		[Token(Token = "0x4002E5E")]
		[FieldOffset(Offset = "0x44")]
		public int lastWeekSpReward;

		// Token: 0x04002E5F RID: 11871
		[Token(Token = "0x4002E5F")]
		[FieldOffset(Offset = "0x48")]
		public long lastShowTs;

		// Token: 0x02000690 RID: 1680
		[Token(Token = "0x2000690")]
		public class PayloadMessageBoardLastWeekVisitor : IMessageBoardVisitorData, IPlayerStatus, IHotfixable
		{
			// Token: 0x17000CD5 RID: 3285
			// (get) Token: 0x060062C6 RID: 25286 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CD5")]
			public AvatarInfo avatarInfo
			{
				[Token(Token = "0x60062C6")]
				[Address(RVA = "0x1DF0170", Offset = "0x1DEED70", VA = "0x181DF0170", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000CD6 RID: 3286
			// (get) Token: 0x060062C7 RID: 25287 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CD6")]
			public string skinId
			{
				[Token(Token = "0x60062C7")]
				[Address(RVA = "0x1DF0230", Offset = "0x1DEEE30", VA = "0x181DF0230", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000CD7 RID: 3287
			// (get) Token: 0x060062C8 RID: 25288 RVA: 0x000302B8 File Offset: 0x0002E4B8
			[Token(Token = "0x17000CD7")]
			public bool isSkinSp
			{
				[Token(Token = "0x60062C8")]
				[Address(RVA = "0x1DF01D0", Offset = "0x1DEEDD0", VA = "0x181DF01D0", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060062C9 RID: 25289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062C9")]
			[Address(RVA = "0x1DF0110", Offset = "0x1DEED10", VA = "0x181DF0110")]
			public PayloadMessageBoardLastWeekVisitor()
			{
			}

			// Token: 0x04002E60 RID: 11872
			[Token(Token = "0x4002E60")]
			[FieldOffset(Offset = "0x10")]
			public string uid;

			// Token: 0x04002E61 RID: 11873
			[Token(Token = "0x4002E61")]
			[FieldOffset(Offset = "0x18")]
			public string nickName;

			// Token: 0x04002E62 RID: 11874
			[Token(Token = "0x4002E62")]
			[FieldOffset(Offset = "0x20")]
			public string nickNumber;

			// Token: 0x04002E63 RID: 11875
			[Token(Token = "0x4002E63")]
			[FieldOffset(Offset = "0x28")]
			public AvatarInfo avatar;

			// Token: 0x04002E64 RID: 11876
			[Token(Token = "0x4002E64")]
			[FieldOffset(Offset = "0x30")]
			public string secretarySkinId;

			// Token: 0x04002E65 RID: 11877
			[Token(Token = "0x4002E65")]
			[FieldOffset(Offset = "0x38")]
			public string secretary;

			// Token: 0x04002E66 RID: 11878
			[Token(Token = "0x4002E66")]
			[FieldOffset(Offset = "0x40")]
			public bool secretarySkinSp;

			// Token: 0x04002E67 RID: 11879
			[Token(Token = "0x4002E67")]
			[FieldOffset(Offset = "0x48")]
			public long lastVisitTs;

			// Token: 0x04002E68 RID: 11880
			[Token(Token = "0x4002E68")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_avatarInfo;

			// Token: 0x04002E69 RID: 11881
			[Token(Token = "0x4002E69")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_skinId;

			// Token: 0x04002E6A RID: 11882
			[Token(Token = "0x4002E6A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_isSkinSp;

			// Token: 0x04002E6B RID: 11883
			[Token(Token = "0x4002E6B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02000691 RID: 1681
		[Token(Token = "0x2000691")]
		public class PayloadMessageBoardThisWeekVisitor : BuildingPayloadGetMessageBoardContentResponse.PayloadMessageBoardLastWeekVisitor, IMessageBoardVisitorData, IPlayerStatus, IHotfixable
		{
			// Token: 0x060062CA RID: 25290 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062CA")]
			[Address(RVA = "0x1DF0290", Offset = "0x1DEEE90", VA = "0x181DF0290")]
			public PayloadMessageBoardThisWeekVisitor()
			{
			}

			// Token: 0x04002E6C RID: 11884
			[Token(Token = "0x4002E6C")]
			[FieldOffset(Offset = "0x50")]
			public string nameCardSkin;

			// Token: 0x04002E6D RID: 11885
			[Token(Token = "0x4002E6D")]
			[FieldOffset(Offset = "0x58")]
			public int nameCardSkinTmpl;

			// Token: 0x04002E6E RID: 11886
			[Token(Token = "0x4002E6E")]
			[FieldOffset(Offset = "0x5C")]
			public int level;

			// Token: 0x04002E6F RID: 11887
			[Token(Token = "0x4002E6F")]
			[FieldOffset(Offset = "0x60")]
			public int visitCount;

			// Token: 0x04002E70 RID: 11888
			[Token(Token = "0x4002E70")]
			[FieldOffset(Offset = "0x68")]
			public long infoShare;

			// Token: 0x04002E71 RID: 11889
			[Token(Token = "0x4002E71")]
			[FieldOffset(Offset = "0x70")]
			public bool recentVisited;

			// Token: 0x04002E72 RID: 11890
			[Token(Token = "0x4002E72")]
			[FieldOffset(Offset = "0x78")]
			public string emoji;

			// Token: 0x04002E73 RID: 11891
			[Token(Token = "0x4002E73")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
