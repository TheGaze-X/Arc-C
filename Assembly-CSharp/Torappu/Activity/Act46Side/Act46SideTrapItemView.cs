using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.TemplateTrap;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act46Side
{
	// Token: 0x020072A8 RID: 29352
	[Token(Token = "0x20072A8")]
	public class Act46SideTrapItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006245 RID: 25157
		// (get) Token: 0x060298DE RID: 170206 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060298DF RID: 170207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006245")]
		public Action<string> onClicked
		{
			[Token(Token = "0x60298DE")]
			[Address(RVA = "0x24FF290", Offset = "0x24FDE90", VA = "0x1824FF290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60298DF")]
			[Address(RVA = "0x24FF2F0", Offset = "0x24FDEF0", VA = "0x1824FF2F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060298E0 RID: 170208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298E0")]
		[Address(RVA = "0x24FF120", Offset = "0x24FDD20", VA = "0x1824FF120")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060298E1 RID: 170209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298E1")]
		[Address(RVA = "0x24FED30", Offset = "0x24FD930", VA = "0x1824FED30")]
		public void Render(TemplateTrapViewModel viewModel)
		{
		}

		// Token: 0x060298E2 RID: 170210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298E2")]
		[Address(RVA = "0x24FEC60", Offset = "0x24FD860", VA = "0x1824FEC60")]
		public void OnClicked()
		{
		}

		// Token: 0x060298E3 RID: 170211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298E3")]
		[Address(RVA = "0x24FF230", Offset = "0x24FDE30", VA = "0x1824FF230")]
		public Act46SideTrapItemView()
		{
		}

		// Token: 0x0403B693 RID: 243347
		[Token(Token = "0x403B693")]
		private const string FORMAT_COUNT = "X{0}";

		// Token: 0x0403B694 RID: 243348
		[Token(Token = "0x403B694")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0403B695 RID: 243349
		[Token(Token = "0x403B695")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0403B696 RID: 243350
		[Token(Token = "0x403B696")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0403B697 RID: 243351
		[Token(Token = "0x403B697")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _animSelect;

		// Token: 0x0403B698 RID: 243352
		[Token(Token = "0x403B698")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x0403B699 RID: 243353
		[Token(Token = "0x403B699")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _pnlLocked;

		// Token: 0x0403B69A RID: 243354
		[Token(Token = "0x403B69A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _canvasBtn;

		// Token: 0x0403B69B RID: 243355
		[Token(Token = "0x403B69B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textLockedDesc;

		// Token: 0x0403B69C RID: 243356
		[Token(Token = "0x403B69C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _newTrackPoint;

		// Token: 0x0403B69D RID: 243357
		[Token(Token = "0x403B69D")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedTrapId;

		// Token: 0x0403B69E RID: 243358
		[Token(Token = "0x403B69E")]
		[FieldOffset(Offset = "0x70")]
		private int m_cachedCount;

		// Token: 0x0403B69F RID: 243359
		[Token(Token = "0x403B69F")]
		[FieldOffset(Offset = "0x78")]
		private UISwitchTween m_selectTween;

		// Token: 0x0403B6A0 RID: 243360
		[Token(Token = "0x403B6A0")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x0403B6A1 RID: 243361
		[Token(Token = "0x403B6A1")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403B6A3 RID: 243363
		[Token(Token = "0x403B6A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClicked;

		// Token: 0x0403B6A4 RID: 243364
		[Token(Token = "0x403B6A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClicked;

		// Token: 0x0403B6A5 RID: 243365
		[Token(Token = "0x403B6A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B6A6 RID: 243366
		[Token(Token = "0x403B6A6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403B6A7 RID: 243367
		[Token(Token = "0x403B6A7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClicked;

		// Token: 0x0403B6A8 RID: 243368
		[Token(Token = "0x403B6A8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
