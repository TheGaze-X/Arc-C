using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200397D RID: 14717
	[Token(Token = "0x200397D")]
	public abstract class LoopScrollAdapter : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003785 RID: 14213
		// (get) Token: 0x060173C7 RID: 95175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003785")]
		protected LoopScrollRect scrollRect
		{
			[Token(Token = "0x60173C7")]
			[Address(RVA = "0xF9E1F0", Offset = "0xF9CDF0", VA = "0x180F9E1F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060173C8 RID: 95176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173C8")]
		[Address(RVA = "0xF9D570", Offset = "0xF9C170", VA = "0x180F9D570", Slot = "4")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x060173C9 RID: 95177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173C9")]
		[Address(RVA = "0xF9D4B0", Offset = "0xF9C0B0", VA = "0x180F9D4B0", Slot = "5")]
		protected virtual void OnCellsUpdate()
		{
		}

		// Token: 0x17003786 RID: 14214
		// (get) Token: 0x060173CA RID: 95178
		[Token(Token = "0x17003786")]
		public abstract int totalCount { [Token(Token = "0x60173CA")] get; }

		// Token: 0x060173CB RID: 95179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173CB")]
		[Address(RVA = "0xF9DAE0", Offset = "0xF9C6E0", VA = "0x180F9DAE0")]
		public void TriggerUpdateView(Transform transform, int index)
		{
		}

		// Token: 0x060173CC RID: 95180
		[Token(Token = "0x60173CC")]
		protected abstract void UpdateView(Transform transform, int index);

		// Token: 0x060173CD RID: 95181
		[Token(Token = "0x60173CD")]
		public abstract GameObject CreateView(Transform parent);

		// Token: 0x060173CE RID: 95182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173CE")]
		[Address(RVA = "0xF9D5D0", Offset = "0xF9C1D0", VA = "0x180F9D5D0", Slot = "9")]
		protected virtual void OnNewItemAlloc(GameObject newItem)
		{
		}

		// Token: 0x060173CF RID: 95183 RVA: 0x00095700 File Offset: 0x00093900
		[Token(Token = "0x60173CF")]
		[Address(RVA = "0xF9CD00", Offset = "0xF9B900", VA = "0x180F9CD00", Slot = "10")]
		[Obsolete]
		public virtual bool DestroyView(GameObject gameObject)
		{
			return default(bool);
		}

		// Token: 0x17003787 RID: 14215
		// (get) Token: 0x060173D0 RID: 95184 RVA: 0x00095718 File Offset: 0x00093918
		[Token(Token = "0x17003787")]
		public int childCount
		{
			[Token(Token = "0x60173D0")]
			[Address(RVA = "0xF9E180", Offset = "0xF9CD80", VA = "0x180F9E180")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060173D1 RID: 95185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60173D1")]
		[Address(RVA = "0xF9CD70", Offset = "0xF9B970", VA = "0x180F9CD70")]
		public Transform GetChild(int index)
		{
			return null;
		}

		// Token: 0x060173D2 RID: 95186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60173D2")]
		[Address(RVA = "0xF9CC30", Offset = "0xF9B830", VA = "0x180F9CC30")]
		public Transform AllocateAtTail(Transform parent)
		{
			return null;
		}

		// Token: 0x060173D3 RID: 95187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60173D3")]
		[Address(RVA = "0xF9CB60", Offset = "0xF9B760", VA = "0x180F9CB60")]
		public Transform AllocateAtFront(Transform parent)
		{
			return null;
		}

		// Token: 0x060173D4 RID: 95188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60173D4")]
		[Address(RVA = "0xF9DBC0", Offset = "0xF9C7C0", VA = "0x180F9DBC0")]
		private GameObject _AllocGameObject(Transform parent)
		{
			return null;
		}

		// Token: 0x060173D5 RID: 95189 RVA: 0x00095730 File Offset: 0x00093930
		[Token(Token = "0x60173D5")]
		[Address(RVA = "0xF9D800", Offset = "0xF9C400", VA = "0x180F9D800")]
		public bool Recycle(Transform transform)
		{
			return default(bool);
		}

		// Token: 0x060173D6 RID: 95190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173D6")]
		[Address(RVA = "0xF9D510", Offset = "0xF9C110", VA = "0x180F9D510", Slot = "11")]
		public virtual void OnContentPositionChange()
		{
		}

		// Token: 0x17003788 RID: 14216
		// (get) Token: 0x060173D7 RID: 95191 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060173D8 RID: 95192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003788")]
		public Action OnScrollLayoutUpdated
		{
			[Token(Token = "0x60173D7")]
			[Address(RVA = "0xF9E120", Offset = "0xF9CD20", VA = "0x180F9E120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60173D8")]
			[Address(RVA = "0xF9E250", Offset = "0xF9CE50", VA = "0x180F9E250")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060173D9 RID: 95193 RVA: 0x00095748 File Offset: 0x00093948
		[Token(Token = "0x60173D9")]
		[Address(RVA = "0xF9CFD0", Offset = "0xF9BBD0", VA = "0x180F9CFD0")]
		public bool HasPendingRefreshOpt()
		{
			return default(bool);
		}

		// Token: 0x060173DA RID: 95194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173DA")]
		[Address(RVA = "0xF9D0E0", Offset = "0xF9BCE0", VA = "0x180F9D0E0")]
		public void NotifyDataChanged()
		{
		}

		// Token: 0x060173DB RID: 95195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173DB")]
		[Address(RVA = "0xF9D3F0", Offset = "0xF9BFF0", VA = "0x180F9D3F0")]
		public void NotifyRebuild()
		{
		}

		// Token: 0x060173DC RID: 95196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173DC")]
		[Address(RVA = "0xF9D310", Offset = "0xF9BF10", VA = "0x180F9D310")]
		public void NotifyRebuildWithIndex(int startIndex)
		{
		}

		// Token: 0x060173DD RID: 95197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173DD")]
		[Address(RVA = "0xF9D1A0", Offset = "0xF9BDA0", VA = "0x180F9D1A0")]
		public void NotifyItemChanged(int itemIndex)
		{
		}

		// Token: 0x060173DE RID: 95198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173DE")]
		[Address(RVA = "0xF9CE10", Offset = "0xF9BA10", VA = "0x180F9CE10")]
		public void HandleViews(Action<GameObject> viewHandler)
		{
		}

		// Token: 0x060173DF RID: 95199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173DF")]
		[Address(RVA = "0xF9D630", Offset = "0xF9C230", VA = "0x180F9D630")]
		public void OnScrollRectActivated()
		{
		}

		// Token: 0x060173E0 RID: 95200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173E0")]
		[Address(RVA = "0xF9D040", Offset = "0xF9BC40", VA = "0x180F9D040")]
		public void Init(LoopScrollRect scrollRect)
		{
		}

		// Token: 0x060173E1 RID: 95201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60173E1")]
		[Address(RVA = "0xF9D9E0", Offset = "0xF9C5E0", VA = "0x180F9D9E0")]
		protected Transform ScrollContent()
		{
			return null;
		}

		// Token: 0x060173E2 RID: 95202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173E2")]
		[Address(RVA = "0xF9DDC0", Offset = "0xF9C9C0", VA = "0x180F9DDC0")]
		private void _RefreshCells()
		{
		}

		// Token: 0x060173E3 RID: 95203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173E3")]
		[Address(RVA = "0xF9DD20", Offset = "0xF9C920", VA = "0x180F9DD20")]
		private void _RebuildCells()
		{
		}

		// Token: 0x060173E4 RID: 95204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173E4")]
		[Address(RVA = "0xF9DE50", Offset = "0xF9CA50", VA = "0x180F9DE50")]
		private void _TryNotifyScrollRect(Action action, ref bool flag)
		{
		}

		// Token: 0x060173E5 RID: 95205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173E5")]
		[Address(RVA = "0xF9DF80", Offset = "0xF9CB80", VA = "0x180F9DF80")]
		private void _TryPendingTask(Action task, ref bool flag)
		{
		}

		// Token: 0x060173E6 RID: 95206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60173E6")]
		[Address(RVA = "0xF9E030", Offset = "0xF9CC30", VA = "0x180F9E030")]
		protected LoopScrollAdapter()
		{
		}

		// Token: 0x0401C0CB RID: 114891
		[Token(Token = "0x401C0CB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private LoopScrollRect m_scrollRect;

		// Token: 0x0401C0CC RID: 114892
		[Token(Token = "0x401C0CC")]
		[FieldOffset(Offset = "0x20")]
		private List<GameObject> m_activeItems;

		// Token: 0x0401C0CD RID: 114893
		[Token(Token = "0x401C0CD")]
		[FieldOffset(Offset = "0x28")]
		private List<GameObject> m_pooledItems;

		// Token: 0x0401C0CF RID: 114895
		[Token(Token = "0x401C0CF")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasPendingDataChange;

		// Token: 0x0401C0D0 RID: 114896
		[Token(Token = "0x401C0D0")]
		[FieldOffset(Offset = "0x39")]
		private bool m_hasPendingRebuild;

		// Token: 0x0401C0D1 RID: 114897
		[Token(Token = "0x401C0D1")]
		[FieldOffset(Offset = "0x3C")]
		private int m_startIndexWhenNextRebuild;

		// Token: 0x0401C0D2 RID: 114898
		[Token(Token = "0x401C0D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_scrollRect;

		// Token: 0x0401C0D3 RID: 114899
		[Token(Token = "0x401C0D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401C0D4 RID: 114900
		[Token(Token = "0x401C0D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCellsUpdate;

		// Token: 0x0401C0D5 RID: 114901
		[Token(Token = "0x401C0D5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TriggerUpdateView;

		// Token: 0x0401C0D6 RID: 114902
		[Token(Token = "0x401C0D6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnNewItemAlloc;

		// Token: 0x0401C0D7 RID: 114903
		[Token(Token = "0x401C0D7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DestroyView;

		// Token: 0x0401C0D8 RID: 114904
		[Token(Token = "0x401C0D8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_childCount;

		// Token: 0x0401C0D9 RID: 114905
		[Token(Token = "0x401C0D9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetChild;

		// Token: 0x0401C0DA RID: 114906
		[Token(Token = "0x401C0DA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_AllocateAtTail;

		// Token: 0x0401C0DB RID: 114907
		[Token(Token = "0x401C0DB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_AllocateAtFront;

		// Token: 0x0401C0DC RID: 114908
		[Token(Token = "0x401C0DC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__AllocGameObject;

		// Token: 0x0401C0DD RID: 114909
		[Token(Token = "0x401C0DD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Recycle;

		// Token: 0x0401C0DE RID: 114910
		[Token(Token = "0x401C0DE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnContentPositionChange;

		// Token: 0x0401C0DF RID: 114911
		[Token(Token = "0x401C0DF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_OnScrollLayoutUpdated;

		// Token: 0x0401C0E0 RID: 114912
		[Token(Token = "0x401C0E0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_OnScrollLayoutUpdated;

		// Token: 0x0401C0E1 RID: 114913
		[Token(Token = "0x401C0E1")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_HasPendingRefreshOpt;

		// Token: 0x0401C0E2 RID: 114914
		[Token(Token = "0x401C0E2")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_NotifyDataChanged;

		// Token: 0x0401C0E3 RID: 114915
		[Token(Token = "0x401C0E3")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_NotifyRebuild;

		// Token: 0x0401C0E4 RID: 114916
		[Token(Token = "0x401C0E4")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_NotifyRebuildWithIndex;

		// Token: 0x0401C0E5 RID: 114917
		[Token(Token = "0x401C0E5")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_NotifyItemChanged;

		// Token: 0x0401C0E6 RID: 114918
		[Token(Token = "0x401C0E6")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_HandleViews;

		// Token: 0x0401C0E7 RID: 114919
		[Token(Token = "0x401C0E7")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnScrollRectActivated;

		// Token: 0x0401C0E8 RID: 114920
		[Token(Token = "0x401C0E8")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401C0E9 RID: 114921
		[Token(Token = "0x401C0E9")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_ScrollContent;

		// Token: 0x0401C0EA RID: 114922
		[Token(Token = "0x401C0EA")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__RefreshCells;

		// Token: 0x0401C0EB RID: 114923
		[Token(Token = "0x401C0EB")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__RebuildCells;

		// Token: 0x0401C0EC RID: 114924
		[Token(Token = "0x401C0EC")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__TryNotifyScrollRect;

		// Token: 0x0401C0ED RID: 114925
		[Token(Token = "0x401C0ED")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__TryPendingTask;

		// Token: 0x0401C0EE RID: 114926
		[Token(Token = "0x401C0EE")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
