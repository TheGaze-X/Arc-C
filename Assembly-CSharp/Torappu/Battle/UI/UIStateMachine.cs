using System;
using Il2CppDummyDll;

namespace Torappu.Battle.UI
{
	// Token: 0x02003352 RID: 13138
	[Token(Token = "0x2003352")]
	public class UIStateMachine : EnumStateMachine<UIStateEnum>
	{
		// Token: 0x170031C1 RID: 12737
		// (get) Token: 0x06014F75 RID: 85877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170031C1")]
		public new IUIStateNode currentState
		{
			[Token(Token = "0x6014F75")]
			[Address(RVA = "0xD65F20", Offset = "0xD64B20", VA = "0x180D65F20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06014F76 RID: 85878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F76")]
		[Address(RVA = "0xD65DA0", Offset = "0xD649A0", VA = "0x180D65DA0")]
		public void RegisterState(UIStateEnum state, IUIStateNode stateNode, bool asDefault = false)
		{
		}

		// Token: 0x06014F77 RID: 85879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F77")]
		[Address(RVA = "0xD65ED0", Offset = "0xD64AD0", VA = "0x180D65ED0")]
		public new void Start(UIStateEnum state)
		{
		}

		// Token: 0x06014F78 RID: 85880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F78")]
		[Address(RVA = "0xD65EC0", Offset = "0xD64AC0", VA = "0x180D65EC0")]
		public new void SetDefaultState(UIStateEnum state)
		{
		}

		// Token: 0x06014F79 RID: 85881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F79")]
		[Address(RVA = "0xD65C00", Offset = "0xD64800", VA = "0x180D65C00", Slot = "6")]
		protected override void OnStateChanged(int newStateId, int oldStateId)
		{
		}

		// Token: 0x06014F7A RID: 85882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F7A")]
		[Address(RVA = "0xD65EE0", Offset = "0xD64AE0", VA = "0x180D65EE0")]
		public UIStateMachine()
		{
		}
	}
}
