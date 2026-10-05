using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020038EE RID: 14574
	[Token(Token = "0x20038EE")]
	public abstract class UIRecycleGridLayoutGroup : UIRecycleLayoutGroup
	{
		// Token: 0x170036FA RID: 14074
		// (get) Token: 0x060170A5 RID: 94373 RVA: 0x00094860 File Offset: 0x00092A60
		[Token(Token = "0x170036FA")]
		protected float perpendicularSpacing
		{
			[Token(Token = "0x60170A5")]
			[Address(RVA = "0xF79860", Offset = "0xF78460", VA = "0x180F79860")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060170A6 RID: 94374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60170A6")]
		[Address(RVA = "0xF79770", Offset = "0xF78370", VA = "0x180F79770", Slot = "20")]
		protected override void UpdateViews(int fromIndex)
		{
		}

		// Token: 0x060170A7 RID: 94375
		[Token(Token = "0x60170A7")]
		protected abstract void CalculateViewMeta(int fromIndex);

		// Token: 0x060170A8 RID: 94376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60170A8")]
		[Address(RVA = "0xF79800", Offset = "0xF78400", VA = "0x180F79800")]
		protected UIRecycleGridLayoutGroup()
		{
		}

		// Token: 0x060170A9 RID: 94377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60170A9")]
		[Address(RVA = "0xF79760", Offset = "0xF78360", VA = "0x180F79760")]
		private void <>xLuaBaseProxy_UpdateViews(int P0)
		{
		}

		// Token: 0x0401BD01 RID: 113921
		[Token(Token = "0x401BD01")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Layout")]
		private float _perpendicularSpacing;

		// Token: 0x0401BD02 RID: 113922
		[Token(Token = "0x401BD02")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_perpendicularSpacing;

		// Token: 0x0401BD03 RID: 113923
		[Token(Token = "0x401BD03")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateViews;

		// Token: 0x0401BD04 RID: 113924
		[Token(Token = "0x401BD04")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020038EF RID: 14575
		[Token(Token = "0x20038EF")]
		public interface IGridVirtualView : UIRecycleLayoutAdapter.IVirtualView, IHotfixable
		{
			// Token: 0x060170AA RID: 94378
			[Token(Token = "0x60170AA")]
			float GetPerpendicularPreferSize();

			// Token: 0x060170AB RID: 94379
			[Token(Token = "0x60170AB")]
			bool ForceLineBreak();
		}

		// Token: 0x020038F0 RID: 14576
		[Token(Token = "0x20038F0")]
		public abstract class GridVirtualView<T> : UIRecycleLayoutAdapter.VirtualView<T>, UIRecycleGridLayoutGroup.IGridVirtualView, UIRecycleLayoutAdapter.IVirtualView, IHotfixable where T : Component
		{
			// Token: 0x060170AC RID: 94380
			[Token(Token = "0x60170AC")]
			public abstract float GetPerpendicularPreferSize();

			// Token: 0x060170AD RID: 94381
			[Token(Token = "0x60170AD")]
			public abstract bool ForceLineBreak();

			// Token: 0x060170AE RID: 94382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60170AE")]
			protected GridVirtualView()
			{
			}

			// Token: 0x0401BD05 RID: 113925
			[Token(Token = "0x401BD05")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020038F1 RID: 14577
		[Token(Token = "0x20038F1")]
		public class GridLayoutMeta : UIRecycleLayoutGroup.ICustomLayoutMeta, IHotfixable
		{
			// Token: 0x060170AF RID: 94383 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60170AF")]
			[Address(RVA = "0xF72830", Offset = "0xF71430", VA = "0x180F72830")]
			public GridLayoutMeta()
			{
			}

			// Token: 0x0401BD06 RID: 113926
			[Token(Token = "0x401BD06")]
			[FieldOffset(Offset = "0x10")]
			public float perpendicularPos;

			// Token: 0x0401BD07 RID: 113927
			[Token(Token = "0x401BD07")]
			[FieldOffset(Offset = "0x14")]
			public float perpendicularSize;

			// Token: 0x0401BD08 RID: 113928
			[Token(Token = "0x401BD08")]
			[FieldOffset(Offset = "0x18")]
			public float curAxisSizeInSamePerpendicularGroup;

			// Token: 0x0401BD09 RID: 113929
			[Token(Token = "0x401BD09")]
			[FieldOffset(Offset = "0x1C")]
			public float maxPerpendicularSize;

			// Token: 0x0401BD0A RID: 113930
			[Token(Token = "0x401BD0A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
