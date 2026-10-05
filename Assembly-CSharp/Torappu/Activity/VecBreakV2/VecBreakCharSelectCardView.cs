using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.TemplateCharSelect;
using Torappu.UI.TemplateCharSelect.Common;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E77 RID: 28279
	[Token(Token = "0x2006E77")]
	public class VecBreakCharSelectCardView : TemplateCharSelectCardView
	{
		// Token: 0x060283D7 RID: 164823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283D7")]
		[Address(RVA = "0x2388E70", Offset = "0x2387A70", VA = "0x182388E70", Slot = "6")]
		protected override void DoRender(TemplateCharSelectCardViewModel viewModel)
		{
		}

		// Token: 0x060283D8 RID: 164824 RVA: 0x000D0F80 File Offset: 0x000CF180
		[Token(Token = "0x60283D8")]
		[Address(RVA = "0x2389150", Offset = "0x2387D50", VA = "0x182389150", Slot = "7")]
		protected override bool OnCheckClick()
		{
			return default(bool);
		}

		// Token: 0x060283D9 RID: 164825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283D9")]
		[Address(RVA = "0x23891D0", Offset = "0x2387DD0", VA = "0x1823891D0")]
		public VecBreakCharSelectCardView()
		{
		}

		// Token: 0x060283DA RID: 164826 RVA: 0x000D0F98 File Offset: 0x000CF198
		[Token(Token = "0x60283DA")]
		[Address(RVA = "0x23891C0", Offset = "0x2387DC0", VA = "0x1823891C0")]
		private bool <>xLuaBaseProxy_OnCheckClick()
		{
			return default(bool);
		}

		// Token: 0x04039317 RID: 234263
		[Token(Token = "0x4039317")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _transPanelHolder;

		// Token: 0x04039318 RID: 234264
		[Token(Token = "0x4039318")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _defenseOtherGO;

		// Token: 0x04039319 RID: 234265
		[Token(Token = "0x4039319")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CommonCharSelectCardDefaultPanel _defaultPanelPrefab;

		// Token: 0x0403931A RID: 234266
		[Token(Token = "0x403931A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIColorGraphic _graphic;

		// Token: 0x0403931B RID: 234267
		[Token(Token = "0x403931B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textDefendOtherHint;

		// Token: 0x0403931C RID: 234268
		[Token(Token = "0x403931C")]
		[FieldOffset(Offset = "0x70")]
		private CommonCharSelectCardDefaultPanel m_defaultPanel;

		// Token: 0x0403931D RID: 234269
		[Token(Token = "0x403931D")]
		[FieldOffset(Offset = "0x78")]
		private VecBreakSquadCharSelectCardViewModel m_viewModel;

		// Token: 0x0403931E RID: 234270
		[Token(Token = "0x403931E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoRender;

		// Token: 0x0403931F RID: 234271
		[Token(Token = "0x403931F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCheckClick;

		// Token: 0x04039320 RID: 234272
		[Token(Token = "0x4039320")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
