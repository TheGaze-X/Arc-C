using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075DB RID: 30171
	[Token(Token = "0x20075DB")]
	public class Act24sideMissionRewardCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A7AC RID: 173996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7AC")]
		[Address(RVA = "0x2628960", Offset = "0x2627560", VA = "0x182628960")]
		public void Render(Act24sideMissionRewardCardView.Options options, Act24sideMissionRewardView closure, Action onFinished)
		{
		}

		// Token: 0x0602A7AD RID: 173997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7AD")]
		[Address(RVA = "0x2628620", Offset = "0x2627220", VA = "0x182628620")]
		public void Render(Act24sideMissionRewardCardView.OptionsAct options, Act24sideMissionRewardView closure, Action onFinished)
		{
		}

		// Token: 0x0602A7AE RID: 173998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7AE")]
		[Address(RVA = "0x26284E0", Offset = "0x26270E0", VA = "0x1826284E0")]
		public void HideEffect(Act24sideMissionRewardView closure)
		{
		}

		// Token: 0x0602A7AF RID: 173999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7AF")]
		[Address(RVA = "0x2628300", Offset = "0x2626F00", VA = "0x182628300")]
		public void ForceToEnd(Act24sideMissionRewardView closure)
		{
		}

		// Token: 0x0602A7B0 RID: 174000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7B0")]
		[Address(RVA = "0x2628EB0", Offset = "0x2627AB0", VA = "0x182628EB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A7B1 RID: 174001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A7B1")]
		[Address(RVA = "0x2628D50", Offset = "0x2627950", VA = "0x182628D50")]
		private IEnumerator _DoRenderCoroutine(float delay, bool showEffect)
		{
			return null;
		}

		// Token: 0x0602A7B2 RID: 174002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7B2")]
		[Address(RVA = "0x26290F0", Offset = "0x2627CF0", VA = "0x1826290F0")]
		private void _ResetAll(Act24sideMissionRewardView closure)
		{
		}

		// Token: 0x0602A7B3 RID: 174003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7B3")]
		[Address(RVA = "0x2628E30", Offset = "0x2627A30", VA = "0x182628E30")]
		private void _FinishMe()
		{
		}

		// Token: 0x0602A7B4 RID: 174004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7B4")]
		[Address(RVA = "0x2629250", Offset = "0x2627E50", VA = "0x182629250")]
		private void _StopCoroutine(Act24sideMissionRewardView closure)
		{
		}

		// Token: 0x0602A7B5 RID: 174005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A7B5")]
		[Address(RVA = "0x26292F0", Offset = "0x2627EF0", VA = "0x1826292F0")]
		public Act24sideMissionRewardCardView()
		{
		}

		// Token: 0x0403D24C RID: 250444
		[Token(Token = "0x403D24C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _effectScale;

		// Token: 0x0403D24D RID: 250445
		[Token(Token = "0x403D24D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _effectHolder;

		// Token: 0x0403D24E RID: 250446
		[Token(Token = "0x403D24E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _delayForInternalCard;

		// Token: 0x0403D24F RID: 250447
		[Token(Token = "0x403D24F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Act24sideMeldingItemView _actItemViewPrefab;

		// Token: 0x0403D250 RID: 250448
		[Token(Token = "0x403D250")]
		[FieldOffset(Offset = "0x38")]
		private UIItemCard m_internalCard;

		// Token: 0x0403D251 RID: 250449
		[Token(Token = "0x403D251")]
		[FieldOffset(Offset = "0x40")]
		private Act24sideMeldingItemView m_actItem;

		// Token: 0x0403D252 RID: 250450
		[Token(Token = "0x403D252")]
		[FieldOffset(Offset = "0x48")]
		private Coroutine m_coroutine;

		// Token: 0x0403D253 RID: 250451
		[Token(Token = "0x403D253")]
		[FieldOffset(Offset = "0x50")]
		private Action m_onFinished;

		// Token: 0x0403D254 RID: 250452
		[Token(Token = "0x403D254")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isShowEffect;

		// Token: 0x0403D255 RID: 250453
		[Token(Token = "0x403D255")]
		[FieldOffset(Offset = "0x59")]
		private bool m_hasInited;

		// Token: 0x0403D256 RID: 250454
		[Token(Token = "0x403D256")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D257 RID: 250455
		[Token(Token = "0x403D257")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_Render;

		// Token: 0x0403D258 RID: 250456
		[Token(Token = "0x403D258")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HideEffect;

		// Token: 0x0403D259 RID: 250457
		[Token(Token = "0x403D259")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ForceToEnd;

		// Token: 0x0403D25A RID: 250458
		[Token(Token = "0x403D25A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D25B RID: 250459
		[Token(Token = "0x403D25B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DoRenderCoroutine;

		// Token: 0x0403D25C RID: 250460
		[Token(Token = "0x403D25C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ResetAll;

		// Token: 0x0403D25D RID: 250461
		[Token(Token = "0x403D25D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FinishMe;

		// Token: 0x0403D25E RID: 250462
		[Token(Token = "0x403D25E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__StopCoroutine;

		// Token: 0x0403D25F RID: 250463
		[Token(Token = "0x403D25F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020075DC RID: 30172
		[Token(Token = "0x20075DC")]
		public struct Options
		{
			// Token: 0x0403D260 RID: 250464
			[Token(Token = "0x403D260")]
			[FieldOffset(Offset = "0x0")]
			public UIItemViewModel model;

			// Token: 0x0403D261 RID: 250465
			[Token(Token = "0x403D261")]
			[FieldOffset(Offset = "0x8")]
			public float delay;

			// Token: 0x0403D262 RID: 250466
			[Token(Token = "0x403D262")]
			[FieldOffset(Offset = "0xC")]
			public float itemScaleFactor;

			// Token: 0x0403D263 RID: 250467
			[Token(Token = "0x403D263")]
			[FieldOffset(Offset = "0x10")]
			public bool isShowEffect;
		}

		// Token: 0x020075DD RID: 30173
		[Token(Token = "0x20075DD")]
		public struct OptionsAct
		{
			// Token: 0x0403D264 RID: 250468
			[Token(Token = "0x403D264")]
			[FieldOffset(Offset = "0x0")]
			public Act24sideMeldingItemViewModel model;

			// Token: 0x0403D265 RID: 250469
			[Token(Token = "0x403D265")]
			[FieldOffset(Offset = "0x8")]
			public float delay;

			// Token: 0x0403D266 RID: 250470
			[Token(Token = "0x403D266")]
			[FieldOffset(Offset = "0xC")]
			public bool isShowEffect;

			// Token: 0x0403D267 RID: 250471
			[Token(Token = "0x403D267")]
			[FieldOffset(Offset = "0x10")]
			public ILoadAsset assetLoader;

			// Token: 0x0403D268 RID: 250472
			[Token(Token = "0x403D268")]
			[FieldOffset(Offset = "0x18")]
			public string actId;
		}
	}
}
