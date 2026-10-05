using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.BattleFinish
{
	// Token: 0x0200708D RID: 28813
	[Token(Token = "0x200708D")]
	public abstract class ActMultiV3BattleFinishModeViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x170060DB RID: 24795
		// (get) Token: 0x06028EE9 RID: 167657
		[Token(Token = "0x170060DB")]
		public abstract ActMultiV3MapModeType modeType { [Token(Token = "0x6028EE9")] get; }

		// Token: 0x06028EEA RID: 167658
		[Token(Token = "0x6028EEA")]
		public abstract Tween GenerateShowTween();

		// Token: 0x06028EEB RID: 167659
		[Token(Token = "0x6028EEB")]
		protected abstract void OnEnter();

		// Token: 0x06028EEC RID: 167660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EEC")]
		[Address(RVA = "0x244C5E0", Offset = "0x244B1E0", VA = "0x18244C5E0")]
		public void TriggerEnter(ActMultiV3BattleFinishViewModel viewModel)
		{
		}

		// Token: 0x06028EED RID: 167661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EED")]
		[Address(RVA = "0x244C800", Offset = "0x244B400", VA = "0x18244C800")]
		private void _RenderBaseView(ActMultiV3BattleFinishViewModel viewModel)
		{
		}

		// Token: 0x06028EEE RID: 167662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EEE")]
		[Address(RVA = "0x244C9A0", Offset = "0x244B5A0", VA = "0x18244C9A0")]
		protected ActMultiV3BattleFinishModeViewBase()
		{
		}

		// Token: 0x0403A67B RID: 239227
		[Token(Token = "0x403A67B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] _activeStarGOList;

		// Token: 0x0403A67C RID: 239228
		[Token(Token = "0x403A67C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _inactiveStarGOList;

		// Token: 0x0403A67D RID: 239229
		[Token(Token = "0x403A67D")]
		[FieldOffset(Offset = "0x28")]
		protected ActMultiV3BattleFinishViewModel m_viewModel;

		// Token: 0x0403A67E RID: 239230
		[Token(Token = "0x403A67E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TriggerEnter;

		// Token: 0x0403A67F RID: 239231
		[Token(Token = "0x403A67F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderBaseView;

		// Token: 0x0403A680 RID: 239232
		[Token(Token = "0x403A680")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
