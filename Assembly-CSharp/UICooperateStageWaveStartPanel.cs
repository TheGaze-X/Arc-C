using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu;
using Torappu.Battle.GameMode;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000020 RID: 32
[Token(Token = "0x2000020")]
public class UICooperateStageWaveStartPanel : MonoBehaviour
{
	// Token: 0x06000087 RID: 135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000087")]
	[Address(RVA = "0x50F250", Offset = "0x50DE50", VA = "0x18050F250")]
	public void OnInit()
	{
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000088")]
	[Address(RVA = "0x50F1A0", Offset = "0x50DDA0", VA = "0x18050F1A0")]
	public void OnFixedUpdate(FP deltaTime)
	{
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000089")]
	[Address(RVA = "0x50F4D0", Offset = "0x50E0D0", VA = "0x18050F4D0")]
	public void ShowStartPanel(Vector3 originLocalPosition)
	{
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008A")]
	[Address(RVA = "0x510750", Offset = "0x50F350", VA = "0x180510750")]
	private void _SetTaskInfo(string basicInfo, string advancedInfo, string taskName, int stage)
	{
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008B")]
	[Address(RVA = "0x510A80", Offset = "0x50F680", VA = "0x180510A80")]
	private void _SetWaveInfo(int curWave, int waveCnt)
	{
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008C")]
	[Address(RVA = "0x5104A0", Offset = "0x50F0A0", VA = "0x1805104A0")]
	private void _SetFirstWaveInfo(int curWave, int waveCnt, GameModeFactory.CooperateGameMode gameMode)
	{
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008D")]
	[Address(RVA = "0x5106C0", Offset = "0x50F2C0", VA = "0x1805106C0")]
	private void _SetLastWaveInfo()
	{
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008E")]
	[Address(RVA = "0x5108C0", Offset = "0x50F4C0", VA = "0x1805108C0")]
	private void _SetTaskNormal(GameModeFactory.CooperateGameMode gameMode, UIAnimationLocation anim)
	{
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00002358 File Offset: 0x00000558
	[Token(Token = "0x600008F")]
	[Address(RVA = "0x510190", Offset = "0x50ED90", VA = "0x180510190")]
	private UICooperateStageWaveStartPanel.BasicTaskInfo _GetWaveInfo(GameModeFactory.CooperateGameMode gameMode)
	{
		return default(UICooperateStageWaveStartPanel.BasicTaskInfo);
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000090")]
	[Address(RVA = "0x510070", Offset = "0x50EC70", VA = "0x180510070")]
	private string _GetTargetInfo()
	{
		return null;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000091")]
	[Address(RVA = "0x5103F0", Offset = "0x50EFF0", VA = "0x1805103F0")]
	private void _HideAllPerform(object arg)
	{
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000092")]
	[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
	public UICooperateStageWaveStartPanel()
	{
	}

	// Token: 0x04000072 RID: 114
	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text _basicTaskInfo;

	// Token: 0x04000073 RID: 115
	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text _advancedTaskInfo;

	// Token: 0x04000074 RID: 116
	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text _taskName;

	// Token: 0x04000075 RID: 117
	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text _stageCnt;

	// Token: 0x04000076 RID: 118
	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject _advanceField;

	// Token: 0x04000077 RID: 119
	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Text _defenceMaxWave;

	// Token: 0x04000078 RID: 120
	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Text _defenceCurWave;

	// Token: 0x04000079 RID: 121
	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Text _defenceFirstMaxWave;

	// Token: 0x0400007A RID: 122
	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Text _defenceTarget;

	// Token: 0x0400007B RID: 123
	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Text _defenceFirstCurWave;

	// Token: 0x0400007C RID: 124
	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Text _defenceLastWaveInfo;

	// Token: 0x0400007D RID: 125
	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private UIAnimationLocation _normalWaveStart;

	// Token: 0x0400007E RID: 126
	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UIAnimationLocation _normalTrainWaveStart;

	// Token: 0x0400007F RID: 127
	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private UIAnimationLocation _footballWaveStart;

	// Token: 0x04000080 RID: 128
	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private UIAnimationLocation _footballTrainWaveStart;

	// Token: 0x04000081 RID: 129
	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private UIAnimationLocation _defenceWaveStart;

	// Token: 0x04000082 RID: 130
	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private UIAnimationLocation _defenceTrainWaveStart;

	// Token: 0x04000083 RID: 131
	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private UIAnimationLocation _defenceWaveNoraml;

	// Token: 0x04000084 RID: 132
	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private UIAnimationLocation _defenceWaveLast;

	// Token: 0x04000085 RID: 133
	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private UIAnimationLocation _sailBoatWaveStart;

	// Token: 0x04000086 RID: 134
	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private UIAnimationLocation _sailBoatTrainWaveStart;

	// Token: 0x04000087 RID: 135
	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x110")]
	private FP m_passedTime;

	// Token: 0x04000088 RID: 136
	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x118")]
	private Tween m_tween;

	// Token: 0x04000089 RID: 137
	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x120")]
	private string m_stageId;

	// Token: 0x0400008A RID: 138
	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x128")]
	private string m_actId;

	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	private struct BasicTaskInfo
	{
		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x0")]
		public string basicInfo;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x8")]
		public string advanceInfo;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x10")]
		public string taskName;
	}
}
