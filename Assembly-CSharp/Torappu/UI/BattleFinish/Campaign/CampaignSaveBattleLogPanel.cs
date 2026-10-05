using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.BattleFinish.Campaign
{
	// Token: 0x02006229 RID: 25129
	[Token(Token = "0x2006229")]
	public class CampaignSaveBattleLogPanel : MonoBehaviour
	{
		// Token: 0x1700558C RID: 21900
		// (get) Token: 0x06024415 RID: 148501 RVA: 0x000C3948 File Offset: 0x000C1B48
		// (set) Token: 0x06024416 RID: 148502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700558C")]
		public bool isOn
		{
			[Token(Token = "0x6024415")]
			[Address(RVA = "0x1F1AB90", Offset = "0x1F19790", VA = "0x181F1AB90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6024416")]
			[Address(RVA = "0x1F1AC00", Offset = "0x1F19800", VA = "0x181F1AC00")]
			set
			{
			}
		}

		// Token: 0x1700558D RID: 21901
		// (get) Token: 0x06024417 RID: 148503 RVA: 0x000C3960 File Offset: 0x000C1B60
		// (set) Token: 0x06024418 RID: 148504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700558D")]
		public bool interactable
		{
			[Token(Token = "0x6024417")]
			[Address(RVA = "0x1F1AB40", Offset = "0x1F19740", VA = "0x181F1AB40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6024418")]
			[Address(RVA = "0x1F1ABB0", Offset = "0x1F197B0", VA = "0x181F1ABB0")]
			set
			{
			}
		}

		// Token: 0x06024419 RID: 148505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024419")]
		[Address(RVA = "0x1F1A0E0", Offset = "0x1F18CE0", VA = "0x181F1A0E0")]
		public void Render(AutoBattleConvertUtil.BattleLog log, bool isNew)
		{
		}

		// Token: 0x0602441A RID: 148506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602441A")]
		[Address(RVA = "0x1F1A8F0", Offset = "0x1F194F0", VA = "0x181F1A8F0")]
		private static void _LoadPlayerCharsToShow(List<BattleLogger.CharInfo> squadInJournal, ref List<BattleLogger.CharInfo> squadToShow)
		{
		}

		// Token: 0x0602441B RID: 148507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602441B")]
		[Address(RVA = "0x1F1A840", Offset = "0x1F19440", VA = "0x181F1A840")]
		private string _FormatVersionStr(uint version)
		{
			return null;
		}

		// Token: 0x0602441C RID: 148508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602441C")]
		[Address(RVA = "0x1F1A780", Offset = "0x1F19380", VA = "0x181F1A780")]
		private string _FormatPlayTimeStr(float playTime)
		{
			return null;
		}

		// Token: 0x0602441D RID: 148509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602441D")]
		[Address(RVA = "0x1F1AAB0", Offset = "0x1F196B0", VA = "0x181F1AAB0")]
		public CampaignSaveBattleLogPanel()
		{
		}

		// Token: 0x04032691 RID: 206481
		[Token(Token = "0x4032691")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Toggle _toggle;

		// Token: 0x04032692 RID: 206482
		[Token(Token = "0x4032692")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _versionText;

		// Token: 0x04032693 RID: 206483
		[Token(Token = "0x4032693")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _savetimeText;

		// Token: 0x04032694 RID: 206484
		[Token(Token = "0x4032694")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _remainingCostText;

		// Token: 0x04032695 RID: 206485
		[Token(Token = "0x4032695")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _playTimeText;

		// Token: 0x04032696 RID: 206486
		[Token(Token = "0x4032696")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _lifePointText;

		// Token: 0x04032697 RID: 206487
		[Token(Token = "0x4032697")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _missedEnemiesCntText;

		// Token: 0x04032698 RID: 206488
		[Token(Token = "0x4032698")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _killedEnemiesCntText;

		// Token: 0x04032699 RID: 206489
		[Token(Token = "0x4032699")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _newHint;

		// Token: 0x0403269A RID: 206490
		[Token(Token = "0x403269A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private EasyInstancePool _charCardPool;

		// Token: 0x0403269B RID: 206491
		[Token(Token = "0x403269B")]
		[FieldOffset(Offset = "0x68")]
		private List<BattleLogger.CharInfo> m_playerChars;
	}
}
