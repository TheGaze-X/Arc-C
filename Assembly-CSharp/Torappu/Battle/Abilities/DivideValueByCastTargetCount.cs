using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C16 RID: 11286
	[Token(Token = "0x2002C16")]
	public class DivideValueByCastTargetCount : AbilityStandard.Behaviour
	{
		// Token: 0x060130EA RID: 78058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130EA")]
		[Address(RVA = "0xB198C0", Offset = "0xB184C0", VA = "0x180B198C0", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x060130EB RID: 78059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130EB")]
		[Address(RVA = "0xB19830", Offset = "0xB18430", VA = "0x180B19830", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x060130EC RID: 78060 RVA: 0x000747F0 File Offset: 0x000729F0
		[Token(Token = "0x60130EC")]
		[Address(RVA = "0xB19610", Offset = "0xB18210", VA = "0x180B19610")]
		private int GetTargetCount()
		{
			return 0;
		}

		// Token: 0x060130ED RID: 78061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130ED")]
		[Address(RVA = "0xB19990", Offset = "0xB18590", VA = "0x180B19990")]
		private void _UpdateBlackboard()
		{
		}

		// Token: 0x060130EE RID: 78062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130EE")]
		[Address(RVA = "0xB19B60", Offset = "0xB18760", VA = "0x180B19B60")]
		public DivideValueByCastTargetCount()
		{
		}

		// Token: 0x060130EF RID: 78063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130EF")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x060130F0 RID: 78064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130F0")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x04015854 RID: 88148
		[Token(Token = "0x4015854")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AbilityStandard.Event _event;

		// Token: 0x04015855 RID: 88149
		[Token(Token = "0x4015855")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _blackboardKey;

		// Token: 0x04015856 RID: 88150
		[Token(Token = "0x4015856")]
		[FieldOffset(Offset = "0x30")]
		private float m_blackboardValue;

		// Token: 0x04015857 RID: 88151
		[Token(Token = "0x4015857")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04015858 RID: 88152
		[Token(Token = "0x4015858")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x04015859 RID: 88153
		[Token(Token = "0x4015859")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetTargetCount;

		// Token: 0x0401585A RID: 88154
		[Token(Token = "0x401585A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateBlackboard;

		// Token: 0x0401585B RID: 88155
		[Token(Token = "0x401585B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
