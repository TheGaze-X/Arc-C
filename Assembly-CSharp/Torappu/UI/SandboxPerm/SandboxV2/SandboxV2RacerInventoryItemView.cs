using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004351 RID: 17233
	[Token(Token = "0x2004351")]
	public class SandboxV2RacerInventoryItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A750 RID: 108368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A750")]
		[Address(RVA = "0x138F010", Offset = "0x138DC10", VA = "0x18138F010")]
		public void Render(SandboxV2RacerModel model, bool isSelected)
		{
		}

		// Token: 0x0601A751 RID: 108369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A751")]
		[Address(RVA = "0x138F410", Offset = "0x138E010", VA = "0x18138F410")]
		public void ResetSelectStatus()
		{
		}

		// Token: 0x0601A752 RID: 108370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A752")]
		[Address(RVA = "0x138EF30", Offset = "0x138DB30", VA = "0x18138EF30")]
		public void EventOnClick()
		{
		}

		// Token: 0x0601A753 RID: 108371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A753")]
		[Address(RVA = "0x138F490", Offset = "0x138E090", VA = "0x18138F490")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A754 RID: 108372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A754")]
		[Address(RVA = "0x138F680", Offset = "0x138E280", VA = "0x18138F680")]
		public SandboxV2RacerInventoryItemView()
		{
		}

		// Token: 0x04021A60 RID: 137824
		[Token(Token = "0x4021A60")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x04021A61 RID: 137825
		[Token(Token = "0x4021A61")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelTemp;

		// Token: 0x04021A62 RID: 137826
		[Token(Token = "0x4021A62")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelMarked;

		// Token: 0x04021A63 RID: 137827
		[Token(Token = "0x4021A63")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelNotMarked;

		// Token: 0x04021A64 RID: 137828
		[Token(Token = "0x4021A64")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x04021A65 RID: 137829
		[Token(Token = "0x4021A65")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _iconRacer;

		// Token: 0x04021A66 RID: 137830
		[Token(Token = "0x4021A66")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text[] _textName;

		// Token: 0x04021A67 RID: 137831
		[Token(Token = "0x4021A67")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x04021A68 RID: 137832
		[Token(Token = "0x4021A68")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SimpleLayoutContent _racerLevelContent;

		// Token: 0x04021A69 RID: 137833
		[Token(Token = "0x4021A69")]
		[FieldOffset(Offset = "0x68")]
		private int m_racerLevel;

		// Token: 0x04021A6A RID: 137834
		[Token(Token = "0x4021A6A")]
		[FieldOffset(Offset = "0x70")]
		private SandboxV2RacerInventoryItemView.Adapter m_adapter;

		// Token: 0x04021A6B RID: 137835
		[Token(Token = "0x4021A6B")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x04021A6C RID: 137836
		[Token(Token = "0x4021A6C")]
		[FieldOffset(Offset = "0x80")]
		private UISwitchTween m_selectTween;

		// Token: 0x04021A6D RID: 137837
		[Token(Token = "0x4021A6D")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04021A6E RID: 137838
		[Token(Token = "0x4021A6E")]
		[FieldOffset(Offset = "0x98")]
		private string m_cachedInstId;

		// Token: 0x04021A6F RID: 137839
		[Token(Token = "0x4021A6F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021A70 RID: 137840
		[Token(Token = "0x4021A70")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ResetSelectStatus;

		// Token: 0x04021A71 RID: 137841
		[Token(Token = "0x4021A71")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x04021A72 RID: 137842
		[Token(Token = "0x4021A72")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021A73 RID: 137843
		[Token(Token = "0x4021A73")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004352 RID: 17234
		[Token(Token = "0x2004352")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601A755 RID: 108373 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A755")]
			[Address(RVA = "0x1383820", Offset = "0x1382420", VA = "0x181383820")]
			public Adapter(SandboxV2RacerInventoryItemView closure)
			{
			}

			// Token: 0x17003ECF RID: 16079
			// (get) Token: 0x0601A756 RID: 108374 RVA: 0x000A1E50 File Offset: 0x000A0050
			[Token(Token = "0x17003ECF")]
			public override int count
			{
				[Token(Token = "0x601A756")]
				[Address(RVA = "0x13839A0", Offset = "0x13825A0", VA = "0x1813839A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A757 RID: 108375 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A757")]
			[Address(RVA = "0x13833F0", Offset = "0x1381FF0", VA = "0x1813833F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04021A74 RID: 137844
			[Token(Token = "0x4021A74")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2RacerInventoryItemView m_closure;

			// Token: 0x04021A75 RID: 137845
			[Token(Token = "0x4021A75")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04021A76 RID: 137846
			[Token(Token = "0x4021A76")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04021A77 RID: 137847
			[Token(Token = "0x4021A77")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
