using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CommonFriendAssist
{
	// Token: 0x02005BC9 RID: 23497
	[Token(Token = "0x2005BC9")]
	public class CommonFriendAssistViewModel : IHotfixable
	{
		// Token: 0x17004FBC RID: 20412
		// (get) Token: 0x0602212E RID: 139566 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602212F RID: 139567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004FBC")]
		public string tips
		{
			[Token(Token = "0x602212E")]
			[Address(RVA = "0x1C8E920", Offset = "0x1C8D520", VA = "0x181C8E920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602212F")]
			[Address(RVA = "0x1C8EAF0", Offset = "0x1C8D6F0", VA = "0x181C8EAF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004FBD RID: 20413
		// (get) Token: 0x06022130 RID: 139568 RVA: 0x000BC490 File Offset: 0x000BA690
		// (set) Token: 0x06022131 RID: 139569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004FBD")]
		public ProfessionCategory profFilter
		{
			[Token(Token = "0x6022130")]
			[Address(RVA = "0x1C8E860", Offset = "0x1C8D460", VA = "0x181C8E860")]
			[CompilerGenerated]
			get
			{
				return ProfessionCategory.NONE;
			}
			[Token(Token = "0x6022131")]
			[Address(RVA = "0x1C8EA00", Offset = "0x1C8D600", VA = "0x181C8EA00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004FBE RID: 20414
		// (get) Token: 0x06022132 RID: 139570 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022133 RID: 139571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004FBE")]
		public List<CommonFriendAssistViewModel.ProfTabModel> profTabList
		{
			[Token(Token = "0x6022132")]
			[Address(RVA = "0x1C8E8C0", Offset = "0x1C8D4C0", VA = "0x181C8E8C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6022133")]
			[Address(RVA = "0x1C8EA70", Offset = "0x1C8D670", VA = "0x181C8EA70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004FBF RID: 20415
		// (get) Token: 0x06022134 RID: 139572 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022135 RID: 139573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004FBF")]
		public List<CommonFriendAssistViewModel.FriendItemModel> friendAssistList
		{
			[Token(Token = "0x6022134")]
			[Address(RVA = "0x1C8E800", Offset = "0x1C8D400", VA = "0x181C8E800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6022135")]
			[Address(RVA = "0x1C8E980", Offset = "0x1C8D580", VA = "0x181C8E980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06022136 RID: 139574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022136")]
		[Address(RVA = "0x1C8DB20", Offset = "0x1C8C720", VA = "0x181C8DB20")]
		public void Init(ICommonFriendAssistPlugin plugin)
		{
		}

		// Token: 0x06022137 RID: 139575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022137")]
		[Address(RVA = "0x1C8E200", Offset = "0x1C8CE00", VA = "0x181C8E200")]
		public void Update(CommonFriendAssistData data)
		{
		}

		// Token: 0x06022138 RID: 139576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022138")]
		[Address(RVA = "0x1C8D9F0", Offset = "0x1C8C5F0", VA = "0x181C8D9F0")]
		public void Clear()
		{
		}

		// Token: 0x06022139 RID: 139577 RVA: 0x000BC4A8 File Offset: 0x000BA6A8
		[Token(Token = "0x6022139")]
		[Address(RVA = "0x1C8DF70", Offset = "0x1C8CB70", VA = "0x181C8DF70")]
		public bool SetProfFilter(ProfessionCategory profFilter)
		{
			return default(bool);
		}

		// Token: 0x0602213A RID: 139578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602213A")]
		[Address(RVA = "0x1C8E150", Offset = "0x1C8CD50", VA = "0x181C8E150")]
		public void SetStarFriendTabSelected(bool isSelected)
		{
		}

		// Token: 0x0602213B RID: 139579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602213B")]
		[Address(RVA = "0x1C8E2A0", Offset = "0x1C8CEA0", VA = "0x181C8E2A0")]
		private void _AddSquadSlotWithoutDup(List<CommonFriendAssistViewModel.FriendItemModel> retList, List<SquadAssistData> dataSource, int maxLength)
		{
		}

		// Token: 0x0602213C RID: 139580 RVA: 0x000BC4C0 File Offset: 0x000BA6C0
		[Token(Token = "0x602213C")]
		[Address(RVA = "0x1C8E480", Offset = "0x1C8D080", VA = "0x181C8E480")]
		private bool _IsSameAssistData(SquadAssistData a, SquadAssistData b)
		{
			return default(bool);
		}

		// Token: 0x0602213D RID: 139581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602213D")]
		[Address(RVA = "0x1C8E540", Offset = "0x1C8D140", VA = "0x181C8E540")]
		private void _RefreshAssistList()
		{
		}

		// Token: 0x0602213E RID: 139582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602213E")]
		[Address(RVA = "0x1C8E7A0", Offset = "0x1C8D3A0", VA = "0x181C8E7A0")]
		public CommonFriendAssistViewModel()
		{
		}

		// Token: 0x0402EBD6 RID: 191446
		[Token(Token = "0x402EBD6")]
		[FieldOffset(Offset = "0x10")]
		private int m_assistSlotMaxCount;

		// Token: 0x0402EBD7 RID: 191447
		[Token(Token = "0x402EBD7")]
		[FieldOffset(Offset = "0x18")]
		private CommonFriendAssistData m_cacheAssistData;

		// Token: 0x0402EBD8 RID: 191448
		[Token(Token = "0x402EBD8")]
		[FieldOffset(Offset = "0x20")]
		public bool starFriendTabSelected;

		// Token: 0x0402EBDD RID: 191453
		[Token(Token = "0x402EBDD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_tips;

		// Token: 0x0402EBDE RID: 191454
		[Token(Token = "0x402EBDE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_tips;

		// Token: 0x0402EBDF RID: 191455
		[Token(Token = "0x402EBDF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_profFilter;

		// Token: 0x0402EBE0 RID: 191456
		[Token(Token = "0x402EBE0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_profFilter;

		// Token: 0x0402EBE1 RID: 191457
		[Token(Token = "0x402EBE1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_profTabList;

		// Token: 0x0402EBE2 RID: 191458
		[Token(Token = "0x402EBE2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_profTabList;

		// Token: 0x0402EBE3 RID: 191459
		[Token(Token = "0x402EBE3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_friendAssistList;

		// Token: 0x0402EBE4 RID: 191460
		[Token(Token = "0x402EBE4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_friendAssistList;

		// Token: 0x0402EBE5 RID: 191461
		[Token(Token = "0x402EBE5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402EBE6 RID: 191462
		[Token(Token = "0x402EBE6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0402EBE7 RID: 191463
		[Token(Token = "0x402EBE7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x0402EBE8 RID: 191464
		[Token(Token = "0x402EBE8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SetProfFilter;

		// Token: 0x0402EBE9 RID: 191465
		[Token(Token = "0x402EBE9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SetStarFriendTabSelected;

		// Token: 0x0402EBEA RID: 191466
		[Token(Token = "0x402EBEA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__AddSquadSlotWithoutDup;

		// Token: 0x0402EBEB RID: 191467
		[Token(Token = "0x402EBEB")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__IsSameAssistData;

		// Token: 0x0402EBEC RID: 191468
		[Token(Token = "0x402EBEC")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RefreshAssistList;

		// Token: 0x0402EBED RID: 191469
		[Token(Token = "0x402EBED")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005BCA RID: 23498
		[Token(Token = "0x2005BCA")]
		public class ProfTabModel
		{
			// Token: 0x0602213F RID: 139583 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602213F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ProfTabModel()
			{
			}

			// Token: 0x0402EBEE RID: 191470
			[Token(Token = "0x402EBEE")]
			[FieldOffset(Offset = "0x10")]
			public ProfessionCategory professionCategory;

			// Token: 0x0402EBEF RID: 191471
			[Token(Token = "0x402EBEF")]
			[FieldOffset(Offset = "0x14")]
			public bool isSelected;

			// Token: 0x0402EBF0 RID: 191472
			[Token(Token = "0x402EBF0")]
			[FieldOffset(Offset = "0x15")]
			public bool enableClick;
		}

		// Token: 0x02005BCB RID: 23499
		[Token(Token = "0x2005BCB")]
		public class FriendItemModel
		{
			// Token: 0x06022140 RID: 139584 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022140")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FriendItemModel()
			{
			}

			// Token: 0x0402EBF1 RID: 191473
			[Token(Token = "0x402EBF1")]
			[FieldOffset(Offset = "0x10")]
			public SquadAssistData assistData;
		}
	}
}
