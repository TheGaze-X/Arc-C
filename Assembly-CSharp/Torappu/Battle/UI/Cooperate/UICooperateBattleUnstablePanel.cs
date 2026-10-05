using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033D4 RID: 13268
	[Token(Token = "0x20033D4")]
	public class UICooperateBattleUnstablePanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x060152D8 RID: 86744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152D8")]
		[Address(RVA = "0xDA2170", Offset = "0xDA0D70", VA = "0x180DA2170")]
		public void InitLayout()
		{
		}

		// Token: 0x060152D9 RID: 86745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152D9")]
		[Address(RVA = "0xDA22E0", Offset = "0xDA0EE0", VA = "0x180DA22E0")]
		public void ShowDyingPanel()
		{
		}

		// Token: 0x060152DA RID: 86746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152DA")]
		[Address(RVA = "0xDA1F70", Offset = "0xDA0B70", VA = "0x180DA1F70")]
		public void ClearDyingPanel()
		{
		}

		// Token: 0x060152DB RID: 86747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152DB")]
		[Address(RVA = "0xDA23E0", Offset = "0xDA0FE0", VA = "0x180DA23E0")]
		public void ShowUnstablePanel()
		{
		}

		// Token: 0x060152DC RID: 86748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152DC")]
		[Address(RVA = "0xDA2060", Offset = "0xDA0C60", VA = "0x180DA2060")]
		public void ClearUnstablePanel()
		{
		}

		// Token: 0x060152DD RID: 86749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152DD")]
		[Address(RVA = "0xDA2630", Offset = "0xDA1230", VA = "0x180DA2630")]
		public UICooperateBattleUnstablePanel()
		{
		}

		// Token: 0x0401946C RID: 103532
		[Token(Token = "0x401946C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("dying")]
		private RectTransform _dyingPanel;

		// Token: 0x0401946D RID: 103533
		[Token(Token = "0x401946D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("dying")]
		private CanvasGroup _dyingCanvasGroup;

		// Token: 0x0401946E RID: 103534
		[Token(Token = "0x401946E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("dying")]
		private float _dyingFadeDuration;

		// Token: 0x0401946F RID: 103535
		[Token(Token = "0x401946F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("dying")]
		private AnimationWrapper _dyingWrapper;

		// Token: 0x04019470 RID: 103536
		[Token(Token = "0x4019470")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("dying")]
		private string _dyingAnimName;

		// Token: 0x04019471 RID: 103537
		[Token(Token = "0x4019471")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("connect")]
		private RectTransform _warningUnstablePanel;

		// Token: 0x04019472 RID: 103538
		[Token(Token = "0x4019472")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("connect")]
		private CanvasGroup _unstableCanvasGroup;

		// Token: 0x04019473 RID: 103539
		[Token(Token = "0x4019473")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("connect")]
		private float _unstableFadeDuration;

		// Token: 0x04019474 RID: 103540
		[Token(Token = "0x4019474")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("connect")]
		private AnimationWrapper _unstableWrapper;

		// Token: 0x04019475 RID: 103541
		[Token(Token = "0x4019475")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("connect")]
		private string _unstableEnterAnimName;

		// Token: 0x04019476 RID: 103542
		[Token(Token = "0x4019476")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("connect")]
		private string _unstableLoopAnimName;

		// Token: 0x04019477 RID: 103543
		[Token(Token = "0x4019477")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_loopTween;

		// Token: 0x04019478 RID: 103544
		[Token(Token = "0x4019478")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitLayout;

		// Token: 0x04019479 RID: 103545
		[Token(Token = "0x4019479")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowDyingPanel;

		// Token: 0x0401947A RID: 103546
		[Token(Token = "0x401947A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ClearDyingPanel;

		// Token: 0x0401947B RID: 103547
		[Token(Token = "0x401947B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowUnstablePanel;

		// Token: 0x0401947C RID: 103548
		[Token(Token = "0x401947C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ClearUnstablePanel;

		// Token: 0x0401947D RID: 103549
		[Token(Token = "0x401947D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
