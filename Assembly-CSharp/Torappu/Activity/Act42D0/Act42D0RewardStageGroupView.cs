using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x020073A5 RID: 29605
	[Token(Token = "0x20073A5")]
	public class Act42D0RewardStageGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029D88 RID: 171400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D88")]
		[Address(RVA = "0x25737F0", Offset = "0x25723F0", VA = "0x1825737F0")]
		public void Render(Act42D0RewardStageViewModel viewModel, int maxCount)
		{
		}

		// Token: 0x06029D89 RID: 171401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D89")]
		[Address(RVA = "0x2573A40", Offset = "0x2572640", VA = "0x182573A40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029D8A RID: 171402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D8A")]
		[Address(RVA = "0x2573BA0", Offset = "0x25727A0", VA = "0x182573BA0")]
		public Act42D0RewardStageGroupView()
		{
		}

		// Token: 0x0403BF65 RID: 245605
		[Token(Token = "0x403BF65")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _code;

		// Token: 0x0403BF66 RID: 245606
		[Token(Token = "0x403BF66")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0403BF67 RID: 245607
		[Token(Token = "0x403BF67")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0403BF68 RID: 245608
		[Token(Token = "0x403BF68")]
		[FieldOffset(Offset = "0x30")]
		private Act42D0RewardStageViewModel m_cachedViewModel;

		// Token: 0x0403BF69 RID: 245609
		[Token(Token = "0x403BF69")]
		[FieldOffset(Offset = "0x38")]
		private Act42D0RewardStageGroupView.Adapter m_adapter;

		// Token: 0x0403BF6A RID: 245610
		[Token(Token = "0x403BF6A")]
		[FieldOffset(Offset = "0x40")]
		private int m_maxCount;

		// Token: 0x0403BF6B RID: 245611
		[Token(Token = "0x403BF6B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BF6C RID: 245612
		[Token(Token = "0x403BF6C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BF6D RID: 245613
		[Token(Token = "0x403BF6D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020073A6 RID: 29606
		[Token(Token = "0x20073A6")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06029D8B RID: 171403 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029D8B")]
			[Address(RVA = "0x257FF10", Offset = "0x257EB10", VA = "0x18257FF10")]
			public Adapter(Act42D0RewardStageGroupView closure)
			{
			}

			// Token: 0x170062D0 RID: 25296
			// (get) Token: 0x06029D8C RID: 171404 RVA: 0x000D6C50 File Offset: 0x000D4E50
			[Token(Token = "0x170062D0")]
			public override int count
			{
				[Token(Token = "0x6029D8C")]
				[Address(RVA = "0x2580340", Offset = "0x257EF40", VA = "0x182580340", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06029D8D RID: 171405 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029D8D")]
			[Address(RVA = "0x257F2C0", Offset = "0x257DEC0", VA = "0x18257F2C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403BF6E RID: 245614
			[Token(Token = "0x403BF6E")]
			[FieldOffset(Offset = "0x20")]
			private Act42D0RewardStageGroupView m_closure;

			// Token: 0x0403BF6F RID: 245615
			[Token(Token = "0x403BF6F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403BF70 RID: 245616
			[Token(Token = "0x403BF70")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403BF71 RID: 245617
			[Token(Token = "0x403BF71")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
