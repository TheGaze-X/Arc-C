using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200737A RID: 29562
	[Token(Token = "0x200737A")]
	public class Act42D0EffectView : DataBinder<Act42D0EffectProperty>
	{
		// Token: 0x06029CB7 RID: 171191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CB7")]
		[Address(RVA = "0x255D4A0", Offset = "0x255C0A0", VA = "0x18255D4A0", Slot = "7")]
		public override void OnValueChanged(Act42D0EffectProperty property)
		{
		}

		// Token: 0x06029CB8 RID: 171192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CB8")]
		[Address(RVA = "0x255D890", Offset = "0x255C490", VA = "0x18255D890")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029CB9 RID: 171193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CB9")]
		[Address(RVA = "0x255DAF0", Offset = "0x255C6F0", VA = "0x18255DAF0")]
		private void _RegisterTutorialGo()
		{
		}

		// Token: 0x06029CBA RID: 171194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CBA")]
		[Address(RVA = "0x255DA60", Offset = "0x255C660", VA = "0x18255DA60")]
		private void _NotifyEffectViewShown()
		{
		}

		// Token: 0x06029CBB RID: 171195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CBB")]
		[Address(RVA = "0x255DBB0", Offset = "0x255C7B0", VA = "0x18255DBB0")]
		public Act42D0EffectView()
		{
		}

		// Token: 0x0403BD8C RID: 245132
		[Token(Token = "0x403BD8C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act42D0EffectSelectView _selectView;

		// Token: 0x0403BD8D RID: 245133
		[Token(Token = "0x403BD8D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act42D0EffectDetailGroupView _detailGroupView;

		// Token: 0x0403BD8E RID: 245134
		[Token(Token = "0x403BD8E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Act42D0EffectBottomView _bottomView;

		// Token: 0x0403BD8F RID: 245135
		[Token(Token = "0x403BD8F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403BD90 RID: 245136
		[Token(Token = "0x403BD90")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _buffListGraphic;

		// Token: 0x0403BD91 RID: 245137
		[Token(Token = "0x403BD91")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0403BD92 RID: 245138
		[Token(Token = "0x403BD92")]
		[FieldOffset(Offset = "0x50")]
		private Act42D0EffectView.ShowHideSwitchTween m_switchTween;

		// Token: 0x0403BD93 RID: 245139
		[Token(Token = "0x403BD93")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403BD94 RID: 245140
		[Token(Token = "0x403BD94")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403BD95 RID: 245141
		[Token(Token = "0x403BD95")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BD96 RID: 245142
		[Token(Token = "0x403BD96")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGo;

		// Token: 0x0403BD97 RID: 245143
		[Token(Token = "0x403BD97")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__NotifyEffectViewShown;

		// Token: 0x0403BD98 RID: 245144
		[Token(Token = "0x403BD98")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200737B RID: 29563
		[Token(Token = "0x200737B")]
		private class ShowHideSwitchTween : UISwitchTween
		{
			// Token: 0x06029CBC RID: 171196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029CBC")]
			[Address(RVA = "0x2568680", Offset = "0x2567280", VA = "0x182568680")]
			public ShowHideSwitchTween(Act42D0EffectView closure)
			{
			}

			// Token: 0x06029CBD RID: 171197 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029CBD")]
			[Address(RVA = "0x2568490", Offset = "0x2567090", VA = "0x182568490", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06029CBE RID: 171198 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029CBE")]
			[Address(RVA = "0x2568370", Offset = "0x2566F70", VA = "0x182568370", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06029CBF RID: 171199 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029CBF")]
			[Address(RVA = "0x25682F0", Offset = "0x2566EF0", VA = "0x1825682F0", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x06029CC0 RID: 171200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029CC0")]
			[Address(RVA = "0x2568270", Offset = "0x2566E70", VA = "0x182568270", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x06029CC1 RID: 171201 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029CC1")]
			[Address(RVA = "0x25685B0", Offset = "0x25671B0", VA = "0x1825685B0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x06029CC2 RID: 171202 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029CC2")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x06029CC3 RID: 171203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029CC3")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x06029CC4 RID: 171204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029CC4")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0403BD99 RID: 245145
			[Token(Token = "0x403BD99")]
			[FieldOffset(Offset = "0x48")]
			private Act42D0EffectView m_closure;

			// Token: 0x0403BD9A RID: 245146
			[Token(Token = "0x403BD9A")]
			private const float ANIM_DURATION = 0.16f;

			// Token: 0x0403BD9B RID: 245147
			[Token(Token = "0x403BD9B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403BD9C RID: 245148
			[Token(Token = "0x403BD9C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0403BD9D RID: 245149
			[Token(Token = "0x403BD9D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0403BD9E RID: 245150
			[Token(Token = "0x403BD9E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0403BD9F RID: 245151
			[Token(Token = "0x403BD9F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x0403BDA0 RID: 245152
			[Token(Token = "0x403BDA0")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
