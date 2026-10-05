using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200602A RID: 24618
	[Token(Token = "0x200602A")]
	public class CarvingHomeEntryItemViewModel : IComparable, IHotfixable
	{
		// Token: 0x1700540B RID: 21515
		// (get) Token: 0x0602399D RID: 145821 RVA: 0x000C14D0 File Offset: 0x000BF6D0
		[Token(Token = "0x1700540B")]
		public bool isLocked
		{
			[Token(Token = "0x602399D")]
			[Address(RVA = "0x1E44B50", Offset = "0x1E43750", VA = "0x181E44B50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602399E RID: 145822 RVA: 0x000C14E8 File Offset: 0x000BF6E8
		[Token(Token = "0x602399E")]
		[Address(RVA = "0x1E449F0", Offset = "0x1E435F0", VA = "0x181E449F0", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x0602399F RID: 145823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602399F")]
		[Address(RVA = "0x1E44940", Offset = "0x1E43540", VA = "0x181E44940")]
		public void CalcStatus(long currTs)
		{
		}

		// Token: 0x060239A0 RID: 145824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239A0")]
		[Address(RVA = "0x1E44AF0", Offset = "0x1E436F0", VA = "0x181E44AF0")]
		public CarvingHomeEntryItemViewModel()
		{
		}

		// Token: 0x0403149C RID: 201884
		[Token(Token = "0x403149C")]
		[FieldOffset(Offset = "0x10")]
		public CarvingChallengeStatus status;

		// Token: 0x0403149D RID: 201885
		[Token(Token = "0x403149D")]
		[FieldOffset(Offset = "0x18")]
		public string id;

		// Token: 0x0403149E RID: 201886
		[Token(Token = "0x403149E")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x0403149F RID: 201887
		[Token(Token = "0x403149F")]
		[FieldOffset(Offset = "0x28")]
		public string desc;

		// Token: 0x040314A0 RID: 201888
		[Token(Token = "0x40314A0")]
		[FieldOffset(Offset = "0x30")]
		public int bestRecord;

		// Token: 0x040314A1 RID: 201889
		[Token(Token = "0x40314A1")]
		[FieldOffset(Offset = "0x34")]
		public int roundCount;

		// Token: 0x040314A2 RID: 201890
		[Token(Token = "0x40314A2")]
		[FieldOffset(Offset = "0x38")]
		public string prefabId;

		// Token: 0x040314A3 RID: 201891
		[Token(Token = "0x40314A3")]
		[FieldOffset(Offset = "0x40")]
		public string iconId;

		// Token: 0x040314A4 RID: 201892
		[Token(Token = "0x40314A4")]
		[FieldOffset(Offset = "0x48")]
		public int sortId;

		// Token: 0x040314A5 RID: 201893
		[Token(Token = "0x40314A5")]
		[FieldOffset(Offset = "0x50")]
		public long openTs;

		// Token: 0x040314A6 RID: 201894
		[Token(Token = "0x40314A6")]
		[FieldOffset(Offset = "0x58")]
		public DateTime openTime;

		// Token: 0x040314A7 RID: 201895
		[Token(Token = "0x40314A7")]
		[FieldOffset(Offset = "0x60")]
		public bool isStageLocked;

		// Token: 0x040314A8 RID: 201896
		[Token(Token = "0x40314A8")]
		[FieldOffset(Offset = "0x61")]
		public bool isNewUnlock;

		// Token: 0x040314A9 RID: 201897
		[Token(Token = "0x40314A9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isLocked;

		// Token: 0x040314AA RID: 201898
		[Token(Token = "0x40314AA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x040314AB RID: 201899
		[Token(Token = "0x40314AB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CalcStatus;

		// Token: 0x040314AC RID: 201900
		[Token(Token = "0x40314AC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
