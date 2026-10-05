using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007372 RID: 29554
	[Token(Token = "0x2007372")]
	public class Act42D0EffectSelectBranchView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029C97 RID: 171159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C97")]
		[Address(RVA = "0x2559B90", Offset = "0x2558790", VA = "0x182559B90")]
		public void Render(Act42D0EffectBranchViewModel viewModel, int sequenceNum)
		{
		}

		// Token: 0x06029C98 RID: 171160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C98")]
		[Address(RVA = "0x2559DF0", Offset = "0x25589F0", VA = "0x182559DF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029C99 RID: 171161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C99")]
		[Address(RVA = "0x2559F50", Offset = "0x2558B50", VA = "0x182559F50")]
		public Act42D0EffectSelectBranchView()
		{
		}

		// Token: 0x0403BD44 RID: 245060
		[Token(Token = "0x403BD44")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _name;

		// Token: 0x0403BD45 RID: 245061
		[Token(Token = "0x403BD45")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0403BD46 RID: 245062
		[Token(Token = "0x403BD46")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0403BD47 RID: 245063
		[Token(Token = "0x403BD47")]
		[FieldOffset(Offset = "0x30")]
		private Act42D0EffectSelectBranchView.Adapter m_adapter;

		// Token: 0x0403BD48 RID: 245064
		[Token(Token = "0x403BD48")]
		[FieldOffset(Offset = "0x38")]
		private ListDict<string, Act42D0EffectGroupViewModel> m_cachedViewModels;

		// Token: 0x0403BD49 RID: 245065
		[Token(Token = "0x403BD49")]
		[FieldOffset(Offset = "0x40")]
		private int m_cachedSequenceNum;

		// Token: 0x0403BD4A RID: 245066
		[Token(Token = "0x403BD4A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BD4B RID: 245067
		[Token(Token = "0x403BD4B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BD4C RID: 245068
		[Token(Token = "0x403BD4C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007373 RID: 29555
		[Token(Token = "0x2007373")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06029C9A RID: 171162 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C9A")]
			[Address(RVA = "0x25643E0", Offset = "0x2562FE0", VA = "0x1825643E0")]
			public Adapter(Act42D0EffectSelectBranchView closure)
			{
			}

			// Token: 0x170062A8 RID: 25256
			// (get) Token: 0x06029C9B RID: 171163 RVA: 0x000D68C0 File Offset: 0x000D4AC0
			[Token(Token = "0x170062A8")]
			public override int count
			{
				[Token(Token = "0x6029C9B")]
				[Address(RVA = "0x2564630", Offset = "0x2563230", VA = "0x182564630", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06029C9C RID: 171164 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029C9C")]
			[Address(RVA = "0x2563EB0", Offset = "0x2562AB0", VA = "0x182563EB0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403BD4D RID: 245069
			[Token(Token = "0x403BD4D")]
			[FieldOffset(Offset = "0x20")]
			private Act42D0EffectSelectBranchView m_closure;

			// Token: 0x0403BD4E RID: 245070
			[Token(Token = "0x403BD4E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403BD4F RID: 245071
			[Token(Token = "0x403BD4F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403BD50 RID: 245072
			[Token(Token = "0x403BD50")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
