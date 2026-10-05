using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B55 RID: 11093
	[Token(Token = "0x2002B55")]
	public class AttributeChecker : ToggleablePassiveBuffAbility.Checker
	{
		// Token: 0x060129EF RID: 76271 RVA: 0x000720F0 File Offset: 0x000702F0
		[Token(Token = "0x60129EF")]
		[Address(RVA = "0xA9C2D0", Offset = "0xA9AED0", VA = "0x180A9C2D0", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x060129F0 RID: 76272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129F0")]
		[Address(RVA = "0xA9C330", Offset = "0xA9AF30", VA = "0x180A9C330", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x060129F1 RID: 76273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129F1")]
		[Address(RVA = "0xA9C3D0", Offset = "0xA9AFD0", VA = "0x180A9C3D0", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060129F2 RID: 76274 RVA: 0x00072108 File Offset: 0x00070308
		[Token(Token = "0x60129F2")]
		[Address(RVA = "0xA9C450", Offset = "0xA9B050", VA = "0x180A9C450")]
		private bool _CheckToggled()
		{
			return default(bool);
		}

		// Token: 0x060129F3 RID: 76275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129F3")]
		[Address(RVA = "0xA9C5C0", Offset = "0xA9B1C0", VA = "0x180A9C5C0")]
		public AttributeChecker()
		{
		}

		// Token: 0x060129F4 RID: 76276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129F4")]
		[Address(RVA = "0xA96850", Offset = "0xA95450", VA = "0x180A96850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x040150A3 RID: 86179
		[Token(Token = "0x40150A3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AttributeType _attributeType;

		// Token: 0x040150A4 RID: 86180
		[Token(Token = "0x40150A4")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private CompareType _condType;

		// Token: 0x040150A5 RID: 86181
		[Token(Token = "0x40150A5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _condition;

		// Token: 0x040150A6 RID: 86182
		[Token(Token = "0x40150A6")]
		[FieldOffset(Offset = "0x2C")]
		private float m_condition;

		// Token: 0x040150A7 RID: 86183
		[Token(Token = "0x40150A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x040150A8 RID: 86184
		[Token(Token = "0x40150A8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040150A9 RID: 86185
		[Token(Token = "0x40150A9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040150AA RID: 86186
		[Token(Token = "0x40150AA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckToggled;

		// Token: 0x040150AB RID: 86187
		[Token(Token = "0x40150AB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
