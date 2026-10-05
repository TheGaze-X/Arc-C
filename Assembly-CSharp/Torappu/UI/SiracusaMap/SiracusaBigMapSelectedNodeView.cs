using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F7D RID: 16253
	[Token(Token = "0x2003F7D")]
	public class SiracusaBigMapSelectedNodeView : SiracusaMapNodeViewBase
	{
		// Token: 0x06019370 RID: 103280 RVA: 0x0009D440 File Offset: 0x0009B640
		[Token(Token = "0x6019370")]
		[Address(RVA = "0x11E5240", Offset = "0x11E3E40", VA = "0x1811E5240", Slot = "4")]
		public override SiracusaMapNodeViewBase.ViewType GetViewType()
		{
			return SiracusaMapNodeViewBase.ViewType.NORMAL;
		}

		// Token: 0x06019371 RID: 103281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019371")]
		[Address(RVA = "0x11E5460", Offset = "0x11E4060", VA = "0x1811E5460", Slot = "5")]
		public override void Render(SiracusaMapMapNodeViewModel viewModel)
		{
		}

		// Token: 0x06019372 RID: 103282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019372")]
		[Address(RVA = "0x11E5770", Offset = "0x11E4370", VA = "0x1811E5770", Slot = "6")]
		public override void Show(bool isFastMode)
		{
		}

		// Token: 0x06019373 RID: 103283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019373")]
		[Address(RVA = "0x11E52A0", Offset = "0x11E3EA0", VA = "0x1811E52A0", Slot = "7")]
		public override void Hide(bool isFastMode)
		{
		}

		// Token: 0x06019374 RID: 103284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019374")]
		[Address(RVA = "0x11E58C0", Offset = "0x11E44C0", VA = "0x1811E58C0")]
		public SiracusaBigMapSelectedNodeView()
		{
		}

		// Token: 0x06019376 RID: 103286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019376")]
		[Address(RVA = "0x11E5190", Offset = "0x11E3D90", VA = "0x1811E5190")]
		private void <>xLuaBaseProxy_Show(bool P0)
		{
		}

		// Token: 0x06019377 RID: 103287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019377")]
		[Address(RVA = "0x11E5180", Offset = "0x11E3D80", VA = "0x1811E5180")]
		private void <>xLuaBaseProxy_Hide(bool P0)
		{
		}

		// Token: 0x0401F455 RID: 128085
		[Token(Token = "0x401F455")]
		private const string ANIM_SELECT_ENTER = "large_map_pos_enter_select";

		// Token: 0x0401F456 RID: 128086
		[Token(Token = "0x401F456")]
		private const string ANIM_SELECT_EXIT = "large_map_pos_exit_select";

		// Token: 0x0401F457 RID: 128087
		[Token(Token = "0x401F457")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIDynImage _imgLogo;

		// Token: 0x0401F458 RID: 128088
		[Token(Token = "0x401F458")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtName;

		// Token: 0x0401F459 RID: 128089
		[Token(Token = "0x401F459")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private StageRankView _stageRankView;

		// Token: 0x0401F45A RID: 128090
		[Token(Token = "0x401F45A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0401F45B RID: 128091
		[Token(Token = "0x401F45B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _imgCornerFlag;

		// Token: 0x0401F45C RID: 128092
		[Token(Token = "0x401F45C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0401F45D RID: 128093
		[Token(Token = "0x401F45D")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_tween;

		// Token: 0x0401F45E RID: 128094
		[Token(Token = "0x401F45E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0401F45F RID: 128095
		[Token(Token = "0x401F45F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F460 RID: 128096
		[Token(Token = "0x401F460")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0401F461 RID: 128097
		[Token(Token = "0x401F461")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0401F462 RID: 128098
		[Token(Token = "0x401F462")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
