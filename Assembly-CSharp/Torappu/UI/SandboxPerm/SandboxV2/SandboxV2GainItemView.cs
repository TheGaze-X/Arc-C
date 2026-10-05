using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004309 RID: 17161
	[Token(Token = "0x2004309")]
	public class SandboxV2GainItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003E91 RID: 16017
		// (get) Token: 0x0601A5DB RID: 107995 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A5DC RID: 107996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003E91")]
		public Action<int> onItemClicked
		{
			[Token(Token = "0x601A5DB")]
			[Address(RVA = "0x134C520", Offset = "0x134B120", VA = "0x18134C520")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A5DC")]
			[Address(RVA = "0x134C580", Offset = "0x134B180", VA = "0x18134C580")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003E92 RID: 16018
		// (get) Token: 0x0601A5DD RID: 107997 RVA: 0x000A1940 File Offset: 0x0009FB40
		[Token(Token = "0x17003E92")]
		public bool isEnterAnimPlaying
		{
			[Token(Token = "0x601A5DD")]
			[Address(RVA = "0x134C4B0", Offset = "0x134B0B0", VA = "0x18134C4B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601A5DE RID: 107998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5DE")]
		[Address(RVA = "0x134C000", Offset = "0x134AC00", VA = "0x18134C000")]
		public void Render(IList<UIItemViewModel> itemModels)
		{
		}

		// Token: 0x0601A5DF RID: 107999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A5DF")]
		[Address(RVA = "0x134C290", Offset = "0x134AE90", VA = "0x18134C290")]
		public GameObject TipOnlyGetItemCardGo(int index)
		{
			return null;
		}

		// Token: 0x0601A5E0 RID: 108000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5E0")]
		[Address(RVA = "0x134BF70", Offset = "0x134AB70", VA = "0x18134BF70")]
		public void PlayRewardAudio()
		{
		}

		// Token: 0x0601A5E1 RID: 108001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5E1")]
		[Address(RVA = "0x134C320", Offset = "0x134AF20", VA = "0x18134C320")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A5E2 RID: 108002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5E2")]
		[Address(RVA = "0x134C450", Offset = "0x134B050", VA = "0x18134C450")]
		public SandboxV2GainItemView()
		{
		}

		// Token: 0x0402179C RID: 137116
		[Token(Token = "0x402179C")]
		private const string ENTER_ANIM_KEY = "sandbox_v2_gain_item_enter";

		// Token: 0x0402179D RID: 137117
		[Token(Token = "0x402179D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0402179E RID: 137118
		[Token(Token = "0x402179E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0402179F RID: 137119
		[Token(Token = "0x402179F")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInited;

		// Token: 0x040217A0 RID: 137120
		[Token(Token = "0x40217A0")]
		[FieldOffset(Offset = "0x30")]
		private IList<UIItemViewModel> m_cachedItemList;

		// Token: 0x040217A1 RID: 137121
		[Token(Token = "0x40217A1")]
		[FieldOffset(Offset = "0x38")]
		private SandboxV2GainItemView.Adapter m_adapter;

		// Token: 0x040217A2 RID: 137122
		[Token(Token = "0x40217A2")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_cachedEnterAnim;

		// Token: 0x040217A4 RID: 137124
		[Token(Token = "0x40217A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x040217A5 RID: 137125
		[Token(Token = "0x40217A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x040217A6 RID: 137126
		[Token(Token = "0x40217A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isEnterAnimPlaying;

		// Token: 0x040217A7 RID: 137127
		[Token(Token = "0x40217A7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040217A8 RID: 137128
		[Token(Token = "0x40217A8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TipOnlyGetItemCardGo;

		// Token: 0x040217A9 RID: 137129
		[Token(Token = "0x40217A9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PlayRewardAudio;

		// Token: 0x040217AA RID: 137130
		[Token(Token = "0x40217AA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040217AB RID: 137131
		[Token(Token = "0x40217AB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200430A RID: 17162
		[Token(Token = "0x200430A")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601A5E3 RID: 108003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A5E3")]
			[Address(RVA = "0x133FE60", Offset = "0x133EA60", VA = "0x18133FE60")]
			public Adapter(SandboxV2GainItemView closure)
			{
			}

			// Token: 0x17003E93 RID: 16019
			// (get) Token: 0x0601A5E4 RID: 108004 RVA: 0x000A1958 File Offset: 0x0009FB58
			[Token(Token = "0x17003E93")]
			public override int count
			{
				[Token(Token = "0x601A5E4")]
				[Address(RVA = "0x133FEE0", Offset = "0x133EAE0", VA = "0x18133FEE0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A5E5 RID: 108005 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A5E5")]
			[Address(RVA = "0x133FA80", Offset = "0x133E680", VA = "0x18133FA80", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040217AC RID: 137132
			[Token(Token = "0x40217AC")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2GainItemView m_closure;

			// Token: 0x040217AD RID: 137133
			[Token(Token = "0x40217AD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040217AE RID: 137134
			[Token(Token = "0x40217AE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040217AF RID: 137135
			[Token(Token = "0x40217AF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
