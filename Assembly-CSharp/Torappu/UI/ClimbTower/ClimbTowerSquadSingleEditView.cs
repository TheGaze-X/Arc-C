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
	// Token: 0x02005D92 RID: 23954
	[Token(Token = "0x2005D92")]
	public class ClimbTowerSquadSingleEditView : DataBinder<ClimbTowerSquadSingleEditProp>
	{
		// Token: 0x170051FB RID: 20987
		// (get) Token: 0x06022B9E RID: 142238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170051FB")]
		public ClimbTowerSquadSingleEditGroupItemView groupItemPrefab
		{
			[Token(Token = "0x6022B9E")]
			[Address(RVA = "0x1D46BB0", Offset = "0x1D457B0", VA = "0x181D46BB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170051FC RID: 20988
		// (get) Token: 0x06022B9F RID: 142239 RVA: 0x000BE9C8 File Offset: 0x000BCBC8
		// (set) Token: 0x06022BA0 RID: 142240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051FC")]
		public bool needRebuild
		{
			[Token(Token = "0x6022B9F")]
			[Address(RVA = "0x1D46C10", Offset = "0x1D45810", VA = "0x181D46C10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6022BA0")]
			[Address(RVA = "0x1D46CD0", Offset = "0x1D458D0", VA = "0x181D46CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170051FD RID: 20989
		// (get) Token: 0x06022BA1 RID: 142241 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022BA2 RID: 142242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051FD")]
		public Action<int> onCharSelect
		{
			[Token(Token = "0x6022BA1")]
			[Address(RVA = "0x1D46C70", Offset = "0x1D45870", VA = "0x181D46C70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6022BA2")]
			[Address(RVA = "0x1D46D40", Offset = "0x1D45940", VA = "0x181D46D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022BA3 RID: 142243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BA3")]
		[Address(RVA = "0x1D46360", Offset = "0x1D44F60", VA = "0x181D46360", Slot = "7")]
		public override void OnValueChanged(ClimbTowerSquadSingleEditProp property)
		{
		}

		// Token: 0x06022BA4 RID: 142244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BA4")]
		[Address(RVA = "0x1D46930", Offset = "0x1D45530", VA = "0x181D46930")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022BA5 RID: 142245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BA5")]
		[Address(RVA = "0x1D464A0", Offset = "0x1D450A0", VA = "0x181D464A0")]
		private void _FocusToCharCard(ClimbTowerSquadSingleEditModel editModel)
		{
		}

		// Token: 0x06022BA6 RID: 142246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BA6")]
		[Address(RVA = "0x1D46680", Offset = "0x1D45280", VA = "0x181D46680")]
		private void _FocusToPos(float pos, bool fastMode)
		{
		}

		// Token: 0x06022BA7 RID: 142247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BA7")]
		[Address(RVA = "0x1D462B0", Offset = "0x1D44EB0", VA = "0x181D462B0")]
		public void OnProfessionClicked(ProfessionCategory profession)
		{
		}

		// Token: 0x06022BA8 RID: 142248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BA8")]
		[Address(RVA = "0x1D46B40", Offset = "0x1D45740", VA = "0x181D46B40")]
		public ClimbTowerSquadSingleEditView()
		{
		}

		// Token: 0x0402FBC5 RID: 195525
		[Token(Token = "0x402FBC5")]
		private const float FOCUS_TWEEN_DURATION = 0.23f;

		// Token: 0x0402FBC6 RID: 195526
		[Token(Token = "0x402FBC6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ClimbTowerSquadSingleEditGroupItemView _groupItemPrefab;

		// Token: 0x0402FBC7 RID: 195527
		[Token(Token = "0x402FBC7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIRecycleHorizonLayoutGroup _recycleSquadList;

		// Token: 0x0402FBC8 RID: 195528
		[Token(Token = "0x402FBC8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _viewport;

		// Token: 0x0402FBC9 RID: 195529
		[Token(Token = "0x402FBC9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ScrollRect _scrollView;

		// Token: 0x0402FBCA RID: 195530
		[Token(Token = "0x402FBCA")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x0402FBCB RID: 195531
		[Token(Token = "0x402FBCB")]
		[FieldOffset(Offset = "0x48")]
		private ClimbTowerSquadSingleEditAdapter m_adapter;

		// Token: 0x0402FBCC RID: 195532
		[Token(Token = "0x402FBCC")]
		[FieldOffset(Offset = "0x50")]
		private Tween m_tween;

		// Token: 0x0402FBCF RID: 195535
		[Token(Token = "0x402FBCF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groupItemPrefab;

		// Token: 0x0402FBD0 RID: 195536
		[Token(Token = "0x402FBD0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needRebuild;

		// Token: 0x0402FBD1 RID: 195537
		[Token(Token = "0x402FBD1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_needRebuild;

		// Token: 0x0402FBD2 RID: 195538
		[Token(Token = "0x402FBD2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_onCharSelect;

		// Token: 0x0402FBD3 RID: 195539
		[Token(Token = "0x402FBD3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_onCharSelect;

		// Token: 0x0402FBD4 RID: 195540
		[Token(Token = "0x402FBD4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402FBD5 RID: 195541
		[Token(Token = "0x402FBD5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402FBD6 RID: 195542
		[Token(Token = "0x402FBD6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FocusToCharCard;

		// Token: 0x0402FBD7 RID: 195543
		[Token(Token = "0x402FBD7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__FocusToPos;

		// Token: 0x0402FBD8 RID: 195544
		[Token(Token = "0x402FBD8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnProfessionClicked;

		// Token: 0x0402FBD9 RID: 195545
		[Token(Token = "0x402FBD9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
