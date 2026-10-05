using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F03 RID: 16131
	[Token(Token = "0x2003F03")]
	public class SiracusaCharTaskModel : IHotfixable
	{
		// Token: 0x060190B3 RID: 102579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190B3")]
		[Address(RVA = "0x11B2A00", Offset = "0x11B1600", VA = "0x1811B2A00")]
		protected SiracusaCharTaskModel()
		{
		}

		// Token: 0x17003BD1 RID: 15313
		// (get) Token: 0x060190B4 RID: 102580 RVA: 0x0009CCA8 File Offset: 0x0009AEA8
		[Token(Token = "0x17003BD1")]
		public int sortId
		{
			[Token(Token = "0x60190B4")]
			[Address(RVA = "0x11B2C80", Offset = "0x11B1880", VA = "0x1811B2C80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003BD2 RID: 15314
		// (get) Token: 0x060190B5 RID: 102581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BD2")]
		public string placeId
		{
			[Token(Token = "0x60190B5")]
			[Address(RVA = "0x11B2B60", Offset = "0x11B1760", VA = "0x1811B2B60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003BD3 RID: 15315
		// (get) Token: 0x060190B6 RID: 102582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BD3")]
		public string npcId
		{
			[Token(Token = "0x60190B6")]
			[Address(RVA = "0x11B2AD0", Offset = "0x11B16D0", VA = "0x1811B2AD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003BD4 RID: 15316
		// (get) Token: 0x060190B7 RID: 102583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BD4")]
		public string placeName
		{
			[Token(Token = "0x60190B7")]
			[Address(RVA = "0x11B2BF0", Offset = "0x11B17F0", VA = "0x1811B2BF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003BD5 RID: 15317
		// (get) Token: 0x060190B8 RID: 102584 RVA: 0x0009CCC0 File Offset: 0x0009AEC0
		[Token(Token = "0x17003BD5")]
		public PlayerSiracusaMap.StateEnum taskStatus
		{
			[Token(Token = "0x60190B8")]
			[Address(RVA = "0x11B2D60", Offset = "0x11B1960", VA = "0x1811B2D60")]
			get
			{
				return PlayerSiracusaMap.StateEnum.NONE;
			}
		}

		// Token: 0x17003BD6 RID: 15318
		// (get) Token: 0x060190B9 RID: 102585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BD6")]
		public PlayerSiracusaMap.BattleProgress battleProgress
		{
			[Token(Token = "0x60190B9")]
			[Address(RVA = "0x11B2A60", Offset = "0x11B1660", VA = "0x1811B2A60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003BD7 RID: 15319
		// (get) Token: 0x060190BA RID: 102586 RVA: 0x0009CCD8 File Offset: 0x0009AED8
		[Token(Token = "0x17003BD7")]
		public SiracusaData.TaskType taskType
		{
			[Token(Token = "0x60190BA")]
			[Address(RVA = "0x11B2DD0", Offset = "0x11B19D0", VA = "0x1811B2DD0")]
			get
			{
				return SiracusaData.TaskType.NONE;
			}
		}

		// Token: 0x17003BD8 RID: 15320
		// (get) Token: 0x060190BB RID: 102587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BD8")]
		public string taskId
		{
			[Token(Token = "0x60190BB")]
			[Address(RVA = "0x11B2CF0", Offset = "0x11B18F0", VA = "0x1811B2CF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060190BC RID: 102588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190BC")]
		[Address(RVA = "0x11B2900", Offset = "0x11B1500", VA = "0x1811B2900", Slot = "4")]
		public virtual void LoadData(SiracusaData siracusaData, SiracusaData.TaskBasicInfoData taskInfoData, PlayerSiracusaMap.TaskInfo playerTask)
		{
		}

		// Token: 0x060190BD RID: 102589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60190BD")]
		[Address(RVA = "0x11B26B0", Offset = "0x11B12B0", VA = "0x1811B26B0")]
		public static SiracusaCharTaskModel Create(SiracusaData siracusaData, SiracusaData.TaskBasicInfoData taskInfoData, PlayerSiracusaMap.TaskInfo playerTask)
		{
			return null;
		}

		// Token: 0x0401EF8A RID: 126858
		[Token(Token = "0x401EF8A")]
		[FieldOffset(Offset = "0x10")]
		private SiracusaData.TaskBasicInfoData m_basicInfoData;

		// Token: 0x0401EF8B RID: 126859
		[Token(Token = "0x401EF8B")]
		[FieldOffset(Offset = "0x18")]
		private PlayerSiracusaMap.TaskInfo m_playerTask;

		// Token: 0x0401EF8C RID: 126860
		[Token(Token = "0x401EF8C")]
		[FieldOffset(Offset = "0x20")]
		private SiracusaData.PointData m_pointData;

		// Token: 0x0401EF8D RID: 126861
		[Token(Token = "0x401EF8D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401EF8E RID: 126862
		[Token(Token = "0x401EF8E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0401EF8F RID: 126863
		[Token(Token = "0x401EF8F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_placeId;

		// Token: 0x0401EF90 RID: 126864
		[Token(Token = "0x401EF90")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_npcId;

		// Token: 0x0401EF91 RID: 126865
		[Token(Token = "0x401EF91")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_placeName;

		// Token: 0x0401EF92 RID: 126866
		[Token(Token = "0x401EF92")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_taskStatus;

		// Token: 0x0401EF93 RID: 126867
		[Token(Token = "0x401EF93")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_battleProgress;

		// Token: 0x0401EF94 RID: 126868
		[Token(Token = "0x401EF94")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_taskType;

		// Token: 0x0401EF95 RID: 126869
		[Token(Token = "0x401EF95")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_taskId;

		// Token: 0x0401EF96 RID: 126870
		[Token(Token = "0x401EF96")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401EF97 RID: 126871
		[Token(Token = "0x401EF97")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Create;
	}
}
