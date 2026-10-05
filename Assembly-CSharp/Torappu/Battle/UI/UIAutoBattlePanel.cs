using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Battle.UI
{
	// Token: 0x0200336F RID: 13167
	[Token(Token = "0x200336F")]
	public class UIAutoBattlePanel : MonoBehaviour
	{
		// Token: 0x0601501D RID: 86045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601501D")]
		[Address(RVA = "0xD6C110", Offset = "0xD6AD10", VA = "0x180D6C110")]
		public void Display(bool isShow)
		{
		}

		// Token: 0x0601501E RID: 86046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601501E")]
		[Address(RVA = "0xD6CEB0", Offset = "0xD6BAB0", VA = "0x180D6CEB0")]
		public void UpdateData(BattleController controller)
		{
		}

		// Token: 0x0601501F RID: 86047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601501F")]
		[Address(RVA = "0xD6C650", Offset = "0xD6B250", VA = "0x180D6C650")]
		public void OnAutoReplayFinished()
		{
		}

		// Token: 0x06015020 RID: 86048 RVA: 0x0008A108 File Offset: 0x00088308
		[Token(Token = "0x6015020")]
		[Address(RVA = "0xD6C660", Offset = "0xD6B260", VA = "0x180D6C660")]
		public bool TryHookGameOver(BattleController.GameResult result, PlayerBattleRank battleRank, UIBattleSystemMenuPanel.BattleReward reward)
		{
			return default(bool);
		}

		// Token: 0x06015021 RID: 86049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015021")]
		[Address(RVA = "0xD6D290", Offset = "0xD6BE90", VA = "0x180D6D290")]
		private void _OnEnterState(UIAutoBattlePanel.AutoState newState)
		{
		}

		// Token: 0x06015022 RID: 86050 RVA: 0x0008A120 File Offset: 0x00088320
		[Token(Token = "0x6015022")]
		[Address(RVA = "0xD6D120", Offset = "0xD6BD20", VA = "0x180D6D120")]
		private bool _CheckErrorOccurred(BattleController controller)
		{
			return default(bool);
		}

		// Token: 0x06015023 RID: 86051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015023")]
		[Address(RVA = "0xD6C160", Offset = "0xD6AD60", VA = "0x180D6C160")]
		public void EventOnExitAutoBattle()
		{
		}

		// Token: 0x06015024 RID: 86052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015024")]
		[Address(RVA = "0xD6D890", Offset = "0xD6C490", VA = "0x180D6D890")]
		public UIAutoBattlePanel()
		{
		}

		// Token: 0x04018FE5 RID: 102373
		[Token(Token = "0x4018FE5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Collection(typeof(UIAutoBattlePanel.AutoState))]
		private Transform[] _autoBattleStates;

		// Token: 0x04018FE6 RID: 102374
		[Token(Token = "0x4018FE6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Mask")]
		private Image _topMask;

		// Token: 0x04018FE7 RID: 102375
		[Token(Token = "0x4018FE7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Mask")]
		private Image _bottomMask;

		// Token: 0x04018FE8 RID: 102376
		[Token(Token = "0x4018FE8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Mask")]
		private Material _normalTopMaterial;

		// Token: 0x04018FE9 RID: 102377
		[Token(Token = "0x4018FE9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Mask")]
		private Material _normalBottomMaterial;

		// Token: 0x04018FEA RID: 102378
		[Token(Token = "0x4018FEA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Mask")]
		private Color _errorColor;

		// Token: 0x04018FEB RID: 102379
		[Token(Token = "0x4018FEB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Mask")]
		private Sprite _errorMask;

		// Token: 0x04018FEC RID: 102380
		[Token(Token = "0x4018FEC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Mask")]
		private float _normalMaskHeight;

		// Token: 0x04018FED RID: 102381
		[Token(Token = "0x4018FED")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[Group("Mask")]
		private float _errorMaskHeight;

		// Token: 0x04018FEE RID: 102382
		[Token(Token = "0x4018FEE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Mask")]
		private Text _comboCardText;

		// Token: 0x04018FEF RID: 102383
		[Token(Token = "0x4018FEF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Animation")]
		private Animator[] _buttonAnimation;

		// Token: 0x04018FF0 RID: 102384
		[Token(Token = "0x4018FF0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Animation")]
		private float _interval;

		// Token: 0x04018FF1 RID: 102385
		[Token(Token = "0x4018FF1")]
		[FieldOffset(Offset = "0x74")]
		private UIAutoBattlePanel.AutoState m_state;

		// Token: 0x04018FF2 RID: 102386
		[Token(Token = "0x4018FF2")]
		[FieldOffset(Offset = "0x78")]
		private float m_interval;

		// Token: 0x02003370 RID: 13168
		[Token(Token = "0x2003370")]
		private enum AutoState
		{
			// Token: 0x04018FF4 RID: 102388
			[Token(Token = "0x4018FF4")]
			NORMAL,
			// Token: 0x04018FF5 RID: 102389
			[Token(Token = "0x4018FF5")]
			WARNING,
			// Token: 0x04018FF6 RID: 102390
			[Token(Token = "0x4018FF6")]
			ERROR,
			// Token: 0x04018FF7 RID: 102391
			[Token(Token = "0x4018FF7")]
			FINISHED
		}
	}
}
