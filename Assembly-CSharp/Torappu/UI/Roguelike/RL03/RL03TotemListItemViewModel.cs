using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005876 RID: 22646
	[Token(Token = "0x2005876")]
	public class RL03TotemListItemViewModel : IRL03TotemListViewModel, IHotfixable
	{
		// Token: 0x17004D93 RID: 19859
		// (get) Token: 0x0602111A RID: 135450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D93")]
		public string instId
		{
			[Token(Token = "0x602111A")]
			[Address(RVA = "0x1B6A8B0", Offset = "0x1B694B0", VA = "0x181B6A8B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004D94 RID: 19860
		// (get) Token: 0x0602111B RID: 135451 RVA: 0x000B8698 File Offset: 0x000B6898
		[Token(Token = "0x17004D94")]
		public bool isEmpty
		{
			[Token(Token = "0x602111B")]
			[Address(RVA = "0x1B6AA30", Offset = "0x1B69630", VA = "0x181B6AA30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004D95 RID: 19861
		// (get) Token: 0x0602111C RID: 135452 RVA: 0x000B86B0 File Offset: 0x000B68B0
		[Token(Token = "0x17004D95")]
		public bool canUseTotem
		{
			[Token(Token = "0x602111C")]
			[Address(RVA = "0x1B6A850", Offset = "0x1B69450", VA = "0x181B6A850")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004D96 RID: 19862
		// (get) Token: 0x0602111D RID: 135453 RVA: 0x000B86C8 File Offset: 0x000B68C8
		[Token(Token = "0x17004D96")]
		public bool isDivination
		{
			[Token(Token = "0x602111D")]
			[Address(RVA = "0x1B6A9D0", Offset = "0x1B695D0", VA = "0x181B6A9D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004D97 RID: 19863
		// (get) Token: 0x0602111E RID: 135454 RVA: 0x000B86E0 File Offset: 0x000B68E0
		[Token(Token = "0x17004D97")]
		public bool isBossTotem
		{
			[Token(Token = "0x602111E")]
			[Address(RVA = "0x1B6A940", Offset = "0x1B69540", VA = "0x181B6A940")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602111F RID: 135455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602111F")]
		[Address(RVA = "0x1B6A5E0", Offset = "0x1B691E0", VA = "0x181B6A5E0")]
		public string GetTotemFullDesc()
		{
			return null;
		}

		// Token: 0x06021120 RID: 135456 RVA: 0x000B86F8 File Offset: 0x000B68F8
		[Token(Token = "0x6021120")]
		[Address(RVA = "0x1B6A4B0", Offset = "0x1B690B0", VA = "0x181B6A4B0")]
		public bool CheckIsSameTotem(RL03TotemListItemViewModel itemViewModel)
		{
			return default(bool);
		}

		// Token: 0x06021121 RID: 135457 RVA: 0x000B8710 File Offset: 0x000B6910
		[Token(Token = "0x6021121")]
		[Address(RVA = "0x1B6A790", Offset = "0x1B69390", VA = "0x181B6A790", Slot = "4")]
		public RL03TotemListViewType GetViewType()
		{
			return RL03TotemListViewType.NORMAL_ITEM;
		}

		// Token: 0x06021122 RID: 135458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021122")]
		[Address(RVA = "0x1B6A7F0", Offset = "0x1B693F0", VA = "0x181B6A7F0")]
		public RL03TotemListItemViewModel()
		{
		}

		// Token: 0x0402D032 RID: 184370
		[Token(Token = "0x402D032")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x0402D033 RID: 184371
		[Token(Token = "0x402D033")]
		[FieldOffset(Offset = "0x18")]
		public string totemId;

		// Token: 0x0402D034 RID: 184372
		[Token(Token = "0x402D034")]
		[FieldOffset(Offset = "0x20")]
		public RL03TotemViewModel totemViewModel;

		// Token: 0x0402D035 RID: 184373
		[Token(Token = "0x402D035")]
		[FieldOffset(Offset = "0x28")]
		public TotemItemDisplayType displayType;

		// Token: 0x0402D036 RID: 184374
		[Token(Token = "0x402D036")]
		[FieldOffset(Offset = "0x2C")]
		public bool isSelected;

		// Token: 0x0402D037 RID: 184375
		[Token(Token = "0x402D037")]
		[FieldOffset(Offset = "0x2D")]
		public bool needHighLight;

		// Token: 0x0402D038 RID: 184376
		[Token(Token = "0x402D038")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_instId;

		// Token: 0x0402D039 RID: 184377
		[Token(Token = "0x402D039")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x0402D03A RID: 184378
		[Token(Token = "0x402D03A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_canUseTotem;

		// Token: 0x0402D03B RID: 184379
		[Token(Token = "0x402D03B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isDivination;

		// Token: 0x0402D03C RID: 184380
		[Token(Token = "0x402D03C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isBossTotem;

		// Token: 0x0402D03D RID: 184381
		[Token(Token = "0x402D03D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetTotemFullDesc;

		// Token: 0x0402D03E RID: 184382
		[Token(Token = "0x402D03E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckIsSameTotem;

		// Token: 0x0402D03F RID: 184383
		[Token(Token = "0x402D03F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0402D040 RID: 184384
		[Token(Token = "0x402D040")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
