using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x02006216 RID: 25110
	[Token(Token = "0x2006216")]
	public class BattleFinishMetaDisplayView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060243AE RID: 148398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243AE")]
		[Address(RVA = "0x1F17FC0", Offset = "0x1F16BC0", VA = "0x181F17FC0")]
		public void Render(BattleInfoViewModel viewModel)
		{
		}

		// Token: 0x060243AF RID: 148399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243AF")]
		[Address(RVA = "0x1F18530", Offset = "0x1F17130", VA = "0x181F18530")]
		private void _PlayAnimWithSignal(string signal)
		{
		}

		// Token: 0x060243B0 RID: 148400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243B0")]
		[Address(RVA = "0x1F186E0", Offset = "0x1F172E0", VA = "0x181F186E0")]
		private void _StopBattleFinishBGM()
		{
		}

		// Token: 0x060243B1 RID: 148401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243B1")]
		[Address(RVA = "0x1F17F60", Offset = "0x1F16B60", VA = "0x181F17F60")]
		public void EventOnCloseBtnClick()
		{
		}

		// Token: 0x060243B2 RID: 148402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243B2")]
		[Address(RVA = "0x1F187A0", Offset = "0x1F173A0", VA = "0x181F187A0")]
		public BattleFinishMetaDisplayView()
		{
		}

		// Token: 0x04032609 RID: 206345
		[Token(Token = "0x4032609")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIFullScreenImage _blurBackground;

		// Token: 0x0403260A RID: 206346
		[Token(Token = "0x403260A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtStageCode;

		// Token: 0x0403260B RID: 206347
		[Token(Token = "0x403260B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtStageName;

		// Token: 0x0403260C RID: 206348
		[Token(Token = "0x403260C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtWord;

		// Token: 0x0403260D RID: 206349
		[Token(Token = "0x403260D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _animationLocation;

		// Token: 0x0403260E RID: 206350
		[Token(Token = "0x403260E")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_animTween;

		// Token: 0x0403260F RID: 206351
		[Token(Token = "0x403260F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04032610 RID: 206352
		[Token(Token = "0x4032610")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayAnimWithSignal;

		// Token: 0x04032611 RID: 206353
		[Token(Token = "0x4032611")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__StopBattleFinishBGM;

		// Token: 0x04032612 RID: 206354
		[Token(Token = "0x4032612")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnCloseBtnClick;

		// Token: 0x04032613 RID: 206355
		[Token(Token = "0x4032613")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
