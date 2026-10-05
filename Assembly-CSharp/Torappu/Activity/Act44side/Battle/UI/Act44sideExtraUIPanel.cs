using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act44side.Battle.UI
{
	// Token: 0x020072EE RID: 29422
	[Token(Token = "0x20072EE")]
	public class Act44sideExtraUIPanel : Act44sideNormalUIPanel
	{
		// Token: 0x17006269 RID: 25193
		// (get) Token: 0x06029A13 RID: 170515 RVA: 0x000D6140 File Offset: 0x000D4340
		[Token(Token = "0x17006269")]
		private int curGrade
		{
			[Token(Token = "0x6029A13")]
			[Address(RVA = "0x24EEF60", Offset = "0x24EDB60", VA = "0x1824EEF60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700626A RID: 25194
		// (get) Token: 0x06029A14 RID: 170516 RVA: 0x000D6158 File Offset: 0x000D4358
		[Token(Token = "0x1700626A")]
		private int maxPlayTime
		{
			[Token(Token = "0x6029A14")]
			[Address(RVA = "0x24EF0A0", Offset = "0x24EDCA0", VA = "0x1824EF0A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06029A15 RID: 170517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A15")]
		[Address(RVA = "0x24EE790", Offset = "0x24ED390", VA = "0x1824EE790", Slot = "4")]
		public override void Init(Act44SideBattleManager envManager)
		{
		}

		// Token: 0x06029A16 RID: 170518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A16")]
		[Address(RVA = "0x24EE930", Offset = "0x24ED530", VA = "0x1824EE930")]
		public void UpdateGradeDisplay()
		{
		}

		// Token: 0x06029A17 RID: 170519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A17")]
		[Address(RVA = "0x24EEB00", Offset = "0x24ED700", VA = "0x1824EEB00")]
		public void UpdateTimeDisplay()
		{
		}

		// Token: 0x06029A18 RID: 170520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A18")]
		[Address(RVA = "0x24EEDF0", Offset = "0x24ED9F0", VA = "0x1824EEDF0")]
		private void _InitTimePerformAnim()
		{
		}

		// Token: 0x06029A19 RID: 170521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A19")]
		[Address(RVA = "0x24EEEB0", Offset = "0x24EDAB0", VA = "0x1824EEEB0")]
		public Act44sideExtraUIPanel()
		{
		}

		// Token: 0x06029A1A RID: 170522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A1A")]
		[Address(RVA = "0x24EE920", Offset = "0x24ED520", VA = "0x1824EE920")]
		private void <>xLuaBaseProxy_Init(Act44SideBattleManager P0)
		{
		}

		// Token: 0x0403B8CD RID: 243917
		[Token(Token = "0x403B8CD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Grade Timer Params")]
		private Text _scoreText;

		// Token: 0x0403B8CE RID: 243918
		[Token(Token = "0x403B8CE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Grade Timer Params")]
		private Text _timeText;

		// Token: 0x0403B8CF RID: 243919
		[Token(Token = "0x403B8CF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Grade Timer Params")]
		private int _timeBeginTweenTime;

		// Token: 0x0403B8D0 RID: 243920
		[Token(Token = "0x403B8D0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Grade Timer Params")]
		private UIAnimationLocation _waringTimePerform;

		// Token: 0x0403B8D1 RID: 243921
		[Token(Token = "0x403B8D1")]
		[FieldOffset(Offset = "0x70")]
		private int m_playTime;

		// Token: 0x0403B8D2 RID: 243922
		[Token(Token = "0x403B8D2")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_progressTween;

		// Token: 0x0403B8D3 RID: 243923
		[Token(Token = "0x403B8D3")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_timeTween;

		// Token: 0x0403B8D4 RID: 243924
		[Token(Token = "0x403B8D4")]
		[FieldOffset(Offset = "0x88")]
		private LevelScriptRuntime m_levelScriptRuntime;

		// Token: 0x0403B8D5 RID: 243925
		[Token(Token = "0x403B8D5")]
		private const string TOTAL_GRADE_STR = "total_score";

		// Token: 0x0403B8D6 RID: 243926
		[Token(Token = "0x403B8D6")]
		private const string MAX_PLAY_TIME_STR = "max_play_time";

		// Token: 0x0403B8D7 RID: 243927
		[Token(Token = "0x403B8D7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_curGrade;

		// Token: 0x0403B8D8 RID: 243928
		[Token(Token = "0x403B8D8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_maxPlayTime;

		// Token: 0x0403B8D9 RID: 243929
		[Token(Token = "0x403B8D9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403B8DA RID: 243930
		[Token(Token = "0x403B8DA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateGradeDisplay;

		// Token: 0x0403B8DB RID: 243931
		[Token(Token = "0x403B8DB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateTimeDisplay;

		// Token: 0x0403B8DC RID: 243932
		[Token(Token = "0x403B8DC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitTimePerformAnim;

		// Token: 0x0403B8DD RID: 243933
		[Token(Token = "0x403B8DD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
