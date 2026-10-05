using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000017 RID: 23
[Token(Token = "0x2000017")]
public class BattleTimer : MonoBehaviour
{
	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000057 RID: 87 RVA: 0x00002208 File Offset: 0x00000408
	// (set) Token: 0x06000058 RID: 88 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000012")]
	[Inspect(InspectorLevel.Debug)]
	[Group("Timer")]
	private float timerTextPlaytime
	{
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x4F7D70", Offset = "0x4F6970", VA = "0x1804F7D70")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x4F7D80", Offset = "0x4F6980", VA = "0x1804F7D80")]
		set
		{
		}
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x4F7A80", Offset = "0x4F6680", VA = "0x1804F7A80")]
	private string _GetPlaytimeFormat(float playTime)
	{
		return null;
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
	public void EventOnEntryClick()
	{
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
	public void EventOnTimerPlayNPause()
	{
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
	public void EventOnTimerRecord()
	{
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005D")]
	[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
	public void EventOnTimerReset()
	{
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005E")]
	[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
	public void EventOnRestartGame()
	{
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005F")]
	[Address(RVA = "0x4F7D50", Offset = "0x4F6950", VA = "0x1804F7D50")]
	public BattleTimer()
	{
	}

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _panelContent;

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x20")]
	private BattleController m_battleController;

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Group("Timer")]
	private Text _timerText;

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x30")]
	private float m_timerTextPlaytime;

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Group("Timer")]
	private Button _timerPlayNPause;

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x40")]
	[ReadOnly]
	[Group("Timer")]
	[Inspect(InspectorLevel.Debug)]
	private Text m_timerPlayNPauseText;

	// Token: 0x04000044 RID: 68
	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Group("Timer")]
	private Button _timerRecord;

	// Token: 0x04000045 RID: 69
	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Group("Timer")]
	private Button _timerReset;

	// Token: 0x04000046 RID: 70
	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Group("Timer")]
	private Text[] _timerRecordTexts;

	// Token: 0x04000047 RID: 71
	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x60")]
	[Inspect(InspectorLevel.Debug)]
	[Group("Timer")]
	private BattleTimer.TimerRecordScrollController m_timerRecordScrollController;

	// Token: 0x04000048 RID: 72
	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x68")]
	[Group("Timer")]
	[SerializeField]
	[Inspect(InspectorLevel.Debug)]
	private float _timerRecordScrollSpeed;

	// Token: 0x04000049 RID: 73
	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	[Inspect(InspectorLevel.Debug)]
	[Group("Timer")]
	private bool _isDownward;

	// Token: 0x0400004A RID: 74
	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x70")]
	[Inspect(InspectorLevel.Debug)]
	[ReadOnly]
	[Group("Timer")]
	private int m_timerRecordCurrentIndex;

	// Token: 0x0400004B RID: 75
	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x78")]
	[Inspect]
	[Group("Timer")]
	private List<float> m_timerRecords;

	// Token: 0x0400004C RID: 76
	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x80")]
	private bool m_isResetPause;

	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	private class TimerRecordScrollController
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x17000013")]
		[Inspect]
		private int entityCount
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x50EB80", Offset = "0x50D780", VA = "0x18050EB80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x17000014")]
		[Inspect]
		private float fadeThreshold
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x50EBC0", Offset = "0x50D7C0", VA = "0x18050EBC0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x50EB00", Offset = "0x50D700", VA = "0x18050EB00")]
		public TimerRecordScrollController(float gap, float midLine, int maxDisplay, List<RectTransform> transformList, bool isDownward = true)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x50E490", Offset = "0x50D090", VA = "0x18050E490")]
		public void Reset(int displayCount = 0)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x50E790", Offset = "0x50D390", VA = "0x18050E790")]
		public void Scroll(float speed, float targetDelta)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x50E720", Offset = "0x50D320", VA = "0x18050E720")]
		public void Scroll(float speed, int steps)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x50E7B0", Offset = "0x50D3B0", VA = "0x18050E7B0")]
		public void Update(float deltaTime)
		{
		}

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x10")]
		public float gap;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x14")]
		public float midLine;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x18")]
		public int maxDisplay;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x1C")]
		public bool isDownward;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x20")]
		public List<RectTransform> transformList;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x28")]
		public float speed;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x2C")]
		public float targetDelta;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x30")]
		public bool targetDeltaFinished;
	}
}
