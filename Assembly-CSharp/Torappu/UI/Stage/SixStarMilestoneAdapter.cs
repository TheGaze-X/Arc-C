using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006825 RID: 26661
	[Token(Token = "0x2006825")]
	public class SixStarMilestoneAdapter : LoopScrollAdapter<SixStarMilestoneItemHolder, SixStarMilestoneItemViewModel>, IHotfixable
	{
		// Token: 0x06026309 RID: 156425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026309")]
		[Address(RVA = "0x2139B20", Offset = "0x2138720", VA = "0x182139B20", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0602630A RID: 156426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602630A")]
		[Address(RVA = "0x2139BD0", Offset = "0x21387D0", VA = "0x182139BD0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, SixStarMilestoneItemHolder holder, SixStarMilestoneItemViewModel data)
		{
		}

		// Token: 0x0602630B RID: 156427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602630B")]
		[Address(RVA = "0x2139D30", Offset = "0x2138930", VA = "0x182139D30")]
		public SixStarMilestoneAdapter()
		{
		}

		// Token: 0x04035CEC RID: 220396
		[Token(Token = "0x4035CEC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _itemPrefab;

		// Token: 0x04035CED RID: 220397
		[Token(Token = "0x4035CED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x04035CEE RID: 220398
		[Token(Token = "0x4035CEE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04035CEF RID: 220399
		[Token(Token = "0x4035CEF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
