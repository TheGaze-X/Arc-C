using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067A0 RID: 26528
	[Token(Token = "0x20067A0")]
	public class ZoneHomeEntryActivityModel : ZoneHomeEntryItemModel
	{
		// Token: 0x170059FF RID: 23039
		// (get) Token: 0x060260B4 RID: 155828 RVA: 0x000C9C18 File Offset: 0x000C7E18
		// (set) Token: 0x060260B5 RID: 155829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170059FF")]
		public ActivityBasicInfo basicInfo
		{
			[Token(Token = "0x60260B4")]
			[Address(RVA = "0x2129B70", Offset = "0x2128770", VA = "0x182129B70")]
			[CompilerGenerated]
			get
			{
				return default(ActivityBasicInfo);
			}
			[Token(Token = "0x60260B5")]
			[Address(RVA = "0x2129DD0", Offset = "0x21289D0", VA = "0x182129DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005A00 RID: 23040
		// (get) Token: 0x060260B6 RID: 155830 RVA: 0x000C9C30 File Offset: 0x000C7E30
		// (set) Token: 0x060260B7 RID: 155831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A00")]
		public bool isStageOpen
		{
			[Token(Token = "0x60260B6")]
			[Address(RVA = "0x2129D00", Offset = "0x2128900", VA = "0x182129D00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60260B7")]
			[Address(RVA = "0x2129EE0", Offset = "0x2128AE0", VA = "0x182129EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005A01 RID: 23041
		// (get) Token: 0x060260B8 RID: 155832 RVA: 0x000C9C48 File Offset: 0x000C7E48
		[Token(Token = "0x17005A01")]
		public bool isEntryUnlocked
		{
			[Token(Token = "0x60260B8")]
			[Address(RVA = "0x2129C70", Offset = "0x2128870", VA = "0x182129C70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005A02 RID: 23042
		// (get) Token: 0x060260B9 RID: 155833 RVA: 0x000C9C60 File Offset: 0x000C7E60
		// (set) Token: 0x060260BA RID: 155834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A02")]
		public int actItemCount
		{
			[Token(Token = "0x60260B9")]
			[Address(RVA = "0x2129B10", Offset = "0x2128710", VA = "0x182129B10")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60260BA")]
			[Address(RVA = "0x2129D60", Offset = "0x2128960", VA = "0x182129D60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060260BB RID: 155835 RVA: 0x000C9C78 File Offset: 0x000C7E78
		[Token(Token = "0x60260BB")]
		[Address(RVA = "0x21288F0", Offset = "0x21274F0", VA = "0x1821288F0", Slot = "4")]
		public override ZoneHomeEntryMedalStatus GetMedalStatus()
		{
			return default(ZoneHomeEntryMedalStatus);
		}

		// Token: 0x060260BC RID: 155836 RVA: 0x000C9C90 File Offset: 0x000C7E90
		[Token(Token = "0x60260BC")]
		[Address(RVA = "0x2128870", Offset = "0x2127470", VA = "0x182128870", Slot = "5")]
		public override ZoneHomeEntryLockInfo GetLockInfo()
		{
			return default(ZoneHomeEntryLockInfo);
		}

		// Token: 0x060260BD RID: 155837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60260BD")]
		[Address(RVA = "0x2128980", Offset = "0x2127580", VA = "0x182128980")]
		public static IList<ZoneHomeEntryItemModel> LoadData()
		{
			return null;
		}

		// Token: 0x060260BE RID: 155838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260BE")]
		[Address(RVA = "0x2129030", Offset = "0x2127C30", VA = "0x182129030")]
		private void _LoadData(DateTime curTime, ActivityBasicInfo actInfo)
		{
		}

		// Token: 0x060260BF RID: 155839 RVA: 0x000C9CA8 File Offset: 0x000C7EA8
		[Token(Token = "0x60260BF")]
		[Address(RVA = "0x2128E40", Offset = "0x2127A40", VA = "0x182128E40")]
		private static HomeEntrySortIndex _GetSortIndex(bool isStageOpen, ActivityBasicInfo actInfo, ZoneHomeEntryLockInfo lockInfo, ZoneHomeEntryMedalStatus medalStatus)
		{
			return HomeEntrySortIndex.NONE;
		}

		// Token: 0x060260C0 RID: 155840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260C0")]
		[Address(RVA = "0x2129A20", Offset = "0x2128620", VA = "0x182129A20")]
		public ZoneHomeEntryActivityModel()
		{
		}

		// Token: 0x060260C1 RID: 155841 RVA: 0x000C9CC0 File Offset: 0x000C7EC0
		[Token(Token = "0x60260C1")]
		[Address(RVA = "0x2128D90", Offset = "0x2127990", VA = "0x182128D90")]
		private ZoneHomeEntryMedalStatus <>xLuaBaseProxy_GetMedalStatus()
		{
			return default(ZoneHomeEntryMedalStatus);
		}

		// Token: 0x060260C2 RID: 155842 RVA: 0x000C9CD8 File Offset: 0x000C7ED8
		[Token(Token = "0x60260C2")]
		[Address(RVA = "0x2128CE0", Offset = "0x21278E0", VA = "0x182128CE0")]
		private ZoneHomeEntryLockInfo <>xLuaBaseProxy_GetLockInfo()
		{
			return default(ZoneHomeEntryLockInfo);
		}

		// Token: 0x040358A7 RID: 219303
		[Token(Token = "0x40358A7")]
		[FieldOffset(Offset = "0x40")]
		private ZoneHomeEntryLockInfo m_lockInfo;

		// Token: 0x040358A8 RID: 219304
		[Token(Token = "0x40358A8")]
		[FieldOffset(Offset = "0x58")]
		private ZoneHomeEntryMedalStatus m_medalStatus;

		// Token: 0x040358AC RID: 219308
		[Token(Token = "0x40358AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_basicInfo;

		// Token: 0x040358AD RID: 219309
		[Token(Token = "0x40358AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_basicInfo;

		// Token: 0x040358AE RID: 219310
		[Token(Token = "0x40358AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isStageOpen;

		// Token: 0x040358AF RID: 219311
		[Token(Token = "0x40358AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isStageOpen;

		// Token: 0x040358B0 RID: 219312
		[Token(Token = "0x40358B0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isEntryUnlocked;

		// Token: 0x040358B1 RID: 219313
		[Token(Token = "0x40358B1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_actItemCount;

		// Token: 0x040358B2 RID: 219314
		[Token(Token = "0x40358B2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_actItemCount;

		// Token: 0x040358B3 RID: 219315
		[Token(Token = "0x40358B3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetMedalStatus;

		// Token: 0x040358B4 RID: 219316
		[Token(Token = "0x40358B4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetLockInfo;

		// Token: 0x040358B5 RID: 219317
		[Token(Token = "0x40358B5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040358B6 RID: 219318
		[Token(Token = "0x40358B6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x040358B7 RID: 219319
		[Token(Token = "0x40358B7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetSortIndex;

		// Token: 0x040358B8 RID: 219320
		[Token(Token = "0x40358B8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
