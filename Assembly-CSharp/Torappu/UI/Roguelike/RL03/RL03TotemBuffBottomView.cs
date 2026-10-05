using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200585B RID: 22619
	[Token(Token = "0x200585B")]
	public class RL03TotemBuffBottomView : DataBinder<RL03TotemBottomViewProperty>
	{
		// Token: 0x17004D7F RID: 19839
		// (get) Token: 0x0602109A RID: 135322 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602109B RID: 135323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004D7F")]
		public Action onConfirmClick
		{
			[Token(Token = "0x602109A")]
			[Address(RVA = "0x1B62870", Offset = "0x1B61470", VA = "0x181B62870")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602109B")]
			[Address(RVA = "0x1B628E0", Offset = "0x1B614E0", VA = "0x181B628E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602109C RID: 135324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602109C")]
		[Address(RVA = "0x1B61AA0", Offset = "0x1B606A0", VA = "0x181B61AA0", Slot = "7")]
		public override void OnValueChanged(RL03TotemBottomViewProperty property)
		{
		}

		// Token: 0x0602109D RID: 135325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602109D")]
		[Address(RVA = "0x1B624F0", Offset = "0x1B610F0", VA = "0x181B624F0")]
		private void _PlayResonanceAnim(bool isTotemResonance)
		{
		}

		// Token: 0x0602109E RID: 135326 RVA: 0x000B8458 File Offset: 0x000B6658
		[Token(Token = "0x602109E")]
		[Address(RVA = "0x1B62340", Offset = "0x1B60F40", VA = "0x181B62340")]
		private bool _NeedResetResonanceAnim(RL03TotemBuffBottomView.CacheTotemInfoStruct prevTotemInfoStruct, RL03TotemBuffBottomView.CacheTotemInfoStruct newTotemInfoStruct)
		{
			return default(bool);
		}

		// Token: 0x0602109F RID: 135327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602109F")]
		[Address(RVA = "0x1B619E0", Offset = "0x1B605E0", VA = "0x181B619E0")]
		public void EventOnConfirmBtnClick()
		{
		}

		// Token: 0x060210A0 RID: 135328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60210A0")]
		[Address(RVA = "0x1B627E0", Offset = "0x1B613E0", VA = "0x181B627E0")]
		public RL03TotemBuffBottomView()
		{
		}

		// Token: 0x0402CF16 RID: 184086
		[Token(Token = "0x402CF16")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<RoguelikeTotemColorType, Color> NONE_RESONANCE_COLOR_DICT;

		// Token: 0x0402CF17 RID: 184087
		[Token(Token = "0x402CF17")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RL03TotemBuffBottomDescView _locationTotemDescView;

		// Token: 0x0402CF18 RID: 184088
		[Token(Token = "0x402CF18")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RL03TotemBuffBottomDescView _effectTotemDescView;

		// Token: 0x0402CF19 RID: 184089
		[Token(Token = "0x402CF19")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _emptyDesc;

		// Token: 0x0402CF1A RID: 184090
		[Token(Token = "0x402CF1A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _imgLocation;

		// Token: 0x0402CF1B RID: 184091
		[Token(Token = "0x402CF1B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _imgEffect;

		// Token: 0x0402CF1C RID: 184092
		[Token(Token = "0x402CF1C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _imgResonance;

		// Token: 0x0402CF1D RID: 184093
		[Token(Token = "0x402CF1D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelResonance;

		// Token: 0x0402CF1E RID: 184094
		[Token(Token = "0x402CF1E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgTotemBkg;

		// Token: 0x0402CF1F RID: 184095
		[Token(Token = "0x402CF1F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RL03TotemBuffBottomConfirmView _confirmView;

		// Token: 0x0402CF20 RID: 184096
		[Token(Token = "0x402CF20")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _resonanceAnimLocation;

		// Token: 0x0402CF22 RID: 184098
		[Token(Token = "0x402CF22")]
		[FieldOffset(Offset = "0x80")]
		private RL03TotemBuffBottomViewModel m_viewModel;

		// Token: 0x0402CF23 RID: 184099
		[Token(Token = "0x402CF23")]
		[FieldOffset(Offset = "0x88")]
		private RL03TotemBuffBottomView.CacheTotemInfoStruct m_cachedTotemInfoStruct;

		// Token: 0x0402CF24 RID: 184100
		[Token(Token = "0x402CF24")]
		[FieldOffset(Offset = "0xA8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402CF25 RID: 184101
		[Token(Token = "0x402CF25")]
		[FieldOffset(Offset = "0xB8")]
		private Tween m_resonanceTween;

		// Token: 0x0402CF26 RID: 184102
		[Token(Token = "0x402CF26")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onConfirmClick;

		// Token: 0x0402CF27 RID: 184103
		[Token(Token = "0x402CF27")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onConfirmClick;

		// Token: 0x0402CF28 RID: 184104
		[Token(Token = "0x402CF28")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402CF29 RID: 184105
		[Token(Token = "0x402CF29")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayResonanceAnim;

		// Token: 0x0402CF2A RID: 184106
		[Token(Token = "0x402CF2A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__NeedResetResonanceAnim;

		// Token: 0x0402CF2B RID: 184107
		[Token(Token = "0x402CF2B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnConfirmBtnClick;

		// Token: 0x0402CF2C RID: 184108
		[Token(Token = "0x402CF2C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200585C RID: 22620
		[Token(Token = "0x200585C")]
		private struct CacheTotemInfoStruct
		{
			// Token: 0x060210A2 RID: 135330 RVA: 0x000B8470 File Offset: 0x000B6670
			[Token(Token = "0x60210A2")]
			[Address(RVA = "0x1B5B5C0", Offset = "0x1B5A1C0", VA = "0x181B5B5C0")]
			public static RL03TotemBuffBottomView.CacheTotemInfoStruct Create(RL03TotemBuffBottomViewModel viewModel)
			{
				return default(RL03TotemBuffBottomView.CacheTotemInfoStruct);
			}

			// Token: 0x0402CF2D RID: 184109
			[Token(Token = "0x402CF2D")]
			[FieldOffset(Offset = "0x0")]
			public string locaticonTotemId;

			// Token: 0x0402CF2E RID: 184110
			[Token(Token = "0x402CF2E")]
			[FieldOffset(Offset = "0x8")]
			public string locationTotemInstId;

			// Token: 0x0402CF2F RID: 184111
			[Token(Token = "0x402CF2F")]
			[FieldOffset(Offset = "0x10")]
			public string effectTotemId;

			// Token: 0x0402CF30 RID: 184112
			[Token(Token = "0x402CF30")]
			[FieldOffset(Offset = "0x18")]
			public string effectTotemInstId;
		}
	}
}
