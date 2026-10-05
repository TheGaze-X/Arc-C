using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048C7 RID: 18631
	[Token(Token = "0x20048C7")]
	public class MiniActTrialListAdapter : RecycleLoopScrollAdapter<MiniActTrialItemHolder, MiniActTrialItemModel>
	{
		// Token: 0x170042B7 RID: 17079
		// (get) Token: 0x0601C1AF RID: 115119 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601C1B0 RID: 115120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170042B7")]
		public Action<string> onChapterClick
		{
			[Token(Token = "0x601C1AF")]
			[Address(RVA = "0x159A2E0", Offset = "0x1598EE0", VA = "0x18159A2E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601C1B0")]
			[Address(RVA = "0x159A3A0", Offset = "0x1598FA0", VA = "0x18159A3A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170042B8 RID: 17080
		// (get) Token: 0x0601C1B1 RID: 115121 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601C1B2 RID: 115122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170042B8")]
		public Action<string, List<string>> onTrialCollect
		{
			[Token(Token = "0x601C1B1")]
			[Address(RVA = "0x159A340", Offset = "0x1598F40", VA = "0x18159A340")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601C1B2")]
			[Address(RVA = "0x159A420", Offset = "0x1599020", VA = "0x18159A420")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601C1B3 RID: 115123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1B3")]
		[Address(RVA = "0x1599ED0", Offset = "0x1598AD0", VA = "0x181599ED0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, MiniActTrialItemHolder holder, MiniActTrialItemModel data)
		{
		}

		// Token: 0x0601C1B4 RID: 115124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C1B4")]
		[Address(RVA = "0x159A1C0", Offset = "0x1598DC0", VA = "0x18159A1C0", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0601C1B5 RID: 115125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1B5")]
		[Address(RVA = "0x159A270", Offset = "0x1598E70", VA = "0x18159A270")]
		public MiniActTrialListAdapter()
		{
		}

		// Token: 0x04024BCB RID: 150475
		[Token(Token = "0x4024BCB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _itemTemplate;

		// Token: 0x04024BCC RID: 150476
		[Token(Token = "0x4024BCC")]
		[FieldOffset(Offset = "0x70")]
		public IDragHandler parentScroll;

		// Token: 0x04024BCF RID: 150479
		[Token(Token = "0x4024BCF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onChapterClick;

		// Token: 0x04024BD0 RID: 150480
		[Token(Token = "0x4024BD0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onChapterClick;

		// Token: 0x04024BD1 RID: 150481
		[Token(Token = "0x4024BD1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onTrialCollect;

		// Token: 0x04024BD2 RID: 150482
		[Token(Token = "0x4024BD2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onTrialCollect;

		// Token: 0x04024BD3 RID: 150483
		[Token(Token = "0x4024BD3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04024BD4 RID: 150484
		[Token(Token = "0x4024BD4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x04024BD5 RID: 150485
		[Token(Token = "0x4024BD5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
