using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F08 RID: 16136
	[Token(Token = "0x2003F08")]
	public class SiracusaCharCardModel : IHotfixable
	{
		// Token: 0x17003BE6 RID: 15334
		// (get) Token: 0x060190D8 RID: 102616 RVA: 0x0009CD80 File Offset: 0x0009AF80
		// (set) Token: 0x060190D9 RID: 102617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BE6")]
		public int selectIdx
		{
			[Token(Token = "0x60190D8")]
			[Address(RVA = "0x11AF750", Offset = "0x11AE350", VA = "0x1811AF750")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60190D9")]
			[Address(RVA = "0x11AF980", Offset = "0x11AE580", VA = "0x1811AF980")]
			set
			{
			}
		}

		// Token: 0x17003BE7 RID: 15335
		// (get) Token: 0x060190DA RID: 102618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BE7")]
		public SiracusaCharTaskRingModel selectRingModel
		{
			[Token(Token = "0x60190DA")]
			[Address(RVA = "0x11AF7B0", Offset = "0x11AE3B0", VA = "0x1811AF7B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003BE8 RID: 15336
		// (get) Token: 0x060190DB RID: 102619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BE8")]
		public List<SiracusaCharTaskRingModel> taskRingList
		{
			[Token(Token = "0x60190DB")]
			[Address(RVA = "0x11AF820", Offset = "0x11AE420", VA = "0x1811AF820")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003BE9 RID: 15337
		// (get) Token: 0x060190DC RID: 102620 RVA: 0x0009CD98 File Offset: 0x0009AF98
		[Token(Token = "0x17003BE9")]
		public SiracusaCharCardModel.DisplayEnum displayStatus
		{
			[Token(Token = "0x60190DC")]
			[Address(RVA = "0x11AF630", Offset = "0x11AE230", VA = "0x1811AF630")]
			get
			{
				return SiracusaCharCardModel.DisplayEnum.NONE;
			}
		}

		// Token: 0x17003BEA RID: 15338
		// (get) Token: 0x060190DD RID: 102621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BEA")]
		public string charCardId
		{
			[Token(Token = "0x60190DD")]
			[Address(RVA = "0x11AF4D0", Offset = "0x11AE0D0", VA = "0x1811AF4D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003BEB RID: 15339
		// (get) Token: 0x060190DE RID: 102622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BEB")]
		public SiracusaData.CharCardData charCardData
		{
			[Token(Token = "0x60190DE")]
			[Address(RVA = "0x11AF470", Offset = "0x11AE070", VA = "0x1811AF470")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003BEC RID: 15340
		// (get) Token: 0x060190DF RID: 102623 RVA: 0x0009CDB0 File Offset: 0x0009AFB0
		[Token(Token = "0x17003BEC")]
		public bool isBagEmpty
		{
			[Token(Token = "0x60190DF")]
			[Address(RVA = "0x11AF6F0", Offset = "0x11AE2F0", VA = "0x1811AF6F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003BED RID: 15341
		// (get) Token: 0x060190E0 RID: 102624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BED")]
		public SiracusaData.ItemInfoData bagItemInfoData
		{
			[Token(Token = "0x60190E0")]
			[Address(RVA = "0x11AF3B0", Offset = "0x11ADFB0", VA = "0x1811AF3B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003BEE RID: 15342
		// (get) Token: 0x060190E1 RID: 102625 RVA: 0x0009CDC8 File Offset: 0x0009AFC8
		[Token(Token = "0x17003BEE")]
		public Color themeColor
		{
			[Token(Token = "0x60190E1")]
			[Address(RVA = "0x11AF880", Offset = "0x11AE480", VA = "0x1811AF880")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17003BEF RID: 15343
		// (get) Token: 0x060190E2 RID: 102626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BEF")]
		public string currentTaskDesc
		{
			[Token(Token = "0x60190E2")]
			[Address(RVA = "0x11AF5A0", Offset = "0x11AE1A0", VA = "0x1811AF5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003BF0 RID: 15344
		// (get) Token: 0x060190E3 RID: 102627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BF0")]
		public SiracusaCharTaskRingModel doingRingModel
		{
			[Token(Token = "0x60190E3")]
			[Address(RVA = "0x11AF690", Offset = "0x11AE290", VA = "0x1811AF690")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003BF1 RID: 15345
		// (get) Token: 0x060190E4 RID: 102628 RVA: 0x0009CDE0 File Offset: 0x0009AFE0
		[Token(Token = "0x17003BF1")]
		public int totalRingCount
		{
			[Token(Token = "0x60190E4")]
			[Address(RVA = "0x11AF900", Offset = "0x11AE500", VA = "0x1811AF900")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003BF2 RID: 15346
		// (get) Token: 0x060190E5 RID: 102629 RVA: 0x0009CDF8 File Offset: 0x0009AFF8
		[Token(Token = "0x17003BF2")]
		public int currentRingCount
		{
			[Token(Token = "0x60190E5")]
			[Address(RVA = "0x11AF530", Offset = "0x11AE130", VA = "0x1811AF530")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060190E6 RID: 102630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190E6")]
		[Address(RVA = "0x11AE2E0", Offset = "0x11ACEE0", VA = "0x1811AE2E0")]
		public void Init(SiracusaData siracusaData, PlayerSiracusaMap playerSiracusa)
		{
		}

		// Token: 0x060190E7 RID: 102631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60190E7")]
		[Address(RVA = "0x11AE160", Offset = "0x11ACD60", VA = "0x1811AE160")]
		public SiracusaCharTaskRingModel FindTaskRingAndSelect(string ringId)
		{
			return null;
		}

		// Token: 0x060190E8 RID: 102632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190E8")]
		[Address(RVA = "0x11AE8E0", Offset = "0x11AD4E0", VA = "0x1811AE8E0")]
		private void _ClearData()
		{
		}

		// Token: 0x060190E9 RID: 102633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190E9")]
		[Address(RVA = "0x11AE3F0", Offset = "0x11ACFF0", VA = "0x1811AE3F0")]
		public void UpdateModel(PlayerSiracusaMap playerSiracusa)
		{
		}

		// Token: 0x060190EA RID: 102634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190EA")]
		[Address(RVA = "0x11AE470", Offset = "0x11AD070", VA = "0x1811AE470")]
		public void UpdateReplayModel(PlayerSiracusaMap playerSiracusa, string charCardId)
		{
		}

		// Token: 0x060190EB RID: 102635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190EB")]
		[Address(RVA = "0x11AE510", Offset = "0x11AD110", VA = "0x1811AE510")]
		public void UpdateWhenBackToBigMap(PlayerSiracusaMap playerSiracusa)
		{
		}

		// Token: 0x060190EC RID: 102636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190EC")]
		[Address(RVA = "0x11AEB20", Offset = "0x11AD720", VA = "0x1811AEB20")]
		private void _UpdateModel(PlayerSiracusaMap playerSiracusa, string charCardId)
		{
		}

		// Token: 0x060190ED RID: 102637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190ED")]
		[Address(RVA = "0x11AE9B0", Offset = "0x11AD5B0", VA = "0x1811AE9B0")]
		private void _ResetSelectIdxToDefault()
		{
		}

		// Token: 0x060190EE RID: 102638 RVA: 0x0009CE10 File Offset: 0x0009B010
		[Token(Token = "0x60190EE")]
		[Address(RVA = "0x11AE6F0", Offset = "0x11AD2F0", VA = "0x1811AE6F0")]
		private SiracusaCharCardModel.DisplayEnum _CalcDisplayStatus(SiracusaData siracusaData, PlayerSiracusaMap playerSiracusa, bool isReplay)
		{
			return SiracusaCharCardModel.DisplayEnum.NONE;
		}

		// Token: 0x060190EF RID: 102639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190EF")]
		[Address(RVA = "0x11AF2F0", Offset = "0x11ADEF0", VA = "0x1811AF2F0")]
		public SiracusaCharCardModel()
		{
		}

		// Token: 0x0401EFB8 RID: 126904
		[Token(Token = "0x401EFB8")]
		[FieldOffset(Offset = "0x10")]
		private SiracusaData m_siracusaData;

		// Token: 0x0401EFB9 RID: 126905
		[Token(Token = "0x401EFB9")]
		[FieldOffset(Offset = "0x18")]
		private string m_charCardId;

		// Token: 0x0401EFBA RID: 126906
		[Token(Token = "0x401EFBA")]
		[FieldOffset(Offset = "0x20")]
		private SiracusaData.CharCardData m_charCardData;

		// Token: 0x0401EFBB RID: 126907
		[Token(Token = "0x401EFBB")]
		[FieldOffset(Offset = "0x28")]
		private SiracusaCharCardModel.DisplayEnum m_displayStatus;

		// Token: 0x0401EFBC RID: 126908
		[Token(Token = "0x401EFBC")]
		[FieldOffset(Offset = "0x2C")]
		private Color m_themeColor;

		// Token: 0x0401EFBD RID: 126909
		[Token(Token = "0x401EFBD")]
		[FieldOffset(Offset = "0x40")]
		private List<SiracusaCharTaskRingModel> m_taskRingList;

		// Token: 0x0401EFBE RID: 126910
		[Token(Token = "0x401EFBE")]
		[FieldOffset(Offset = "0x48")]
		private SiracusaCharTaskRingModel m_doingTaskRing;

		// Token: 0x0401EFBF RID: 126911
		[Token(Token = "0x401EFBF")]
		[FieldOffset(Offset = "0x50")]
		private int m_selectIdx;

		// Token: 0x0401EFC0 RID: 126912
		[Token(Token = "0x401EFC0")]
		[FieldOffset(Offset = "0x54")]
		private bool m_haveOperaItem;

		// Token: 0x0401EFC1 RID: 126913
		[Token(Token = "0x401EFC1")]
		[FieldOffset(Offset = "0x55")]
		private bool m_isReplay;

		// Token: 0x0401EFC2 RID: 126914
		[Token(Token = "0x401EFC2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectIdx;

		// Token: 0x0401EFC3 RID: 126915
		[Token(Token = "0x401EFC3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectIdx;

		// Token: 0x0401EFC4 RID: 126916
		[Token(Token = "0x401EFC4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectRingModel;

		// Token: 0x0401EFC5 RID: 126917
		[Token(Token = "0x401EFC5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_taskRingList;

		// Token: 0x0401EFC6 RID: 126918
		[Token(Token = "0x401EFC6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_displayStatus;

		// Token: 0x0401EFC7 RID: 126919
		[Token(Token = "0x401EFC7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_charCardId;

		// Token: 0x0401EFC8 RID: 126920
		[Token(Token = "0x401EFC8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_charCardData;

		// Token: 0x0401EFC9 RID: 126921
		[Token(Token = "0x401EFC9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isBagEmpty;

		// Token: 0x0401EFCA RID: 126922
		[Token(Token = "0x401EFCA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_bagItemInfoData;

		// Token: 0x0401EFCB RID: 126923
		[Token(Token = "0x401EFCB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_themeColor;

		// Token: 0x0401EFCC RID: 126924
		[Token(Token = "0x401EFCC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_currentTaskDesc;

		// Token: 0x0401EFCD RID: 126925
		[Token(Token = "0x401EFCD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_doingRingModel;

		// Token: 0x0401EFCE RID: 126926
		[Token(Token = "0x401EFCE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_totalRingCount;

		// Token: 0x0401EFCF RID: 126927
		[Token(Token = "0x401EFCF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_currentRingCount;

		// Token: 0x0401EFD0 RID: 126928
		[Token(Token = "0x401EFD0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401EFD1 RID: 126929
		[Token(Token = "0x401EFD1")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_FindTaskRingAndSelect;

		// Token: 0x0401EFD2 RID: 126930
		[Token(Token = "0x401EFD2")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ClearData;

		// Token: 0x0401EFD3 RID: 126931
		[Token(Token = "0x401EFD3")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_UpdateModel;

		// Token: 0x0401EFD4 RID: 126932
		[Token(Token = "0x401EFD4")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_UpdateReplayModel;

		// Token: 0x0401EFD5 RID: 126933
		[Token(Token = "0x401EFD5")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_UpdateWhenBackToBigMap;

		// Token: 0x0401EFD6 RID: 126934
		[Token(Token = "0x401EFD6")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__UpdateModel;

		// Token: 0x0401EFD7 RID: 126935
		[Token(Token = "0x401EFD7")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__ResetSelectIdxToDefault;

		// Token: 0x0401EFD8 RID: 126936
		[Token(Token = "0x401EFD8")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__CalcDisplayStatus;

		// Token: 0x0401EFD9 RID: 126937
		[Token(Token = "0x401EFD9")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003F09 RID: 16137
		[Token(Token = "0x2003F09")]
		public enum DisplayEnum
		{
			// Token: 0x0401EFDB RID: 126939
			[Token(Token = "0x401EFDB")]
			NONE,
			// Token: 0x0401EFDC RID: 126940
			[Token(Token = "0x401EFDC")]
			EMPTY,
			// Token: 0x0401EFDD RID: 126941
			[Token(Token = "0x401EFDD")]
			EQUIP,
			// Token: 0x0401EFDE RID: 126942
			[Token(Token = "0x401EFDE")]
			COMPLETED
		}
	}
}
