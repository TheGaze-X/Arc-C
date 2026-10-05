using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B2F RID: 27439
	[Token(Token = "0x2006B2F")]
	public class ChallengeBookItemModel : ArchiveItemModel, IComparable
	{
		// Token: 0x06027391 RID: 160657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027391")]
		[Address(RVA = "0x2276660", Offset = "0x2275260", VA = "0x182276660")]
		public ChallengeBookItemModel(ActArchivePlugin.IActArchiveChallengeBookPlugin plugin)
		{
		}

		// Token: 0x06027392 RID: 160658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027392")]
		[Address(RVA = "0x22764B0", Offset = "0x22750B0", VA = "0x1822764B0", Slot = "4")]
		public override string GetFuncId()
		{
			return null;
		}

		// Token: 0x06027393 RID: 160659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027393")]
		[Address(RVA = "0x2276450", Offset = "0x2275050", VA = "0x182276450", Slot = "5")]
		public override string GetDesc()
		{
			return null;
		}

		// Token: 0x06027394 RID: 160660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027394")]
		[Address(RVA = "0x2276510", Offset = "0x2275110", VA = "0x182276510", Slot = "6")]
		public override string GetTrackType(string archiveId)
		{
			return null;
		}

		// Token: 0x06027395 RID: 160661 RVA: 0x000CDB90 File Offset: 0x000CBD90
		[Token(Token = "0x6027395")]
		[Address(RVA = "0x2276350", Offset = "0x2274F50", VA = "0x182276350", Slot = "7")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06027396 RID: 160662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027396")]
		[Address(RVA = "0x2276650", Offset = "0x2275250", VA = "0x182276650")]
		private string <>xLuaBaseProxy_GetTrackType(string P0)
		{
			return null;
		}

		// Token: 0x040377F2 RID: 227314
		[Token(Token = "0x40377F2")]
		[FieldOffset(Offset = "0x30")]
		public string storyId;

		// Token: 0x040377F3 RID: 227315
		[Token(Token = "0x40377F3")]
		[FieldOffset(Offset = "0x38")]
		public string challengeName;

		// Token: 0x040377F4 RID: 227316
		[Token(Token = "0x40377F4")]
		[FieldOffset(Offset = "0x40")]
		public string storyName;

		// Token: 0x040377F5 RID: 227317
		[Token(Token = "0x40377F5")]
		[FieldOffset(Offset = "0x48")]
		public string textId;

		// Token: 0x040377F6 RID: 227318
		[Token(Token = "0x40377F6")]
		[FieldOffset(Offset = "0x50")]
		public int sortId;

		// Token: 0x040377F7 RID: 227319
		[Token(Token = "0x40377F7")]
		[FieldOffset(Offset = "0x58")]
		private ActArchivePlugin.IActArchiveChallengeBookPlugin m_plugin;

		// Token: 0x040377F8 RID: 227320
		[Token(Token = "0x40377F8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040377F9 RID: 227321
		[Token(Token = "0x40377F9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetFuncId;

		// Token: 0x040377FA RID: 227322
		[Token(Token = "0x40377FA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x040377FB RID: 227323
		[Token(Token = "0x40377FB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetTrackType;

		// Token: 0x040377FC RID: 227324
		[Token(Token = "0x40377FC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CompareTo;
	}
}
