using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x020048A6 RID: 18598
	[Token(Token = "0x20048A6")]
	public class MissionRewardPreviewItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C109 RID: 114953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C109")]
		[Address(RVA = "0x156CA40", Offset = "0x156B640", VA = "0x18156CA40")]
		public void Render(UIItemViewModel viewModel)
		{
		}

		// Token: 0x0601C10A RID: 114954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C10A")]
		[Address(RVA = "0x156CC90", Offset = "0x156B890", VA = "0x18156CC90", Slot = "4")]
		protected virtual void _InitIfNeeded()
		{
		}

		// Token: 0x0601C10B RID: 114955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C10B")]
		[Address(RVA = "0x156CEA0", Offset = "0x156BAA0", VA = "0x18156CEA0")]
		public MissionRewardPreviewItem()
		{
		}

		// Token: 0x04024A72 RID: 150130
		[Token(Token = "0x4024A72")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform _itemCardContainer;

		// Token: 0x04024A73 RID: 150131
		[Token(Token = "0x4024A73")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected float _cardScaleFactor;

		// Token: 0x04024A74 RID: 150132
		[Token(Token = "0x4024A74")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected bool _showItemNum;

		// Token: 0x04024A75 RID: 150133
		[Token(Token = "0x4024A75")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _countPanel;

		// Token: 0x04024A76 RID: 150134
		[Token(Token = "0x4024A76")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _countLabel;

		// Token: 0x04024A77 RID: 150135
		[Token(Token = "0x4024A77")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _useOriginCountLabel;

		// Token: 0x04024A78 RID: 150136
		[Token(Token = "0x4024A78")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool _usePreviewCountLabel;

		// Token: 0x04024A79 RID: 150137
		[Token(Token = "0x4024A79")]
		[FieldOffset(Offset = "0x3A")]
		[SerializeField]
		private bool _useOriginCountBackground;

		// Token: 0x04024A7A RID: 150138
		[Token(Token = "0x4024A7A")]
		[FieldOffset(Offset = "0x40")]
		protected UIItemCard m_itemCard;

		// Token: 0x04024A7B RID: 150139
		[Token(Token = "0x4024A7B")]
		[FieldOffset(Offset = "0x48")]
		protected UIItemViewModel m_viewModel;

		// Token: 0x04024A7C RID: 150140
		[Token(Token = "0x4024A7C")]
		[FieldOffset(Offset = "0x50")]
		protected bool m_isInited;

		// Token: 0x04024A7D RID: 150141
		[Token(Token = "0x4024A7D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024A7E RID: 150142
		[Token(Token = "0x4024A7E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNeeded;

		// Token: 0x04024A7F RID: 150143
		[Token(Token = "0x4024A7F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
