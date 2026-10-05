using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020034F5 RID: 13557
	[Token(Token = "0x20034F5")]
	public interface IComparableChar : IHotfixable
	{
		// Token: 0x1700330A RID: 13066
		// (get) Token: 0x060159A9 RID: 88489
		[Token(Token = "0x1700330A")]
		string name { [Token(Token = "0x60159A9")] get; }

		// Token: 0x1700330B RID: 13067
		// (get) Token: 0x060159AA RID: 88490
		[Token(Token = "0x1700330B")]
		RarityRank rarity { [Token(Token = "0x60159AA")] get; }

		// Token: 0x1700330C RID: 13068
		// (get) Token: 0x060159AB RID: 88491
		[Token(Token = "0x1700330C")]
		ProfessionCategory profession { [Token(Token = "0x60159AB")] get; }

		// Token: 0x1700330D RID: 13069
		// (get) Token: 0x060159AC RID: 88492
		[Token(Token = "0x1700330D")]
		EvolvePhase evolvePhase { [Token(Token = "0x60159AC")] get; }

		// Token: 0x1700330E RID: 13070
		// (get) Token: 0x060159AD RID: 88493
		[Token(Token = "0x1700330E")]
		int level { [Token(Token = "0x60159AD")] get; }

		// Token: 0x1700330F RID: 13071
		// (get) Token: 0x060159AE RID: 88494
		[Token(Token = "0x1700330F")]
		DateTime gainTime { [Token(Token = "0x60159AE")] get; }

		// Token: 0x17003310 RID: 13072
		// (get) Token: 0x060159AF RID: 88495
		[Token(Token = "0x17003310")]
		int favorPoint { [Token(Token = "0x60159AF")] get; }

		// Token: 0x17003311 RID: 13073
		// (get) Token: 0x060159B0 RID: 88496
		[Token(Token = "0x17003311")]
		int atk { [Token(Token = "0x60159B0")] get; }

		// Token: 0x17003312 RID: 13074
		// (get) Token: 0x060159B1 RID: 88497
		[Token(Token = "0x17003312")]
		int def { [Token(Token = "0x60159B1")] get; }

		// Token: 0x17003313 RID: 13075
		// (get) Token: 0x060159B2 RID: 88498
		[Token(Token = "0x17003313")]
		float magicRes { [Token(Token = "0x60159B2")] get; }

		// Token: 0x17003314 RID: 13076
		// (get) Token: 0x060159B3 RID: 88499
		[Token(Token = "0x17003314")]
		int cost { [Token(Token = "0x60159B3")] get; }

		// Token: 0x17003315 RID: 13077
		// (get) Token: 0x060159B4 RID: 88500
		[Token(Token = "0x17003315")]
		int maxHp { [Token(Token = "0x60159B4")] get; }

		// Token: 0x17003316 RID: 13078
		// (get) Token: 0x060159B5 RID: 88501
		[Token(Token = "0x17003316")]
		int blockCnt { [Token(Token = "0x60159B5")] get; }

		// Token: 0x17003317 RID: 13079
		// (get) Token: 0x060159B6 RID: 88502
		[Token(Token = "0x17003317")]
		int respawnTime { [Token(Token = "0x60159B6")] get; }

		// Token: 0x17003318 RID: 13080
		// (get) Token: 0x060159B7 RID: 88503
		[Token(Token = "0x17003318")]
		float atkSpeed { [Token(Token = "0x60159B7")] get; }

		// Token: 0x17003319 RID: 13081
		// (get) Token: 0x060159B8 RID: 88504
		[Token(Token = "0x17003319")]
		int sortIndex { [Token(Token = "0x60159B8")] get; }

		// Token: 0x060159B9 RID: 88505 RVA: 0x0008CCD0 File Offset: 0x0008AED0
		[Token(Token = "0x60159B9")]
		[Address(RVA = "0xE38F80", Offset = "0xE37B80", VA = "0x180E38F80", Slot = "16")]
		int CompareWithSingleType(IComparableChar targetChar, CharacterSortType sortType)
		{
			return 0;
		}

		// Token: 0x060159BA RID: 88506 RVA: 0x0008CCE8 File Offset: 0x0008AEE8
		[Token(Token = "0x60159BA")]
		[Address(RVA = "0xE38E90", Offset = "0xE37A90", VA = "0x180E38E90", Slot = "17")]
		int CompareWithAllType(IComparableChar targetChar)
		{
			return 0;
		}
	}
}
