using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004974 RID: 18804
	[Token(Token = "0x2004974")]
	public class MedalGroupListItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C571 RID: 116081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C571")]
		[Address(RVA = "0x15CC720", Offset = "0x15CB320", VA = "0x1815CC720")]
		public void Render(MedalGroupViewModel viewModel, UIPage page)
		{
		}

		// Token: 0x0601C572 RID: 116082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C572")]
		[Address(RVA = "0x15CCCA0", Offset = "0x15CB8A0", VA = "0x1815CCCA0")]
		private void _UpdateGroupView(MedalGroupViewModel viewModel, UIPage page)
		{
		}

		// Token: 0x0601C573 RID: 116083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C573")]
		[Address(RVA = "0x15CC670", Offset = "0x15CB270", VA = "0x1815CC670")]
		public void OnClick()
		{
		}

		// Token: 0x0601C574 RID: 116084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C574")]
		[Address(RVA = "0x15CCF30", Offset = "0x15CBB30", VA = "0x1815CCF30")]
		public MedalGroupListItem()
		{
		}

		// Token: 0x0402515A RID: 151898
		[Token(Token = "0x402515A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x0402515B RID: 151899
		[Token(Token = "0x402515B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _groupName;

		// Token: 0x0402515C RID: 151900
		[Token(Token = "0x402515C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _groupDesc;

		// Token: 0x0402515D RID: 151901
		[Token(Token = "0x402515D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _templateContainer;

		// Token: 0x0402515E RID: 151902
		[Token(Token = "0x402515E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _getFlag;

		// Token: 0x0402515F RID: 151903
		[Token(Token = "0x402515F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _getTime;

		// Token: 0x04025160 RID: 151904
		[Token(Token = "0x4025160")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public UIStringEvent onClickEvent;

		// Token: 0x04025161 RID: 151905
		[Token(Token = "0x4025161")]
		[FieldOffset(Offset = "0x50")]
		private MedalGroupViewModel m_cacheViewModel;

		// Token: 0x04025162 RID: 151906
		[Token(Token = "0x4025162")]
		[FieldOffset(Offset = "0x58")]
		private UIMedalGroupView m_groupView;

		// Token: 0x04025163 RID: 151907
		[Token(Token = "0x4025163")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color BACK_COLOR;

		// Token: 0x04025164 RID: 151908
		[Token(Token = "0x4025164")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04025165 RID: 151909
		[Token(Token = "0x4025165")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateGroupView;

		// Token: 0x04025166 RID: 151910
		[Token(Token = "0x4025166")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04025167 RID: 151911
		[Token(Token = "0x4025167")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
