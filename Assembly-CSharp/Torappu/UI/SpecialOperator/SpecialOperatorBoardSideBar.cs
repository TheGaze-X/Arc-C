using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003EA0 RID: 16032
	[Token(Token = "0x2003EA0")]
	public class SpecialOperatorBoardSideBar : DataBinder<SpecialOperatorBoardProp>, IHotfixable
	{
		// Token: 0x06018E42 RID: 101954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E42")]
		[Address(RVA = "0x1190380", Offset = "0x118EF80", VA = "0x181190380", Slot = "7")]
		public override void OnValueChanged(SpecialOperatorBoardProp property)
		{
		}

		// Token: 0x06018E43 RID: 101955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E43")]
		[Address(RVA = "0x1190D00", Offset = "0x118F900", VA = "0x181190D00")]
		private void _RenderTab(SpecialOperatorBoardTabType curTabType)
		{
		}

		// Token: 0x06018E44 RID: 101956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E44")]
		[Address(RVA = "0x1190A30", Offset = "0x118F630", VA = "0x181190A30")]
		private void _RenderLvlupSubTab(SpecialOperatorDetailNodeType curLvlupTabType)
		{
		}

		// Token: 0x06018E45 RID: 101957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E45")]
		[Address(RVA = "0x11908E0", Offset = "0x118F4E0", VA = "0x1811908E0")]
		private void _OnPostSetMarkPos()
		{
		}

		// Token: 0x06018E46 RID: 101958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E46")]
		[Address(RVA = "0x1190710", Offset = "0x118F310", VA = "0x181190710")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018E47 RID: 101959 RVA: 0x0009C558 File Offset: 0x0009A758
		[Token(Token = "0x6018E47")]
		[Address(RVA = "0x1190620", Offset = "0x118F220", VA = "0x181190620")]
		private SpecialOperatorBoardSideBar.LvlupTabConfig _FindConfig(SpecialOperatorDetailNodeType nodeType)
		{
			return default(SpecialOperatorBoardSideBar.LvlupTabConfig);
		}

		// Token: 0x06018E48 RID: 101960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E48")]
		[Address(RVA = "0x1191050", Offset = "0x118FC50", VA = "0x181191050")]
		public SpecialOperatorBoardSideBar()
		{
		}

		// Token: 0x0401EB13 RID: 125715
		[Token(Token = "0x401EB13")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SpecialOperatorBoardTabView[] _tabViews;

		// Token: 0x0401EB14 RID: 125716
		[Token(Token = "0x401EB14")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _selectedMark;

		// Token: 0x0401EB15 RID: 125717
		[Token(Token = "0x401EB15")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _tabTweenDuration;

		// Token: 0x0401EB16 RID: 125718
		[Token(Token = "0x401EB16")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _lvlupTabEnterAnim;

		// Token: 0x0401EB17 RID: 125719
		[Token(Token = "0x401EB17")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _lvlupSubTabExpandAnim;

		// Token: 0x0401EB18 RID: 125720
		[Token(Token = "0x401EB18")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SpecialOperatorBoardSideBar.LvlupTabConfig[] _lvlupTabConfigs;

		// Token: 0x0401EB19 RID: 125721
		[Token(Token = "0x401EB19")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SimpleLayoutContent _lvlupSubTabContent;

		// Token: 0x0401EB1A RID: 125722
		[Token(Token = "0x401EB1A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _lvlupSelectedMark;

		// Token: 0x0401EB1B RID: 125723
		[Token(Token = "0x401EB1B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _lvlupSelectedLight;

		// Token: 0x0401EB1C RID: 125724
		[Token(Token = "0x401EB1C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UILayoutDimensionListener _listener;

		// Token: 0x0401EB1D RID: 125725
		[Token(Token = "0x401EB1D")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x0401EB1E RID: 125726
		[Token(Token = "0x401EB1E")]
		[FieldOffset(Offset = "0x84")]
		private int m_cachedEnterSeqNum;

		// Token: 0x0401EB1F RID: 125727
		[Token(Token = "0x401EB1F")]
		[FieldOffset(Offset = "0x88")]
		private bool m_cachedIsFirstRender;

		// Token: 0x0401EB20 RID: 125728
		[Token(Token = "0x401EB20")]
		[FieldOffset(Offset = "0x90")]
		private SpecialOperatorBoardSideBar.LvlupSubTabAdapter m_subTabAdapter;

		// Token: 0x0401EB21 RID: 125729
		[Token(Token = "0x401EB21")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_enterTween;

		// Token: 0x0401EB22 RID: 125730
		[Token(Token = "0x401EB22")]
		[FieldOffset(Offset = "0xA0")]
		private AnimationSwitchTween m_lvlupTabExpandTween;

		// Token: 0x0401EB23 RID: 125731
		[Token(Token = "0x401EB23")]
		[FieldOffset(Offset = "0xA8")]
		private SpecialOperatorBoardMainModel m_cachedModel;

		// Token: 0x0401EB24 RID: 125732
		[Token(Token = "0x401EB24")]
		[FieldOffset(Offset = "0xB0")]
		private SpecialOperatorBoardTabType m_cachedTabType;

		// Token: 0x0401EB25 RID: 125733
		[Token(Token = "0x401EB25")]
		[FieldOffset(Offset = "0xB4")]
		private SpecialOperatorDetailNodeType m_cachedLvlupTabType;

		// Token: 0x0401EB26 RID: 125734
		[Token(Token = "0x401EB26")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401EB27 RID: 125735
		[Token(Token = "0x401EB27")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderTab;

		// Token: 0x0401EB28 RID: 125736
		[Token(Token = "0x401EB28")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderLvlupSubTab;

		// Token: 0x0401EB29 RID: 125737
		[Token(Token = "0x401EB29")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnPostSetMarkPos;

		// Token: 0x0401EB2A RID: 125738
		[Token(Token = "0x401EB2A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401EB2B RID: 125739
		[Token(Token = "0x401EB2B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FindConfig;

		// Token: 0x0401EB2C RID: 125740
		[Token(Token = "0x401EB2C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003EA1 RID: 16033
		[Token(Token = "0x2003EA1")]
		private class LvlupSubTabAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06018E49 RID: 101961 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018E49")]
			[Address(RVA = "0x11820F0", Offset = "0x1180CF0", VA = "0x1811820F0")]
			public LvlupSubTabAdapter(SpecialOperatorBoardSideBar closure)
			{
			}

			// Token: 0x17003B61 RID: 15201
			// (get) Token: 0x06018E4A RID: 101962 RVA: 0x0009C570 File Offset: 0x0009A770
			[Token(Token = "0x17003B61")]
			public override int count
			{
				[Token(Token = "0x6018E4A")]
				[Address(RVA = "0x1182170", Offset = "0x1180D70", VA = "0x181182170", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018E4B RID: 101963 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018E4B")]
			[Address(RVA = "0x1181E50", Offset = "0x1180A50", VA = "0x181181E50", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06018E4C RID: 101964 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018E4C")]
			[Address(RVA = "0x1181D00", Offset = "0x1180900", VA = "0x181181D00")]
			public SpecialOperatorBoardLvlupTabView GetSelectedView(SpecialOperatorDetailNodeType selectedNodeType)
			{
				return null;
			}

			// Token: 0x0401EB2D RID: 125741
			[Token(Token = "0x401EB2D")]
			[FieldOffset(Offset = "0x20")]
			private SpecialOperatorBoardSideBar m_closure;

			// Token: 0x0401EB2E RID: 125742
			[Token(Token = "0x401EB2E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401EB2F RID: 125743
			[Token(Token = "0x401EB2F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401EB30 RID: 125744
			[Token(Token = "0x401EB30")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401EB31 RID: 125745
			[Token(Token = "0x401EB31")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetSelectedView;
		}

		// Token: 0x02003EA2 RID: 16034
		[Token(Token = "0x2003EA2")]
		private class OnPostLayoutAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x06018E4D RID: 101965 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018E4D")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public OnPostLayoutAction(SpecialOperatorBoardSideBar closure)
			{
			}

			// Token: 0x06018E4E RID: 101966 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018E4E")]
			[Address(RVA = "0x1182210", Offset = "0x1180E10", VA = "0x181182210", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x0401EB32 RID: 125746
			[Token(Token = "0x401EB32")]
			[FieldOffset(Offset = "0x10")]
			private SpecialOperatorBoardSideBar m_closure;
		}

		// Token: 0x02003EA3 RID: 16035
		[Token(Token = "0x2003EA3")]
		[Serializable]
		public struct LvlupTabConfig
		{
			// Token: 0x0401EB33 RID: 125747
			[Token(Token = "0x401EB33")]
			[FieldOffset(Offset = "0x0")]
			public SpecialOperatorDetailNodeType nodeType;

			// Token: 0x0401EB34 RID: 125748
			[Token(Token = "0x401EB34")]
			[FieldOffset(Offset = "0x8")]
			public GameObject viewPrefab;
		}
	}
}
