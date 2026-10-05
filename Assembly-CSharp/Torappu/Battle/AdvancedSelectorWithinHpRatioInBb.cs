using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024EF RID: 9455
	[Token(Token = "0x20024EF")]
	public class AdvancedSelectorWithinHpRatioInBb : AdvancedSelector
	{
		// Token: 0x0600F395 RID: 62357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F395")]
		[Address(RVA = "0x6A1C20", Offset = "0x6A0820", VA = "0x1806A1C20", Slot = "22")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F396 RID: 62358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F396")]
		[Address(RVA = "0x6A1B20", Offset = "0x6A0720", VA = "0x1806A1B20", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F397 RID: 62359 RVA: 0x00059D78 File Offset: 0x00057F78
		[Token(Token = "0x600F397")]
		[Address(RVA = "0x6A1CA0", Offset = "0x6A08A0", VA = "0x1806A1CA0", Slot = "16")]
		protected override bool ValidateTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F398 RID: 62360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F398")]
		[Address(RVA = "0x6A1EF0", Offset = "0x6A0AF0", VA = "0x1806A1EF0")]
		private void _Init(Blackboard blackboard)
		{
		}

		// Token: 0x0600F399 RID: 62361 RVA: 0x00059D90 File Offset: 0x00057F90
		[Token(Token = "0x600F399")]
		[Address(RVA = "0x6A1D30", Offset = "0x6A0930", VA = "0x1806A1D30")]
		private bool _CheckHpRatio(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F39A RID: 62362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F39A")]
		[Address(RVA = "0x6A20B0", Offset = "0x6A0CB0", VA = "0x1806A20B0")]
		public AdvancedSelectorWithinHpRatioInBb()
		{
		}

		// Token: 0x0600F39B RID: 62363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F39B")]
		[Address(RVA = "0x60C6F0", Offset = "0x60B2F0", VA = "0x18060C6F0")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0600F39C RID: 62364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F39C")]
		[Address(RVA = "0x69B0C0", Offset = "0x699CC0", VA = "0x18069B0C0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F39D RID: 62365 RVA: 0x00059DA8 File Offset: 0x00057FA8
		[Token(Token = "0x600F39D")]
		[Address(RVA = "0x60C700", Offset = "0x60B300", VA = "0x18060C700")]
		private bool <>xLuaBaseProxy_ValidateTarget(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04010DA6 RID: 69030
		[Token(Token = "0x4010DA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private bool _filerMaxHp;

		// Token: 0x04010DA7 RID: 69031
		[Token(Token = "0x4010DA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private float _maxHpRatio;

		// Token: 0x04010DA8 RID: 69032
		[Token(Token = "0x4010DA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private bool _loadMaxHpRatioFromBb;

		// Token: 0x04010DA9 RID: 69033
		[Token(Token = "0x4010DA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private string _maxHpBlackboardKey;

		// Token: 0x04010DAA RID: 69034
		[Token(Token = "0x4010DAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private bool _maxHpExcludeEqual;

		// Token: 0x04010DAB RID: 69035
		[Token(Token = "0x4010DAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		[SerializeField]
		private bool _filterMinHp;

		// Token: 0x04010DAC RID: 69036
		[Token(Token = "0x4010DAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[SerializeField]
		private float _minHpRatio;

		// Token: 0x04010DAD RID: 69037
		[Token(Token = "0x4010DAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private bool _loadMinHpRatioFromBb;

		// Token: 0x04010DAE RID: 69038
		[Token(Token = "0x4010DAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private string _minHpBlackboardKey;

		// Token: 0x04010DAF RID: 69039
		[Token(Token = "0x4010DAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private bool _minHpExcludeEqual;

		// Token: 0x04010DB0 RID: 69040
		[Token(Token = "0x4010DB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private FP m_minHpRatio;

		// Token: 0x04010DB1 RID: 69041
		[Token(Token = "0x4010DB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private FP m_maxHpRatio;

		// Token: 0x04010DB2 RID: 69042
		[Token(Token = "0x4010DB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04010DB3 RID: 69043
		[Token(Token = "0x4010DB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04010DB4 RID: 69044
		[Token(Token = "0x4010DB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ValidateTarget;

		// Token: 0x04010DB5 RID: 69045
		[Token(Token = "0x4010DB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x04010DB6 RID: 69046
		[Token(Token = "0x4010DB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckHpRatio;

		// Token: 0x04010DB7 RID: 69047
		[Token(Token = "0x4010DB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
