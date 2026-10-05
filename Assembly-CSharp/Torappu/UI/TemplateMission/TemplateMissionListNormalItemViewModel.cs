using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003DAE RID: 15790
	[Token(Token = "0x2003DAE")]
	public class TemplateMissionListNormalItemViewModel : ITemplateMissionListItemViewModel, IHotfixable
	{
		// Token: 0x17003A8C RID: 14988
		// (get) Token: 0x060188BC RID: 100540 RVA: 0x0009AAD0 File Offset: 0x00098CD0
		// (set) Token: 0x060188BD RID: 100541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003A8C")]
		public MissionHoldingState state
		{
			[Token(Token = "0x60188BC")]
			[Address(RVA = "0x1113F70", Offset = "0x1112B70", VA = "0x181113F70")]
			[CompilerGenerated]
			get
			{
				return MissionHoldingState.NOT_OPEN;
			}
			[Token(Token = "0x60188BD")]
			[Address(RVA = "0x11144A0", Offset = "0x11130A0", VA = "0x1811144A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003A8D RID: 14989
		// (get) Token: 0x060188BE RID: 100542 RVA: 0x0009AAE8 File Offset: 0x00098CE8
		// (set) Token: 0x060188BF RID: 100543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003A8D")]
		public int target
		{
			[Token(Token = "0x60188BE")]
			[Address(RVA = "0x1114030", Offset = "0x1112C30", VA = "0x181114030")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60188BF")]
			[Address(RVA = "0x1114590", Offset = "0x1113190", VA = "0x181114590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003A8E RID: 14990
		// (get) Token: 0x060188C0 RID: 100544 RVA: 0x0009AB00 File Offset: 0x00098D00
		// (set) Token: 0x060188C1 RID: 100545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003A8E")]
		public int value
		{
			[Token(Token = "0x60188C0")]
			[Address(RVA = "0x11140F0", Offset = "0x1112CF0", VA = "0x1811140F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60188C1")]
			[Address(RVA = "0x1114680", Offset = "0x1113280", VA = "0x181114680")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003A8F RID: 14991
		// (get) Token: 0x060188C2 RID: 100546 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060188C3 RID: 100547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003A8F")]
		public MissionData data
		{
			[Token(Token = "0x60188C2")]
			[Address(RVA = "0x1113BA0", Offset = "0x11127A0", VA = "0x181113BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60188C3")]
			[Address(RVA = "0x1114150", Offset = "0x1112D50", VA = "0x181114150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003A90 RID: 14992
		// (get) Token: 0x060188C4 RID: 100548 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060188C5 RID: 100549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003A90")]
		public List<MissionDisplayRewards> rewardList
		{
			[Token(Token = "0x60188C4")]
			[Address(RVA = "0x1113DF0", Offset = "0x11129F0", VA = "0x181113DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60188C5")]
			[Address(RVA = "0x11142D0", Offset = "0x1112ED0", VA = "0x1811142D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003A91 RID: 14993
		// (get) Token: 0x060188C6 RID: 100550 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060188C7 RID: 100551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003A91")]
		public DataBundle meta
		{
			[Token(Token = "0x60188C6")]
			[Address(RVA = "0x1113D30", Offset = "0x1112930", VA = "0x181113D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60188C7")]
			[Address(RVA = "0x11141D0", Offset = "0x1112DD0", VA = "0x1811141D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003A92 RID: 14994
		// (get) Token: 0x060188C8 RID: 100552 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060188C9 RID: 100553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003A92")]
		public TemplateMissionStyleData styleData
		{
			[Token(Token = "0x60188C8")]
			[Address(RVA = "0x1113FD0", Offset = "0x1112BD0", VA = "0x181113FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60188C9")]
			[Address(RVA = "0x1114510", Offset = "0x1113110", VA = "0x181114510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003A93 RID: 14995
		// (get) Token: 0x060188CA RID: 100554 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060188CB RID: 100555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003A93")]
		public TemplateMissionGroupSource param
		{
			[Token(Token = "0x60188CA")]
			[Address(RVA = "0x1113D90", Offset = "0x1112990", VA = "0x181113D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60188CB")]
			[Address(RVA = "0x1114250", Offset = "0x1112E50", VA = "0x181114250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003A94 RID: 14996
		// (get) Token: 0x060188CC RID: 100556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A94")]
		public string description
		{
			[Token(Token = "0x60188CC")]
			[Address(RVA = "0x1113C00", Offset = "0x1112800", VA = "0x181113C00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A95 RID: 14997
		// (get) Token: 0x060188CD RID: 100557 RVA: 0x0009AB18 File Offset: 0x00098D18
		// (set) Token: 0x060188CE RID: 100558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003A95")]
		public int sortId
		{
			[Token(Token = "0x60188CD")]
			[Address(RVA = "0x1113F10", Offset = "0x1112B10", VA = "0x181113F10")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60188CE")]
			[Address(RVA = "0x1114430", Offset = "0x1113030", VA = "0x181114430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003A96 RID: 14998
		// (get) Token: 0x060188CF RID: 100559 RVA: 0x0009AB30 File Offset: 0x00098D30
		// (set) Token: 0x060188D0 RID: 100560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003A96")]
		public bool showCountRemainTip
		{
			[Token(Token = "0x60188CF")]
			[Address(RVA = "0x1113E50", Offset = "0x1112A50", VA = "0x181113E50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60188D0")]
			[Address(RVA = "0x1114350", Offset = "0x1112F50", VA = "0x181114350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003A97 RID: 14999
		// (get) Token: 0x060188D1 RID: 100561 RVA: 0x0009AB48 File Offset: 0x00098D48
		// (set) Token: 0x060188D2 RID: 100562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003A97")]
		public bool showEndRemainTip
		{
			[Token(Token = "0x60188D1")]
			[Address(RVA = "0x1113EB0", Offset = "0x1112AB0", VA = "0x181113EB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60188D2")]
			[Address(RVA = "0x11143C0", Offset = "0x1112FC0", VA = "0x1811143C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003A98 RID: 15000
		// (get) Token: 0x060188D3 RID: 100563 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060188D4 RID: 100564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003A98")]
		public string textRemainTip
		{
			[Token(Token = "0x60188D3")]
			[Address(RVA = "0x1114090", Offset = "0x1112C90", VA = "0x181114090")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60188D4")]
			[Address(RVA = "0x1114600", Offset = "0x1113200", VA = "0x181114600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060188D5 RID: 100565 RVA: 0x0009AB60 File Offset: 0x00098D60
		[Token(Token = "0x60188D5")]
		[Address(RVA = "0x1112FA0", Offset = "0x1111BA0", VA = "0x181112FA0", Slot = "4")]
		public TemplateMissionListItemViewType GetItemViewType()
		{
			return TemplateMissionListItemViewType.NORMAL_ITEM;
		}

		// Token: 0x060188D6 RID: 100566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188D6")]
		[Address(RVA = "0x11136F0", Offset = "0x11122F0", VA = "0x1811136F0")]
		public TemplateMissionListNormalItemViewModel(int groupIndex, TemplateMissionGroupSource groupInfo, TemplateMissionStyleData styleData_, MissionHoldingState state_, int target_, int value_, List<MissionDisplayRewards> rewards, MissionData data_, MissionGroup groupData, [Optional] DataBundle meta_)
		{
		}

		// Token: 0x060188D7 RID: 100567 RVA: 0x0009AB78 File Offset: 0x00098D78
		[Token(Token = "0x60188D7")]
		[Address(RVA = "0x11132E0", Offset = "0x1111EE0", VA = "0x1811132E0")]
		public bool IsMissionValid(long currTs)
		{
			return default(bool);
		}

		// Token: 0x060188D8 RID: 100568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60188D8")]
		[Address(RVA = "0x1113000", Offset = "0x1111C00", VA = "0x181113000")]
		public List<AbstractTemplateMissionRewardItemViewModel> GetRewardPreviewItems()
		{
			return null;
		}

		// Token: 0x060188D9 RID: 100569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188D9")]
		[Address(RVA = "0x1113420", Offset = "0x1112020", VA = "0x181113420")]
		public void UpdateRemainTimeTip(long currTs)
		{
		}

		// Token: 0x060188DA RID: 100570 RVA: 0x0009AB90 File Offset: 0x00098D90
		[Token(Token = "0x60188DA")]
		[Address(RVA = "0x1112E50", Offset = "0x1111A50", VA = "0x181112E50")]
		public bool CheckIfAbleToClaim()
		{
			return default(bool);
		}

		// Token: 0x0401E191 RID: 123281
		[Token(Token = "0x401E191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MissionGroup m_groupData;

		// Token: 0x0401E192 RID: 123282
		[Token(Token = "0x401E192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0401E193 RID: 123283
		[Token(Token = "0x401E193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_state;

		// Token: 0x0401E194 RID: 123284
		[Token(Token = "0x401E194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_target;

		// Token: 0x0401E195 RID: 123285
		[Token(Token = "0x401E195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_target;

		// Token: 0x0401E196 RID: 123286
		[Token(Token = "0x401E196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_value;

		// Token: 0x0401E197 RID: 123287
		[Token(Token = "0x401E197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_value;

		// Token: 0x0401E198 RID: 123288
		[Token(Token = "0x401E198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_data;

		// Token: 0x0401E199 RID: 123289
		[Token(Token = "0x401E199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_data;

		// Token: 0x0401E19A RID: 123290
		[Token(Token = "0x401E19A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_rewardList;

		// Token: 0x0401E19B RID: 123291
		[Token(Token = "0x401E19B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_rewardList;

		// Token: 0x0401E19C RID: 123292
		[Token(Token = "0x401E19C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_meta;

		// Token: 0x0401E19D RID: 123293
		[Token(Token = "0x401E19D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_meta;

		// Token: 0x0401E19E RID: 123294
		[Token(Token = "0x401E19E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_styleData;

		// Token: 0x0401E19F RID: 123295
		[Token(Token = "0x401E19F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_styleData;

		// Token: 0x0401E1A0 RID: 123296
		[Token(Token = "0x401E1A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_param;

		// Token: 0x0401E1A1 RID: 123297
		[Token(Token = "0x401E1A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_param;

		// Token: 0x0401E1A2 RID: 123298
		[Token(Token = "0x401E1A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_description;

		// Token: 0x0401E1A3 RID: 123299
		[Token(Token = "0x401E1A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0401E1A4 RID: 123300
		[Token(Token = "0x401E1A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_set_sortId;

		// Token: 0x0401E1A5 RID: 123301
		[Token(Token = "0x401E1A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_showCountRemainTip;

		// Token: 0x0401E1A6 RID: 123302
		[Token(Token = "0x401E1A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_set_showCountRemainTip;

		// Token: 0x0401E1A7 RID: 123303
		[Token(Token = "0x401E1A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_showEndRemainTip;

		// Token: 0x0401E1A8 RID: 123304
		[Token(Token = "0x401E1A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_set_showEndRemainTip;

		// Token: 0x0401E1A9 RID: 123305
		[Token(Token = "0x401E1A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_textRemainTip;

		// Token: 0x0401E1AA RID: 123306
		[Token(Token = "0x401E1AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_set_textRemainTip;

		// Token: 0x0401E1AB RID: 123307
		[Token(Token = "0x401E1AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetItemViewType;

		// Token: 0x0401E1AC RID: 123308
		[Token(Token = "0x401E1AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401E1AD RID: 123309
		[Token(Token = "0x401E1AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_IsMissionValid;

		// Token: 0x0401E1AE RID: 123310
		[Token(Token = "0x401E1AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GetRewardPreviewItems;

		// Token: 0x0401E1AF RID: 123311
		[Token(Token = "0x401E1AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_UpdateRemainTimeTip;

		// Token: 0x0401E1B0 RID: 123312
		[Token(Token = "0x401E1B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_CheckIfAbleToClaim;
	}
}
