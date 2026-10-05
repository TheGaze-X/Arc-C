using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu
{
	// Token: 0x02000693 RID: 1683
	[Token(Token = "0x2000693")]
	public class BuildingPayloadGetOthersMessageBoardContentResponse : PlayerDeltaResponse
	{
		// Token: 0x060062CC RID: 25292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062CC")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuildingPayloadGetOthersMessageBoardContentResponse()
		{
		}

		// Token: 0x04002E75 RID: 11893
		[Token(Token = "0x4002E75")]
		[FieldOffset(Offset = "0x28")]
		public List<BuildingPayloadGetOthersMessageBoardContentResponse.PayloadOthersMessageBoardThisWeekVisitor> thisWeekVisitors;

		// Token: 0x02000694 RID: 1684
		[Token(Token = "0x2000694")]
		public class PayloadOthersMessageBoardThisWeekVisitor : IMessageBoardVisitorData, IPlayerStatus, IHotfixable
		{
			// Token: 0x17000CD8 RID: 3288
			// (get) Token: 0x060062CD RID: 25293 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CD8")]
			public AvatarInfo avatarInfo
			{
				[Token(Token = "0x60062CD")]
				[Address(RVA = "0x1DF0390", Offset = "0x1DEEF90", VA = "0x181DF0390", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000CD9 RID: 3289
			// (get) Token: 0x060062CE RID: 25294 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CD9")]
			public string skinId
			{
				[Token(Token = "0x60062CE")]
				[Address(RVA = "0x1DF0450", Offset = "0x1DEF050", VA = "0x181DF0450", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000CDA RID: 3290
			// (get) Token: 0x060062CF RID: 25295 RVA: 0x000302D0 File Offset: 0x0002E4D0
			[Token(Token = "0x17000CDA")]
			public bool isSkinSp
			{
				[Token(Token = "0x60062CF")]
				[Address(RVA = "0x1DF03F0", Offset = "0x1DEEFF0", VA = "0x181DF03F0", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060062D0 RID: 25296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062D0")]
			[Address(RVA = "0x1DF0330", Offset = "0x1DEEF30", VA = "0x181DF0330")]
			public PayloadOthersMessageBoardThisWeekVisitor()
			{
			}

			// Token: 0x04002E76 RID: 11894
			[Token(Token = "0x4002E76")]
			[FieldOffset(Offset = "0x10")]
			public string uid;

			// Token: 0x04002E77 RID: 11895
			[Token(Token = "0x4002E77")]
			[FieldOffset(Offset = "0x18")]
			public string nickName;

			// Token: 0x04002E78 RID: 11896
			[Token(Token = "0x4002E78")]
			[FieldOffset(Offset = "0x20")]
			public string nickNumber;

			// Token: 0x04002E79 RID: 11897
			[Token(Token = "0x4002E79")]
			[FieldOffset(Offset = "0x28")]
			public AvatarInfo avatar;

			// Token: 0x04002E7A RID: 11898
			[Token(Token = "0x4002E7A")]
			[FieldOffset(Offset = "0x30")]
			public string secretarySkinId;

			// Token: 0x04002E7B RID: 11899
			[Token(Token = "0x4002E7B")]
			[FieldOffset(Offset = "0x38")]
			public string secretary;

			// Token: 0x04002E7C RID: 11900
			[Token(Token = "0x4002E7C")]
			[FieldOffset(Offset = "0x40")]
			public bool secretarySkinSp;

			// Token: 0x04002E7D RID: 11901
			[Token(Token = "0x4002E7D")]
			[FieldOffset(Offset = "0x44")]
			public int level;

			// Token: 0x04002E7E RID: 11902
			[Token(Token = "0x4002E7E")]
			[FieldOffset(Offset = "0x48")]
			public long lastVisitTs;

			// Token: 0x04002E7F RID: 11903
			[Token(Token = "0x4002E7F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_avatarInfo;

			// Token: 0x04002E80 RID: 11904
			[Token(Token = "0x4002E80")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_skinId;

			// Token: 0x04002E81 RID: 11905
			[Token(Token = "0x4002E81")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_isSkinSp;

			// Token: 0x04002E82 RID: 11906
			[Token(Token = "0x4002E82")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
