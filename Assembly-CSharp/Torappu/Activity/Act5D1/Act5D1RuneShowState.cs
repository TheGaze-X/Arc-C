using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007245 RID: 29253
	[Token(Token = "0x2007245")]
	public class Act5D1RuneShowState : PopupFloatState
	{
		// Token: 0x0602973E RID: 169790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602973E")]
		[Address(RVA = "0x24CB3E0", Offset = "0x24C9FE0", VA = "0x1824CB3E0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602973F RID: 169791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602973F")]
		[Address(RVA = "0x24CB440", Offset = "0x24CA040", VA = "0x1824CB440", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06029740 RID: 169792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029740")]
		[Address(RVA = "0x24CB6C0", Offset = "0x24CA2C0", VA = "0x1824CB6C0")]
		public Act5D1RuneShowState()
		{
		}

		// Token: 0x06029742 RID: 169794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029742")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403B396 RID: 242582
		[Token(Token = "0x403B396")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act5D1RuneShowStateBean _stateBean;

		// Token: 0x0403B397 RID: 242583
		[Token(Token = "0x403B397")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SimpleLayoutContent _viewContainer;

		// Token: 0x0403B398 RID: 242584
		[Token(Token = "0x403B398")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _cannotUseBenefit;

		// Token: 0x0403B399 RID: 242585
		[Token(Token = "0x403B399")]
		[FieldOffset(Offset = "0x88")]
		private Act5D1ShowAdapter m_adapter;

		// Token: 0x0403B39A RID: 242586
		[Token(Token = "0x403B39A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403B39B RID: 242587
		[Token(Token = "0x403B39B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403B39C RID: 242588
		[Token(Token = "0x403B39C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
