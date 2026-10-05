using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D7F RID: 19839
	[Token(Token = "0x2004D7F")]
	public class NameCardV2ViewModel : IHotfixable
	{
		// Token: 0x1700459E RID: 17822
		// (get) Token: 0x0601DB02 RID: 121602 RVA: 0x000AC458 File Offset: 0x000AA658
		// (set) Token: 0x0601DB03 RID: 121603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700459E")]
		public bool hasSelfMagazineSquad
		{
			[Token(Token = "0x601DB02")]
			[Address(RVA = "0x174DF10", Offset = "0x174CB10", VA = "0x18174DF10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601DB03")]
			[Address(RVA = "0x174DFE0", Offset = "0x174CBE0", VA = "0x18174DFE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700459F RID: 17823
		// (get) Token: 0x0601DB04 RID: 121604 RVA: 0x000AC470 File Offset: 0x000AA670
		// (set) Token: 0x0601DB05 RID: 121605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700459F")]
		public bool albumValid
		{
			[Token(Token = "0x601DB04")]
			[Address(RVA = "0x174DEB0", Offset = "0x174CAB0", VA = "0x18174DEB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601DB05")]
			[Address(RVA = "0x174DF70", Offset = "0x174CB70", VA = "0x18174DF70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601DB06 RID: 121606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB06")]
		[Address(RVA = "0x174B270", Offset = "0x1749E70", VA = "0x18174B270")]
		public void LoadSelfData([Optional] string overrideSkinId, NameCardV2ViewModel.ShowDetailOption showDetailOpt = NameCardV2ViewModel.ShowDetailOption.READ_FROM_MISC)
		{
		}

		// Token: 0x0601DB07 RID: 121607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB07")]
		[Address(RVA = "0x174B490", Offset = "0x174A090", VA = "0x18174B490")]
		public void RefreshSelfData([Optional] string overrideSkinId, NameCardV2ViewModel.ShowDetailOption showDetailOpt = NameCardV2ViewModel.ShowDetailOption.READ_FROM_MISC)
		{
		}

		// Token: 0x0601DB08 RID: 121608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB08")]
		[Address(RVA = "0x174B100", Offset = "0x1749D00", VA = "0x18174B100")]
		public void LoadFriendData(FriendDataWithNameCard data)
		{
		}

		// Token: 0x0601DB09 RID: 121609 RVA: 0x000AC488 File Offset: 0x000AA688
		[Token(Token = "0x601DB09")]
		[Address(RVA = "0x174B030", Offset = "0x1749C30", VA = "0x18174B030")]
		public bool CanSelectModule()
		{
			return default(bool);
		}

		// Token: 0x0601DB0A RID: 121610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB0A")]
		[Address(RVA = "0x174B730", Offset = "0x174A330", VA = "0x18174B730")]
		public void SelectModule(string moduleId)
		{
		}

		// Token: 0x0601DB0B RID: 121611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB0B")]
		[Address(RVA = "0x174C7C0", Offset = "0x174B3C0", VA = "0x18174C7C0")]
		public void UnselectModule(string moduleId)
		{
		}

		// Token: 0x0601DB0C RID: 121612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB0C")]
		[Address(RVA = "0x174C620", Offset = "0x174B220", VA = "0x18174C620")]
		public void SwitchOperatorStyle(string moduleId)
		{
		}

		// Token: 0x0601DB0D RID: 121613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB0D")]
		[Address(RVA = "0x174C200", Offset = "0x174AE00", VA = "0x18174C200")]
		public void SwitchAssistModuleStyle(string moduleId)
		{
		}

		// Token: 0x0601DB0E RID: 121614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB0E")]
		[Address(RVA = "0x174C3A0", Offset = "0x174AFA0", VA = "0x18174C3A0")]
		public void SwitchEquipModuleStyle(string moduleId)
		{
		}

		// Token: 0x0601DB0F RID: 121615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB0F")]
		[Address(RVA = "0x174BDF0", Offset = "0x174A9F0", VA = "0x18174BDF0")]
		public void SetNameCardShowType(NameCardV2ViewModel.ShowType type)
		{
		}

		// Token: 0x0601DB10 RID: 121616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB10")]
		[Address(RVA = "0x174B850", Offset = "0x174A450", VA = "0x18174B850")]
		public void SetNameCardMisc(NameCardMiscModel misc, NameCardV2ViewModel.SetMiscOption option)
		{
		}

		// Token: 0x0601DB11 RID: 121617 RVA: 0x000AC4A0 File Offset: 0x000AA6A0
		[Token(Token = "0x601DB11")]
		[Address(RVA = "0x174D9A0", Offset = "0x174C5A0", VA = "0x18174D9A0")]
		private bool _ReloadFixedModuleIfNeed(string skinId)
		{
			return default(bool);
		}

		// Token: 0x0601DB12 RID: 121618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB12")]
		[Address(RVA = "0x174CCA0", Offset = "0x174B8A0", VA = "0x18174CCA0")]
		private void _LoadFixedModuleModel(string skinId, int skinTmpl, [Optional] FriendDataWithNameCard data)
		{
		}

		// Token: 0x0601DB13 RID: 121619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB13")]
		[Address(RVA = "0x174D5B0", Offset = "0x174C1B0", VA = "0x18174D5B0")]
		private void _RefreshFixedModuleModel(string skinId, int skinTmpl)
		{
		}

		// Token: 0x0601DB14 RID: 121620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB14")]
		[Address(RVA = "0x174C950", Offset = "0x174B550", VA = "0x18174C950")]
		private void _InitRemovableModuleIfNot()
		{
		}

		// Token: 0x0601DB15 RID: 121621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB15")]
		[Address(RVA = "0x174D340", Offset = "0x174BF40", VA = "0x18174D340")]
		private void _MoveRemovableModuleModels(PlayerNameCardStyle style)
		{
		}

		// Token: 0x0601DB16 RID: 121622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB16")]
		[Address(RVA = "0x174D0D0", Offset = "0x174BCD0", VA = "0x18174D0D0")]
		private void _LoadRemovableModuleModel(ListDict<string, NameCardV2RemovableModuleBaseModel> listDict, bool isSelect, string nameCardSkinId, int nameCardSkinTmpl, [Optional] FriendDataWithNameCard data)
		{
		}

		// Token: 0x0601DB17 RID: 121623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB17")]
		[Address(RVA = "0x174D770", Offset = "0x174C370", VA = "0x18174D770")]
		private void _RefreshRemovableModuleModel(ListDict<string, NameCardV2RemovableModuleBaseModel> listDict, bool isSelect, string nameCardSkinId, int nameCardSkinTmpl)
		{
		}

		// Token: 0x0601DB18 RID: 121624 RVA: 0x000AC4B8 File Offset: 0x000AA6B8
		[Token(Token = "0x601DB18")]
		[Address(RVA = "0x174DC10", Offset = "0x174C810", VA = "0x18174DC10")]
		private static int _SortUnselectedModule(KeyValuePair<string, NameCardV2RemovableModuleBaseModel> a, KeyValuePair<string, NameCardV2RemovableModuleBaseModel> b)
		{
			return 0;
		}

		// Token: 0x0601DB19 RID: 121625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB19")]
		[Address(RVA = "0x174CEE0", Offset = "0x174BAE0", VA = "0x18174CEE0")]
		private void _LoadMiscData(PlayerNameCardStyle style, NameCardV2ViewModel.ShowDetailOption showDetailOpt = NameCardV2ViewModel.ShowDetailOption.READ_FROM_MISC)
		{
		}

		// Token: 0x0601DB1A RID: 121626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB1A")]
		[Address(RVA = "0x174DCF0", Offset = "0x174C8F0", VA = "0x18174DCF0")]
		public NameCardV2ViewModel()
		{
		}

		// Token: 0x04027397 RID: 160663
		[Token(Token = "0x4027397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NameCardV2ViewModel.ShowType showType;

		// Token: 0x04027398 RID: 160664
		[Token(Token = "0x4027398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NameCardMiscModel miscModel;

		// Token: 0x04027399 RID: 160665
		[Token(Token = "0x4027399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string skinId;

		// Token: 0x0402739A RID: 160666
		[Token(Token = "0x402739A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int skinTmpl;

		// Token: 0x0402739B RID: 160667
		[Token(Token = "0x402739B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int editSeqNum;

		// Token: 0x0402739C RID: 160668
		[Token(Token = "0x402739C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int resetSeqNum;

		// Token: 0x0402739D RID: 160669
		[Token(Token = "0x402739D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int showDetailSeqNum;

		// Token: 0x0402739E RID: 160670
		[Token(Token = "0x402739E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Dictionary<string, NameCardV2ModuleBaseModel> fixedModuleModelDict;

		// Token: 0x0402739F RID: 160671
		[Token(Token = "0x402739F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ListDict<string, NameCardV2RemovableModuleBaseModel> selectedModuleModelList;

		// Token: 0x040273A0 RID: 160672
		[Token(Token = "0x40273A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ListDict<string, NameCardV2RemovableModuleBaseModel> unselectedModuleModelList;

		// Token: 0x040273A1 RID: 160673
		[Token(Token = "0x40273A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool skinChangeUnlocked;

		// Token: 0x040273A2 RID: 160674
		[Token(Token = "0x40273A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool hasNewSkinTrackPoint;

		// Token: 0x040273A3 RID: 160675
		[Token(Token = "0x40273A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private bool m_hasModuleListInited;

		// Token: 0x040273A6 RID: 160678
		[Token(Token = "0x40273A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasSelfMagazineSquad;

		// Token: 0x040273A7 RID: 160679
		[Token(Token = "0x40273A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_hasSelfMagazineSquad;

		// Token: 0x040273A8 RID: 160680
		[Token(Token = "0x40273A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_albumValid;

		// Token: 0x040273A9 RID: 160681
		[Token(Token = "0x40273A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_albumValid;

		// Token: 0x040273AA RID: 160682
		[Token(Token = "0x40273AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadSelfData;

		// Token: 0x040273AB RID: 160683
		[Token(Token = "0x40273AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshSelfData;

		// Token: 0x040273AC RID: 160684
		[Token(Token = "0x40273AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadFriendData;

		// Token: 0x040273AD RID: 160685
		[Token(Token = "0x40273AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CanSelectModule;

		// Token: 0x040273AE RID: 160686
		[Token(Token = "0x40273AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SelectModule;

		// Token: 0x040273AF RID: 160687
		[Token(Token = "0x40273AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UnselectModule;

		// Token: 0x040273B0 RID: 160688
		[Token(Token = "0x40273B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SwitchOperatorStyle;

		// Token: 0x040273B1 RID: 160689
		[Token(Token = "0x40273B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SwitchAssistModuleStyle;

		// Token: 0x040273B2 RID: 160690
		[Token(Token = "0x40273B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SwitchEquipModuleStyle;

		// Token: 0x040273B3 RID: 160691
		[Token(Token = "0x40273B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SetNameCardShowType;

		// Token: 0x040273B4 RID: 160692
		[Token(Token = "0x40273B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SetNameCardMisc;

		// Token: 0x040273B5 RID: 160693
		[Token(Token = "0x40273B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ReloadFixedModuleIfNeed;

		// Token: 0x040273B6 RID: 160694
		[Token(Token = "0x40273B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__LoadFixedModuleModel;

		// Token: 0x040273B7 RID: 160695
		[Token(Token = "0x40273B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__RefreshFixedModuleModel;

		// Token: 0x040273B8 RID: 160696
		[Token(Token = "0x40273B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__InitRemovableModuleIfNot;

		// Token: 0x040273B9 RID: 160697
		[Token(Token = "0x40273B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__MoveRemovableModuleModels;

		// Token: 0x040273BA RID: 160698
		[Token(Token = "0x40273BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__LoadRemovableModuleModel;

		// Token: 0x040273BB RID: 160699
		[Token(Token = "0x40273BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__RefreshRemovableModuleModel;

		// Token: 0x040273BC RID: 160700
		[Token(Token = "0x40273BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__SortUnselectedModule;

		// Token: 0x040273BD RID: 160701
		[Token(Token = "0x40273BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__LoadMiscData;

		// Token: 0x040273BE RID: 160702
		[Token(Token = "0x40273BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004D80 RID: 19840
		[Token(Token = "0x2004D80")]
		public struct SetMiscOption
		{
			// Token: 0x040273BF RID: 160703
			[Token(Token = "0x40273BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public NameCardV2ViewModel.MiscFlag flag;

			// Token: 0x040273C0 RID: 160704
			[Token(Token = "0x40273C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public bool initShowDetail;
		}

		// Token: 0x02004D81 RID: 19841
		[Token(Token = "0x2004D81")]
		public enum ShowType
		{
			// Token: 0x040273C2 RID: 160706
			[Token(Token = "0x40273C2")]
			DISPLAY_ONLY,
			// Token: 0x040273C3 RID: 160707
			[Token(Token = "0x40273C3")]
			IN_NAME_CARD_STATE,
			// Token: 0x040273C4 RID: 160708
			[Token(Token = "0x40273C4")]
			IN_SELF_EDIT_STATE,
			// Token: 0x040273C5 RID: 160709
			[Token(Token = "0x40273C5")]
			IN_SOCIAL_CARD_ALBUM_PAGE
		}

		// Token: 0x02004D82 RID: 19842
		[Token(Token = "0x2004D82")]
		public enum ShowDetailOption
		{
			// Token: 0x040273C7 RID: 160711
			[Token(Token = "0x40273C7")]
			READ_FROM_MISC,
			// Token: 0x040273C8 RID: 160712
			[Token(Token = "0x40273C8")]
			FORCE_SHOW_DETAIL,
			// Token: 0x040273C9 RID: 160713
			[Token(Token = "0x40273C9")]
			FORCE_HIDE_DETAIL
		}

		// Token: 0x02004D83 RID: 19843
		[Token(Token = "0x2004D83")]
		[Flags]
		public enum MiscFlag
		{
			// Token: 0x040273CB RID: 160715
			[Token(Token = "0x40273CB")]
			NONE = 0,
			// Token: 0x040273CC RID: 160716
			[Token(Token = "0x40273CC")]
			MISC_SHOW_DETAIL = 1,
			// Token: 0x040273CD RID: 160717
			[Token(Token = "0x40273CD")]
			MISC_SET_BIRTH = 2,
			// Token: 0x040273CE RID: 160718
			[Token(Token = "0x40273CE")]
			MISC_SHOW_BIRTH = 4,
			// Token: 0x040273CF RID: 160719
			[Token(Token = "0x40273CF")]
			MISC_ENABLE_BIRTH = 8
		}
	}
}
