using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x020073AC RID: 29612
	[Token(Token = "0x20073AC")]
	public class Act42D0RewardTitleView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029DA1 RID: 171425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DA1")]
		[Address(RVA = "0x2575010", Offset = "0x2573C10", VA = "0x182575010")]
		public void Render(ListDict<string, Act42D0RewardTitleViewModel> titles, int ratingMaxCount, string actId)
		{
		}

		// Token: 0x06029DA2 RID: 171426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DA2")]
		[Address(RVA = "0x2575230", Offset = "0x2573E30", VA = "0x182575230")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029DA3 RID: 171427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DA3")]
		[Address(RVA = "0x2575390", Offset = "0x2573F90", VA = "0x182575390")]
		public Act42D0RewardTitleView()
		{
		}

		// Token: 0x0403BF9A RID: 245658
		[Token(Token = "0x403BF9A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0403BF9B RID: 245659
		[Token(Token = "0x403BF9B")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x0403BF9C RID: 245660
		[Token(Token = "0x403BF9C")]
		[FieldOffset(Offset = "0x28")]
		private ListDict<string, Act42D0RewardTitleViewModel> m_cachedViewModels;

		// Token: 0x0403BF9D RID: 245661
		[Token(Token = "0x403BF9D")]
		[FieldOffset(Offset = "0x30")]
		private string m_cachedActId;

		// Token: 0x0403BF9E RID: 245662
		[Token(Token = "0x403BF9E")]
		[FieldOffset(Offset = "0x38")]
		private int m_maxCount;

		// Token: 0x0403BF9F RID: 245663
		[Token(Token = "0x403BF9F")]
		[FieldOffset(Offset = "0x40")]
		private Act42D0RewardTitleView.Adapter m_adapter;

		// Token: 0x0403BFA0 RID: 245664
		[Token(Token = "0x403BFA0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BFA1 RID: 245665
		[Token(Token = "0x403BFA1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BFA2 RID: 245666
		[Token(Token = "0x403BFA2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020073AD RID: 29613
		[Token(Token = "0x20073AD")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06029DA4 RID: 171428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029DA4")]
			[Address(RVA = "0x257FE90", Offset = "0x257EA90", VA = "0x18257FE90")]
			public Adapter(Act42D0RewardTitleView closure)
			{
			}

			// Token: 0x170062D2 RID: 25298
			// (get) Token: 0x06029DA5 RID: 171429 RVA: 0x000D6C80 File Offset: 0x000D4E80
			[Token(Token = "0x170062D2")]
			public override int count
			{
				[Token(Token = "0x6029DA5")]
				[Address(RVA = "0x25802D0", Offset = "0x257EED0", VA = "0x1825802D0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06029DA6 RID: 171430 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029DA6")]
			[Address(RVA = "0x257F5A0", Offset = "0x257E1A0", VA = "0x18257F5A0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403BFA3 RID: 245667
			[Token(Token = "0x403BFA3")]
			[FieldOffset(Offset = "0x20")]
			private Act42D0RewardTitleView m_closure;

			// Token: 0x0403BFA4 RID: 245668
			[Token(Token = "0x403BFA4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403BFA5 RID: 245669
			[Token(Token = "0x403BFA5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403BFA6 RID: 245670
			[Token(Token = "0x403BFA6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
