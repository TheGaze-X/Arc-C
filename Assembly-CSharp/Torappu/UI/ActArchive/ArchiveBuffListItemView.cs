using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B17 RID: 27415
	[Token(Token = "0x2006B17")]
	public class ArchiveBuffListItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027326 RID: 160550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027326")]
		[Address(RVA = "0x2262EA0", Offset = "0x2261AA0", VA = "0x182262EA0")]
		public void Render(BuffItemViewModel viewModel)
		{
		}

		// Token: 0x06027327 RID: 160551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027327")]
		[Address(RVA = "0x2262DC0", Offset = "0x22619C0", VA = "0x182262DC0")]
		public void OnItemClicked()
		{
		}

		// Token: 0x06027328 RID: 160552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027328")]
		[Address(RVA = "0x22630E0", Offset = "0x2261CE0", VA = "0x1822630E0")]
		public ArchiveBuffListItemView()
		{
		}

		// Token: 0x04037739 RID: 227129
		[Token(Token = "0x4037739")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0403773A RID: 227130
		[Token(Token = "0x403773A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelSelect;

		// Token: 0x0403773B RID: 227131
		[Token(Token = "0x403773B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelNew;

		// Token: 0x0403773C RID: 227132
		[Token(Token = "0x403773C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403773D RID: 227133
		[Token(Token = "0x403773D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _selectColor;

		// Token: 0x0403773E RID: 227134
		[Token(Token = "0x403773E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _unselectColor;

		// Token: 0x0403773F RID: 227135
		[Token(Token = "0x403773F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _lockedColor;

		// Token: 0x04037740 RID: 227136
		[Token(Token = "0x4037740")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action<string> onItemClick;

		// Token: 0x04037741 RID: 227137
		[Token(Token = "0x4037741")]
		[FieldOffset(Offset = "0x70")]
		private BuffItemViewModel m_cachedViewModel;

		// Token: 0x04037742 RID: 227138
		[Token(Token = "0x4037742")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037743 RID: 227139
		[Token(Token = "0x4037743")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnItemClicked;

		// Token: 0x04037744 RID: 227140
		[Token(Token = "0x4037744")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
