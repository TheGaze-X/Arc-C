using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007393 RID: 29587
	[Token(Token = "0x2007393")]
	public class Act42d0AreaViewModel : IHotfixable
	{
		// Token: 0x170062CA RID: 25290
		// (get) Token: 0x06029D36 RID: 171318 RVA: 0x000D6BA8 File Offset: 0x000D4DA8
		[Token(Token = "0x170062CA")]
		public int stageSelectedIndex
		{
			[Token(Token = "0x6029D36")]
			[Address(RVA = "0x257A080", Offset = "0x2578C80", VA = "0x18257A080")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170062CB RID: 25291
		// (get) Token: 0x06029D37 RID: 171319 RVA: 0x000D6BC0 File Offset: 0x000D4DC0
		[Token(Token = "0x170062CB")]
		public bool hasStageSelected
		{
			[Token(Token = "0x6029D37")]
			[Address(RVA = "0x257A020", Offset = "0x2578C20", VA = "0x18257A020")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06029D38 RID: 171320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D38")]
		[Address(RVA = "0x25793F0", Offset = "0x2577FF0", VA = "0x1825793F0")]
		public void LoadData(string actId, Act42D0Data.Act42D0AreaInfoData areaInfoData)
		{
		}

		// Token: 0x06029D39 RID: 171321 RVA: 0x000D6BD8 File Offset: 0x000D4DD8
		[Token(Token = "0x6029D39")]
		[Address(RVA = "0x2579370", Offset = "0x2577F70", VA = "0x182579370")]
		public bool IsNew()
		{
			return default(bool);
		}

		// Token: 0x06029D3A RID: 171322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D3A")]
		[Address(RVA = "0x2579AB0", Offset = "0x25786B0", VA = "0x182579AB0")]
		public void RefreshPlayerData(PlayerActivity.PlayerAct42D0Activity.AreaInfo playerInfo)
		{
		}

		// Token: 0x06029D3B RID: 171323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D3B")]
		[Address(RVA = "0x2579DA0", Offset = "0x25789A0", VA = "0x182579DA0")]
		public void SelectStage(string stageId)
		{
		}

		// Token: 0x06029D3C RID: 171324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D3C")]
		[Address(RVA = "0x2579EC0", Offset = "0x2578AC0", VA = "0x182579EC0")]
		public void UnSelect()
		{
		}

		// Token: 0x06029D3D RID: 171325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D3D")]
		[Address(RVA = "0x2579D30", Offset = "0x2578930", VA = "0x182579D30")]
		public void SelectStage(int stageIndex)
		{
		}

		// Token: 0x06029D3E RID: 171326 RVA: 0x000D6BF0 File Offset: 0x000D4DF0
		[Token(Token = "0x6029D3E")]
		[Address(RVA = "0x2579310", Offset = "0x2577F10", VA = "0x182579310")]
		public static bool IfHasStageSelected(int index)
		{
			return default(bool);
		}

		// Token: 0x06029D3F RID: 171327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D3F")]
		[Address(RVA = "0x2579F20", Offset = "0x2578B20", VA = "0x182579F20")]
		public Act42d0AreaViewModel()
		{
		}

		// Token: 0x0403BE76 RID: 245366
		[Token(Token = "0x403BE76")]
		[FieldOffset(Offset = "0x10")]
		public Act42D0Data.Act42D0AreaInfoData areaInfo;

		// Token: 0x0403BE77 RID: 245367
		[Token(Token = "0x403BE77")]
		[FieldOffset(Offset = "0x18")]
		public bool isUnlock;

		// Token: 0x0403BE78 RID: 245368
		[Token(Token = "0x403BE78")]
		[FieldOffset(Offset = "0x20")]
		public string unlockDesc;

		// Token: 0x0403BE79 RID: 245369
		[Token(Token = "0x403BE79")]
		[FieldOffset(Offset = "0x28")]
		public bool canUseBuff;

		// Token: 0x0403BE7A RID: 245370
		[Token(Token = "0x403BE7A")]
		[FieldOffset(Offset = "0x30")]
		public string activityId;

		// Token: 0x0403BE7B RID: 245371
		[Token(Token = "0x403BE7B")]
		public const int STAGE_INDEX_NO_SELECTTION = -1;

		// Token: 0x0403BE7C RID: 245372
		[Token(Token = "0x403BE7C")]
		[FieldOffset(Offset = "0x38")]
		public List<Act42D0MapStageItemViewModel> stageItemModelList;

		// Token: 0x0403BE7D RID: 245373
		[Token(Token = "0x403BE7D")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, Act42D0Data.Act42D0StageRatingInfoData> m_stageRatingInfoData;

		// Token: 0x0403BE7E RID: 245374
		[Token(Token = "0x403BE7E")]
		[FieldOffset(Offset = "0x48")]
		private int m_stageSelectedIndex;

		// Token: 0x0403BE7F RID: 245375
		[Token(Token = "0x403BE7F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stageSelectedIndex;

		// Token: 0x0403BE80 RID: 245376
		[Token(Token = "0x403BE80")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_hasStageSelected;

		// Token: 0x0403BE81 RID: 245377
		[Token(Token = "0x403BE81")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403BE82 RID: 245378
		[Token(Token = "0x403BE82")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsNew;

		// Token: 0x0403BE83 RID: 245379
		[Token(Token = "0x403BE83")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x0403BE84 RID: 245380
		[Token(Token = "0x403BE84")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SelectStage;

		// Token: 0x0403BE85 RID: 245381
		[Token(Token = "0x403BE85")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UnSelect;

		// Token: 0x0403BE86 RID: 245382
		[Token(Token = "0x403BE86")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix1_SelectStage;

		// Token: 0x0403BE87 RID: 245383
		[Token(Token = "0x403BE87")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_IfHasStageSelected;

		// Token: 0x0403BE88 RID: 245384
		[Token(Token = "0x403BE88")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
