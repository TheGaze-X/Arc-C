using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055B4 RID: 21940
	[Token(Token = "0x20055B4")]
	public class RL05CopperPackageViewModel : IHotfixable
	{
		// Token: 0x17004B84 RID: 19332
		// (get) Token: 0x06020363 RID: 131939 RVA: 0x000B4EB8 File Offset: 0x000B30B8
		// (set) Token: 0x06020364 RID: 131940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B84")]
		public RL05CopperPackageType verType
		{
			[Token(Token = "0x6020363")]
			[Address(RVA = "0x1A4F2A0", Offset = "0x1A4DEA0", VA = "0x181A4F2A0")]
			[CompilerGenerated]
			get
			{
				return RL05CopperPackageType.INIT;
			}
			[Token(Token = "0x6020364")]
			[Address(RVA = "0x1A4F550", Offset = "0x1A4E150", VA = "0x181A4F550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004B85 RID: 19333
		// (get) Token: 0x06020365 RID: 131941 RVA: 0x000B4ED0 File Offset: 0x000B30D0
		// (set) Token: 0x06020366 RID: 131942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B85")]
		public int refreshCost
		{
			[Token(Token = "0x6020365")]
			[Address(RVA = "0x1A4F240", Offset = "0x1A4DE40", VA = "0x181A4F240")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6020366")]
			[Address(RVA = "0x1A4F4E0", Offset = "0x1A4E0E0", VA = "0x181A4F4E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004B86 RID: 19334
		// (get) Token: 0x06020367 RID: 131943 RVA: 0x000B4EE8 File Offset: 0x000B30E8
		// (set) Token: 0x06020368 RID: 131944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B86")]
		public bool canFreeze
		{
			[Token(Token = "0x6020367")]
			[Address(RVA = "0x1A4F0C0", Offset = "0x1A4DCC0", VA = "0x181A4F0C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6020368")]
			[Address(RVA = "0x1A4F300", Offset = "0x1A4DF00", VA = "0x181A4F300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004B87 RID: 19335
		// (get) Token: 0x06020369 RID: 131945 RVA: 0x000B4F00 File Offset: 0x000B3100
		// (set) Token: 0x0602036A RID: 131946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B87")]
		public int itemCount
		{
			[Token(Token = "0x6020369")]
			[Address(RVA = "0x1A4F180", Offset = "0x1A4DD80", VA = "0x181A4F180")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602036A")]
			[Address(RVA = "0x1A4F3F0", Offset = "0x1A4DFF0", VA = "0x181A4F3F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004B88 RID: 19336
		// (get) Token: 0x0602036B RID: 131947 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602036C RID: 131948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B88")]
		public string itemid
		{
			[Token(Token = "0x602036B")]
			[Address(RVA = "0x1A4F1E0", Offset = "0x1A4DDE0", VA = "0x181A4F1E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602036C")]
			[Address(RVA = "0x1A4F460", Offset = "0x1A4E060", VA = "0x181A4F460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004B89 RID: 19337
		// (get) Token: 0x0602036D RID: 131949 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602036E RID: 131950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B89")]
		public List<RoguelikePlayerCopperItemViewModel> copperList
		{
			[Token(Token = "0x602036D")]
			[Address(RVA = "0x1A4F120", Offset = "0x1A4DD20", VA = "0x181A4F120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602036E")]
			[Address(RVA = "0x1A4F370", Offset = "0x1A4DF70", VA = "0x181A4F370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602036F RID: 131951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602036F")]
		[Address(RVA = "0x1A4E880", Offset = "0x1A4D480", VA = "0x181A4E880")]
		public void LoadData(RL05CopperPackageDialog.Options options)
		{
		}

		// Token: 0x06020370 RID: 131952 RVA: 0x000B4F18 File Offset: 0x000B3118
		[Token(Token = "0x6020370")]
		[Address(RVA = "0x1A4EF10", Offset = "0x1A4DB10", VA = "0x181A4EF10")]
		public bool SelectCopper(string instId)
		{
			return default(bool);
		}

		// Token: 0x06020371 RID: 131953 RVA: 0x000B4F30 File Offset: 0x000B3130
		[Token(Token = "0x6020371")]
		[Address(RVA = "0x1A4EFD0", Offset = "0x1A4DBD0", VA = "0x181A4EFD0")]
		public RL05CopperPackageSelectInfo TakeSelectInfo()
		{
			return default(RL05CopperPackageSelectInfo);
		}

		// Token: 0x06020372 RID: 131954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020372")]
		[Address(RVA = "0x1A4E6F0", Offset = "0x1A4D2F0", VA = "0x181A4E6F0")]
		public RoguelikePlayerCopperItemViewModel GetSelectedCopper()
		{
			return null;
		}

		// Token: 0x06020373 RID: 131955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020373")]
		[Address(RVA = "0x1A4F060", Offset = "0x1A4DC60", VA = "0x181A4F060")]
		public RL05CopperPackageViewModel()
		{
		}

		// Token: 0x0402B919 RID: 178457
		[Token(Token = "0x402B919")]
		[FieldOffset(Offset = "0x30")]
		private RL05CopperPackageSelectInfo m_selectInfo;

		// Token: 0x0402B91A RID: 178458
		[Token(Token = "0x402B91A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_verType;

		// Token: 0x0402B91B RID: 178459
		[Token(Token = "0x402B91B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_verType;

		// Token: 0x0402B91C RID: 178460
		[Token(Token = "0x402B91C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_refreshCost;

		// Token: 0x0402B91D RID: 178461
		[Token(Token = "0x402B91D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_refreshCost;

		// Token: 0x0402B91E RID: 178462
		[Token(Token = "0x402B91E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_canFreeze;

		// Token: 0x0402B91F RID: 178463
		[Token(Token = "0x402B91F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_canFreeze;

		// Token: 0x0402B920 RID: 178464
		[Token(Token = "0x402B920")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_itemCount;

		// Token: 0x0402B921 RID: 178465
		[Token(Token = "0x402B921")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_itemCount;

		// Token: 0x0402B922 RID: 178466
		[Token(Token = "0x402B922")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_itemid;

		// Token: 0x0402B923 RID: 178467
		[Token(Token = "0x402B923")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_itemid;

		// Token: 0x0402B924 RID: 178468
		[Token(Token = "0x402B924")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_copperList;

		// Token: 0x0402B925 RID: 178469
		[Token(Token = "0x402B925")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_copperList;

		// Token: 0x0402B926 RID: 178470
		[Token(Token = "0x402B926")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402B927 RID: 178471
		[Token(Token = "0x402B927")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SelectCopper;

		// Token: 0x0402B928 RID: 178472
		[Token(Token = "0x402B928")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_TakeSelectInfo;

		// Token: 0x0402B929 RID: 178473
		[Token(Token = "0x402B929")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetSelectedCopper;

		// Token: 0x0402B92A RID: 178474
		[Token(Token = "0x402B92A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
