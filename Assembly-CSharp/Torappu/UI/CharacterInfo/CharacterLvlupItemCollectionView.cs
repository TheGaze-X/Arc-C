using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F64 RID: 24420
	[Token(Token = "0x2005F64")]
	public class CharacterLvlupItemCollectionView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060235B6 RID: 144822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235B6")]
		[Address(RVA = "0x1E0C640", Offset = "0x1E0B240", VA = "0x181E0C640")]
		public void Render(CharacterLvlupItemCollectionViewModel viewModel)
		{
		}

		// Token: 0x060235B7 RID: 144823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235B7")]
		[Address(RVA = "0x1E0C870", Offset = "0x1E0B470", VA = "0x181E0C870")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060235B8 RID: 144824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235B8")]
		[Address(RVA = "0x1E0C960", Offset = "0x1E0B560", VA = "0x181E0C960")]
		private void _OnModifyingCardNum(int index, int num)
		{
		}

		// Token: 0x060235B9 RID: 144825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235B9")]
		[Address(RVA = "0x1E0CA00", Offset = "0x1E0B600", VA = "0x181E0CA00")]
		public CharacterLvlupItemCollectionView()
		{
		}

		// Token: 0x04030D02 RID: 199938
		[Token(Token = "0x4030D02")]
		private const int AVG_FOCUS_ITEM_INDEX = 3;

		// Token: 0x04030D03 RID: 199939
		[Token(Token = "0x4030D03")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _itemLayoutContent;

		// Token: 0x04030D04 RID: 199940
		[Token(Token = "0x4030D04")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _goldContainer;

		// Token: 0x04030D05 RID: 199941
		[Token(Token = "0x4030D05")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CharacterLvlupItemCard _cardPrefab;

		// Token: 0x04030D06 RID: 199942
		[Token(Token = "0x4030D06")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Action<int, int> onModifyingCardNum;

		// Token: 0x04030D07 RID: 199943
		[Token(Token = "0x4030D07")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x04030D08 RID: 199944
		[Token(Token = "0x4030D08")]
		[FieldOffset(Offset = "0x40")]
		private CharacterLvlupItemCollectionView.ItemAdapter m_adapter;

		// Token: 0x04030D09 RID: 199945
		[Token(Token = "0x4030D09")]
		[FieldOffset(Offset = "0x48")]
		private CharacterLvlupItemCard m_goldCard;

		// Token: 0x04030D0A RID: 199946
		[Token(Token = "0x4030D0A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030D0B RID: 199947
		[Token(Token = "0x4030D0B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030D0C RID: 199948
		[Token(Token = "0x4030D0C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnModifyingCardNum;

		// Token: 0x04030D0D RID: 199949
		[Token(Token = "0x4030D0D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F65 RID: 24421
		[Token(Token = "0x2005F65")]
		private class ItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x1700538F RID: 21391
			// (get) Token: 0x060235BA RID: 144826 RVA: 0x000C0A20 File Offset: 0x000BEC20
			[Token(Token = "0x1700538F")]
			public override int count
			{
				[Token(Token = "0x60235BA")]
				[Address(RVA = "0x1E103A0", Offset = "0x1E0EFA0", VA = "0x181E103A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060235BB RID: 144827 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60235BB")]
			[Address(RVA = "0x1E10170", Offset = "0x1E0ED70", VA = "0x181E10170", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x060235BC RID: 144828 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60235BC")]
			[Address(RVA = "0x1E10340", Offset = "0x1E0EF40", VA = "0x181E10340")]
			public ItemAdapter()
			{
			}

			// Token: 0x04030D0E RID: 199950
			[Token(Token = "0x4030D0E")]
			[FieldOffset(Offset = "0x20")]
			public CharacterLvlupItemCollectionViewModel viewModel;

			// Token: 0x04030D0F RID: 199951
			[Token(Token = "0x4030D0F")]
			[FieldOffset(Offset = "0x28")]
			public Action<int, int> modifyAction;

			// Token: 0x04030D10 RID: 199952
			[Token(Token = "0x4030D10")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04030D11 RID: 199953
			[Token(Token = "0x4030D11")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04030D12 RID: 199954
			[Token(Token = "0x4030D12")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
