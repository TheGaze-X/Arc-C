using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200735B RID: 29531
	[Token(Token = "0x200735B")]
	public class Act42D0NormalFinishInfoModel : Act42D0FinishInfoModel
	{
		// Token: 0x1700629B RID: 25243
		// (get) Token: 0x06029C31 RID: 171057 RVA: 0x000D67B8 File Offset: 0x000D49B8
		[Token(Token = "0x1700629B")]
		public bool isRatingNew
		{
			[Token(Token = "0x6029C31")]
			[Address(RVA = "0x25614B0", Offset = "0x25600B0", VA = "0x1825614B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700629C RID: 25244
		// (get) Token: 0x06029C32 RID: 171058 RVA: 0x000D67D0 File Offset: 0x000D49D0
		[Token(Token = "0x1700629C")]
		public int ratingLevel
		{
			[Token(Token = "0x6029C32")]
			[Address(RVA = "0x25616B0", Offset = "0x25602B0", VA = "0x1825616B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700629D RID: 25245
		// (get) Token: 0x06029C33 RID: 171059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700629D")]
		public string ratingAudioSignal
		{
			[Token(Token = "0x6029C33")]
			[Address(RVA = "0x2561510", Offset = "0x2560110", VA = "0x182561510")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700629E RID: 25246
		// (get) Token: 0x06029C34 RID: 171060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700629E")]
		public string stageCode
		{
			[Token(Token = "0x6029C34")]
			[Address(RVA = "0x2561710", Offset = "0x2560310", VA = "0x182561710")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700629F RID: 25247
		// (get) Token: 0x06029C35 RID: 171061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700629F")]
		public string ratingIconName
		{
			[Token(Token = "0x6029C35")]
			[Address(RVA = "0x2561640", Offset = "0x2560240", VA = "0x182561640")]
			get
			{
				return null;
			}
		}

		// Token: 0x170062A0 RID: 25248
		// (get) Token: 0x06029C36 RID: 171062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170062A0")]
		public string ratingDesc
		{
			[Token(Token = "0x6029C36")]
			[Address(RVA = "0x25615B0", Offset = "0x25601B0", VA = "0x1825615B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170062A1 RID: 25249
		// (get) Token: 0x06029C37 RID: 171063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170062A1")]
		public List<Act42D0Data.Act42D0EffectInfoData> effectDataList
		{
			[Token(Token = "0x6029C37")]
			[Address(RVA = "0x2561450", Offset = "0x2560050", VA = "0x182561450")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029C38 RID: 171064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029C38")]
		[Address(RVA = "0x2561260", Offset = "0x255FE60", VA = "0x182561260")]
		private Act42D0Data.Act42D0RatingInfoData _FindRatingInfo(Act42D0Data.Act42D0StageRatingInfoData stageRatingInfo)
		{
			return null;
		}

		// Token: 0x06029C39 RID: 171065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029C39")]
		[Address(RVA = "0x2560D70", Offset = "0x255F970", VA = "0x182560D70", Slot = "6")]
		public override string GetStageName()
		{
			return null;
		}

		// Token: 0x06029C3A RID: 171066 RVA: 0x000D67E8 File Offset: 0x000D49E8
		[Token(Token = "0x6029C3A")]
		[Address(RVA = "0x2560E00", Offset = "0x255FA00", VA = "0x182560E00", Slot = "5")]
		public override Act42D0FinishInfoModel.ViewType GetViewType()
		{
			return Act42D0FinishInfoModel.ViewType.NONE;
		}

		// Token: 0x06029C3B RID: 171067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C3B")]
		[Address(RVA = "0x2560E60", Offset = "0x255FA60", VA = "0x182560E60", Slot = "4")]
		public override void LoadData(Act42D0Data actData, CommonFinishBattleResponse response)
		{
		}

		// Token: 0x06029C3C RID: 171068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029C3C")]
		[Address(RVA = "0x2560D00", Offset = "0x255F900", VA = "0x182560D00", Slot = "7")]
		public override string GetDisplayIconId()
		{
			return null;
		}

		// Token: 0x06029C3D RID: 171069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C3D")]
		[Address(RVA = "0x2561350", Offset = "0x255FF50", VA = "0x182561350")]
		public Act42D0NormalFinishInfoModel()
		{
		}

		// Token: 0x0403BC6C RID: 244844
		[Token(Token = "0x403BC6C")]
		private const int RATING_MIN_LEVEL = 1;

		// Token: 0x0403BC6D RID: 244845
		[Token(Token = "0x403BC6D")]
		private const int RATING_MAX_LEVEL = 5;

		// Token: 0x0403BC6E RID: 244846
		[Token(Token = "0x403BC6E")]
		[FieldOffset(Offset = "0x28")]
		private int m_ratingLv;

		// Token: 0x0403BC6F RID: 244847
		[Token(Token = "0x403BC6F")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_isRatingNew;

		// Token: 0x0403BC70 RID: 244848
		[Token(Token = "0x403BC70")]
		[FieldOffset(Offset = "0x30")]
		private List<Act42D0Data.Act42D0EffectInfoData> m_effectDataList;

		// Token: 0x0403BC71 RID: 244849
		[Token(Token = "0x403BC71")]
		[FieldOffset(Offset = "0x38")]
		private Act42D0Data.Act42D0StageInfoData m_stageInfo;

		// Token: 0x0403BC72 RID: 244850
		[Token(Token = "0x403BC72")]
		[FieldOffset(Offset = "0x40")]
		private Act42D0Data.Act42D0StageRatingInfoData m_stageRatingInfo;

		// Token: 0x0403BC73 RID: 244851
		[Token(Token = "0x403BC73")]
		[FieldOffset(Offset = "0x48")]
		private Act42D0Data.Act42D0RatingInfoData m_currentRatingInfo;

		// Token: 0x0403BC74 RID: 244852
		[Token(Token = "0x403BC74")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isRatingNew;

		// Token: 0x0403BC75 RID: 244853
		[Token(Token = "0x403BC75")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_ratingLevel;

		// Token: 0x0403BC76 RID: 244854
		[Token(Token = "0x403BC76")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_ratingAudioSignal;

		// Token: 0x0403BC77 RID: 244855
		[Token(Token = "0x403BC77")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_stageCode;

		// Token: 0x0403BC78 RID: 244856
		[Token(Token = "0x403BC78")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_ratingIconName;

		// Token: 0x0403BC79 RID: 244857
		[Token(Token = "0x403BC79")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_ratingDesc;

		// Token: 0x0403BC7A RID: 244858
		[Token(Token = "0x403BC7A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_effectDataList;

		// Token: 0x0403BC7B RID: 244859
		[Token(Token = "0x403BC7B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FindRatingInfo;

		// Token: 0x0403BC7C RID: 244860
		[Token(Token = "0x403BC7C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetStageName;

		// Token: 0x0403BC7D RID: 244861
		[Token(Token = "0x403BC7D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0403BC7E RID: 244862
		[Token(Token = "0x403BC7E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403BC7F RID: 244863
		[Token(Token = "0x403BC7F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetDisplayIconId;

		// Token: 0x0403BC80 RID: 244864
		[Token(Token = "0x403BC80")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
