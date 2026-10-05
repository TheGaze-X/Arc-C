using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.TemplateTrap;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act32side
{
	// Token: 0x02007488 RID: 29832
	[Token(Token = "0x2007488")]
	public class Act32SideTrapSelectItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A12B RID: 172331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A12B")]
		[Address(RVA = "0x25BD390", Offset = "0x25BBF90", VA = "0x1825BD390")]
		public void RenderSelectTrap(int index, TemplateTrapViewModel viewModel)
		{
		}

		// Token: 0x0602A12C RID: 172332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A12C")]
		[Address(RVA = "0x25BD310", Offset = "0x25BBF10", VA = "0x1825BD310")]
		public void OnClick()
		{
		}

		// Token: 0x0602A12D RID: 172333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A12D")]
		[Address(RVA = "0x25BD5E0", Offset = "0x25BC1E0", VA = "0x1825BD5E0")]
		public Act32SideTrapSelectItemView()
		{
		}

		// Token: 0x0403C631 RID: 247345
		[Token(Token = "0x403C631")]
		private const string UI_ICON_IMG = "{0}_icon";

		// Token: 0x0403C632 RID: 247346
		[Token(Token = "0x403C632")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _iconImg;

		// Token: 0x0403C633 RID: 247347
		[Token(Token = "0x403C633")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _name;

		// Token: 0x0403C634 RID: 247348
		[Token(Token = "0x403C634")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _detail;

		// Token: 0x0403C635 RID: 247349
		[Token(Token = "0x403C635")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _selectItem;

		// Token: 0x0403C636 RID: 247350
		[Token(Token = "0x403C636")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _notSelectItem;

		// Token: 0x0403C637 RID: 247351
		[Token(Token = "0x403C637")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0403C638 RID: 247352
		[Token(Token = "0x403C638")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _animClip;

		// Token: 0x0403C639 RID: 247353
		[Token(Token = "0x403C639")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action<string, int> onSelectAction;

		// Token: 0x0403C63A RID: 247354
		[Token(Token = "0x403C63A")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public UIAtlasObject trapHub;

		// Token: 0x0403C63B RID: 247355
		[Token(Token = "0x403C63B")]
		[FieldOffset(Offset = "0x60")]
		private int m_index;

		// Token: 0x0403C63C RID: 247356
		[Token(Token = "0x403C63C")]
		[FieldOffset(Offset = "0x68")]
		private TemplateTrapViewModel m_viewModel;

		// Token: 0x0403C63D RID: 247357
		[Token(Token = "0x403C63D")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_tween;

		// Token: 0x0403C63E RID: 247358
		[Token(Token = "0x403C63E")]
		[FieldOffset(Offset = "0x78")]
		private string m_cacheSelectId;

		// Token: 0x0403C63F RID: 247359
		[Token(Token = "0x403C63F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderSelectTrap;

		// Token: 0x0403C640 RID: 247360
		[Token(Token = "0x403C640")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403C641 RID: 247361
		[Token(Token = "0x403C641")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
