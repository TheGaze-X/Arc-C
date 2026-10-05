using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.AsyncLoader;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x0200496F RID: 18799
	[Token(Token = "0x200496F")]
	public class MedalGroupListView : MonoBehaviour, IHotfixable, ITimeWatcher
	{
		// Token: 0x0601C554 RID: 116052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C554")]
		[Address(RVA = "0x15CDCE0", Offset = "0x15CC8E0", VA = "0x1815CDCE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C555 RID: 116053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C555")]
		[Address(RVA = "0x15CD3A0", Offset = "0x15CBFA0", VA = "0x1815CD3A0")]
		private void OnEnable()
		{
		}

		// Token: 0x0601C556 RID: 116054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C556")]
		[Address(RVA = "0x15CD340", Offset = "0x15CBF40", VA = "0x1815CD340")]
		private void OnDisable()
		{
		}

		// Token: 0x0601C557 RID: 116055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C557")]
		[Address(RVA = "0x15CDC60", Offset = "0x15CC860", VA = "0x1815CDC60", Slot = "4")]
		public void UpdateTime(float delta)
		{
		}

		// Token: 0x0601C558 RID: 116056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C558")]
		[Address(RVA = "0x15CDA50", Offset = "0x15CC650", VA = "0x1815CDA50")]
		public void ToLeftBarType(string typeId)
		{
		}

		// Token: 0x0601C559 RID: 116057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C559")]
		[Address(RVA = "0x15CDF00", Offset = "0x15CCB00", VA = "0x1815CDF00")]
		private void _ToBarPos(float value, [Optional] Action finishAction)
		{
		}

		// Token: 0x0601C55A RID: 116058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C55A")]
		[Address(RVA = "0x15CD400", Offset = "0x15CC000", VA = "0x1815CD400")]
		public void OnValueChanged(Vector2 pos)
		{
		}

		// Token: 0x0601C55B RID: 116059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C55B")]
		[Address(RVA = "0x15CD850", Offset = "0x15CC450", VA = "0x1815CD850")]
		public void Render(MedalListViewModel listViewModel, bool refreshFlag = false)
		{
		}

		// Token: 0x0601C55C RID: 116060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C55C")]
		[Address(RVA = "0x15CD630", Offset = "0x15CC230", VA = "0x1815CD630")]
		public void Refresh()
		{
		}

		// Token: 0x0601C55D RID: 116061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C55D")]
		[Address(RVA = "0x15CE140", Offset = "0x15CCD40", VA = "0x1815CE140")]
		public MedalGroupListView()
		{
		}

		// Token: 0x04025120 RID: 151840
		[Token(Token = "0x4025120")]
		private const int MEDAL_PER_FRAME = 2;

		// Token: 0x04025121 RID: 151841
		[Token(Token = "0x4025121")]
		private const float SPACING_HEIGHT = 15f;

		// Token: 0x04025122 RID: 151842
		[Token(Token = "0x4025122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIRecycleLayoutGroup _content;

		// Token: 0x04025123 RID: 151843
		[Token(Token = "0x4025123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MedalBarListView _barListView;

		// Token: 0x04025124 RID: 151844
		[Token(Token = "0x4025124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MedalGroupItemView _prefab;

		// Token: 0x04025125 RID: 151845
		[Token(Token = "0x4025125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ScrollRect _scroll;

		// Token: 0x04025126 RID: 151846
		[Token(Token = "0x4025126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIMedalEvent _clickMedalEvent;

		// Token: 0x04025127 RID: 151847
		[Token(Token = "0x4025127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIStringEvent _clickToGroupEvent;

		// Token: 0x04025128 RID: 151848
		[Token(Token = "0x4025128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _ableToGetFlag;

		// Token: 0x04025129 RID: 151849
		[Token(Token = "0x4025129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _emptyState;

		// Token: 0x0402512A RID: 151850
		[Token(Token = "0x402512A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public string pageName;

		// Token: 0x0402512B RID: 151851
		[Token(Token = "0x402512B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MedalListViewModel.ListFilter m_cachedFilter;

		// Token: 0x0402512C RID: 151852
		[Token(Token = "0x402512C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AsyncGameObjectLoader m_objLoader;

		// Token: 0x0402512D RID: 151853
		[Token(Token = "0x402512D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private MedalGroupListView.Adapter m_adapter;

		// Token: 0x0402512E RID: 151854
		[Token(Token = "0x402512E")]
		private const float DELTA_HEIGHT = 40f;

		// Token: 0x0402512F RID: 151855
		[Token(Token = "0x402512F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x04025130 RID: 151856
		[Token(Token = "0x4025130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Tween m_cacheTween;

		// Token: 0x04025131 RID: 151857
		[Token(Token = "0x4025131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025132 RID: 151858
		[Token(Token = "0x4025132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04025133 RID: 151859
		[Token(Token = "0x4025133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x04025134 RID: 151860
		[Token(Token = "0x4025134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x04025135 RID: 151861
		[Token(Token = "0x4025135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ToLeftBarType;

		// Token: 0x04025136 RID: 151862
		[Token(Token = "0x4025136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ToBarPos;

		// Token: 0x04025137 RID: 151863
		[Token(Token = "0x4025137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04025138 RID: 151864
		[Token(Token = "0x4025138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04025139 RID: 151865
		[Token(Token = "0x4025139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x0402513A RID: 151866
		[Token(Token = "0x402513A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004970 RID: 18800
		[Token(Token = "0x2004970")]
		private class Adapter : UIRecycleLayoutAdapter
		{
			// Token: 0x0601C55E RID: 116062 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C55E")]
			[Address(RVA = "0x15C4820", Offset = "0x15C3420", VA = "0x1815C4820")]
			public Adapter(MedalGroupListView closure)
			{
			}

			// Token: 0x0601C55F RID: 116063 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C55F")]
			[Address(RVA = "0x15C3D80", Offset = "0x15C2980", VA = "0x1815C3D80")]
			public void RebuildList(List<MedalGroupListItemModel> modelList)
			{
			}

			// Token: 0x0601C560 RID: 116064 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C560")]
			[Address(RVA = "0x15C40C0", Offset = "0x15C2CC0", VA = "0x1815C40C0")]
			public void RefreshList()
			{
			}

			// Token: 0x1700431E RID: 17182
			// (get) Token: 0x0601C561 RID: 116065 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700431E")]
			public List<KeyValuePair<string, float>> heightList
			{
				[Token(Token = "0x601C561")]
				[Address(RVA = "0x15C4A10", Offset = "0x15C3610", VA = "0x1815C4A10")]
				get
				{
					return null;
				}
			}

			// Token: 0x0601C562 RID: 116066 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C562")]
			[Address(RVA = "0x15C3C60", Offset = "0x15C2860", VA = "0x1815C3C60", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x0601C563 RID: 116067 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C563")]
			[Address(RVA = "0x15C4460", Offset = "0x15C3060", VA = "0x1815C4460")]
			private void _ReloadHeightList()
			{
			}

			// Token: 0x0402513B RID: 151867
			[Token(Token = "0x402513B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private MedalGroupListView m_closure;

			// Token: 0x0402513C RID: 151868
			[Token(Token = "0x402513C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private List<MedalGroupItemView.VirtualView> m_cells;

			// Token: 0x0402513D RID: 151869
			[Token(Token = "0x402513D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<KeyValuePair<string, float>> m_heightList;

			// Token: 0x0402513E RID: 151870
			[Token(Token = "0x402513E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402513F RID: 151871
			[Token(Token = "0x402513F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RebuildList;

			// Token: 0x04025140 RID: 151872
			[Token(Token = "0x4025140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RefreshList;

			// Token: 0x04025141 RID: 151873
			[Token(Token = "0x4025141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_heightList;

			// Token: 0x04025142 RID: 151874
			[Token(Token = "0x4025142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x04025143 RID: 151875
			[Token(Token = "0x4025143")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__ReloadHeightList;
		}
	}
}
