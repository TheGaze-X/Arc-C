using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003295 RID: 12949
	[Token(Token = "0x2003295")]
	public class Mh2RidingHudPlugin : UIPluginTalent.UnitTalentUIPlugin
	{
		// Token: 0x060148E4 RID: 84196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148E4")]
		[Address(RVA = "0xCD2C80", Offset = "0xCD1880", VA = "0x180CD2C80", Slot = "9")]
		protected override void DoAttach(Unit owner, UIPluginTalent uiTalent)
		{
		}

		// Token: 0x060148E5 RID: 84197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148E5")]
		[Address(RVA = "0xCD2EE0", Offset = "0xCD1AE0", VA = "0x180CD2EE0")]
		private void Update()
		{
		}

		// Token: 0x060148E6 RID: 84198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148E6")]
		[Address(RVA = "0xCD3260", Offset = "0xCD1E60", VA = "0x180CD3260")]
		public Mh2RidingHudPlugin()
		{
		}

		// Token: 0x060148E7 RID: 84199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148E7")]
		[Address(RVA = "0xCC3AD0", Offset = "0xCC26D0", VA = "0x180CC3AD0")]
		private void <>xLuaBaseProxy_DoAttach(Unit P0, UIPluginTalent P1)
		{
		}

		// Token: 0x04018503 RID: 99587
		[Token(Token = "0x4018503")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Slider _ridingSlider;

		// Token: 0x04018504 RID: 99588
		[Token(Token = "0x4018504")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _root;

		// Token: 0x04018505 RID: 99589
		[Token(Token = "0x4018505")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _readyRidingRoot;

		// Token: 0x04018506 RID: 99590
		[Token(Token = "0x4018506")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _notReadyRidingRoot;

		// Token: 0x04018507 RID: 99591
		[Token(Token = "0x4018507")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _ridingCountdownRoot;

		// Token: 0x04018508 RID: 99592
		[Token(Token = "0x4018508")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Slider _ridingRemainingTimeSlider;

		// Token: 0x04018509 RID: 99593
		[Token(Token = "0x4018509")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _ridingRemainingTimePointer;

		// Token: 0x0401850A RID: 99594
		[Token(Token = "0x401850A")]
		[FieldOffset(Offset = "0x68")]
		private Mh2RidingHudPluginTalent m_hudTalent;

		// Token: 0x0401850B RID: 99595
		[Token(Token = "0x401850B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x0401850C RID: 99596
		[Token(Token = "0x401850C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401850D RID: 99597
		[Token(Token = "0x401850D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
