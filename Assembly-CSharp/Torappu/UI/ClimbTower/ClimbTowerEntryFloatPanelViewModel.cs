using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DB1 RID: 23985
	[Token(Token = "0x2005DB1")]
	public class ClimbTowerEntryFloatPanelViewModel : IHotfixable
	{
		// Token: 0x06022C60 RID: 142432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C60")]
		[Address(RVA = "0x1D51B50", Offset = "0x1D50750", VA = "0x181D51B50")]
		public void LoadData()
		{
		}

		// Token: 0x06022C61 RID: 142433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C61")]
		[Address(RVA = "0x1D520F0", Offset = "0x1D50CF0", VA = "0x181D520F0")]
		public void SetGodCardTabClosedStatusNot()
		{
		}

		// Token: 0x06022C62 RID: 142434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C62")]
		[Address(RVA = "0x1D52180", Offset = "0x1D50D80", VA = "0x181D52180")]
		private void _LoadSeasonGodCardData()
		{
		}

		// Token: 0x06022C63 RID: 142435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C63")]
		[Address(RVA = "0x1D52300", Offset = "0x1D50F00", VA = "0x181D52300")]
		private void _LoadTowerGodCardData()
		{
		}

		// Token: 0x06022C64 RID: 142436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C64")]
		[Address(RVA = "0x1D52500", Offset = "0x1D51100", VA = "0x181D52500")]
		public ClimbTowerEntryFloatPanelViewModel()
		{
		}

		// Token: 0x0402FD05 RID: 195845
		[Token(Token = "0x402FD05")]
		[FieldOffset(Offset = "0x10")]
		public string seasonId;

		// Token: 0x0402FD06 RID: 195846
		[Token(Token = "0x402FD06")]
		[FieldOffset(Offset = "0x18")]
		public long endTs;

		// Token: 0x0402FD07 RID: 195847
		[Token(Token = "0x402FD07")]
		[FieldOffset(Offset = "0x20")]
		public string remainTimeDesc;

		// Token: 0x0402FD08 RID: 195848
		[Token(Token = "0x402FD08")]
		[FieldOffset(Offset = "0x28")]
		public int periodCurr;

		// Token: 0x0402FD09 RID: 195849
		[Token(Token = "0x402FD09")]
		[FieldOffset(Offset = "0x2C")]
		public int periodCount;

		// Token: 0x0402FD0A RID: 195850
		[Token(Token = "0x402FD0A")]
		[FieldOffset(Offset = "0x30")]
		public int seasonNum;

		// Token: 0x0402FD0B RID: 195851
		[Token(Token = "0x402FD0B")]
		[FieldOffset(Offset = "0x38")]
		public string seasonName;

		// Token: 0x0402FD0C RID: 195852
		[Token(Token = "0x402FD0C")]
		[FieldOffset(Offset = "0x40")]
		public int missionSum;

		// Token: 0x0402FD0D RID: 195853
		[Token(Token = "0x402FD0D")]
		[FieldOffset(Offset = "0x44")]
		public int missionComplete;

		// Token: 0x0402FD0E RID: 195854
		[Token(Token = "0x402FD0E")]
		[FieldOffset(Offset = "0x48")]
		public bool showMissionTrackPoint;

		// Token: 0x0402FD0F RID: 195855
		[Token(Token = "0x402FD0F")]
		[FieldOffset(Offset = "0x49")]
		public bool isMissionAndGodCardBanned;

		// Token: 0x0402FD10 RID: 195856
		[Token(Token = "0x402FD10")]
		[FieldOffset(Offset = "0x50")]
		public List<ClimbTowerEntryGodCardModel> godCardList;

		// Token: 0x0402FD11 RID: 195857
		[Token(Token = "0x402FD11")]
		[FieldOffset(Offset = "0x58")]
		public bool isGodCardTabClose;

		// Token: 0x0402FD12 RID: 195858
		[Token(Token = "0x402FD12")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FD13 RID: 195859
		[Token(Token = "0x402FD13")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetGodCardTabClosedStatusNot;

		// Token: 0x0402FD14 RID: 195860
		[Token(Token = "0x402FD14")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadSeasonGodCardData;

		// Token: 0x0402FD15 RID: 195861
		[Token(Token = "0x402FD15")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadTowerGodCardData;

		// Token: 0x0402FD16 RID: 195862
		[Token(Token = "0x402FD16")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
