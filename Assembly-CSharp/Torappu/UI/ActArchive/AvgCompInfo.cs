using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B10 RID: 27408
	[Token(Token = "0x2006B10")]
	public class AvgCompInfo : ActArchiveCompInfo
	{
		// Token: 0x06027305 RID: 160517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027305")]
		[Address(RVA = "0x2259500", Offset = "0x2258100", VA = "0x182259500")]
		public AvgCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x06027306 RID: 160518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027306")]
		[Address(RVA = "0x2258E10", Offset = "0x2257A10", VA = "0x182258E10")]
		public AvgItemModel GetAvgItemInfo(string avgId)
		{
			return null;
		}

		// Token: 0x06027307 RID: 160519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027307")]
		[Address(RVA = "0x2259350", Offset = "0x2257F50", VA = "0x182259350")]
		public void SetSelectedAvgItem(string avgID, bool isInit)
		{
		}

		// Token: 0x06027308 RID: 160520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027308")]
		[Address(RVA = "0x22590E0", Offset = "0x2257CE0", VA = "0x1822590E0", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x06027309 RID: 160521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027309")]
		[Address(RVA = "0x2258D60", Offset = "0x2257960", VA = "0x182258D60", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x0602730A RID: 160522 RVA: 0x000CD9C8 File Offset: 0x000CBBC8
		[Token(Token = "0x602730A")]
		[Address(RVA = "0x2259060", Offset = "0x2257C60", VA = "0x182259060", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x0602730B RID: 160523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602730B")]
		[Address(RVA = "0x22592A0", Offset = "0x2257EA0", VA = "0x1822592A0", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x0602730C RID: 160524 RVA: 0x000CD9E0 File Offset: 0x000CBBE0
		[Token(Token = "0x602730C")]
		[Address(RVA = "0x2258F00", Offset = "0x2257B00", VA = "0x182258F00", Slot = "8")]
		public override bool HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x0602730D RID: 160525 RVA: 0x000CD9F8 File Offset: 0x000CBBF8
		[Token(Token = "0x602730D")]
		[Address(RVA = "0x224ACE0", Offset = "0x22498E0", VA = "0x18224ACE0")]
		private bool <>xLuaBaseProxy_HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x040376FE RID: 227070
		[Token(Token = "0x40376FE")]
		[FieldOffset(Offset = "0x18")]
		public AvgProperty avg;

		// Token: 0x040376FF RID: 227071
		[Token(Token = "0x40376FF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04037700 RID: 227072
		[Token(Token = "0x4037700")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetAvgItemInfo;

		// Token: 0x04037701 RID: 227073
		[Token(Token = "0x4037701")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelectedAvgItem;

		// Token: 0x04037702 RID: 227074
		[Token(Token = "0x4037702")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037703 RID: 227075
		[Token(Token = "0x4037703")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x04037704 RID: 227076
		[Token(Token = "0x4037704")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04037705 RID: 227077
		[Token(Token = "0x4037705")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x04037706 RID: 227078
		[Token(Token = "0x4037706")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HasNewItem;
	}
}
