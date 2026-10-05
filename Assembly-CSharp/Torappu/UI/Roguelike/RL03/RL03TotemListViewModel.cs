using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005872 RID: 22642
	[Token(Token = "0x2005872")]
	public class RL03TotemListViewModel : IHotfixable
	{
		// Token: 0x17004D8E RID: 19854
		// (get) Token: 0x0602110A RID: 135434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D8E")]
		public List<bool> viewSelectStatusList
		{
			[Token(Token = "0x602110A")]
			[Address(RVA = "0x1B6D4F0", Offset = "0x1B6C0F0", VA = "0x181B6D4F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004D8F RID: 19855
		// (get) Token: 0x0602110B RID: 135435 RVA: 0x000B8650 File Offset: 0x000B6850
		[Token(Token = "0x17004D8F")]
		public int sequenceNum
		{
			[Token(Token = "0x602110B")]
			[Address(RVA = "0x1B6D490", Offset = "0x1B6C090", VA = "0x181B6D490")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004D90 RID: 19856
		// (get) Token: 0x0602110C RID: 135436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D90")]
		public Dictionary<string, RL03TotemListItemViewModel> locationInstItemDict
		{
			[Token(Token = "0x602110C")]
			[Address(RVA = "0x1B6D350", Offset = "0x1B6BF50", VA = "0x181B6D350")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004D91 RID: 19857
		// (get) Token: 0x0602110D RID: 135437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D91")]
		public RL03TotemViewModel selectedLocationTotemViewModel
		{
			[Token(Token = "0x602110D")]
			[Address(RVA = "0x1B6D420", Offset = "0x1B6C020", VA = "0x181B6D420")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004D92 RID: 19858
		// (get) Token: 0x0602110E RID: 135438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D92")]
		public RL03TotemViewModel selectedEffectTotemViewModel
		{
			[Token(Token = "0x602110E")]
			[Address(RVA = "0x1B6D3B0", Offset = "0x1B6BFB0", VA = "0x181B6D3B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602110F RID: 135439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602110F")]
		[Address(RVA = "0x1B6BB00", Offset = "0x1B6A700", VA = "0x181B6BB00")]
		public void LoadData(string topicId, int sequenceNum)
		{
		}

		// Token: 0x06021110 RID: 135440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021110")]
		[Address(RVA = "0x1B6BE10", Offset = "0x1B6AA10", VA = "0x181B6BE10")]
		public void UpdateTotemDisplayTypeWithMapStatus(List<string> cantUseInMapLocationTotemList)
		{
		}

		// Token: 0x06021111 RID: 135441 RVA: 0x000B8668 File Offset: 0x000B6868
		[Token(Token = "0x6021111")]
		[Address(RVA = "0x1B6B9C0", Offset = "0x1B6A5C0", VA = "0x181B6B9C0")]
		public TotemItemDisplayType GetTotemItemDisplayType(string totemId, string instId)
		{
			return TotemItemDisplayType.NONE;
		}

		// Token: 0x06021112 RID: 135442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021112")]
		[Address(RVA = "0x1B6BC20", Offset = "0x1B6A820", VA = "0x181B6BC20")]
		public void SelectTotemItem(string totemId, string instId)
		{
		}

		// Token: 0x06021113 RID: 135443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021113")]
		[Address(RVA = "0x1B6C6E0", Offset = "0x1B6B2E0", VA = "0x181B6C6E0")]
		private void _GeneViewModels(PlayerRoguelikeV2.CurrentData.Module.Totem playerTotem)
		{
		}

		// Token: 0x06021114 RID: 135444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021114")]
		[Address(RVA = "0x1B6C320", Offset = "0x1B6AF20", VA = "0x181B6C320")]
		private void _AddBlockItemViewModels(RoguelikeTotemPosType posType, RL03TotemListItemViewModel divinationItemViewModel, List<RL03TotemListItemViewModel> itemViewModels, ref List<IRL03TotemListViewModel> wholeViewModels)
		{
		}

		// Token: 0x06021115 RID: 135445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021115")]
		[Address(RVA = "0x1B6CB60", Offset = "0x1B6B760", VA = "0x181B6CB60")]
		private void _UpdateViewModelsAfterSelectChanged()
		{
		}

		// Token: 0x06021116 RID: 135446 RVA: 0x000B8680 File Offset: 0x000B6880
		[Token(Token = "0x6021116")]
		[Address(RVA = "0x1B6C600", Offset = "0x1B6B200", VA = "0x181B6C600")]
		private bool _CheckIfTotemResonance(RL03TotemListItemViewModel locationViewModel, RL03TotemListItemViewModel effectViewModel)
		{
			return default(bool);
		}

		// Token: 0x06021117 RID: 135447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021117")]
		[Address(RVA = "0x1B6D190", Offset = "0x1B6BD90", VA = "0x181B6D190")]
		public RL03TotemListViewModel()
		{
		}

		// Token: 0x0402D015 RID: 184341
		[Token(Token = "0x402D015")]
		[FieldOffset(Offset = "0x10")]
		private string m_topicId;

		// Token: 0x0402D016 RID: 184342
		[Token(Token = "0x402D016")]
		[FieldOffset(Offset = "0x18")]
		public List<IRL03TotemListViewModel> wholeItemViewModels;

		// Token: 0x0402D017 RID: 184343
		[Token(Token = "0x402D017")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, RL03TotemListItemViewModel> m_locationInstItemDict;

		// Token: 0x0402D018 RID: 184344
		[Token(Token = "0x402D018")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, RL03TotemListItemViewModel> m_effectInstItemDict;

		// Token: 0x0402D019 RID: 184345
		[Token(Token = "0x402D019")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, TotemItemDisplayType> m_locationNormalDisplayTypeDict;

		// Token: 0x0402D01A RID: 184346
		[Token(Token = "0x402D01A")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, TotemItemDisplayType> m_effectNormalDisplayTypeDict;

		// Token: 0x0402D01B RID: 184347
		[Token(Token = "0x402D01B")]
		[FieldOffset(Offset = "0x40")]
		private RL03TotemListItemViewModel m_locationBossViewModel;

		// Token: 0x0402D01C RID: 184348
		[Token(Token = "0x402D01C")]
		[FieldOffset(Offset = "0x48")]
		private RL03TotemListItemViewModel m_effectBossViewModel;

		// Token: 0x0402D01D RID: 184349
		[Token(Token = "0x402D01D")]
		[FieldOffset(Offset = "0x50")]
		private RL03TotemListItemViewModel m_selectedLocationViewModel;

		// Token: 0x0402D01E RID: 184350
		[Token(Token = "0x402D01E")]
		[FieldOffset(Offset = "0x58")]
		private RL03TotemListItemViewModel m_selectedEffectViewModel;

		// Token: 0x0402D01F RID: 184351
		[Token(Token = "0x402D01F")]
		[FieldOffset(Offset = "0x60")]
		private int m_sequenceNum;

		// Token: 0x0402D020 RID: 184352
		[Token(Token = "0x402D020")]
		[FieldOffset(Offset = "0x68")]
		private List<bool> m_viewSelectStatusList;

		// Token: 0x0402D021 RID: 184353
		[Token(Token = "0x402D021")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewSelectStatusList;

		// Token: 0x0402D022 RID: 184354
		[Token(Token = "0x402D022")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_sequenceNum;

		// Token: 0x0402D023 RID: 184355
		[Token(Token = "0x402D023")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_locationInstItemDict;

		// Token: 0x0402D024 RID: 184356
		[Token(Token = "0x402D024")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectedLocationTotemViewModel;

		// Token: 0x0402D025 RID: 184357
		[Token(Token = "0x402D025")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_selectedEffectTotemViewModel;

		// Token: 0x0402D026 RID: 184358
		[Token(Token = "0x402D026")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402D027 RID: 184359
		[Token(Token = "0x402D027")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateTotemDisplayTypeWithMapStatus;

		// Token: 0x0402D028 RID: 184360
		[Token(Token = "0x402D028")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetTotemItemDisplayType;

		// Token: 0x0402D029 RID: 184361
		[Token(Token = "0x402D029")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SelectTotemItem;

		// Token: 0x0402D02A RID: 184362
		[Token(Token = "0x402D02A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GeneViewModels;

		// Token: 0x0402D02B RID: 184363
		[Token(Token = "0x402D02B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__AddBlockItemViewModels;

		// Token: 0x0402D02C RID: 184364
		[Token(Token = "0x402D02C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateViewModelsAfterSelectChanged;

		// Token: 0x0402D02D RID: 184365
		[Token(Token = "0x402D02D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CheckIfTotemResonance;

		// Token: 0x0402D02E RID: 184366
		[Token(Token = "0x402D02E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
