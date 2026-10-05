using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036B0 RID: 14000
	[Token(Token = "0x20036B0")]
	[Serializable]
	public class BattleLogMeta : IHotfixable
	{
		// Token: 0x06016405 RID: 91141 RVA: 0x00090270 File Offset: 0x0008E470
		[Token(Token = "0x6016405")]
		[Address(RVA = "0xEAC900", Offset = "0xEAB500", VA = "0x180EAC900")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06016406 RID: 91142 RVA: 0x00090288 File Offset: 0x0008E488
		[Token(Token = "0x6016406")]
		[Address(RVA = "0xEACC50", Offset = "0xEAB850", VA = "0x180EACC50")]
		public bool IsPredefinedAssistEmpty()
		{
			return default(bool);
		}

		// Token: 0x06016407 RID: 91143 RVA: 0x000902A0 File Offset: 0x0008E4A0
		[Token(Token = "0x6016407")]
		[Address(RVA = "0xEACFA0", Offset = "0xEABBA0", VA = "0x180EACFA0")]
		private bool _IsPredefinedAssistEmpty()
		{
			return default(bool);
		}

		// Token: 0x06016408 RID: 91144 RVA: 0x000902B8 File Offset: 0x0008E4B8
		[Token(Token = "0x6016408")]
		[Address(RVA = "0xEACD30", Offset = "0xEAB930", VA = "0x180EACD30")]
		private bool _IsBattleCharmListEmpty()
		{
			return default(bool);
		}

		// Token: 0x06016409 RID: 91145 RVA: 0x000902D0 File Offset: 0x0008E4D0
		[Token(Token = "0x6016409")]
		[Address(RVA = "0xEACEA0", Offset = "0xEABAA0", VA = "0x180EACEA0")]
		private bool _IsBattleTechListEmpty()
		{
			return default(bool);
		}

		// Token: 0x0601640A RID: 91146 RVA: 0x000902E8 File Offset: 0x0008E4E8
		[Token(Token = "0x601640A")]
		[Address(RVA = "0xEAD040", Offset = "0xEABC40", VA = "0x180EAD040")]
		private bool _IsTemplateTrapListEmpty()
		{
			return default(bool);
		}

		// Token: 0x0601640B RID: 91147 RVA: 0x00090300 File Offset: 0x0008E500
		[Token(Token = "0x601640B")]
		[Address(RVA = "0xEACCB0", Offset = "0xEAB8B0", VA = "0x180EACCB0")]
		private bool _IsBattleCartDictEmpty()
		{
			return default(bool);
		}

		// Token: 0x0601640C RID: 91148 RVA: 0x00090318 File Offset: 0x0008E518
		[Token(Token = "0x601640C")]
		[Address(RVA = "0xEACF20", Offset = "0xEABB20", VA = "0x180EACF20")]
		private bool _IsBattleTrapToolListEmpty()
		{
			return default(bool);
		}

		// Token: 0x0601640D RID: 91149 RVA: 0x00090330 File Offset: 0x0008E530
		[Token(Token = "0x601640D")]
		[Address(RVA = "0xEACE20", Offset = "0xEABA20", VA = "0x180EACE20")]
		private bool _IsBattlePerformanceEmpty()
		{
			return default(bool);
		}

		// Token: 0x0601640E RID: 91150 RVA: 0x00090348 File Offset: 0x0008E548
		[Token(Token = "0x601640E")]
		[Address(RVA = "0xEACDB0", Offset = "0xEAB9B0", VA = "0x180EACDB0")]
		private bool _IsBattleFireworkEmpty()
		{
			return default(bool);
		}

		// Token: 0x0601640F RID: 91151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601640F")]
		[Address(RVA = "0xEAD0C0", Offset = "0xEABCC0", VA = "0x180EAD0C0")]
		public BattleLogMeta()
		{
		}

		// Token: 0x0401AC1D RID: 109597
		[Token(Token = "0x401AC1D")]
		[FieldOffset(Offset = "0x10")]
		public PredefinedAssistData predefinedAssistData;

		// Token: 0x0401AC1E RID: 109598
		[Token(Token = "0x401AC1E")]
		[FieldOffset(Offset = "0x18")]
		public BattleCharmsData battleCharmsData;

		// Token: 0x0401AC1F RID: 109599
		[Token(Token = "0x401AC1F")]
		[FieldOffset(Offset = "0x20")]
		public BattleTemplateTrapData battleTemplateTrapData;

		// Token: 0x0401AC20 RID: 109600
		[Token(Token = "0x401AC20")]
		[FieldOffset(Offset = "0x28")]
		public BattleTechData battleTechesData;

		// Token: 0x0401AC21 RID: 109601
		[Token(Token = "0x401AC21")]
		[FieldOffset(Offset = "0x30")]
		public BattleCartData battleCartData;

		// Token: 0x0401AC22 RID: 109602
		[Token(Token = "0x401AC22")]
		[FieldOffset(Offset = "0x38")]
		public BattleTrapToolData battleTrapToolData;

		// Token: 0x0401AC23 RID: 109603
		[Token(Token = "0x401AC23")]
		[FieldOffset(Offset = "0x40")]
		public BattlePerformanceData battlePerformanceData;

		// Token: 0x0401AC24 RID: 109604
		[Token(Token = "0x401AC24")]
		[FieldOffset(Offset = "0x48")]
		public BattleFireworkData battleFireworkData;

		// Token: 0x0401AC25 RID: 109605
		[Token(Token = "0x401AC25")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x0401AC26 RID: 109606
		[Token(Token = "0x401AC26")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsPredefinedAssistEmpty;

		// Token: 0x0401AC27 RID: 109607
		[Token(Token = "0x401AC27")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__IsPredefinedAssistEmpty;

		// Token: 0x0401AC28 RID: 109608
		[Token(Token = "0x401AC28")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__IsBattleCharmListEmpty;

		// Token: 0x0401AC29 RID: 109609
		[Token(Token = "0x401AC29")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__IsBattleTechListEmpty;

		// Token: 0x0401AC2A RID: 109610
		[Token(Token = "0x401AC2A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__IsTemplateTrapListEmpty;

		// Token: 0x0401AC2B RID: 109611
		[Token(Token = "0x401AC2B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__IsBattleCartDictEmpty;

		// Token: 0x0401AC2C RID: 109612
		[Token(Token = "0x401AC2C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__IsBattleTrapToolListEmpty;

		// Token: 0x0401AC2D RID: 109613
		[Token(Token = "0x401AC2D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__IsBattlePerformanceEmpty;

		// Token: 0x0401AC2E RID: 109614
		[Token(Token = "0x401AC2E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__IsBattleFireworkEmpty;

		// Token: 0x0401AC2F RID: 109615
		[Token(Token = "0x401AC2F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
