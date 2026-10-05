using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003560 RID: 13664
	[Token(Token = "0x2003560")]
	public class CommonCharCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170033BD RID: 13245
		// (get) Token: 0x06015C57 RID: 89175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170033BD")]
		public UIColorGraphic colorGraphic
		{
			[Token(Token = "0x6015C57")]
			[Address(RVA = "0xE46050", Offset = "0xE44C50", VA = "0x180E46050")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015C58 RID: 89176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C58")]
		[Address(RVA = "0xE44E70", Offset = "0xE43A70", VA = "0x180E44E70")]
		private void _InitScalerIfNot()
		{
		}

		// Token: 0x06015C59 RID: 89177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C59")]
		[Address(RVA = "0xE44B90", Offset = "0xE43790", VA = "0x180E44B90")]
		public void SetScaler(float newScaler)
		{
		}

		// Token: 0x06015C5A RID: 89178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C5A")]
		[Address(RVA = "0xE449D0", Offset = "0xE435D0", VA = "0x180E449D0")]
		public void SetPlugin(CommonCharCardView.CharCardCompType charCardCompType, CommonCharCardView.ICommonCharCardPlugin customPlugin)
		{
		}

		// Token: 0x06015C5B RID: 89179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C5B")]
		[Address(RVA = "0xE44770", Offset = "0xE43370", VA = "0x180E44770")]
		public void RenderCard(ICharacterCardViewModel cardViewModel)
		{
		}

		// Token: 0x06015C5C RID: 89180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C5C")]
		[Address(RVA = "0xE44930", Offset = "0xE43530", VA = "0x180E44930")]
		public void ResetCard()
		{
		}

		// Token: 0x06015C5D RID: 89181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015C5D")]
		[Address(RVA = "0xE44D60", Offset = "0xE43960", VA = "0x180E44D60")]
		private CommonCharCardView.ICommonCharCardPlugin _GetAvailPlugin(CommonCharCardView.CharCardCompType compType)
		{
			return null;
		}

		// Token: 0x06015C5E RID: 89182 RVA: 0x0008DBB8 File Offset: 0x0008BDB8
		[Token(Token = "0x6015C5E")]
		[Address(RVA = "0xE451D0", Offset = "0xE43DD0", VA = "0x180E451D0")]
		private bool _RenderByCommonAssets(CommonCharCardView.CommonCharCardComp totalCardComp, ICharacterCardViewModel characterCardViewModel)
		{
			return default(bool);
		}

		// Token: 0x06015C5F RID: 89183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C5F")]
		[Address(RVA = "0xE455F0", Offset = "0xE441F0", VA = "0x180E455F0")]
		private void _RenderByCustomAssets(CommonCharCardView.CommonCharCardComp totalCardComp, ICharacterCardViewModel characterCardViewModel)
		{
		}

		// Token: 0x06015C60 RID: 89184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C60")]
		[Address(RVA = "0xE44F20", Offset = "0xE43B20", VA = "0x180E44F20")]
		private void _RendCardSingleTypeView(CommonCharCardView.CommonCharCardSingleTypeAssets cardAssets, ICharacterCardViewModel characterCardViewModel, CommonCharCardView.ICommonCharCardPlugin cardPlugin)
		{
		}

		// Token: 0x06015C61 RID: 89185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C61")]
		[Address(RVA = "0xE45F80", Offset = "0xE44B80", VA = "0x180E45F80")]
		public CommonCharCardView()
		{
		}

		// Token: 0x0401A2ED RID: 107245
		[Token(Token = "0x401A2ED")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CommonCharCardView.CustomCharCardComp[] _customCharCardAssets;

		// Token: 0x0401A2EE RID: 107246
		[Token(Token = "0x401A2EE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _rendCommonName;

		// Token: 0x0401A2EF RID: 107247
		[Token(Token = "0x401A2EF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CommonCharCardView.CommonCharCardNameComp _nameComp;

		// Token: 0x0401A2F0 RID: 107248
		[Token(Token = "0x401A2F0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _rendCommonPortrait;

		// Token: 0x0401A2F1 RID: 107249
		[Token(Token = "0x401A2F1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CommonCharCardView.CommonCharCardPortraitComp _portraitComp;

		// Token: 0x0401A2F2 RID: 107250
		[Token(Token = "0x401A2F2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _rendCommonElite;

		// Token: 0x0401A2F3 RID: 107251
		[Token(Token = "0x401A2F3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CommonCharCardView.CommonCharCardEliteComp _eliteComp;

		// Token: 0x0401A2F4 RID: 107252
		[Token(Token = "0x401A2F4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _rendCommonLv;

		// Token: 0x0401A2F5 RID: 107253
		[Token(Token = "0x401A2F5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CommonCharCardView.CommonCharCardLvComp _lvComp;

		// Token: 0x0401A2F6 RID: 107254
		[Token(Token = "0x401A2F6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _rendCommonPotential;

		// Token: 0x0401A2F7 RID: 107255
		[Token(Token = "0x401A2F7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CommonCharCardView.CommonCharCardPotentialComp _potentialComp;

		// Token: 0x0401A2F8 RID: 107256
		[Token(Token = "0x401A2F8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private bool _rendCommonEquip;

		// Token: 0x0401A2F9 RID: 107257
		[Token(Token = "0x401A2F9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CommonCharCardView.CommonCharCardEquipComp _equipComp;

		// Token: 0x0401A2FA RID: 107258
		[Token(Token = "0x401A2FA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool _rendCommonProfession;

		// Token: 0x0401A2FB RID: 107259
		[Token(Token = "0x401A2FB")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CommonCharCardView.CommonCharCardProfessionComp _professionComp;

		// Token: 0x0401A2FC RID: 107260
		[Token(Token = "0x401A2FC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _rendCommonSkill;

		// Token: 0x0401A2FD RID: 107261
		[Token(Token = "0x401A2FD")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CommonCharCardView.CommonCharCardSkillComp _skillComp;

		// Token: 0x0401A2FE RID: 107262
		[Token(Token = "0x401A2FE")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private bool _rendCommonRarityRank;

		// Token: 0x0401A2FF RID: 107263
		[Token(Token = "0x401A2FF")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private CommonCharCardView.CommonCharCardRarityRankComp _rarityRarityRankComp;

		// Token: 0x0401A300 RID: 107264
		[Token(Token = "0x401A300")]
		[FieldOffset(Offset = "0xB0")]
		private Dictionary<int, CommonCharCardView.ICommonCharCardPlugin> m_customPlugins;

		// Token: 0x0401A301 RID: 107265
		[Token(Token = "0x401A301")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<int, CommonCharCardView.ICommonCharCardPlugin> DEFAULT_PLUGINS;

		// Token: 0x0401A302 RID: 107266
		[Token(Token = "0x401A302")]
		[FieldOffset(Offset = "0xB8")]
		private UIScaler m_uiScaler;

		// Token: 0x0401A303 RID: 107267
		[Token(Token = "0x401A303")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isScalerInited;

		// Token: 0x0401A304 RID: 107268
		[Token(Token = "0x401A304")]
		[FieldOffset(Offset = "0xC8")]
		private UIColorGraphic m_uiColorGraphic;

		// Token: 0x0401A305 RID: 107269
		[Token(Token = "0x401A305")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_isColorGraphicInited;

		// Token: 0x0401A306 RID: 107270
		[Token(Token = "0x401A306")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_colorGraphic;

		// Token: 0x0401A307 RID: 107271
		[Token(Token = "0x401A307")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitScalerIfNot;

		// Token: 0x0401A308 RID: 107272
		[Token(Token = "0x401A308")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetScaler;

		// Token: 0x0401A309 RID: 107273
		[Token(Token = "0x401A309")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetPlugin;

		// Token: 0x0401A30A RID: 107274
		[Token(Token = "0x401A30A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RenderCard;

		// Token: 0x0401A30B RID: 107275
		[Token(Token = "0x401A30B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ResetCard;

		// Token: 0x0401A30C RID: 107276
		[Token(Token = "0x401A30C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetAvailPlugin;

		// Token: 0x0401A30D RID: 107277
		[Token(Token = "0x401A30D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderByCommonAssets;

		// Token: 0x0401A30E RID: 107278
		[Token(Token = "0x401A30E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderByCustomAssets;

		// Token: 0x0401A30F RID: 107279
		[Token(Token = "0x401A30F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RendCardSingleTypeView;

		// Token: 0x0401A310 RID: 107280
		[Token(Token = "0x401A310")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003561 RID: 13665
		[Token(Token = "0x2003561")]
		public interface ICommonCharCardPlugin : IHotfixable
		{
			// Token: 0x06015C63 RID: 89187
			[Token(Token = "0x6015C63")]
			bool CheckCacheCondition(ICharacterCardViewModel characterCardViewModel, DataBundle cacheConditions);

			// Token: 0x06015C64 RID: 89188
			[Token(Token = "0x6015C64")]
			void ApplyCacheCondition(ICharacterCardViewModel characterCardViewModel, DataBundle cacheConditions);

			// Token: 0x06015C65 RID: 89189
			[Token(Token = "0x6015C65")]
			void RendView(CommonCharCardView.CommonCharCardSingleTypeAssets cardAssets, ICharacterCardViewModel characterCardViewModel);
		}

		// Token: 0x02003562 RID: 13666
		[Token(Token = "0x2003562")]
		public enum CharCardCompType
		{
			// Token: 0x0401A312 RID: 107282
			[Token(Token = "0x401A312")]
			NONE,
			// Token: 0x0401A313 RID: 107283
			[Token(Token = "0x401A313")]
			NAME,
			// Token: 0x0401A314 RID: 107284
			[Token(Token = "0x401A314")]
			PORTRAIT,
			// Token: 0x0401A315 RID: 107285
			[Token(Token = "0x401A315")]
			ELITE,
			// Token: 0x0401A316 RID: 107286
			[Token(Token = "0x401A316")]
			LV,
			// Token: 0x0401A317 RID: 107287
			[Token(Token = "0x401A317")]
			POTENTIAL,
			// Token: 0x0401A318 RID: 107288
			[Token(Token = "0x401A318")]
			EQUIP,
			// Token: 0x0401A319 RID: 107289
			[Token(Token = "0x401A319")]
			PROFESSION,
			// Token: 0x0401A31A RID: 107290
			[Token(Token = "0x401A31A")]
			SKILL,
			// Token: 0x0401A31B RID: 107291
			[Token(Token = "0x401A31B")]
			RARITY_RANK,
			// Token: 0x0401A31C RID: 107292
			[Token(Token = "0x401A31C")]
			CUSTOM_DECO
		}

		// Token: 0x02003563 RID: 13667
		[Token(Token = "0x2003563")]
		[Serializable]
		public abstract class CommonCharCardSingleTypeAssets : IHotfixable
		{
			// Token: 0x170033BE RID: 13246
			// (get) Token: 0x06015C66 RID: 89190 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033BE")]
			public RectTransform root
			{
				[Token(Token = "0x6015C66")]
				[Address(RVA = "0xE44710", Offset = "0xE43310", VA = "0x180E44710")]
				get
				{
					return null;
				}
			}

			// Token: 0x06015C67 RID: 89191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015C67")]
			[Address(RVA = "0xE44670", Offset = "0xE43270", VA = "0x180E44670")]
			protected CommonCharCardSingleTypeAssets()
			{
			}

			// Token: 0x0401A31D RID: 107293
			[Token(Token = "0x401A31D")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private RectTransform _root;

			// Token: 0x0401A31E RID: 107294
			[Token(Token = "0x401A31E")]
			[FieldOffset(Offset = "0x18")]
			[NonSerialized]
			public DataBundle cacheConditions;

			// Token: 0x0401A31F RID: 107295
			[Token(Token = "0x401A31F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_root;

			// Token: 0x0401A320 RID: 107296
			[Token(Token = "0x401A320")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003564 RID: 13668
		[Token(Token = "0x2003564")]
		[Serializable]
		public abstract class CommonCharCardComp : IHotfixable
		{
			// Token: 0x170033BF RID: 13247
			// (get) Token: 0x06015C68 RID: 89192
			[Token(Token = "0x170033BF")]
			public abstract CommonCharCardView.CharCardCompType compType { [Token(Token = "0x6015C68")] get; }

			// Token: 0x170033C0 RID: 13248
			// (get) Token: 0x06015C69 RID: 89193 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033C0")]
			public CommonCharCardView.CommonCharCardNameAssets nameAssets
			{
				[Token(Token = "0x6015C69")]
				[Address(RVA = "0xE43B80", Offset = "0xE42780", VA = "0x180E43B80")]
				get
				{
					return null;
				}
			}

			// Token: 0x170033C1 RID: 13249
			// (get) Token: 0x06015C6A RID: 89194 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033C1")]
			public CommonCharCardView.CommonCharCardPortraitAssets portraitAssets
			{
				[Token(Token = "0x6015C6A")]
				[Address(RVA = "0xE43BE0", Offset = "0xE427E0", VA = "0x180E43BE0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170033C2 RID: 13250
			// (get) Token: 0x06015C6B RID: 89195 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033C2")]
			public CommonCharCardView.CommonCharCardEliteAssets eliteAssets
			{
				[Token(Token = "0x6015C6B")]
				[Address(RVA = "0xE43A60", Offset = "0xE42660", VA = "0x180E43A60")]
				get
				{
					return null;
				}
			}

			// Token: 0x170033C3 RID: 13251
			// (get) Token: 0x06015C6C RID: 89196 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033C3")]
			public CommonCharCardView.CommonCharCardLvAssets lvAssets
			{
				[Token(Token = "0x6015C6C")]
				[Address(RVA = "0xE43B20", Offset = "0xE42720", VA = "0x180E43B20")]
				get
				{
					return null;
				}
			}

			// Token: 0x170033C4 RID: 13252
			// (get) Token: 0x06015C6D RID: 89197 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033C4")]
			public CommonCharCardView.CommonCharCardPotentialAssets potentialAssets
			{
				[Token(Token = "0x6015C6D")]
				[Address(RVA = "0xE43C40", Offset = "0xE42840", VA = "0x180E43C40")]
				get
				{
					return null;
				}
			}

			// Token: 0x170033C5 RID: 13253
			// (get) Token: 0x06015C6E RID: 89198 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033C5")]
			public CommonCharCardView.CommonCharCardEquipAssets equipAssets
			{
				[Token(Token = "0x6015C6E")]
				[Address(RVA = "0xE43AC0", Offset = "0xE426C0", VA = "0x180E43AC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170033C6 RID: 13254
			// (get) Token: 0x06015C6F RID: 89199 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033C6")]
			public CommonCharCardView.CommonCharCardProfessionAssets professionAssets
			{
				[Token(Token = "0x6015C6F")]
				[Address(RVA = "0xE43CA0", Offset = "0xE428A0", VA = "0x180E43CA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170033C7 RID: 13255
			// (get) Token: 0x06015C70 RID: 89200 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033C7")]
			public CommonCharCardView.CommonCharCardSkillAssets skillAssets
			{
				[Token(Token = "0x6015C70")]
				[Address(RVA = "0xE43D60", Offset = "0xE42960", VA = "0x180E43D60")]
				get
				{
					return null;
				}
			}

			// Token: 0x170033C8 RID: 13256
			// (get) Token: 0x06015C71 RID: 89201 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033C8")]
			public CommonCharCardView.CommonCharCardRarityRankAssets rarityRankAssets
			{
				[Token(Token = "0x6015C71")]
				[Address(RVA = "0xE43D00", Offset = "0xE42900", VA = "0x180E43D00")]
				get
				{
					return null;
				}
			}

			// Token: 0x170033C9 RID: 13257
			// (get) Token: 0x06015C72 RID: 89202 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033C9")]
			public CommonCharCardView.CommonCharCardDecoAssets customDecoAssets
			{
				[Token(Token = "0x6015C72")]
				[Address(RVA = "0xE43A00", Offset = "0xE42600", VA = "0x180E43A00")]
				get
				{
					return null;
				}
			}

			// Token: 0x06015C73 RID: 89203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015C73")]
			[Address(RVA = "0xE439A0", Offset = "0xE425A0", VA = "0x180E439A0")]
			protected CommonCharCardComp()
			{
			}

			// Token: 0x0401A321 RID: 107297
			[Token(Token = "0x401A321")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private CommonCharCardView.CommonCharCardNameAssets _nameAssets;

			// Token: 0x0401A322 RID: 107298
			[Token(Token = "0x401A322")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private CommonCharCardView.CommonCharCardPortraitAssets _portraitAssets;

			// Token: 0x0401A323 RID: 107299
			[Token(Token = "0x401A323")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private CommonCharCardView.CommonCharCardEliteAssets _eliteAssets;

			// Token: 0x0401A324 RID: 107300
			[Token(Token = "0x401A324")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private CommonCharCardView.CommonCharCardLvAssets _lvAssets;

			// Token: 0x0401A325 RID: 107301
			[Token(Token = "0x401A325")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private CommonCharCardView.CommonCharCardPotentialAssets _potentialAssets;

			// Token: 0x0401A326 RID: 107302
			[Token(Token = "0x401A326")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private CommonCharCardView.CommonCharCardEquipAssets _equipAssets;

			// Token: 0x0401A327 RID: 107303
			[Token(Token = "0x401A327")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private CommonCharCardView.CommonCharCardProfessionAssets _professionAssets;

			// Token: 0x0401A328 RID: 107304
			[Token(Token = "0x401A328")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private CommonCharCardView.CommonCharCardSkillAssets _skillAssets;

			// Token: 0x0401A329 RID: 107305
			[Token(Token = "0x401A329")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			private CommonCharCardView.CommonCharCardRarityRankAssets _rarityRankAssets;

			// Token: 0x0401A32A RID: 107306
			[Token(Token = "0x401A32A")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			private CommonCharCardView.CommonCharCardDecoAssets _customDecoAssets;

			// Token: 0x0401A32B RID: 107307
			[Token(Token = "0x401A32B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_nameAssets;

			// Token: 0x0401A32C RID: 107308
			[Token(Token = "0x401A32C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_portraitAssets;

			// Token: 0x0401A32D RID: 107309
			[Token(Token = "0x401A32D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_eliteAssets;

			// Token: 0x0401A32E RID: 107310
			[Token(Token = "0x401A32E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_lvAssets;

			// Token: 0x0401A32F RID: 107311
			[Token(Token = "0x401A32F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_potentialAssets;

			// Token: 0x0401A330 RID: 107312
			[Token(Token = "0x401A330")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_equipAssets;

			// Token: 0x0401A331 RID: 107313
			[Token(Token = "0x401A331")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_professionAssets;

			// Token: 0x0401A332 RID: 107314
			[Token(Token = "0x401A332")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_skillAssets;

			// Token: 0x0401A333 RID: 107315
			[Token(Token = "0x401A333")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_rarityRankAssets;

			// Token: 0x0401A334 RID: 107316
			[Token(Token = "0x401A334")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_customDecoAssets;

			// Token: 0x0401A335 RID: 107317
			[Token(Token = "0x401A335")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003565 RID: 13669
		[Token(Token = "0x2003565")]
		[Serializable]
		private class CustomCharCardComp : CommonCharCardView.CommonCharCardComp
		{
			// Token: 0x170033CA RID: 13258
			// (get) Token: 0x06015C74 RID: 89204 RVA: 0x0008DBD0 File Offset: 0x0008BDD0
			[Token(Token = "0x170033CA")]
			public override CommonCharCardView.CharCardCompType compType
			{
				[Token(Token = "0x6015C74")]
				[Address(RVA = "0xE461A0", Offset = "0xE44DA0", VA = "0x180E461A0", Slot = "4")]
				get
				{
					return CommonCharCardView.CharCardCompType.NONE;
				}
			}

			// Token: 0x06015C75 RID: 89205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015C75")]
			[Address(RVA = "0xE46100", Offset = "0xE44D00", VA = "0x180E46100")]
			public CustomCharCardComp()
			{
			}

			// Token: 0x0401A336 RID: 107318
			[Token(Token = "0x401A336")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			private CommonCharCardView.CharCardCompType _compType;

			// Token: 0x0401A337 RID: 107319
			[Token(Token = "0x401A337")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_compType;

			// Token: 0x0401A338 RID: 107320
			[Token(Token = "0x401A338")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003566 RID: 13670
		[Token(Token = "0x2003566")]
		[Serializable]
		public class CommonCharCardDecoAssets : CommonCharCardView.CommonCharCardSingleTypeAssets
		{
			// Token: 0x170033CB RID: 13259
			// (get) Token: 0x06015C76 RID: 89206 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033CB")]
			public CommonCharCardDecoBase monoDeco
			{
				[Token(Token = "0x6015C76")]
				[Address(RVA = "0xE43E20", Offset = "0xE42A20", VA = "0x180E43E20")]
				get
				{
					return null;
				}
			}

			// Token: 0x06015C77 RID: 89207 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015C77")]
			[Address(RVA = "0xE43DC0", Offset = "0xE429C0", VA = "0x180E43DC0")]
			public CommonCharCardDecoAssets()
			{
			}

			// Token: 0x0401A339 RID: 107321
			[Token(Token = "0x401A339")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private CommonCharCardDecoBase _monoDeco;

			// Token: 0x0401A33A RID: 107322
			[Token(Token = "0x401A33A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_monoDeco;

			// Token: 0x0401A33B RID: 107323
			[Token(Token = "0x401A33B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003567 RID: 13671
		[Token(Token = "0x2003567")]
		[Serializable]
		private class CommonCharCardDecoComp : CommonCharCardView.CommonCharCardComp
		{
			// Token: 0x170033CC RID: 13260
			// (get) Token: 0x06015C78 RID: 89208 RVA: 0x0008DBE8 File Offset: 0x0008BDE8
			[Token(Token = "0x170033CC")]
			public override CommonCharCardView.CharCardCompType compType
			{
				[Token(Token = "0x6015C78")]
				[Address(RVA = "0xE43F20", Offset = "0xE42B20", VA = "0x180E43F20", Slot = "4")]
				get
				{
					return CommonCharCardView.CharCardCompType.NONE;
				}
			}

			// Token: 0x06015C79 RID: 89209 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015C79")]
			[Address(RVA = "0xE43E80", Offset = "0xE42A80", VA = "0x180E43E80")]
			public CommonCharCardDecoComp()
			{
			}

			// Token: 0x0401A33C RID: 107324
			[Token(Token = "0x401A33C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_compType;

			// Token: 0x0401A33D RID: 107325
			[Token(Token = "0x401A33D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003568 RID: 13672
		[Token(Token = "0x2003568")]
		private class DefaultCardDecoPlugin : CommonCharCardView.ICommonCharCardPlugin, IHotfixable
		{
			// Token: 0x06015C7A RID: 89210 RVA: 0x0008DC00 File Offset: 0x0008BE00
			[Token(Token = "0x6015C7A")]
			[Address(RVA = "0xE46280", Offset = "0xE44E80", VA = "0x180E46280", Slot = "4")]
			public bool CheckCacheCondition(ICharacterCardViewModel characterCardViewModel, DataBundle cacheConditions)
			{
				return default(bool);
			}

			// Token: 0x06015C7B RID: 89211 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015C7B")]
			[Address(RVA = "0xE46200", Offset = "0xE44E00", VA = "0x180E46200", Slot = "5")]
			public void ApplyCacheCondition(ICharacterCardViewModel characterCardViewModel, DataBundle cacheConditions)
			{
			}

			// Token: 0x06015C7C RID: 89212 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015C7C")]
			[Address(RVA = "0xE46310", Offset = "0xE44F10", VA = "0x180E46310", Slot = "6")]
			public void RendView(CommonCharCardView.CommonCharCardSingleTypeAssets cardAssets, ICharacterCardViewModel characterCardViewModel)
			{
			}

			// Token: 0x06015C7D RID: 89213 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015C7D")]
			[Address(RVA = "0xE464B0", Offset = "0xE450B0", VA = "0x180E464B0")]
			public DefaultCardDecoPlugin()
			{
			}

			// Token: 0x0401A33E RID: 107326
			[Token(Token = "0x401A33E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CheckCacheCondition;

			// Token: 0x0401A33F RID: 107327
			[Token(Token = "0x401A33F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ApplyCacheCondition;

			// Token: 0x0401A340 RID: 107328
			[Token(Token = "0x401A340")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RendView;

			// Token: 0x0401A341 RID: 107329
			[Token(Token = "0x401A341")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003569 RID: 13673
		[Token(Token = "0x2003569")]
		public enum EliteIconType
		{
			// Token: 0x0401A343 RID: 107331
			[Token(Token = "0x401A343")]
			ELITE_CARD,
			// Token: 0x0401A344 RID: 107332
			[Token(Token = "0x401A344")]
			ELITE_PIC
		}

		// Token: 0x0200356A RID: 13674
		[Token(Token = "0x200356A")]
		[Serializable]
		public class CommonCharCardEliteAssets : CommonCharCardView.CommonCharCardSingleTypeAssets
		{
			// Token: 0x170033CD RID: 13261
			// (get) Token: 0x06015C7E RID: 89214 RVA: 0x0008DC18 File Offset: 0x0008BE18
			[Token(Token = "0x170033CD")]
			public bool hideEliteWhenIsZero
			{
				[Token(Token = "0x6015C7E")]
				[Address(RVA = "0xE44050", Offset = "0xE42C50", VA = "0x180E44050")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170033CE RID: 13262
			// (get) Token: 0x06015C7F RID: 89215 RVA: 0x0008DC30 File Offset: 0x0008BE30
			[Token(Token = "0x170033CE")]
			public CommonCharCardView.EliteIconType eliteIconType
			{
				[Token(Token = "0x6015C7F")]
				[Address(RVA = "0xE43FF0", Offset = "0xE42BF0", VA = "0x180E43FF0")]
				get
				{
					return CommonCharCardView.EliteIconType.ELITE_CARD;
				}
			}

			// Token: 0x170033CF RID: 13263
			// (get) Token: 0x06015C80 RID: 89216 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033CF")]
			public Image imageElite
			{
				[Token(Token = "0x6015C80")]
				[Address(RVA = "0xE440B0", Offset = "0xE42CB0", VA = "0x180E440B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06015C81 RID: 89217 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015C81")]
			[Address(RVA = "0xE43F80", Offset = "0xE42B80", VA = "0x180E43F80")]
			public CommonCharCardEliteAssets()
			{
			}

			// Token: 0x0401A345 RID: 107333
			[Token(Token = "0x401A345")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private bool _hideEliteWhenIsZero;

			// Token: 0x0401A346 RID: 107334
			[Token(Token = "0x401A346")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			private CommonCharCardView.EliteIconType _eliteIconType;

			// Token: 0x0401A347 RID: 107335
			[Token(Token = "0x401A347")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Image _imageElite;

			// Token: 0x0401A348 RID: 107336
			[Token(Token = "0x401A348")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_hideEliteWhenIsZero;

			// Token: 0x0401A349 RID: 107337
			[Token(Token = "0x401A349")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_eliteIconType;

			// Token: 0x0401A34A RID: 107338
			[Token(Token = "0x401A34A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_imageElite;

			// Token: 0x0401A34B RID: 107339
			[Token(Token = "0x401A34B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200356B RID: 13675
		[Token(Token = "0x200356B")]
		[Serializable]
		private class CommonCharCardEliteComp : CommonCharCardView.CommonCharCardComp
		{
			// Token: 0x170033D0 RID: 13264
			// (get) Token: 0x06015C82 RID: 89218 RVA: 0x0008DC48 File Offset: 0x0008BE48
			[Token(Token = "0x170033D0")]
			public override CommonCharCardView.CharCardCompType compType
			{
				[Token(Token = "0x6015C82")]
				[Address(RVA = "0xE441B0", Offset = "0xE42DB0", VA = "0x180E441B0", Slot = "4")]
				get
				{
					return CommonCharCardView.CharCardCompType.NONE;
				}
			}

			// Token: 0x06015C83 RID: 89219 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015C83")]
			[Address(RVA = "0xE44110", Offset = "0xE42D10", VA = "0x180E44110")]
			public CommonCharCardEliteComp()
			{
			}

			// Token: 0x0401A34C RID: 107340
			[Token(Token = "0x401A34C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_compType;

			// Token: 0x0401A34D RID: 107341
			[Token(Token = "0x401A34D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200356C RID: 13676
		[Token(Token = "0x200356C")]
		private class DefaultElitePlugin : CommonCharCardView.ICommonCharCardPlugin, IHotfixable
		{
			// Token: 0x06015C84 RID: 89220 RVA: 0x0008DC60 File Offset: 0x0008BE60
			[Token(Token = "0x6015C84")]
			[Address(RVA = "0xE46600", Offset = "0xE45200", VA = "0x180E46600", Slot = "4")]
			public bool CheckCacheCondition(ICharacterCardViewModel characterCardViewModel, DataBundle cacheConditions)
			{
				return default(bool);
			}

			// Token: 0x06015C85 RID: 89221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015C85")]
			[Address(RVA = "0xE46510", Offset = "0xE45110", VA = "0x180E46510", Slot = "5")]
			public void ApplyCacheCondition(ICharacterCardViewModel characterCardViewModel, DataBundle cacheConditions)
			{
			}

			// Token: 0x06015C86 RID: 89222 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015C86")]
			[Address(RVA = "0xE46710", Offset = "0xE45310", VA = "0x180E46710", Slot = "6")]
			public void RendView(CommonCharCardView.CommonCharCardSingleTypeAssets cardAssets, ICharacterCardViewModel characterCardViewModel)
			{
			}

			// Token: 0x06015C87 RID: 89223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015C87")]
			[Address(RVA = "0xE469F0", Offset = "0xE455F0", VA = "0x180E469F0")]
			public DefaultElitePlugin()
			{
			}

			// Token: 0x0401A34E RID: 107342
			[Token(Token = "0x401A34E")]
			private const string KEY_CACHE_ELITE_LEVEL = "KEY_CACHE_ELITE_LEVEL";

			// Token: 0x0401A34F RID: 107343
			[Token(Token = "0x401A34F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CheckCacheCondition;

			// Token: 0x0401A350 RID: 107344
			[Token(Token = "0x401A350")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ApplyCacheCondition;

			// Token: 0x0401A351 RID: 107345
			[Token(Token = "0x401A351")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RendView;

			// Token: 0x0401A352 RID: 107346
			[Token(Token = "0x401A352")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200356D RID: 13677
		[Token(Token = "0x200356D")]
		[Serializable]
		public class CommonCharCardEquipAssets : CommonCharCardView.CommonCharCardSingleTypeAssets
		{
			// Token: 0x170033D1 RID: 13265
			// (get) Token: 0x06015C88 RID: 89224 RVA: 0x0008DC78 File Offset: 0x0008BE78
			[Token(Token = "0x170033D1")]
			public bool showEquipLevel
			{
				[Token(Token = "0x6015C88")]
				[Address(RVA = "0xE44450", Offset = "0xE43050", VA = "0x180E44450")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170033D2 RID: 13266
			// (get) Token: 0x06015C89 RID: 89225 RVA: 0x0008DC90 File Offset: 0x0008BE90
			[Token(Token = "0x170033D2")]
			public bool useOriginalDefaultEquipIcon
			{
				[Token(Token = "0x6015C89")]
				[Address(RVA = "0xE44510", Offset = "0xE43110", VA = "0x180E44510")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170033D3 RID: 13267
			// (get) Token: 0x06015C8A RID: 89226 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033D3")]
			public GameObject panelEquip
			{
				[Token(Token = "0x6015C8A")]
				[Address(RVA = "0xE443F0", Offset = "0xE42FF0", VA = "0x180E443F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170033D4 RID: 13268
			// (get) Token: 0x06015C8B RID: 89227 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033D4")]
			public GameObject panelEquipEmpty
			{
				[Token(Token = "0x6015C8B")]
				[Address(RVA = "0xE44390", Offset = "0xE42F90", VA = "0x180E44390")]
				get
				{
					return null;
				}
			}

			// Token: 0x170033D5 RID: 13269
			// (get) Token: 0x06015C8C RID: 89228 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033D5")]
			public GameObject panelDefaultEquip
			{
				[Token(Token = "0x6015C8C")]
				[Address(RVA = "0xE44330", Offset = "0xE42F30", VA = "0x180E44330")]
				get
				{
					return null;
				}
			}

			// Token: 0x170033D6 RID: 13270
			// (get) Token: 0x06015C8D RID: 89229 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033D6")]
			public Image imageEquip
			{
				[Token(Token = "0x6015C8D")]
				[Address(RVA = "0xE442D0", Offset = "0xE42ED0", VA = "0x180E442D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170033D7 RID: 13271
			// (get) Token: 0x06015C8E RID: 89230 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033D7")]
			public GameObject equipLvGo
			{
				[Token(Token = "0x6015C8E")]
				[Address(RVA = "0xE44270", Offset = "0xE42E70", VA = "0x180E44270")]
				get
				{
					return null;
				}
			}

			// Token: 0x170033D8 RID: 13272
			// (get) Token: 0x06015C8F RID: 89231 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033D8")]
			public Text textEquipLv
			{
				[Token(Token = "0x6015C8F")]
				[Address(RVA = "0xE444B0", Offset = "0xE430B0", VA = "0x180E444B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06015C90 RID: 89232 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015C90")]
			[Address(RVA = "0xE44210", Offset = "0xE42E10", VA = "0x180E44210")]
			public CommonCharCardEquipAssets()
			{
			}

			// Token: 0x0401A353 RID: 107347
			[Token(Token = "0x401A353")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private bool _showEquipLevel;

			// Token: 0x0401A354 RID: 107348
			[Token(Token = "0x401A354")]
			[FieldOffset(Offset = "0x21")]
			[SerializeField]
			private bool _useOriginalDefaultEquipIcon;

			// Token: 0x0401A355 RID: 107349
			[Token(Token = "0x401A355")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private GameObject _panelEquipEmpty;

			// Token: 0x0401A356 RID: 107350
			[Token(Token = "0x401A356")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private GameObject _panelEquip;

			// Token: 0x0401A357 RID: 107351
			[Token(Token = "0x401A357")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private GameObject _panelDefaultEquip;

			// Token: 0x0401A358 RID: 107352
			[Token(Token = "0x401A358")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private Image _imageEquip;

			// Token: 0x0401A359 RID: 107353
			[Token(Token = "0x401A359")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private GameObject _equipLvGo;

			// Token: 0x0401A35A RID: 107354
			[Token(Token = "0x401A35A")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			private Text _textEquipLv;

			// Token: 0x0401A35B RID: 107355
			[Token(Token = "0x401A35B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_showEquipLevel;

			// Token: 0x0401A35C RID: 107356
			[Token(Token = "0x401A35C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_useOriginalDefaultEquipIcon;

			// Token: 0x0401A35D RID: 107357
			[Token(Token = "0x401A35D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_panelEquip;

			// Token: 0x0401A35E RID: 107358
			[Token(Token = "0x401A35E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_panelEquipEmpty;

			// Token: 0x0401A35F RID: 107359
			[Token(Token = "0x401A35F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_panelDefaultEquip;

			// Token: 0x0401A360 RID: 107360
			[Token(Token = "0x401A360")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_imageEquip;

			// Token: 0x0401A361 RID: 107361
			[Token(Token = "0x401A361")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_equipLvGo;

			// Token: 0x0401A362 RID: 107362
			[Token(Token = "0x401A362")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_textEquipLv;

			// Token: 0x0401A363 RID: 107363
			[Token(Token = "0x401A363")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200356E RID: 13678
		[Token(Token = "0x200356E")]
		[Serializable]
		private class CommonCharCardEquipComp : CommonCharCardView.CommonCharCardComp
		{
			// Token: 0x170033D9 RID: 13273
			// (get) Token: 0x06015C91 RID: 89233 RVA: 0x0008DCA8 File Offset: 0x0008BEA8
			[Token(Token = "0x170033D9")]
			public override CommonCharCardView.CharCardCompType compType
			{
				[Token(Token = "0x6015C91")]
				[Address(RVA = "0xE44610", Offset = "0xE43210", VA = "0x180E44610", Slot = "4")]
				get
				{
					return CommonCharCardView.CharCardCompType.NONE;
				}
			}

			// Token: 0x06015C92 RID: 89234 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015C92")]
			[Address(RVA = "0xE44570", Offset = "0xE43170", VA = "0x180E44570")]
			public CommonCharCardEquipComp()
			{
			}

			// Token: 0x0401A364 RID: 107364
			[Token(Token = "0x401A364")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_compType;

			// Token: 0x0401A365 RID: 107365
			[Token(Token = "0x401A365")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200356F RID: 13679
		[Token(Token = "0x200356F")]
		private class DefaultEquipPlugin : CommonCharCardView.ICommonCharCardPlugin, IHotfixable
		{
			// Token: 0x06015C93 RID: 89235 RVA: 0x0008DCC0 File Offset: 0x0008BEC0
			[Token(Token = "0x6015C93")]
			[Address(RVA = "0xE46C40", Offset = "0xE45840", VA = "0x180E46C40", Slot = "4")]
			public bool CheckCacheCondition(ICharacterCardViewModel characterCardViewModel, DataBundle cacheConditions)
			{
				return default(bool);
			}

			// Token: 0x06015C94 RID: 89236 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015C94")]
			[Address(RVA = "0xE46A50", Offset = "0xE45650", VA = "0x180E46A50", Slot = "5")]
			public void ApplyCacheCondition(ICharacterCardViewModel characterCardViewModel, DataBundle cacheConditions)
			{
			}

			// Token: 0x06015C95 RID: 89237 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015C95")]
			[Address(RVA = "0xE46E70", Offset = "0xE45A70", VA = "0x180E46E70", Slot = "6")]
			public void RendView(CommonCharCardView.CommonCharCardSingleTypeAssets cardAssets, ICharacterCardViewModel characterCardViewModel)
			{
			}

			// Token: 0x06015C96 RID: 89238 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015C96")]
			[Address(RVA = "0xE47390", Offset = "0xE45F90", VA = "0x180E47390")]
			public DefaultEquipPlugin()
			{
			}

			// Token: 0x0401A366 RID: 107366
			[Token(Token = "0x401A366")]
			private const string KEY_CACHE_EQUIP_ID = "KEY_CACHE_EQUIP_ID";

			// Token: 0x0401A367 RID: 107367
			[Token(Token = "0x401A367")]
			private const string KEY_CACHE_EQUIP_LEVEL = "KEY_CACHE_EQUIP_LEVEL";

			// Token: 0x0401A368 RID: 107368
			[Token(Token = "0x401A368")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CheckCacheCondition;

			// Token: 0x0401A369 RID: 107369
			[Token(Token = "0x401A369")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ApplyCacheCondition;

			// Token: 0x0401A36A RID: 107370
			[Token(Token = "0x401A36A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RendView;

			// Token: 0x0401A36B RID: 107371
			[Token(Token = "0x401A36B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003570 RID: 13680
		[Token(Token = "0x2003570")]
		[Serializable]
		public class CommonCharCardLvAssets : CommonCharCardView.CommonCharCardSingleTypeAssets
		{
			// Token: 0x170033DA RID: 13274
			// (get) Token: 0x06015C97 RID: 89239 RVA: 0x0008DCD8 File Offset: 0x0008BED8
			[Token(Token = "0x170033DA")]
			public bool showLvPercent
			{
				[Token(Token = "0x6015C97")]
				[Address(RVA = "0xE5B990", Offset = "0xE5A590", VA = "0x180E5B990")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170033DB RID: 13275
			// (get) Token: 0x06015C98 RID: 89240 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033DB")]
			public Text textLv
			{
				[Token(Token = "0x6015C98")]
				[Address(RVA = "0xE5B9F0", Offset = "0xE5A5F0", VA = "0x180E5B9F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170033DC RID: 13276
			// (get) Token: 0x06015C99 RID: 89241 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033DC")]
			public Image imageLvPercent
			{
				[Token(Token = "0x6015C99")]
				[Address(RVA = "0xE5B930", Offset = "0xE5A530", VA = "0x180E5B930")]
				get
				{
					return null;
				}
			}

			// Token: 0x06015C9A RID: 89242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015C9A")]
			[Address(RVA = "0xE5B8D0", Offset = "0xE5A4D0", VA = "0x180E5B8D0")]
			public CommonCharCardLvAssets()
			{
			}

			// Token: 0x0401A36C RID: 107372
			[Token(Token = "0x401A36C")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private bool _showLvPercent;

			// Token: 0x0401A36D RID: 107373
			[Token(Token = "0x401A36D")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Text _textLv;

			// Token: 0x0401A36E RID: 107374
			[Token(Token = "0x401A36E")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Image _imageLvPercent;

			// Token: 0x0401A36F RID: 107375
			[Token(Token = "0x401A36F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_showLvPercent;

			// Token: 0x0401A370 RID: 107376
			[Token(Token = "0x401A370")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_textLv;

			// Token: 0x0401A371 RID: 107377
			[Token(Token = "0x401A371")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_imageLvPercent;

			// Token: 0x0401A372 RID: 107378
			[Token(Token = "0x401A372")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003571 RID: 13681
		[Token(Token = "0x2003571")]
		[Serializable]
		private class CommonCharCardLvComp : CommonCharCardView.CommonCharCardComp
		{
			// Token: 0x170033DD RID: 13277
			// (get) Token: 0x06015C9B RID: 89243 RVA: 0x0008DCF0 File Offset: 0x0008BEF0
			[Token(Token = "0x170033DD")]
			public override CommonCharCardView.CharCardCompType compType
			{
				[Token(Token = "0x6015C9B")]
				[Address(RVA = "0xE5BAB0", Offset = "0xE5A6B0", VA = "0x180E5BAB0", Slot = "4")]
				get
				{
					return CommonCharCardView.CharCardCompType.NONE;
				}
			}

			// Token: 0x06015C9C RID: 89244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015C9C")]
			[Address(RVA = "0xE5BA50", Offset = "0xE5A650", VA = "0x180E5BA50")]
			public CommonCharCardLvComp()
			{
			}

			// Token: 0x0401A373 RID: 107379
			[Token(Token = "0x401A373")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_compType;

			// Token: 0x0401A374 RID: 107380
			[Token(Token = "0x401A374")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003572 RID: 13682
		[Token(Token = "0x2003572")]
		private class DefaultLvPlugin : CommonCharCardView.ICommonCharCardPlugin, IHotfixable
		{
			// Token: 0x06015C9D RID: 89245 RVA: 0x0008DD08 File Offset: 0x0008BF08
			[Token(Token = "0x6015C9D")]
			[Address(RVA = "0xE6C460", Offset = "0xE6B060", VA = "0x180E6C460", Slot = "4")]
			public bool CheckCacheCondition(ICharacterCardViewModel characterCardViewModel, DataBundle cacheConditions)
			{
				return default(bool);
			}

			// Token: 0x06015C9E RID: 89246 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015C9E")]
			[Address(RVA = "0xE6C3E0", Offset = "0xE6AFE0", VA = "0x180E6C3E0", Slot = "5")]
			public void ApplyCacheCondition(ICharacterCardViewModel characterCardViewModel, DataBundle cacheConditions)
			{
			}

			// Token: 0x06015C9F RID: 89247 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015C9F")]
			[Address(RVA = "0xE6C4F0", Offset = "0xE6B0F0", VA = "0x180E6C4F0", Slot = "6")]
			public void RendView(CommonCharCardView.CommonCharCardSingleTypeAssets cardAssets, ICharacterCardViewModel characterCardViewModel)
			{
			}

			// Token: 0x06015CA0 RID: 89248 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CA0")]
			[Address(RVA = "0xE6C760", Offset = "0xE6B360", VA = "0x180E6C760")]
			public DefaultLvPlugin()
			{
			}

			// Token: 0x0401A375 RID: 107381
			[Token(Token = "0x401A375")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CheckCacheCondition;

			// Token: 0x0401A376 RID: 107382
			[Token(Token = "0x401A376")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ApplyCacheCondition;

			// Token: 0x0401A377 RID: 107383
			[Token(Token = "0x401A377")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RendView;

			// Token: 0x0401A378 RID: 107384
			[Token(Token = "0x401A378")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003573 RID: 13683
		[Token(Token = "0x2003573")]
		[Serializable]
		public class CommonCharCardNameAssets : CommonCharCardView.CommonCharCardSingleTypeAssets
		{
			// Token: 0x170033DE RID: 13278
			// (get) Token: 0x06015CA1 RID: 89249 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033DE")]
			public Text textName
			{
				[Token(Token = "0x6015CA1")]
				[Address(RVA = "0xE5BB70", Offset = "0xE5A770", VA = "0x180E5BB70")]
				get
				{
					return null;
				}
			}

			// Token: 0x06015CA2 RID: 89250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CA2")]
			[Address(RVA = "0xE5BB10", Offset = "0xE5A710", VA = "0x180E5BB10")]
			public CommonCharCardNameAssets()
			{
			}

			// Token: 0x0401A379 RID: 107385
			[Token(Token = "0x401A379")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _textName;

			// Token: 0x0401A37A RID: 107386
			[Token(Token = "0x401A37A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_textName;

			// Token: 0x0401A37B RID: 107387
			[Token(Token = "0x401A37B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003574 RID: 13684
		[Token(Token = "0x2003574")]
		[Serializable]
		private class CommonCharCardNameComp : CommonCharCardView.CommonCharCardComp
		{
			// Token: 0x170033DF RID: 13279
			// (get) Token: 0x06015CA3 RID: 89251 RVA: 0x0008DD20 File Offset: 0x0008BF20
			[Token(Token = "0x170033DF")]
			public override CommonCharCardView.CharCardCompType compType
			{
				[Token(Token = "0x6015CA3")]
				[Address(RVA = "0xE5BC30", Offset = "0xE5A830", VA = "0x180E5BC30", Slot = "4")]
				get
				{
					return CommonCharCardView.CharCardCompType.NONE;
				}
			}

			// Token: 0x06015CA4 RID: 89252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CA4")]
			[Address(RVA = "0xE5BBD0", Offset = "0xE5A7D0", VA = "0x180E5BBD0")]
			public CommonCharCardNameComp()
			{
			}

			// Token: 0x0401A37C RID: 107388
			[Token(Token = "0x401A37C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_compType;

			// Token: 0x0401A37D RID: 107389
			[Token(Token = "0x401A37D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003575 RID: 13685
		[Token(Token = "0x2003575")]
		private class DefaultNamePlugin : CommonCharCardView.ICommonCharCardPlugin, IHotfixable
		{
			// Token: 0x06015CA5 RID: 89253 RVA: 0x0008DD38 File Offset: 0x0008BF38
			[Token(Token = "0x6015CA5")]
			[Address(RVA = "0xE6C840", Offset = "0xE6B440", VA = "0x180E6C840", Slot = "4")]
			public bool CheckCacheCondition(ICharacterCardViewModel characterCardViewModel, DataBundle cacheConditions)
			{
				return default(bool);
			}

			// Token: 0x06015CA6 RID: 89254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CA6")]
			[Address(RVA = "0xE6C7C0", Offset = "0xE6B3C0", VA = "0x180E6C7C0", Slot = "5")]
			public void ApplyCacheCondition(ICharacterCardViewModel characterCardViewModel, DataBundle cacheConditions)
			{
			}

			// Token: 0x06015CA7 RID: 89255 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CA7")]
			[Address(RVA = "0xE6C8D0", Offset = "0xE6B4D0", VA = "0x180E6C8D0", Slot = "6")]
			public void RendView(CommonCharCardView.CommonCharCardSingleTypeAssets cardAssets, ICharacterCardViewModel characterCardViewModel)
			{
			}

			// Token: 0x06015CA8 RID: 89256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CA8")]
			[Address(RVA = "0xE6CA70", Offset = "0xE6B670", VA = "0x180E6CA70")]
			public DefaultNamePlugin()
			{
			}

			// Token: 0x0401A37E RID: 107390
			[Token(Token = "0x401A37E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CheckCacheCondition;

			// Token: 0x0401A37F RID: 107391
			[Token(Token = "0x401A37F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ApplyCacheCondition;

			// Token: 0x0401A380 RID: 107392
			[Token(Token = "0x401A380")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RendView;

			// Token: 0x0401A381 RID: 107393
			[Token(Token = "0x401A381")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003576 RID: 13686
		[Token(Token = "0x2003576")]
		[Serializable]
		public class CommonCharCardPortraitAssets : CommonCharCardView.CommonCharCardSingleTypeAssets
		{
			// Token: 0x170033E0 RID: 13280
			// (get) Token: 0x06015CA9 RID: 89257 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033E0")]
			public UIAtlasImage imagePortrait
			{
				[Token(Token = "0x6015CA9")]
				[Address(RVA = "0xE5BCF0", Offset = "0xE5A8F0", VA = "0x180E5BCF0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06015CAA RID: 89258 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CAA")]
			[Address(RVA = "0xE5BC90", Offset = "0xE5A890", VA = "0x180E5BC90")]
			public CommonCharCardPortraitAssets()
			{
			}

			// Token: 0x0401A382 RID: 107394
			[Token(Token = "0x401A382")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private UIAtlasImage _imagePortrait;

			// Token: 0x0401A383 RID: 107395
			[Token(Token = "0x401A383")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_imagePortrait;

			// Token: 0x0401A384 RID: 107396
			[Token(Token = "0x401A384")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003577 RID: 13687
		[Token(Token = "0x2003577")]
		[Serializable]
		private class CommonCharCardPortraitComp : CommonCharCardView.CommonCharCardComp
		{
			// Token: 0x170033E1 RID: 13281
			// (get) Token: 0x06015CAB RID: 89259 RVA: 0x0008DD50 File Offset: 0x0008BF50
			[Token(Token = "0x170033E1")]
			public override CommonCharCardView.CharCardCompType compType
			{
				[Token(Token = "0x6015CAB")]
				[Address(RVA = "0xE5BDB0", Offset = "0xE5A9B0", VA = "0x180E5BDB0", Slot = "4")]
				get
				{
					return CommonCharCardView.CharCardCompType.NONE;
				}
			}

			// Token: 0x06015CAC RID: 89260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CAC")]
			[Address(RVA = "0xE5BD50", Offset = "0xE5A950", VA = "0x180E5BD50")]
			public CommonCharCardPortraitComp()
			{
			}

			// Token: 0x0401A385 RID: 107397
			[Token(Token = "0x401A385")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_compType;

			// Token: 0x0401A386 RID: 107398
			[Token(Token = "0x401A386")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003578 RID: 13688
		[Token(Token = "0x2003578")]
		private class DefaultPortraitPlugin : CommonCharCardView.ICommonCharCardPlugin, IHotfixable
		{
			// Token: 0x06015CAD RID: 89261 RVA: 0x0008DD68 File Offset: 0x0008BF68
			[Token(Token = "0x6015CAD")]
			[Address(RVA = "0xE6CC10", Offset = "0xE6B810", VA = "0x180E6CC10", Slot = "4")]
			public bool CheckCacheCondition(ICharacterCardViewModel characterCardViewModel, DataBundle cacheConditions)
			{
				return default(bool);
			}

			// Token: 0x06015CAE RID: 89262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CAE")]
			[Address(RVA = "0xE6CAD0", Offset = "0xE6B6D0", VA = "0x180E6CAD0", Slot = "5")]
			public void ApplyCacheCondition(ICharacterCardViewModel characterCardViewModel, DataBundle cacheConditions)
			{
			}

			// Token: 0x06015CAF RID: 89263 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CAF")]
			[Address(RVA = "0xE6CD70", Offset = "0xE6B970", VA = "0x180E6CD70", Slot = "6")]
			public void RendView(CommonCharCardView.CommonCharCardSingleTypeAssets cardAssets, ICharacterCardViewModel characterCardViewModel)
			{
			}

			// Token: 0x06015CB0 RID: 89264 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CB0")]
			[Address(RVA = "0xE6CFB0", Offset = "0xE6BBB0", VA = "0x180E6CFB0")]
			public DefaultPortraitPlugin()
			{
			}

			// Token: 0x0401A387 RID: 107399
			[Token(Token = "0x401A387")]
			private const string KEY_CACHE_PORTRAIT_ID = "KEY_CACHE_PORTRAIT_ID";

			// Token: 0x0401A388 RID: 107400
			[Token(Token = "0x401A388")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CheckCacheCondition;

			// Token: 0x0401A389 RID: 107401
			[Token(Token = "0x401A389")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ApplyCacheCondition;

			// Token: 0x0401A38A RID: 107402
			[Token(Token = "0x401A38A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RendView;

			// Token: 0x0401A38B RID: 107403
			[Token(Token = "0x401A38B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003579 RID: 13689
		[Token(Token = "0x2003579")]
		[Serializable]
		public class CommonCharCardPotentialAssets : CommonCharCardView.CommonCharCardSingleTypeAssets
		{
			// Token: 0x170033E2 RID: 13282
			// (get) Token: 0x06015CB1 RID: 89265 RVA: 0x0008DD80 File Offset: 0x0008BF80
			[Token(Token = "0x170033E2")]
			public bool hidePotentialWhenIsZero
			{
				[Token(Token = "0x6015CB1")]
				[Address(RVA = "0xE5BE70", Offset = "0xE5AA70", VA = "0x180E5BE70")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170033E3 RID: 13283
			// (get) Token: 0x06015CB2 RID: 89266 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033E3")]
			public Image imagePotential
			{
				[Token(Token = "0x6015CB2")]
				[Address(RVA = "0xE5BED0", Offset = "0xE5AAD0", VA = "0x180E5BED0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06015CB3 RID: 89267 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CB3")]
			[Address(RVA = "0xE5BE10", Offset = "0xE5AA10", VA = "0x180E5BE10")]
			public CommonCharCardPotentialAssets()
			{
			}

			// Token: 0x0401A38C RID: 107404
			[Token(Token = "0x401A38C")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private bool _hidePotentialWhenIsZero;

			// Token: 0x0401A38D RID: 107405
			[Token(Token = "0x401A38D")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Image _imagePotential;

			// Token: 0x0401A38E RID: 107406
			[Token(Token = "0x401A38E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_hidePotentialWhenIsZero;

			// Token: 0x0401A38F RID: 107407
			[Token(Token = "0x401A38F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_imagePotential;

			// Token: 0x0401A390 RID: 107408
			[Token(Token = "0x401A390")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200357A RID: 13690
		[Token(Token = "0x200357A")]
		[Serializable]
		private class CommonCharCardPotentialComp : CommonCharCardView.CommonCharCardComp
		{
			// Token: 0x170033E4 RID: 13284
			// (get) Token: 0x06015CB4 RID: 89268 RVA: 0x0008DD98 File Offset: 0x0008BF98
			[Token(Token = "0x170033E4")]
			public override CommonCharCardView.CharCardCompType compType
			{
				[Token(Token = "0x6015CB4")]
				[Address(RVA = "0xE5BF90", Offset = "0xE5AB90", VA = "0x180E5BF90", Slot = "4")]
				get
				{
					return CommonCharCardView.CharCardCompType.NONE;
				}
			}

			// Token: 0x06015CB5 RID: 89269 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CB5")]
			[Address(RVA = "0xE5BF30", Offset = "0xE5AB30", VA = "0x180E5BF30")]
			public CommonCharCardPotentialComp()
			{
			}

			// Token: 0x0401A391 RID: 107409
			[Token(Token = "0x401A391")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_compType;

			// Token: 0x0401A392 RID: 107410
			[Token(Token = "0x401A392")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200357B RID: 13691
		[Token(Token = "0x200357B")]
		private class DefaultPotentialPlugin : CommonCharCardView.ICommonCharCardPlugin, IHotfixable
		{
			// Token: 0x06015CB6 RID: 89270 RVA: 0x0008DDB0 File Offset: 0x0008BFB0
			[Token(Token = "0x6015CB6")]
			[Address(RVA = "0xE6D100", Offset = "0xE6BD00", VA = "0x180E6D100", Slot = "4")]
			public bool CheckCacheCondition(ICharacterCardViewModel characterCardViewModel, DataBundle cacheConditions)
			{
				return default(bool);
			}

			// Token: 0x06015CB7 RID: 89271 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CB7")]
			[Address(RVA = "0xE6D010", Offset = "0xE6BC10", VA = "0x180E6D010", Slot = "5")]
			public void ApplyCacheCondition(ICharacterCardViewModel characterCardViewModel, DataBundle cacheConditions)
			{
			}

			// Token: 0x06015CB8 RID: 89272 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CB8")]
			[Address(RVA = "0xE6D200", Offset = "0xE6BE00", VA = "0x180E6D200", Slot = "6")]
			public void RendView(CommonCharCardView.CommonCharCardSingleTypeAssets cardAssets, ICharacterCardViewModel characterCardViewModel)
			{
			}

			// Token: 0x06015CB9 RID: 89273 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CB9")]
			[Address(RVA = "0xE6D420", Offset = "0xE6C020", VA = "0x180E6D420")]
			public DefaultPotentialPlugin()
			{
			}

			// Token: 0x0401A393 RID: 107411
			[Token(Token = "0x401A393")]
			private const string KEY_CACHE_POTENTIAL_LEVEL = "KEY_CACHE_POTENTIAL_LEVEL";

			// Token: 0x0401A394 RID: 107412
			[Token(Token = "0x401A394")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CheckCacheCondition;

			// Token: 0x0401A395 RID: 107413
			[Token(Token = "0x401A395")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ApplyCacheCondition;

			// Token: 0x0401A396 RID: 107414
			[Token(Token = "0x401A396")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RendView;

			// Token: 0x0401A397 RID: 107415
			[Token(Token = "0x401A397")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200357C RID: 13692
		[Token(Token = "0x200357C")]
		public enum ProfessionIconType
		{
			// Token: 0x0401A399 RID: 107417
			[Token(Token = "0x401A399")]
			V1,
			// Token: 0x0401A39A RID: 107418
			[Token(Token = "0x401A39A")]
			V2
		}

		// Token: 0x0200357D RID: 13693
		[Token(Token = "0x200357D")]
		[Serializable]
		public class CommonCharCardProfessionAssets : CommonCharCardView.CommonCharCardSingleTypeAssets
		{
			// Token: 0x170033E5 RID: 13285
			// (get) Token: 0x06015CBA RID: 89274 RVA: 0x0008DDC8 File Offset: 0x0008BFC8
			[Token(Token = "0x170033E5")]
			public CommonCharCardView.ProfessionIconType professionIconType
			{
				[Token(Token = "0x6015CBA")]
				[Address(RVA = "0xE5C0C0", Offset = "0xE5ACC0", VA = "0x180E5C0C0")]
				get
				{
					return CommonCharCardView.ProfessionIconType.V1;
				}
			}

			// Token: 0x170033E6 RID: 13286
			// (get) Token: 0x06015CBB RID: 89275 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033E6")]
			public Image imageProfession
			{
				[Token(Token = "0x6015CBB")]
				[Address(RVA = "0xE5C060", Offset = "0xE5AC60", VA = "0x180E5C060")]
				get
				{
					return null;
				}
			}

			// Token: 0x06015CBC RID: 89276 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CBC")]
			[Address(RVA = "0xE5BFF0", Offset = "0xE5ABF0", VA = "0x180E5BFF0")]
			public CommonCharCardProfessionAssets()
			{
			}

			// Token: 0x0401A39B RID: 107419
			[Token(Token = "0x401A39B")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private CommonCharCardView.ProfessionIconType _professionIconType;

			// Token: 0x0401A39C RID: 107420
			[Token(Token = "0x401A39C")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Image _imageProfession;

			// Token: 0x0401A39D RID: 107421
			[Token(Token = "0x401A39D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_professionIconType;

			// Token: 0x0401A39E RID: 107422
			[Token(Token = "0x401A39E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_imageProfession;

			// Token: 0x0401A39F RID: 107423
			[Token(Token = "0x401A39F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200357E RID: 13694
		[Token(Token = "0x200357E")]
		[Serializable]
		private class CommonCharCardProfessionComp : CommonCharCardView.CommonCharCardComp
		{
			// Token: 0x170033E7 RID: 13287
			// (get) Token: 0x06015CBD RID: 89277 RVA: 0x0008DDE0 File Offset: 0x0008BFE0
			[Token(Token = "0x170033E7")]
			public override CommonCharCardView.CharCardCompType compType
			{
				[Token(Token = "0x6015CBD")]
				[Address(RVA = "0xE5C180", Offset = "0xE5AD80", VA = "0x180E5C180", Slot = "4")]
				get
				{
					return CommonCharCardView.CharCardCompType.NONE;
				}
			}

			// Token: 0x06015CBE RID: 89278 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CBE")]
			[Address(RVA = "0xE5C120", Offset = "0xE5AD20", VA = "0x180E5C120")]
			public CommonCharCardProfessionComp()
			{
			}

			// Token: 0x0401A3A0 RID: 107424
			[Token(Token = "0x401A3A0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_compType;

			// Token: 0x0401A3A1 RID: 107425
			[Token(Token = "0x401A3A1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200357F RID: 13695
		[Token(Token = "0x200357F")]
		private class DefaultProfessionPlugin : CommonCharCardView.ICommonCharCardPlugin, IHotfixable
		{
			// Token: 0x06015CBF RID: 89279 RVA: 0x0008DDF8 File Offset: 0x0008BFF8
			[Token(Token = "0x6015CBF")]
			[Address(RVA = "0xE6D570", Offset = "0xE6C170", VA = "0x180E6D570", Slot = "4")]
			public bool CheckCacheCondition(ICharacterCardViewModel characterCardViewModel, DataBundle cacheConditions)
			{
				return default(bool);
			}

			// Token: 0x06015CC0 RID: 89280 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CC0")]
			[Address(RVA = "0xE6D480", Offset = "0xE6C080", VA = "0x180E6D480", Slot = "5")]
			public void ApplyCacheCondition(ICharacterCardViewModel characterCardViewModel, DataBundle cacheConditions)
			{
			}

			// Token: 0x06015CC1 RID: 89281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CC1")]
			[Address(RVA = "0xE6D680", Offset = "0xE6C280", VA = "0x180E6D680", Slot = "6")]
			public void RendView(CommonCharCardView.CommonCharCardSingleTypeAssets cardAssets, ICharacterCardViewModel characterCardViewModel)
			{
			}

			// Token: 0x06015CC2 RID: 89282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CC2")]
			[Address(RVA = "0xE6D8C0", Offset = "0xE6C4C0", VA = "0x180E6D8C0")]
			public DefaultProfessionPlugin()
			{
			}

			// Token: 0x0401A3A2 RID: 107426
			[Token(Token = "0x401A3A2")]
			private const string KEY_CACHE_PROFESSION_TYPE_INT = "KEY_CACHE_PROFESSION_TYPE_INT";

			// Token: 0x0401A3A3 RID: 107427
			[Token(Token = "0x401A3A3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CheckCacheCondition;

			// Token: 0x0401A3A4 RID: 107428
			[Token(Token = "0x401A3A4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ApplyCacheCondition;

			// Token: 0x0401A3A5 RID: 107429
			[Token(Token = "0x401A3A5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RendView;

			// Token: 0x0401A3A6 RID: 107430
			[Token(Token = "0x401A3A6")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003580 RID: 13696
		[Token(Token = "0x2003580")]
		[Serializable]
		public class CommonCharCardRarityRankAssets : CommonCharCardView.CommonCharCardSingleTypeAssets
		{
			// Token: 0x170033E8 RID: 13288
			// (get) Token: 0x06015CC3 RID: 89283 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033E8")]
			public UICharCardRankWidget stars
			{
				[Token(Token = "0x6015CC3")]
				[Address(RVA = "0xE5C2A0", Offset = "0xE5AEA0", VA = "0x180E5C2A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170033E9 RID: 13289
			// (get) Token: 0x06015CC4 RID: 89284 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033E9")]
			public UICharRarityImage[] panelRarityLights
			{
				[Token(Token = "0x6015CC4")]
				[Address(RVA = "0xE5C240", Offset = "0xE5AE40", VA = "0x180E5C240")]
				get
				{
					return null;
				}
			}

			// Token: 0x06015CC5 RID: 89285 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CC5")]
			[Address(RVA = "0xE5C1E0", Offset = "0xE5ADE0", VA = "0x180E5C1E0")]
			public CommonCharCardRarityRankAssets()
			{
			}

			// Token: 0x0401A3A7 RID: 107431
			[Token(Token = "0x401A3A7")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private UICharCardRankWidget _stars;

			// Token: 0x0401A3A8 RID: 107432
			[Token(Token = "0x401A3A8")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private UICharRarityImage[] _panelRarityLights;

			// Token: 0x0401A3A9 RID: 107433
			[Token(Token = "0x401A3A9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_stars;

			// Token: 0x0401A3AA RID: 107434
			[Token(Token = "0x401A3AA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_panelRarityLights;

			// Token: 0x0401A3AB RID: 107435
			[Token(Token = "0x401A3AB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003581 RID: 13697
		[Token(Token = "0x2003581")]
		[Serializable]
		private class CommonCharCardRarityRankComp : CommonCharCardView.CommonCharCardComp
		{
			// Token: 0x170033EA RID: 13290
			// (get) Token: 0x06015CC6 RID: 89286 RVA: 0x0008DE10 File Offset: 0x0008C010
			[Token(Token = "0x170033EA")]
			public override CommonCharCardView.CharCardCompType compType
			{
				[Token(Token = "0x6015CC6")]
				[Address(RVA = "0xE5C360", Offset = "0xE5AF60", VA = "0x180E5C360", Slot = "4")]
				get
				{
					return CommonCharCardView.CharCardCompType.NONE;
				}
			}

			// Token: 0x06015CC7 RID: 89287 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CC7")]
			[Address(RVA = "0xE5C300", Offset = "0xE5AF00", VA = "0x180E5C300")]
			public CommonCharCardRarityRankComp()
			{
			}

			// Token: 0x0401A3AC RID: 107436
			[Token(Token = "0x401A3AC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_compType;

			// Token: 0x0401A3AD RID: 107437
			[Token(Token = "0x401A3AD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003582 RID: 13698
		[Token(Token = "0x2003582")]
		private class DefaultRarityRankPlugin : CommonCharCardView.ICommonCharCardPlugin, IHotfixable
		{
			// Token: 0x06015CC8 RID: 89288 RVA: 0x0008DE28 File Offset: 0x0008C028
			[Token(Token = "0x6015CC8")]
			[Address(RVA = "0xE6DA10", Offset = "0xE6C610", VA = "0x180E6DA10", Slot = "4")]
			public bool CheckCacheCondition(ICharacterCardViewModel characterCardViewModel, DataBundle cacheConditions)
			{
				return default(bool);
			}

			// Token: 0x06015CC9 RID: 89289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CC9")]
			[Address(RVA = "0xE6D920", Offset = "0xE6C520", VA = "0x180E6D920", Slot = "5")]
			public void ApplyCacheCondition(ICharacterCardViewModel characterCardViewModel, DataBundle cacheConditions)
			{
			}

			// Token: 0x06015CCA RID: 89290 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CCA")]
			[Address(RVA = "0xE6DB20", Offset = "0xE6C720", VA = "0x180E6DB20", Slot = "6")]
			public void RendView(CommonCharCardView.CommonCharCardSingleTypeAssets cardAssets, ICharacterCardViewModel characterCardViewModel)
			{
			}

			// Token: 0x06015CCB RID: 89291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CCB")]
			[Address(RVA = "0xE6DDC0", Offset = "0xE6C9C0", VA = "0x180E6DDC0")]
			public DefaultRarityRankPlugin()
			{
			}

			// Token: 0x0401A3AE RID: 107438
			[Token(Token = "0x401A3AE")]
			private const string KEY_CACHE_RANK_STAR = "KEY_CACHE_RANK_STAR";

			// Token: 0x0401A3AF RID: 107439
			[Token(Token = "0x401A3AF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CheckCacheCondition;

			// Token: 0x0401A3B0 RID: 107440
			[Token(Token = "0x401A3B0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ApplyCacheCondition;

			// Token: 0x0401A3B1 RID: 107441
			[Token(Token = "0x401A3B1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RendView;

			// Token: 0x0401A3B2 RID: 107442
			[Token(Token = "0x401A3B2")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003583 RID: 13699
		[Token(Token = "0x2003583")]
		[Serializable]
		public class CommonCharCardSkillAssets : CommonCharCardView.CommonCharCardSingleTypeAssets
		{
			// Token: 0x170033EB RID: 13291
			// (get) Token: 0x06015CCC RID: 89292 RVA: 0x0008DE40 File Offset: 0x0008C040
			[Token(Token = "0x170033EB")]
			public bool showSkillLevel
			{
				[Token(Token = "0x6015CCC")]
				[Address(RVA = "0xE5C5A0", Offset = "0xE5B1A0", VA = "0x180E5C5A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170033EC RID: 13292
			// (get) Token: 0x06015CCD RID: 89293 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033EC")]
			public GameObject panelNoSkill
			{
				[Token(Token = "0x6015CCD")]
				[Address(RVA = "0xE5C4E0", Offset = "0xE5B0E0", VA = "0x180E5C4E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170033ED RID: 13293
			// (get) Token: 0x06015CCE RID: 89294 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033ED")]
			public GameObject panelSkill
			{
				[Token(Token = "0x6015CCE")]
				[Address(RVA = "0xE5C540", Offset = "0xE5B140", VA = "0x180E5C540")]
				get
				{
					return null;
				}
			}

			// Token: 0x170033EE RID: 13294
			// (get) Token: 0x06015CCF RID: 89295 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033EE")]
			public Image imageSkill
			{
				[Token(Token = "0x6015CCF")]
				[Address(RVA = "0xE5C480", Offset = "0xE5B080", VA = "0x180E5C480")]
				get
				{
					return null;
				}
			}

			// Token: 0x170033EF RID: 13295
			// (get) Token: 0x06015CD0 RID: 89296 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033EF")]
			public Text textSkillLevel
			{
				[Token(Token = "0x6015CD0")]
				[Address(RVA = "0xE5C600", Offset = "0xE5B200", VA = "0x180E5C600")]
				get
				{
					return null;
				}
			}

			// Token: 0x170033F0 RID: 13296
			// (get) Token: 0x06015CD1 RID: 89297 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170033F0")]
			public Image imageSkillSpecializeLv
			{
				[Token(Token = "0x6015CD1")]
				[Address(RVA = "0xE5C420", Offset = "0xE5B020", VA = "0x180E5C420")]
				get
				{
					return null;
				}
			}

			// Token: 0x06015CD2 RID: 89298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CD2")]
			[Address(RVA = "0xE5C3C0", Offset = "0xE5AFC0", VA = "0x180E5C3C0")]
			public CommonCharCardSkillAssets()
			{
			}

			// Token: 0x0401A3B3 RID: 107443
			[Token(Token = "0x401A3B3")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private bool _showSkillLevel;

			// Token: 0x0401A3B4 RID: 107444
			[Token(Token = "0x401A3B4")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private GameObject _panelNoSkill;

			// Token: 0x0401A3B5 RID: 107445
			[Token(Token = "0x401A3B5")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private GameObject _panelSkill;

			// Token: 0x0401A3B6 RID: 107446
			[Token(Token = "0x401A3B6")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private Image _imageSkill;

			// Token: 0x0401A3B7 RID: 107447
			[Token(Token = "0x401A3B7")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private Text _textSkillLevel;

			// Token: 0x0401A3B8 RID: 107448
			[Token(Token = "0x401A3B8")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private Image _imageSkillSpecializeLv;

			// Token: 0x0401A3B9 RID: 107449
			[Token(Token = "0x401A3B9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_showSkillLevel;

			// Token: 0x0401A3BA RID: 107450
			[Token(Token = "0x401A3BA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_panelNoSkill;

			// Token: 0x0401A3BB RID: 107451
			[Token(Token = "0x401A3BB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_panelSkill;

			// Token: 0x0401A3BC RID: 107452
			[Token(Token = "0x401A3BC")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_imageSkill;

			// Token: 0x0401A3BD RID: 107453
			[Token(Token = "0x401A3BD")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_textSkillLevel;

			// Token: 0x0401A3BE RID: 107454
			[Token(Token = "0x401A3BE")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_imageSkillSpecializeLv;

			// Token: 0x0401A3BF RID: 107455
			[Token(Token = "0x401A3BF")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003584 RID: 13700
		[Token(Token = "0x2003584")]
		[Serializable]
		private class CommonCharCardSkillComp : CommonCharCardView.CommonCharCardComp
		{
			// Token: 0x170033F1 RID: 13297
			// (get) Token: 0x06015CD3 RID: 89299 RVA: 0x0008DE58 File Offset: 0x0008C058
			[Token(Token = "0x170033F1")]
			public override CommonCharCardView.CharCardCompType compType
			{
				[Token(Token = "0x6015CD3")]
				[Address(RVA = "0xE5C6C0", Offset = "0xE5B2C0", VA = "0x180E5C6C0", Slot = "4")]
				get
				{
					return CommonCharCardView.CharCardCompType.NONE;
				}
			}

			// Token: 0x06015CD4 RID: 89300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CD4")]
			[Address(RVA = "0xE5C660", Offset = "0xE5B260", VA = "0x180E5C660")]
			public CommonCharCardSkillComp()
			{
			}

			// Token: 0x0401A3C0 RID: 107456
			[Token(Token = "0x401A3C0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_compType;

			// Token: 0x0401A3C1 RID: 107457
			[Token(Token = "0x401A3C1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003585 RID: 13701
		[Token(Token = "0x2003585")]
		private class DefaultSkillPlugin : CommonCharCardView.ICommonCharCardPlugin, IHotfixable
		{
			// Token: 0x06015CD5 RID: 89301 RVA: 0x0008DE70 File Offset: 0x0008C070
			[Token(Token = "0x6015CD5")]
			[Address(RVA = "0xE6FE70", Offset = "0xE6EA70", VA = "0x180E6FE70", Slot = "4")]
			public bool CheckCacheCondition(ICharacterCardViewModel characterCardViewModel, DataBundle cacheConditions)
			{
				return default(bool);
			}

			// Token: 0x06015CD6 RID: 89302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CD6")]
			[Address(RVA = "0xE6FCF0", Offset = "0xE6E8F0", VA = "0x180E6FCF0", Slot = "5")]
			public void ApplyCacheCondition(ICharacterCardViewModel characterCardViewModel, DataBundle cacheConditions)
			{
			}

			// Token: 0x06015CD7 RID: 89303 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CD7")]
			[Address(RVA = "0xE70100", Offset = "0xE6ED00", VA = "0x180E70100", Slot = "6")]
			public void RendView(CommonCharCardView.CommonCharCardSingleTypeAssets cardAssets, ICharacterCardViewModel characterCardViewModel)
			{
			}

			// Token: 0x06015CD8 RID: 89304 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015CD8")]
			[Address(RVA = "0xE70490", Offset = "0xE6F090", VA = "0x180E70490")]
			public DefaultSkillPlugin()
			{
			}

			// Token: 0x0401A3C2 RID: 107458
			[Token(Token = "0x401A3C2")]
			private const string KEY_CACHE_SKILL_ID = "KEY_CACHE_SKILL_ID";

			// Token: 0x0401A3C3 RID: 107459
			[Token(Token = "0x401A3C3")]
			private const string KEY_CACHE_SKILL_LEVEL = "KEY_CACHE_SKILL_LEVEL";

			// Token: 0x0401A3C4 RID: 107460
			[Token(Token = "0x401A3C4")]
			private const string KEY_CACHE_SKILL_SPEC_LEVEL = "KEY_CACHE_SKILL_SPEC_LEVEL";

			// Token: 0x0401A3C5 RID: 107461
			[Token(Token = "0x401A3C5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CheckCacheCondition;

			// Token: 0x0401A3C6 RID: 107462
			[Token(Token = "0x401A3C6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ApplyCacheCondition;

			// Token: 0x0401A3C7 RID: 107463
			[Token(Token = "0x401A3C7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RendView;

			// Token: 0x0401A3C8 RID: 107464
			[Token(Token = "0x401A3C8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
