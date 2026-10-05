using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006531 RID: 25905
	[Token(Token = "0x2006531")]
	public class ArtMagazineCoverDetailViewModel : IHotfixable
	{
		// Token: 0x170057DD RID: 22493
		// (get) Token: 0x060253AA RID: 152490 RVA: 0x000C7110 File Offset: 0x000C5310
		// (set) Token: 0x060253AB RID: 152491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057DD")]
		public ArtMagazineCoverDetailShowType showType
		{
			[Token(Token = "0x60253AA")]
			[Address(RVA = "0x202A3A0", Offset = "0x2028FA0", VA = "0x18202A3A0")]
			[CompilerGenerated]
			get
			{
				return ArtMagazineCoverDetailShowType.DEFAULT;
			}
			[Token(Token = "0x60253AB")]
			[Address(RVA = "0x202A780", Offset = "0x2029380", VA = "0x18202A780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057DE RID: 22494
		// (get) Token: 0x060253AC RID: 152492 RVA: 0x000C7128 File Offset: 0x000C5328
		[Token(Token = "0x170057DE")]
		public bool showInditBtn
		{
			[Token(Token = "0x60253AC")]
			[Address(RVA = "0x202A0A0", Offset = "0x2028CA0", VA = "0x18202A0A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170057DF RID: 22495
		// (get) Token: 0x060253AD RID: 152493 RVA: 0x000C7140 File Offset: 0x000C5340
		// (set) Token: 0x060253AE RID: 152494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057DF")]
		public int curInditCount
		{
			[Token(Token = "0x60253AD")]
			[Address(RVA = "0x2029D50", Offset = "0x2028950", VA = "0x182029D50")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60253AE")]
			[Address(RVA = "0x202A4D0", Offset = "0x20290D0", VA = "0x18202A4D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057E0 RID: 22496
		// (get) Token: 0x060253AF RID: 152495 RVA: 0x000C7158 File Offset: 0x000C5358
		// (set) Token: 0x060253B0 RID: 152496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057E0")]
		public int inditMaxCount
		{
			[Token(Token = "0x60253AF")]
			[Address(RVA = "0x2029ED0", Offset = "0x2028AD0", VA = "0x182029ED0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60253B0")]
			[Address(RVA = "0x202A6A0", Offset = "0x20292A0", VA = "0x18202A6A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057E1 RID: 22497
		// (get) Token: 0x060253B1 RID: 152497 RVA: 0x000C7170 File Offset: 0x000C5370
		// (set) Token: 0x060253B2 RID: 152498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057E1")]
		public ArtMagazineCoverDetailViewModel.LeafInditState inditState
		{
			[Token(Token = "0x60253B1")]
			[Address(RVA = "0x2029F30", Offset = "0x2028B30", VA = "0x182029F30")]
			[CompilerGenerated]
			get
			{
				return ArtMagazineCoverDetailViewModel.LeafInditState.NONE;
			}
			[Token(Token = "0x60253B2")]
			[Address(RVA = "0x202A710", Offset = "0x2029310", VA = "0x18202A710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057E2 RID: 22498
		// (get) Token: 0x060253B3 RID: 152499 RVA: 0x000C7188 File Offset: 0x000C5388
		[Token(Token = "0x170057E2")]
		public bool showEditBtn
		{
			[Token(Token = "0x60253B3")]
			[Address(RVA = "0x2029FF0", Offset = "0x2028BF0", VA = "0x182029FF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170057E3 RID: 22499
		// (get) Token: 0x060253B4 RID: 152500 RVA: 0x000C71A0 File Offset: 0x000C53A0
		[Token(Token = "0x170057E3")]
		public bool showMultiPart
		{
			[Token(Token = "0x60253B4")]
			[Address(RVA = "0x202A210", Offset = "0x2028E10", VA = "0x18202A210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170057E4 RID: 22500
		// (get) Token: 0x060253B5 RID: 152501 RVA: 0x000C71B8 File Offset: 0x000C53B8
		[Token(Token = "0x170057E4")]
		public bool showLeftArrow
		{
			[Token(Token = "0x60253B5")]
			[Address(RVA = "0x202A150", Offset = "0x2028D50", VA = "0x18202A150")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170057E5 RID: 22501
		// (get) Token: 0x060253B6 RID: 152502 RVA: 0x000C71D0 File Offset: 0x000C53D0
		[Token(Token = "0x170057E5")]
		public bool showRightArrow
		{
			[Token(Token = "0x60253B6")]
			[Address(RVA = "0x202A2D0", Offset = "0x2028ED0", VA = "0x18202A2D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170057E6 RID: 22502
		// (get) Token: 0x060253B7 RID: 152503 RVA: 0x000C71E8 File Offset: 0x000C53E8
		// (set) Token: 0x060253B8 RID: 152504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057E6")]
		public int curLeafIndex
		{
			[Token(Token = "0x60253B7")]
			[Address(RVA = "0x2029E10", Offset = "0x2028A10", VA = "0x182029E10")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60253B8")]
			[Address(RVA = "0x202A5C0", Offset = "0x20291C0", VA = "0x18202A5C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057E7 RID: 22503
		// (get) Token: 0x060253B9 RID: 152505 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060253BA RID: 152506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057E7")]
		public string curLeafId
		{
			[Token(Token = "0x60253B9")]
			[Address(RVA = "0x2029DB0", Offset = "0x20289B0", VA = "0x182029DB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60253BA")]
			[Address(RVA = "0x202A540", Offset = "0x2029140", VA = "0x18202A540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057E8 RID: 22504
		// (get) Token: 0x060253BB RID: 152507 RVA: 0x000C7200 File Offset: 0x000C5400
		[Token(Token = "0x170057E8")]
		public int totalLeafCount
		{
			[Token(Token = "0x60253BB")]
			[Address(RVA = "0x202A400", Offset = "0x2029000", VA = "0x18202A400")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170057E9 RID: 22505
		// (get) Token: 0x060253BC RID: 152508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170057E9")]
		public ListDict<int, ArtMagazineCoverDetailLeafItemViewModel> leafItemList
		{
			[Token(Token = "0x60253BC")]
			[Address(RVA = "0x2029F90", Offset = "0x2028B90", VA = "0x182029F90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170057EA RID: 22506
		// (get) Token: 0x060253BD RID: 152509 RVA: 0x000C7218 File Offset: 0x000C5418
		// (set) Token: 0x060253BE RID: 152510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057EA")]
		public int enterSeqNum
		{
			[Token(Token = "0x60253BD")]
			[Address(RVA = "0x2029E70", Offset = "0x2028A70", VA = "0x182029E70")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60253BE")]
			[Address(RVA = "0x202A630", Offset = "0x2029230", VA = "0x18202A630")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060253BF RID: 152511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253BF")]
		[Address(RVA = "0x20288C0", Offset = "0x20274C0", VA = "0x1820288C0")]
		public void LoadData(ArtMagazineCoverDetailShowType showType, int initFocusIndex, List<string> leafIds)
		{
		}

		// Token: 0x060253C0 RID: 152512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253C0")]
		[Address(RVA = "0x2029090", Offset = "0x2027C90", VA = "0x182029090")]
		public void RefreshData()
		{
		}

		// Token: 0x060253C1 RID: 152513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253C1")]
		[Address(RVA = "0x2028D70", Offset = "0x2027970", VA = "0x182028D70")]
		public void RefreshCurLeafInditState()
		{
		}

		// Token: 0x060253C2 RID: 152514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253C2")]
		[Address(RVA = "0x2029380", Offset = "0x2027F80", VA = "0x182029380")]
		public void RefreshPageIndexByRightFocus()
		{
		}

		// Token: 0x060253C3 RID: 152515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253C3")]
		[Address(RVA = "0x2029270", Offset = "0x2027E70", VA = "0x182029270")]
		public void RefreshPageIndexByLeftFocus()
		{
		}

		// Token: 0x060253C4 RID: 152516 RVA: 0x000C7230 File Offset: 0x000C5430
		[Token(Token = "0x60253C4")]
		[Address(RVA = "0x20283B0", Offset = "0x2026FB0", VA = "0x1820283B0")]
		public int GetInditLeafIndex(string leafId)
		{
			return 0;
		}

		// Token: 0x060253C5 RID: 152517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60253C5")]
		[Address(RVA = "0x20284A0", Offset = "0x20270A0", VA = "0x1820284A0")]
		public List<string> GetNewInditList(out bool isAdd)
		{
			return null;
		}

		// Token: 0x060253C6 RID: 152518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253C6")]
		[Address(RVA = "0x2029A30", Offset = "0x2028630", VA = "0x182029A30")]
		private void _RefreshPlayerData()
		{
		}

		// Token: 0x060253C7 RID: 152519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253C7")]
		[Address(RVA = "0x20298E0", Offset = "0x20284E0", VA = "0x1820298E0")]
		private void _RefreshDefaultData()
		{
		}

		// Token: 0x060253C8 RID: 152520 RVA: 0x000C7248 File Offset: 0x000C5448
		[Token(Token = "0x60253C8")]
		[Address(RVA = "0x20294B0", Offset = "0x20280B0", VA = "0x1820294B0")]
		private ArtMagazineCoverDetailViewModel.LeafInditState _GetLeafInditState(string leafId)
		{
			return ArtMagazineCoverDetailViewModel.LeafInditState.NONE;
		}

		// Token: 0x060253C9 RID: 152521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60253C9")]
		[Address(RVA = "0x2029770", Offset = "0x2028370", VA = "0x182029770")]
		private List<string> _GetNewListByRemove(string leafId)
		{
			return null;
		}

		// Token: 0x060253CA RID: 152522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60253CA")]
		[Address(RVA = "0x20295A0", Offset = "0x20281A0", VA = "0x1820295A0")]
		private List<string> _GetNewListByAdd(string leafId)
		{
			return null;
		}

		// Token: 0x060253CB RID: 152523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253CB")]
		[Address(RVA = "0x2029C40", Offset = "0x2028840", VA = "0x182029C40")]
		public ArtMagazineCoverDetailViewModel()
		{
		}

		// Token: 0x040343AE RID: 213934
		[Token(Token = "0x40343AE")]
		[FieldOffset(Offset = "0x38")]
		private List<string> m_playerMagazineLeafList;

		// Token: 0x040343AF RID: 213935
		[Token(Token = "0x40343AF")]
		[FieldOffset(Offset = "0x40")]
		private ListDict<int, ArtMagazineCoverDetailLeafItemViewModel> m_leafItemList;

		// Token: 0x040343B0 RID: 213936
		[Token(Token = "0x40343B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showType;

		// Token: 0x040343B1 RID: 213937
		[Token(Token = "0x40343B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_showType;

		// Token: 0x040343B2 RID: 213938
		[Token(Token = "0x40343B2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showInditBtn;

		// Token: 0x040343B3 RID: 213939
		[Token(Token = "0x40343B3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_curInditCount;

		// Token: 0x040343B4 RID: 213940
		[Token(Token = "0x40343B4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_curInditCount;

		// Token: 0x040343B5 RID: 213941
		[Token(Token = "0x40343B5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_inditMaxCount;

		// Token: 0x040343B6 RID: 213942
		[Token(Token = "0x40343B6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_inditMaxCount;

		// Token: 0x040343B7 RID: 213943
		[Token(Token = "0x40343B7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_inditState;

		// Token: 0x040343B8 RID: 213944
		[Token(Token = "0x40343B8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_inditState;

		// Token: 0x040343B9 RID: 213945
		[Token(Token = "0x40343B9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_showEditBtn;

		// Token: 0x040343BA RID: 213946
		[Token(Token = "0x40343BA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_showMultiPart;

		// Token: 0x040343BB RID: 213947
		[Token(Token = "0x40343BB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_showLeftArrow;

		// Token: 0x040343BC RID: 213948
		[Token(Token = "0x40343BC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_showRightArrow;

		// Token: 0x040343BD RID: 213949
		[Token(Token = "0x40343BD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_curLeafIndex;

		// Token: 0x040343BE RID: 213950
		[Token(Token = "0x40343BE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_curLeafIndex;

		// Token: 0x040343BF RID: 213951
		[Token(Token = "0x40343BF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_curLeafId;

		// Token: 0x040343C0 RID: 213952
		[Token(Token = "0x40343C0")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_curLeafId;

		// Token: 0x040343C1 RID: 213953
		[Token(Token = "0x40343C1")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_totalLeafCount;

		// Token: 0x040343C2 RID: 213954
		[Token(Token = "0x40343C2")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_leafItemList;

		// Token: 0x040343C3 RID: 213955
		[Token(Token = "0x40343C3")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_enterSeqNum;

		// Token: 0x040343C4 RID: 213956
		[Token(Token = "0x40343C4")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_set_enterSeqNum;

		// Token: 0x040343C5 RID: 213957
		[Token(Token = "0x40343C5")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040343C6 RID: 213958
		[Token(Token = "0x40343C6")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x040343C7 RID: 213959
		[Token(Token = "0x40343C7")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_RefreshCurLeafInditState;

		// Token: 0x040343C8 RID: 213960
		[Token(Token = "0x40343C8")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_RefreshPageIndexByRightFocus;

		// Token: 0x040343C9 RID: 213961
		[Token(Token = "0x40343C9")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_RefreshPageIndexByLeftFocus;

		// Token: 0x040343CA RID: 213962
		[Token(Token = "0x40343CA")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_GetInditLeafIndex;

		// Token: 0x040343CB RID: 213963
		[Token(Token = "0x40343CB")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GetNewInditList;

		// Token: 0x040343CC RID: 213964
		[Token(Token = "0x40343CC")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__RefreshPlayerData;

		// Token: 0x040343CD RID: 213965
		[Token(Token = "0x40343CD")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__RefreshDefaultData;

		// Token: 0x040343CE RID: 213966
		[Token(Token = "0x40343CE")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__GetLeafInditState;

		// Token: 0x040343CF RID: 213967
		[Token(Token = "0x40343CF")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__GetNewListByRemove;

		// Token: 0x040343D0 RID: 213968
		[Token(Token = "0x40343D0")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__GetNewListByAdd;

		// Token: 0x040343D1 RID: 213969
		[Token(Token = "0x40343D1")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006532 RID: 25906
		[Token(Token = "0x2006532")]
		public enum LeafInditState
		{
			// Token: 0x040343D3 RID: 213971
			[Token(Token = "0x40343D3")]
			NONE,
			// Token: 0x040343D4 RID: 213972
			[Token(Token = "0x40343D4")]
			INDITED,
			// Token: 0x040343D5 RID: 213973
			[Token(Token = "0x40343D5")]
			CAN_INDIT,
			// Token: 0x040343D6 RID: 213974
			[Token(Token = "0x40343D6")]
			FULL
		}
	}
}
