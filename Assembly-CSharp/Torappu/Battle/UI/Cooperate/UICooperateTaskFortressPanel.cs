using System;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033F4 RID: 13300
	[Token(Token = "0x20033F4")]
	public class UICooperateTaskFortressPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015393 RID: 86931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015393")]
		[Address(RVA = "0xDABE60", Offset = "0xDAAA60", VA = "0x180DABE60")]
		public void InitPanel()
		{
		}

		// Token: 0x06015394 RID: 86932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015394")]
		[Address(RVA = "0xDAC180", Offset = "0xDAAD80", VA = "0x180DAC180")]
		public void UpdatePanel()
		{
		}

		// Token: 0x06015395 RID: 86933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015395")]
		[Address(RVA = "0xDAC290", Offset = "0xDAAE90", VA = "0x180DAC290")]
		private void _UpdateWaveInfo()
		{
		}

		// Token: 0x06015396 RID: 86934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015396")]
		[Address(RVA = "0xDAC520", Offset = "0xDAB120", VA = "0x180DAC520")]
		public UICooperateTaskFortressPanel()
		{
		}

		// Token: 0x040195A4 RID: 103844
		[Token(Token = "0x40195A4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _maxWave;

		// Token: 0x040195A5 RID: 103845
		[Token(Token = "0x40195A5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _curWave;

		// Token: 0x040195A6 RID: 103846
		[Token(Token = "0x40195A6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _curEnemy;

		// Token: 0x040195A7 RID: 103847
		[Token(Token = "0x40195A7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _maxEnemy;

		// Token: 0x040195A8 RID: 103848
		[Token(Token = "0x40195A8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _fortressInfo;

		// Token: 0x040195A9 RID: 103849
		[Token(Token = "0x40195A9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _fortressInfoKey;

		// Token: 0x040195AA RID: 103850
		[Token(Token = "0x40195AA")]
		[FieldOffset(Offset = "0x48")]
		private int m_maxWaveCnt;

		// Token: 0x040195AB RID: 103851
		[Token(Token = "0x40195AB")]
		[FieldOffset(Offset = "0x4C")]
		private int m_waveFinished;

		// Token: 0x040195AC RID: 103852
		[Token(Token = "0x40195AC")]
		[FieldOffset(Offset = "0x50")]
		private Scheduler m_scheduler;

		// Token: 0x040195AD RID: 103853
		[Token(Token = "0x40195AD")]
		[FieldOffset(Offset = "0x58")]
		private GameModeFactory.CooperateGameMode m_gameMode;

		// Token: 0x040195AE RID: 103854
		[Token(Token = "0x40195AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitPanel;

		// Token: 0x040195AF RID: 103855
		[Token(Token = "0x40195AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdatePanel;

		// Token: 0x040195B0 RID: 103856
		[Token(Token = "0x40195B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateWaveInfo;

		// Token: 0x040195B1 RID: 103857
		[Token(Token = "0x40195B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
