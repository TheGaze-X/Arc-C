using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.BattleFinish;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x020047A4 RID: 18340
	[Token(Token = "0x20047A4")]
	public class RecalRuneBattleFinishView : DynBattleFinishView
	{
		// Token: 0x0601BC6B RID: 113771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC6B")]
		[Address(RVA = "0x152BAE0", Offset = "0x152A6E0", VA = "0x18152BAE0")]
		public void OnCloseClick()
		{
		}

		// Token: 0x0601BC6C RID: 113772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC6C")]
		[Address(RVA = "0x152BB40", Offset = "0x152A740", VA = "0x18152BB40", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601BC6D RID: 113773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC6D")]
		[Address(RVA = "0x152CAC0", Offset = "0x152B6C0", VA = "0x18152CAC0")]
		private void _RenderStage(RecalRuneStageData stageData, int score, bool newRecord, int hp, long ts)
		{
		}

		// Token: 0x0601BC6E RID: 113774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC6E")]
		[Address(RVA = "0x152C230", Offset = "0x152AE30", VA = "0x18152C230")]
		private void _RenderRunes(RecalRuneStageData stageData, List<string> runeIdList)
		{
		}

		// Token: 0x0601BC6F RID: 113775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC6F")]
		[Address(RVA = "0x152C580", Offset = "0x152B180", VA = "0x18152C580")]
		private void _RenderSquad()
		{
		}

		// Token: 0x0601BC70 RID: 113776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC70")]
		[Address(RVA = "0x152BF10", Offset = "0x152AB10", VA = "0x18152BF10")]
		private void _PlayEnter()
		{
		}

		// Token: 0x0601BC71 RID: 113777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC71")]
		[Address(RVA = "0x152C000", Offset = "0x152AC00", VA = "0x18152C000")]
		private void _PlayIllustVoice()
		{
		}

		// Token: 0x0601BC72 RID: 113778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC72")]
		[Address(RVA = "0x152CE00", Offset = "0x152BA00", VA = "0x18152CE00")]
		public RecalRuneBattleFinishView()
		{
		}

		// Token: 0x040241A9 RID: 147881
		[Token(Token = "0x40241A9")]
		private const string INVALID_SCORE_STRING = "-";

		// Token: 0x040241AA RID: 147882
		[Token(Token = "0x40241AA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _illustHolder;

		// Token: 0x040241AB RID: 147883
		[Token(Token = "0x40241AB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<RecalRuneBattleFinishView.CardHolder> _squadCardHolders;

		// Token: 0x040241AC RID: 147884
		[Token(Token = "0x40241AC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RecalRuneBattleFinishView.CardHolder _assistCardHolder;

		// Token: 0x040241AD RID: 147885
		[Token(Token = "0x40241AD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RecalRuneBattleFinishCharView _cardPrefab;

		// Token: 0x040241AE RID: 147886
		[Token(Token = "0x40241AE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RecalRuneBattleFinishRuneListAdapter _runeAdapter;

		// Token: 0x040241AF RID: 147887
		[Token(Token = "0x40241AF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _scoreText;

		// Token: 0x040241B0 RID: 147888
		[Token(Token = "0x40241B0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _normalRecordVariant;

		// Token: 0x040241B1 RID: 147889
		[Token(Token = "0x40241B1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _newRecordVariant;

		// Token: 0x040241B2 RID: 147890
		[Token(Token = "0x40241B2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _juniorEffectVariant;

		// Token: 0x040241B3 RID: 147891
		[Token(Token = "0x40241B3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _seniorEffectVariant;

		// Token: 0x040241B4 RID: 147892
		[Token(Token = "0x40241B4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _hpText;

		// Token: 0x040241B5 RID: 147893
		[Token(Token = "0x40241B5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _timeText;

		// Token: 0x040241B6 RID: 147894
		[Token(Token = "0x40241B6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _idText;

		// Token: 0x040241B7 RID: 147895
		[Token(Token = "0x40241B7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _levelCodeText;

		// Token: 0x040241B8 RID: 147896
		[Token(Token = "0x40241B8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _levelNameText;

		// Token: 0x040241B9 RID: 147897
		[Token(Token = "0x40241B9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _enterAnimation;

		// Token: 0x040241BA RID: 147898
		[Token(Token = "0x40241BA")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_passSeniorScore;

		// Token: 0x040241BB RID: 147899
		[Token(Token = "0x40241BB")]
		[FieldOffset(Offset = "0xB0")]
		private CharUISkinStruct m_randomIllust;

		// Token: 0x040241BC RID: 147900
		[Token(Token = "0x40241BC")]
		[FieldOffset(Offset = "0xC8")]
		private AnimationWrapper _enterWrapper;

		// Token: 0x040241BD RID: 147901
		[Token(Token = "0x40241BD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCloseClick;

		// Token: 0x040241BE RID: 147902
		[Token(Token = "0x40241BE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040241BF RID: 147903
		[Token(Token = "0x40241BF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderStage;

		// Token: 0x040241C0 RID: 147904
		[Token(Token = "0x40241C0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderRunes;

		// Token: 0x040241C1 RID: 147905
		[Token(Token = "0x40241C1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderSquad;

		// Token: 0x040241C2 RID: 147906
		[Token(Token = "0x40241C2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayEnter;

		// Token: 0x040241C3 RID: 147907
		[Token(Token = "0x40241C3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayIllustVoice;

		// Token: 0x040241C4 RID: 147908
		[Token(Token = "0x40241C4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020047A5 RID: 18341
		[Token(Token = "0x20047A5")]
		public enum RuneItemSortType
		{
			// Token: 0x040241C6 RID: 147910
			[Token(Token = "0x40241C6")]
			OTHER,
			// Token: 0x040241C7 RID: 147911
			[Token(Token = "0x40241C7")]
			ESSENTIAL_EXCLUSIVE,
			// Token: 0x040241C8 RID: 147912
			[Token(Token = "0x40241C8")]
			ESSENTIAL_FIXED
		}

		// Token: 0x020047A6 RID: 18342
		[Token(Token = "0x20047A6")]
		public struct RuneItem : IComparable<RecalRuneBattleFinishView.RuneItem>
		{
			// Token: 0x0601BC73 RID: 113779 RVA: 0x000A6368 File Offset: 0x000A4568
			[Token(Token = "0x601BC73")]
			[Address(RVA = "0x1534F90", Offset = "0x1533B90", VA = "0x181534F90", Slot = "4")]
			public int CompareTo(RecalRuneBattleFinishView.RuneItem other)
			{
				return 0;
			}

			// Token: 0x040241C9 RID: 147913
			[Token(Token = "0x40241C9")]
			[FieldOffset(Offset = "0x0")]
			public string runeId;

			// Token: 0x040241CA RID: 147914
			[Token(Token = "0x40241CA")]
			[FieldOffset(Offset = "0x8")]
			public int sortId;

			// Token: 0x040241CB RID: 147915
			[Token(Token = "0x40241CB")]
			[FieldOffset(Offset = "0xC")]
			public RecalRuneBattleFinishView.RuneItemSortType type;

			// Token: 0x040241CC RID: 147916
			[Token(Token = "0x40241CC")]
			[FieldOffset(Offset = "0x10")]
			public string iconId;

			// Token: 0x040241CD RID: 147917
			[Token(Token = "0x40241CD")]
			[FieldOffset(Offset = "0x18")]
			public int score;
		}

		// Token: 0x020047A7 RID: 18343
		[Token(Token = "0x20047A7")]
		[Serializable]
		private class CardHolder
		{
			// Token: 0x0601BC74 RID: 113780 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BC74")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CardHolder()
			{
			}

			// Token: 0x040241CE RID: 147918
			[Token(Token = "0x40241CE")]
			[FieldOffset(Offset = "0x10")]
			public RectTransform root;

			// Token: 0x040241CF RID: 147919
			[Token(Token = "0x40241CF")]
			[FieldOffset(Offset = "0x18")]
			public GameObject emptyState;
		}
	}
}
