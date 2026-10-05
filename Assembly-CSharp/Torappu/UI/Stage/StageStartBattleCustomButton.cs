using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006981 RID: 27009
	[Token(Token = "0x2006981")]
	public class StageStartBattleCustomButton : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026A57 RID: 158295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A57")]
		[Address(RVA = "0x21BC570", Offset = "0x21BB170", VA = "0x1821BC570")]
		public void SetStartBattleEvent(Button.ButtonClickedEvent clickEvent)
		{
		}

		// Token: 0x06026A58 RID: 158296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A58")]
		[Address(RVA = "0x21BC260", Offset = "0x21BAE60", VA = "0x1821BC260")]
		public void Render(PreviewConfigViewModel stageModel, UIPage page)
		{
		}

		// Token: 0x06026A59 RID: 158297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026A59")]
		[Address(RVA = "0x21BC600", Offset = "0x21BB200", VA = "0x1821BC600")]
		private string _PickConstStyleId(PreviewConfigViewModel stageModel)
		{
			return null;
		}

		// Token: 0x06026A5A RID: 158298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A5A")]
		[Address(RVA = "0x21BC6E0", Offset = "0x21BB2E0", VA = "0x1821BC6E0")]
		public StageStartBattleCustomButton()
		{
		}

		// Token: 0x040368F6 RID: 223478
		[Token(Token = "0x40368F6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _btnStartBattle;

		// Token: 0x040368F7 RID: 223479
		[Token(Token = "0x40368F7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _bkgCost;

		// Token: 0x040368F8 RID: 223480
		[Token(Token = "0x40368F8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgStartBattle;

		// Token: 0x040368F9 RID: 223481
		[Token(Token = "0x40368F9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textCost;

		// Token: 0x040368FA RID: 223482
		[Token(Token = "0x40368FA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _diffGroupObj;

		// Token: 0x040368FB RID: 223483
		[Token(Token = "0x40368FB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _groupApCostColor;

		// Token: 0x040368FC RID: 223484
		[Token(Token = "0x40368FC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _commonApCostColor;

		// Token: 0x040368FD RID: 223485
		[Token(Token = "0x40368FD")]
		[FieldOffset(Offset = "0x60")]
		private string m_styleId;

		// Token: 0x040368FE RID: 223486
		[Token(Token = "0x40368FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetStartBattleEvent;

		// Token: 0x040368FF RID: 223487
		[Token(Token = "0x40368FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036900 RID: 223488
		[Token(Token = "0x4036900")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PickConstStyleId;

		// Token: 0x04036901 RID: 223489
		[Token(Token = "0x4036901")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
