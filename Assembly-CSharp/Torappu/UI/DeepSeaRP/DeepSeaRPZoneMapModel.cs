using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x0200513E RID: 20798
	[Token(Token = "0x200513E")]
	public class DeepSeaRPZoneMapModel : IHotfixable
	{
		// Token: 0x1700479C RID: 18332
		// (get) Token: 0x0601EBA9 RID: 125865 RVA: 0x000AF680 File Offset: 0x000AD880
		[Token(Token = "0x1700479C")]
		public DeepSeaRPZoneMapModel.ZoneStatus zoneStatus
		{
			[Token(Token = "0x601EBA9")]
			[Address(RVA = "0x1877CB0", Offset = "0x18768B0", VA = "0x181877CB0")]
			get
			{
				return DeepSeaRPZoneMapModel.ZoneStatus.TIMELOCKED;
			}
		}

		// Token: 0x1700479D RID: 18333
		// (get) Token: 0x0601EBAA RID: 125866 RVA: 0x000AF698 File Offset: 0x000AD898
		[Token(Token = "0x1700479D")]
		public int zoneIndex
		{
			[Token(Token = "0x601EBAA")]
			[Address(RVA = "0x1877BB0", Offset = "0x18767B0", VA = "0x181877BB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700479E RID: 18334
		// (get) Token: 0x0601EBAB RID: 125867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700479E")]
		public string zoneId
		{
			[Token(Token = "0x601EBAB")]
			[Address(RVA = "0x1877B20", Offset = "0x1876720", VA = "0x181877B20")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700479F RID: 18335
		// (get) Token: 0x0601EBAC RID: 125868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700479F")]
		public string zoneName
		{
			[Token(Token = "0x601EBAC")]
			[Address(RVA = "0x1877C20", Offset = "0x1876820", VA = "0x181877C20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170047A0 RID: 18336
		// (get) Token: 0x0601EBAD RID: 125869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170047A0")]
		public string lockedText
		{
			[Token(Token = "0x601EBAD")]
			[Address(RVA = "0x1877A20", Offset = "0x1876620", VA = "0x181877A20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170047A1 RID: 18337
		// (get) Token: 0x0601EBAE RID: 125870 RVA: 0x000AF6B0 File Offset: 0x000AD8B0
		[Token(Token = "0x170047A1")]
		public long startTime
		{
			[Token(Token = "0x601EBAE")]
			[Address(RVA = "0x1877AB0", Offset = "0x18766B0", VA = "0x181877AB0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x0601EBAF RID: 125871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EBAF")]
		[Address(RVA = "0x1877680", Offset = "0x1876280", VA = "0x181877680")]
		public void InitData(bool isRetro, Act17sideData.ZoneData act17sideZoneData)
		{
		}

		// Token: 0x0601EBB0 RID: 125872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EBB0")]
		[Address(RVA = "0x1877800", Offset = "0x1876400", VA = "0x181877800")]
		private void _UpdateZoneStatus()
		{
		}

		// Token: 0x0601EBB1 RID: 125873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EBB1")]
		[Address(RVA = "0x18779C0", Offset = "0x18765C0", VA = "0x1818779C0")]
		public DeepSeaRPZoneMapModel()
		{
		}

		// Token: 0x04029375 RID: 168821
		[Token(Token = "0x4029375")]
		[FieldOffset(Offset = "0x10")]
		private ZoneData m_zoneData;

		// Token: 0x04029376 RID: 168822
		[Token(Token = "0x4029376")]
		[FieldOffset(Offset = "0x18")]
		private bool m_isRetro;

		// Token: 0x04029377 RID: 168823
		[Token(Token = "0x4029377")]
		[FieldOffset(Offset = "0x20")]
		private Act17sideData.ZoneData m_zoneAdditionData;

		// Token: 0x04029378 RID: 168824
		[Token(Token = "0x4029378")]
		[FieldOffset(Offset = "0x28")]
		private ZoneValidInfo m_zoneValidInfo;

		// Token: 0x04029379 RID: 168825
		[Token(Token = "0x4029379")]
		[FieldOffset(Offset = "0x30")]
		private DeepSeaRPZoneMapModel.ZoneStatus m_zoneStatus;

		// Token: 0x0402937A RID: 168826
		[Token(Token = "0x402937A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_zoneStatus;

		// Token: 0x0402937B RID: 168827
		[Token(Token = "0x402937B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_zoneIndex;

		// Token: 0x0402937C RID: 168828
		[Token(Token = "0x402937C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_zoneId;

		// Token: 0x0402937D RID: 168829
		[Token(Token = "0x402937D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_zoneName;

		// Token: 0x0402937E RID: 168830
		[Token(Token = "0x402937E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_lockedText;

		// Token: 0x0402937F RID: 168831
		[Token(Token = "0x402937F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_startTime;

		// Token: 0x04029380 RID: 168832
		[Token(Token = "0x4029380")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04029381 RID: 168833
		[Token(Token = "0x4029381")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateZoneStatus;

		// Token: 0x04029382 RID: 168834
		[Token(Token = "0x4029382")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200513F RID: 20799
		[Token(Token = "0x200513F")]
		public enum ZoneStatus
		{
			// Token: 0x04029384 RID: 168836
			[Token(Token = "0x4029384")]
			TIMELOCKED,
			// Token: 0x04029385 RID: 168837
			[Token(Token = "0x4029385")]
			STAGELOCKED,
			// Token: 0x04029386 RID: 168838
			[Token(Token = "0x4029386")]
			OPEN,
			// Token: 0x04029387 RID: 168839
			[Token(Token = "0x4029387")]
			TIMEOUT
		}
	}
}
