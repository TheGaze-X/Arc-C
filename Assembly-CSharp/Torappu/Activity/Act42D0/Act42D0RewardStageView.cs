using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x020073A8 RID: 29608
	[Token(Token = "0x20073A8")]
	public class Act42D0RewardStageView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029D90 RID: 171408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D90")]
		[Address(RVA = "0x2573FA0", Offset = "0x2572BA0", VA = "0x182573FA0")]
		public void Render(ListDict<string, Act42D0RewardStageViewModel> stages, int maxCount)
		{
		}

		// Token: 0x06029D91 RID: 171409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D91")]
		[Address(RVA = "0x25741B0", Offset = "0x2572DB0", VA = "0x1825741B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029D92 RID: 171410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D92")]
		[Address(RVA = "0x2574310", Offset = "0x2572F10", VA = "0x182574310")]
		public Act42D0RewardStageView()
		{
		}

		// Token: 0x0403BF7A RID: 245626
		[Token(Token = "0x403BF7A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0403BF7B RID: 245627
		[Token(Token = "0x403BF7B")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x0403BF7C RID: 245628
		[Token(Token = "0x403BF7C")]
		[FieldOffset(Offset = "0x28")]
		private ListDict<string, Act42D0RewardStageViewModel> m_cachedViewModels;

		// Token: 0x0403BF7D RID: 245629
		[Token(Token = "0x403BF7D")]
		[FieldOffset(Offset = "0x30")]
		private int m_maxCount;

		// Token: 0x0403BF7E RID: 245630
		[Token(Token = "0x403BF7E")]
		[FieldOffset(Offset = "0x38")]
		private Act42D0RewardStageView.Adapter m_adapter;

		// Token: 0x0403BF7F RID: 245631
		[Token(Token = "0x403BF7F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BF80 RID: 245632
		[Token(Token = "0x403BF80")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BF81 RID: 245633
		[Token(Token = "0x403BF81")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020073A9 RID: 29609
		[Token(Token = "0x20073A9")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06029D93 RID: 171411 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029D93")]
			[Address(RVA = "0x2580010", Offset = "0x257EC10", VA = "0x182580010")]
			public Adapter(Act42D0RewardStageView closure)
			{
			}

			// Token: 0x170062D1 RID: 25297
			// (get) Token: 0x06029D94 RID: 171412 RVA: 0x000D6C68 File Offset: 0x000D4E68
			[Token(Token = "0x170062D1")]
			public override int count
			{
				[Token(Token = "0x6029D94")]
				[Address(RVA = "0x25801A0", Offset = "0x257EDA0", VA = "0x1825801A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06029D95 RID: 171413 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029D95")]
			[Address(RVA = "0x257F8B0", Offset = "0x257E4B0", VA = "0x18257F8B0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403BF82 RID: 245634
			[Token(Token = "0x403BF82")]
			[FieldOffset(Offset = "0x20")]
			private Act42D0RewardStageView m_closure;

			// Token: 0x0403BF83 RID: 245635
			[Token(Token = "0x403BF83")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403BF84 RID: 245636
			[Token(Token = "0x403BF84")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403BF85 RID: 245637
			[Token(Token = "0x403BF85")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
