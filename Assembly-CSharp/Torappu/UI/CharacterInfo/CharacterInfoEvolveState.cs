using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005ECA RID: 24266
	[Token(Token = "0x2005ECA")]
	public class CharacterInfoEvolveState : UIPopupState
	{
		// Token: 0x06023230 RID: 143920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023230")]
		[Address(RVA = "0x1DA65A0", Offset = "0x1DA51A0", VA = "0x181DA65A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06023231 RID: 143921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023231")]
		[Address(RVA = "0x1DA6C40", Offset = "0x1DA5840", VA = "0x181DA6C40", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023232 RID: 143922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023232")]
		[Address(RVA = "0x1DA7030", Offset = "0x1DA5C30", VA = "0x181DA7030", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06023233 RID: 143923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023233")]
		[Address(RVA = "0x1DA6A10", Offset = "0x1DA5610", VA = "0x181DA6A10")]
		protected void OnDestroy()
		{
		}

		// Token: 0x06023234 RID: 143924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023234")]
		[Address(RVA = "0x1DA7AE0", Offset = "0x1DA66E0", VA = "0x181DA7AE0")]
		private void _RefreshPlayerStatusViews()
		{
		}

		// Token: 0x06023235 RID: 143925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023235")]
		[Address(RVA = "0x1DA6A70", Offset = "0x1DA5670", VA = "0x181DA6A70")]
		public void OnDetailClick()
		{
		}

		// Token: 0x06023236 RID: 143926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023236")]
		[Address(RVA = "0x1DA6840", Offset = "0x1DA5440", VA = "0x181DA6840")]
		public void OnBackClick()
		{
		}

		// Token: 0x06023237 RID: 143927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023237")]
		[Address(RVA = "0x1DA7250", Offset = "0x1DA5E50", VA = "0x181DA7250")]
		public void OnUpgradeConfirmClick()
		{
		}

		// Token: 0x06023238 RID: 143928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023238")]
		[Address(RVA = "0x1DA71C0", Offset = "0x1DA5DC0", VA = "0x181DA71C0")]
		public void OnUpgradeCancelClick()
		{
		}

		// Token: 0x06023239 RID: 143929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023239")]
		[Address(RVA = "0x1DA70F0", Offset = "0x1DA5CF0", VA = "0x181DA70F0")]
		public void OnRouteToTarget()
		{
		}

		// Token: 0x0602323A RID: 143930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602323A")]
		[Address(RVA = "0x1DA77A0", Offset = "0x1DA63A0", VA = "0x181DA77A0")]
		private void _BindBackPressListeners()
		{
		}

		// Token: 0x0602323B RID: 143931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602323B")]
		[Address(RVA = "0x1DA79A0", Offset = "0x1DA65A0", VA = "0x181DA79A0")]
		private void _ClearIllusts()
		{
		}

		// Token: 0x0602323C RID: 143932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602323C")]
		[Address(RVA = "0x1DA7D50", Offset = "0x1DA6950", VA = "0x181DA7D50")]
		private void _UpdateAnimatorStates()
		{
		}

		// Token: 0x0602323D RID: 143933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602323D")]
		[Address(RVA = "0x1DA7560", Offset = "0x1DA6160", VA = "0x181DA7560", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0602323E RID: 143934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602323E")]
		[Address(RVA = "0x1DA6600", Offset = "0x1DA5200", VA = "0x181DA6600", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0602323F RID: 143935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602323F")]
		[Address(RVA = "0x1DA76A0", Offset = "0x1DA62A0", VA = "0x181DA76A0", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06023240 RID: 143936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023240")]
		[Address(RVA = "0x1DA6740", Offset = "0x1DA5340", VA = "0x181DA6740", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06023241 RID: 143937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023241")]
		[Address(RVA = "0x1DA7E10", Offset = "0x1DA6A10", VA = "0x181DA7E10")]
		public CharacterInfoEvolveState()
		{
		}

		// Token: 0x06023242 RID: 143938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023242")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06023243 RID: 143939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023243")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x040306E8 RID: 198376
		[Token(Token = "0x40306E8")]
		private const string ANIM_DETAIL_OPEN_KEY = "OnEnter";

		// Token: 0x040306E9 RID: 198377
		[Token(Token = "0x40306E9")]
		private const string ANIM_STATE_ENTER_KEY = "EnterState";

		// Token: 0x040306EA RID: 198378
		[Token(Token = "0x40306EA")]
		private const string ANIM_STATE_FAST_KEY = "Fast";

		// Token: 0x040306EB RID: 198379
		[Token(Token = "0x40306EB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharacterInfoEvolveStateBean _stateBean;

		// Token: 0x040306EC RID: 198380
		[Token(Token = "0x40306EC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _nameInConfirmInfo;

		// Token: 0x040306ED RID: 198381
		[Token(Token = "0x40306ED")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _panelIllustOld;

		// Token: 0x040306EE RID: 198382
		[Token(Token = "0x40306EE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _panelIllustNew;

		// Token: 0x040306EF RID: 198383
		[Token(Token = "0x40306EF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Tooltip("Silhouette effect on the new illustration")]
		private Material _illustSilhouetteMat;

		// Token: 0x040306F0 RID: 198384
		[Token(Token = "0x40306F0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _illustSilhouetteColor;

		// Token: 0x040306F1 RID: 198385
		[Token(Token = "0x40306F1")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Range(0.1f, 2f)]
		private float _illustScaleFactor;

		// Token: 0x040306F2 RID: 198386
		[Token(Token = "0x40306F2")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private CharacterInfoEvolveAttrController _panelUpgradeAttrs;

		// Token: 0x040306F3 RID: 198387
		[Token(Token = "0x40306F3")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private SimpleLayoutContent _requireLayout;

		// Token: 0x040306F4 RID: 198388
		[Token(Token = "0x40306F4")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private CharacterEvolveTextContainer _evolveText;

		// Token: 0x040306F5 RID: 198389
		[Token(Token = "0x40306F5")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private CharacterEvolveDetailView _detailView;

		// Token: 0x040306F6 RID: 198390
		[Token(Token = "0x40306F6")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CharacterInfoSpOpView _spOpView;

		// Token: 0x040306F7 RID: 198391
		[Token(Token = "0x40306F7")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _guidebookTrigger;

		// Token: 0x040306F8 RID: 198392
		[Token(Token = "0x40306F8")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Animator _animAll;

		// Token: 0x040306F9 RID: 198393
		[Token(Token = "0x40306F9")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Tooltip("The alpha here would be used to determine whether state enter/exit finished")]
		private CanvasGroup _alphaListener;

		// Token: 0x040306FA RID: 198394
		[Token(Token = "0x40306FA")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_animDetailOpen;

		// Token: 0x040306FB RID: 198395
		[Token(Token = "0x40306FB")]
		[FieldOffset(Offset = "0xE1")]
		private bool m_animStateEnter;

		// Token: 0x040306FC RID: 198396
		[Token(Token = "0x40306FC")]
		[FieldOffset(Offset = "0xE8")]
		private UICharacterIllust m_illustOld;

		// Token: 0x040306FD RID: 198397
		[Token(Token = "0x40306FD")]
		[FieldOffset(Offset = "0xF0")]
		private UICharacterIllust m_illustNew;

		// Token: 0x040306FE RID: 198398
		[Token(Token = "0x40306FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040306FF RID: 198399
		[Token(Token = "0x40306FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04030700 RID: 198400
		[Token(Token = "0x4030700")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04030701 RID: 198401
		[Token(Token = "0x4030701")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04030702 RID: 198402
		[Token(Token = "0x4030702")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshPlayerStatusViews;

		// Token: 0x04030703 RID: 198403
		[Token(Token = "0x4030703")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDetailClick;

		// Token: 0x04030704 RID: 198404
		[Token(Token = "0x4030704")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBackClick;

		// Token: 0x04030705 RID: 198405
		[Token(Token = "0x4030705")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnUpgradeConfirmClick;

		// Token: 0x04030706 RID: 198406
		[Token(Token = "0x4030706")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnUpgradeCancelClick;

		// Token: 0x04030707 RID: 198407
		[Token(Token = "0x4030707")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnRouteToTarget;

		// Token: 0x04030708 RID: 198408
		[Token(Token = "0x4030708")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__BindBackPressListeners;

		// Token: 0x04030709 RID: 198409
		[Token(Token = "0x4030709")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ClearIllusts;

		// Token: 0x0403070A RID: 198410
		[Token(Token = "0x403070A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateAnimatorStates;

		// Token: 0x0403070B RID: 198411
		[Token(Token = "0x403070B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403070C RID: 198412
		[Token(Token = "0x403070C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0403070D RID: 198413
		[Token(Token = "0x403070D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x0403070E RID: 198414
		[Token(Token = "0x403070E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x0403070F RID: 198415
		[Token(Token = "0x403070F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005ECB RID: 24267
		[Token(Token = "0x2005ECB")]
		public class RequirementAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06023244 RID: 143940 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023244")]
			[Address(RVA = "0x1DB91A0", Offset = "0x1DB7DA0", VA = "0x181DB91A0")]
			public RequirementAdapter(CharacterInfoEvolveState closure)
			{
			}

			// Token: 0x17005333 RID: 21299
			// (get) Token: 0x06023245 RID: 143941 RVA: 0x000C0048 File Offset: 0x000BE248
			[Token(Token = "0x17005333")]
			public override int count
			{
				[Token(Token = "0x6023245")]
				[Address(RVA = "0x1DB9400", Offset = "0x1DB8000", VA = "0x181DB9400", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06023246 RID: 143942 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023246")]
			[Address(RVA = "0x1DB8C70", Offset = "0x1DB7870", VA = "0x181DB8C70", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04030710 RID: 198416
			[Token(Token = "0x4030710")]
			[FieldOffset(Offset = "0x20")]
			private CharacterInfoEvolveState m_closure;

			// Token: 0x04030711 RID: 198417
			[Token(Token = "0x4030711")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04030712 RID: 198418
			[Token(Token = "0x4030712")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04030713 RID: 198419
			[Token(Token = "0x4030713")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
