using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200602B RID: 24619
	[Token(Token = "0x200602B")]
	public class CarvingHomeEntryViewModel : IHotfixable
	{
		// Token: 0x1700540C RID: 21516
		// (get) Token: 0x060239A1 RID: 145825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700540C")]
		public CarvingHomeEntryItemViewModel focusItem
		{
			[Token(Token = "0x60239A1")]
			[Address(RVA = "0x1E45550", Offset = "0x1E44150", VA = "0x181E45550")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700540D RID: 21517
		// (get) Token: 0x060239A2 RID: 145826 RVA: 0x000C1500 File Offset: 0x000BF700
		[Token(Token = "0x1700540D")]
		public bool isPrevItemNew
		{
			[Token(Token = "0x60239A2")]
			[Address(RVA = "0x1E45770", Offset = "0x1E44370", VA = "0x181E45770")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700540E RID: 21518
		// (get) Token: 0x060239A3 RID: 145827 RVA: 0x000C1518 File Offset: 0x000BF718
		[Token(Token = "0x1700540E")]
		public bool isNextItemNew
		{
			[Token(Token = "0x60239A3")]
			[Address(RVA = "0x1E45680", Offset = "0x1E44280", VA = "0x181E45680")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700540F RID: 21519
		// (get) Token: 0x060239A4 RID: 145828 RVA: 0x000C1530 File Offset: 0x000BF730
		[Token(Token = "0x1700540F")]
		public int itemCount
		{
			[Token(Token = "0x60239A4")]
			[Address(RVA = "0x1E45820", Offset = "0x1E44420", VA = "0x181E45820")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060239A5 RID: 145829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239A5")]
		[Address(RVA = "0x1E44E90", Offset = "0x1E43A90", VA = "0x181E44E90")]
		public void LoadData(string activityId)
		{
		}

		// Token: 0x060239A6 RID: 145830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239A6")]
		[Address(RVA = "0x1E44F10", Offset = "0x1E43B10", VA = "0x181E44F10")]
		public void RefreshData()
		{
		}

		// Token: 0x060239A7 RID: 145831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239A7")]
		[Address(RVA = "0x1E44D60", Offset = "0x1E43960", VA = "0x181E44D60")]
		public void FocusLastPlayChallengeIfNeed()
		{
		}

		// Token: 0x060239A8 RID: 145832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239A8")]
		[Address(RVA = "0x1E454A0", Offset = "0x1E440A0", VA = "0x181E454A0")]
		public CarvingHomeEntryViewModel()
		{
		}

		// Token: 0x040314AD RID: 201901
		[Token(Token = "0x40314AD")]
		public const int DEFAULT_ENTER_SEQUENCE = 0;

		// Token: 0x040314AE RID: 201902
		[Token(Token = "0x40314AE")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x040314AF RID: 201903
		[Token(Token = "0x40314AF")]
		[FieldOffset(Offset = "0x18")]
		public int enterSequence;

		// Token: 0x040314B0 RID: 201904
		[Token(Token = "0x40314B0")]
		[FieldOffset(Offset = "0x20")]
		public List<CarvingHomeEntryItemViewModel> itemModelList;

		// Token: 0x040314B1 RID: 201905
		[Token(Token = "0x40314B1")]
		[FieldOffset(Offset = "0x28")]
		public int focusIndex;

		// Token: 0x040314B2 RID: 201906
		[Token(Token = "0x40314B2")]
		[FieldOffset(Offset = "0x2C")]
		public bool isPlaying;

		// Token: 0x040314B3 RID: 201907
		[Token(Token = "0x40314B3")]
		[FieldOffset(Offset = "0x30")]
		private string m_playingChallengeId;

		// Token: 0x040314B4 RID: 201908
		[Token(Token = "0x40314B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_focusItem;

		// Token: 0x040314B5 RID: 201909
		[Token(Token = "0x40314B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isPrevItemNew;

		// Token: 0x040314B6 RID: 201910
		[Token(Token = "0x40314B6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isNextItemNew;

		// Token: 0x040314B7 RID: 201911
		[Token(Token = "0x40314B7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_itemCount;

		// Token: 0x040314B8 RID: 201912
		[Token(Token = "0x40314B8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040314B9 RID: 201913
		[Token(Token = "0x40314B9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x040314BA RID: 201914
		[Token(Token = "0x40314BA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_FocusLastPlayChallengeIfNeed;

		// Token: 0x040314BB RID: 201915
		[Token(Token = "0x40314BB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
