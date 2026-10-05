using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x0200500B RID: 20491
	[Token(Token = "0x200500B")]
	public class EnemyDuelRoundEndOperationView : DataBinder<EnemyDuelRoundEndOperationProperty>
	{
		// Token: 0x0601E693 RID: 124563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E693")]
		[Address(RVA = "0x181EFF0", Offset = "0x181DBF0", VA = "0x18181EFF0", Slot = "7")]
		public override void OnValueChanged(EnemyDuelRoundEndOperationProperty property)
		{
		}

		// Token: 0x0601E694 RID: 124564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E694")]
		[Address(RVA = "0x181EEF0", Offset = "0x181DAF0", VA = "0x18181EEF0")]
		public void OnStatePause()
		{
		}

		// Token: 0x0601E695 RID: 124565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E695")]
		[Address(RVA = "0x181F460", Offset = "0x181E060", VA = "0x18181F460")]
		private void _PlayEntryTween()
		{
		}

		// Token: 0x0601E696 RID: 124566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E696")]
		[Address(RVA = "0x181F5F0", Offset = "0x181E1F0", VA = "0x18181F5F0")]
		public EnemyDuelRoundEndOperationView()
		{
		}

		// Token: 0x04028AD9 RID: 166617
		[Token(Token = "0x4028AD9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x04028ADA RID: 166618
		[Token(Token = "0x4028ADA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private EnemyDuelRoundEndBarView _barView;

		// Token: 0x04028ADB RID: 166619
		[Token(Token = "0x4028ADB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private EnemyDuelOperationRankItemView[] _itemList;

		// Token: 0x04028ADC RID: 166620
		[Token(Token = "0x4028ADC")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_entryTween;

		// Token: 0x04028ADD RID: 166621
		[Token(Token = "0x4028ADD")]
		[FieldOffset(Offset = "0x48")]
		private AnimationSwitchTween m_windowTween;

		// Token: 0x04028ADE RID: 166622
		[Token(Token = "0x4028ADE")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04028ADF RID: 166623
		[Token(Token = "0x4028ADF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04028AE0 RID: 166624
		[Token(Token = "0x4028AE0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStatePause;

		// Token: 0x04028AE1 RID: 166625
		[Token(Token = "0x4028AE1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayEntryTween;

		// Token: 0x04028AE2 RID: 166626
		[Token(Token = "0x4028AE2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
