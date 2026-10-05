using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x020047F5 RID: 18421
	[Token(Token = "0x20047F5")]
	public class MonopolyCardPanelModel : IHotfixable
	{
		// Token: 0x1700423B RID: 16955
		// (get) Token: 0x0601BDC0 RID: 114112 RVA: 0x000A6788 File Offset: 0x000A4988
		[Token(Token = "0x1700423B")]
		public bool hasAllCardUsed
		{
			[Token(Token = "0x601BDC0")]
			[Address(RVA = "0x1538050", Offset = "0x1536C50", VA = "0x181538050")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700423C RID: 16956
		// (get) Token: 0x0601BDC1 RID: 114113 RVA: 0x000A67A0 File Offset: 0x000A49A0
		[Token(Token = "0x1700423C")]
		public bool hasAnyCardUsed
		{
			[Token(Token = "0x601BDC1")]
			[Address(RVA = "0x15381C0", Offset = "0x1536DC0", VA = "0x1815381C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700423D RID: 16957
		// (get) Token: 0x0601BDC2 RID: 114114 RVA: 0x000A67B8 File Offset: 0x000A49B8
		[Token(Token = "0x1700423D")]
		public int selectCardPoint
		{
			[Token(Token = "0x601BDC2")]
			[Address(RVA = "0x15383B0", Offset = "0x1536FB0", VA = "0x1815383B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700423E RID: 16958
		// (get) Token: 0x0601BDC3 RID: 114115 RVA: 0x000A67D0 File Offset: 0x000A49D0
		[Token(Token = "0x1700423E")]
		public bool canMove
		{
			[Token(Token = "0x601BDC3")]
			[Address(RVA = "0x1537FE0", Offset = "0x1536BE0", VA = "0x181537FE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700423F RID: 16959
		// (get) Token: 0x0601BDC4 RID: 114116 RVA: 0x000A67E8 File Offset: 0x000A49E8
		[Token(Token = "0x1700423F")]
		public bool canMining
		{
			[Token(Token = "0x601BDC4")]
			[Address(RVA = "0x1537F50", Offset = "0x1536B50", VA = "0x181537F50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004240 RID: 16960
		// (get) Token: 0x0601BDC5 RID: 114117 RVA: 0x000A6800 File Offset: 0x000A4A00
		[Token(Token = "0x17004240")]
		public bool isSelectCardCombo
		{
			[Token(Token = "0x601BDC5")]
			[Address(RVA = "0x1538330", Offset = "0x1536F30", VA = "0x181538330")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601BDC6 RID: 114118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDC6")]
		[Address(RVA = "0x1537A60", Offset = "0x1536660", VA = "0x181537A60")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0601BDC7 RID: 114119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDC7")]
		[Address(RVA = "0x1537B10", Offset = "0x1536710", VA = "0x181537B10")]
		public void RefreshData(string actId)
		{
		}

		// Token: 0x0601BDC8 RID: 114120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDC8")]
		[Address(RVA = "0x1537CE0", Offset = "0x15368E0", VA = "0x181537CE0")]
		public void SelectCard(int index)
		{
		}

		// Token: 0x0601BDC9 RID: 114121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDC9")]
		[Address(RVA = "0x1537970", Offset = "0x1536570", VA = "0x181537970")]
		public void CalculateDelayInfo(MonopolyEventType eventType, ref float globalDelay)
		{
		}

		// Token: 0x0601BDCA RID: 114122 RVA: 0x000A6818 File Offset: 0x000A4A18
		[Token(Token = "0x601BDCA")]
		[Address(RVA = "0x1537DF0", Offset = "0x15369F0", VA = "0x181537DF0")]
		private bool _CheckIfCardValid(int index, out int cardPoint)
		{
			return default(bool);
		}

		// Token: 0x0601BDCB RID: 114123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDCB")]
		[Address(RVA = "0x1537EA0", Offset = "0x1536AA0", VA = "0x181537EA0")]
		public MonopolyCardPanelModel()
		{
		}

		// Token: 0x04024461 RID: 148577
		[Token(Token = "0x4024461")]
		public const int INVALID_CARD_INDEX = -1;

		// Token: 0x04024462 RID: 148578
		[Token(Token = "0x4024462")]
		[FieldOffset(Offset = "0x10")]
		public List<int> cardList;

		// Token: 0x04024463 RID: 148579
		[Token(Token = "0x4024463")]
		[FieldOffset(Offset = "0x18")]
		public int lastMiningCardPoint;

		// Token: 0x04024464 RID: 148580
		[Token(Token = "0x4024464")]
		[FieldOffset(Offset = "0x1C")]
		public int selectCardIndex;

		// Token: 0x04024465 RID: 148581
		[Token(Token = "0x4024465")]
		[FieldOffset(Offset = "0x20")]
		public int currTurn;

		// Token: 0x04024466 RID: 148582
		[Token(Token = "0x4024466")]
		[FieldOffset(Offset = "0x24")]
		public int maxTurn;

		// Token: 0x04024467 RID: 148583
		[Token(Token = "0x4024467")]
		[FieldOffset(Offset = "0x28")]
		public float cardBaseRenderDelay;

		// Token: 0x04024468 RID: 148584
		[Token(Token = "0x4024468")]
		[FieldOffset(Offset = "0x2C")]
		public float destroyCardDelay;

		// Token: 0x04024469 RID: 148585
		[Token(Token = "0x4024469")]
		[FieldOffset(Offset = "0x30")]
		public float cardPanelHintRenderDelay;

		// Token: 0x0402446A RID: 148586
		[Token(Token = "0x402446A")]
		[FieldOffset(Offset = "0x34")]
		public bool needDestroyCard;

		// Token: 0x0402446B RID: 148587
		[Token(Token = "0x402446B")]
		[FieldOffset(Offset = "0x35")]
		public bool isEndRound;

		// Token: 0x0402446C RID: 148588
		[Token(Token = "0x402446C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasAllCardUsed;

		// Token: 0x0402446D RID: 148589
		[Token(Token = "0x402446D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_hasAnyCardUsed;

		// Token: 0x0402446E RID: 148590
		[Token(Token = "0x402446E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectCardPoint;

		// Token: 0x0402446F RID: 148591
		[Token(Token = "0x402446F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_canMove;

		// Token: 0x04024470 RID: 148592
		[Token(Token = "0x4024470")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_canMining;

		// Token: 0x04024471 RID: 148593
		[Token(Token = "0x4024471")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isSelectCardCombo;

		// Token: 0x04024472 RID: 148594
		[Token(Token = "0x4024472")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04024473 RID: 148595
		[Token(Token = "0x4024473")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04024474 RID: 148596
		[Token(Token = "0x4024474")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SelectCard;

		// Token: 0x04024475 RID: 148597
		[Token(Token = "0x4024475")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CalculateDelayInfo;

		// Token: 0x04024476 RID: 148598
		[Token(Token = "0x4024476")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckIfCardValid;

		// Token: 0x04024477 RID: 148599
		[Token(Token = "0x4024477")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
