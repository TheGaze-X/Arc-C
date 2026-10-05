using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.Gacha;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200470D RID: 18189
	[Token(Token = "0x200470D")]
	public class RecruitStateBean : PageSingleComponent, ISingletonNotAutoCreate, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x170041A7 RID: 16807
		// (get) Token: 0x0601B930 RID: 112944 RVA: 0x000A58B8 File Offset: 0x000A3AB8
		[Token(Token = "0x170041A7")]
		public long currentGold
		{
			[Token(Token = "0x601B930")]
			[Address(RVA = "0x14EC250", Offset = "0x14EAE50", VA = "0x1814EC250")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x0601B931 RID: 112945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B931")]
		[Address(RVA = "0x14EBA00", Offset = "0x14EA600", VA = "0x1814EBA00")]
		public void InitDataIfNeeded()
		{
		}

		// Token: 0x0601B932 RID: 112946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B932")]
		[Address(RVA = "0x14EBA70", Offset = "0x14EA670", VA = "0x1814EBA70")]
		public void LoadBuildData()
		{
		}

		// Token: 0x0601B933 RID: 112947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B933")]
		[Address(RVA = "0x14EBE60", Offset = "0x14EAA60", VA = "0x1814EBE60")]
		public void UpdateResource()
		{
		}

		// Token: 0x0601B934 RID: 112948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B934")]
		[Address(RVA = "0x14EBE00", Offset = "0x14EAA00", VA = "0x1814EBE00")]
		public void MarkForcePoolDetail()
		{
		}

		// Token: 0x0601B935 RID: 112949 RVA: 0x000A58D0 File Offset: 0x000A3AD0
		[Token(Token = "0x601B935")]
		[Address(RVA = "0x14EB690", Offset = "0x14EA290", VA = "0x1814EB690")]
		public bool ConsumeForcePoolDetail()
		{
			return default(bool);
		}

		// Token: 0x0601B936 RID: 112950 RVA: 0x000A58E8 File Offset: 0x000A3AE8
		[Token(Token = "0x601B936")]
		[Address(RVA = "0x14EAF70", Offset = "0x14E9B70", VA = "0x1814EAF70")]
		public static KeyValuePair<long, int> CalcCommonRecruitBuildCost(long costTimeMillsec, int selectedTagNum)
		{
			return default(KeyValuePair<long, int>);
		}

		// Token: 0x0601B937 RID: 112951 RVA: 0x000A5900 File Offset: 0x000A3B00
		[Token(Token = "0x601B937")]
		[Address(RVA = "0x14EB6F0", Offset = "0x14EA2F0", VA = "0x1814EB6F0")]
		public static long GetRecruitBuildMaxMillsec()
		{
			return 0L;
		}

		// Token: 0x0601B938 RID: 112952 RVA: 0x000A5918 File Offset: 0x000A3B18
		[Token(Token = "0x601B938")]
		[Address(RVA = "0x14EB5F0", Offset = "0x14EA1F0", VA = "0x1814EB5F0")]
		public static bool CheckIsSpecialTag(int tagId)
		{
			return default(bool);
		}

		// Token: 0x0601B939 RID: 112953 RVA: 0x000A5930 File Offset: 0x000A3B30
		[Token(Token = "0x601B939")]
		[Address(RVA = "0x14EB780", Offset = "0x14EA380", VA = "0x1814EB780")]
		public static int GetSpecialTagRank(int tagId)
		{
			return 0;
		}

		// Token: 0x0601B93A RID: 112954 RVA: 0x000A5948 File Offset: 0x000A3B48
		[Token(Token = "0x601B93A")]
		[Address(RVA = "0x14EB150", Offset = "0x14E9D50", VA = "0x1814EB150")]
		public long CalcFastFinishGold(int slotIndex)
		{
			return 0L;
		}

		// Token: 0x0601B93B RID: 112955 RVA: 0x000A5960 File Offset: 0x000A3B60
		[Token(Token = "0x601B93B")]
		[Address(RVA = "0x14EB4B0", Offset = "0x14EA0B0", VA = "0x1814EB4B0")]
		public bool CheckIfCanFastFinish(int slotIndex)
		{
			return default(bool);
		}

		// Token: 0x0601B93C RID: 112956 RVA: 0x000A5978 File Offset: 0x000A3B78
		[Token(Token = "0x601B93C")]
		[Address(RVA = "0x14EB880", Offset = "0x14EA480", VA = "0x1814EB880")]
		public bool HasEnoughResourceToGacha(string gachaPoolId)
		{
			return default(bool);
		}

		// Token: 0x0601B93D RID: 112957 RVA: 0x000A5990 File Offset: 0x000A3B90
		[Token(Token = "0x601B93D")]
		[Address(RVA = "0x14EB940", Offset = "0x14EA540", VA = "0x1814EB940")]
		public bool HasEnoughResourceToTenGacha(string gachaPoolId)
		{
			return default(bool);
		}

		// Token: 0x0601B93E RID: 112958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B93E")]
		[Address(RVA = "0x14EBEC0", Offset = "0x14EAAC0", VA = "0x1814EBEC0")]
		public void UpdateTopBar()
		{
		}

		// Token: 0x0601B93F RID: 112959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B93F")]
		[Address(RVA = "0x14EBF70", Offset = "0x14EAB70", VA = "0x1814EBF70")]
		private void _UpdateResource()
		{
		}

		// Token: 0x0601B940 RID: 112960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B940")]
		[Address(RVA = "0x14EC060", Offset = "0x14EAC60", VA = "0x1814EC060")]
		public RecruitStateBean()
		{
		}

		// Token: 0x04023B6F RID: 146287
		[Token(Token = "0x4023B6F")]
		public const int BUILD_SLOT_COUNT = 4;

		// Token: 0x04023B70 RID: 146288
		[Token(Token = "0x4023B70")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public GachaResult[] gachaResult;

		// Token: 0x04023B71 RID: 146289
		[Token(Token = "0x4023B71")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public GachaController.Output gachaOutput;

		// Token: 0x04023B72 RID: 146290
		[Token(Token = "0x4023B72")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public string gachaPoolDetailId;

		// Token: 0x04023B73 RID: 146291
		[Token(Token = "0x4023B73")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public bool detailNeedScroll;

		// Token: 0x04023B74 RID: 146292
		[Token(Token = "0x4023B74")]
		[FieldOffset(Offset = "0x8C")]
		[NonSerialized]
		public int detailScrollIndex;

		// Token: 0x04023B75 RID: 146293
		[Token(Token = "0x4023B75")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public GachaDetailData.GachaObjGroupType detailGroupType;

		// Token: 0x04023B76 RID: 146294
		[Token(Token = "0x4023B76")]
		[FieldOffset(Offset = "0x98")]
		public BuildSlotGroupViewProperty slotGroupProperty;

		// Token: 0x04023B77 RID: 146295
		[Token(Token = "0x4023B77")]
		[FieldOffset(Offset = "0xA0")]
		public BuildInfoViewProperty buildInfoProperty;

		// Token: 0x04023B78 RID: 146296
		[Token(Token = "0x4023B78")]
		[FieldOffset(Offset = "0xA8")]
		public BuildTopBarProperty topBarProperty;

		// Token: 0x04023B79 RID: 146297
		[Token(Token = "0x4023B79")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private ResourceBarViewProperty _resourceBarProperty;

		// Token: 0x04023B7A RID: 146298
		[Token(Token = "0x4023B7A")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_isInited;

		// Token: 0x04023B7B RID: 146299
		[Token(Token = "0x4023B7B")]
		[FieldOffset(Offset = "0xB9")]
		private bool m_needForceGetDetail;

		// Token: 0x04023B7C RID: 146300
		[Token(Token = "0x4023B7C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currentGold;

		// Token: 0x04023B7D RID: 146301
		[Token(Token = "0x4023B7D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitDataIfNeeded;

		// Token: 0x04023B7E RID: 146302
		[Token(Token = "0x4023B7E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadBuildData;

		// Token: 0x04023B7F RID: 146303
		[Token(Token = "0x4023B7F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateResource;

		// Token: 0x04023B80 RID: 146304
		[Token(Token = "0x4023B80")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_MarkForcePoolDetail;

		// Token: 0x04023B81 RID: 146305
		[Token(Token = "0x4023B81")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ConsumeForcePoolDetail;

		// Token: 0x04023B82 RID: 146306
		[Token(Token = "0x4023B82")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CalcCommonRecruitBuildCost;

		// Token: 0x04023B83 RID: 146307
		[Token(Token = "0x4023B83")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetRecruitBuildMaxMillsec;

		// Token: 0x04023B84 RID: 146308
		[Token(Token = "0x4023B84")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckIsSpecialTag;

		// Token: 0x04023B85 RID: 146309
		[Token(Token = "0x4023B85")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetSpecialTagRank;

		// Token: 0x04023B86 RID: 146310
		[Token(Token = "0x4023B86")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CalcFastFinishGold;

		// Token: 0x04023B87 RID: 146311
		[Token(Token = "0x4023B87")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckIfCanFastFinish;

		// Token: 0x04023B88 RID: 146312
		[Token(Token = "0x4023B88")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_HasEnoughResourceToGacha;

		// Token: 0x04023B89 RID: 146313
		[Token(Token = "0x4023B89")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_HasEnoughResourceToTenGacha;

		// Token: 0x04023B8A RID: 146314
		[Token(Token = "0x4023B8A")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_UpdateTopBar;

		// Token: 0x04023B8B RID: 146315
		[Token(Token = "0x4023B8B")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UpdateResource;

		// Token: 0x04023B8C RID: 146316
		[Token(Token = "0x4023B8C")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
