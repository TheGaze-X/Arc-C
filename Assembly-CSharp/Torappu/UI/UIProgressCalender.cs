using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039A0 RID: 14752
	[Token(Token = "0x20039A0")]
	public class UIProgressCalender : MonoBehaviour, IHotfixable
	{
		// Token: 0x06017520 RID: 95520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017520")]
		[Address(RVA = "0xFAFAA0", Offset = "0xFAE6A0", VA = "0x180FAFAA0")]
		public void Render(UIProgressCalender.Param param)
		{
		}

		// Token: 0x06017521 RID: 95521 RVA: 0x00095EE0 File Offset: 0x000940E0
		[Token(Token = "0x6017521")]
		[Address(RVA = "0xFAFB70", Offset = "0xFAE770", VA = "0x180FAFB70")]
		private UIProgressCalender.ViewModel _CalcViewModel(UIProgressCalender.Param param)
		{
			return default(UIProgressCalender.ViewModel);
		}

		// Token: 0x06017522 RID: 95522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017522")]
		[Address(RVA = "0xFB0300", Offset = "0xFAEF00", VA = "0x180FB0300")]
		private void _ResetViewsIfNecessary(IList<UIProgressCalender.NodeModel> nodeModels)
		{
		}

		// Token: 0x06017523 RID: 95523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017523")]
		[Address(RVA = "0xFB05F0", Offset = "0xFAF1F0", VA = "0x180FB05F0")]
		private void _UpdateViewLayouts(UIProgressCalender.ViewModel viewModel)
		{
		}

		// Token: 0x06017524 RID: 95524 RVA: 0x00095EF8 File Offset: 0x000940F8
		[Token(Token = "0x6017524")]
		[Address(RVA = "0xFB0180", Offset = "0xFAED80", VA = "0x180FB0180")]
		private static DateTime _ReadIndexDayFromTs(long ts)
		{
			return default(DateTime);
		}

		// Token: 0x06017525 RID: 95525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017525")]
		[Address(RVA = "0xFB0910", Offset = "0xFAF510", VA = "0x180FB0910")]
		public UIProgressCalender()
		{
		}

		// Token: 0x0401C250 RID: 115280
		[Token(Token = "0x401C250")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HorizontalLayoutGroup _layout;

		// Token: 0x0401C251 RID: 115281
		[Token(Token = "0x401C251")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIProgressCalender.NodeView _nodePrefab;

		// Token: 0x0401C252 RID: 115282
		[Token(Token = "0x401C252")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Optional. Null if use _nodePrefab instead.")]
		private UIProgressCalender.NodeView _startNodePrefab;

		// Token: 0x0401C253 RID: 115283
		[Token(Token = "0x401C253")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("Optional. Null if use _nodePrefab instead.")]
		private UIProgressCalender.NodeView _endNodePrefab;

		// Token: 0x0401C254 RID: 115284
		[Token(Token = "0x401C254")]
		[FieldOffset(Offset = "0x38")]
		private List<UIProgressCalender.NodeModel> m_tempCacheList;

		// Token: 0x0401C255 RID: 115285
		[Token(Token = "0x401C255")]
		[FieldOffset(Offset = "0x40")]
		private List<UIProgressCalender.NodeView> m_views;

		// Token: 0x0401C256 RID: 115286
		[Token(Token = "0x401C256")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401C257 RID: 115287
		[Token(Token = "0x401C257")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CalcViewModel;

		// Token: 0x0401C258 RID: 115288
		[Token(Token = "0x401C258")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ResetViewsIfNecessary;

		// Token: 0x0401C259 RID: 115289
		[Token(Token = "0x401C259")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateViewLayouts;

		// Token: 0x0401C25A RID: 115290
		[Token(Token = "0x401C25A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ReadIndexDayFromTs;

		// Token: 0x0401C25B RID: 115291
		[Token(Token = "0x401C25B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020039A1 RID: 14753
		[Token(Token = "0x20039A1")]
		public abstract class NodeView : MonoBehaviour, ILayoutElement
		{
			// Token: 0x170037DA RID: 14298
			// (get) Token: 0x06017526 RID: 95526 RVA: 0x00095F10 File Offset: 0x00094110
			[Token(Token = "0x170037DA")]
			public float minWidth
			{
				[Token(Token = "0x6017526")]
				[Address(RVA = "0xFACF50", Offset = "0xFABB50", VA = "0x180FACF50", Slot = "6")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170037DB RID: 14299
			// (get) Token: 0x06017527 RID: 95527 RVA: 0x00095F28 File Offset: 0x00094128
			[Token(Token = "0x170037DB")]
			public float preferredWidth
			{
				[Token(Token = "0x6017527")]
				[Address(RVA = "0xFACF90", Offset = "0xFABB90", VA = "0x180FACF90", Slot = "7")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170037DC RID: 14300
			// (get) Token: 0x06017528 RID: 95528 RVA: 0x00095F40 File Offset: 0x00094140
			[Token(Token = "0x170037DC")]
			public float flexibleWidth
			{
				[Token(Token = "0x6017528")]
				[Address(RVA = "0x738E20", Offset = "0x737A20", VA = "0x180738E20", Slot = "8")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170037DD RID: 14301
			// (get) Token: 0x06017529 RID: 95529 RVA: 0x00095F58 File Offset: 0x00094158
			[Token(Token = "0x170037DD")]
			public float minHeight
			{
				[Token(Token = "0x6017529")]
				[Address(RVA = "0x738E20", Offset = "0x737A20", VA = "0x180738E20", Slot = "9")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170037DE RID: 14302
			// (get) Token: 0x0601752A RID: 95530 RVA: 0x00095F70 File Offset: 0x00094170
			[Token(Token = "0x170037DE")]
			public float preferredHeight
			{
				[Token(Token = "0x601752A")]
				[Address(RVA = "0x738E20", Offset = "0x737A20", VA = "0x180738E20", Slot = "10")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170037DF RID: 14303
			// (get) Token: 0x0601752B RID: 95531 RVA: 0x00095F88 File Offset: 0x00094188
			[Token(Token = "0x170037DF")]
			public float flexibleHeight
			{
				[Token(Token = "0x601752B")]
				[Address(RVA = "0x738E20", Offset = "0x737A20", VA = "0x180738E20", Slot = "11")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170037E0 RID: 14304
			// (get) Token: 0x0601752C RID: 95532 RVA: 0x00095FA0 File Offset: 0x000941A0
			[Token(Token = "0x170037E0")]
			public int layoutPriority
			{
				[Token(Token = "0x601752C")]
				[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "12")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601752D RID: 95533 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601752D")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
			public void CalculateLayoutInputHorizontal()
			{
			}

			// Token: 0x0601752E RID: 95534 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601752E")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			public void CalculateLayoutInputVertical()
			{
			}

			// Token: 0x0601752F RID: 95535
			[Token(Token = "0x601752F")]
			public abstract float GetPreferWidth();

			// Token: 0x06017530 RID: 95536
			[Token(Token = "0x6017530")]
			public abstract float GetPureNodeWidth();

			// Token: 0x06017531 RID: 95537
			[Token(Token = "0x6017531")]
			public abstract void Render(UIProgressCalender.NodeView.ViewModel model);

			// Token: 0x06017532 RID: 95538 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017532")]
			[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
			protected NodeView()
			{
			}

			// Token: 0x020039A2 RID: 14754
			[Token(Token = "0x20039A2")]
			public struct ViewModel : IHotfixable
			{
				// Token: 0x0401C25C RID: 115292
				[Token(Token = "0x401C25C")]
				[FieldOffset(Offset = "0x0")]
				public bool isNodeActive;

				// Token: 0x0401C25D RID: 115293
				[Token(Token = "0x401C25D")]
				[FieldOffset(Offset = "0x1")]
				public bool isLastNode;

				// Token: 0x0401C25E RID: 115294
				[Token(Token = "0x401C25E")]
				[FieldOffset(Offset = "0x4")]
				public float progress;

				// Token: 0x0401C25F RID: 115295
				[Token(Token = "0x401C25F")]
				[FieldOffset(Offset = "0x8")]
				public float lineWidth;

				// Token: 0x0401C260 RID: 115296
				[Token(Token = "0x401C260")]
				[FieldOffset(Offset = "0xC")]
				public bool isNodeDayReached;
			}
		}

		// Token: 0x020039A3 RID: 14755
		[Token(Token = "0x20039A3")]
		public struct Node
		{
			// Token: 0x0401C261 RID: 115297
			[Token(Token = "0x401C261")]
			[FieldOffset(Offset = "0x0")]
			public long ts;
		}

		// Token: 0x020039A4 RID: 14756
		[Token(Token = "0x20039A4")]
		public struct Param
		{
			// Token: 0x0401C262 RID: 115298
			[Token(Token = "0x401C262")]
			[FieldOffset(Offset = "0x0")]
			public List<UIProgressCalender.Node> nodes;

			// Token: 0x0401C263 RID: 115299
			[Token(Token = "0x401C263")]
			[FieldOffset(Offset = "0x8")]
			public long curTs;
		}

		// Token: 0x020039A5 RID: 14757
		[Token(Token = "0x20039A5")]
		private struct LineModel : IHotfixable
		{
			// Token: 0x06017533 RID: 95539 RVA: 0x00095FB8 File Offset: 0x000941B8
			[Token(Token = "0x6017533")]
			[Address(RVA = "0xF9C7A0", Offset = "0xF9B3A0", VA = "0x180F9C7A0")]
			public float GetProgressOfDay(int curDay)
			{
				return 0f;
			}

			// Token: 0x06017534 RID: 95540 RVA: 0x00095FD0 File Offset: 0x000941D0
			[Token(Token = "0x6017534")]
			[Address(RVA = "0xF9C910", Offset = "0xF9B510", VA = "0x180F9C910")]
			public int GetUnitCount()
			{
				return 0;
			}

			// Token: 0x06017535 RID: 95541 RVA: 0x00095FE8 File Offset: 0x000941E8
			[Token(Token = "0x6017535")]
			[Address(RVA = "0xF9CA20", Offset = "0xF9B620", VA = "0x180F9CA20")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0401C264 RID: 115300
			[Token(Token = "0x401C264")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIProgressCalender.LineModel EMPTY;

			// Token: 0x0401C265 RID: 115301
			[Token(Token = "0x401C265")]
			[FieldOffset(Offset = "0x0")]
			public int startDay;

			// Token: 0x0401C266 RID: 115302
			[Token(Token = "0x401C266")]
			[FieldOffset(Offset = "0x4")]
			public int endDay;

			// Token: 0x0401C267 RID: 115303
			[Token(Token = "0x401C267")]
			[FieldOffset(Offset = "0x8")]
			public long startTs;

			// Token: 0x0401C268 RID: 115304
			[Token(Token = "0x401C268")]
			[FieldOffset(Offset = "0x10")]
			public long endTs;

			// Token: 0x0401C269 RID: 115305
			[Token(Token = "0x401C269")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetProgressOfDay;

			// Token: 0x0401C26A RID: 115306
			[Token(Token = "0x401C26A")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetUnitCount;

			// Token: 0x0401C26B RID: 115307
			[Token(Token = "0x401C26B")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_IsEmpty;
		}

		// Token: 0x020039A6 RID: 14758
		[Token(Token = "0x20039A6")]
		private struct NodeModel : IHotfixable
		{
			// Token: 0x0401C26C RID: 115308
			[Token(Token = "0x401C26C")]
			[FieldOffset(Offset = "0x0")]
			public int day;

			// Token: 0x0401C26D RID: 115309
			[Token(Token = "0x401C26D")]
			[FieldOffset(Offset = "0x8")]
			public long nodeTs;

			// Token: 0x0401C26E RID: 115310
			[Token(Token = "0x401C26E")]
			[FieldOffset(Offset = "0x10")]
			public UIProgressCalender.LineModel line;
		}

		// Token: 0x020039A7 RID: 14759
		[Token(Token = "0x20039A7")]
		private struct ViewModel
		{
			// Token: 0x0401C26F RID: 115311
			[Token(Token = "0x401C26F")]
			[FieldOffset(Offset = "0x0")]
			public List<UIProgressCalender.NodeModel> nodeModels;

			// Token: 0x0401C270 RID: 115312
			[Token(Token = "0x401C270")]
			[FieldOffset(Offset = "0x8")]
			public float lineUnit;

			// Token: 0x0401C271 RID: 115313
			[Token(Token = "0x401C271")]
			[FieldOffset(Offset = "0xC")]
			public int curDay;

			// Token: 0x0401C272 RID: 115314
			[Token(Token = "0x401C272")]
			[FieldOffset(Offset = "0x10")]
			public long curTs;
		}
	}
}
