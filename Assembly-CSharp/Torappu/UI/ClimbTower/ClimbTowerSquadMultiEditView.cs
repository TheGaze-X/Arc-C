using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D84 RID: 23940
	[Token(Token = "0x2005D84")]
	public class ClimbTowerSquadMultiEditView : DataBinder<ClimbTowerSquadMultiEditProp>
	{
		// Token: 0x170051E5 RID: 20965
		// (get) Token: 0x06022B32 RID: 142130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170051E5")]
		public ClimbTowerSquadMultiEditGroupItemView itemPrefab
		{
			[Token(Token = "0x6022B32")]
			[Address(RVA = "0x1D41AD0", Offset = "0x1D406D0", VA = "0x181D41AD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170051E6 RID: 20966
		// (get) Token: 0x06022B33 RID: 142131 RVA: 0x000BE800 File Offset: 0x000BCA00
		// (set) Token: 0x06022B34 RID: 142132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051E6")]
		public bool needRebuild
		{
			[Token(Token = "0x6022B33")]
			[Address(RVA = "0x1D41B30", Offset = "0x1D40730", VA = "0x181D41B30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6022B34")]
			[Address(RVA = "0x1D41C50", Offset = "0x1D40850", VA = "0x181D41C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170051E7 RID: 20967
		// (get) Token: 0x06022B35 RID: 142133 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022B36 RID: 142134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051E7")]
		public Action<int, string> onSkillSelect
		{
			[Token(Token = "0x6022B35")]
			[Address(RVA = "0x1D41BF0", Offset = "0x1D407F0", VA = "0x181D41BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6022B36")]
			[Address(RVA = "0x1D41D40", Offset = "0x1D40940", VA = "0x181D41D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170051E8 RID: 20968
		// (get) Token: 0x06022B37 RID: 142135 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022B38 RID: 142136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051E8")]
		public Action<int, string> onEquipSelect
		{
			[Token(Token = "0x6022B37")]
			[Address(RVA = "0x1D41B90", Offset = "0x1D40790", VA = "0x181D41B90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6022B38")]
			[Address(RVA = "0x1D41CC0", Offset = "0x1D408C0", VA = "0x181D41CC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022B39 RID: 142137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B39")]
		[Address(RVA = "0x1D40E70", Offset = "0x1D3FA70", VA = "0x181D40E70", Slot = "7")]
		public override void OnValueChanged(ClimbTowerSquadMultiEditProp property)
		{
		}

		// Token: 0x06022B3A RID: 142138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B3A")]
		[Address(RVA = "0x1D417A0", Offset = "0x1D403A0", VA = "0x181D417A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022B3B RID: 142139 RVA: 0x000BE818 File Offset: 0x000BCA18
		[Token(Token = "0x6022B3B")]
		[Address(RVA = "0x1D411C0", Offset = "0x1D3FDC0", VA = "0x181D411C0")]
		private static float _CalculateVisibleColumnInsideChild(Bounds elementBounds, float viewportMin)
		{
			return 0f;
		}

		// Token: 0x06022B3C RID: 142140 RVA: 0x000BE830 File Offset: 0x000BCA30
		[Token(Token = "0x6022B3C")]
		[Address(RVA = "0x1D41700", Offset = "0x1D40300", VA = "0x181D41700")]
		private static float _GetPositionInsideChild(float columnIndex)
		{
			return 0f;
		}

		// Token: 0x06022B3D RID: 142141 RVA: 0x000BE848 File Offset: 0x000BCA48
		[Token(Token = "0x6022B3D")]
		[Address(RVA = "0x1D41570", Offset = "0x1D40170", VA = "0x181D41570")]
		private float _GetPositionFromIndex(int viewIndex, float columnIndex)
		{
			return 0f;
		}

		// Token: 0x06022B3E RID: 142142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B3E")]
		[Address(RVA = "0x1D412C0", Offset = "0x1D3FEC0", VA = "0x181D412C0")]
		private void _FocusToPos(float pos, bool fastMode)
		{
		}

		// Token: 0x06022B3F RID: 142143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B3F")]
		[Address(RVA = "0x1D40D60", Offset = "0x1D3F960", VA = "0x181D40D60")]
		public void OnProfessionClicked(ProfessionCategory profession)
		{
		}

		// Token: 0x06022B40 RID: 142144 RVA: 0x000BE860 File Offset: 0x000BCA60
		[Token(Token = "0x6022B40")]
		[Address(RVA = "0x1D408F0", Offset = "0x1D3F4F0", VA = "0x181D408F0")]
		public int GetCurrIndex(out float columnIndex)
		{
			return 0;
		}

		// Token: 0x06022B41 RID: 142145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B41")]
		[Address(RVA = "0x1D41A60", Offset = "0x1D40660", VA = "0x181D41A60")]
		public ClimbTowerSquadMultiEditView()
		{
		}

		// Token: 0x0402FB31 RID: 195377
		[Token(Token = "0x402FB31")]
		private const float FOCUS_TWEEN_DURATION = 0.23f;

		// Token: 0x0402FB32 RID: 195378
		[Token(Token = "0x402FB32")]
		private const float GROUP_VIEW_ELEMENT_WIDTH = 212f;

		// Token: 0x0402FB33 RID: 195379
		[Token(Token = "0x402FB33")]
		private const float GROUP_VIEW_ELEMENT_SPACING = 20f;

		// Token: 0x0402FB34 RID: 195380
		[Token(Token = "0x402FB34")]
		private const float GROUP_VIEW_HEADER_WIDTH = 85f;

		// Token: 0x0402FB35 RID: 195381
		[Token(Token = "0x402FB35")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ClimbTowerSquadMultiEditGroupItemView _groupItemPrefab;

		// Token: 0x0402FB36 RID: 195382
		[Token(Token = "0x402FB36")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIRecycleHorizonLayoutGroup _recycleSquadList;

		// Token: 0x0402FB37 RID: 195383
		[Token(Token = "0x402FB37")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x0402FB38 RID: 195384
		[Token(Token = "0x402FB38")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _viewport;

		// Token: 0x0402FB39 RID: 195385
		[Token(Token = "0x402FB39")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ScrollRect _scrollView;

		// Token: 0x0402FB3A RID: 195386
		[Token(Token = "0x402FB3A")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x0402FB3B RID: 195387
		[Token(Token = "0x402FB3B")]
		[FieldOffset(Offset = "0x58")]
		private ClimbTowerSquadMultiEditAdapter m_adapter;

		// Token: 0x0402FB3C RID: 195388
		[Token(Token = "0x402FB3C")]
		[FieldOffset(Offset = "0x60")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x0402FB3D RID: 195389
		[Token(Token = "0x402FB3D")]
		[FieldOffset(Offset = "0x68")]
		private Tween m_tween;

		// Token: 0x0402FB41 RID: 195393
		[Token(Token = "0x402FB41")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemPrefab;

		// Token: 0x0402FB42 RID: 195394
		[Token(Token = "0x402FB42")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needRebuild;

		// Token: 0x0402FB43 RID: 195395
		[Token(Token = "0x402FB43")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_needRebuild;

		// Token: 0x0402FB44 RID: 195396
		[Token(Token = "0x402FB44")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_onSkillSelect;

		// Token: 0x0402FB45 RID: 195397
		[Token(Token = "0x402FB45")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_onSkillSelect;

		// Token: 0x0402FB46 RID: 195398
		[Token(Token = "0x402FB46")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_onEquipSelect;

		// Token: 0x0402FB47 RID: 195399
		[Token(Token = "0x402FB47")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_onEquipSelect;

		// Token: 0x0402FB48 RID: 195400
		[Token(Token = "0x402FB48")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402FB49 RID: 195401
		[Token(Token = "0x402FB49")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402FB4A RID: 195402
		[Token(Token = "0x402FB4A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CalculateVisibleColumnInsideChild;

		// Token: 0x0402FB4B RID: 195403
		[Token(Token = "0x402FB4B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetPositionInsideChild;

		// Token: 0x0402FB4C RID: 195404
		[Token(Token = "0x402FB4C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetPositionFromIndex;

		// Token: 0x0402FB4D RID: 195405
		[Token(Token = "0x402FB4D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__FocusToPos;

		// Token: 0x0402FB4E RID: 195406
		[Token(Token = "0x402FB4E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnProfessionClicked;

		// Token: 0x0402FB4F RID: 195407
		[Token(Token = "0x402FB4F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetCurrIndex;

		// Token: 0x0402FB50 RID: 195408
		[Token(Token = "0x402FB50")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
