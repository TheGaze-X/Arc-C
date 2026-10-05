using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200245B RID: 9307
	[Token(Token = "0x200245B")]
	public class PassiveSkill : BasicSkill
	{
		// Token: 0x0600EF47 RID: 61255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF47")]
		[Address(RVA = "0x676FF0", Offset = "0x675BF0", VA = "0x180676FF0", Slot = "57")]
		public override void OnInit()
		{
		}

		// Token: 0x0600EF48 RID: 61256 RVA: 0x000580B0 File Offset: 0x000562B0
		[Token(Token = "0x600EF48")]
		[Address(RVA = "0x676F60", Offset = "0x675B60", VA = "0x180676F60", Slot = "49")]
		protected override bool DoCast([Optional] Ability.FinishCallbackDelegate finishCb, PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EF49 RID: 61257 RVA: 0x000580C8 File Offset: 0x000562C8
		[Token(Token = "0x600EF49")]
		[Address(RVA = "0x677120", Offset = "0x675D20", VA = "0x180677120", Slot = "51")]
		public override bool UseSkill(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EF4A RID: 61258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF4A")]
		[Address(RVA = "0x677190", Offset = "0x675D90", VA = "0x180677190")]
		public PassiveSkill()
		{
		}

		// Token: 0x0600EF4B RID: 61259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF4B")]
		[Address(RVA = "0x634E10", Offset = "0x633A10", VA = "0x180634E10")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x04010898 RID: 67736
		[Token(Token = "0x4010898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private bool _attachInDummy;

		// Token: 0x04010899 RID: 67737
		[Token(Token = "0x4010899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401089A RID: 67738
		[Token(Token = "0x401089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoCast;

		// Token: 0x0401089B RID: 67739
		[Token(Token = "0x401089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UseSkill;

		// Token: 0x0401089C RID: 67740
		[Token(Token = "0x401089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
