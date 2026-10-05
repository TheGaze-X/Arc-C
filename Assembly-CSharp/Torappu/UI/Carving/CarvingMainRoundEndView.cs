using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006089 RID: 24713
	[Token(Token = "0x2006089")]
	public class CarvingMainRoundEndView : DataBinder<CarvingMainRoundEndProperty>
	{
		// Token: 0x06023BE0 RID: 146400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BE0")]
		[Address(RVA = "0x1E631E0", Offset = "0x1E61DE0", VA = "0x181E631E0", Slot = "7")]
		public override void OnValueChanged(CarvingMainRoundEndProperty property)
		{
		}

		// Token: 0x06023BE1 RID: 146401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BE1")]
		[Address(RVA = "0x1E63140", Offset = "0x1E61D40", VA = "0x181E63140")]
		public void ClearTween()
		{
		}

		// Token: 0x06023BE2 RID: 146402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BE2")]
		[Address(RVA = "0x1E63900", Offset = "0x1E62500", VA = "0x181E63900")]
		private void _GenerateEnterAnim(bool passRound, int curScore)
		{
		}

		// Token: 0x06023BE3 RID: 146403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023BE3")]
		[Address(RVA = "0x1E63AE0", Offset = "0x1E626E0", VA = "0x181E63AE0")]
		public CarvingMainRoundEndView()
		{
		}

		// Token: 0x04031897 RID: 202903
		[Token(Token = "0x4031897")]
		private const string TARGET_ROUND_TEXT_FORMAT = "/{0}";

		// Token: 0x04031898 RID: 202904
		[Token(Token = "0x4031898")]
		private const string COIN_TEXT_FORMAT = "+{0}";

		// Token: 0x04031899 RID: 202905
		[Token(Token = "0x4031899")]
		private const int SCORE_ANIM_START_VALUE = 0;

		// Token: 0x0403189A RID: 202906
		[Token(Token = "0x403189A")]
		private const float SCORE_ANIM_FADETIME = 0.8f;

		// Token: 0x0403189B RID: 202907
		[Token(Token = "0x403189B")]
		private const float SCORE_ANIM_DELAY = 0.1f;

		// Token: 0x0403189C RID: 202908
		[Token(Token = "0x403189C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _achieveGoalToggle;

		// Token: 0x0403189D RID: 202909
		[Token(Token = "0x403189D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _targetScoreText;

		// Token: 0x0403189E RID: 202910
		[Token(Token = "0x403189E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _curScoreText;

		// Token: 0x0403189F RID: 202911
		[Token(Token = "0x403189F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _curRoundText;

		// Token: 0x040318A0 RID: 202912
		[Token(Token = "0x40318A0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _targetRoundText;

		// Token: 0x040318A1 RID: 202913
		[Token(Token = "0x40318A1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _coinText;

		// Token: 0x040318A2 RID: 202914
		[Token(Token = "0x40318A2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _levelClearPanel;

		// Token: 0x040318A3 RID: 202915
		[Token(Token = "0x40318A3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _unlimitedNotice;

		// Token: 0x040318A4 RID: 202916
		[Token(Token = "0x40318A4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _coinPart;

		// Token: 0x040318A5 RID: 202917
		[Token(Token = "0x40318A5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _nextRoundBtn;

		// Token: 0x040318A6 RID: 202918
		[Token(Token = "0x40318A6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _endClassBtn;

		// Token: 0x040318A7 RID: 202919
		[Token(Token = "0x40318A7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _successEnterAnim;

		// Token: 0x040318A8 RID: 202920
		[Token(Token = "0x40318A8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _failEnterAnim;

		// Token: 0x040318A9 RID: 202921
		[Token(Token = "0x40318A9")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_enterAnim;

		// Token: 0x040318AA RID: 202922
		[Token(Token = "0x40318AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040318AB RID: 202923
		[Token(Token = "0x40318AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ClearTween;

		// Token: 0x040318AC RID: 202924
		[Token(Token = "0x40318AC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GenerateEnterAnim;

		// Token: 0x040318AD RID: 202925
		[Token(Token = "0x40318AD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
