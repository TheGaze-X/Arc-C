using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004016 RID: 16406
	[Token(Token = "0x2004016")]
	public class SandboxPermDiffItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601967F RID: 104063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601967F")]
		[Address(RVA = "0x1215380", Offset = "0x1213F80", VA = "0x181215380")]
		public void Render(SandboxPermDiffViewModel viewModel)
		{
		}

		// Token: 0x06019680 RID: 104064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019680")]
		[Address(RVA = "0x1215280", Offset = "0x1213E80", VA = "0x181215280")]
		public void OnSelectDiff()
		{
		}

		// Token: 0x06019681 RID: 104065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019681")]
		[Address(RVA = "0x1215600", Offset = "0x1214200", VA = "0x181215600")]
		public SandboxPermDiffItem()
		{
		}

		// Token: 0x0401F9B0 RID: 129456
		[Token(Token = "0x401F9B0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _title;

		// Token: 0x0401F9B1 RID: 129457
		[Token(Token = "0x401F9B1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x0401F9B2 RID: 129458
		[Token(Token = "0x401F9B2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _descText;

		// Token: 0x0401F9B3 RID: 129459
		[Token(Token = "0x401F9B3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _titleUnSelected;

		// Token: 0x0401F9B4 RID: 129460
		[Token(Token = "0x401F9B4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _detailTextUnSelected;

		// Token: 0x0401F9B5 RID: 129461
		[Token(Token = "0x401F9B5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _descTextUnselected;

		// Token: 0x0401F9B6 RID: 129462
		[Token(Token = "0x401F9B6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _isSelected;

		// Token: 0x0401F9B7 RID: 129463
		[Token(Token = "0x401F9B7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _notSelected;

		// Token: 0x0401F9B8 RID: 129464
		[Token(Token = "0x401F9B8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _modeIcon;

		// Token: 0x0401F9B9 RID: 129465
		[Token(Token = "0x401F9B9")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401F9BA RID: 129466
		[Token(Token = "0x401F9BA")]
		[FieldOffset(Offset = "0x70")]
		private SandboxPermDiffViewModel m_viewModel;

		// Token: 0x0401F9BB RID: 129467
		[Token(Token = "0x401F9BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F9BC RID: 129468
		[Token(Token = "0x401F9BC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSelectDiff;

		// Token: 0x0401F9BD RID: 129469
		[Token(Token = "0x401F9BD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
