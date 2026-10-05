using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077BB RID: 30651
	[Token(Token = "0x20077BB")]
	public class Act1VHalfIdleIncomeGraphItemViewModel : IHotfixable
	{
		// Token: 0x0602B068 RID: 176232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B068")]
		[Address(RVA = "0x26D0920", Offset = "0x26CF520", VA = "0x1826D0920")]
		public void Refresh()
		{
		}

		// Token: 0x0602B069 RID: 176233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B069")]
		[Address(RVA = "0x26D0C00", Offset = "0x26CF800", VA = "0x1826D0C00")]
		public Act1VHalfIdleIncomeGraphItemViewModel()
		{
		}

		// Token: 0x0403E1F4 RID: 254452
		[Token(Token = "0x403E1F4")]
		private const float MIN_FILL_AMOUNT = 0.01f;

		// Token: 0x0403E1F5 RID: 254453
		[Token(Token = "0x403E1F5")]
		[FieldOffset(Offset = "0x10")]
		public Act1VHalfIdleIncomeGraphViewModel.GraphStyle graphStyle;

		// Token: 0x0403E1F6 RID: 254454
		[Token(Token = "0x403E1F6")]
		[FieldOffset(Offset = "0x14")]
		public int value;

		// Token: 0x0403E1F7 RID: 254455
		[Token(Token = "0x403E1F7")]
		[FieldOffset(Offset = "0x18")]
		public int maxValue;

		// Token: 0x0403E1F8 RID: 254456
		[Token(Token = "0x403E1F8")]
		[FieldOffset(Offset = "0x1C")]
		public int lastValue;

		// Token: 0x0403E1F9 RID: 254457
		[Token(Token = "0x403E1F9")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x0403E1FA RID: 254458
		[Token(Token = "0x403E1FA")]
		[FieldOffset(Offset = "0x28")]
		public string itemId;

		// Token: 0x0403E1FB RID: 254459
		[Token(Token = "0x403E1FB")]
		[FieldOffset(Offset = "0x30")]
		public ItemType itemType;

		// Token: 0x0403E1FC RID: 254460
		[Token(Token = "0x403E1FC")]
		[FieldOffset(Offset = "0x34")]
		public bool showFixedDropIcon;

		// Token: 0x0403E1FD RID: 254461
		[Token(Token = "0x403E1FD")]
		[FieldOffset(Offset = "0x35")]
		public bool showHighLightBg;

		// Token: 0x0403E1FE RID: 254462
		[Token(Token = "0x403E1FE")]
		[FieldOffset(Offset = "0x38")]
		public int deltaValue;

		// Token: 0x0403E1FF RID: 254463
		[Token(Token = "0x403E1FF")]
		[FieldOffset(Offset = "0x3C")]
		public bool showItemBg;

		// Token: 0x0403E200 RID: 254464
		[Token(Token = "0x403E200")]
		[FieldOffset(Offset = "0x3D")]
		public bool showMaxIconTip;

		// Token: 0x0403E201 RID: 254465
		[Token(Token = "0x403E201")]
		[FieldOffset(Offset = "0x3E")]
		public bool showMaxLight;

		// Token: 0x0403E202 RID: 254466
		[Token(Token = "0x403E202")]
		[FieldOffset(Offset = "0x3F")]
		public bool showMaxTopCap;

		// Token: 0x0403E203 RID: 254467
		[Token(Token = "0x403E203")]
		[FieldOffset(Offset = "0x40")]
		public bool showDataDiffPart;

		// Token: 0x0403E204 RID: 254468
		[Token(Token = "0x403E204")]
		[FieldOffset(Offset = "0x44")]
		public float maxFillAmount;

		// Token: 0x0403E205 RID: 254469
		[Token(Token = "0x403E205")]
		[FieldOffset(Offset = "0x48")]
		public float normalFillAmount;

		// Token: 0x0403E206 RID: 254470
		[Token(Token = "0x403E206")]
		[FieldOffset(Offset = "0x4C")]
		public float increaseFillAmount;

		// Token: 0x0403E207 RID: 254471
		[Token(Token = "0x403E207")]
		[FieldOffset(Offset = "0x50")]
		public float decreaseFillAmount;

		// Token: 0x0403E208 RID: 254472
		[Token(Token = "0x403E208")]
		[FieldOffset(Offset = "0x54")]
		public float noChangeFillAmount;

		// Token: 0x0403E209 RID: 254473
		[Token(Token = "0x403E209")]
		[FieldOffset(Offset = "0x58")]
		public string absDeltaValueText;

		// Token: 0x0403E20A RID: 254474
		[Token(Token = "0x403E20A")]
		[FieldOffset(Offset = "0x60")]
		public UIItemViewModel uiItemViewModel;

		// Token: 0x0403E20B RID: 254475
		[Token(Token = "0x403E20B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x0403E20C RID: 254476
		[Token(Token = "0x403E20C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
