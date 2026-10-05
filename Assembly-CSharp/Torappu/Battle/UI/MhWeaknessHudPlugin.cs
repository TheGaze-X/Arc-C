using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003297 RID: 12951
	[Token(Token = "0x2003297")]
	public class MhWeaknessHudPlugin : UIPluginTalent.UnitTalentUIPlugin
	{
		// Token: 0x060148ED RID: 84205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148ED")]
		[Address(RVA = "0xCD3980", Offset = "0xCD2580", VA = "0x180CD3980", Slot = "9")]
		protected override void DoAttach(Unit owner, UIPluginTalent uiTalent)
		{
		}

		// Token: 0x060148EE RID: 84206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148EE")]
		[Address(RVA = "0xCD3B00", Offset = "0xCD2700", VA = "0x180CD3B00")]
		private void Update()
		{
		}

		// Token: 0x060148EF RID: 84207 RVA: 0x00087708 File Offset: 0x00085908
		[Token(Token = "0x60148EF")]
		[Address(RVA = "0xCD3E10", Offset = "0xCD2A10", VA = "0x180CD3E10")]
		private bool _CheckOwnerValidMode()
		{
			return default(bool);
		}

		// Token: 0x060148F0 RID: 84208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148F0")]
		[Address(RVA = "0xCD3F00", Offset = "0xCD2B00", VA = "0x180CD3F00")]
		public MhWeaknessHudPlugin()
		{
		}

		// Token: 0x060148F1 RID: 84209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148F1")]
		[Address(RVA = "0xCC3AD0", Offset = "0xCC26D0", VA = "0x180CC3AD0")]
		private void <>xLuaBaseProxy_DoAttach(Unit P0, UIPluginTalent P1)
		{
		}

		// Token: 0x04018519 RID: 99609
		[Token(Token = "0x4018519")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _rootObj;

		// Token: 0x0401851A RID: 99610
		[Token(Token = "0x401851A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _rotationObj;

		// Token: 0x0401851B RID: 99611
		[Token(Token = "0x401851B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x0401851C RID: 99612
		[Token(Token = "0x401851C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _triggerKey;

		// Token: 0x0401851D RID: 99613
		[Token(Token = "0x401851D")]
		[FieldOffset(Offset = "0x50")]
		private MhWeaknessHudPluginTalent m_hudTalent;

		// Token: 0x0401851E RID: 99614
		[Token(Token = "0x401851E")]
		[FieldOffset(Offset = "0x58")]
		private int m_trigger;

		// Token: 0x0401851F RID: 99615
		[Token(Token = "0x401851F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04018520 RID: 99616
		[Token(Token = "0x4018520")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018521 RID: 99617
		[Token(Token = "0x4018521")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckOwnerValidMode;

		// Token: 0x04018522 RID: 99618
		[Token(Token = "0x4018522")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
