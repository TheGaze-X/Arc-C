using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000FC0 RID: 4032
	[Token(Token = "0x2000FC0")]
	public class CrisisV2CommentData : ICrisisV2CommentData, IHotfixable
	{
		// Token: 0x06006D07 RID: 27911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D07")]
		[Address(RVA = "0x2100E60", Offset = "0x20FFA60", VA = "0x182100E60", Slot = "4")]
		public string GetCommentDesc()
		{
			return null;
		}

		// Token: 0x06006D08 RID: 27912 RVA: 0x00031B30 File Offset: 0x0002FD30
		[Token(Token = "0x6006D08")]
		[Address(RVA = "0x2100F20", Offset = "0x20FFB20", VA = "0x182100F20", Slot = "5")]
		public int GetCommentSortId()
		{
			return 0;
		}

		// Token: 0x06006D09 RID: 27913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D09")]
		[Address(RVA = "0x2100EC0", Offset = "0x20FFAC0", VA = "0x182100EC0", Slot = "6")]
		public string GetCommentId()
		{
			return null;
		}

		// Token: 0x06006D0A RID: 27914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D0A")]
		[Address(RVA = "0x2100F80", Offset = "0x20FFB80", VA = "0x182100F80")]
		public CrisisV2CommentData()
		{
		}

		// Token: 0x04005598 RID: 21912
		[Token(Token = "0x4005598")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005599 RID: 21913
		[Token(Token = "0x4005599")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x0400559A RID: 21914
		[Token(Token = "0x400559A")]
		[FieldOffset(Offset = "0x20")]
		public string desc;

		// Token: 0x0400559B RID: 21915
		[Token(Token = "0x400559B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCommentDesc;

		// Token: 0x0400559C RID: 21916
		[Token(Token = "0x400559C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCommentSortId;

		// Token: 0x0400559D RID: 21917
		[Token(Token = "0x400559D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCommentId;

		// Token: 0x0400559E RID: 21918
		[Token(Token = "0x400559E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
