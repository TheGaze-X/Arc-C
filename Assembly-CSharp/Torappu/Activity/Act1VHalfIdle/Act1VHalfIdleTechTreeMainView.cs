using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007802 RID: 30722
	[Token(Token = "0x2007802")]
	public class Act1VHalfIdleTechTreeMainView : DataBinder<Act1VHalfIdleTechTreeMainViewModelProperty>
	{
		// Token: 0x170064D3 RID: 25811
		// (get) Token: 0x0602B195 RID: 176533 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B196 RID: 176534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170064D3")]
		public Action<string> onUnlock
		{
			[Token(Token = "0x602B195")]
			[Address(RVA = "0x26E7F60", Offset = "0x26E6B60", VA = "0x1826E7F60")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B196")]
			[Address(RVA = "0x26E8040", Offset = "0x26E6C40", VA = "0x1826E8040")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170064D4 RID: 25812
		// (get) Token: 0x0602B197 RID: 176535 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B198 RID: 176536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170064D4")]
		public Action<string> onNodeClick
		{
			[Token(Token = "0x602B197")]
			[Address(RVA = "0x26E7F00", Offset = "0x26E6B00", VA = "0x1826E7F00")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B198")]
			[Address(RVA = "0x26E7FC0", Offset = "0x26E6BC0", VA = "0x1826E7FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602B199 RID: 176537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B199")]
		[Address(RVA = "0x26E77B0", Offset = "0x26E63B0", VA = "0x1826E77B0", Slot = "7")]
		public override void OnValueChanged(Act1VHalfIdleTechTreeMainViewModelProperty property)
		{
		}

		// Token: 0x0602B19A RID: 176538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B19A")]
		[Address(RVA = "0x26E7C90", Offset = "0x26E6890", VA = "0x1826E7C90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B19B RID: 176539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B19B")]
		[Address(RVA = "0x26E7700", Offset = "0x26E6300", VA = "0x1826E7700")]
		public void EventOnClickBottom()
		{
		}

		// Token: 0x0602B19C RID: 176540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B19C")]
		[Address(RVA = "0x26E7B00", Offset = "0x26E6700", VA = "0x1826E7B00")]
		private void _FocusOnPos(float pos)
		{
		}

		// Token: 0x0602B19D RID: 176541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B19D")]
		[Address(RVA = "0x26E7E80", Offset = "0x26E6A80", VA = "0x1826E7E80")]
		public Act1VHalfIdleTechTreeMainView()
		{
		}

		// Token: 0x0403E473 RID: 255091
		[Token(Token = "0x403E473")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _itemCnt;

		// Token: 0x0403E474 RID: 255092
		[Token(Token = "0x403E474")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _diagramList;

		// Token: 0x0403E475 RID: 255093
		[Token(Token = "0x403E475")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Act1VHalfIdleTechTreeNodeDetailView _detalView;

		// Token: 0x0403E476 RID: 255094
		[Token(Token = "0x403E476")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _nodeCnt;

		// Token: 0x0403E477 RID: 255095
		[Token(Token = "0x403E477")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _unlockNodeCnt;

		// Token: 0x0403E478 RID: 255096
		[Token(Token = "0x403E478")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x0403E479 RID: 255097
		[Token(Token = "0x403E479")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Focus")]
		private ScrollRect _scrollView;

		// Token: 0x0403E47A RID: 255098
		[Token(Token = "0x403E47A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Focus")]
		private RectTransform _scrollViewRect;

		// Token: 0x0403E47B RID: 255099
		[Token(Token = "0x403E47B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Focus")]
		private float _focusDuration;

		// Token: 0x0403E47C RID: 255100
		[Token(Token = "0x403E47C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Focus")]
		private UILayoutDimensionListener _listener;

		// Token: 0x0403E47D RID: 255101
		[Token(Token = "0x403E47D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Focus")]
		private float _paddingLeft;

		// Token: 0x0403E47E RID: 255102
		[Token(Token = "0x403E47E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Focus")]
		private RectTransform _content;

		// Token: 0x0403E47F RID: 255103
		[Token(Token = "0x403E47F")]
		[FieldOffset(Offset = "0x88")]
		private int m_cachedInitSeqNum;

		// Token: 0x0403E480 RID: 255104
		[Token(Token = "0x403E480")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_focusTween;

		// Token: 0x0403E481 RID: 255105
		[Token(Token = "0x403E481")]
		[FieldOffset(Offset = "0x98")]
		private Act1VHalfIdleTechTreeMainView.DiagramListAdapter m_diagramAdapter;

		// Token: 0x0403E484 RID: 255108
		[Token(Token = "0x403E484")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onUnlock;

		// Token: 0x0403E485 RID: 255109
		[Token(Token = "0x403E485")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onUnlock;

		// Token: 0x0403E486 RID: 255110
		[Token(Token = "0x403E486")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onNodeClick;

		// Token: 0x0403E487 RID: 255111
		[Token(Token = "0x403E487")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onNodeClick;

		// Token: 0x0403E488 RID: 255112
		[Token(Token = "0x403E488")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403E489 RID: 255113
		[Token(Token = "0x403E489")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E48A RID: 255114
		[Token(Token = "0x403E48A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnClickBottom;

		// Token: 0x0403E48B RID: 255115
		[Token(Token = "0x403E48B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FocusOnPos;

		// Token: 0x0403E48C RID: 255116
		[Token(Token = "0x403E48C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007803 RID: 30723
		[Token(Token = "0x2007803")]
		private class PostLayoutAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x0602B19E RID: 176542 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B19E")]
			[Address(RVA = "0x2704DA0", Offset = "0x27039A0", VA = "0x182704DA0")]
			public PostLayoutAction(Act1VHalfIdleTechTreeMainView closure, float focusPos)
			{
			}

			// Token: 0x0602B19F RID: 176543 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B19F")]
			[Address(RVA = "0x2704D20", Offset = "0x2703920", VA = "0x182704D20", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x0403E48D RID: 255117
			[Token(Token = "0x403E48D")]
			[FieldOffset(Offset = "0x10")]
			private Act1VHalfIdleTechTreeMainView m_closure;

			// Token: 0x0403E48E RID: 255118
			[Token(Token = "0x403E48E")]
			[FieldOffset(Offset = "0x18")]
			private float m_focusPos;
		}

		// Token: 0x02007804 RID: 30724
		[Token(Token = "0x2007804")]
		private class DiagramListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170064D5 RID: 25813
			// (get) Token: 0x0602B1A1 RID: 176545 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602B1A0 RID: 176544 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170064D5")]
			public Action<string> onNodeClick
			{
				[Token(Token = "0x602B1A1")]
				[Address(RVA = "0x2704490", Offset = "0x2703090", VA = "0x182704490")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x602B1A0")]
				[Address(RVA = "0x27044F0", Offset = "0x27030F0", VA = "0x1827044F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170064D6 RID: 25814
			// (get) Token: 0x0602B1A2 RID: 176546 RVA: 0x000DAD78 File Offset: 0x000D8F78
			[Token(Token = "0x170064D6")]
			public override int count
			{
				[Token(Token = "0x602B1A2")]
				[Address(RVA = "0x2704420", Offset = "0x2703020", VA = "0x182704420", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602B1A3 RID: 176547 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B1A3")]
			[Address(RVA = "0x27041C0", Offset = "0x2702DC0", VA = "0x1827041C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602B1A4 RID: 176548 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B1A4")]
			[Address(RVA = "0x27043C0", Offset = "0x2702FC0", VA = "0x1827043C0")]
			public DiagramListAdapter()
			{
			}

			// Token: 0x0403E490 RID: 255120
			[Token(Token = "0x403E490")]
			[FieldOffset(Offset = "0x28")]
			public List<Act1VHalfIdleTechTreeDiagramData> diagrams;

			// Token: 0x0403E491 RID: 255121
			[Token(Token = "0x403E491")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_set_onNodeClick;

			// Token: 0x0403E492 RID: 255122
			[Token(Token = "0x403E492")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_onNodeClick;

			// Token: 0x0403E493 RID: 255123
			[Token(Token = "0x403E493")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403E494 RID: 255124
			[Token(Token = "0x403E494")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403E495 RID: 255125
			[Token(Token = "0x403E495")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
