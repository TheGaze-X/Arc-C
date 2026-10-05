using System;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033E8 RID: 13288
	[Token(Token = "0x20033E8")]
	public class UICooperateRestingPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601534A RID: 86858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601534A")]
		[Address(RVA = "0xDA6910", Offset = "0xDA5510", VA = "0x180DA6910")]
		public void OnInit(GameModeFactory.CooperateGameMode gameMode)
		{
		}

		// Token: 0x0601534B RID: 86859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601534B")]
		[Address(RVA = "0xDA6CD0", Offset = "0xDA58D0", VA = "0x180DA6CD0")]
		public void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0601534C RID: 86860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601534C")]
		[Address(RVA = "0xDA6F40", Offset = "0xDA5B40", VA = "0x180DA6F40")]
		private void _OnRestingStateChanged(object args)
		{
		}

		// Token: 0x0601534D RID: 86861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601534D")]
		[Address(RVA = "0xDA6B40", Offset = "0xDA5740", VA = "0x180DA6B40")]
		public void OnSkipButtonClick()
		{
		}

		// Token: 0x0601534E RID: 86862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601534E")]
		[Address(RVA = "0xDA69E0", Offset = "0xDA55E0", VA = "0x180DA69E0")]
		public void OnPlayerSkipResting(PlayerSide side)
		{
		}

		// Token: 0x0601534F RID: 86863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601534F")]
		[Address(RVA = "0xDA6EB0", Offset = "0xDA5AB0", VA = "0x180DA6EB0")]
		public void ResetResting()
		{
		}

		// Token: 0x06015350 RID: 86864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015350")]
		[Address(RVA = "0xDA70C0", Offset = "0xDA5CC0", VA = "0x180DA70C0")]
		public UICooperateRestingPanel()
		{
		}

		// Token: 0x04019516 RID: 103702
		[Token(Token = "0x4019516")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _timer;

		// Token: 0x04019517 RID: 103703
		[Token(Token = "0x4019517")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _skipButton;

		// Token: 0x04019518 RID: 103704
		[Token(Token = "0x4019518")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationWrapper _leftAnimation;

		// Token: 0x04019519 RID: 103705
		[Token(Token = "0x4019519")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationWrapper _rightAnimation;

		// Token: 0x0401951A RID: 103706
		[Token(Token = "0x401951A")]
		[FieldOffset(Offset = "0x38")]
		private GameModeFactory.CooperateGameMode m_gameMode;

		// Token: 0x0401951B RID: 103707
		[Token(Token = "0x401951B")]
		[FieldOffset(Offset = "0x40")]
		private PeriodicTimer m_restingTicker;

		// Token: 0x0401951C RID: 103708
		[Token(Token = "0x401951C")]
		[FieldOffset(Offset = "0x48")]
		private readonly string m_leftAnimationName;

		// Token: 0x0401951D RID: 103709
		[Token(Token = "0x401951D")]
		[FieldOffset(Offset = "0x50")]
		private readonly string m_rightAnimationName;

		// Token: 0x0401951E RID: 103710
		[Token(Token = "0x401951E")]
		[FieldOffset(Offset = "0x58")]
		private readonly string m_str_s;

		// Token: 0x0401951F RID: 103711
		[Token(Token = "0x401951F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04019520 RID: 103712
		[Token(Token = "0x4019520")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04019521 RID: 103713
		[Token(Token = "0x4019521")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnRestingStateChanged;

		// Token: 0x04019522 RID: 103714
		[Token(Token = "0x4019522")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSkipButtonClick;

		// Token: 0x04019523 RID: 103715
		[Token(Token = "0x4019523")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPlayerSkipResting;

		// Token: 0x04019524 RID: 103716
		[Token(Token = "0x4019524")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ResetResting;

		// Token: 0x04019525 RID: 103717
		[Token(Token = "0x4019525")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
