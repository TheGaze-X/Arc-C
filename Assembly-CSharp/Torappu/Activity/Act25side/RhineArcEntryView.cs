using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074E9 RID: 29929
	[Token(Token = "0x20074E9")]
	public class RhineArcEntryView : DataBinder<RhineArcProperty>
	{
		// Token: 0x0602A2FC RID: 172796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2FC")]
		[Address(RVA = "0x25D7FD0", Offset = "0x25D6BD0", VA = "0x1825D7FD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A2FD RID: 172797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2FD")]
		[Address(RVA = "0x25D7D50", Offset = "0x25D6950", VA = "0x1825D7D50", Slot = "7")]
		public override void OnValueChanged(RhineArcProperty property)
		{
		}

		// Token: 0x0602A2FE RID: 172798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2FE")]
		[Address(RVA = "0x25D81C0", Offset = "0x25D6DC0", VA = "0x1825D81C0")]
		public RhineArcEntryView()
		{
		}

		// Token: 0x0403C9D7 RID: 248279
		[Token(Token = "0x403C9D7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _leftContent;

		// Token: 0x0403C9D8 RID: 248280
		[Token(Token = "0x403C9D8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _rightContent;

		// Token: 0x0403C9D9 RID: 248281
		[Token(Token = "0x403C9D9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _scrollContent;

		// Token: 0x0403C9DA RID: 248282
		[Token(Token = "0x403C9DA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _viewPort;

		// Token: 0x0403C9DB RID: 248283
		[Token(Token = "0x403C9DB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _focusSizeRatio;

		// Token: 0x0403C9DC RID: 248284
		[Token(Token = "0x403C9DC")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _focusTime;

		// Token: 0x0403C9DD RID: 248285
		[Token(Token = "0x403C9DD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _picAllLockPanel;

		// Token: 0x0403C9DE RID: 248286
		[Token(Token = "0x403C9DE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _storyAllLockPanel;

		// Token: 0x0403C9DF RID: 248287
		[Token(Token = "0x403C9DF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _battlePerformanceAllLockPanel;

		// Token: 0x0403C9E0 RID: 248288
		[Token(Token = "0x403C9E0")]
		[FieldOffset(Offset = "0x60")]
		private UILayoutDimensionListener m_dimensionListener;

		// Token: 0x0403C9E1 RID: 248289
		[Token(Token = "0x403C9E1")]
		[FieldOffset(Offset = "0x68")]
		private RhineArcEntryView.LeftAdapter m_leftAdapter;

		// Token: 0x0403C9E2 RID: 248290
		[Token(Token = "0x403C9E2")]
		[FieldOffset(Offset = "0x70")]
		private RhineArcEntryView.RightAdapter m_rightAdatper;

		// Token: 0x0403C9E3 RID: 248291
		[Token(Token = "0x403C9E3")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0403C9E4 RID: 248292
		[Token(Token = "0x403C9E4")]
		[FieldOffset(Offset = "0x79")]
		private bool m_needFocus;

		// Token: 0x0403C9E5 RID: 248293
		[Token(Token = "0x403C9E5")]
		[FieldOffset(Offset = "0x7C")]
		private float m_focusOnX;

		// Token: 0x0403C9E6 RID: 248294
		[Token(Token = "0x403C9E6")]
		[FieldOffset(Offset = "0x80")]
		private int m_maxUnAvailGroupSize;

		// Token: 0x0403C9E7 RID: 248295
		[Token(Token = "0x403C9E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403C9E8 RID: 248296
		[Token(Token = "0x403C9E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403C9E9 RID: 248297
		[Token(Token = "0x403C9E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020074EA RID: 29930
		[Token(Token = "0x20074EA")]
		private class LeftAdapter : SimpleLayoutAdapter
		{
			// Token: 0x1700635B RID: 25435
			// (get) Token: 0x0602A2FF RID: 172799 RVA: 0x000D7A78 File Offset: 0x000D5C78
			[Token(Token = "0x1700635B")]
			public override int count
			{
				[Token(Token = "0x602A2FF")]
				[Address(RVA = "0x25D4B20", Offset = "0x25D3720", VA = "0x1825D4B20", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A300 RID: 172800 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A300")]
			[Address(RVA = "0x25D4900", Offset = "0x25D3500", VA = "0x1825D4900", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602A301 RID: 172801 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A301")]
			[Address(RVA = "0x25D4AC0", Offset = "0x25D36C0", VA = "0x1825D4AC0")]
			public LeftAdapter()
			{
			}

			// Token: 0x0403C9EA RID: 248298
			[Token(Token = "0x403C9EA")]
			[FieldOffset(Offset = "0x20")]
			public ListDict<string, RhineArcViewModel.Group> groups;

			// Token: 0x0403C9EB RID: 248299
			[Token(Token = "0x403C9EB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403C9EC RID: 248300
			[Token(Token = "0x403C9EC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403C9ED RID: 248301
			[Token(Token = "0x403C9ED")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020074EB RID: 29931
		[Token(Token = "0x20074EB")]
		private class RightAdapter : SimpleLayoutAdapter
		{
			// Token: 0x1700635C RID: 25436
			// (get) Token: 0x0602A302 RID: 172802 RVA: 0x000D7A90 File Offset: 0x000D5C90
			[Token(Token = "0x1700635C")]
			public override int count
			{
				[Token(Token = "0x602A302")]
				[Address(RVA = "0x25D9050", Offset = "0x25D7C50", VA = "0x1825D9050", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A303 RID: 172803 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A303")]
			[Address(RVA = "0x25D8E30", Offset = "0x25D7A30", VA = "0x1825D8E30", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602A304 RID: 172804 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A304")]
			[Address(RVA = "0x25D8FF0", Offset = "0x25D7BF0", VA = "0x1825D8FF0")]
			public RightAdapter()
			{
			}

			// Token: 0x0403C9EE RID: 248302
			[Token(Token = "0x403C9EE")]
			[FieldOffset(Offset = "0x20")]
			public ListDict<string, RhineArcViewModel.Group> groups;

			// Token: 0x0403C9EF RID: 248303
			[Token(Token = "0x403C9EF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403C9F0 RID: 248304
			[Token(Token = "0x403C9F0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403C9F1 RID: 248305
			[Token(Token = "0x403C9F1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020074EC RID: 29932
		[Token(Token = "0x20074EC")]
		private class OnPostLayoutScrollHorizontalAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x0602A305 RID: 172805 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A305")]
			[Address(RVA = "0x25D4B90", Offset = "0x25D3790", VA = "0x1825D4B90", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x0602A306 RID: 172806 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A306")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public OnPostLayoutScrollHorizontalAction()
			{
			}

			// Token: 0x0403C9F2 RID: 248306
			[Token(Token = "0x403C9F2")]
			[FieldOffset(Offset = "0x10")]
			public RhineArcEntryView m_closure;
		}
	}
}
