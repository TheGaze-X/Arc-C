using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.BattleFinish.Campaign
{
	// Token: 0x02006227 RID: 25127
	[Token(Token = "0x2006227")]
	public class CampaignSaveBattleLogCharCardView : MonoBehaviour
	{
		// Token: 0x0602440E RID: 148494 RVA: 0x000C3930 File Offset: 0x000C1B30
		[Token(Token = "0x602440E")]
		[Address(RVA = "0x1F19680", Offset = "0x1F18280", VA = "0x181F19680")]
		public bool Render(BattleLogger.CharInfo charInfo)
		{
			return default(bool);
		}

		// Token: 0x0602440F RID: 148495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602440F")]
		[Address(RVA = "0x1F19B60", Offset = "0x1F18760", VA = "0x181F19B60")]
		private void _SetAvatar(string charId, string skinId)
		{
		}

		// Token: 0x06024410 RID: 148496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024410")]
		[Address(RVA = "0x1F19F10", Offset = "0x1F18B10", VA = "0x181F19F10")]
		private void _SetProfession(ProfessionCategory profession)
		{
		}

		// Token: 0x06024411 RID: 148497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024411")]
		[Address(RVA = "0x1F1A020", Offset = "0x1F18C20", VA = "0x181F1A020")]
		private void _SetRarityRank(RarityRank rarity)
		{
		}

		// Token: 0x06024412 RID: 148498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024412")]
		[Address(RVA = "0x1F19C90", Offset = "0x1F18890", VA = "0x181F19C90")]
		private void _SetCostValue(CharacterData charData, BattleLogger.CharInfo charInfo, string charId)
		{
		}

		// Token: 0x06024413 RID: 148499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024413")]
		[Address(RVA = "0x1F1A060", Offset = "0x1F18C60", VA = "0x181F1A060")]
		public CampaignSaveBattleLogCharCardView()
		{
		}

		// Token: 0x04032687 RID: 206471
		[Token(Token = "0x4032687")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Widgets")]
		private Image _avatarImage;

		// Token: 0x04032688 RID: 206472
		[Token(Token = "0x4032688")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Widgets")]
		private Image _professionIcon;

		// Token: 0x04032689 RID: 206473
		[Token(Token = "0x4032689")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Widgets")]
		private Image _professionMark;

		// Token: 0x0403268A RID: 206474
		[Token(Token = "0x403268A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Widgets")]
		private Image _rarityMark;

		// Token: 0x0403268B RID: 206475
		[Token(Token = "0x403268B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Widgets")]
		private Text _costLabel;

		// Token: 0x0403268C RID: 206476
		[Token(Token = "0x403268C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Config")]
		private CampaignSaveBattleLogCharCardView.ProfessionData[] _professionData;

		// Token: 0x0403268D RID: 206477
		[Token(Token = "0x403268D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Config")]
		[Collection(6)]
		private Sprite[] _rarityColors;

		// Token: 0x02006228 RID: 25128
		[Token(Token = "0x2006228")]
		[Serializable]
		public struct ProfessionData
		{
			// Token: 0x06024414 RID: 148500 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024414")]
			[Address(RVA = "0x1F1C1F0", Offset = "0x1F1ADF0", VA = "0x181F1C1F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0403268E RID: 206478
			[Token(Token = "0x403268E")]
			[FieldOffset(Offset = "0x0")]
			public ProfessionCategory profession;

			// Token: 0x0403268F RID: 206479
			[Token(Token = "0x403268F")]
			[FieldOffset(Offset = "0x8")]
			public Sprite sprite;

			// Token: 0x04032690 RID: 206480
			[Token(Token = "0x4032690")]
			[FieldOffset(Offset = "0x10")]
			public Color color;
		}
	}
}
