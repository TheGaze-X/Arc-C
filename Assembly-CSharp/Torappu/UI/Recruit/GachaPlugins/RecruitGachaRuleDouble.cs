using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit.GachaPlugins
{
	// Token: 0x0200477A RID: 18298
	[Token(Token = "0x200477A")]
	public class RecruitGachaRuleDouble : RecruitGachaItemPlugin
	{
		// Token: 0x0601BB2D RID: 113453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB2D")]
		[Address(RVA = "0x1517DD0", Offset = "0x15169D0", VA = "0x181517DD0", Slot = "4")]
		protected override void OnRefreshData(RecruitGachaItemViewBase host)
		{
		}

		// Token: 0x0601BB2E RID: 113454 RVA: 0x000A5E58 File Offset: 0x000A4058
		[Token(Token = "0x601BB2E")]
		[Address(RVA = "0x1518000", Offset = "0x1516C00", VA = "0x181518000")]
		private bool _IsRuleValid(GachaRuleType gachaRuleType)
		{
			return default(bool);
		}

		// Token: 0x0601BB2F RID: 113455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB2F")]
		[Address(RVA = "0x1518080", Offset = "0x1516C80", VA = "0x181518080")]
		private void _RenderGuaranteePart(PlayerGacha.PlayerDoubleGacha playerDoubleParam)
		{
		}

		// Token: 0x0601BB30 RID: 113456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB30")]
		[Address(RVA = "0x1518260", Offset = "0x1516E60", VA = "0x181518260")]
		public RecruitGachaRuleDouble()
		{
		}

		// Token: 0x04023FFF RID: 147455
		[Token(Token = "0x4023FFF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtCountCaption;

		// Token: 0x04024000 RID: 147456
		[Token(Token = "0x4024000")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtShowCount;

		// Token: 0x04024001 RID: 147457
		[Token(Token = "0x4024001")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelShowCount;

		// Token: 0x04024002 RID: 147458
		[Token(Token = "0x4024002")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgCharAvatar;

		// Token: 0x04024003 RID: 147459
		[Token(Token = "0x4024003")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelGuarantee;

		// Token: 0x04024004 RID: 147460
		[Token(Token = "0x4024004")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _firstGuranteeGO;

		// Token: 0x04024005 RID: 147461
		[Token(Token = "0x4024005")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _secondGuranteeGO;

		// Token: 0x04024006 RID: 147462
		[Token(Token = "0x4024006")]
		[FieldOffset(Offset = "0x50")]
		private string m_cacheCharId;

		// Token: 0x04024007 RID: 147463
		[Token(Token = "0x4024007")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRefreshData;

		// Token: 0x04024008 RID: 147464
		[Token(Token = "0x4024008")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__IsRuleValid;

		// Token: 0x04024009 RID: 147465
		[Token(Token = "0x4024009")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderGuaranteePart;

		// Token: 0x0402400A RID: 147466
		[Token(Token = "0x402400A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
