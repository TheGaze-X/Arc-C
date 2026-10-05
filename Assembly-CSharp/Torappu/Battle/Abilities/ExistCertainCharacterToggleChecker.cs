using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B5B RID: 11099
	[Token(Token = "0x2002B5B")]
	public class ExistCertainCharacterToggleChecker : ToggleablePassiveBuffAbility.Checker
	{
		// Token: 0x06012A1F RID: 76319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A1F")]
		[Address(RVA = "0xAA01E0", Offset = "0xA9EDE0", VA = "0x180AA01E0", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x06012A20 RID: 76320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A20")]
		[Address(RVA = "0xAA0290", Offset = "0xA9EE90", VA = "0x180AA0290", Slot = "7")]
		public override void OnAttached()
		{
		}

		// Token: 0x06012A21 RID: 76321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A21")]
		[Address(RVA = "0xAA0410", Offset = "0xA9F010", VA = "0x180AA0410", Slot = "8")]
		public override void OnDetached()
		{
		}

		// Token: 0x06012A22 RID: 76322 RVA: 0x00072258 File Offset: 0x00070458
		[Token(Token = "0x6012A22")]
		[Address(RVA = "0xAA0180", Offset = "0xA9ED80", VA = "0x180AA0180", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x06012A23 RID: 76323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A23")]
		[Address(RVA = "0xAA0AE0", Offset = "0xA9F6E0", VA = "0x180AA0AE0")]
		private void _OnUnitBornOrRallyPointReborn(object arg)
		{
		}

		// Token: 0x06012A24 RID: 76324 RVA: 0x00072270 File Offset: 0x00070470
		[Token(Token = "0x6012A24")]
		[Address(RVA = "0xAA0590", Offset = "0xA9F190", VA = "0x180AA0590")]
		private bool _CheckCondition()
		{
			return default(bool);
		}

		// Token: 0x06012A25 RID: 76325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A25")]
		[Address(RVA = "0xAA0C40", Offset = "0xA9F840", VA = "0x180AA0C40")]
		public ExistCertainCharacterToggleChecker()
		{
		}

		// Token: 0x06012A26 RID: 76326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A26")]
		[Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x06012A27 RID: 76327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A27")]
		[Address(RVA = "0xA961B0", Offset = "0xA94DB0", VA = "0x180A961B0")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x040150EA RID: 86250
		[Token(Token = "0x40150EA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _charKey;

		// Token: 0x040150EB RID: 86251
		[Token(Token = "0x40150EB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _chooseMyToken;

		// Token: 0x040150EC RID: 86252
		[Token(Token = "0x40150EC")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _inverse;

		// Token: 0x040150ED RID: 86253
		[Token(Token = "0x40150ED")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _minCnt;

		// Token: 0x040150EE RID: 86254
		[Token(Token = "0x40150EE")]
		[FieldOffset(Offset = "0x30")]
		private int m_minCnt;

		// Token: 0x040150EF RID: 86255
		[Token(Token = "0x40150EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040150F0 RID: 86256
		[Token(Token = "0x40150F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x040150F1 RID: 86257
		[Token(Token = "0x40150F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x040150F2 RID: 86258
		[Token(Token = "0x40150F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x040150F3 RID: 86259
		[Token(Token = "0x40150F3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnUnitBornOrRallyPointReborn;

		// Token: 0x040150F4 RID: 86260
		[Token(Token = "0x40150F4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckCondition;

		// Token: 0x040150F5 RID: 86261
		[Token(Token = "0x40150F5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
