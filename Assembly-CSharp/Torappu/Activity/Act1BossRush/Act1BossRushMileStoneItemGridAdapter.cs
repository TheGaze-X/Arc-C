using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1BossRush
{
	// Token: 0x020070BC RID: 28860
	[Token(Token = "0x20070BC")]
	public class Act1BossRushMileStoneItemGridAdapter : RecycleLoopScrollAdapter<Act1BossRushMileStoneItemHolder, Act1BossRushMileStoneItemViewModel>
	{
		// Token: 0x1700613B RID: 24891
		// (get) Token: 0x0602904A RID: 168010 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602904B RID: 168011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700613B")]
		public Action<string> onItemClick
		{
			[Token(Token = "0x602904A")]
			[Address(RVA = "0x2467870", Offset = "0x2466470", VA = "0x182467870")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602904B")]
			[Address(RVA = "0x24678D0", Offset = "0x24664D0", VA = "0x1824678D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602904C RID: 168012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602904C")]
		[Address(RVA = "0x24676E0", Offset = "0x24662E0", VA = "0x1824676E0", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0602904D RID: 168013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602904D")]
		[Address(RVA = "0x2467510", Offset = "0x2466110", VA = "0x182467510", Slot = "13")]
		public override void UpdateView(int position, GameObject view, Act1BossRushMileStoneItemHolder holder, Act1BossRushMileStoneItemViewModel data)
		{
		}

		// Token: 0x0602904E RID: 168014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602904E")]
		[Address(RVA = "0x2467800", Offset = "0x2466400", VA = "0x182467800")]
		public Act1BossRushMileStoneItemGridAdapter()
		{
		}

		// Token: 0x0403A8CB RID: 239819
		[Token(Token = "0x403A8CB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _mileStoneItem;

		// Token: 0x0403A8CD RID: 239821
		[Token(Token = "0x403A8CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x0403A8CE RID: 239822
		[Token(Token = "0x403A8CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x0403A8CF RID: 239823
		[Token(Token = "0x403A8CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0403A8D0 RID: 239824
		[Token(Token = "0x403A8D0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403A8D1 RID: 239825
		[Token(Token = "0x403A8D1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
