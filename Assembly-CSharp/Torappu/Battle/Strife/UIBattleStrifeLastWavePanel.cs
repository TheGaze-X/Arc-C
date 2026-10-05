using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Strife
{
	// Token: 0x02002683 RID: 9859
	[Token(Token = "0x2002683")]
	public class UIBattleStrifeLastWavePanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x060101A0 RID: 65952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101A0")]
		[Address(RVA = "0x7D34F0", Offset = "0x7D20F0", VA = "0x1807D34F0")]
		public void OnInit()
		{
		}

		// Token: 0x060101A1 RID: 65953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101A1")]
		[Address(RVA = "0x7D3470", Offset = "0x7D2070", VA = "0x1807D3470")]
		public void OnCurWaveWillFinish(float showTime)
		{
		}

		// Token: 0x060101A2 RID: 65954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101A2")]
		[Address(RVA = "0x7D3590", Offset = "0x7D2190", VA = "0x1807D3590")]
		public void UpdateGameInfo()
		{
		}

		// Token: 0x060101A3 RID: 65955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101A3")]
		[Address(RVA = "0x7D3790", Offset = "0x7D2390", VA = "0x1807D3790")]
		private void _SwitchPanelShow(float showTime, bool isShow)
		{
		}

		// Token: 0x060101A4 RID: 65956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101A4")]
		[Address(RVA = "0x7D3630", Offset = "0x7D2230", VA = "0x1807D3630")]
		private void _PlayWaveTipsAnim(bool isLast)
		{
		}

		// Token: 0x060101A5 RID: 65957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101A5")]
		[Address(RVA = "0x7D39F0", Offset = "0x7D25F0", VA = "0x1807D39F0")]
		public UIBattleStrifeLastWavePanel()
		{
		}

		// Token: 0x04011EDE RID: 73438
		[Token(Token = "0x4011EDE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objNextPart;

		// Token: 0x04011EDF RID: 73439
		[Token(Token = "0x4011EDF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objLastPart;

		// Token: 0x04011EE0 RID: 73440
		[Token(Token = "0x4011EE0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationWrapper _waveAnim;

		// Token: 0x04011EE1 RID: 73441
		[Token(Token = "0x4011EE1")]
		private const string STRIFE_NEXT_WAVE_ANIM = "battle_ui_strifer_next_wave";

		// Token: 0x04011EE2 RID: 73442
		[Token(Token = "0x4011EE2")]
		private const string STRIFE_LAST_WAVE_ANIM = "battle_ui_strifer_last_wave";

		// Token: 0x04011EE3 RID: 73443
		[Token(Token = "0x4011EE3")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isShow;

		// Token: 0x04011EE4 RID: 73444
		[Token(Token = "0x4011EE4")]
		[FieldOffset(Offset = "0x34")]
		private float m_showDuration;

		// Token: 0x04011EE5 RID: 73445
		[Token(Token = "0x4011EE5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04011EE6 RID: 73446
		[Token(Token = "0x4011EE6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCurWaveWillFinish;

		// Token: 0x04011EE7 RID: 73447
		[Token(Token = "0x4011EE7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x04011EE8 RID: 73448
		[Token(Token = "0x4011EE8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SwitchPanelShow;

		// Token: 0x04011EE9 RID: 73449
		[Token(Token = "0x4011EE9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayWaveTipsAnim;

		// Token: 0x04011EEA RID: 73450
		[Token(Token = "0x4011EEA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
