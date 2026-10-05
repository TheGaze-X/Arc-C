using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x02004804 RID: 18436
	[Token(Token = "0x2004804")]
	public class MonopolyMapViewModel : IHotfixable
	{
		// Token: 0x17004242 RID: 16962
		// (get) Token: 0x0601BE0E RID: 114190 RVA: 0x000A68A8 File Offset: 0x000A4AA8
		[Token(Token = "0x17004242")]
		public int playerPos
		{
			[Token(Token = "0x601BE0E")]
			[Address(RVA = "0x1542490", Offset = "0x1541090", VA = "0x181542490")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004243 RID: 16963
		// (get) Token: 0x0601BE0F RID: 114191 RVA: 0x000A68C0 File Offset: 0x000A4AC0
		[Token(Token = "0x17004243")]
		public int playerRound
		{
			[Token(Token = "0x601BE0F")]
			[Address(RVA = "0x1542520", Offset = "0x1541120", VA = "0x181542520")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004244 RID: 16964
		// (get) Token: 0x0601BE10 RID: 114192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004244")]
		public MonopolyMapNodeItemModel currNodeItemViewModel
		{
			[Token(Token = "0x601BE10")]
			[Address(RVA = "0x1542400", Offset = "0x1541000", VA = "0x181542400")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601BE11 RID: 114193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE11")]
		[Address(RVA = "0x1541FE0", Offset = "0x1540BE0", VA = "0x181541FE0")]
		public void LoadPlayerMapData(string actId)
		{
		}

		// Token: 0x0601BE12 RID: 114194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE12")]
		[Address(RVA = "0x1541F20", Offset = "0x1540B20", VA = "0x181541F20")]
		public void CalculateDelayInfo(MonopolyEventType eventType, ref float globalDelay)
		{
		}

		// Token: 0x0601BE13 RID: 114195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE13")]
		[Address(RVA = "0x1542350", Offset = "0x1540F50", VA = "0x181542350")]
		public MonopolyMapViewModel()
		{
		}

		// Token: 0x04024524 RID: 148772
		[Token(Token = "0x4024524")]
		[FieldOffset(Offset = "0x10")]
		public List<MonopolyMapNodeItemModel> nodeList;

		// Token: 0x04024525 RID: 148773
		[Token(Token = "0x4024525")]
		[FieldOffset(Offset = "0x18")]
		public int playerStep;

		// Token: 0x04024526 RID: 148774
		[Token(Token = "0x4024526")]
		[FieldOffset(Offset = "0x20")]
		public string stageId;

		// Token: 0x04024527 RID: 148775
		[Token(Token = "0x4024527")]
		[FieldOffset(Offset = "0x28")]
		public MonopolyEventType playerEventType;

		// Token: 0x04024528 RID: 148776
		[Token(Token = "0x4024528")]
		[FieldOffset(Offset = "0x2C")]
		public float playerPosMoveDelay;

		// Token: 0x04024529 RID: 148777
		[Token(Token = "0x4024529")]
		[FieldOffset(Offset = "0x30")]
		public float miningAnimDelay;

		// Token: 0x0402452A RID: 148778
		[Token(Token = "0x402452A")]
		[FieldOffset(Offset = "0x34")]
		public float mapRefreshDelay;

		// Token: 0x0402452B RID: 148779
		[Token(Token = "0x402452B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_playerPos;

		// Token: 0x0402452C RID: 148780
		[Token(Token = "0x402452C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_playerRound;

		// Token: 0x0402452D RID: 148781
		[Token(Token = "0x402452D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_currNodeItemViewModel;

		// Token: 0x0402452E RID: 148782
		[Token(Token = "0x402452E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadPlayerMapData;

		// Token: 0x0402452F RID: 148783
		[Token(Token = "0x402452F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CalculateDelayInfo;

		// Token: 0x04024530 RID: 148784
		[Token(Token = "0x4024530")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
