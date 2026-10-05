using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004977 RID: 18807
	[Token(Token = "0x2004977")]
	public class MedalBarListRecycleList : RecycleLoopScrollAdapter, IHotfixable
	{
		// Token: 0x17004320 RID: 17184
		// (get) Token: 0x0601C580 RID: 116096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004320")]
		public List<MedalBarListItemModel> currentViewModelList
		{
			[Token(Token = "0x601C580")]
			[Address(RVA = "0x15C5DB0", Offset = "0x15C49B0", VA = "0x1815C5DB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004321 RID: 17185
		// (get) Token: 0x0601C581 RID: 116097 RVA: 0x000A7F10 File Offset: 0x000A6110
		[Token(Token = "0x17004321")]
		public override int totalCount
		{
			[Token(Token = "0x601C581")]
			[Address(RVA = "0x15C5E10", Offset = "0x15C4A10", VA = "0x1815C5E10", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601C582 RID: 116098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C582")]
		[Address(RVA = "0x15C57D0", Offset = "0x15C43D0", VA = "0x1815C57D0")]
		public void OnMedalClick(string medalId)
		{
		}

		// Token: 0x0601C583 RID: 116099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C583")]
		[Address(RVA = "0x15C5720", Offset = "0x15C4320", VA = "0x1815C5720", Slot = "12")]
		protected override void OnDataSourceChanged(bool forceRebuild)
		{
		}

		// Token: 0x0601C584 RID: 116100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C584")]
		[Address(RVA = "0x15C58E0", Offset = "0x15C44E0", VA = "0x1815C58E0", Slot = "7")]
		protected override void UpdateView(Transform transform, int index)
		{
		}

		// Token: 0x0601C585 RID: 116101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C585")]
		[Address(RVA = "0x15C5C40", Offset = "0x15C4840", VA = "0x1815C5C40", Slot = "13")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0601C586 RID: 116102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C586")]
		[Address(RVA = "0x15C5D50", Offset = "0x15C4950", VA = "0x1815C5D50")]
		public MedalBarListRecycleList()
		{
		}

		// Token: 0x0601C587 RID: 116103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C587")]
		[Address(RVA = "0x15C58D0", Offset = "0x15C44D0", VA = "0x1815C58D0")]
		private void <>xLuaBaseProxy_OnDataSourceChanged(bool P0)
		{
		}

		// Token: 0x04025178 RID: 151928
		[Token(Token = "0x4025178")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIMedalEvent _clickMedalEvent;

		// Token: 0x04025179 RID: 151929
		[Token(Token = "0x4025179")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIStringEvent _clickToGroupEvent;

		// Token: 0x0402517A RID: 151930
		[Token(Token = "0x402517A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIStringEvent _clickToMedalEvent;

		// Token: 0x0402517B RID: 151931
		[Token(Token = "0x402517B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _emptyFlag;

		// Token: 0x0402517C RID: 151932
		[Token(Token = "0x402517C")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public List<MedalBarListItemModel> viewModelList;

		// Token: 0x0402517D RID: 151933
		[Token(Token = "0x402517D")]
		[FieldOffset(Offset = "0x80")]
		public GameObject _medalObj;

		// Token: 0x0402517E RID: 151934
		[Token(Token = "0x402517E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currentViewModelList;

		// Token: 0x0402517F RID: 151935
		[Token(Token = "0x402517F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_totalCount;

		// Token: 0x04025180 RID: 151936
		[Token(Token = "0x4025180")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMedalClick;

		// Token: 0x04025181 RID: 151937
		[Token(Token = "0x4025181")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDataSourceChanged;

		// Token: 0x04025182 RID: 151938
		[Token(Token = "0x4025182")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04025183 RID: 151939
		[Token(Token = "0x4025183")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x04025184 RID: 151940
		[Token(Token = "0x4025184")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
