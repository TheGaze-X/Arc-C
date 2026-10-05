using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B56 RID: 11094
	[Token(Token = "0x2002B56")]
	public class AttributeOrderInAllCharsToggleChecker : ToggleablePassiveBuffAbility.Checker
	{
		// Token: 0x17002909 RID: 10505
		// (get) Token: 0x060129F5 RID: 76277 RVA: 0x00072120 File Offset: 0x00070320
		[Token(Token = "0x17002909")]
		private bool compareAttribute
		{
			[Token(Token = "0x60129F5")]
			[Address(RVA = "0xA9CFD0", Offset = "0xA9BBD0", VA = "0x180A9CFD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060129F6 RID: 76278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129F6")]
		[Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x060129F7 RID: 76279 RVA: 0x00072138 File Offset: 0x00070338
		[Token(Token = "0x60129F7")]
		[Address(RVA = "0xA9C670", Offset = "0xA9B270", VA = "0x180A9C670", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x060129F8 RID: 76280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129F8")]
		[Address(RVA = "0xA9C820", Offset = "0xA9B420", VA = "0x180A9C820", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060129F9 RID: 76281 RVA: 0x00072150 File Offset: 0x00070350
		[Token(Token = "0x60129F9")]
		[Address(RVA = "0xA9C920", Offset = "0xA9B520", VA = "0x180A9C920")]
		private bool _CheckToggled()
		{
			return default(bool);
		}

		// Token: 0x060129FA RID: 76282 RVA: 0x00072168 File Offset: 0x00070368
		[Token(Token = "0x60129FA")]
		[Address(RVA = "0xA9CE00", Offset = "0xA9BA00", VA = "0x180A9CE00")]
		private FP _GetValue(Entity entity)
		{
			return default(FP);
		}

		// Token: 0x060129FB RID: 76283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129FB")]
		[Address(RVA = "0xA9CF20", Offset = "0xA9BB20", VA = "0x180A9CF20")]
		public AttributeOrderInAllCharsToggleChecker()
		{
		}

		// Token: 0x060129FC RID: 76284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129FC")]
		[Address(RVA = "0xA96850", Offset = "0xA95450", VA = "0x180A96850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x040150AC RID: 86188
		[Token(Token = "0x40150AC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TargetOptions _targetOptions;

		// Token: 0x040150AD RID: 86189
		[Token(Token = "0x40150AD")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private int _num;

		// Token: 0x040150AE RID: 86190
		[Token(Token = "0x40150AE")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private bool _isAsc;

		// Token: 0x040150AF RID: 86191
		[Token(Token = "0x40150AF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _tickInterval;

		// Token: 0x040150B0 RID: 86192
		[Token(Token = "0x40150B0")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private AttributeOrderInAllCharsToggleChecker.CompareTargetType _targetType;

		// Token: 0x040150B1 RID: 86193
		[Token(Token = "0x40150B1")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Inspect("compareAttribute")]
		private AttributeType _attributeType;

		// Token: 0x040150B2 RID: 86194
		[Token(Token = "0x40150B2")]
		[FieldOffset(Offset = "0x98")]
		private PeriodicTimer m_timer;

		// Token: 0x040150B3 RID: 86195
		[Token(Token = "0x40150B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compareAttribute;

		// Token: 0x040150B4 RID: 86196
		[Token(Token = "0x40150B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040150B5 RID: 86197
		[Token(Token = "0x40150B5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x040150B6 RID: 86198
		[Token(Token = "0x40150B6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040150B7 RID: 86199
		[Token(Token = "0x40150B7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckToggled;

		// Token: 0x040150B8 RID: 86200
		[Token(Token = "0x40150B8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetValue;

		// Token: 0x040150B9 RID: 86201
		[Token(Token = "0x40150B9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002B57 RID: 11095
		[Token(Token = "0x2002B57")]
		private enum CompareTargetType
		{
			// Token: 0x040150BB RID: 86203
			[Token(Token = "0x40150BB")]
			NONE,
			// Token: 0x040150BC RID: 86204
			[Token(Token = "0x40150BC")]
			ATTRIBUTE,
			// Token: 0x040150BD RID: 86205
			[Token(Token = "0x40150BD")]
			HP,
			// Token: 0x040150BE RID: 86206
			[Token(Token = "0x40150BE")]
			HP_RATIO
		}
	}
}
