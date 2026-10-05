using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F04 RID: 16132
	[Token(Token = "0x2003F04")]
	public class SiracusaCharBattleTaskModel : SiracusaCharTaskModel
	{
		// Token: 0x17003BD9 RID: 15321
		// (get) Token: 0x060190BE RID: 102590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BD9")]
		public string stageId
		{
			[Token(Token = "0x60190BE")]
			[Address(RVA = "0x11AD760", Offset = "0x11AC360", VA = "0x1811AD760")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003BDA RID: 15322
		// (get) Token: 0x060190BF RID: 102591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BDA")]
		public string taskDesc
		{
			[Token(Token = "0x60190BF")]
			[Address(RVA = "0x11AD7D0", Offset = "0x11AC3D0", VA = "0x1811AD7D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060190C0 RID: 102592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190C0")]
		[Address(RVA = "0x11AD5D0", Offset = "0x11AC1D0", VA = "0x1811AD5D0", Slot = "4")]
		public override void LoadData(SiracusaData siracusaData, SiracusaData.TaskBasicInfoData taskInfoData, PlayerSiracusaMap.TaskInfo playerTask)
		{
		}

		// Token: 0x060190C1 RID: 102593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190C1")]
		[Address(RVA = "0x11AD6C0", Offset = "0x11AC2C0", VA = "0x1811AD6C0")]
		public SiracusaCharBattleTaskModel()
		{
		}

		// Token: 0x060190C2 RID: 102594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190C2")]
		[Address(RVA = "0x11AD520", Offset = "0x11AC120", VA = "0x1811AD520")]
		private void <>xLuaBaseProxy_LoadData(SiracusaData P0, SiracusaData.TaskBasicInfoData P1, PlayerSiracusaMap.TaskInfo P2)
		{
		}

		// Token: 0x0401EF98 RID: 126872
		[Token(Token = "0x401EF98")]
		[FieldOffset(Offset = "0x28")]
		private SiracusaData.BattleTaskData m_battleTaskData;

		// Token: 0x0401EF99 RID: 126873
		[Token(Token = "0x401EF99")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x0401EF9A RID: 126874
		[Token(Token = "0x401EF9A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_taskDesc;

		// Token: 0x0401EF9B RID: 126875
		[Token(Token = "0x401EF9B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401EF9C RID: 126876
		[Token(Token = "0x401EF9C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
