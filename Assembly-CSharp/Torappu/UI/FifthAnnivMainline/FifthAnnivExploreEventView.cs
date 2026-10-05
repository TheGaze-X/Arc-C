using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EAC RID: 20140
	[Token(Token = "0x2004EAC")]
	public class FifthAnnivExploreEventView : FifthAnnivExploreDetailViewBase
	{
		// Token: 0x17004685 RID: 18053
		// (get) Token: 0x0601E0CD RID: 123085 RVA: 0x000AD460 File Offset: 0x000AB660
		[Token(Token = "0x17004685")]
		protected override FifthAnnivExploreDecisionModel.DecisionStatus status
		{
			[Token(Token = "0x601E0CD")]
			[Address(RVA = "0x17BBB90", Offset = "0x17BA790", VA = "0x1817BBB90", Slot = "8")]
			get
			{
				return FifthAnnivExploreDecisionModel.DecisionStatus.NONE;
			}
		}

		// Token: 0x0601E0CE RID: 123086 RVA: 0x000AD478 File Offset: 0x000AB678
		[Token(Token = "0x601E0CE")]
		[Address(RVA = "0x17BB750", Offset = "0x17BA350", VA = "0x1817BB750", Slot = "10")]
		protected override UIAnimationLocation GetEnterAnim()
		{
			return default(UIAnimationLocation);
		}

		// Token: 0x0601E0CF RID: 123087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0CF")]
		[Address(RVA = "0x17BB7D0", Offset = "0x17BA3D0", VA = "0x1817BB7D0", Slot = "9")]
		protected override void OnDataUpdate()
		{
		}

		// Token: 0x0601E0D0 RID: 123088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0D0")]
		[Address(RVA = "0x17BB9C0", Offset = "0x17BA5C0", VA = "0x1817BB9C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E0D1 RID: 123089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0D1")]
		[Address(RVA = "0x17BBAE0", Offset = "0x17BA6E0", VA = "0x1817BBAE0")]
		public FifthAnnivExploreEventView()
		{
		}

		// Token: 0x0601E0D2 RID: 123090 RVA: 0x000AD490 File Offset: 0x000AB690
		[Token(Token = "0x601E0D2")]
		[Address(RVA = "0x17BA7D0", Offset = "0x17B93D0", VA = "0x1817BA7D0")]
		private UIAnimationLocation <>xLuaBaseProxy_GetEnterAnim()
		{
			return default(UIAnimationLocation);
		}

		// Token: 0x04027F6D RID: 163693
		[Token(Token = "0x4027F6D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _planList;

		// Token: 0x04027F6E RID: 163694
		[Token(Token = "0x4027F6E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04027F6F RID: 163695
		[Token(Token = "0x4027F6F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x04027F70 RID: 163696
		[Token(Token = "0x4027F70")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x04027F71 RID: 163697
		[Token(Token = "0x4027F71")]
		[FieldOffset(Offset = "0x60")]
		private FifthAnnivExploreEventView.PlanListAdapter m_planListAdapter;

		// Token: 0x04027F72 RID: 163698
		[Token(Token = "0x4027F72")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_status;

		// Token: 0x04027F73 RID: 163699
		[Token(Token = "0x4027F73")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetEnterAnim;

		// Token: 0x04027F74 RID: 163700
		[Token(Token = "0x4027F74")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDataUpdate;

		// Token: 0x04027F75 RID: 163701
		[Token(Token = "0x4027F75")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027F76 RID: 163702
		[Token(Token = "0x4027F76")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004EAD RID: 20141
		[Token(Token = "0x2004EAD")]
		private class PlanListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601E0D3 RID: 123091 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E0D3")]
			[Address(RVA = "0x17C7ED0", Offset = "0x17C6AD0", VA = "0x1817C7ED0")]
			public PlanListAdapter(FifthAnnivExploreEventView closure)
			{
			}

			// Token: 0x17004686 RID: 18054
			// (get) Token: 0x0601E0D4 RID: 123092 RVA: 0x000AD4A8 File Offset: 0x000AB6A8
			[Token(Token = "0x17004686")]
			public override int count
			{
				[Token(Token = "0x601E0D4")]
				[Address(RVA = "0x17C7F50", Offset = "0x17C6B50", VA = "0x1817C7F50", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601E0D5 RID: 123093 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E0D5")]
			[Address(RVA = "0x17C7CD0", Offset = "0x17C68D0", VA = "0x1817C7CD0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04027F77 RID: 163703
			[Token(Token = "0x4027F77")]
			[FieldOffset(Offset = "0x20")]
			private FifthAnnivExploreEventView m_closure;

			// Token: 0x04027F78 RID: 163704
			[Token(Token = "0x4027F78")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04027F79 RID: 163705
			[Token(Token = "0x4027F79")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04027F7A RID: 163706
			[Token(Token = "0x4027F7A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
