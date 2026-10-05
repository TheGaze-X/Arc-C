using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.Roguelike.Duel
{
	// Token: 0x0200292F RID: 10543
	[Token(Token = "0x200292F")]
	public class RoguelikeDuelUIBattlePanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x060117B3 RID: 71603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117B3")]
		[Address(RVA = "0x962E60", Offset = "0x961A60", VA = "0x180962E60")]
		public void InitData(RoguelikeDuelUIPlugin plugin)
		{
		}

		// Token: 0x060117B4 RID: 71604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117B4")]
		[Address(RVA = "0x9632E0", Offset = "0x961EE0", VA = "0x1809632E0")]
		public void UpdateData()
		{
		}

		// Token: 0x060117B5 RID: 71605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117B5")]
		[Address(RVA = "0x963090", Offset = "0x961C90", VA = "0x180963090")]
		public void PlayBattleStartAnimation()
		{
		}

		// Token: 0x060117B6 RID: 71606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117B6")]
		[Address(RVA = "0x9634F0", Offset = "0x9620F0", VA = "0x1809634F0")]
		private void _InitUI()
		{
		}

		// Token: 0x060117B7 RID: 71607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117B7")]
		[Address(RVA = "0x9635A0", Offset = "0x9621A0", VA = "0x1809635A0")]
		private void _SetRemainTimeInfo()
		{
		}

		// Token: 0x060117B8 RID: 71608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117B8")]
		[Address(RVA = "0x963710", Offset = "0x962310", VA = "0x180963710")]
		private void _SetRemainTimeText(int remainTime)
		{
		}

		// Token: 0x060117B9 RID: 71609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117B9")]
		[Address(RVA = "0x9638A0", Offset = "0x9624A0", VA = "0x1809638A0")]
		public RoguelikeDuelUIBattlePanel()
		{
		}

		// Token: 0x040138BE RID: 80062
		[Token(Token = "0x40138BE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Animation ")]
		private UIAnimationLocation _perform;

		// Token: 0x040138BF RID: 80063
		[Token(Token = "0x40138BF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Time")]
		private UITextSlider _remainTimeSlider;

		// Token: 0x040138C0 RID: 80064
		[Token(Token = "0x40138C0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Time")]
		private Text _remainTimeText;

		// Token: 0x040138C1 RID: 80065
		[Token(Token = "0x40138C1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Time")]
		private GameObject _emergencyMask;

		// Token: 0x040138C2 RID: 80066
		[Token(Token = "0x40138C2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Time")]
		private int _emergencyTimeThreshold;

		// Token: 0x040138C3 RID: 80067
		[Token(Token = "0x40138C3")]
		[FieldOffset(Offset = "0x44")]
		private int m_remainTime;

		// Token: 0x040138C4 RID: 80068
		[Token(Token = "0x40138C4")]
		[FieldOffset(Offset = "0x48")]
		private int m_maxTime;

		// Token: 0x040138C5 RID: 80069
		[Token(Token = "0x40138C5")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeDuelUIPlugin m_plugin;

		// Token: 0x040138C6 RID: 80070
		[Token(Token = "0x40138C6")]
		[FieldOffset(Offset = "0x58")]
		private GameModeFactory.RoguelikeDuelGameMode m_gameMode;

		// Token: 0x040138C7 RID: 80071
		[Token(Token = "0x40138C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x040138C8 RID: 80072
		[Token(Token = "0x40138C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x040138C9 RID: 80073
		[Token(Token = "0x40138C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PlayBattleStartAnimation;

		// Token: 0x040138CA RID: 80074
		[Token(Token = "0x40138CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitUI;

		// Token: 0x040138CB RID: 80075
		[Token(Token = "0x40138CB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetRemainTimeInfo;

		// Token: 0x040138CC RID: 80076
		[Token(Token = "0x40138CC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetRemainTimeText;

		// Token: 0x040138CD RID: 80077
		[Token(Token = "0x40138CD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
