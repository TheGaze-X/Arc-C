using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B71 RID: 19313
	[Token(Token = "0x2004B71")]
	public class HomeSecretaryChangeCardGroupViewModel : IHotfixable
	{
		// Token: 0x17004459 RID: 17497
		// (get) Token: 0x0601D11A RID: 119066 RVA: 0x000AA3A0 File Offset: 0x000A85A0
		[Token(Token = "0x17004459")]
		public int displayChrInstId
		{
			[Token(Token = "0x601D11A")]
			[Address(RVA = "0x16A3A40", Offset = "0x16A2640", VA = "0x1816A3A40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700445A RID: 17498
		// (get) Token: 0x0601D11B RID: 119067 RVA: 0x000AA3B8 File Offset: 0x000A85B8
		[Token(Token = "0x1700445A")]
		public int defaultDisplayCharInstId
		{
			[Token(Token = "0x601D11B")]
			[Address(RVA = "0x16A3850", Offset = "0x16A2450", VA = "0x1816A3850")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601D11C RID: 119068 RVA: 0x000AA3D0 File Offset: 0x000A85D0
		[Token(Token = "0x601D11C")]
		[Address(RVA = "0x16A1F00", Offset = "0x16A0B00", VA = "0x1816A1F00")]
		public HomeSecretaryChangeSkinStateBean.InputParams GenerateChangeSkinParams()
		{
			return default(HomeSecretaryChangeSkinStateBean.InputParams);
		}

		// Token: 0x1700445B RID: 17499
		// (get) Token: 0x0601D11D RID: 119069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700445B")]
		public List<HomeSecretaryCardViewModel> cardListCache
		{
			[Token(Token = "0x601D11D")]
			[Address(RVA = "0x16A35E0", Offset = "0x16A21E0", VA = "0x1816A35E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700445C RID: 17500
		// (get) Token: 0x0601D11E RID: 119070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700445C")]
		public List<HomeSecretaryCardViewModel> cardList
		{
			[Token(Token = "0x601D11E")]
			[Address(RVA = "0x16A3640", Offset = "0x16A2240", VA = "0x1816A3640")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700445D RID: 17501
		// (get) Token: 0x0601D11F RID: 119071 RVA: 0x000AA3E8 File Offset: 0x000A85E8
		// (set) Token: 0x0601D120 RID: 119072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700445D")]
		public CharacterSortType sortType
		{
			[Token(Token = "0x601D11F")]
			[Address(RVA = "0x16A3B10", Offset = "0x16A2710", VA = "0x1816A3B10")]
			get
			{
				return CharacterSortType.BY_LEVEL_UP;
			}
			[Token(Token = "0x601D120")]
			[Address(RVA = "0x16A3C90", Offset = "0x16A2890", VA = "0x1816A3C90")]
			set
			{
			}
		}

		// Token: 0x1700445E RID: 17502
		// (get) Token: 0x0601D121 RID: 119073 RVA: 0x000AA400 File Offset: 0x000A8600
		// (set) Token: 0x0601D122 RID: 119074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700445E")]
		public bool isStarMarkTopSelected
		{
			[Token(Token = "0x601D121")]
			[Address(RVA = "0x16A3AB0", Offset = "0x16A26B0", VA = "0x1816A3AB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601D122")]
			[Address(RVA = "0x16A3C00", Offset = "0x16A2800", VA = "0x1816A3C00")]
			set
			{
			}
		}

		// Token: 0x1700445F RID: 17503
		// (get) Token: 0x0601D123 RID: 119075 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D124 RID: 119076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700445F")]
		public List<HomeSecretaryCardViewModel> dataSource
		{
			[Token(Token = "0x601D123")]
			[Address(RVA = "0x16A37F0", Offset = "0x16A23F0", VA = "0x1816A37F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x601D124")]
			[Address(RVA = "0x16A3B70", Offset = "0x16A2770", VA = "0x1816A3B70")]
			set
			{
			}
		}

		// Token: 0x0601D125 RID: 119077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D125")]
		[Address(RVA = "0x16A2970", Offset = "0x16A1570", VA = "0x1816A2970")]
		public void UpdateFilter(CharacterFilterViewModel filterViewModel)
		{
		}

		// Token: 0x0601D126 RID: 119078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D126")]
		[Address(RVA = "0x16A25E0", Offset = "0x16A11E0", VA = "0x1816A25E0")]
		public void UpdateCardCache(HomeSecretaryCardViewModel model)
		{
		}

		// Token: 0x0601D127 RID: 119079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D127")]
		[Address(RVA = "0x16A2460", Offset = "0x16A1060", VA = "0x1816A2460")]
		public void SelectChar(int charInstId)
		{
		}

		// Token: 0x0601D128 RID: 119080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D128")]
		[Address(RVA = "0x16A23A0", Offset = "0x16A0FA0", VA = "0x1816A23A0")]
		public void RemoveChar(int charInstId)
		{
		}

		// Token: 0x0601D129 RID: 119081 RVA: 0x000AA418 File Offset: 0x000A8618
		[Token(Token = "0x601D129")]
		[Address(RVA = "0x16A2310", Offset = "0x16A0F10", VA = "0x1816A2310")]
		public bool IsCharSelected(int charInstId)
		{
			return default(bool);
		}

		// Token: 0x0601D12A RID: 119082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D12A")]
		[Address(RVA = "0x16A2770", Offset = "0x16A1370", VA = "0x1816A2770")]
		public void UpdateDisplayCharInfo()
		{
		}

		// Token: 0x0601D12B RID: 119083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D12B")]
		[Address(RVA = "0x16A2CB0", Offset = "0x16A18B0", VA = "0x1816A2CB0")]
		private List<HomeSecretaryCardViewModel> _GetCharCardList()
		{
			return null;
		}

		// Token: 0x0601D12C RID: 119084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D12C")]
		[Address(RVA = "0x16A2EE0", Offset = "0x16A1AE0", VA = "0x1816A2EE0")]
		private void _ProcessSelectedCharTopMode(ref List<HomeSecretaryCardViewModel> dataList)
		{
		}

		// Token: 0x0601D12D RID: 119085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D12D")]
		[Address(RVA = "0x16A3170", Offset = "0x16A1D70", VA = "0x1816A3170")]
		private void _ProcessStarMarkCharTopMode(ref List<HomeSecretaryCardViewModel> dataList)
		{
		}

		// Token: 0x0601D12E RID: 119086 RVA: 0x000AA430 File Offset: 0x000A8630
		[Token(Token = "0x601D12E")]
		[Address(RVA = "0x16A2DF0", Offset = "0x16A19F0", VA = "0x1816A2DF0")]
		private bool _IsCardSelected(HomeSecretaryCardViewModel cardModel)
		{
			return default(bool);
		}

		// Token: 0x0601D12F RID: 119087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D12F")]
		[Address(RVA = "0x16A2A10", Offset = "0x16A1610", VA = "0x1816A2A10")]
		private List<HomeSecretaryCardViewModel> _AchieveSortedAndFilterCharacters(Func<HomeSecretaryCardViewModel, bool> filterWhiteList)
		{
			return null;
		}

		// Token: 0x0601D130 RID: 119088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D130")]
		[Address(RVA = "0x16A33C0", Offset = "0x16A1FC0", VA = "0x1816A33C0")]
		public HomeSecretaryChangeCardGroupViewModel()
		{
		}

		// Token: 0x0402624C RID: 156236
		[Token(Token = "0x402624C")]
		[FieldOffset(Offset = "0x10")]
		public CharacterFilterViewModel filter;

		// Token: 0x0402624D RID: 156237
		[Token(Token = "0x402624D")]
		[FieldOffset(Offset = "0x18")]
		public HashSet<int> starMarkSelectedChrInstIds;

		// Token: 0x0402624E RID: 156238
		[Token(Token = "0x402624E")]
		[FieldOffset(Offset = "0x20")]
		private int m_displayChrInstId;

		// Token: 0x0402624F RID: 156239
		[Token(Token = "0x402624F")]
		[FieldOffset(Offset = "0x28")]
		public CharUISkinStruct displaySkin;

		// Token: 0x04026250 RID: 156240
		[Token(Token = "0x4026250")]
		[FieldOffset(Offset = "0x40")]
		public string displayCharRealName;

		// Token: 0x04026251 RID: 156241
		[Token(Token = "0x4026251")]
		[FieldOffset(Offset = "0x48")]
		public string displayCharNickName;

		// Token: 0x04026252 RID: 156242
		[Token(Token = "0x4026252")]
		[FieldOffset(Offset = "0x50")]
		public int maxSelectCharNum;

		// Token: 0x04026253 RID: 156243
		[Token(Token = "0x4026253")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, List<string>> inPresetSkinDict;

		// Token: 0x04026254 RID: 156244
		[Token(Token = "0x4026254")]
		[FieldOffset(Offset = "0x60")]
		public string presetInstId;

		// Token: 0x04026255 RID: 156245
		[Token(Token = "0x4026255")]
		[FieldOffset(Offset = "0x68")]
		public HashSet<int> selectedCharInstIds;

		// Token: 0x04026256 RID: 156246
		[Token(Token = "0x4026256")]
		[FieldOffset(Offset = "0x70")]
		private List<int> m_playerSelectRecords;

		// Token: 0x04026257 RID: 156247
		[Token(Token = "0x4026257")]
		[FieldOffset(Offset = "0x78")]
		private List<HomeSecretaryCardViewModel> m_cardListCache;

		// Token: 0x04026258 RID: 156248
		[Token(Token = "0x4026258")]
		[FieldOffset(Offset = "0x80")]
		private CharacterSortType m_sortTypeCache;

		// Token: 0x04026259 RID: 156249
		[Token(Token = "0x4026259")]
		[FieldOffset(Offset = "0x84")]
		private bool m_isStarMarkTopSelected;

		// Token: 0x0402625A RID: 156250
		[Token(Token = "0x402625A")]
		[FieldOffset(Offset = "0x88")]
		private List<HomeSecretaryCardViewModel> m_secretaryCardViewModels;

		// Token: 0x0402625B RID: 156251
		[Token(Token = "0x402625B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_displayChrInstId;

		// Token: 0x0402625C RID: 156252
		[Token(Token = "0x402625C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_defaultDisplayCharInstId;

		// Token: 0x0402625D RID: 156253
		[Token(Token = "0x402625D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateChangeSkinParams;

		// Token: 0x0402625E RID: 156254
		[Token(Token = "0x402625E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_cardListCache;

		// Token: 0x0402625F RID: 156255
		[Token(Token = "0x402625F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_cardList;

		// Token: 0x04026260 RID: 156256
		[Token(Token = "0x4026260")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_sortType;

		// Token: 0x04026261 RID: 156257
		[Token(Token = "0x4026261")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_sortType;

		// Token: 0x04026262 RID: 156258
		[Token(Token = "0x4026262")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isStarMarkTopSelected;

		// Token: 0x04026263 RID: 156259
		[Token(Token = "0x4026263")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_isStarMarkTopSelected;

		// Token: 0x04026264 RID: 156260
		[Token(Token = "0x4026264")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_dataSource;

		// Token: 0x04026265 RID: 156261
		[Token(Token = "0x4026265")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_dataSource;

		// Token: 0x04026266 RID: 156262
		[Token(Token = "0x4026266")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateFilter;

		// Token: 0x04026267 RID: 156263
		[Token(Token = "0x4026267")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_UpdateCardCache;

		// Token: 0x04026268 RID: 156264
		[Token(Token = "0x4026268")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SelectChar;

		// Token: 0x04026269 RID: 156265
		[Token(Token = "0x4026269")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_RemoveChar;

		// Token: 0x0402626A RID: 156266
		[Token(Token = "0x402626A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_IsCharSelected;

		// Token: 0x0402626B RID: 156267
		[Token(Token = "0x402626B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_UpdateDisplayCharInfo;

		// Token: 0x0402626C RID: 156268
		[Token(Token = "0x402626C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GetCharCardList;

		// Token: 0x0402626D RID: 156269
		[Token(Token = "0x402626D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ProcessSelectedCharTopMode;

		// Token: 0x0402626E RID: 156270
		[Token(Token = "0x402626E")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ProcessStarMarkCharTopMode;

		// Token: 0x0402626F RID: 156271
		[Token(Token = "0x402626F")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__IsCardSelected;

		// Token: 0x04026270 RID: 156272
		[Token(Token = "0x4026270")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__AchieveSortedAndFilterCharacters;

		// Token: 0x04026271 RID: 156273
		[Token(Token = "0x4026271")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
