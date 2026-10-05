using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F05 RID: 16133
	[Token(Token = "0x2003F05")]
	public class SiracusaCharAVGTaskModel : SiracusaCharTaskModel
	{
		// Token: 0x060190C3 RID: 102595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190C3")]
		[Address(RVA = "0x11AD430", Offset = "0x11AC030", VA = "0x1811AD430", Slot = "4")]
		public override void LoadData(SiracusaData siracusaData, SiracusaData.TaskBasicInfoData taskInfoData, PlayerSiracusaMap.TaskInfo playerTask)
		{
		}

		// Token: 0x060190C4 RID: 102596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190C4")]
		[Address(RVA = "0x11AD530", Offset = "0x11AC130", VA = "0x1811AD530")]
		public SiracusaCharAVGTaskModel()
		{
		}

		// Token: 0x060190C5 RID: 102597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190C5")]
		[Address(RVA = "0x11AD520", Offset = "0x11AC120", VA = "0x1811AD520")]
		private void <>xLuaBaseProxy_LoadData(SiracusaData P0, SiracusaData.TaskBasicInfoData P1, PlayerSiracusaMap.TaskInfo P2)
		{
		}

		// Token: 0x0401EF9D RID: 126877
		[Token(Token = "0x401EF9D")]
		[FieldOffset(Offset = "0x28")]
		private SiracusaData.AVGTaskData m_avgTaskData;

		// Token: 0x0401EF9E RID: 126878
		[Token(Token = "0x401EF9E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401EF9F RID: 126879
		[Token(Token = "0x401EF9F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
