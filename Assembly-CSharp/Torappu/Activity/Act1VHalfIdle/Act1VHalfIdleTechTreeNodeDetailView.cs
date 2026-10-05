using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200780A RID: 30730
	[Token(Token = "0x200780A")]
	internal class Act1VHalfIdleTechTreeNodeDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170064E1 RID: 25825
		// (get) Token: 0x0602B1CC RID: 176588 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B1CB RID: 176587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170064E1")]
		public Action<string> onUnlock
		{
			[Token(Token = "0x602B1CC")]
			[Address(RVA = "0x26FD690", Offset = "0x26FC290", VA = "0x1826FD690")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B1CB")]
			[Address(RVA = "0x26FD6F0", Offset = "0x26FC2F0", VA = "0x1826FD6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602B1CD RID: 176589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1CD")]
		[Address(RVA = "0x26FCDF0", Offset = "0x26FB9F0", VA = "0x1826FCDF0")]
		public void RenderView(Act1VHalfIdleTechTreeNodeViewModel nodeModel)
		{
		}

		// Token: 0x170064E2 RID: 25826
		// (get) Token: 0x0602B1CE RID: 176590 RVA: 0x000DAE68 File Offset: 0x000D9068
		[Token(Token = "0x170064E2")]
		private bool hasInited
		{
			[Token(Token = "0x602B1CE")]
			[Address(RVA = "0x26FD630", Offset = "0x26FC230", VA = "0x1826FD630")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602B1CF RID: 176591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1CF")]
		[Address(RVA = "0x26FD1E0", Offset = "0x26FBDE0", VA = "0x1826FD1E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B1D0 RID: 176592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1D0")]
		[Address(RVA = "0x26FD330", Offset = "0x26FBF30", VA = "0x1826FD330")]
		private void _SetVisible(bool v, bool immediately)
		{
		}

		// Token: 0x0602B1D1 RID: 176593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1D1")]
		[Address(RVA = "0x26FCD30", Offset = "0x26FB930", VA = "0x1826FCD30")]
		public void EventUnlock()
		{
		}

		// Token: 0x0602B1D2 RID: 176594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1D2")]
		[Address(RVA = "0x26FD5D0", Offset = "0x26FC1D0", VA = "0x1826FD5D0")]
		public Act1VHalfIdleTechTreeNodeDetailView()
		{
		}

		// Token: 0x0403E4CC RID: 255180
		[Token(Token = "0x403E4CC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0403E4CD RID: 255181
		[Token(Token = "0x403E4CD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _name;

		// Token: 0x0403E4CE RID: 255182
		[Token(Token = "0x403E4CE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _effectList;

		// Token: 0x0403E4CF RID: 255183
		[Token(Token = "0x403E4CF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text[] _itemCostLables;

		// Token: 0x0403E4D0 RID: 255184
		[Token(Token = "0x403E4D0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _unlockToggle;

		// Token: 0x0403E4D1 RID: 255185
		[Token(Token = "0x403E4D1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TwoStateToggle _canUnlockToggle;

		// Token: 0x0403E4D2 RID: 255186
		[Token(Token = "0x403E4D2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _prevLockTips;

		// Token: 0x0403E4D3 RID: 255187
		[Token(Token = "0x403E4D3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _inAnim;

		// Token: 0x0403E4D4 RID: 255188
		[Token(Token = "0x403E4D4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _outAnim;

		// Token: 0x0403E4D5 RID: 255189
		[Token(Token = "0x403E4D5")]
		[FieldOffset(Offset = "0x70")]
		private string m_nodeId;

		// Token: 0x0403E4D6 RID: 255190
		[Token(Token = "0x403E4D6")]
		[FieldOffset(Offset = "0x78")]
		private Act1VHalfIdleTechTreeNodeDetailView.EffectListAdapter m_effectListAdapter;

		// Token: 0x0403E4D7 RID: 255191
		[Token(Token = "0x403E4D7")]
		[FieldOffset(Offset = "0x80")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403E4D8 RID: 255192
		[Token(Token = "0x403E4D8")]
		[FieldOffset(Offset = "0x90")]
		private bool m_visible;

		// Token: 0x0403E4DA RID: 255194
		[Token(Token = "0x403E4DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onUnlock;

		// Token: 0x0403E4DB RID: 255195
		[Token(Token = "0x403E4DB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onUnlock;

		// Token: 0x0403E4DC RID: 255196
		[Token(Token = "0x403E4DC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0403E4DD RID: 255197
		[Token(Token = "0x403E4DD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_hasInited;

		// Token: 0x0403E4DE RID: 255198
		[Token(Token = "0x403E4DE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E4DF RID: 255199
		[Token(Token = "0x403E4DF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetVisible;

		// Token: 0x0403E4E0 RID: 255200
		[Token(Token = "0x403E4E0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventUnlock;

		// Token: 0x0403E4E1 RID: 255201
		[Token(Token = "0x403E4E1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200780B RID: 30731
		[Token(Token = "0x200780B")]
		private class EffectListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170064E3 RID: 25827
			// (get) Token: 0x0602B1D4 RID: 176596 RVA: 0x000DAE80 File Offset: 0x000D9080
			[Token(Token = "0x170064E3")]
			public override int count
			{
				[Token(Token = "0x602B1D4")]
				[Address(RVA = "0x2704770", Offset = "0x2703370", VA = "0x182704770", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602B1D5 RID: 176597 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B1D5")]
			[Address(RVA = "0x2704570", Offset = "0x2703170", VA = "0x182704570", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602B1D6 RID: 176598 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B1D6")]
			[Address(RVA = "0x2704710", Offset = "0x2703310", VA = "0x182704710")]
			public EffectListAdapter()
			{
			}

			// Token: 0x0403E4E2 RID: 255202
			[Token(Token = "0x403E4E2")]
			[FieldOffset(Offset = "0x20")]
			public List<Act1VHalfIdleTechTreeData.Effect> effectList;

			// Token: 0x0403E4E3 RID: 255203
			[Token(Token = "0x403E4E3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403E4E4 RID: 255204
			[Token(Token = "0x403E4E4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403E4E5 RID: 255205
			[Token(Token = "0x403E4E5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
