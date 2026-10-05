using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007575 RID: 30069
	[Token(Token = "0x2007575")]
	public class Act24sideBattleTrapTrapListView : Act24sideBattleTrapAbstractTrapListView
	{
		// Token: 0x0602A55C RID: 173404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A55C")]
		[Address(RVA = "0x25FB6A0", Offset = "0x25FA2A0", VA = "0x1825FB6A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A55D RID: 173405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A55D")]
		[Address(RVA = "0x25FB4E0", Offset = "0x25FA0E0", VA = "0x1825FB4E0", Slot = "4")]
		public override void Render(List<Act24sideBattleTrapItemViewModel> modelList)
		{
		}

		// Token: 0x0602A55E RID: 173406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A55E")]
		[Address(RVA = "0x25FB7C0", Offset = "0x25FA3C0", VA = "0x1825FB7C0")]
		public Act24sideBattleTrapTrapListView()
		{
		}

		// Token: 0x0403CE1F RID: 249375
		[Token(Token = "0x403CE1F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _trapCardList;

		// Token: 0x0403CE20 RID: 249376
		[Token(Token = "0x403CE20")]
		[FieldOffset(Offset = "0x20")]
		private Act24sideBattleTrapTrapListView.TrapCardListAdapter m_trapCardListAdapter;

		// Token: 0x0403CE21 RID: 249377
		[Token(Token = "0x403CE21")]
		[FieldOffset(Offset = "0x28")]
		private List<Act24sideBattleTrapItemViewModel> m_modelList;

		// Token: 0x0403CE22 RID: 249378
		[Token(Token = "0x403CE22")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInit;

		// Token: 0x0403CE23 RID: 249379
		[Token(Token = "0x403CE23")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CE24 RID: 249380
		[Token(Token = "0x403CE24")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CE25 RID: 249381
		[Token(Token = "0x403CE25")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007576 RID: 30070
		[Token(Token = "0x2007576")]
		private class TrapCardListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602A55F RID: 173407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A55F")]
			[Address(RVA = "0x26048C0", Offset = "0x26034C0", VA = "0x1826048C0")]
			public TrapCardListAdapter(Act24sideBattleTrapTrapListView closure)
			{
			}

			// Token: 0x170063A7 RID: 25511
			// (get) Token: 0x0602A560 RID: 173408 RVA: 0x000D8150 File Offset: 0x000D6350
			[Token(Token = "0x170063A7")]
			public override int count
			{
				[Token(Token = "0x602A560")]
				[Address(RVA = "0x2604940", Offset = "0x2603540", VA = "0x182604940", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A561 RID: 173409 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A561")]
			[Address(RVA = "0x2604730", Offset = "0x2603330", VA = "0x182604730", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403CE26 RID: 249382
			[Token(Token = "0x403CE26")]
			[FieldOffset(Offset = "0x20")]
			private Act24sideBattleTrapTrapListView m_closure;

			// Token: 0x0403CE27 RID: 249383
			[Token(Token = "0x403CE27")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403CE28 RID: 249384
			[Token(Token = "0x403CE28")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403CE29 RID: 249385
			[Token(Token = "0x403CE29")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
