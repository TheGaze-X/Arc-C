using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075A4 RID: 30116
	[Token(Token = "0x20075A4")]
	public class Act24sideMeldingGoodGridView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170063B5 RID: 25525
		// (get) Token: 0x0602A60B RID: 173579 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A60C RID: 173580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170063B5")]
		public Action<Act24SideData.MeldingGoodDisplayType> onGridPostLayout
		{
			[Token(Token = "0x602A60B")]
			[Address(RVA = "0x260A520", Offset = "0x2609120", VA = "0x18260A520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602A60C")]
			[Address(RVA = "0x260A580", Offset = "0x2609180", VA = "0x18260A580")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602A60D RID: 173581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A60D")]
		[Address(RVA = "0x2609F30", Offset = "0x2608B30", VA = "0x182609F30")]
		public void Render(Act24sideMeldingGoodDisplayViewModel groupViewModel)
		{
		}

		// Token: 0x0602A60E RID: 173582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A60E")]
		[Address(RVA = "0x260A280", Offset = "0x2608E80", VA = "0x18260A280")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A60F RID: 173583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A60F")]
		[Address(RVA = "0x260A3F0", Offset = "0x2608FF0", VA = "0x18260A3F0")]
		private void _OnPostLayout()
		{
		}

		// Token: 0x0602A610 RID: 173584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A610")]
		[Address(RVA = "0x260A4C0", Offset = "0x26090C0", VA = "0x18260A4C0")]
		public Act24sideMeldingGoodGridView()
		{
		}

		// Token: 0x0403CF88 RID: 249736
		[Token(Token = "0x403CF88")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _layoutContent;

		// Token: 0x0403CF89 RID: 249737
		[Token(Token = "0x403CF89")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act24sideMeldingGoodTitleAbstractView _titleView;

		// Token: 0x0403CF8A RID: 249738
		[Token(Token = "0x403CF8A")]
		[FieldOffset(Offset = "0x28")]
		private Act24sideMeldingGoodGridView.Adapter m_adapter;

		// Token: 0x0403CF8B RID: 249739
		[Token(Token = "0x403CF8B")]
		[FieldOffset(Offset = "0x30")]
		private Act24sideMeldingGoodDisplayViewModel m_model;

		// Token: 0x0403CF8C RID: 249740
		[Token(Token = "0x403CF8C")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0403CF8D RID: 249741
		[Token(Token = "0x403CF8D")]
		[FieldOffset(Offset = "0x3C")]
		private Act24SideData.MeldingGoodDisplayType m_displayType;

		// Token: 0x0403CF8E RID: 249742
		[Token(Token = "0x403CF8E")]
		[FieldOffset(Offset = "0x40")]
		private UILayoutDimensionListener m_dimensionListener;

		// Token: 0x0403CF90 RID: 249744
		[Token(Token = "0x403CF90")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onGridPostLayout;

		// Token: 0x0403CF91 RID: 249745
		[Token(Token = "0x403CF91")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onGridPostLayout;

		// Token: 0x0403CF92 RID: 249746
		[Token(Token = "0x403CF92")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CF93 RID: 249747
		[Token(Token = "0x403CF93")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CF94 RID: 249748
		[Token(Token = "0x403CF94")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnPostLayout;

		// Token: 0x0403CF95 RID: 249749
		[Token(Token = "0x403CF95")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020075A5 RID: 30117
		[Token(Token = "0x20075A5")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0602A611 RID: 173585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A611")]
			[Address(RVA = "0x261B220", Offset = "0x2619E20", VA = "0x18261B220")]
			public Adapter(Act24sideMeldingGoodGridView closure)
			{
			}

			// Token: 0x170063B6 RID: 25526
			// (get) Token: 0x0602A612 RID: 173586 RVA: 0x000D8318 File Offset: 0x000D6518
			[Token(Token = "0x170063B6")]
			public override int count
			{
				[Token(Token = "0x602A612")]
				[Address(RVA = "0x261B530", Offset = "0x261A130", VA = "0x18261B530", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A613 RID: 173587 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A613")]
			[Address(RVA = "0x261ADD0", Offset = "0x26199D0", VA = "0x18261ADD0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403CF96 RID: 249750
			[Token(Token = "0x403CF96")]
			[FieldOffset(Offset = "0x20")]
			private Act24sideMeldingGoodGridView m_closure;

			// Token: 0x0403CF97 RID: 249751
			[Token(Token = "0x403CF97")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403CF98 RID: 249752
			[Token(Token = "0x403CF98")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403CF99 RID: 249753
			[Token(Token = "0x403CF99")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
