using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E4E RID: 24142
	[Token(Token = "0x2005E4E")]
	public class ItemRepoChooseCharEvolveStateBean : IStateBean, IHotfixable
	{
		// Token: 0x170052E7 RID: 21223
		// (get) Token: 0x06022F98 RID: 143256 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022F99 RID: 143257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052E7")]
		public UIItemViewModel itemViewModel
		{
			[Token(Token = "0x6022F98")]
			[Address(RVA = "0x1D805D0", Offset = "0x1D7F1D0", VA = "0x181D805D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6022F99")]
			[Address(RVA = "0x1D809B0", Offset = "0x1D7F5B0", VA = "0x181D809B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170052E8 RID: 21224
		// (get) Token: 0x06022F9A RID: 143258 RVA: 0x000BFA30 File Offset: 0x000BDC30
		// (set) Token: 0x06022F9B RID: 143259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052E8")]
		public RarityRank rarity
		{
			[Token(Token = "0x6022F9A")]
			[Address(RVA = "0x1D80630", Offset = "0x1D7F230", VA = "0x181D80630")]
			[CompilerGenerated]
			get
			{
				return RarityRank.TIER_1;
			}
			[Token(Token = "0x6022F9B")]
			[Address(RVA = "0x1D80A30", Offset = "0x1D7F630", VA = "0x181D80A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170052E9 RID: 21225
		// (get) Token: 0x06022F9C RID: 143260 RVA: 0x000BFA48 File Offset: 0x000BDC48
		// (set) Token: 0x06022F9D RID: 143261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052E9")]
		public bool clickable
		{
			[Token(Token = "0x6022F9C")]
			[Address(RVA = "0x1D80510", Offset = "0x1D7F110", VA = "0x181D80510")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6022F9D")]
			[Address(RVA = "0x1D808C0", Offset = "0x1D7F4C0", VA = "0x181D808C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170052EA RID: 21226
		// (get) Token: 0x06022F9E RID: 143262 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022F9F RID: 143263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052EA")]
		public string titleText
		{
			[Token(Token = "0x6022F9E")]
			[Address(RVA = "0x1D806F0", Offset = "0x1D7F2F0", VA = "0x181D806F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6022F9F")]
			[Address(RVA = "0x1D80B10", Offset = "0x1D7F710", VA = "0x181D80B10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170052EB RID: 21227
		// (get) Token: 0x06022FA0 RID: 143264 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022FA1 RID: 143265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052EB")]
		public string emptyText
		{
			[Token(Token = "0x6022FA0")]
			[Address(RVA = "0x1D80570", Offset = "0x1D7F170", VA = "0x181D80570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6022FA1")]
			[Address(RVA = "0x1D80930", Offset = "0x1D7F530", VA = "0x181D80930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170052EC RID: 21228
		// (get) Token: 0x06022FA2 RID: 143266 RVA: 0x000BFA60 File Offset: 0x000BDC60
		// (set) Token: 0x06022FA3 RID: 143267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052EC")]
		public CharCardType charCardType
		{
			[Token(Token = "0x6022FA2")]
			[Address(RVA = "0x1D803F0", Offset = "0x1D7EFF0", VA = "0x181D803F0")]
			[CompilerGenerated]
			get
			{
				return CharCardType.EVOLVE;
			}
			[Token(Token = "0x6022FA3")]
			[Address(RVA = "0x1D80750", Offset = "0x1D7F350", VA = "0x181D80750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170052ED RID: 21229
		// (get) Token: 0x06022FA4 RID: 143268 RVA: 0x000BFA78 File Offset: 0x000BDC78
		// (set) Token: 0x06022FA5 RID: 143269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052ED")]
		public int selectedCharInstId
		{
			[Token(Token = "0x6022FA4")]
			[Address(RVA = "0x1D80690", Offset = "0x1D7F290", VA = "0x181D80690")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6022FA5")]
			[Address(RVA = "0x1D80AA0", Offset = "0x1D7F6A0", VA = "0x181D80AA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170052EE RID: 21230
		// (get) Token: 0x06022FA6 RID: 143270 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022FA7 RID: 143271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052EE")]
		public ItemRepoChooseCharEvolveStateBean.CharacterSorter<CharacterCardViewModel> characterSorter
		{
			[Token(Token = "0x6022FA6")]
			[Address(RVA = "0x1D804B0", Offset = "0x1D7F0B0", VA = "0x181D804B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6022FA7")]
			[Address(RVA = "0x1D80840", Offset = "0x1D7F440", VA = "0x181D80840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170052EF RID: 21231
		// (get) Token: 0x06022FA8 RID: 143272 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022FA9 RID: 143273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052EF")]
		public ItemRepoChooseCharEvolveStateBean.CharacterFilter<CharacterCardViewModel> characterFilter
		{
			[Token(Token = "0x6022FA8")]
			[Address(RVA = "0x1D80450", Offset = "0x1D7F050", VA = "0x181D80450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6022FA9")]
			[Address(RVA = "0x1D807C0", Offset = "0x1D7F3C0", VA = "0x181D807C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06022FAA RID: 143274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FAA")]
		[Address(RVA = "0x1D7F4C0", Offset = "0x1D7E0C0", VA = "0x181D7F4C0")]
		public void GenerateInput(UIItemViewModel itemViewModel, bool clickable)
		{
		}

		// Token: 0x06022FAB RID: 143275 RVA: 0x000BFA90 File Offset: 0x000BDC90
		[Token(Token = "0x6022FAB")]
		[Address(RVA = "0x1D7FED0", Offset = "0x1D7EAD0", VA = "0x181D7FED0")]
		private bool _FilterEvolveChar(CharacterCardViewModel charInfo)
		{
			return default(bool);
		}

		// Token: 0x06022FAC RID: 143276 RVA: 0x000BFAA8 File Offset: 0x000BDCA8
		[Token(Token = "0x6022FAC")]
		[Address(RVA = "0x1D80020", Offset = "0x1D7EC20", VA = "0x181D80020")]
		private bool _FilterLevelMaxChar(CharacterCardViewModel charInfo)
		{
			return default(bool);
		}

		// Token: 0x06022FAD RID: 143277 RVA: 0x000BFAC0 File Offset: 0x000BDCC0
		[Token(Token = "0x6022FAD")]
		[Address(RVA = "0x1D801A0", Offset = "0x1D7EDA0", VA = "0x181D801A0")]
		private bool _FilterSkillMaxChar(CharacterCardViewModel charInfo)
		{
			return default(bool);
		}

		// Token: 0x06022FAE RID: 143278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FAE")]
		[Address(RVA = "0x1D80390", Offset = "0x1D7EF90", VA = "0x181D80390")]
		public ItemRepoChooseCharEvolveStateBean()
		{
		}

		// Token: 0x040302F4 RID: 197364
		[Token(Token = "0x40302F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemViewModel;

		// Token: 0x040302F5 RID: 197365
		[Token(Token = "0x40302F5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_itemViewModel;

		// Token: 0x040302F6 RID: 197366
		[Token(Token = "0x40302F6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_rarity;

		// Token: 0x040302F7 RID: 197367
		[Token(Token = "0x40302F7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_rarity;

		// Token: 0x040302F8 RID: 197368
		[Token(Token = "0x40302F8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_clickable;

		// Token: 0x040302F9 RID: 197369
		[Token(Token = "0x40302F9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_clickable;

		// Token: 0x040302FA RID: 197370
		[Token(Token = "0x40302FA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_titleText;

		// Token: 0x040302FB RID: 197371
		[Token(Token = "0x40302FB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_titleText;

		// Token: 0x040302FC RID: 197372
		[Token(Token = "0x40302FC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_emptyText;

		// Token: 0x040302FD RID: 197373
		[Token(Token = "0x40302FD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_emptyText;

		// Token: 0x040302FE RID: 197374
		[Token(Token = "0x40302FE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_charCardType;

		// Token: 0x040302FF RID: 197375
		[Token(Token = "0x40302FF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_charCardType;

		// Token: 0x04030300 RID: 197376
		[Token(Token = "0x4030300")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_selectedCharInstId;

		// Token: 0x04030301 RID: 197377
		[Token(Token = "0x4030301")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_selectedCharInstId;

		// Token: 0x04030302 RID: 197378
		[Token(Token = "0x4030302")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_characterSorter;

		// Token: 0x04030303 RID: 197379
		[Token(Token = "0x4030303")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_characterSorter;

		// Token: 0x04030304 RID: 197380
		[Token(Token = "0x4030304")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_characterFilter;

		// Token: 0x04030305 RID: 197381
		[Token(Token = "0x4030305")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_characterFilter;

		// Token: 0x04030306 RID: 197382
		[Token(Token = "0x4030306")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GenerateInput;

		// Token: 0x04030307 RID: 197383
		[Token(Token = "0x4030307")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__FilterEvolveChar;

		// Token: 0x04030308 RID: 197384
		[Token(Token = "0x4030308")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__FilterLevelMaxChar;

		// Token: 0x04030309 RID: 197385
		[Token(Token = "0x4030309")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__FilterSkillMaxChar;

		// Token: 0x0403030A RID: 197386
		[Token(Token = "0x403030A")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005E4F RID: 24143
		// (Invoke) Token: 0x06022FB0 RID: 143280
		[Token(Token = "0x2005E4F")]
		public delegate void CharacterSorter<T>(List<T> charList) where T : IBasicCharInfo;

		// Token: 0x02005E50 RID: 24144
		// (Invoke) Token: 0x06022FB4 RID: 143284
		[Token(Token = "0x2005E50")]
		public delegate bool CharacterFilter<T>(T charInfo) where T : IBasicCharInfo;
	}
}
