using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003721 RID: 14113
	[Token(Token = "0x2003721")]
	public class CommonReplicateItemCard : MonoBehaviour, IHotfixable
	{
		// Token: 0x06016693 RID: 91795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016693")]
		[Address(RVA = "0xED7750", Offset = "0xED6350", VA = "0x180ED7750")]
		public void Render(CommonReplicateItemCard.InputParams inputParams)
		{
		}

		// Token: 0x06016694 RID: 91796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016694")]
		[Address(RVA = "0xED7970", Offset = "0xED6570", VA = "0x180ED7970")]
		public void UpdateCardColorByCompleteStatus(bool isCompleted, Color completeCol, Color normalCol)
		{
		}

		// Token: 0x06016695 RID: 91797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016695")]
		[Address(RVA = "0xED76D0", Offset = "0xED62D0", VA = "0x180ED76D0")]
		protected void OnDestroy()
		{
		}

		// Token: 0x06016696 RID: 91798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016696")]
		[Address(RVA = "0xED7FD0", Offset = "0xED6BD0", VA = "0x180ED7FD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06016697 RID: 91799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016697")]
		[Address(RVA = "0xED82B0", Offset = "0xED6EB0", VA = "0x180ED82B0")]
		private void _RenderCommonItemCard(CommonReplicateItemCard.InputParams inputParams)
		{
		}

		// Token: 0x06016698 RID: 91800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016698")]
		[Address(RVA = "0xED8440", Offset = "0xED7040", VA = "0x180ED8440")]
		private void _RenderRepItemCard(CommonReplicateItemCard.InputParams inputParams)
		{
		}

		// Token: 0x06016699 RID: 91801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016699")]
		[Address(RVA = "0xED7BF0", Offset = "0xED67F0", VA = "0x180ED7BF0")]
		private UIItemCard _EnsureCommonItemCard(float scale)
		{
			return null;
		}

		// Token: 0x0601669A RID: 91802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601669A")]
		[Address(RVA = "0xED7E20", Offset = "0xED6A20", VA = "0x180ED7E20")]
		private UIItemCard _EnsureRepItemCard(float scale)
		{
			return null;
		}

		// Token: 0x0601669B RID: 91803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601669B")]
		[Address(RVA = "0xED8790", Offset = "0xED7390", VA = "0x180ED8790")]
		private void _ShowCard(UIItemCard card, bool show)
		{
		}

		// Token: 0x0601669C RID: 91804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601669C")]
		[Address(RVA = "0xED81D0", Offset = "0xED6DD0", VA = "0x180ED81D0")]
		private void _OnItemCardClicked(int unusedIndex)
		{
		}

		// Token: 0x0601669D RID: 91805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601669D")]
		[Address(RVA = "0xED8870", Offset = "0xED7470", VA = "0x180ED8870")]
		public CommonReplicateItemCard()
		{
		}

		// Token: 0x0401AF44 RID: 110404
		[Token(Token = "0x401AF44")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _commonItemRoot;

		// Token: 0x0401AF45 RID: 110405
		[Token(Token = "0x401AF45")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _repItemRoot;

		// Token: 0x0401AF46 RID: 110406
		[Token(Token = "0x401AF46")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _repIcon;

		// Token: 0x0401AF47 RID: 110407
		[Token(Token = "0x401AF47")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0401AF48 RID: 110408
		[Token(Token = "0x401AF48")]
		[FieldOffset(Offset = "0x38")]
		private UIItemCard m_itemCard;

		// Token: 0x0401AF49 RID: 110409
		[Token(Token = "0x401AF49")]
		[FieldOffset(Offset = "0x40")]
		private UIItemCard m_repItemCard;

		// Token: 0x0401AF4A RID: 110410
		[Token(Token = "0x401AF4A")]
		[FieldOffset(Offset = "0x48")]
		private CommonReplicateItemCard.ReplicateTweenWrapper m_repTween;

		// Token: 0x0401AF4B RID: 110411
		[Token(Token = "0x401AF4B")]
		[FieldOffset(Offset = "0x50")]
		private UIItemViewModel m_itemModel;

		// Token: 0x0401AF4C RID: 110412
		[Token(Token = "0x401AF4C")]
		[FieldOffset(Offset = "0x58")]
		private UIItemViewModel m_repItemModel;

		// Token: 0x0401AF4D RID: 110413
		[Token(Token = "0x401AF4D")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isReplicate;

		// Token: 0x0401AF4E RID: 110414
		[Token(Token = "0x401AF4E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401AF4F RID: 110415
		[Token(Token = "0x401AF4F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateCardColorByCompleteStatus;

		// Token: 0x0401AF50 RID: 110416
		[Token(Token = "0x401AF50")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401AF51 RID: 110417
		[Token(Token = "0x401AF51")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401AF52 RID: 110418
		[Token(Token = "0x401AF52")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderCommonItemCard;

		// Token: 0x0401AF53 RID: 110419
		[Token(Token = "0x401AF53")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderRepItemCard;

		// Token: 0x0401AF54 RID: 110420
		[Token(Token = "0x401AF54")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EnsureCommonItemCard;

		// Token: 0x0401AF55 RID: 110421
		[Token(Token = "0x401AF55")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EnsureRepItemCard;

		// Token: 0x0401AF56 RID: 110422
		[Token(Token = "0x401AF56")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ShowCard;

		// Token: 0x0401AF57 RID: 110423
		[Token(Token = "0x401AF57")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnItemCardClicked;

		// Token: 0x0401AF58 RID: 110424
		[Token(Token = "0x401AF58")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003722 RID: 14114
		[Token(Token = "0x2003722")]
		public struct InputParams
		{
			// Token: 0x170035B9 RID: 13753
			// (get) Token: 0x0601669E RID: 91806 RVA: 0x00091260 File Offset: 0x0008F460
			[Token(Token = "0x170035B9")]
			public bool isReplicate
			{
				[Token(Token = "0x601669E")]
				[Address(RVA = "0xEDB190", Offset = "0xED9D90", VA = "0x180EDB190")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601669F RID: 91807 RVA: 0x00091278 File Offset: 0x0008F478
			[Token(Token = "0x601669F")]
			[Address(RVA = "0xEDB020", Offset = "0xED9C20", VA = "0x180EDB020")]
			public static CommonReplicateItemCard.InputParams CreateWithActId(string actId, ItemBundle commonItem, float scale)
			{
				return default(CommonReplicateItemCard.InputParams);
			}

			// Token: 0x060166A0 RID: 91808 RVA: 0x00091290 File Offset: 0x0008F490
			[Token(Token = "0x60166A0")]
			[Address(RVA = "0xEDB130", Offset = "0xED9D30", VA = "0x180EDB130")]
			public static CommonReplicateItemCard.InputParams Create(ItemBundle commonItem, ItemBundle repItem, float scale)
			{
				return default(CommonReplicateItemCard.InputParams);
			}

			// Token: 0x0401AF59 RID: 110425
			[Token(Token = "0x401AF59")]
			[FieldOffset(Offset = "0x0")]
			public ItemBundle commonItemBundle;

			// Token: 0x0401AF5A RID: 110426
			[Token(Token = "0x401AF5A")]
			[FieldOffset(Offset = "0x8")]
			public ItemBundle replicateItemBundle;

			// Token: 0x0401AF5B RID: 110427
			[Token(Token = "0x401AF5B")]
			[FieldOffset(Offset = "0x10")]
			public float scale;
		}

		// Token: 0x02003723 RID: 14115
		[Token(Token = "0x2003723")]
		private class ReplicateTweenWrapper : IHotfixable
		{
			// Token: 0x060166A1 RID: 91809 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60166A1")]
			[Address(RVA = "0xEDE0A0", Offset = "0xEDCCA0", VA = "0x180EDE0A0")]
			public void SetCanvasGroup(CanvasGroup item, CanvasGroup replicate)
			{
			}

			// Token: 0x060166A2 RID: 91810 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60166A2")]
			[Address(RVA = "0xEDE140", Offset = "0xEDCD40", VA = "0x180EDE140")]
			public void SetTween()
			{
			}

			// Token: 0x060166A3 RID: 91811 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60166A3")]
			[Address(RVA = "0xEDE000", Offset = "0xEDCC00", VA = "0x180EDE000")]
			public void KillTween()
			{
			}

			// Token: 0x060166A4 RID: 91812 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60166A4")]
			[Address(RVA = "0xEDE600", Offset = "0xEDD200", VA = "0x180EDE600")]
			public ReplicateTweenWrapper()
			{
			}

			// Token: 0x0401AF5C RID: 110428
			[Token(Token = "0x401AF5C")]
			[FieldOffset(Offset = "0x10")]
			private CanvasGroup m_itemCanvasGroup;

			// Token: 0x0401AF5D RID: 110429
			[Token(Token = "0x401AF5D")]
			[FieldOffset(Offset = "0x18")]
			private CanvasGroup m_replicateCanvasGroup;

			// Token: 0x0401AF5E RID: 110430
			[Token(Token = "0x401AF5E")]
			[FieldOffset(Offset = "0x20")]
			private Sequence m_tween;

			// Token: 0x0401AF5F RID: 110431
			[Token(Token = "0x401AF5F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetCanvasGroup;

			// Token: 0x0401AF60 RID: 110432
			[Token(Token = "0x401AF60")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetTween;

			// Token: 0x0401AF61 RID: 110433
			[Token(Token = "0x401AF61")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_KillTween;

			// Token: 0x0401AF62 RID: 110434
			[Token(Token = "0x401AF62")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
