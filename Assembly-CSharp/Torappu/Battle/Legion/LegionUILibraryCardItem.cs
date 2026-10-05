using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.Legion
{
	// Token: 0x02002A1C RID: 10780
	[Token(Token = "0x2002A1C")]
	public class LegionUILibraryCardItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06011E42 RID: 73282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E42")]
		[Address(RVA = "0x9CA740", Offset = "0x9C9340", VA = "0x1809CA740")]
		public void ApplyData(Deck.Card card)
		{
		}

		// Token: 0x06011E43 RID: 73283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E43")]
		[Address(RVA = "0x9CAD60", Offset = "0x9C9960", VA = "0x1809CAD60")]
		private void _SetProfession(ProfessionCategory profession)
		{
		}

		// Token: 0x06011E44 RID: 73284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E44")]
		[Address(RVA = "0x9CAEC0", Offset = "0x9C9AC0", VA = "0x1809CAEC0")]
		private void _SetRarityRank(RarityRank rarity)
		{
		}

		// Token: 0x06011E45 RID: 73285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E45")]
		[Address(RVA = "0x9CABE0", Offset = "0x9C97E0", VA = "0x1809CABE0")]
		private void _SetEvolvePhase(EvolvePhase evolvePhase)
		{
		}

		// Token: 0x06011E46 RID: 73286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E46")]
		[Address(RVA = "0x9CAF60", Offset = "0x9C9B60", VA = "0x1809CAF60")]
		public LegionUILibraryCardItem()
		{
		}

		// Token: 0x0401422C RID: 82476
		[Token(Token = "0x401422C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Widgets")]
		private Image _avatarImage;

		// Token: 0x0401422D RID: 82477
		[Token(Token = "0x401422D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Widgets")]
		private Image _professionIcon;

		// Token: 0x0401422E RID: 82478
		[Token(Token = "0x401422E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Widgets")]
		private Image _professionMark;

		// Token: 0x0401422F RID: 82479
		[Token(Token = "0x401422F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Widgets")]
		private Image _rarityMark;

		// Token: 0x04014230 RID: 82480
		[Token(Token = "0x4014230")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Widgets")]
		private Text _costLabel;

		// Token: 0x04014231 RID: 82481
		[Token(Token = "0x4014231")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Widgets")]
		private Image _eliteIcon;

		// Token: 0x04014232 RID: 82482
		[Token(Token = "0x4014232")]
		[FieldOffset(Offset = "0x48")]
		[FormerlySerializedAs("_professionSprites")]
		[SerializeField]
		[Group("Config")]
		private LegionUILibraryCardItem.ProfessionData[] _professionData;

		// Token: 0x04014233 RID: 82483
		[Token(Token = "0x4014233")]
		[FieldOffset(Offset = "0x50")]
		[Group("Config")]
		[Collection(6)]
		[SerializeField]
		private Sprite[] _rarityColors;

		// Token: 0x04014234 RID: 82484
		[Token(Token = "0x4014234")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Config")]
		[Collection(4)]
		private Sprite[] _evolveIcons;

		// Token: 0x04014235 RID: 82485
		[Token(Token = "0x4014235")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x04014236 RID: 82486
		[Token(Token = "0x4014236")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetProfession;

		// Token: 0x04014237 RID: 82487
		[Token(Token = "0x4014237")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetRarityRank;

		// Token: 0x04014238 RID: 82488
		[Token(Token = "0x4014238")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetEvolvePhase;

		// Token: 0x04014239 RID: 82489
		[Token(Token = "0x4014239")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002A1D RID: 10781
		[Token(Token = "0x2002A1D")]
		[Serializable]
		public struct ProfessionData
		{
			// Token: 0x06011E47 RID: 73287 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6011E47")]
			[Address(RVA = "0x9CDDF0", Offset = "0x9CC9F0", VA = "0x1809CDDF0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0401423A RID: 82490
			[Token(Token = "0x401423A")]
			[FieldOffset(Offset = "0x0")]
			public ProfessionCategory profession;

			// Token: 0x0401423B RID: 82491
			[Token(Token = "0x401423B")]
			[FieldOffset(Offset = "0x8")]
			public Sprite sprite;

			// Token: 0x0401423C RID: 82492
			[Token(Token = "0x401423C")]
			[FieldOffset(Offset = "0x10")]
			public Color color;
		}
	}
}
