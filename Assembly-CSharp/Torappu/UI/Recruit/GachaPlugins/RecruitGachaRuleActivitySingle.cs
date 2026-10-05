using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit.GachaPlugins
{
	// Token: 0x02004779 RID: 18297
	[Token(Token = "0x2004779")]
	public class RecruitGachaRuleActivitySingle : RecruitGachaItemPlugin
	{
		// Token: 0x0601BB2A RID: 113450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB2A")]
		[Address(RVA = "0x1517690", Offset = "0x1516290", VA = "0x181517690", Slot = "4")]
		protected override void OnRefreshData(RecruitGachaItemViewBase host)
		{
		}

		// Token: 0x0601BB2B RID: 113451 RVA: 0x000A5E40 File Offset: 0x000A4040
		[Token(Token = "0x601BB2B")]
		[Address(RVA = "0x1517B80", Offset = "0x1516780", VA = "0x181517B80")]
		private CharUISkinStruct _GetSkinStruct(string charId)
		{
			return default(CharUISkinStruct);
		}

		// Token: 0x0601BB2C RID: 113452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB2C")]
		[Address(RVA = "0x1517D40", Offset = "0x1516940", VA = "0x181517D40")]
		public RecruitGachaRuleActivitySingle()
		{
		}

		// Token: 0x04023FF6 RID: 147446
		[Token(Token = "0x4023FF6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtCountdownCaption;

		// Token: 0x04023FF7 RID: 147447
		[Token(Token = "0x4023FF7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtCountdown;

		// Token: 0x04023FF8 RID: 147448
		[Token(Token = "0x4023FF8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelCountdownTips;

		// Token: 0x04023FF9 RID: 147449
		[Token(Token = "0x4023FF9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgCharAvatar;

		// Token: 0x04023FFA RID: 147450
		[Token(Token = "0x4023FFA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelGuarantee;

		// Token: 0x04023FFB RID: 147451
		[Token(Token = "0x4023FFB")]
		[FieldOffset(Offset = "0x40")]
		private string m_cachedCharId;

		// Token: 0x04023FFC RID: 147452
		[Token(Token = "0x4023FFC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRefreshData;

		// Token: 0x04023FFD RID: 147453
		[Token(Token = "0x4023FFD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetSkinStruct;

		// Token: 0x04023FFE RID: 147454
		[Token(Token = "0x4023FFE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
