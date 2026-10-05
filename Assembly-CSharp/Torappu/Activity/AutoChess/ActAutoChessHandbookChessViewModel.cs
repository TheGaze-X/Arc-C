using System;
using Il2CppDummyDll;
using Torappu.UI.AutoChess;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007108 RID: 28936
	[Token(Token = "0x2007108")]
	public class ActAutoChessHandbookChessViewModel : IAutoChessCommonChessModel, IComparable, IHotfixable
	{
		// Token: 0x060291E2 RID: 168418 RVA: 0x000D4868 File Offset: 0x000D2A68
		[Token(Token = "0x60291E2")]
		[Address(RVA = "0x2484130", Offset = "0x2482D30", VA = "0x182484130", Slot = "4")]
		public int GetLevel()
		{
			return 0;
		}

		// Token: 0x060291E3 RID: 168419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60291E3")]
		[Address(RVA = "0x2484070", Offset = "0x2482C70", VA = "0x182484070", Slot = "5")]
		public string GetCharId()
		{
			return null;
		}

		// Token: 0x060291E4 RID: 168420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60291E4")]
		[Address(RVA = "0x2484190", Offset = "0x2482D90", VA = "0x182484190", Slot = "6")]
		public string GetTmplId()
		{
			return null;
		}

		// Token: 0x060291E5 RID: 168421 RVA: 0x000D4880 File Offset: 0x000D2A80
		[Token(Token = "0x60291E5")]
		[Address(RVA = "0x24840D0", Offset = "0x2482CD0", VA = "0x1824840D0", Slot = "7")]
		public EvolvePhase GetGoldenEvolvePhase()
		{
			return EvolvePhase.PHASE_0;
		}

		// Token: 0x060291E6 RID: 168422 RVA: 0x000D4898 File Offset: 0x000D2A98
		[Token(Token = "0x60291E6")]
		[Address(RVA = "0x2483F00", Offset = "0x2482B00", VA = "0x182483F00", Slot = "8")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x060291E7 RID: 168423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291E7")]
		[Address(RVA = "0x24841F0", Offset = "0x2482DF0", VA = "0x1824841F0")]
		public ActAutoChessHandbookChessViewModel()
		{
		}

		// Token: 0x0403AB3B RID: 240443
		[Token(Token = "0x403AB3B")]
		[FieldOffset(Offset = "0x10")]
		public string chessId;

		// Token: 0x0403AB3C RID: 240444
		[Token(Token = "0x403AB3C")]
		[FieldOffset(Offset = "0x18")]
		public int chessLevel;

		// Token: 0x0403AB3D RID: 240445
		[Token(Token = "0x403AB3D")]
		[FieldOffset(Offset = "0x20")]
		public string charId;

		// Token: 0x0403AB3E RID: 240446
		[Token(Token = "0x403AB3E")]
		[FieldOffset(Offset = "0x28")]
		public string tmplId;

		// Token: 0x0403AB3F RID: 240447
		[Token(Token = "0x403AB3F")]
		[FieldOffset(Offset = "0x30")]
		public ProfessionCategory profession;

		// Token: 0x0403AB40 RID: 240448
		[Token(Token = "0x403AB40")]
		[FieldOffset(Offset = "0x34")]
		public bool isOwn;

		// Token: 0x0403AB41 RID: 240449
		[Token(Token = "0x403AB41")]
		[FieldOffset(Offset = "0x38")]
		public int sortId;

		// Token: 0x0403AB42 RID: 240450
		[Token(Token = "0x403AB42")]
		[FieldOffset(Offset = "0x3C")]
		public EvolvePhase goldenEvolvePhase;

		// Token: 0x0403AB43 RID: 240451
		[Token(Token = "0x403AB43")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetLevel;

		// Token: 0x0403AB44 RID: 240452
		[Token(Token = "0x403AB44")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCharId;

		// Token: 0x0403AB45 RID: 240453
		[Token(Token = "0x403AB45")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetTmplId;

		// Token: 0x0403AB46 RID: 240454
		[Token(Token = "0x403AB46")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetGoldenEvolvePhase;

		// Token: 0x0403AB47 RID: 240455
		[Token(Token = "0x403AB47")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403AB48 RID: 240456
		[Token(Token = "0x403AB48")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
