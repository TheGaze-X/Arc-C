using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act12side
{
	// Token: 0x02007A65 RID: 31333
	[Token(Token = "0x2007A65")]
	public class Act12sideMissionViewModel : IHotfixable
	{
		// Token: 0x170066E0 RID: 26336
		// (get) Token: 0x0602BE27 RID: 179751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066E0")]
		public List<string> unlockNewMissionIdList
		{
			[Token(Token = "0x602BE27")]
			[Address(RVA = "0x27C2DF0", Offset = "0x27C19F0", VA = "0x1827C2DF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066E1 RID: 26337
		// (get) Token: 0x0602BE28 RID: 179752 RVA: 0x000DD928 File Offset: 0x000DBB28
		// (set) Token: 0x0602BE29 RID: 179753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170066E1")]
		public Act12SideData.ActZoneClass filterClass
		{
			[Token(Token = "0x602BE28")]
			[Address(RVA = "0x27C2D20", Offset = "0x27C1920", VA = "0x1827C2D20")]
			get
			{
				return Act12SideData.ActZoneClass.NONE;
			}
			[Token(Token = "0x602BE29")]
			[Address(RVA = "0x27C2FD0", Offset = "0x27C1BD0", VA = "0x1827C2FD0")]
			set
			{
			}
		}

		// Token: 0x170066E2 RID: 26338
		// (get) Token: 0x0602BE2A RID: 179754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066E2")]
		public List<Act12sideMissionItemViewModel> filterItemList
		{
			[Token(Token = "0x602BE2A")]
			[Address(RVA = "0x27C2D80", Offset = "0x27C1980", VA = "0x1827C2D80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602BE2B RID: 179755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE2B")]
		[Address(RVA = "0x27C2990", Offset = "0x27C1590", VA = "0x1827C2990")]
		private void _FilterList(Act12SideData.ActZoneClass zoneClass)
		{
		}

		// Token: 0x0602BE2C RID: 179756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE2C")]
		[Address(RVA = "0x27C2BE0", Offset = "0x27C17E0", VA = "0x1827C2BE0")]
		public Act12sideMissionViewModel()
		{
		}

		// Token: 0x0403F8EA RID: 260330
		[Token(Token = "0x403F8EA")]
		[FieldOffset(Offset = "0x10")]
		public List<Act12sideMissionItemViewModel> missionItemList;

		// Token: 0x0403F8EB RID: 260331
		[Token(Token = "0x403F8EB")]
		[FieldOffset(Offset = "0x18")]
		public int completedCount;

		// Token: 0x0403F8EC RID: 260332
		[Token(Token = "0x403F8EC")]
		[FieldOffset(Offset = "0x1C")]
		private bool m_filterListInit;

		// Token: 0x0403F8ED RID: 260333
		[Token(Token = "0x403F8ED")]
		[FieldOffset(Offset = "0x20")]
		private Act12SideData.ActZoneClass m_filterClass;

		// Token: 0x0403F8EE RID: 260334
		[Token(Token = "0x403F8EE")]
		[FieldOffset(Offset = "0x28")]
		private List<Act12sideMissionItemViewModel> m_filterItemList;

		// Token: 0x0403F8EF RID: 260335
		[Token(Token = "0x403F8EF")]
		[FieldOffset(Offset = "0x30")]
		private List<string> m_unlockNewMissionIdList;

		// Token: 0x0403F8F0 RID: 260336
		[Token(Token = "0x403F8F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_unlockNewMissionIdList;

		// Token: 0x0403F8F1 RID: 260337
		[Token(Token = "0x403F8F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_filterClass;

		// Token: 0x0403F8F2 RID: 260338
		[Token(Token = "0x403F8F2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_filterClass;

		// Token: 0x0403F8F3 RID: 260339
		[Token(Token = "0x403F8F3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_filterItemList;

		// Token: 0x0403F8F4 RID: 260340
		[Token(Token = "0x403F8F4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FilterList;

		// Token: 0x0403F8F5 RID: 260341
		[Token(Token = "0x403F8F5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
