using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007378 RID: 29560
	[Token(Token = "0x2007378")]
	public class Act42D0EffectSelectView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029CB1 RID: 171185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CB1")]
		[Address(RVA = "0x255ACC0", Offset = "0x25598C0", VA = "0x18255ACC0")]
		public void Render(Act42D0EffectViewModel viewModel)
		{
		}

		// Token: 0x06029CB2 RID: 171186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CB2")]
		[Address(RVA = "0x255AF50", Offset = "0x2559B50", VA = "0x18255AF50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029CB3 RID: 171187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CB3")]
		[Address(RVA = "0x255B0B0", Offset = "0x2559CB0", VA = "0x18255B0B0")]
		public Act42D0EffectSelectView()
		{
		}

		// Token: 0x0403BD7F RID: 245119
		[Token(Token = "0x403BD7F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0403BD80 RID: 245120
		[Token(Token = "0x403BD80")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0403BD81 RID: 245121
		[Token(Token = "0x403BD81")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0403BD82 RID: 245122
		[Token(Token = "0x403BD82")]
		[FieldOffset(Offset = "0x30")]
		private Act42D0EffectSelectView.Adapter m_adapter;

		// Token: 0x0403BD83 RID: 245123
		[Token(Token = "0x403BD83")]
		[FieldOffset(Offset = "0x38")]
		private ListDict<string, Act42D0EffectBranchViewModel> m_cachedViewModels;

		// Token: 0x0403BD84 RID: 245124
		[Token(Token = "0x403BD84")]
		[FieldOffset(Offset = "0x40")]
		private int m_cachedSequenceNum;

		// Token: 0x0403BD85 RID: 245125
		[Token(Token = "0x403BD85")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BD86 RID: 245126
		[Token(Token = "0x403BD86")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BD87 RID: 245127
		[Token(Token = "0x403BD87")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007379 RID: 29561
		[Token(Token = "0x2007379")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06029CB4 RID: 171188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029CB4")]
			[Address(RVA = "0x25642E0", Offset = "0x2562EE0", VA = "0x1825642E0")]
			public Adapter(Act42D0EffectSelectView closure)
			{
			}

			// Token: 0x170062AA RID: 25258
			// (get) Token: 0x06029CB5 RID: 171189 RVA: 0x000D68F0 File Offset: 0x000D4AF0
			[Token(Token = "0x170062AA")]
			public override int count
			{
				[Token(Token = "0x6029CB5")]
				[Address(RVA = "0x2564580", Offset = "0x2563180", VA = "0x182564580", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06029CB6 RID: 171190 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029CB6")]
			[Address(RVA = "0x2563CB0", Offset = "0x25628B0", VA = "0x182563CB0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403BD88 RID: 245128
			[Token(Token = "0x403BD88")]
			[FieldOffset(Offset = "0x20")]
			private Act42D0EffectSelectView m_closure;

			// Token: 0x0403BD89 RID: 245129
			[Token(Token = "0x403BD89")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403BD8A RID: 245130
			[Token(Token = "0x403BD8A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403BD8B RID: 245131
			[Token(Token = "0x403BD8B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
