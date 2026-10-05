using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077A0 RID: 30624
	[Token(Token = "0x20077A0")]
	public class Act1VHalfIdleDepotBuffItemViewModel : IHotfixable, IComparable<Act1VHalfIdleDepotBuffItemViewModel>
	{
		// Token: 0x170064C4 RID: 25796
		// (get) Token: 0x0602AFF0 RID: 176112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170064C4")]
		public Act1VHalfIdleCharBuffData buffData
		{
			[Token(Token = "0x602AFF0")]
			[Address(RVA = "0x26C8540", Offset = "0x26C7140", VA = "0x1826C8540")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602AFF1 RID: 176113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFF1")]
		[Address(RVA = "0x26C82E0", Offset = "0x26C6EE0", VA = "0x1826C82E0")]
		public void LoadData(string actId, Act1VHalfIdleCharBuffData buffData)
		{
		}

		// Token: 0x0602AFF2 RID: 176114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFF2")]
		[Address(RVA = "0x26C8410", Offset = "0x26C7010", VA = "0x1826C8410")]
		public void RefreshData(int profCharCount)
		{
		}

		// Token: 0x0602AFF3 RID: 176115 RVA: 0x000DA970 File Offset: 0x000D8B70
		[Token(Token = "0x602AFF3")]
		[Address(RVA = "0x26C8220", Offset = "0x26C6E20", VA = "0x1826C8220", Slot = "4")]
		public int CompareTo(Act1VHalfIdleDepotBuffItemViewModel other)
		{
			return 0;
		}

		// Token: 0x0602AFF4 RID: 176116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFF4")]
		[Address(RVA = "0x26C84E0", Offset = "0x26C70E0", VA = "0x1826C84E0")]
		public Act1VHalfIdleDepotBuffItemViewModel()
		{
		}

		// Token: 0x0403E0FE RID: 254206
		[Token(Token = "0x403E0FE")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403E0FF RID: 254207
		[Token(Token = "0x403E0FF")]
		[FieldOffset(Offset = "0x18")]
		public ProfessionCategory prof;

		// Token: 0x0403E100 RID: 254208
		[Token(Token = "0x403E100")]
		[FieldOffset(Offset = "0x1C")]
		public int level;

		// Token: 0x0403E101 RID: 254209
		[Token(Token = "0x403E101")]
		[FieldOffset(Offset = "0x20")]
		public int charCount;

		// Token: 0x0403E102 RID: 254210
		[Token(Token = "0x403E102")]
		[FieldOffset(Offset = "0x28")]
		public string desc;

		// Token: 0x0403E103 RID: 254211
		[Token(Token = "0x403E103")]
		[FieldOffset(Offset = "0x30")]
		public bool isActive;

		// Token: 0x0403E104 RID: 254212
		[Token(Token = "0x403E104")]
		[FieldOffset(Offset = "0x34")]
		public int maxLevel;

		// Token: 0x0403E105 RID: 254213
		[Token(Token = "0x403E105")]
		[FieldOffset(Offset = "0x38")]
		public int nextLevelCharCount;

		// Token: 0x0403E106 RID: 254214
		[Token(Token = "0x403E106")]
		[FieldOffset(Offset = "0x40")]
		private Act1VHalfIdleCharBuffData m_buffData;

		// Token: 0x0403E107 RID: 254215
		[Token(Token = "0x403E107")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_buffData;

		// Token: 0x0403E108 RID: 254216
		[Token(Token = "0x403E108")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403E109 RID: 254217
		[Token(Token = "0x403E109")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0403E10A RID: 254218
		[Token(Token = "0x403E10A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403E10B RID: 254219
		[Token(Token = "0x403E10B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
