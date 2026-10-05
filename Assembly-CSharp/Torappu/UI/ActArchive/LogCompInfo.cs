using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BA8 RID: 27560
	[Token(Token = "0x2006BA8")]
	public class LogCompInfo : ActArchiveCompInfo
	{
		// Token: 0x060275B0 RID: 161200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275B0")]
		[Address(RVA = "0x228DB60", Offset = "0x228C760", VA = "0x18228DB60")]
		public LogCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x060275B1 RID: 161201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60275B1")]
		[Address(RVA = "0x228D310", Offset = "0x228BF10", VA = "0x18228D310")]
		public LogItemModel GetLogItemInfo(string chapterId)
		{
			return null;
		}

		// Token: 0x060275B2 RID: 161202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275B2")]
		[Address(RVA = "0x228D9B0", Offset = "0x228C5B0", VA = "0x18228D9B0")]
		public void SetSelectedLogItem(string chapterId, bool isInit)
		{
		}

		// Token: 0x060275B3 RID: 161203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275B3")]
		[Address(RVA = "0x228D740", Offset = "0x228C340", VA = "0x18228D740", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x060275B4 RID: 161204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275B4")]
		[Address(RVA = "0x228D0F0", Offset = "0x228BCF0", VA = "0x18228D0F0", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x060275B5 RID: 161205 RVA: 0x000CE2F8 File Offset: 0x000CC4F8
		[Token(Token = "0x60275B5")]
		[Address(RVA = "0x228D6C0", Offset = "0x228C2C0", VA = "0x18228D6C0", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x060275B6 RID: 161206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275B6")]
		[Address(RVA = "0x228D900", Offset = "0x228C500", VA = "0x18228D900", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x060275B7 RID: 161207 RVA: 0x000CE310 File Offset: 0x000CC510
		[Token(Token = "0x60275B7")]
		[Address(RVA = "0x228D400", Offset = "0x228C000", VA = "0x18228D400", Slot = "8")]
		public override bool HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x060275B8 RID: 161208 RVA: 0x000CE328 File Offset: 0x000CC528
		[Token(Token = "0x60275B8")]
		[Address(RVA = "0x228D560", Offset = "0x228C160", VA = "0x18228D560", Slot = "9")]
		public override bool IsUnlocked()
		{
			return default(bool);
		}

		// Token: 0x060275B9 RID: 161209 RVA: 0x000CE340 File Offset: 0x000CC540
		[Token(Token = "0x60275B9")]
		[Address(RVA = "0x2274CA0", Offset = "0x22738A0", VA = "0x182274CA0")]
		private bool <>xLuaBaseProxy_HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x060275BA RID: 161210 RVA: 0x000CE358 File Offset: 0x000CC558
		[Token(Token = "0x60275BA")]
		[Address(RVA = "0x2274CB0", Offset = "0x22738B0", VA = "0x182274CB0")]
		private bool <>xLuaBaseProxy_IsUnlocked()
		{
			return default(bool);
		}

		// Token: 0x04037C25 RID: 228389
		[Token(Token = "0x4037C25")]
		[FieldOffset(Offset = "0x18")]
		public LogProperty log;

		// Token: 0x04037C26 RID: 228390
		[Token(Token = "0x4037C26")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04037C27 RID: 228391
		[Token(Token = "0x4037C27")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetLogItemInfo;

		// Token: 0x04037C28 RID: 228392
		[Token(Token = "0x4037C28")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelectedLogItem;

		// Token: 0x04037C29 RID: 228393
		[Token(Token = "0x4037C29")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037C2A RID: 228394
		[Token(Token = "0x4037C2A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x04037C2B RID: 228395
		[Token(Token = "0x4037C2B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04037C2C RID: 228396
		[Token(Token = "0x4037C2C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x04037C2D RID: 228397
		[Token(Token = "0x4037C2D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HasNewItem;

		// Token: 0x04037C2E RID: 228398
		[Token(Token = "0x4037C2E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_IsUnlocked;
	}
}
