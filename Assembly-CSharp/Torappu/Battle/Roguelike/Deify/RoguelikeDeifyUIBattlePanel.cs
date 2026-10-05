using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.Roguelike.Deify
{
	// Token: 0x02002935 RID: 10549
	[Token(Token = "0x2002935")]
	public class RoguelikeDeifyUIBattlePanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601180F RID: 71695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601180F")]
		[Address(RVA = "0x95EA50", Offset = "0x95D650", VA = "0x18095EA50")]
		public void InitData(RoguelikeDeifyUIPlugin plugin)
		{
		}

		// Token: 0x06011810 RID: 71696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011810")]
		[Address(RVA = "0x95EEE0", Offset = "0x95DAE0", VA = "0x18095EEE0")]
		public void UpdateData()
		{
		}

		// Token: 0x06011811 RID: 71697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011811")]
		[Address(RVA = "0x95EC80", Offset = "0x95D880", VA = "0x18095EC80")]
		public void PlayBattleStartAnimation()
		{
		}

		// Token: 0x06011812 RID: 71698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011812")]
		[Address(RVA = "0x95F0F0", Offset = "0x95DCF0", VA = "0x18095F0F0")]
		private void _InitUI()
		{
		}

		// Token: 0x06011813 RID: 71699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011813")]
		[Address(RVA = "0x95F1A0", Offset = "0x95DDA0", VA = "0x18095F1A0")]
		private void _SetRemainTimeInfo()
		{
		}

		// Token: 0x06011814 RID: 71700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011814")]
		[Address(RVA = "0x95F310", Offset = "0x95DF10", VA = "0x18095F310")]
		private void _SetRemainTimeText(int remainTime)
		{
		}

		// Token: 0x06011815 RID: 71701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011815")]
		[Address(RVA = "0x95F4A0", Offset = "0x95E0A0", VA = "0x18095F4A0")]
		public RoguelikeDeifyUIBattlePanel()
		{
		}

		// Token: 0x04013926 RID: 80166
		[Token(Token = "0x4013926")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Animation ")]
		private UIAnimationLocation _perform;

		// Token: 0x04013927 RID: 80167
		[Token(Token = "0x4013927")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Time")]
		private UITextSlider _remainTimeSlider;

		// Token: 0x04013928 RID: 80168
		[Token(Token = "0x4013928")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Time")]
		private Text _remainTimeText;

		// Token: 0x04013929 RID: 80169
		[Token(Token = "0x4013929")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Time")]
		private GameObject _emergencyMask;

		// Token: 0x0401392A RID: 80170
		[Token(Token = "0x401392A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Time")]
		private int _emergencyTimeThreshold;

		// Token: 0x0401392B RID: 80171
		[Token(Token = "0x401392B")]
		[FieldOffset(Offset = "0x44")]
		private int m_remainTime;

		// Token: 0x0401392C RID: 80172
		[Token(Token = "0x401392C")]
		[FieldOffset(Offset = "0x48")]
		private int m_maxTime;

		// Token: 0x0401392D RID: 80173
		[Token(Token = "0x401392D")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeDeifyUIPlugin m_plugin;

		// Token: 0x0401392E RID: 80174
		[Token(Token = "0x401392E")]
		[FieldOffset(Offset = "0x58")]
		private GameModeFactory.RoguelikeDeifyGameMode m_gameMode;

		// Token: 0x0401392F RID: 80175
		[Token(Token = "0x401392F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04013930 RID: 80176
		[Token(Token = "0x4013930")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04013931 RID: 80177
		[Token(Token = "0x4013931")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PlayBattleStartAnimation;

		// Token: 0x04013932 RID: 80178
		[Token(Token = "0x4013932")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitUI;

		// Token: 0x04013933 RID: 80179
		[Token(Token = "0x4013933")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetRemainTimeInfo;

		// Token: 0x04013934 RID: 80180
		[Token(Token = "0x4013934")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetRemainTimeText;

		// Token: 0x04013935 RID: 80181
		[Token(Token = "0x4013935")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
