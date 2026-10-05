using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000FD9 RID: 4057
	[Token(Token = "0x2000FD9")]
	public class CrisisV2AchievementCommentData : ICrisisV2CommentData, IHotfixable
	{
		// Token: 0x06006D2B RID: 27947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D2B")]
		[Address(RVA = "0x2100780", Offset = "0x20FF380", VA = "0x182100780", Slot = "4")]
		public string GetCommentDesc()
		{
			return null;
		}

		// Token: 0x06006D2C RID: 27948 RVA: 0x00031BA8 File Offset: 0x0002FDA8
		[Token(Token = "0x6006D2C")]
		[Address(RVA = "0x2100840", Offset = "0x20FF440", VA = "0x182100840", Slot = "5")]
		public int GetCommentSortId()
		{
			return 0;
		}

		// Token: 0x06006D2D RID: 27949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D2D")]
		[Address(RVA = "0x21007E0", Offset = "0x20FF3E0", VA = "0x1821007E0", Slot = "6")]
		public string GetCommentId()
		{
			return null;
		}

		// Token: 0x06006D2E RID: 27950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D2E")]
		[Address(RVA = "0x21008A0", Offset = "0x20FF4A0", VA = "0x1821008A0")]
		public CrisisV2AchievementCommentData()
		{
		}

		// Token: 0x04005613 RID: 22035
		[Token(Token = "0x4005613")]
		[FieldOffset(Offset = "0x10")]
		public string commentId;

		// Token: 0x04005614 RID: 22036
		[Token(Token = "0x4005614")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04005615 RID: 22037
		[Token(Token = "0x4005615")]
		[FieldOffset(Offset = "0x20")]
		public string desc;

		// Token: 0x04005616 RID: 22038
		[Token(Token = "0x4005616")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCommentDesc;

		// Token: 0x04005617 RID: 22039
		[Token(Token = "0x4005617")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCommentSortId;

		// Token: 0x04005618 RID: 22040
		[Token(Token = "0x4005618")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCommentId;

		// Token: 0x04005619 RID: 22041
		[Token(Token = "0x4005619")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
