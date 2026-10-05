using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F97 RID: 16279
	[Token(Token = "0x2003F97")]
	public class SiracusaSmallMapSelectedNodeView : SiracusaMapNodeViewBase
	{
		// Token: 0x06019400 RID: 103424 RVA: 0x0009D5C0 File Offset: 0x0009B7C0
		[Token(Token = "0x6019400")]
		[Address(RVA = "0x11F6120", Offset = "0x11F4D20", VA = "0x1811F6120", Slot = "4")]
		public override SiracusaMapNodeViewBase.ViewType GetViewType()
		{
			return SiracusaMapNodeViewBase.ViewType.NORMAL;
		}

		// Token: 0x06019401 RID: 103425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019401")]
		[Address(RVA = "0x11F6340", Offset = "0x11F4F40", VA = "0x1811F6340", Slot = "5")]
		public override void Render(SiracusaMapMapNodeViewModel viewModel)
		{
		}

		// Token: 0x06019402 RID: 103426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019402")]
		[Address(RVA = "0x11F6490", Offset = "0x11F5090", VA = "0x1811F6490", Slot = "6")]
		public override void Show(bool isFastMode)
		{
		}

		// Token: 0x06019403 RID: 103427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019403")]
		[Address(RVA = "0x11F6180", Offset = "0x11F4D80", VA = "0x1811F6180", Slot = "7")]
		public override void Hide(bool isFastMode)
		{
		}

		// Token: 0x06019404 RID: 103428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019404")]
		[Address(RVA = "0x11F6600", Offset = "0x11F5200", VA = "0x1811F6600")]
		public SiracusaSmallMapSelectedNodeView()
		{
		}

		// Token: 0x06019406 RID: 103430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019406")]
		[Address(RVA = "0x11E5190", Offset = "0x11E3D90", VA = "0x1811E5190")]
		private void <>xLuaBaseProxy_Show(bool P0)
		{
		}

		// Token: 0x06019407 RID: 103431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019407")]
		[Address(RVA = "0x11E5180", Offset = "0x11E3D80", VA = "0x1811E5180")]
		private void <>xLuaBaseProxy_Hide(bool P0)
		{
		}

		// Token: 0x0401F573 RID: 128371
		[Token(Token = "0x401F573")]
		private const string ANIM_SELECT_ENTER = "small_map_pos_enter_select";

		// Token: 0x0401F574 RID: 128372
		[Token(Token = "0x401F574")]
		private const string ANIM_SELECT_EXIT = "small_map_pos_exit_select";

		// Token: 0x0401F575 RID: 128373
		[Token(Token = "0x401F575")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIDynImage _imgLogo;

		// Token: 0x0401F576 RID: 128374
		[Token(Token = "0x401F576")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtName;

		// Token: 0x0401F577 RID: 128375
		[Token(Token = "0x401F577")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0401F578 RID: 128376
		[Token(Token = "0x401F578")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_tween;

		// Token: 0x0401F579 RID: 128377
		[Token(Token = "0x401F579")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0401F57A RID: 128378
		[Token(Token = "0x401F57A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F57B RID: 128379
		[Token(Token = "0x401F57B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0401F57C RID: 128380
		[Token(Token = "0x401F57C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0401F57D RID: 128381
		[Token(Token = "0x401F57D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
