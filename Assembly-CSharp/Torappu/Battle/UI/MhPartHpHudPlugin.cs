using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003296 RID: 12950
	[Token(Token = "0x2003296")]
	public class MhPartHpHudPlugin : UIPluginTalent.UnitTalentUIPlugin
	{
		// Token: 0x060148E8 RID: 84200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148E8")]
		[Address(RVA = "0xCD32C0", Offset = "0xCD1EC0", VA = "0x180CD32C0", Slot = "9")]
		protected override void DoAttach(Unit owner, UIPluginTalent uiTalent)
		{
		}

		// Token: 0x060148E9 RID: 84201 RVA: 0x000876F0 File Offset: 0x000858F0
		[Token(Token = "0x60148E9")]
		[Address(RVA = "0xCD3830", Offset = "0xCD2430", VA = "0x180CD3830")]
		private bool _CheckOwnerValidMode()
		{
			return default(bool);
		}

		// Token: 0x060148EA RID: 84202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148EA")]
		[Address(RVA = "0xCD3490", Offset = "0xCD2090", VA = "0x180CD3490")]
		private void Update()
		{
		}

		// Token: 0x060148EB RID: 84203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148EB")]
		[Address(RVA = "0xCD3920", Offset = "0xCD2520", VA = "0x180CD3920")]
		public MhPartHpHudPlugin()
		{
		}

		// Token: 0x060148EC RID: 84204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148EC")]
		[Address(RVA = "0xCC3AD0", Offset = "0xCC26D0", VA = "0x180CC3AD0")]
		private void <>xLuaBaseProxy_DoAttach(Unit P0, UIPluginTalent P1)
		{
		}

		// Token: 0x0401850E RID: 99598
		[Token(Token = "0x401850E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIFollowSlider _partHpSlider;

		// Token: 0x0401850F RID: 99599
		[Token(Token = "0x401850F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _rootObj;

		// Token: 0x04018510 RID: 99600
		[Token(Token = "0x4018510")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04018511 RID: 99601
		[Token(Token = "0x4018511")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _triggerKey;

		// Token: 0x04018512 RID: 99602
		[Token(Token = "0x4018512")]
		[FieldOffset(Offset = "0x50")]
		private MhPartHpHudPluginTalent m_hudTalent;

		// Token: 0x04018513 RID: 99603
		[Token(Token = "0x4018513")]
		[FieldOffset(Offset = "0x58")]
		private float m_currentPartHpRatio;

		// Token: 0x04018514 RID: 99604
		[Token(Token = "0x4018514")]
		[FieldOffset(Offset = "0x5C")]
		private int m_trigger;

		// Token: 0x04018515 RID: 99605
		[Token(Token = "0x4018515")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04018516 RID: 99606
		[Token(Token = "0x4018516")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckOwnerValidMode;

		// Token: 0x04018517 RID: 99607
		[Token(Token = "0x4018517")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018518 RID: 99608
		[Token(Token = "0x4018518")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
