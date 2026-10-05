using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004723 RID: 18211
	[Token(Token = "0x2004723")]
	public class RecruitBuildFastBuyView : PageSingleComponent
	{
		// Token: 0x0601B996 RID: 113046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B996")]
		[Address(RVA = "0x14DEC50", Offset = "0x14DD850", VA = "0x1814DEC50")]
		public void Dismiss()
		{
		}

		// Token: 0x0601B997 RID: 113047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B997")]
		[Address(RVA = "0x14DECD0", Offset = "0x14DD8D0", VA = "0x1814DECD0")]
		public void OnClick()
		{
		}

		// Token: 0x0601B998 RID: 113048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B998")]
		[Address(RVA = "0x14DED60", Offset = "0x14DD960", VA = "0x1814DED60")]
		public static void OnDismissStatic()
		{
		}

		// Token: 0x0601B999 RID: 113049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B999")]
		[Address(RVA = "0x14DEE80", Offset = "0x14DDA80", VA = "0x1814DEE80")]
		public static void OnEnterNotEnoughStatic(int slotId)
		{
		}

		// Token: 0x0601B99A RID: 113050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B99A")]
		[Address(RVA = "0x14DF290", Offset = "0x14DDE90", VA = "0x1814DF290")]
		public static void OnEnterStatic(int slotId)
		{
		}

		// Token: 0x0601B99B RID: 113051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B99B")]
		[Address(RVA = "0x14DEF40", Offset = "0x14DDB40", VA = "0x1814DEF40")]
		public void OnEnterNotEnough(int slotId)
		{
		}

		// Token: 0x0601B99C RID: 113052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B99C")]
		[Address(RVA = "0x14DF350", Offset = "0x14DDF50", VA = "0x1814DF350")]
		public void OnEnter(int slotId)
		{
		}

		// Token: 0x0601B99D RID: 113053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B99D")]
		[Address(RVA = "0x14DF560", Offset = "0x14DE160", VA = "0x1814DF560")]
		private void _InitIfNot(bool diamondFlag)
		{
		}

		// Token: 0x0601B99E RID: 113054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B99E")]
		[Address(RVA = "0x14DF720", Offset = "0x14DE320", VA = "0x1814DF720")]
		private void _InitItemCard(ref UIItemCard itemCard, Transform parent, Action<int> onClick)
		{
		}

		// Token: 0x0601B99F RID: 113055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B99F")]
		[Address(RVA = "0x14DF8C0", Offset = "0x14DE4C0", VA = "0x1814DF8C0")]
		public RecruitBuildFastBuyView()
		{
		}

		// Token: 0x04023C38 RID: 146488
		[Token(Token = "0x4023C38")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _buyText;

		// Token: 0x04023C39 RID: 146489
		[Token(Token = "0x4023C39")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIRenderTextureImage _backImage;

		// Token: 0x04023C3A RID: 146490
		[Token(Token = "0x4023C3A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _obj;

		// Token: 0x04023C3B RID: 146491
		[Token(Token = "0x4023C3B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIItemCard _itemPrefab;

		// Token: 0x04023C3C RID: 146492
		[Token(Token = "0x4023C3C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x04023C3D RID: 146493
		[Token(Token = "0x4023C3D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _costItemHolder;

		// Token: 0x04023C3E RID: 146494
		[Token(Token = "0x4023C3E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _targetItemHolder;

		// Token: 0x04023C3F RID: 146495
		[Token(Token = "0x4023C3F")]
		[FieldOffset(Offset = "0x58")]
		private int m_cost;

		// Token: 0x04023C40 RID: 146496
		[Token(Token = "0x4023C40")]
		[FieldOffset(Offset = "0x5C")]
		private int m_slotId;

		// Token: 0x04023C41 RID: 146497
		[Token(Token = "0x4023C41")]
		[FieldOffset(Offset = "0x60")]
		private UIItemCard m_costItem;

		// Token: 0x04023C42 RID: 146498
		[Token(Token = "0x4023C42")]
		[FieldOffset(Offset = "0x68")]
		private UIItemCard m_targetItem;

		// Token: 0x04023C43 RID: 146499
		[Token(Token = "0x4023C43")]
		[FieldOffset(Offset = "0x70")]
		private UIItemViewModel m_costModel;

		// Token: 0x04023C44 RID: 146500
		[Token(Token = "0x4023C44")]
		[FieldOffset(Offset = "0x78")]
		private UIItemViewModel m_targetModel;

		// Token: 0x04023C45 RID: 146501
		[Token(Token = "0x4023C45")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x04023C46 RID: 146502
		[Token(Token = "0x4023C46")]
		[FieldOffset(Offset = "0x81")]
		private bool m_cacheFlag;

		// Token: 0x04023C47 RID: 146503
		[Token(Token = "0x4023C47")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIIntEvent _onClickFast;

		// Token: 0x04023C48 RID: 146504
		[Token(Token = "0x4023C48")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIIntEvent _onClickFastNotEnough;

		// Token: 0x04023C49 RID: 146505
		[Token(Token = "0x4023C49")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Dismiss;

		// Token: 0x04023C4A RID: 146506
		[Token(Token = "0x4023C4A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04023C4B RID: 146507
		[Token(Token = "0x4023C4B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDismissStatic;

		// Token: 0x04023C4C RID: 146508
		[Token(Token = "0x4023C4C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnterNotEnoughStatic;

		// Token: 0x04023C4D RID: 146509
		[Token(Token = "0x4023C4D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnterStatic;

		// Token: 0x04023C4E RID: 146510
		[Token(Token = "0x4023C4E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnterNotEnough;

		// Token: 0x04023C4F RID: 146511
		[Token(Token = "0x4023C4F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04023C50 RID: 146512
		[Token(Token = "0x4023C50")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023C51 RID: 146513
		[Token(Token = "0x4023C51")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitItemCard;

		// Token: 0x04023C52 RID: 146514
		[Token(Token = "0x4023C52")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
