using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F06 RID: 16134
	[Token(Token = "0x2003F06")]
	public class SiracusaCharTaskRingModel : IHotfixable
	{
		// Token: 0x17003BDB RID: 15323
		// (get) Token: 0x060190C6 RID: 102598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BDB")]
		public SiracusaCharTaskModel selectTaskModel
		{
			[Token(Token = "0x60190C6")]
			[Address(RVA = "0x11B4AB0", Offset = "0x11B36B0", VA = "0x1811B4AB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003BDC RID: 15324
		// (get) Token: 0x060190C7 RID: 102599 RVA: 0x0009CCF0 File Offset: 0x0009AEF0
		[Token(Token = "0x17003BDC")]
		public bool isUnlock
		{
			[Token(Token = "0x60190C7")]
			[Address(RVA = "0x11B4890", Offset = "0x11B3490", VA = "0x1811B4890")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003BDD RID: 15325
		// (get) Token: 0x060190C8 RID: 102600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BDD")]
		public string unlockHint
		{
			[Token(Token = "0x60190C8")]
			[Address(RVA = "0x11B4C80", Offset = "0x11B3880", VA = "0x1811B4C80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003BDE RID: 15326
		// (get) Token: 0x060190C9 RID: 102601 RVA: 0x0009CD08 File Offset: 0x0009AF08
		[Token(Token = "0x17003BDE")]
		public int sortId
		{
			[Token(Token = "0x60190C9")]
			[Address(RVA = "0x11B4B20", Offset = "0x11B3720", VA = "0x1811B4B20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003BDF RID: 15327
		// (get) Token: 0x060190CA RID: 102602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BDF")]
		public ItemBundle rewardItem
		{
			[Token(Token = "0x60190CA")]
			[Address(RVA = "0x11B48F0", Offset = "0x11B34F0", VA = "0x1811B48F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003BE0 RID: 15328
		// (get) Token: 0x060190CB RID: 102603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BE0")]
		public string ringId
		{
			[Token(Token = "0x60190CB")]
			[Address(RVA = "0x11B4960", Offset = "0x11B3560", VA = "0x1811B4960")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003BE1 RID: 15329
		// (get) Token: 0x060190CC RID: 102604 RVA: 0x0009CD20 File Offset: 0x0009AF20
		[Token(Token = "0x17003BE1")]
		public PlayerSiracusaMap.TaskRingStatus ringStatus
		{
			[Token(Token = "0x60190CC")]
			[Address(RVA = "0x11B49D0", Offset = "0x11B35D0", VA = "0x1811B49D0")]
			get
			{
				return PlayerSiracusaMap.TaskRingStatus.NONE;
			}
		}

		// Token: 0x17003BE2 RID: 15330
		// (get) Token: 0x060190CD RID: 102605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BE2")]
		public string taskRingDesc
		{
			[Token(Token = "0x60190CD")]
			[Address(RVA = "0x11B4BF0", Offset = "0x11B37F0", VA = "0x1811B4BF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003BE3 RID: 15331
		// (get) Token: 0x060190CE RID: 102606 RVA: 0x0009CD38 File Offset: 0x0009AF38
		[Token(Token = "0x17003BE3")]
		public SiracusaData.TaskRingLogicType ringType
		{
			[Token(Token = "0x60190CE")]
			[Address(RVA = "0x11B4A40", Offset = "0x11B3640", VA = "0x1811B4A40")]
			get
			{
				return SiracusaData.TaskRingLogicType.NONE;
			}
		}

		// Token: 0x17003BE4 RID: 15332
		// (get) Token: 0x060190CF RID: 102607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BE4")]
		public List<SiracusaCharTaskModel> taskList
		{
			[Token(Token = "0x60190CF")]
			[Address(RVA = "0x11B4B90", Offset = "0x11B3790", VA = "0x1811B4B90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003BE5 RID: 15333
		// (get) Token: 0x060190D0 RID: 102608 RVA: 0x0009CD50 File Offset: 0x0009AF50
		[Token(Token = "0x17003BE5")]
		public bool isDoing
		{
			[Token(Token = "0x60190D0")]
			[Address(RVA = "0x11B4810", Offset = "0x11B3410", VA = "0x1811B4810")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060190D1 RID: 102609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190D1")]
		[Address(RVA = "0x11B3DD0", Offset = "0x11B29D0", VA = "0x1811B3DD0")]
		public void LoadData(SiracusaData siracusaData, SiracusaData.TaskRingData ringData, PlayerSiracusaMap.TaskRing playerRing, Dictionary<string, int> area)
		{
		}

		// Token: 0x060190D2 RID: 102610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60190D2")]
		[Address(RVA = "0x11B45A0", Offset = "0x11B31A0", VA = "0x1811B45A0")]
		private string _GetUnlockHint(SiracusaData siracusaData, string areaId)
		{
			return null;
		}

		// Token: 0x060190D3 RID: 102611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60190D3")]
		[Address(RVA = "0x11B3C50", Offset = "0x11B2850", VA = "0x1811B3C50")]
		public SiracusaCharTaskModel FindTaskAndSelect(string taskId)
		{
			return null;
		}

		// Token: 0x060190D4 RID: 102612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190D4")]
		[Address(RVA = "0x11B4710", Offset = "0x11B3310", VA = "0x1811B4710")]
		public SiracusaCharTaskRingModel()
		{
		}

		// Token: 0x0401EFA0 RID: 126880
		[Token(Token = "0x401EFA0")]
		[FieldOffset(Offset = "0x10")]
		private SiracusaData.TaskRingData m_taskRingData;

		// Token: 0x0401EFA1 RID: 126881
		[Token(Token = "0x401EFA1")]
		[FieldOffset(Offset = "0x18")]
		private PlayerSiracusaMap.TaskRing m_playerRing;

		// Token: 0x0401EFA2 RID: 126882
		[Token(Token = "0x401EFA2")]
		[FieldOffset(Offset = "0x20")]
		private List<SiracusaCharTaskModel> m_taskList;

		// Token: 0x0401EFA3 RID: 126883
		[Token(Token = "0x401EFA3")]
		[FieldOffset(Offset = "0x28")]
		private HashSet<string> m_relatedAreaSet;

		// Token: 0x0401EFA4 RID: 126884
		[Token(Token = "0x401EFA4")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isUnlock;

		// Token: 0x0401EFA5 RID: 126885
		[Token(Token = "0x401EFA5")]
		[FieldOffset(Offset = "0x38")]
		private string m_unlockHint;

		// Token: 0x0401EFA6 RID: 126886
		[Token(Token = "0x401EFA6")]
		[FieldOffset(Offset = "0x40")]
		private int m_selectIndex;

		// Token: 0x0401EFA7 RID: 126887
		[Token(Token = "0x401EFA7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectTaskModel;

		// Token: 0x0401EFA8 RID: 126888
		[Token(Token = "0x401EFA8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isUnlock;

		// Token: 0x0401EFA9 RID: 126889
		[Token(Token = "0x401EFA9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_unlockHint;

		// Token: 0x0401EFAA RID: 126890
		[Token(Token = "0x401EFAA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0401EFAB RID: 126891
		[Token(Token = "0x401EFAB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_rewardItem;

		// Token: 0x0401EFAC RID: 126892
		[Token(Token = "0x401EFAC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_ringId;

		// Token: 0x0401EFAD RID: 126893
		[Token(Token = "0x401EFAD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_ringStatus;

		// Token: 0x0401EFAE RID: 126894
		[Token(Token = "0x401EFAE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_taskRingDesc;

		// Token: 0x0401EFAF RID: 126895
		[Token(Token = "0x401EFAF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_ringType;

		// Token: 0x0401EFB0 RID: 126896
		[Token(Token = "0x401EFB0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_taskList;

		// Token: 0x0401EFB1 RID: 126897
		[Token(Token = "0x401EFB1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_isDoing;

		// Token: 0x0401EFB2 RID: 126898
		[Token(Token = "0x401EFB2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401EFB3 RID: 126899
		[Token(Token = "0x401EFB3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetUnlockHint;

		// Token: 0x0401EFB4 RID: 126900
		[Token(Token = "0x401EFB4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_FindTaskAndSelect;

		// Token: 0x0401EFB5 RID: 126901
		[Token(Token = "0x401EFB5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
