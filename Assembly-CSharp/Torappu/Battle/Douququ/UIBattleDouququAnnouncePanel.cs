using System;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.Douququ
{
	// Token: 0x02002A39 RID: 10809
	[Token(Token = "0x2002A39")]
	public class UIBattleDouququAnnouncePanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06011F1A RID: 73498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F1A")]
		[Address(RVA = "0x9CE1A0", Offset = "0x9CCDA0", VA = "0x1809CE1A0")]
		public void Init(DouququUIAnnounceState announceState)
		{
		}

		// Token: 0x06011F1B RID: 73499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F1B")]
		[Address(RVA = "0x9CE220", Offset = "0x9CCE20", VA = "0x1809CE220")]
		public void Show(bool isFirstShow, GameModeFactory.DouququGameMode manager)
		{
		}

		// Token: 0x06011F1C RID: 73500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F1C")]
		[Address(RVA = "0x9CE580", Offset = "0x9CD180", VA = "0x1809CE580")]
		private void _OnAnnounceEnd()
		{
		}

		// Token: 0x06011F1D RID: 73501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F1D")]
		[Address(RVA = "0x9CE5F0", Offset = "0x9CD1F0", VA = "0x1809CE5F0")]
		public UIBattleDouququAnnouncePanel()
		{
		}

		// Token: 0x040143BF RID: 82879
		[Token(Token = "0x40143BF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objStartPart;

		// Token: 0x040143C0 RID: 82880
		[Token(Token = "0x40143C0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objWavePart;

		// Token: 0x040143C1 RID: 82881
		[Token(Token = "0x40143C1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _curWave;

		// Token: 0x040143C2 RID: 82882
		[Token(Token = "0x40143C2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _totleWave;

		// Token: 0x040143C3 RID: 82883
		[Token(Token = "0x40143C3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationWrapper _startAnim;

		// Token: 0x040143C4 RID: 82884
		[Token(Token = "0x40143C4")]
		[FieldOffset(Offset = "0x40")]
		private DouququUIAnnounceState m_state;

		// Token: 0x040143C5 RID: 82885
		[Token(Token = "0x40143C5")]
		private const string DOUQUQU_START_ANIM = "douququ_battle_start";

		// Token: 0x040143C6 RID: 82886
		[Token(Token = "0x40143C6")]
		private const string DOUQUQU_WAVE_START_ANIM = "douququ_battle_wave_start";

		// Token: 0x040143C7 RID: 82887
		[Token(Token = "0x40143C7")]
		private const int LARGE_WAVE_SIZE = 110;

		// Token: 0x040143C8 RID: 82888
		[Token(Token = "0x40143C8")]
		private const int SMALL_WAVE_SIZE = 80;

		// Token: 0x040143C9 RID: 82889
		[Token(Token = "0x40143C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040143CA RID: 82890
		[Token(Token = "0x40143CA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x040143CB RID: 82891
		[Token(Token = "0x40143CB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnAnnounceEnd;

		// Token: 0x040143CC RID: 82892
		[Token(Token = "0x40143CC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
