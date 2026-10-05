using System;
using Il2CppDummyDll;
using Torappu.Battle;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x02006219 RID: 25113
	[Token(Token = "0x2006219")]
	public class BattleFinishDropRewardFrameHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x060243BE RID: 148414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243BE")]
		[Address(RVA = "0x1F14040", Offset = "0x1F12C40", VA = "0x181F14040")]
		private void _ClearFrameView()
		{
		}

		// Token: 0x060243BF RID: 148415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243BF")]
		[Address(RVA = "0x1F13B50", Offset = "0x1F12750", VA = "0x181F13B50")]
		public void RenderFrameView(BattleStageInfo stageInfo, DropInfoGroupViewModel dropInfoGroupViewModel, UIAssetLoader assetLoader)
		{
		}

		// Token: 0x060243C0 RID: 148416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243C0")]
		[Address(RVA = "0x1F14140", Offset = "0x1F12D40", VA = "0x181F14140")]
		private void _ResetRewardLayout()
		{
		}

		// Token: 0x060243C1 RID: 148417 RVA: 0x000C3870 File Offset: 0x000C1A70
		[Token(Token = "0x60243C1")]
		[Address(RVA = "0x1F141E0", Offset = "0x1F12DE0", VA = "0x181F141E0")]
		private bool _TryLoadFrameView(string panelPath, UIAssetLoader assetLoader)
		{
			return default(bool);
		}

		// Token: 0x060243C2 RID: 148418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243C2")]
		[Address(RVA = "0x1F14330", Offset = "0x1F12F30", VA = "0x181F14330")]
		public BattleFinishDropRewardFrameHolder()
		{
		}

		// Token: 0x0403261E RID: 206366
		[Token(Token = "0x403261E")]
		private const int DEFAULT_LAYOUT_PADDING_LEFT = 8;

		// Token: 0x0403261F RID: 206367
		[Token(Token = "0x403261F")]
		private const int DEFAULT_LAYOUT_PADDING_RIGHT = 0;

		// Token: 0x04032620 RID: 206368
		[Token(Token = "0x4032620")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _frameViewRoot;

		// Token: 0x04032621 RID: 206369
		[Token(Token = "0x4032621")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LayoutGroup _rewardLayout;

		// Token: 0x04032622 RID: 206370
		[Token(Token = "0x4032622")]
		[FieldOffset(Offset = "0x28")]
		private BattleFinishDropRewardFrameView m_frameView;

		// Token: 0x04032623 RID: 206371
		[Token(Token = "0x4032623")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__ClearFrameView;

		// Token: 0x04032624 RID: 206372
		[Token(Token = "0x4032624")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderFrameView;

		// Token: 0x04032625 RID: 206373
		[Token(Token = "0x4032625")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ResetRewardLayout;

		// Token: 0x04032626 RID: 206374
		[Token(Token = "0x4032626")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryLoadFrameView;

		// Token: 0x04032627 RID: 206375
		[Token(Token = "0x4032627")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
