using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007210 RID: 29200
	[Token(Token = "0x2007210")]
	public class Act5D1RuneUtil
	{
		// Token: 0x0602966C RID: 169580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602966C")]
		[Address(RVA = "0x24D0F50", Offset = "0x24CFB50", VA = "0x1824D0F50")]
		public static RuneTable.PackedRuneData GetRuneData(string stageId, string runeId)
		{
			return null;
		}

		// Token: 0x0602966D RID: 169581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602966D")]
		[Address(RVA = "0x24D14A0", Offset = "0x24D00A0", VA = "0x1824D14A0")]
		public static Act5D1Data.RuneUnlockData GetRuneUnlockData(string stageId, string runeId)
		{
			return null;
		}

		// Token: 0x0602966E RID: 169582 RVA: 0x000D5948 File Offset: 0x000D3B48
		[Token(Token = "0x602966E")]
		[Address(RVA = "0x24D0B80", Offset = "0x24CF780", VA = "0x1824D0B80")]
		public static bool CheckRuneUnlocked(string stageId, string runeId)
		{
			return default(bool);
		}

		// Token: 0x0602966F RID: 169583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602966F")]
		[Address(RVA = "0x24D0CF0", Offset = "0x24CF8F0", VA = "0x1824D0CF0")]
		public static Act5D1Data.RuneRecurrentStateData GetRecurrentData(string runeReCurrentId)
		{
			return null;
		}

		// Token: 0x06029670 RID: 169584 RVA: 0x000D5960 File Offset: 0x000D3B60
		[Token(Token = "0x6029670")]
		[Address(RVA = "0x24D0B70", Offset = "0x24CF770", VA = "0x1824D0B70")]
		public static bool CheckRuneAvail(int runeState)
		{
			return default(bool);
		}

		// Token: 0x06029671 RID: 169585 RVA: 0x000D5978 File Offset: 0x000D3B78
		[Token(Token = "0x6029671")]
		[Address(RVA = "0x24D0C90", Offset = "0x24CF890", VA = "0x1824D0C90")]
		public static bool CheckRuneUnlocked(int runeState)
		{
			return default(bool);
		}

		// Token: 0x06029672 RID: 169586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029672")]
		[Address(RVA = "0x24D10C0", Offset = "0x24CFCC0", VA = "0x1824D10C0")]
		public static string GetRunePath()
		{
			return null;
		}

		// Token: 0x06029673 RID: 169587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029673")]
		[Address(RVA = "0x24D0CA0", Offset = "0x24CF8A0", VA = "0x1824D0CA0")]
		public static string GetConstRunePathFromBattleFinish()
		{
			return null;
		}

		// Token: 0x06029674 RID: 169588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029674")]
		[Address(RVA = "0x24D0DF0", Offset = "0x24CF9F0", VA = "0x1824D0DF0")]
		public static string GetRuneBackPath()
		{
			return null;
		}

		// Token: 0x06029675 RID: 169589 RVA: 0x000D5990 File Offset: 0x000D3B90
		[Token(Token = "0x6029675")]
		[Address(RVA = "0x24D1100", Offset = "0x24CFD00", VA = "0x1824D1100")]
		public static bool GetRuneSelectState(string key, int defaultParam = 0)
		{
			return default(bool);
		}

		// Token: 0x06029676 RID: 169590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029676")]
		[Address(RVA = "0x24D15D0", Offset = "0x24D01D0", VA = "0x1824D15D0")]
		public static void SetRuneSelect(string stageId, string runeReId, string runeId, bool isSelect)
		{
		}

		// Token: 0x06029677 RID: 169591 RVA: 0x000D59A8 File Offset: 0x000D3BA8
		[Token(Token = "0x6029677")]
		[Address(RVA = "0x24D11F0", Offset = "0x24CFDF0", VA = "0x1824D11F0")]
		public static bool GetRuneSelect(string stageId, string runeReId, string runeId)
		{
			return default(bool);
		}

		// Token: 0x06029678 RID: 169592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029678")]
		[Address(RVA = "0x24D12E0", Offset = "0x24CFEE0", VA = "0x1824D12E0")]
		public static Sprite GetRuneSprite(string runeId, bool isFromBattleFinish = false)
		{
			return null;
		}

		// Token: 0x06029679 RID: 169593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029679")]
		[Address(RVA = "0x24D0E30", Offset = "0x24CFA30", VA = "0x1824D0E30")]
		public static Sprite GetRuneBackSprite(string bgPic)
		{
			return null;
		}

		// Token: 0x0602967A RID: 169594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602967A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act5D1RuneUtil()
		{
		}

		// Token: 0x0403B216 RID: 242198
		[Token(Token = "0x403B216")]
		private const string RUNE_HUB_PATH = "rune_hub";

		// Token: 0x0403B217 RID: 242199
		[Token(Token = "0x403B217")]
		private const string RUNE_BACK_HUB_PATH = "rune_back_hub";

		// Token: 0x0403B218 RID: 242200
		[Token(Token = "0x403B218")]
		public const int AVAILMASK = 2;

		// Token: 0x0403B219 RID: 242201
		[Token(Token = "0x403B219")]
		public const int UNLOCKMASK = 1;

		// Token: 0x0403B21A RID: 242202
		[Token(Token = "0x403B21A")]
		[FieldOffset(Offset = "0x0")]
		public static int SELECT_PARAM;

		// Token: 0x0403B21B RID: 242203
		[Token(Token = "0x403B21B")]
		[FieldOffset(Offset = "0x4")]
		public static int NOT_SELECT_PARAM;
	}
}
