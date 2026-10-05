using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CA0 RID: 15520
	[Token(Token = "0x2003CA0")]
	public class TuningHomeHiddenInvestView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601839A RID: 99226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601839A")]
		[Address(RVA = "0x10B8080", Offset = "0x10B6C80", VA = "0x1810B8080")]
		public void Render(TuningHomeHiddenInvestViewModel viewModel)
		{
		}

		// Token: 0x0601839B RID: 99227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601839B")]
		[Address(RVA = "0x10B7F50", Offset = "0x10B6B50", VA = "0x1810B7F50")]
		public void EventOnStartInvestClicked()
		{
		}

		// Token: 0x0601839C RID: 99228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601839C")]
		[Address(RVA = "0x10B8280", Offset = "0x10B6E80", VA = "0x1810B8280")]
		public TuningHomeHiddenInvestView()
		{
		}

		// Token: 0x0401D84B RID: 120907
		[Token(Token = "0x401D84B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelUncomplete;

		// Token: 0x0401D84C RID: 120908
		[Token(Token = "0x401D84C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x0401D84D RID: 120909
		[Token(Token = "0x401D84D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgCharacter;

		// Token: 0x0401D84E RID: 120910
		[Token(Token = "0x401D84E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text[] _textNpcName;

		// Token: 0x0401D84F RID: 120911
		[Token(Token = "0x401D84F")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401D850 RID: 120912
		[Token(Token = "0x401D850")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D851 RID: 120913
		[Token(Token = "0x401D851")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnStartInvestClicked;

		// Token: 0x0401D852 RID: 120914
		[Token(Token = "0x401D852")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
