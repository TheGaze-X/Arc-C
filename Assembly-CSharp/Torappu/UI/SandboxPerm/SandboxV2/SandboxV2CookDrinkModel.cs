using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004078 RID: 16504
	[Token(Token = "0x2004078")]
	public class SandboxV2CookDrinkModel : IHotfixable
	{
		// Token: 0x17003CD0 RID: 15568
		// (get) Token: 0x0601986A RID: 104554 RVA: 0x0009E718 File Offset: 0x0009C918
		// (set) Token: 0x0601986B RID: 104555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CD0")]
		public int bottleRequiredCount
		{
			[Token(Token = "0x601986A")]
			[Address(RVA = "0x1238DA0", Offset = "0x12379A0", VA = "0x181238DA0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601986B")]
			[Address(RVA = "0x1239100", Offset = "0x1237D00", VA = "0x181239100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003CD1 RID: 15569
		// (get) Token: 0x0601986C RID: 104556 RVA: 0x0009E730 File Offset: 0x0009C930
		// (set) Token: 0x0601986D RID: 104557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CD1")]
		public int drinkBottleLimit
		{
			[Token(Token = "0x601986C")]
			[Address(RVA = "0x1238E60", Offset = "0x1237A60", VA = "0x181238E60")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601986D")]
			[Address(RVA = "0x12391E0", Offset = "0x1237DE0", VA = "0x1812391E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003CD2 RID: 15570
		// (get) Token: 0x0601986E RID: 104558 RVA: 0x0009E748 File Offset: 0x0009C948
		// (set) Token: 0x0601986F RID: 104559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CD2")]
		public int bottleStock
		{
			[Token(Token = "0x601986E")]
			[Address(RVA = "0x1238E00", Offset = "0x1237A00", VA = "0x181238E00")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601986F")]
			[Address(RVA = "0x1239170", Offset = "0x1237D70", VA = "0x181239170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003CD3 RID: 15571
		// (get) Token: 0x06019870 RID: 104560 RVA: 0x0009E760 File Offset: 0x0009C960
		// (set) Token: 0x06019871 RID: 104561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CD3")]
		public int inheritedDrinkCount
		{
			[Token(Token = "0x6019870")]
			[Address(RVA = "0x1238F80", Offset = "0x1237B80", VA = "0x181238F80")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6019871")]
			[Address(RVA = "0x1239250", Offset = "0x1237E50", VA = "0x181239250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003CD4 RID: 15572
		// (get) Token: 0x06019872 RID: 104562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003CD4")]
		public List<SandboxV2CookDrinkModel.SandboxV2CookDrinkItemModel> foodMatItems
		{
			[Token(Token = "0x6019872")]
			[Address(RVA = "0x1238F20", Offset = "0x1237B20", VA = "0x181238F20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003CD5 RID: 15573
		// (get) Token: 0x06019873 RID: 104563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003CD5")]
		public List<SandboxV2CookDrinkModel.SandboxV2CookDrinkItemModel> foodItems
		{
			[Token(Token = "0x6019873")]
			[Address(RVA = "0x1238EC0", Offset = "0x1237AC0", VA = "0x181238EC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003CD6 RID: 15574
		// (get) Token: 0x06019874 RID: 104564 RVA: 0x0009E778 File Offset: 0x0009C978
		// (set) Token: 0x06019875 RID: 104565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CD6")]
		public SandboxV2CookDrinkModel.SelectMode selectMode
		{
			[Token(Token = "0x6019874")]
			[Address(RVA = "0x1239040", Offset = "0x1237C40", VA = "0x181239040")]
			[CompilerGenerated]
			get
			{
				return SandboxV2CookDrinkModel.SelectMode.FOODMAT;
			}
			[Token(Token = "0x6019875")]
			[Address(RVA = "0x1239330", Offset = "0x1237F30", VA = "0x181239330")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003CD7 RID: 15575
		// (get) Token: 0x06019876 RID: 104566 RVA: 0x0009E790 File Offset: 0x0009C990
		// (set) Token: 0x06019877 RID: 104567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CD7")]
		public int selectedDrinkCount
		{
			[Token(Token = "0x6019876")]
			[Address(RVA = "0x12390A0", Offset = "0x1237CA0", VA = "0x1812390A0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6019877")]
			[Address(RVA = "0x12393A0", Offset = "0x1237FA0", VA = "0x1812393A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003CD8 RID: 15576
		// (get) Token: 0x06019878 RID: 104568 RVA: 0x0009E7A8 File Offset: 0x0009C9A8
		[Token(Token = "0x17003CD8")]
		public int bottleCount
		{
			[Token(Token = "0x6019878")]
			[Address(RVA = "0x1238C10", Offset = "0x1237810", VA = "0x181238C10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003CD9 RID: 15577
		// (get) Token: 0x06019879 RID: 104569 RVA: 0x0009E7C0 File Offset: 0x0009C9C0
		// (set) Token: 0x0601987A RID: 104570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CD9")]
		public bool initialRender
		{
			[Token(Token = "0x6019879")]
			[Address(RVA = "0x1238FE0", Offset = "0x1237BE0", VA = "0x181238FE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601987A")]
			[Address(RVA = "0x12392C0", Offset = "0x1237EC0", VA = "0x1812392C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601987B RID: 104571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601987B")]
		[Address(RVA = "0x1237950", Offset = "0x1236550", VA = "0x181237950")]
		public void LoadData(SandboxV2Data gameData, PlayerSandboxV2 playerData)
		{
		}

		// Token: 0x0601987C RID: 104572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601987C")]
		[Address(RVA = "0x12387D0", Offset = "0x12373D0", VA = "0x1812387D0")]
		public void SwitchSelectMode(SandboxV2CookDrinkModel.SelectMode mode)
		{
		}

		// Token: 0x0601987D RID: 104573 RVA: 0x0009E7D8 File Offset: 0x0009C9D8
		[Token(Token = "0x601987D")]
		[Address(RVA = "0x1238230", Offset = "0x1236E30", VA = "0x181238230")]
		public bool SelectItem(int index, int count)
		{
			return default(bool);
		}

		// Token: 0x0601987E RID: 104574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601987E")]
		[Address(RVA = "0x12375C0", Offset = "0x12361C0", VA = "0x1812375C0")]
		public void ClearSelected()
		{
		}

		// Token: 0x0601987F RID: 104575 RVA: 0x0009E7F0 File Offset: 0x0009C9F0
		[Token(Token = "0x601987F")]
		[Address(RVA = "0x1238480", Offset = "0x1237080", VA = "0x181238480")]
		public bool SelectMaterialsToFillOneBottle()
		{
			return default(bool);
		}

		// Token: 0x06019880 RID: 104576 RVA: 0x0009E808 File Offset: 0x0009CA08
		[Token(Token = "0x6019880")]
		[Address(RVA = "0x1238A30", Offset = "0x1237630", VA = "0x181238A30")]
		private static int _FoodmatComparision(SandboxV2CookDrinkModel.SandboxV2CookDrinkItemModel x, SandboxV2CookDrinkModel.SandboxV2CookDrinkItemModel y)
		{
			return 0;
		}

		// Token: 0x06019881 RID: 104577 RVA: 0x0009E820 File Offset: 0x0009CA20
		[Token(Token = "0x6019881")]
		[Address(RVA = "0x12388F0", Offset = "0x12374F0", VA = "0x1812388F0")]
		private static int _FoodComparision(SandboxV2CookDrinkModel.SandboxV2CookDrinkItemModel x, SandboxV2CookDrinkModel.SandboxV2CookDrinkItemModel y)
		{
			return 0;
		}

		// Token: 0x06019882 RID: 104578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019882")]
		[Address(RVA = "0x1238B20", Offset = "0x1237720", VA = "0x181238B20")]
		public SandboxV2CookDrinkModel()
		{
		}

		// Token: 0x0401FD28 RID: 130344
		[Token(Token = "0x401FD28")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<SandboxV2CookDrinkModel.SandboxV2CookDrinkItemModel> m_foodmatItems;

		// Token: 0x0401FD29 RID: 130345
		[Token(Token = "0x401FD29")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<SandboxV2CookDrinkModel.SandboxV2CookDrinkItemModel> m_foodItems;

		// Token: 0x0401FD31 RID: 130353
		[Token(Token = "0x401FD31")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bottleRequiredCount;

		// Token: 0x0401FD32 RID: 130354
		[Token(Token = "0x401FD32")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_bottleRequiredCount;

		// Token: 0x0401FD33 RID: 130355
		[Token(Token = "0x401FD33")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_drinkBottleLimit;

		// Token: 0x0401FD34 RID: 130356
		[Token(Token = "0x401FD34")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_drinkBottleLimit;

		// Token: 0x0401FD35 RID: 130357
		[Token(Token = "0x401FD35")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_bottleStock;

		// Token: 0x0401FD36 RID: 130358
		[Token(Token = "0x401FD36")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_bottleStock;

		// Token: 0x0401FD37 RID: 130359
		[Token(Token = "0x401FD37")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_inheritedDrinkCount;

		// Token: 0x0401FD38 RID: 130360
		[Token(Token = "0x401FD38")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_inheritedDrinkCount;

		// Token: 0x0401FD39 RID: 130361
		[Token(Token = "0x401FD39")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_foodMatItems;

		// Token: 0x0401FD3A RID: 130362
		[Token(Token = "0x401FD3A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_foodItems;

		// Token: 0x0401FD3B RID: 130363
		[Token(Token = "0x401FD3B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_selectMode;

		// Token: 0x0401FD3C RID: 130364
		[Token(Token = "0x401FD3C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_selectMode;

		// Token: 0x0401FD3D RID: 130365
		[Token(Token = "0x401FD3D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_selectedDrinkCount;

		// Token: 0x0401FD3E RID: 130366
		[Token(Token = "0x401FD3E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_selectedDrinkCount;

		// Token: 0x0401FD3F RID: 130367
		[Token(Token = "0x401FD3F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_bottleCount;

		// Token: 0x0401FD40 RID: 130368
		[Token(Token = "0x401FD40")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_initialRender;

		// Token: 0x0401FD41 RID: 130369
		[Token(Token = "0x401FD41")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_initialRender;

		// Token: 0x0401FD42 RID: 130370
		[Token(Token = "0x401FD42")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401FD43 RID: 130371
		[Token(Token = "0x401FD43")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_SwitchSelectMode;

		// Token: 0x0401FD44 RID: 130372
		[Token(Token = "0x401FD44")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_SelectItem;

		// Token: 0x0401FD45 RID: 130373
		[Token(Token = "0x401FD45")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_ClearSelected;

		// Token: 0x0401FD46 RID: 130374
		[Token(Token = "0x401FD46")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_SelectMaterialsToFillOneBottle;

		// Token: 0x0401FD47 RID: 130375
		[Token(Token = "0x401FD47")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__FoodmatComparision;

		// Token: 0x0401FD48 RID: 130376
		[Token(Token = "0x401FD48")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__FoodComparision;

		// Token: 0x0401FD49 RID: 130377
		[Token(Token = "0x401FD49")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004079 RID: 16505
		[Token(Token = "0x2004079")]
		public class SandboxV2CookDrinkItemModel
		{
			// Token: 0x06019883 RID: 104579 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019883")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SandboxV2CookDrinkItemModel()
			{
			}

			// Token: 0x0401FD4A RID: 130378
			[Token(Token = "0x401FD4A")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x0401FD4B RID: 130379
			[Token(Token = "0x401FD4B")]
			[FieldOffset(Offset = "0x18")]
			public UIItemViewModel itemModel;

			// Token: 0x0401FD4C RID: 130380
			[Token(Token = "0x401FD4C")]
			[FieldOffset(Offset = "0x20")]
			public int drinkCount;

			// Token: 0x0401FD4D RID: 130381
			[Token(Token = "0x401FD4D")]
			[FieldOffset(Offset = "0x24")]
			public SandboxV2FoodMatType matType;

			// Token: 0x0401FD4E RID: 130382
			[Token(Token = "0x401FD4E")]
			[FieldOffset(Offset = "0x28")]
			public string instId;

			// Token: 0x0401FD4F RID: 130383
			[Token(Token = "0x401FD4F")]
			[FieldOffset(Offset = "0x30")]
			public SandboxV2FoodVariantType variantType;
		}

		// Token: 0x0200407A RID: 16506
		[Token(Token = "0x200407A")]
		public enum SelectMode
		{
			// Token: 0x0401FD51 RID: 130385
			[Token(Token = "0x401FD51")]
			FOODMAT,
			// Token: 0x0401FD52 RID: 130386
			[Token(Token = "0x401FD52")]
			FOOD
		}
	}
}
