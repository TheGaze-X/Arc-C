using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077E5 RID: 30693
	[Token(Token = "0x20077E5")]
	public class Act1VHalfIdleRecruitResultCharItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B113 RID: 176403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B113")]
		[Address(RVA = "0x26DFB50", Offset = "0x26DE750", VA = "0x1826DFB50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B114 RID: 176404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B114")]
		[Address(RVA = "0x26DFC70", Offset = "0x26DE870", VA = "0x1826DFC70")]
		private void _Render(Act1VHalfIdleRecruitResultCharItemView.VirtualView virtualView)
		{
		}

		// Token: 0x0602B115 RID: 176405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B115")]
		[Address(RVA = "0x26DFE30", Offset = "0x26DEA30", VA = "0x1826DFE30")]
		public Act1VHalfIdleRecruitResultCharItemView()
		{
		}

		// Token: 0x0403E385 RID: 254853
		[Token(Token = "0x403E385")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _height;

		// Token: 0x0403E386 RID: 254854
		[Token(Token = "0x403E386")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _charList;

		// Token: 0x0403E387 RID: 254855
		[Token(Token = "0x403E387")]
		[FieldOffset(Offset = "0x28")]
		private bool m_inited;

		// Token: 0x0403E388 RID: 254856
		[Token(Token = "0x403E388")]
		[FieldOffset(Offset = "0x30")]
		private Act1VHalfIdleRecruitResultCharItemView.Adapter m_adapter;

		// Token: 0x0403E389 RID: 254857
		[Token(Token = "0x403E389")]
		[FieldOffset(Offset = "0x38")]
		private Act1VHalfIdleRecruitResultCharItemView.VirtualView m_cachedData;

		// Token: 0x0403E38A RID: 254858
		[Token(Token = "0x403E38A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E38B RID: 254859
		[Token(Token = "0x403E38B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403E38C RID: 254860
		[Token(Token = "0x403E38C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020077E6 RID: 30694
		[Token(Token = "0x20077E6")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<Act1VHalfIdleRecruitResultCharItemView>
		{
			// Token: 0x0602B116 RID: 176406 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B116")]
			[Address(RVA = "0x26EDAC0", Offset = "0x26EC6C0", VA = "0x1826EDAC0", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0602B117 RID: 176407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B117")]
			[Address(RVA = "0x26EDF90", Offset = "0x26ECB90", VA = "0x1826EDF90", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x0602B118 RID: 176408 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B118")]
			[Address(RVA = "0x26ED7B0", Offset = "0x26EC3B0", VA = "0x1826ED7B0", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0602B119 RID: 176409 RVA: 0x000DABB0 File Offset: 0x000D8DB0
			[Token(Token = "0x602B119")]
			[Address(RVA = "0x26ED9E0", Offset = "0x26EC5E0", VA = "0x1826ED9E0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0602B11A RID: 176410 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B11A")]
			[Address(RVA = "0x26EE220", Offset = "0x26ECE20", VA = "0x1826EE220")]
			public VirtualView()
			{
			}

			// Token: 0x0403E38D RID: 254861
			[Token(Token = "0x403E38D")]
			[FieldOffset(Offset = "0x20")]
			public List<Act1VHalfIdleCharAvatarViewModel> charViewModels;

			// Token: 0x0403E38E RID: 254862
			[Token(Token = "0x403E38E")]
			[FieldOffset(Offset = "0x28")]
			public int startIndex;

			// Token: 0x0403E38F RID: 254863
			[Token(Token = "0x403E38F")]
			[FieldOffset(Offset = "0x2C")]
			public int columnCount;

			// Token: 0x0403E390 RID: 254864
			[Token(Token = "0x403E390")]
			[FieldOffset(Offset = "0x30")]
			public Act1VHalfIdleRecruitResultCharItemView prefab;

			// Token: 0x0403E391 RID: 254865
			[Token(Token = "0x403E391")]
			[FieldOffset(Offset = "0x38")]
			public bool isFirstRecruit;

			// Token: 0x0403E392 RID: 254866
			[Token(Token = "0x403E392")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0403E393 RID: 254867
			[Token(Token = "0x403E393")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0403E394 RID: 254868
			[Token(Token = "0x403E394")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0403E395 RID: 254869
			[Token(Token = "0x403E395")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0403E396 RID: 254870
			[Token(Token = "0x403E396")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020077E7 RID: 30695
		[Token(Token = "0x20077E7")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0602B11B RID: 176411 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B11B")]
			[Address(RVA = "0x26E9C80", Offset = "0x26E8880", VA = "0x1826E9C80")]
			public Adapter(Act1VHalfIdleRecruitResultCharItemView closure)
			{
			}

			// Token: 0x170064CE RID: 25806
			// (get) Token: 0x0602B11C RID: 176412 RVA: 0x000DABC8 File Offset: 0x000D8DC8
			[Token(Token = "0x170064CE")]
			public override int count
			{
				[Token(Token = "0x602B11C")]
				[Address(RVA = "0x26E9E50", Offset = "0x26E8A50", VA = "0x1826E9E50", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602B11D RID: 176413 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B11D")]
			[Address(RVA = "0x26E9290", Offset = "0x26E7E90", VA = "0x1826E9290", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403E397 RID: 254871
			[Token(Token = "0x403E397")]
			[FieldOffset(Offset = "0x20")]
			private Act1VHalfIdleRecruitResultCharItemView m_closure;

			// Token: 0x0403E398 RID: 254872
			[Token(Token = "0x403E398")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403E399 RID: 254873
			[Token(Token = "0x403E399")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403E39A RID: 254874
			[Token(Token = "0x403E39A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
