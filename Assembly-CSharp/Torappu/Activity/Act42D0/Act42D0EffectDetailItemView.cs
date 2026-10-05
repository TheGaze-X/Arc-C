using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007370 RID: 29552
	[Token(Token = "0x2007370")]
	public class Act42D0EffectDetailItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170062A7 RID: 25255
		// (get) Token: 0x06029C8A RID: 171146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170062A7")]
		public CanvasGroup canvasGroup
		{
			[Token(Token = "0x6029C8A")]
			[Address(RVA = "0x2558FE0", Offset = "0x2557BE0", VA = "0x182558FE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029C8B RID: 171147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C8B")]
		[Address(RVA = "0x2558790", Offset = "0x2557390", VA = "0x182558790")]
		public void Render(Act42D0EffectItemViewModel viewModel, bool needReset)
		{
		}

		// Token: 0x06029C8C RID: 171148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C8C")]
		[Address(RVA = "0x25589F0", Offset = "0x25575F0", VA = "0x1825589F0")]
		public void TriggerNewlyAddAnim()
		{
		}

		// Token: 0x06029C8D RID: 171149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C8D")]
		[Address(RVA = "0x2558B00", Offset = "0x2557700", VA = "0x182558B00")]
		public void TriggerRemoveAnim()
		{
		}

		// Token: 0x06029C8E RID: 171150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C8E")]
		[Address(RVA = "0x2558C20", Offset = "0x2557820", VA = "0x182558C20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029C8F RID: 171151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C8F")]
		[Address(RVA = "0x2558D30", Offset = "0x2557930", VA = "0x182558D30")]
		private void _UpdateDescHeight(string content)
		{
		}

		// Token: 0x06029C90 RID: 171152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C90")]
		[Address(RVA = "0x2558660", Offset = "0x2557260", VA = "0x182558660")]
		public void OnRemoveClick()
		{
		}

		// Token: 0x06029C91 RID: 171153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C91")]
		[Address(RVA = "0x2558550", Offset = "0x2557150", VA = "0x182558550")]
		private void OnDestroy()
		{
		}

		// Token: 0x06029C92 RID: 171154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C92")]
		[Address(RVA = "0x2558B80", Offset = "0x2557780", VA = "0x182558B80")]
		private void _ClearLightTween()
		{
		}

		// Token: 0x06029C93 RID: 171155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C93")]
		[Address(RVA = "0x2558F80", Offset = "0x2557B80", VA = "0x182558F80")]
		public Act42D0EffectDetailItemView()
		{
		}

		// Token: 0x0403BD25 RID: 245029
		[Token(Token = "0x403BD25")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _lightAnim;

		// Token: 0x0403BD26 RID: 245030
		[Token(Token = "0x403BD26")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _itemAnim;

		// Token: 0x0403BD27 RID: 245031
		[Token(Token = "0x403BD27")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _cost;

		// Token: 0x0403BD28 RID: 245032
		[Token(Token = "0x403BD28")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0403BD29 RID: 245033
		[Token(Token = "0x403BD29")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x0403BD2A RID: 245034
		[Token(Token = "0x403BD2A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _reserveHeight;

		// Token: 0x0403BD2B RID: 245035
		[Token(Token = "0x403BD2B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403BD2C RID: 245036
		[Token(Token = "0x403BD2C")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x0403BD2D RID: 245037
		[Token(Token = "0x403BD2D")]
		[FieldOffset(Offset = "0x68")]
		private Act42D0EffectItemViewModel m_cachedViewModel;

		// Token: 0x0403BD2E RID: 245038
		[Token(Token = "0x403BD2E")]
		[FieldOffset(Offset = "0x70")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403BD2F RID: 245039
		[Token(Token = "0x403BD2F")]
		[FieldOffset(Offset = "0x80")]
		private TextGenerator m_textGenerator;

		// Token: 0x0403BD30 RID: 245040
		[Token(Token = "0x403BD30")]
		[FieldOffset(Offset = "0x88")]
		private TextGenerationSettings m_textSettings;

		// Token: 0x0403BD31 RID: 245041
		[Token(Token = "0x403BD31")]
		[FieldOffset(Offset = "0xE8")]
		private Tween m_lightTween;

		// Token: 0x0403BD32 RID: 245042
		[Token(Token = "0x403BD32")]
		[FieldOffset(Offset = "0xF0")]
		private AnimationSwitchTween m_itemTween;

		// Token: 0x0403BD33 RID: 245043
		[Token(Token = "0x403BD33")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_canvasGroup;

		// Token: 0x0403BD34 RID: 245044
		[Token(Token = "0x403BD34")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BD35 RID: 245045
		[Token(Token = "0x403BD35")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TriggerNewlyAddAnim;

		// Token: 0x0403BD36 RID: 245046
		[Token(Token = "0x403BD36")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TriggerRemoveAnim;

		// Token: 0x0403BD37 RID: 245047
		[Token(Token = "0x403BD37")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BD38 RID: 245048
		[Token(Token = "0x403BD38")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateDescHeight;

		// Token: 0x0403BD39 RID: 245049
		[Token(Token = "0x403BD39")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnRemoveClick;

		// Token: 0x0403BD3A RID: 245050
		[Token(Token = "0x403BD3A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403BD3B RID: 245051
		[Token(Token = "0x403BD3B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ClearLightTween;

		// Token: 0x0403BD3C RID: 245052
		[Token(Token = "0x403BD3C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
