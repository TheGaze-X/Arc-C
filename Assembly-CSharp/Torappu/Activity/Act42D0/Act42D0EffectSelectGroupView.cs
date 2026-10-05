using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007374 RID: 29556
	[Token(Token = "0x2007374")]
	public class Act42D0EffectSelectGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029C9D RID: 171165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C9D")]
		[Address(RVA = "0x255A070", Offset = "0x2558C70", VA = "0x18255A070")]
		public void Render(Act42D0EffectGroupViewModel viewModel, int sequenceNum)
		{
		}

		// Token: 0x06029C9E RID: 171166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C9E")]
		[Address(RVA = "0x255A290", Offset = "0x2558E90", VA = "0x18255A290")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029C9F RID: 171167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C9F")]
		[Address(RVA = "0x2559FC0", Offset = "0x2558BC0", VA = "0x182559FC0")]
		public void OnClearEffect()
		{
		}

		// Token: 0x06029CA0 RID: 171168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CA0")]
		[Address(RVA = "0x255A3F0", Offset = "0x2558FF0", VA = "0x18255A3F0")]
		public Act42D0EffectSelectGroupView()
		{
		}

		// Token: 0x0403BD51 RID: 245073
		[Token(Token = "0x403BD51")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0403BD52 RID: 245074
		[Token(Token = "0x403BD52")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x0403BD53 RID: 245075
		[Token(Token = "0x403BD53")]
		[FieldOffset(Offset = "0x28")]
		private Act42D0EffectSelectGroupView.Adapter m_adapter;

		// Token: 0x0403BD54 RID: 245076
		[Token(Token = "0x403BD54")]
		[FieldOffset(Offset = "0x30")]
		private List<Act42D0EffectItemViewModel> m_cachedViewModels;

		// Token: 0x0403BD55 RID: 245077
		[Token(Token = "0x403BD55")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403BD56 RID: 245078
		[Token(Token = "0x403BD56")]
		[FieldOffset(Offset = "0x48")]
		private int m_cachedSequenceNum;

		// Token: 0x0403BD57 RID: 245079
		[Token(Token = "0x403BD57")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BD58 RID: 245080
		[Token(Token = "0x403BD58")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BD59 RID: 245081
		[Token(Token = "0x403BD59")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClearEffect;

		// Token: 0x0403BD5A RID: 245082
		[Token(Token = "0x403BD5A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007375 RID: 29557
		[Token(Token = "0x2007375")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06029CA1 RID: 171169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029CA1")]
			[Address(RVA = "0x2564360", Offset = "0x2562F60", VA = "0x182564360")]
			public Adapter(Act42D0EffectSelectGroupView closure)
			{
			}

			// Token: 0x170062A9 RID: 25257
			// (get) Token: 0x06029CA2 RID: 171170 RVA: 0x000D68D8 File Offset: 0x000D4AD8
			[Token(Token = "0x170062A9")]
			public override int count
			{
				[Token(Token = "0x6029CA2")]
				[Address(RVA = "0x25644C0", Offset = "0x25630C0", VA = "0x1825644C0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06029CA3 RID: 171171 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029CA3")]
			[Address(RVA = "0x2563B00", Offset = "0x2562700", VA = "0x182563B00", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403BD5B RID: 245083
			[Token(Token = "0x403BD5B")]
			[FieldOffset(Offset = "0x20")]
			private Act42D0EffectSelectGroupView m_closure;

			// Token: 0x0403BD5C RID: 245084
			[Token(Token = "0x403BD5C")]
			private const int MIN_COUNT = 3;

			// Token: 0x0403BD5D RID: 245085
			[Token(Token = "0x403BD5D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403BD5E RID: 245086
			[Token(Token = "0x403BD5E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403BD5F RID: 245087
			[Token(Token = "0x403BD5F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
