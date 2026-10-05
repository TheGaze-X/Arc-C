using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005937 RID: 22839
	[Token(Token = "0x2005937")]
	public class CrisisV2SettleViewModel : IHotfixable
	{
		// Token: 0x0602144F RID: 136271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602144F")]
		[Address(RVA = "0x1B94D70", Offset = "0x1B93970", VA = "0x181B94D70")]
		public void LoadData(CrisisV2SettleViewModel.Param input)
		{
		}

		// Token: 0x06021450 RID: 136272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021450")]
		[Address(RVA = "0x1B95130", Offset = "0x1B93D30", VA = "0x181B95130")]
		private void _LoadBasicInfo(CrisisV2SettleViewModel.Param input)
		{
		}

		// Token: 0x06021451 RID: 136273 RVA: 0x000B9298 File Offset: 0x000B7498
		[Token(Token = "0x6021451")]
		[Address(RVA = "0x1B954E0", Offset = "0x1B940E0", VA = "0x181B954E0")]
		private bool _LoadCommentsData(CrisisV2SettleViewModel.Param input)
		{
			return default(bool);
		}

		// Token: 0x06021452 RID: 136274 RVA: 0x000B92B0 File Offset: 0x000B74B0
		[Token(Token = "0x6021452")]
		[Address(RVA = "0x1B94E90", Offset = "0x1B93A90", VA = "0x181B94E90")]
		private int _CompareComment(CrisisV2SettleCommentItemViewModel commnet1, CrisisV2SettleCommentItemViewModel commnet2)
		{
			return 0;
		}

		// Token: 0x06021453 RID: 136275 RVA: 0x000B92C8 File Offset: 0x000B74C8
		[Token(Token = "0x6021453")]
		[Address(RVA = "0x1B95770", Offset = "0x1B94370", VA = "0x181B95770")]
		private bool _LoadRuneData(CrisisV2SettleViewModel.Param input)
		{
			return default(bool);
		}

		// Token: 0x06021454 RID: 136276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021454")]
		[Address(RVA = "0x1B95A40", Offset = "0x1B94640", VA = "0x181B95A40")]
		public CrisisV2SettleViewModel()
		{
		}

		// Token: 0x0402D585 RID: 185733
		[Token(Token = "0x402D585")]
		[FieldOffset(Offset = "0x10")]
		public bool isValid;

		// Token: 0x0402D586 RID: 185734
		[Token(Token = "0x402D586")]
		[FieldOffset(Offset = "0x14")]
		public CrisisV2SettleViewType type;

		// Token: 0x0402D587 RID: 185735
		[Token(Token = "0x402D587")]
		[FieldOffset(Offset = "0x18")]
		public bool showLeftHp;

		// Token: 0x0402D588 RID: 185736
		[Token(Token = "0x402D588")]
		[FieldOffset(Offset = "0x1C")]
		public int leftHp;

		// Token: 0x0402D589 RID: 185737
		[Token(Token = "0x402D589")]
		[FieldOffset(Offset = "0x20")]
		public string playerName;

		// Token: 0x0402D58A RID: 185738
		[Token(Token = "0x402D58A")]
		[FieldOffset(Offset = "0x28")]
		public CharUISkinStruct randomIllust;

		// Token: 0x0402D58B RID: 185739
		[Token(Token = "0x402D58B")]
		[FieldOffset(Offset = "0x40")]
		public bool needPlayHardModeVoice;

		// Token: 0x0402D58C RID: 185740
		[Token(Token = "0x402D58C")]
		[FieldOffset(Offset = "0x48")]
		public string stageCode;

		// Token: 0x0402D58D RID: 185741
		[Token(Token = "0x402D58D")]
		[FieldOffset(Offset = "0x50")]
		public string stageName;

		// Token: 0x0402D58E RID: 185742
		[Token(Token = "0x402D58E")]
		[FieldOffset(Offset = "0x58")]
		public SquadItemStruct[] squadList;

		// Token: 0x0402D58F RID: 185743
		[Token(Token = "0x402D58F")]
		[FieldOffset(Offset = "0x60")]
		public SquadItemStruct assistSquad;

		// Token: 0x0402D590 RID: 185744
		[Token(Token = "0x402D590")]
		[FieldOffset(Offset = "0x70")]
		public List<CrisisV2SettleViewModel.SquadSkinInfo> squadSkinInfoList;

		// Token: 0x0402D591 RID: 185745
		[Token(Token = "0x402D591")]
		[FieldOffset(Offset = "0x78")]
		public CrisisV2SettleViewModel.SquadSkinInfo assistSkinInfo;

		// Token: 0x0402D592 RID: 185746
		[Token(Token = "0x402D592")]
		[FieldOffset(Offset = "0x88")]
		public List<int> scoreRecordList;

		// Token: 0x0402D593 RID: 185747
		[Token(Token = "0x402D593")]
		[FieldOffset(Offset = "0x90")]
		public List<int> scoreCurrentList;

		// Token: 0x0402D594 RID: 185748
		[Token(Token = "0x402D594")]
		[FieldOffset(Offset = "0x98")]
		public List<int> scoreMaxList;

		// Token: 0x0402D595 RID: 185749
		[Token(Token = "0x402D595")]
		[FieldOffset(Offset = "0xA0")]
		public List<string> scoreDescList;

		// Token: 0x0402D596 RID: 185750
		[Token(Token = "0x402D596")]
		[FieldOffset(Offset = "0xA8")]
		public int runeCountOld;

		// Token: 0x0402D597 RID: 185751
		[Token(Token = "0x402D597")]
		[FieldOffset(Offset = "0xAC")]
		public int runeCountCurrent;

		// Token: 0x0402D598 RID: 185752
		[Token(Token = "0x402D598")]
		[FieldOffset(Offset = "0xB0")]
		public List<UIItemViewModel> rewardItems;

		// Token: 0x0402D599 RID: 185753
		[Token(Token = "0x402D599")]
		[FieldOffset(Offset = "0xB8")]
		public long timestamp;

		// Token: 0x0402D59A RID: 185754
		[Token(Token = "0x402D59A")]
		[FieldOffset(Offset = "0xC0")]
		public List<CrisisV2SettleRuneItemViewModel> runeModelList;

		// Token: 0x0402D59B RID: 185755
		[Token(Token = "0x402D59B")]
		[FieldOffset(Offset = "0xC8")]
		public bool needShowRuneMoreTips;

		// Token: 0x0402D59C RID: 185756
		[Token(Token = "0x402D59C")]
		[FieldOffset(Offset = "0xC9")]
		public bool isNewRecord;

		// Token: 0x0402D59D RID: 185757
		[Token(Token = "0x402D59D")]
		[FieldOffset(Offset = "0xCA")]
		public bool isNewComplete;

		// Token: 0x0402D59E RID: 185758
		[Token(Token = "0x402D59E")]
		[FieldOffset(Offset = "0xCC")]
		public int scoreCurrent;

		// Token: 0x0402D59F RID: 185759
		[Token(Token = "0x402D59F")]
		[FieldOffset(Offset = "0xD0")]
		public CrisisV2AppraiseType rank;

		// Token: 0x0402D5A0 RID: 185760
		[Token(Token = "0x402D5A0")]
		[FieldOffset(Offset = "0xD8")]
		public string seasonId;

		// Token: 0x0402D5A1 RID: 185761
		[Token(Token = "0x402D5A1")]
		[FieldOffset(Offset = "0xE0")]
		public bool isCommentEmpty;

		// Token: 0x0402D5A2 RID: 185762
		[Token(Token = "0x402D5A2")]
		[FieldOffset(Offset = "0xE8")]
		public List<CrisisV2SettleCommentItemViewModel> leftCommentModelList;

		// Token: 0x0402D5A3 RID: 185763
		[Token(Token = "0x402D5A3")]
		[FieldOffset(Offset = "0xF0")]
		public List<CrisisV2SettleCommentItemViewModel> rightCommentModelList;

		// Token: 0x0402D5A4 RID: 185764
		[Token(Token = "0x402D5A4")]
		[FieldOffset(Offset = "0xF8")]
		private string m_stageId;

		// Token: 0x0402D5A5 RID: 185765
		[Token(Token = "0x402D5A5")]
		[FieldOffset(Offset = "0x100")]
		private ListDict<int, CrisisV2AppraiseWrap> m_scoreToAppraiseDataMap;

		// Token: 0x0402D5A6 RID: 185766
		[Token(Token = "0x402D5A6")]
		[FieldOffset(Offset = "0x108")]
		private int m_voiceGrade;

		// Token: 0x0402D5A7 RID: 185767
		[Token(Token = "0x402D5A7")]
		[FieldOffset(Offset = "0x10C")]
		private CrisisV2StageType m_stageType;

		// Token: 0x0402D5A8 RID: 185768
		[Token(Token = "0x402D5A8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int RUNE_SLOT_SHOW_COUNT;

		// Token: 0x0402D5A9 RID: 185769
		[Token(Token = "0x402D5A9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402D5AA RID: 185770
		[Token(Token = "0x402D5AA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadBasicInfo;

		// Token: 0x0402D5AB RID: 185771
		[Token(Token = "0x402D5AB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadCommentsData;

		// Token: 0x0402D5AC RID: 185772
		[Token(Token = "0x402D5AC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CompareComment;

		// Token: 0x0402D5AD RID: 185773
		[Token(Token = "0x402D5AD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadRuneData;

		// Token: 0x0402D5AE RID: 185774
		[Token(Token = "0x402D5AE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005938 RID: 22840
		[Token(Token = "0x2005938")]
		public struct SquadSkinInfo : IHotfixable
		{
			// Token: 0x06021456 RID: 136278 RVA: 0x000B92E0 File Offset: 0x000B74E0
			[Token(Token = "0x6021456")]
			[Address(RVA = "0x1B9E030", Offset = "0x1B9CC30", VA = "0x181B9E030")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0402D5AF RID: 185775
			[Token(Token = "0x402D5AF")]
			[FieldOffset(Offset = "0x0")]
			public static CrisisV2SettleViewModel.SquadSkinInfo EMPTY;

			// Token: 0x0402D5B0 RID: 185776
			[Token(Token = "0x402D5B0")]
			[FieldOffset(Offset = "0x0")]
			public string charId;

			// Token: 0x0402D5B1 RID: 185777
			[Token(Token = "0x402D5B1")]
			[FieldOffset(Offset = "0x8")]
			public string skinId;

			// Token: 0x0402D5B2 RID: 185778
			[Token(Token = "0x402D5B2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IsEmpty;
		}

		// Token: 0x02005939 RID: 22841
		[Token(Token = "0x2005939")]
		public class Param
		{
			// Token: 0x06021458 RID: 136280 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021458")]
			[Address(RVA = "0x1B9C340", Offset = "0x1B9AF40", VA = "0x181B9C340")]
			public Param()
			{
			}

			// Token: 0x0402D5B3 RID: 185779
			[Token(Token = "0x402D5B3")]
			[FieldOffset(Offset = "0x10")]
			public CrisisV2SettleViewType inputType;

			// Token: 0x0402D5B4 RID: 185780
			[Token(Token = "0x402D5B4")]
			[FieldOffset(Offset = "0x14")]
			public bool isValid;

			// Token: 0x0402D5B5 RID: 185781
			[Token(Token = "0x402D5B5")]
			[FieldOffset(Offset = "0x18")]
			public string seasonId;

			// Token: 0x0402D5B6 RID: 185782
			[Token(Token = "0x402D5B6")]
			[FieldOffset(Offset = "0x20")]
			public CrisisV2StageType stageType;

			// Token: 0x0402D5B7 RID: 185783
			[Token(Token = "0x402D5B7")]
			[FieldOffset(Offset = "0x28")]
			public string stageCode;

			// Token: 0x0402D5B8 RID: 185784
			[Token(Token = "0x402D5B8")]
			[FieldOffset(Offset = "0x30")]
			public string stageName;

			// Token: 0x0402D5B9 RID: 185785
			[Token(Token = "0x402D5B9")]
			[FieldOffset(Offset = "0x38")]
			public long finishTs;

			// Token: 0x0402D5BA RID: 185786
			[Token(Token = "0x402D5BA")]
			[FieldOffset(Offset = "0x40")]
			public int leftHp;

			// Token: 0x0402D5BB RID: 185787
			[Token(Token = "0x402D5BB")]
			[FieldOffset(Offset = "0x48")]
			public CharUISkinStruct charIllust;

			// Token: 0x0402D5BC RID: 185788
			[Token(Token = "0x402D5BC")]
			[FieldOffset(Offset = "0x60")]
			public List<int> scoreRecordList;

			// Token: 0x0402D5BD RID: 185789
			[Token(Token = "0x402D5BD")]
			[FieldOffset(Offset = "0x68")]
			public List<int> scoreCurrentList;

			// Token: 0x0402D5BE RID: 185790
			[Token(Token = "0x402D5BE")]
			[FieldOffset(Offset = "0x70")]
			public List<int> scoreMaxList;

			// Token: 0x0402D5BF RID: 185791
			[Token(Token = "0x402D5BF")]
			[FieldOffset(Offset = "0x78")]
			public List<string> scoreDescList;

			// Token: 0x0402D5C0 RID: 185792
			[Token(Token = "0x402D5C0")]
			[FieldOffset(Offset = "0x80")]
			public int scoreCurrent;

			// Token: 0x0402D5C1 RID: 185793
			[Token(Token = "0x402D5C1")]
			[FieldOffset(Offset = "0x84")]
			public bool isNewRecord;

			// Token: 0x0402D5C2 RID: 185794
			[Token(Token = "0x402D5C2")]
			[FieldOffset(Offset = "0x88")]
			public int runeCountOld;

			// Token: 0x0402D5C3 RID: 185795
			[Token(Token = "0x402D5C3")]
			[FieldOffset(Offset = "0x8C")]
			public int runeCountCurrent;

			// Token: 0x0402D5C4 RID: 185796
			[Token(Token = "0x402D5C4")]
			[FieldOffset(Offset = "0x90")]
			public List<CrisisV2SettleCommentItemViewModel> commentList;

			// Token: 0x0402D5C5 RID: 185797
			[Token(Token = "0x402D5C5")]
			[FieldOffset(Offset = "0x98")]
			public List<CrisisV2SettleRuneItemViewModel> runeList;

			// Token: 0x0402D5C6 RID: 185798
			[Token(Token = "0x402D5C6")]
			[FieldOffset(Offset = "0xA0")]
			public SquadItemStruct[] squadList;

			// Token: 0x0402D5C7 RID: 185799
			[Token(Token = "0x402D5C7")]
			[FieldOffset(Offset = "0xA8")]
			public SquadItemStruct assistSquad;

			// Token: 0x0402D5C8 RID: 185800
			[Token(Token = "0x402D5C8")]
			[FieldOffset(Offset = "0xB8")]
			public List<CrisisV2SettleViewModel.SquadSkinInfo> squadSkinInfoList;

			// Token: 0x0402D5C9 RID: 185801
			[Token(Token = "0x402D5C9")]
			[FieldOffset(Offset = "0xC0")]
			public CrisisV2SettleViewModel.SquadSkinInfo assistSkinInfo;
		}
	}
}
