using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Skills
{
	// Token: 0x020028B9 RID: 10425
	[Token(Token = "0x20028B9")]
	public class SpScaleAfterSkillCast : BasicSkill.Behaviour
	{
		// Token: 0x06011570 RID: 71024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011570")]
		[Address(RVA = "0x9318A0", Offset = "0x9304A0", VA = "0x1809318A0", Slot = "5")]
		public override void AssignData(Blackboard blackboard)
		{
		}

		// Token: 0x06011571 RID: 71025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011571")]
		[Address(RVA = "0x931950", Offset = "0x930550", VA = "0x180931950", Slot = "6")]
		public override void OnCastSucceed()
		{
		}

		// Token: 0x06011572 RID: 71026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011572")]
		[Address(RVA = "0x931B30", Offset = "0x930730", VA = "0x180931B30")]
		private void _ScaleSpCost()
		{
		}

		// Token: 0x06011573 RID: 71027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011573")]
		[Address(RVA = "0x931C60", Offset = "0x930860", VA = "0x180931C60")]
		public SpScaleAfterSkillCast()
		{
		}

		// Token: 0x06011574 RID: 71028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011574")]
		[Address(RVA = "0x91F590", Offset = "0x91E190", VA = "0x18091F590")]
		private void <>xLuaBaseProxy_AssignData(Blackboard P0)
		{
		}

		// Token: 0x06011575 RID: 71029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011575")]
		[Address(RVA = "0x91F5A0", Offset = "0x91E1A0", VA = "0x18091F5A0")]
		private void <>xLuaBaseProxy_OnCastSucceed()
		{
		}

		// Token: 0x04013614 RID: 79380
		[Token(Token = "0x4013614")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _spScale;

		// Token: 0x04013615 RID: 79381
		[Token(Token = "0x4013615")]
		[FieldOffset(Offset = "0x24")]
		private int m_spScaleCnt;

		// Token: 0x04013616 RID: 79382
		[Token(Token = "0x4013616")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x04013617 RID: 79383
		[Token(Token = "0x4013617")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastSucceed;

		// Token: 0x04013618 RID: 79384
		[Token(Token = "0x4013618")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ScaleSpCost;

		// Token: 0x04013619 RID: 79385
		[Token(Token = "0x4013619")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
