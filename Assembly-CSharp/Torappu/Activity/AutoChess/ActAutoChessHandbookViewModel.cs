using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x0200710B RID: 28939
	[Token(Token = "0x200710B")]
	public class ActAutoChessHandbookViewModel : IHotfixable
	{
		// Token: 0x060291EC RID: 168428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291EC")]
		[Address(RVA = "0x2488200", Offset = "0x2486E00", VA = "0x182488200")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x060291ED RID: 168429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291ED")]
		[Address(RVA = "0x2488B80", Offset = "0x2487780", VA = "0x182488B80")]
		private void _LoadBondData()
		{
		}

		// Token: 0x060291EE RID: 168430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60291EE")]
		[Address(RVA = "0x24890E0", Offset = "0x2487CE0", VA = "0x1824890E0")]
		private List<ActAutoChessHandbookChessViewModel> _LoadChessData(List<string> chessIdList, ListDict<string, ActAutoChessData.ActAutoChessCharShopChessData> chessDict, Dictionary<string, ActAutoChessData.ActAutoChessCharChessData> charChessDataDict)
		{
			return null;
		}

		// Token: 0x060291EF RID: 168431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291EF")]
		[Address(RVA = "0x248A3C0", Offset = "0x2488FC0", VA = "0x18248A3C0")]
		private void _RefreshBondList()
		{
		}

		// Token: 0x060291F0 RID: 168432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291F0")]
		[Address(RVA = "0x24882C0", Offset = "0x2486EC0", VA = "0x1824882C0")]
		private void _LoadBandData()
		{
		}

		// Token: 0x060291F1 RID: 168433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291F1")]
		[Address(RVA = "0x248A170", Offset = "0x2488D70", VA = "0x18248A170")]
		private void _RefreshBandList()
		{
		}

		// Token: 0x060291F2 RID: 168434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291F2")]
		[Address(RVA = "0x2489530", Offset = "0x2488130", VA = "0x182489530")]
		private void _LoadEnemyData()
		{
		}

		// Token: 0x060291F3 RID: 168435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291F3")]
		[Address(RVA = "0x248A730", Offset = "0x2489330", VA = "0x18248A730")]
		private void _RefreshEnemyList()
		{
		}

		// Token: 0x060291F4 RID: 168436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291F4")]
		[Address(RVA = "0x248AAA0", Offset = "0x24896A0", VA = "0x18248AAA0")]
		public ActAutoChessHandbookViewModel()
		{
		}

		// Token: 0x0403AB5F RID: 240479
		[Token(Token = "0x403AB5F")]
		public const int DEFAULT_SEQUENCE_NUM = 0;

		// Token: 0x0403AB60 RID: 240480
		[Token(Token = "0x403AB60")]
		private const string BANNED_BAND_ID = "";

		// Token: 0x0403AB61 RID: 240481
		[Token(Token = "0x403AB61")]
		[FieldOffset(Offset = "0x10")]
		public ActAutoChessHandbookTabType type;

		// Token: 0x0403AB62 RID: 240482
		[Token(Token = "0x403AB62")]
		[FieldOffset(Offset = "0x14")]
		public int sequence;

		// Token: 0x0403AB63 RID: 240483
		[Token(Token = "0x403AB63")]
		[FieldOffset(Offset = "0x18")]
		public List<UISimpleRecycleLayoutItemViewModel> bondList;

		// Token: 0x0403AB64 RID: 240484
		[Token(Token = "0x403AB64")]
		[FieldOffset(Offset = "0x20")]
		public string selectedBondId;

		// Token: 0x0403AB65 RID: 240485
		[Token(Token = "0x403AB65")]
		[FieldOffset(Offset = "0x28")]
		public List<UISimpleRecycleLayoutItemViewModel> bandList;

		// Token: 0x0403AB66 RID: 240486
		[Token(Token = "0x403AB66")]
		[FieldOffset(Offset = "0x30")]
		public string selectedBandId;

		// Token: 0x0403AB67 RID: 240487
		[Token(Token = "0x403AB67")]
		[FieldOffset(Offset = "0x38")]
		public List<UISimpleRecycleLayoutItemViewModel> enemyList;

		// Token: 0x0403AB68 RID: 240488
		[Token(Token = "0x403AB68")]
		[FieldOffset(Offset = "0x40")]
		public string selectedEnemyId;

		// Token: 0x0403AB69 RID: 240489
		[Token(Token = "0x403AB69")]
		[FieldOffset(Offset = "0x48")]
		public ListDict<string, ActAutoChessHandbookBondViewModel> bondModelDict;

		// Token: 0x0403AB6A RID: 240490
		[Token(Token = "0x403AB6A")]
		[FieldOffset(Offset = "0x50")]
		public ListDict<string, ActAutoChessHandbookBandViewModel> bandModelDict;

		// Token: 0x0403AB6B RID: 240491
		[Token(Token = "0x403AB6B")]
		[FieldOffset(Offset = "0x58")]
		public ListDict<string, ActAutoChessHandbookEnemyViewModel> enemyModelDict;

		// Token: 0x0403AB6C RID: 240492
		[Token(Token = "0x403AB6C")]
		[FieldOffset(Offset = "0x60")]
		private string m_actId;

		// Token: 0x0403AB6D RID: 240493
		[Token(Token = "0x403AB6D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403AB6E RID: 240494
		[Token(Token = "0x403AB6E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadBondData;

		// Token: 0x0403AB6F RID: 240495
		[Token(Token = "0x403AB6F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadChessData;

		// Token: 0x0403AB70 RID: 240496
		[Token(Token = "0x403AB70")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshBondList;

		// Token: 0x0403AB71 RID: 240497
		[Token(Token = "0x403AB71")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadBandData;

		// Token: 0x0403AB72 RID: 240498
		[Token(Token = "0x403AB72")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RefreshBandList;

		// Token: 0x0403AB73 RID: 240499
		[Token(Token = "0x403AB73")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadEnemyData;

		// Token: 0x0403AB74 RID: 240500
		[Token(Token = "0x403AB74")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RefreshEnemyList;

		// Token: 0x0403AB75 RID: 240501
		[Token(Token = "0x403AB75")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
