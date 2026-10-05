using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F7C RID: 16252
	[Token(Token = "0x2003F7C")]
	public class SiracusaBigMapNormalNodeView : SiracusaMapNodeViewBase
	{
		// Token: 0x06019367 RID: 103271 RVA: 0x0009D428 File Offset: 0x0009B628
		[Token(Token = "0x6019367")]
		[Address(RVA = "0x11E4B80", Offset = "0x11E3780", VA = "0x1811E4B80", Slot = "4")]
		public override SiracusaMapNodeViewBase.ViewType GetViewType()
		{
			return SiracusaMapNodeViewBase.ViewType.NORMAL;
		}

		// Token: 0x06019368 RID: 103272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019368")]
		[Address(RVA = "0x11E4C80", Offset = "0x11E3880", VA = "0x1811E4C80", Slot = "5")]
		public override void Render(SiracusaMapMapNodeViewModel viewModel)
		{
		}

		// Token: 0x06019369 RID: 103273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019369")]
		[Address(RVA = "0x11E4FA0", Offset = "0x11E3BA0", VA = "0x1811E4FA0", Slot = "6")]
		public override void Show(bool isFastMode)
		{
		}

		// Token: 0x0601936A RID: 103274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601936A")]
		[Address(RVA = "0x11E4BE0", Offset = "0x11E37E0", VA = "0x1811E4BE0", Slot = "7")]
		public override void Hide(bool isFastMode)
		{
		}

		// Token: 0x0601936B RID: 103275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601936B")]
		[Address(RVA = "0x11E4A70", Offset = "0x11E3670", VA = "0x1811E4A70")]
		public void EventOnNodeClicked()
		{
		}

		// Token: 0x0601936C RID: 103276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601936C")]
		[Address(RVA = "0x11E51A0", Offset = "0x11E3DA0", VA = "0x1811E51A0")]
		public SiracusaBigMapNormalNodeView()
		{
		}

		// Token: 0x0601936E RID: 103278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601936E")]
		[Address(RVA = "0x11E5190", Offset = "0x11E3D90", VA = "0x1811E5190")]
		private void <>xLuaBaseProxy_Show(bool P0)
		{
		}

		// Token: 0x0601936F RID: 103279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601936F")]
		[Address(RVA = "0x11E5180", Offset = "0x11E3D80", VA = "0x1811E5180")]
		private void <>xLuaBaseProxy_Hide(bool P0)
		{
		}

		// Token: 0x0401F446 RID: 128070
		[Token(Token = "0x401F446")]
		private const string ANIM_NORMAL_ENTER = "large_map_pos_enter_normal";

		// Token: 0x0401F447 RID: 128071
		[Token(Token = "0x401F447")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIDynImage _imgLogo;

		// Token: 0x0401F448 RID: 128072
		[Token(Token = "0x401F448")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtName;

		// Token: 0x0401F449 RID: 128073
		[Token(Token = "0x401F449")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private StageRankView _stageRankView;

		// Token: 0x0401F44A RID: 128074
		[Token(Token = "0x401F44A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0401F44B RID: 128075
		[Token(Token = "0x401F44B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _imgCornerFlag;

		// Token: 0x0401F44C RID: 128076
		[Token(Token = "0x401F44C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0401F44D RID: 128077
		[Token(Token = "0x401F44D")]
		[FieldOffset(Offset = "0x58")]
		private SiracusaMapMapNodeViewModel m_viewModel;

		// Token: 0x0401F44E RID: 128078
		[Token(Token = "0x401F44E")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_tween;

		// Token: 0x0401F44F RID: 128079
		[Token(Token = "0x401F44F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0401F450 RID: 128080
		[Token(Token = "0x401F450")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F451 RID: 128081
		[Token(Token = "0x401F451")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0401F452 RID: 128082
		[Token(Token = "0x401F452")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0401F453 RID: 128083
		[Token(Token = "0x401F453")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnNodeClicked;

		// Token: 0x0401F454 RID: 128084
		[Token(Token = "0x401F454")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
