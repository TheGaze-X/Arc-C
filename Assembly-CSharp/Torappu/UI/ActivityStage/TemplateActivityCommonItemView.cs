using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CD2 RID: 27858
	[Token(Token = "0x2006CD2")]
	public class TemplateActivityCommonItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027BCD RID: 162765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BCD")]
		[Address(RVA = "0x22D7D80", Offset = "0x22D6980", VA = "0x1822D7D80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027BCE RID: 162766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027BCE")]
		[Address(RVA = "0x22D7B50", Offset = "0x22D6750", VA = "0x1822D7B50")]
		private UIItemCard _EnsureRepItemCard()
		{
			return null;
		}

		// Token: 0x06027BCF RID: 162767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BCF")]
		[Address(RVA = "0x22D7A00", Offset = "0x22D6600", VA = "0x1822D7A00")]
		public void Render(BasicActivityItemViewModel viewModel)
		{
		}

		// Token: 0x06027BD0 RID: 162768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BD0")]
		[Address(RVA = "0x22D8140", Offset = "0x22D6D40", VA = "0x1822D8140")]
		private void _UpdateReplicateInfo(BasicActivityItemViewModel actItemModel)
		{
		}

		// Token: 0x06027BD1 RID: 162769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BD1")]
		[Address(RVA = "0x22D8050", Offset = "0x22D6C50", VA = "0x1822D8050")]
		private void _OnRepItemCardClicked(int unusedIndex)
		{
		}

		// Token: 0x06027BD2 RID: 162770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BD2")]
		[Address(RVA = "0x22D7F70", Offset = "0x22D6B70", VA = "0x1822D7F70")]
		private void _OnItemCardClicked(int unusedIndex)
		{
		}

		// Token: 0x06027BD3 RID: 162771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BD3")]
		[Address(RVA = "0x22D7910", Offset = "0x22D6510", VA = "0x1822D7910")]
		private void OnDestroy()
		{
		}

		// Token: 0x06027BD4 RID: 162772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BD4")]
		[Address(RVA = "0x22D83B0", Offset = "0x22D6FB0", VA = "0x1822D83B0")]
		public TemplateActivityCommonItemView()
		{
		}

		// Token: 0x040385A8 RID: 230824
		[Token(Token = "0x40385A8")]
		private const string ANIM_PARAM = "mission_shining";

		// Token: 0x040385A9 RID: 230825
		[Token(Token = "0x40385A9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _itemCont;

		// Token: 0x040385AA RID: 230826
		[Token(Token = "0x40385AA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _itemRepCont;

		// Token: 0x040385AB RID: 230827
		[Token(Token = "0x40385AB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelRepIcon;

		// Token: 0x040385AC RID: 230828
		[Token(Token = "0x40385AC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationWrapper _repAnim;

		// Token: 0x040385AD RID: 230829
		[Token(Token = "0x40385AD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _noItemPart;

		// Token: 0x040385AE RID: 230830
		[Token(Token = "0x40385AE")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public float scaler;

		// Token: 0x040385AF RID: 230831
		[Token(Token = "0x40385AF")]
		[FieldOffset(Offset = "0x44")]
		private bool m_isInited;

		// Token: 0x040385B0 RID: 230832
		[Token(Token = "0x40385B0")]
		[FieldOffset(Offset = "0x48")]
		private UIItemCard m_itemCard;

		// Token: 0x040385B1 RID: 230833
		[Token(Token = "0x40385B1")]
		[FieldOffset(Offset = "0x50")]
		private UIItemCard m_repItemCard;

		// Token: 0x040385B2 RID: 230834
		[Token(Token = "0x40385B2")]
		[FieldOffset(Offset = "0x58")]
		private TemplateActivityCommonItemView.RepTweenController m_repTween;

		// Token: 0x040385B3 RID: 230835
		[Token(Token = "0x40385B3")]
		[FieldOffset(Offset = "0x60")]
		private UIItemViewModel m_itemModel;

		// Token: 0x040385B4 RID: 230836
		[Token(Token = "0x40385B4")]
		[FieldOffset(Offset = "0x68")]
		private UIItemViewModel m_repItemModel;

		// Token: 0x040385B5 RID: 230837
		[Token(Token = "0x40385B5")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isReplicate;

		// Token: 0x040385B6 RID: 230838
		[Token(Token = "0x40385B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040385B7 RID: 230839
		[Token(Token = "0x40385B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureRepItemCard;

		// Token: 0x040385B8 RID: 230840
		[Token(Token = "0x40385B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040385B9 RID: 230841
		[Token(Token = "0x40385B9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateReplicateInfo;

		// Token: 0x040385BA RID: 230842
		[Token(Token = "0x40385BA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnRepItemCardClicked;

		// Token: 0x040385BB RID: 230843
		[Token(Token = "0x40385BB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnItemCardClicked;

		// Token: 0x040385BC RID: 230844
		[Token(Token = "0x40385BC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040385BD RID: 230845
		[Token(Token = "0x40385BD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006CD3 RID: 27859
		[Token(Token = "0x2006CD3")]
		private class RepTweenController : IHotfixable, IDisposable
		{
			// Token: 0x06027BD5 RID: 162773 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027BD5")]
			[Address(RVA = "0x22D54F0", Offset = "0x22D40F0", VA = "0x1822D54F0")]
			public RepTweenController(AnimationWrapper repAnim, string animKey)
			{
			}

			// Token: 0x06027BD6 RID: 162774 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027BD6")]
			[Address(RVA = "0x22D52C0", Offset = "0x22D3EC0", VA = "0x1822D52C0")]
			public void SetEnable(bool isEnable)
			{
			}

			// Token: 0x06027BD7 RID: 162775 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027BD7")]
			[Address(RVA = "0x22D5240", Offset = "0x22D3E40", VA = "0x1822D5240", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x040385BE RID: 230846
			[Token(Token = "0x40385BE")]
			[FieldOffset(Offset = "0x10")]
			private Tween m_loopTween;

			// Token: 0x040385BF RID: 230847
			[Token(Token = "0x40385BF")]
			[FieldOffset(Offset = "0x18")]
			private bool m_isInitSetEnableCall;

			// Token: 0x040385C0 RID: 230848
			[Token(Token = "0x40385C0")]
			[FieldOffset(Offset = "0x20")]
			private AnimationWrapper m_animWrapper;

			// Token: 0x040385C1 RID: 230849
			[Token(Token = "0x40385C1")]
			[FieldOffset(Offset = "0x28")]
			private string m_animKey;

			// Token: 0x040385C2 RID: 230850
			[Token(Token = "0x40385C2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040385C3 RID: 230851
			[Token(Token = "0x40385C3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetEnable;

			// Token: 0x040385C4 RID: 230852
			[Token(Token = "0x40385C4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Dispose;
		}
	}
}
