using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F7F RID: 16255
	[Token(Token = "0x2003F7F")]
	public class SiracusaBigMapTaskNodeView : SiracusaMapNodeViewBase
	{
		// Token: 0x0601937E RID: 103294 RVA: 0x0009D470 File Offset: 0x0009B670
		[Token(Token = "0x601937E")]
		[Address(RVA = "0x11E5F80", Offset = "0x11E4B80", VA = "0x1811E5F80", Slot = "4")]
		public override SiracusaMapNodeViewBase.ViewType GetViewType()
		{
			return SiracusaMapNodeViewBase.ViewType.NORMAL;
		}

		// Token: 0x0601937F RID: 103295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601937F")]
		[Address(RVA = "0x11E60D0", Offset = "0x11E4CD0", VA = "0x1811E60D0", Slot = "5")]
		public override void Render(SiracusaMapMapNodeViewModel viewModel)
		{
		}

		// Token: 0x06019380 RID: 103296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019380")]
		[Address(RVA = "0x11E5FE0", Offset = "0x11E4BE0", VA = "0x1811E5FE0", Slot = "7")]
		public override void Hide(bool isFastMode)
		{
		}

		// Token: 0x06019381 RID: 103297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019381")]
		[Address(RVA = "0x11E6500", Offset = "0x11E5100", VA = "0x1811E6500")]
		private void _TryToPlayTriangleTween()
		{
		}

		// Token: 0x06019382 RID: 103298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019382")]
		[Address(RVA = "0x11E6480", Offset = "0x11E5080", VA = "0x1811E6480")]
		private void _StopTween()
		{
		}

		// Token: 0x06019383 RID: 103299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019383")]
		[Address(RVA = "0x11E6370", Offset = "0x11E4F70", VA = "0x1811E6370")]
		public void SetTaskCharAvatarHub(AutoPackSpriteHub spriteHub)
		{
		}

		// Token: 0x06019384 RID: 103300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019384")]
		[Address(RVA = "0x11E5E70", Offset = "0x11E4A70", VA = "0x1811E5E70")]
		public void EventOnNodeClicked()
		{
		}

		// Token: 0x06019385 RID: 103301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019385")]
		[Address(RVA = "0x11E6790", Offset = "0x11E5390", VA = "0x1811E6790")]
		public SiracusaBigMapTaskNodeView()
		{
		}

		// Token: 0x06019387 RID: 103303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019387")]
		[Address(RVA = "0x11E5180", Offset = "0x11E3D80", VA = "0x1811E5180")]
		private void <>xLuaBaseProxy_Hide(bool P0)
		{
		}

		// Token: 0x0401F470 RID: 128112
		[Token(Token = "0x401F470")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Graphic _graphicCharCard;

		// Token: 0x0401F471 RID: 128113
		[Token(Token = "0x401F471")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objAvatar;

		// Token: 0x0401F472 RID: 128114
		[Token(Token = "0x401F472")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIDynImage _imgLogo;

		// Token: 0x0401F473 RID: 128115
		[Token(Token = "0x401F473")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtName;

		// Token: 0x0401F474 RID: 128116
		[Token(Token = "0x401F474")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIDynImage _imgCharAvatar;

		// Token: 0x0401F475 RID: 128117
		[Token(Token = "0x401F475")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _imgTriangle;

		// Token: 0x0401F476 RID: 128118
		[Token(Token = "0x401F476")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _defaultWidth;

		// Token: 0x0401F477 RID: 128119
		[Token(Token = "0x401F477")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _stepWidth;

		// Token: 0x0401F478 RID: 128120
		[Token(Token = "0x401F478")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _stepCount;

		// Token: 0x0401F479 RID: 128121
		[Token(Token = "0x401F479")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _stepTime;

		// Token: 0x0401F47A RID: 128122
		[Token(Token = "0x401F47A")]
		[FieldOffset(Offset = "0x68")]
		private SiracusaMapMapNodeViewModel m_viewModel;

		// Token: 0x0401F47B RID: 128123
		[Token(Token = "0x401F47B")]
		[FieldOffset(Offset = "0x70")]
		private AutoPackSpriteHub m_taskCharAvatarHub;

		// Token: 0x0401F47C RID: 128124
		[Token(Token = "0x401F47C")]
		[FieldOffset(Offset = "0x78")]
		private Tweener m_tweener;

		// Token: 0x0401F47D RID: 128125
		[Token(Token = "0x401F47D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0401F47E RID: 128126
		[Token(Token = "0x401F47E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F47F RID: 128127
		[Token(Token = "0x401F47F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0401F480 RID: 128128
		[Token(Token = "0x401F480")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryToPlayTriangleTween;

		// Token: 0x0401F481 RID: 128129
		[Token(Token = "0x401F481")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__StopTween;

		// Token: 0x0401F482 RID: 128130
		[Token(Token = "0x401F482")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetTaskCharAvatarHub;

		// Token: 0x0401F483 RID: 128131
		[Token(Token = "0x401F483")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnNodeClicked;

		// Token: 0x0401F484 RID: 128132
		[Token(Token = "0x401F484")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
