using System;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040C2 RID: 16578
	[Token(Token = "0x20040C2")]
	public class SandboxV2AdminMainScienceDetailView : DataBinder<SandboxV2AdminMainSciencePanelModelProperty>
	{
		// Token: 0x06019A56 RID: 105046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A56")]
		[Address(RVA = "0x12776B0", Offset = "0x12762B0", VA = "0x1812776B0", Slot = "7")]
		public override void OnValueChanged(SandboxV2AdminMainSciencePanelModelProperty property)
		{
		}

		// Token: 0x06019A57 RID: 105047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A57")]
		[Address(RVA = "0x1277B70", Offset = "0x1276770", VA = "0x181277B70")]
		private void _RefreshDetail()
		{
		}

		// Token: 0x06019A58 RID: 105048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A58")]
		[Address(RVA = "0x1277A90", Offset = "0x1276690", VA = "0x181277A90")]
		private void _HidePanel([Optional] Action cb)
		{
		}

		// Token: 0x06019A59 RID: 105049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A59")]
		[Address(RVA = "0x1277EF0", Offset = "0x1276AF0", VA = "0x181277EF0")]
		private void _ShowPanel()
		{
		}

		// Token: 0x06019A5A RID: 105050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019A5A")]
		[Address(RVA = "0x12778C0", Offset = "0x12764C0", VA = "0x1812778C0")]
		private AnimationSwitchTween _EnsureSwitchTween()
		{
			return null;
		}

		// Token: 0x06019A5B RID: 105051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A5B")]
		[Address(RVA = "0x1277420", Offset = "0x1276020", VA = "0x181277420")]
		public void EventOnDevelop()
		{
		}

		// Token: 0x06019A5C RID: 105052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A5C")]
		[Address(RVA = "0x12775D0", Offset = "0x12761D0", VA = "0x1812775D0")]
		public void EventOnHide()
		{
		}

		// Token: 0x06019A5D RID: 105053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A5D")]
		[Address(RVA = "0x1277F70", Offset = "0x1276B70", VA = "0x181277F70")]
		public SandboxV2AdminMainScienceDetailView()
		{
		}

		// Token: 0x040200A7 RID: 131239
		[Token(Token = "0x40200A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _detailPanel;

		// Token: 0x040200A8 RID: 131240
		[Token(Token = "0x40200A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _nodeName;

		// Token: 0x040200A9 RID: 131241
		[Token(Token = "0x40200A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _nodeCode;

		// Token: 0x040200AA RID: 131242
		[Token(Token = "0x40200AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _nodeIcon;

		// Token: 0x040200AB RID: 131243
		[Token(Token = "0x40200AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _nodeDesc;

		// Token: 0x040200AC RID: 131244
		[Token(Token = "0x40200AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _developBtn;

		// Token: 0x040200AD RID: 131245
		[Token(Token = "0x40200AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _pointsCost;

		// Token: 0x040200AE RID: 131246
		[Token(Token = "0x40200AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textBtn;

		// Token: 0x040200AF RID: 131247
		[Token(Token = "0x40200AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIColorGraphic _btnGraphicGroup;

		// Token: 0x040200B0 RID: 131248
		[Token(Token = "0x40200B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _finishedPanel;

		// Token: 0x040200B1 RID: 131249
		[Token(Token = "0x40200B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIColorGraphic _graphics;

		// Token: 0x040200B2 RID: 131250
		[Token(Token = "0x40200B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _detailAnimLoc;

		// Token: 0x040200B3 RID: 131251
		[Token(Token = "0x40200B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Ease _animEase;

		// Token: 0x040200B4 RID: 131252
		[Token(Token = "0x40200B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private Color _developableTextColor;

		// Token: 0x040200B5 RID: 131253
		[Token(Token = "0x40200B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private Color _undevelopableTextColor;

		// Token: 0x040200B6 RID: 131254
		[Token(Token = "0x40200B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private Color _developableGraphicColor;

		// Token: 0x040200B7 RID: 131255
		[Token(Token = "0x40200B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private Color _undevelopableGraphicColor;

		// Token: 0x040200B8 RID: 131256
		[Token(Token = "0x40200B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[NonSerialized]
		public Action<string> onNodeDevelop;

		// Token: 0x040200B9 RID: 131257
		[Token(Token = "0x40200B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private string m_cachedNodeId;

		// Token: 0x040200BA RID: 131258
		[Token(Token = "0x40200BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private UIStateFinder m_finder;

		// Token: 0x040200BB RID: 131259
		[Token(Token = "0x40200BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private SandboxV2AdminMainScienceItemViewModel m_cacheItemViewModel;

		// Token: 0x040200BC RID: 131260
		[Token(Token = "0x40200BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private SandboxV2AdminMainSciencePanelModelProperty m_prop;

		// Token: 0x040200BD RID: 131261
		[Token(Token = "0x40200BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private AnimationSwitchTween m_switchTw;

		// Token: 0x040200BE RID: 131262
		[Token(Token = "0x40200BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040200BF RID: 131263
		[Token(Token = "0x40200BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RefreshDetail;

		// Token: 0x040200C0 RID: 131264
		[Token(Token = "0x40200C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__HidePanel;

		// Token: 0x040200C1 RID: 131265
		[Token(Token = "0x40200C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowPanel;

		// Token: 0x040200C2 RID: 131266
		[Token(Token = "0x40200C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EnsureSwitchTween;

		// Token: 0x040200C3 RID: 131267
		[Token(Token = "0x40200C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnDevelop;

		// Token: 0x040200C4 RID: 131268
		[Token(Token = "0x40200C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnHide;

		// Token: 0x040200C5 RID: 131269
		[Token(Token = "0x40200C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
