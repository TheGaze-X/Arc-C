using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x02007456 RID: 29782
	[Token(Token = "0x2007456")]
	public class Act36sideFoodHandbookEnemyItemAdapter : LoopScrollAdapter<Act36sideFoodHandbookEnemyItemAdapter.ViewHolder, Act36sideFoodHandbookEnemyItemModel>
	{
		// Token: 0x17006321 RID: 25377
		// (get) Token: 0x0602A052 RID: 172114 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A053 RID: 172115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006321")]
		public string activityId
		{
			[Token(Token = "0x602A052")]
			[Address(RVA = "0x259BDD0", Offset = "0x259A9D0", VA = "0x18259BDD0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602A053")]
			[Address(RVA = "0x259BE30", Offset = "0x259AA30", VA = "0x18259BE30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602A054 RID: 172116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A054")]
		[Address(RVA = "0x259BBC0", Offset = "0x259A7C0", VA = "0x18259BBC0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, Act36sideFoodHandbookEnemyItemAdapter.ViewHolder holder, Act36sideFoodHandbookEnemyItemModel data)
		{
		}

		// Token: 0x0602A055 RID: 172117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A055")]
		[Address(RVA = "0x259BA90", Offset = "0x259A690", VA = "0x18259BA90", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0602A056 RID: 172118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A056")]
		[Address(RVA = "0x259BD60", Offset = "0x259A960", VA = "0x18259BD60")]
		public Act36sideFoodHandbookEnemyItemAdapter()
		{
		}

		// Token: 0x0403C44E RID: 246862
		[Token(Token = "0x403C44E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Act36sideFoodHandbookEnemyListItem _prefab;

		// Token: 0x0403C450 RID: 246864
		[Token(Token = "0x403C450")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x0403C451 RID: 246865
		[Token(Token = "0x403C451")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_activityId;

		// Token: 0x0403C452 RID: 246866
		[Token(Token = "0x403C452")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403C453 RID: 246867
		[Token(Token = "0x403C453")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0403C454 RID: 246868
		[Token(Token = "0x403C454")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007457 RID: 29783
		[Token(Token = "0x2007457")]
		public class ViewHolder
		{
			// Token: 0x0602A057 RID: 172119 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A057")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0403C455 RID: 246869
			[Token(Token = "0x403C455")]
			[FieldOffset(Offset = "0x10")]
			public Act36sideFoodHandbookEnemyListItem item;
		}
	}
}
