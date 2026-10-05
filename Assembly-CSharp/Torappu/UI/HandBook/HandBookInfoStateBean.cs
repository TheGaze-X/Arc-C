using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.CharacterInfo;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066B6 RID: 26294
	[Token(Token = "0x20066B6")]
	public class HandBookInfoStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x06025C34 RID: 154676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C34")]
		[Address(RVA = "0x20A9240", Offset = "0x20A7E40", VA = "0x1820A9240")]
		public void LoadData(string charIdImport, bool isNPC)
		{
		}

		// Token: 0x06025C35 RID: 154677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C35")]
		[Address(RVA = "0x20A96F0", Offset = "0x20A82F0", VA = "0x1820A96F0")]
		public void LoadData(CharacterInfoHolderBean.CharViewModel charDetailModel)
		{
		}

		// Token: 0x06025C36 RID: 154678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C36")]
		[Address(RVA = "0x20A9D20", Offset = "0x20A8920", VA = "0x1820A9D20")]
		private void _LoadCVInfo(HandBookCardViewModel selectedCardData)
		{
		}

		// Token: 0x06025C37 RID: 154679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C37")]
		[Address(RVA = "0x20A8070", Offset = "0x20A6C70", VA = "0x1820A8070")]
		public void LoadData(HandBookCardViewModel selectedCardData)
		{
		}

		// Token: 0x06025C38 RID: 154680 RVA: 0x000C8EB0 File Offset: 0x000C70B0
		[Token(Token = "0x6025C38")]
		[Address(RVA = "0x20A9B20", Offset = "0x20A8720", VA = "0x1820A9B20")]
		public bool TryFindAvgData(string storyId, out HandbookAvgGroupData groupData, out HandbookAvgData avgData)
		{
			return default(bool);
		}

		// Token: 0x06025C39 RID: 154681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C39")]
		[Address(RVA = "0x20A9960", Offset = "0x20A8560", VA = "0x1820A9960")]
		public void RefreshVoiceLangInfo()
		{
		}

		// Token: 0x06025C3A RID: 154682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025C3A")]
		[Address(RVA = "0x20AA440", Offset = "0x20A9040", VA = "0x1820AA440")]
		private List<HandBookInfoTextViewModel> _LoadNPCCharTextInfo(HandBookCardViewModel cardData)
		{
			return null;
		}

		// Token: 0x06025C3B RID: 154683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025C3B")]
		[Address(RVA = "0x20AA010", Offset = "0x20A8C10", VA = "0x1820AA010")]
		private List<HandBookInfoTextViewModel> _LoadCommonCharTextInfo(HandBookCardViewModel cardData)
		{
			return null;
		}

		// Token: 0x06025C3C RID: 154684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025C3C")]
		[Address(RVA = "0x20A9F70", Offset = "0x20A8B70", VA = "0x1820A9F70")]
		private List<HandBookInfoTextViewModel> _LoadCharTextInfo(HandBookCardViewModel cardData)
		{
			return null;
		}

		// Token: 0x06025C3D RID: 154685 RVA: 0x000C8EC8 File Offset: 0x000C70C8
		[Token(Token = "0x6025C3D")]
		[Address(RVA = "0x20AA780", Offset = "0x20A9380", VA = "0x1820AA780")]
		private static bool _TryToLoadVoiceLangInfoFromCard(HandBookCardViewModel cardData, out HandBookInfoStateBean.VoiceLangInfoStruct voiceLangInfo)
		{
			return default(bool);
		}

		// Token: 0x06025C3E RID: 154686 RVA: 0x000C8EE0 File Offset: 0x000C70E0
		[Token(Token = "0x6025C3E")]
		[Address(RVA = "0x20AABC0", Offset = "0x20A97C0", VA = "0x1820AABC0")]
		private static bool _TryToLoadVoiceLangInfo(string skinId, VoiceLangType voiceLangType, ref HandBookInfoStateBean.VoiceLangInfoStruct voiceLangInfo)
		{
			return default(bool);
		}

		// Token: 0x06025C3F RID: 154687 RVA: 0x000C8EF8 File Offset: 0x000C70F8
		[Token(Token = "0x6025C3F")]
		[Address(RVA = "0x20A7780", Offset = "0x20A6380", VA = "0x1820A7780")]
		public static bool CheckAllCardShow(HandBookCardViewModel cardData, HandBookStoryViewData dataInfo, out List<HandBookStoryViewData.StoryText> result)
		{
			return default(bool);
		}

		// Token: 0x06025C40 RID: 154688 RVA: 0x000C8F10 File Offset: 0x000C7110
		[Token(Token = "0x6025C40")]
		[Address(RVA = "0x20A7980", Offset = "0x20A6580", VA = "0x1820A7980")]
		public static bool CheckCardShow(HandBookCardViewModel cardData, HandBookStoryViewData.StoryText storyText)
		{
			return default(bool);
		}

		// Token: 0x06025C41 RID: 154689 RVA: 0x000C8F28 File Offset: 0x000C7128
		[Token(Token = "0x6025C41")]
		[Address(RVA = "0x20A7A10", Offset = "0x20A6610", VA = "0x1820A7A10")]
		public static bool CheckCardUnlock(HandBookCardViewModel cardData, HandBookStoryViewData.StoryText storyText)
		{
			return default(bool);
		}

		// Token: 0x06025C42 RID: 154690 RVA: 0x000C8F40 File Offset: 0x000C7140
		[Token(Token = "0x6025C42")]
		[Address(RVA = "0x20A7B00", Offset = "0x20A6700", VA = "0x1820A7B00")]
		public static bool CheckCardisLocked(HandBookCardViewModel cardData, HandBookStoryViewData.StoryText storyText)
		{
			return default(bool);
		}

		// Token: 0x06025C43 RID: 154691 RVA: 0x000C8F58 File Offset: 0x000C7158
		[Token(Token = "0x6025C43")]
		[Address(RVA = "0x20A7D10", Offset = "0x20A6910", VA = "0x1820A7D10")]
		public static bool CheckExist(HandBookCardViewModel cardData, DataUnlockType type, string param)
		{
			return default(bool);
		}

		// Token: 0x06025C44 RID: 154692 RVA: 0x000C8F70 File Offset: 0x000C7170
		[Token(Token = "0x6025C44")]
		[Address(RVA = "0x20A7C00", Offset = "0x20A6800", VA = "0x1820A7C00")]
		public static bool CheckExist(HandBookCardViewModel cardData, HandBookStoryViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x06025C45 RID: 154693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C45")]
		[Address(RVA = "0x20AAEE0", Offset = "0x20A9AE0", VA = "0x1820AAEE0")]
		public HandBookInfoStateBean()
		{
		}

		// Token: 0x0403515F RID: 217439
		[Token(Token = "0x403515F")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public HandBookInfoStateBean.HandBookInfoViewModel viewModel;

		// Token: 0x04035160 RID: 217440
		[Token(Token = "0x4035160")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public HandBookCardViewModel selectedCard;

		// Token: 0x04035161 RID: 217441
		[Token(Token = "0x4035161")]
		[FieldOffset(Offset = "0x28")]
		public CharacterIllustViewProperty illustProperty;

		// Token: 0x04035162 RID: 217442
		[Token(Token = "0x4035162")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public TrackPointViewProperty avgTrackPointProperty;

		// Token: 0x04035163 RID: 217443
		[Token(Token = "0x4035163")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public TrackPointViewProperty stageTrackPointProperty;

		// Token: 0x04035164 RID: 217444
		[Token(Token = "0x4035164")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public string drawName;

		// Token: 0x04035165 RID: 217445
		[Token(Token = "0x4035165")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public bool haveDesigner;

		// Token: 0x04035166 RID: 217446
		[Token(Token = "0x4035166")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public string designerName;

		// Token: 0x04035167 RID: 217447
		[Token(Token = "0x4035167")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public string infoName;

		// Token: 0x04035168 RID: 217448
		[Token(Token = "0x4035168")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public bool hasMultiVoiceLang;

		// Token: 0x04035169 RID: 217449
		[Token(Token = "0x4035169")]
		[FieldOffset(Offset = "0x61")]
		[NonSerialized]
		public bool hasNoResForVoiceLang;

		// Token: 0x0403516A RID: 217450
		[Token(Token = "0x403516A")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public HandBookVoiceLangViewProperty voiceLangViewProperty;

		// Token: 0x0403516B RID: 217451
		[Token(Token = "0x403516B")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public TrackPointViewProperty newVoiceTrackPointProperty;

		// Token: 0x0403516C RID: 217452
		[Token(Token = "0x403516C")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public HandBookDesignerViewProperty designerViewProperty;

		// Token: 0x0403516D RID: 217453
		[Token(Token = "0x403516D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403516E RID: 217454
		[Token(Token = "0x403516E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_LoadData;

		// Token: 0x0403516F RID: 217455
		[Token(Token = "0x403516F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadCVInfo;

		// Token: 0x04035170 RID: 217456
		[Token(Token = "0x4035170")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix2_LoadData;

		// Token: 0x04035171 RID: 217457
		[Token(Token = "0x4035171")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryFindAvgData;

		// Token: 0x04035172 RID: 217458
		[Token(Token = "0x4035172")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshVoiceLangInfo;

		// Token: 0x04035173 RID: 217459
		[Token(Token = "0x4035173")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadNPCCharTextInfo;

		// Token: 0x04035174 RID: 217460
		[Token(Token = "0x4035174")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadCommonCharTextInfo;

		// Token: 0x04035175 RID: 217461
		[Token(Token = "0x4035175")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadCharTextInfo;

		// Token: 0x04035176 RID: 217462
		[Token(Token = "0x4035176")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryToLoadVoiceLangInfoFromCard;

		// Token: 0x04035177 RID: 217463
		[Token(Token = "0x4035177")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryToLoadVoiceLangInfo;

		// Token: 0x04035178 RID: 217464
		[Token(Token = "0x4035178")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckAllCardShow;

		// Token: 0x04035179 RID: 217465
		[Token(Token = "0x4035179")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CheckCardShow;

		// Token: 0x0403517A RID: 217466
		[Token(Token = "0x403517A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CheckCardUnlock;

		// Token: 0x0403517B RID: 217467
		[Token(Token = "0x403517B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CheckCardisLocked;

		// Token: 0x0403517C RID: 217468
		[Token(Token = "0x403517C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CheckExist;

		// Token: 0x0403517D RID: 217469
		[Token(Token = "0x403517D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix1_CheckExist;

		// Token: 0x0403517E RID: 217470
		[Token(Token = "0x403517E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020066B7 RID: 26295
		[Token(Token = "0x20066B7")]
		private struct VoiceLangInfoStruct
		{
			// Token: 0x0403517F RID: 217471
			[Token(Token = "0x403517F")]
			[FieldOffset(Offset = "0x0")]
			public string cvName;

			// Token: 0x04035180 RID: 217472
			[Token(Token = "0x4035180")]
			[FieldOffset(Offset = "0x8")]
			public bool hasMultiVoiceLang;

			// Token: 0x04035181 RID: 217473
			[Token(Token = "0x4035181")]
			[FieldOffset(Offset = "0x9")]
			public bool hasNoResForVoiceLang;

			// Token: 0x04035182 RID: 217474
			[Token(Token = "0x4035182")]
			[FieldOffset(Offset = "0x10")]
			public HandBookVoiceLangViewModel viewModel;
		}

		// Token: 0x020066B8 RID: 26296
		[Token(Token = "0x20066B8")]
		public class HandBookInfoViewModel
		{
			// Token: 0x06025C47 RID: 154695 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025C47")]
			[Address(RVA = "0x20BD490", Offset = "0x20BC090", VA = "0x1820BD490")]
			public HandBookInfoViewModel()
			{
			}

			// Token: 0x04035183 RID: 217475
			[Token(Token = "0x4035183")]
			[FieldOffset(Offset = "0x10")]
			public List<HandBookInfoTextViewModel> infoList;

			// Token: 0x04035184 RID: 217476
			[Token(Token = "0x4035184")]
			[FieldOffset(Offset = "0x18")]
			public List<HandBookStoryViewModel> storyList;

			// Token: 0x04035185 RID: 217477
			[Token(Token = "0x4035185")]
			[FieldOffset(Offset = "0x20")]
			public List<HandBookAvgGroupViewModel> avgList;

			// Token: 0x04035186 RID: 217478
			[Token(Token = "0x4035186")]
			[FieldOffset(Offset = "0x28")]
			public HandBookStageViewModel stageViewModel;
		}
	}
}
