using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.GameCity
{
	// Token: 0x0200342D RID: 13357
	[Token(Token = "0x200342D")]
	public class GameCityBattleScoreUIPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601563D RID: 87613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601563D")]
		[Address(RVA = "0xDCDA60", Offset = "0xDCC660", VA = "0x180DCDA60")]
		public void OnPanelShownScore(int score, bool isRainbow)
		{
		}

		// Token: 0x0601563E RID: 87614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601563E")]
		[Address(RVA = "0xDCDD00", Offset = "0xDCC900", VA = "0x180DCDD00")]
		public void PlayForOnce()
		{
		}

		// Token: 0x0601563F RID: 87615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601563F")]
		[Address(RVA = "0xDCDE40", Offset = "0xDCCA40", VA = "0x180DCDE40")]
		private void PlayOutAnim()
		{
		}

		// Token: 0x06015640 RID: 87616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015640")]
		[Address(RVA = "0xDCDC20", Offset = "0xDCC820", VA = "0x180DCDC20")]
		public void PlayDoubleAnim()
		{
		}

		// Token: 0x06015641 RID: 87617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015641")]
		[Address(RVA = "0xDCDF10", Offset = "0xDCCB10", VA = "0x180DCDF10")]
		public GameCityBattleScoreUIPanel()
		{
		}

		// Token: 0x04019974 RID: 104820
		[Token(Token = "0x4019974")]
		private const string SHOW_ANIM_IN_KEY = "act1arcade_score_ui_show_normal";

		// Token: 0x04019975 RID: 104821
		[Token(Token = "0x4019975")]
		private const string SHOW_ANIM_DOUBLE_KEY = "act1arcade_score_ui_show_double_increase";

		// Token: 0x04019976 RID: 104822
		[Token(Token = "0x4019976")]
		private const string SHOW_ANIM_OUT_KEY = "act1arcade_score_ui_out";

		// Token: 0x04019977 RID: 104823
		[Token(Token = "0x4019977")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x04019978 RID: 104824
		[Token(Token = "0x4019978")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _normalScore;

		// Token: 0x04019979 RID: 104825
		[Token(Token = "0x4019979")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _shadowScore;

		// Token: 0x0401997A RID: 104826
		[Token(Token = "0x401997A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _rainbowScore;

		// Token: 0x0401997B RID: 104827
		[Token(Token = "0x401997B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _normalFX;

		// Token: 0x0401997C RID: 104828
		[Token(Token = "0x401997C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _rainbowFX;

		// Token: 0x0401997D RID: 104829
		[Token(Token = "0x401997D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPanelShownScore;

		// Token: 0x0401997E RID: 104830
		[Token(Token = "0x401997E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayForOnce;

		// Token: 0x0401997F RID: 104831
		[Token(Token = "0x401997F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PlayOutAnim;

		// Token: 0x04019980 RID: 104832
		[Token(Token = "0x4019980")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PlayDoubleAnim;

		// Token: 0x04019981 RID: 104833
		[Token(Token = "0x4019981")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
