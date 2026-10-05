using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BF7 RID: 15351
	[Token(Token = "0x2003BF7")]
	public class UniEquipArchiveModuleCollectionView : DataBinder<UniEquipArchiveModuleCollectionViewProperty>
	{
		// Token: 0x06018033 RID: 98355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018033")]
		[Address(RVA = "0x10847E0", Offset = "0x10833E0", VA = "0x1810847E0", Slot = "7")]
		public override void OnValueChanged(UniEquipArchiveModuleCollectionViewProperty property)
		{
		}

		// Token: 0x06018034 RID: 98356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018034")]
		[Address(RVA = "0x1084A30", Offset = "0x1083630", VA = "0x181084A30")]
		public void ResetListToTop()
		{
		}

		// Token: 0x06018035 RID: 98357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018035")]
		[Address(RVA = "0x1084B10", Offset = "0x1083710", VA = "0x181084B10")]
		public UniEquipArchiveModuleCollectionView()
		{
		}

		// Token: 0x0401D1B4 RID: 119220
		[Token(Token = "0x401D1B4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UILayoutDimensionListener _dimensionListener;

		// Token: 0x0401D1B5 RID: 119221
		[Token(Token = "0x401D1B5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UniEquipArchiveModuleCollectionCardAdapter _adapter;

		// Token: 0x0401D1B6 RID: 119222
		[Token(Token = "0x401D1B6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UniEquipArchiveModuleCollectionSortView _sortView;

		// Token: 0x0401D1B7 RID: 119223
		[Token(Token = "0x401D1B7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0401D1B8 RID: 119224
		[Token(Token = "0x401D1B8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x0401D1B9 RID: 119225
		[Token(Token = "0x401D1B9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401D1BA RID: 119226
		[Token(Token = "0x401D1BA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ResetListToTop;

		// Token: 0x0401D1BB RID: 119227
		[Token(Token = "0x401D1BB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003BF8 RID: 15352
		[Token(Token = "0x2003BF8")]
		private class OnPostLayoutScrollVerticalAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x06018036 RID: 98358 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018036")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public OnPostLayoutScrollVerticalAction(UniEquipArchiveModuleCollectionView closure)
			{
			}

			// Token: 0x06018037 RID: 98359 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018037")]
			[Address(RVA = "0x10770F0", Offset = "0x1075CF0", VA = "0x1810770F0", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x0401D1BC RID: 119228
			[Token(Token = "0x401D1BC")]
			[FieldOffset(Offset = "0x10")]
			private UniEquipArchiveModuleCollectionView m_closure;
		}
	}
}
