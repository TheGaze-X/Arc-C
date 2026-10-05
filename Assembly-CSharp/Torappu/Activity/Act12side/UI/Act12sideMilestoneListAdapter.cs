using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007AB1 RID: 31409
	[Token(Token = "0x2007AB1")]
	public class Act12sideMilestoneListAdapter : RecycleLoopScrollAdapter<Act12sideMilestoneItemHolder, Act12sideMilestoneItemModel>
	{
		// Token: 0x1700671E RID: 26398
		// (get) Token: 0x0602BFF4 RID: 180212 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BFF5 RID: 180213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700671E")]
		public Action<string> onMilestoneClick
		{
			[Token(Token = "0x602BFF4")]
			[Address(RVA = "0x27DCF80", Offset = "0x27DBB80", VA = "0x1827DCF80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602BFF5")]
			[Address(RVA = "0x27DCFE0", Offset = "0x27DBBE0", VA = "0x1827DCFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602BFF6 RID: 180214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFF6")]
		[Address(RVA = "0x27DCC90", Offset = "0x27DB890", VA = "0x1827DCC90", Slot = "13")]
		public override void UpdateView(int position, GameObject view, Act12sideMilestoneItemHolder holder, Act12sideMilestoneItemModel data)
		{
		}

		// Token: 0x0602BFF7 RID: 180215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BFF7")]
		[Address(RVA = "0x27DCE60", Offset = "0x27DBA60", VA = "0x1827DCE60", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0602BFF8 RID: 180216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFF8")]
		[Address(RVA = "0x27DCF10", Offset = "0x27DBB10", VA = "0x1827DCF10")]
		public Act12sideMilestoneListAdapter()
		{
		}

		// Token: 0x0403FBDA RID: 261082
		[Token(Token = "0x403FBDA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _itemTemplate;

		// Token: 0x0403FBDC RID: 261084
		[Token(Token = "0x403FBDC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onMilestoneClick;

		// Token: 0x0403FBDD RID: 261085
		[Token(Token = "0x403FBDD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onMilestoneClick;

		// Token: 0x0403FBDE RID: 261086
		[Token(Token = "0x403FBDE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403FBDF RID: 261087
		[Token(Token = "0x403FBDF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0403FBE0 RID: 261088
		[Token(Token = "0x403FBE0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
