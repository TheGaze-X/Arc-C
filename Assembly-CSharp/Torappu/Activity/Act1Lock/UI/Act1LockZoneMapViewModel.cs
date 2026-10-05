using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078D7 RID: 30935
	[Token(Token = "0x20078D7")]
	public class Act1LockZoneMapViewModel : IHotfixable
	{
		// Token: 0x17006592 RID: 26002
		// (get) Token: 0x0602B616 RID: 177686 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B617 RID: 177687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006592")]
		public string selectedStageId
		{
			[Token(Token = "0x602B616")]
			[Address(RVA = "0x275A970", Offset = "0x2759570", VA = "0x18275A970")]
			get
			{
				return null;
			}
			[Token(Token = "0x602B617")]
			[Address(RVA = "0x275A9D0", Offset = "0x27595D0", VA = "0x18275A9D0")]
			set
			{
			}
		}

		// Token: 0x17006593 RID: 26003
		// (get) Token: 0x0602B618 RID: 177688 RVA: 0x000DBAF8 File Offset: 0x000D9CF8
		[Token(Token = "0x17006593")]
		public bool hasStage
		{
			[Token(Token = "0x602B618")]
			[Address(RVA = "0x275A8F0", Offset = "0x27594F0", VA = "0x18275A8F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602B619 RID: 177689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B619")]
		[Address(RVA = "0x275A640", Offset = "0x2759240", VA = "0x18275A640")]
		public void RefreshInfo()
		{
		}

		// Token: 0x0602B61A RID: 177690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B61A")]
		[Address(RVA = "0x275A2A0", Offset = "0x2758EA0", VA = "0x18275A2A0")]
		public void LoadData()
		{
		}

		// Token: 0x0602B61B RID: 177691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B61B")]
		[Address(RVA = "0x275A1C0", Offset = "0x2758DC0", VA = "0x18275A1C0")]
		public Act1LockStageViewModel GetStageViewModel(string stageId)
		{
			return null;
		}

		// Token: 0x0602B61C RID: 177692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B61C")]
		[Address(RVA = "0x275A7F0", Offset = "0x27593F0", VA = "0x18275A7F0")]
		public Act1LockZoneMapViewModel()
		{
		}

		// Token: 0x0403EBB7 RID: 256951
		[Token(Token = "0x403EBB7")]
		[FieldOffset(Offset = "0x10")]
		private string m_selectStageId;

		// Token: 0x0403EBB8 RID: 256952
		[Token(Token = "0x403EBB8")]
		[FieldOffset(Offset = "0x18")]
		public string id;

		// Token: 0x0403EBB9 RID: 256953
		[Token(Token = "0x403EBB9")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x0403EBBA RID: 256954
		[Token(Token = "0x403EBBA")]
		[FieldOffset(Offset = "0x28")]
		public bool isFinalUnlocked;

		// Token: 0x0403EBBB RID: 256955
		[Token(Token = "0x403EBBB")]
		[FieldOffset(Offset = "0x29")]
		public bool anyInterlockUnlocked;

		// Token: 0x0403EBBC RID: 256956
		[Token(Token = "0x403EBBC")]
		[FieldOffset(Offset = "0x30")]
		public List<Act1LockStageViewModel> stageViewModelList;

		// Token: 0x0403EBBD RID: 256957
		[Token(Token = "0x403EBBD")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, Act1LockStageViewModel> stageDict;

		// Token: 0x0403EBBE RID: 256958
		[Token(Token = "0x403EBBE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedStageId;

		// Token: 0x0403EBBF RID: 256959
		[Token(Token = "0x403EBBF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectedStageId;

		// Token: 0x0403EBC0 RID: 256960
		[Token(Token = "0x403EBC0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hasStage;

		// Token: 0x0403EBC1 RID: 256961
		[Token(Token = "0x403EBC1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshInfo;

		// Token: 0x0403EBC2 RID: 256962
		[Token(Token = "0x403EBC2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403EBC3 RID: 256963
		[Token(Token = "0x403EBC3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetStageViewModel;

		// Token: 0x0403EBC4 RID: 256964
		[Token(Token = "0x403EBC4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
