using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit.GachaPlugins
{
	// Token: 0x0200477B RID: 18299
	[Token(Token = "0x200477B")]
	public class RecruitGachaRuleLinkAgeLoop : RecruitGachaItemPlugin
	{
		// Token: 0x0601BB31 RID: 113457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB31")]
		[Address(RVA = "0x15182C0", Offset = "0x1516EC0", VA = "0x1815182C0", Slot = "4")]
		protected override void OnRefreshData(RecruitGachaItemViewBase host)
		{
		}

		// Token: 0x0601BB32 RID: 113458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB32")]
		[Address(RVA = "0x1518760", Offset = "0x1517360", VA = "0x181518760")]
		public void SetRuleGuarantee5Char(string[] charIds)
		{
		}

		// Token: 0x0601BB33 RID: 113459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB33")]
		[Address(RVA = "0x15188A0", Offset = "0x15174A0", VA = "0x1815188A0")]
		public RecruitGachaRuleLinkAgeLoop()
		{
		}

		// Token: 0x0402400B RID: 147467
		[Token(Token = "0x402400B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelGuarantee6;

		// Token: 0x0402400C RID: 147468
		[Token(Token = "0x402400C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textGuarantee6Count;

		// Token: 0x0402400D RID: 147469
		[Token(Token = "0x402400D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imageGuarantee6Char;

		// Token: 0x0402400E RID: 147470
		[Token(Token = "0x402400E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _ruleGuarantee5;

		// Token: 0x0402400F RID: 147471
		[Token(Token = "0x402400F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _ruleGuarantee5CharAll;

		// Token: 0x04024010 RID: 147472
		[Token(Token = "0x4024010")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RecruitGachaRuleLinkAgeLoop.GuaranteeChar5[] _ruleGuarantee5Char;

		// Token: 0x04024011 RID: 147473
		[Token(Token = "0x4024011")]
		[FieldOffset(Offset = "0x48")]
		private RecruitGachaRuleLinkAgeLoop.PlayerParam m_playerParam;

		// Token: 0x04024012 RID: 147474
		[Token(Token = "0x4024012")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRefreshData;

		// Token: 0x04024013 RID: 147475
		[Token(Token = "0x4024013")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetRuleGuarantee5Char;

		// Token: 0x04024014 RID: 147476
		[Token(Token = "0x4024014")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200477C RID: 18300
		[Token(Token = "0x200477C")]
		[Serializable]
		private struct GuaranteeChar5
		{
			// Token: 0x04024015 RID: 147477
			[Token(Token = "0x4024015")]
			[FieldOffset(Offset = "0x0")]
			public string charId;

			// Token: 0x04024016 RID: 147478
			[Token(Token = "0x4024016")]
			[FieldOffset(Offset = "0x8")]
			public GameObject obj;
		}

		// Token: 0x0200477D RID: 18301
		[Token(Token = "0x200477D")]
		private class PlayerParam : IHotfixable
		{
			// Token: 0x0601BB34 RID: 113460 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BB34")]
			[Address(RVA = "0x1506F90", Offset = "0x1505B90", VA = "0x181506F90")]
			public void UpdateData(string poolId)
			{
			}

			// Token: 0x0601BB35 RID: 113461 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601BB35")]
			[Address(RVA = "0x1506B20", Offset = "0x1505720", VA = "0x181506B20")]
			public List<string> GetNext5Char()
			{
				return null;
			}

			// Token: 0x0601BB36 RID: 113462 RVA: 0x000A5E70 File Offset: 0x000A4070
			[Token(Token = "0x601BB36")]
			[Address(RVA = "0x1506CD0", Offset = "0x15058D0", VA = "0x181506CD0")]
			public bool HasMust6()
			{
				return default(bool);
			}

			// Token: 0x0601BB37 RID: 113463 RVA: 0x000A5E88 File Offset: 0x000A4088
			[Token(Token = "0x601BB37")]
			[Address(RVA = "0x1506880", Offset = "0x1505480", VA = "0x181506880")]
			public bool CheckIfShowNext5Desc()
			{
				return default(bool);
			}

			// Token: 0x0601BB38 RID: 113464 RVA: 0x000A5EA0 File Offset: 0x000A40A0
			[Token(Token = "0x601BB38")]
			[Address(RVA = "0x15069A0", Offset = "0x15055A0", VA = "0x1815069A0")]
			public int GetMust6Count()
			{
				return 0;
			}

			// Token: 0x0601BB39 RID: 113465 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601BB39")]
			[Address(RVA = "0x1506940", Offset = "0x1505540", VA = "0x181506940")]
			public string GetMust6Char()
			{
				return null;
			}

			// Token: 0x0601BB3A RID: 113466 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BB3A")]
			[Address(RVA = "0x15076E0", Offset = "0x15062E0", VA = "0x1815076E0")]
			private void _GenEmptyPlayerParam()
			{
			}

			// Token: 0x0601BB3B RID: 113467 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BB3B")]
			[Address(RVA = "0x1507870", Offset = "0x1506470", VA = "0x181507870")]
			public PlayerParam()
			{
			}

			// Token: 0x04024017 RID: 147479
			[Token(Token = "0x4024017")]
			private const string BOOL_MUST6 = "must6";

			// Token: 0x04024018 RID: 147480
			[Token(Token = "0x4024018")]
			private const string STRING_MUST6CHAR = "must6Char";

			// Token: 0x04024019 RID: 147481
			[Token(Token = "0x4024019")]
			private const string INT_6COUNT = "must6Count";

			// Token: 0x0402401A RID: 147482
			[Token(Token = "0x402401A")]
			private const string STRING_NEXT5CHAR = "next5Char";

			// Token: 0x0402401B RID: 147483
			[Token(Token = "0x402401B")]
			private const string BOOL_NEXT5 = "next5";

			// Token: 0x0402401C RID: 147484
			[Token(Token = "0x402401C")]
			private const string INT_LOOP_TARGET6COUNT = "loopTarget6Count";

			// Token: 0x0402401D RID: 147485
			[Token(Token = "0x402401D")]
			private const string STRING_TARGET6CHAR = "guaranteeTarget6Char";

			// Token: 0x0402401E RID: 147486
			[Token(Token = "0x402401E")]
			[FieldOffset(Offset = "0x10")]
			private JObjectWrapper m_playerParam;

			// Token: 0x0402401F RID: 147487
			[Token(Token = "0x402401F")]
			[FieldOffset(Offset = "0x18")]
			private JObjectWrapper m_dataParam;

			// Token: 0x04024020 RID: 147488
			[Token(Token = "0x4024020")]
			[FieldOffset(Offset = "0x20")]
			private bool m_hasMust6;

			// Token: 0x04024021 RID: 147489
			[Token(Token = "0x4024021")]
			[FieldOffset(Offset = "0x24")]
			private int m_must6Count;

			// Token: 0x04024022 RID: 147490
			[Token(Token = "0x4024022")]
			[FieldOffset(Offset = "0x28")]
			private bool m_showNext5Desc;

			// Token: 0x04024023 RID: 147491
			[Token(Token = "0x4024023")]
			[FieldOffset(Offset = "0x30")]
			private List<string> m_next5Char;

			// Token: 0x04024024 RID: 147492
			[Token(Token = "0x4024024")]
			[FieldOffset(Offset = "0x38")]
			private string m_must6Char;

			// Token: 0x04024025 RID: 147493
			[Token(Token = "0x4024025")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_UpdateData;

			// Token: 0x04024026 RID: 147494
			[Token(Token = "0x4024026")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetNext5Char;

			// Token: 0x04024027 RID: 147495
			[Token(Token = "0x4024027")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_HasMust6;

			// Token: 0x04024028 RID: 147496
			[Token(Token = "0x4024028")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_CheckIfShowNext5Desc;

			// Token: 0x04024029 RID: 147497
			[Token(Token = "0x4024029")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetMust6Count;

			// Token: 0x0402402A RID: 147498
			[Token(Token = "0x402402A")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetMust6Char;

			// Token: 0x0402402B RID: 147499
			[Token(Token = "0x402402B")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__GenEmptyPlayerParam;

			// Token: 0x0402402C RID: 147500
			[Token(Token = "0x402402C")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
