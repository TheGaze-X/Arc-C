using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit.GachaPlugins
{
	// Token: 0x02004774 RID: 18292
	[Token(Token = "0x2004774")]
	public class RecruitGachaRule1701 : RecruitGachaItemPlugin
	{
		// Token: 0x0601BB1C RID: 113436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB1C")]
		[Address(RVA = "0x1516E20", Offset = "0x1515A20", VA = "0x181516E20", Slot = "4")]
		protected override void OnRefreshData(RecruitGachaItemViewBase host)
		{
		}

		// Token: 0x0601BB1D RID: 113437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB1D")]
		[Address(RVA = "0x1517150", Offset = "0x1515D50", VA = "0x181517150")]
		public RecruitGachaRule1701()
		{
		}

		// Token: 0x04023FCE RID: 147406
		[Token(Token = "0x4023FCE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _ruleSecure5;

		// Token: 0x04023FCF RID: 147407
		[Token(Token = "0x4023FCF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelSecure6;

		// Token: 0x04023FD0 RID: 147408
		[Token(Token = "0x4023FD0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textSecure6;

		// Token: 0x04023FD1 RID: 147409
		[Token(Token = "0x4023FD1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RecruitGachaRule1701.SecureChar5[] _secureChar5;

		// Token: 0x04023FD2 RID: 147410
		[Token(Token = "0x4023FD2")]
		[FieldOffset(Offset = "0x38")]
		private RecruitGachaRule1701.PlayerParam m_playerParam;

		// Token: 0x04023FD3 RID: 147411
		[Token(Token = "0x4023FD3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRefreshData;

		// Token: 0x04023FD4 RID: 147412
		[Token(Token = "0x4023FD4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004775 RID: 18293
		[Token(Token = "0x2004775")]
		[Serializable]
		private struct SecureChar5
		{
			// Token: 0x04023FD5 RID: 147413
			[Token(Token = "0x4023FD5")]
			[FieldOffset(Offset = "0x0")]
			public string charId;

			// Token: 0x04023FD6 RID: 147414
			[Token(Token = "0x4023FD6")]
			[FieldOffset(Offset = "0x8")]
			public GameObject panel;
		}

		// Token: 0x02004776 RID: 18294
		[Token(Token = "0x2004776")]
		private class PlayerParam : IHotfixable
		{
			// Token: 0x0601BB1E RID: 113438 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BB1E")]
			[Address(RVA = "0x15072F0", Offset = "0x1505EF0", VA = "0x1815072F0")]
			public void UpdateData(string poolId)
			{
			}

			// Token: 0x0601BB1F RID: 113439 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601BB1F")]
			[Address(RVA = "0x1506AC0", Offset = "0x15056C0", VA = "0x181506AC0")]
			public string GetNext5Char()
			{
				return null;
			}

			// Token: 0x0601BB20 RID: 113440 RVA: 0x000A5DC8 File Offset: 0x000A3FC8
			[Token(Token = "0x601BB20")]
			[Address(RVA = "0x1506C10", Offset = "0x1505810", VA = "0x181506C10")]
			public bool HasMust6()
			{
				return default(bool);
			}

			// Token: 0x0601BB21 RID: 113441 RVA: 0x000A5DE0 File Offset: 0x000A3FE0
			[Token(Token = "0x601BB21")]
			[Address(RVA = "0x1506820", Offset = "0x1505420", VA = "0x181506820")]
			public bool CheckIfShowNext5Desc()
			{
				return default(bool);
			}

			// Token: 0x0601BB22 RID: 113442 RVA: 0x000A5DF8 File Offset: 0x000A3FF8
			[Token(Token = "0x601BB22")]
			[Address(RVA = "0x1506A00", Offset = "0x1505600", VA = "0x181506A00")]
			public int GetMust6Count()
			{
				return 0;
			}

			// Token: 0x0601BB23 RID: 113443 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BB23")]
			[Address(RVA = "0x1507810", Offset = "0x1506410", VA = "0x181507810")]
			public PlayerParam()
			{
			}

			// Token: 0x04023FD7 RID: 147415
			[Token(Token = "0x4023FD7")]
			private const string BOOL_NEXT5 = "next5";

			// Token: 0x04023FD8 RID: 147416
			[Token(Token = "0x4023FD8")]
			private const string STRING_NEXT5CHAR = "next5Char";

			// Token: 0x04023FD9 RID: 147417
			[Token(Token = "0x4023FD9")]
			private const string BOOL_MUST6 = "must6";

			// Token: 0x04023FDA RID: 147418
			[Token(Token = "0x4023FDA")]
			private const string INT_6COUNT = "guaranteeTarget6Count";

			// Token: 0x04023FDB RID: 147419
			[Token(Token = "0x4023FDB")]
			[FieldOffset(Offset = "0x10")]
			private JObjectWrapper m_playerParam;

			// Token: 0x04023FDC RID: 147420
			[Token(Token = "0x4023FDC")]
			[FieldOffset(Offset = "0x18")]
			private JObjectWrapper m_dataParam;

			// Token: 0x04023FDD RID: 147421
			[Token(Token = "0x4023FDD")]
			[FieldOffset(Offset = "0x20")]
			private bool m_hasMust6;

			// Token: 0x04023FDE RID: 147422
			[Token(Token = "0x4023FDE")]
			[FieldOffset(Offset = "0x24")]
			private int m_must6Count;

			// Token: 0x04023FDF RID: 147423
			[Token(Token = "0x4023FDF")]
			[FieldOffset(Offset = "0x28")]
			private bool m_showNext5Desc;

			// Token: 0x04023FE0 RID: 147424
			[Token(Token = "0x4023FE0")]
			[FieldOffset(Offset = "0x30")]
			private string m_next5Char;

			// Token: 0x04023FE1 RID: 147425
			[Token(Token = "0x4023FE1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_UpdateData;

			// Token: 0x04023FE2 RID: 147426
			[Token(Token = "0x4023FE2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetNext5Char;

			// Token: 0x04023FE3 RID: 147427
			[Token(Token = "0x4023FE3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_HasMust6;

			// Token: 0x04023FE4 RID: 147428
			[Token(Token = "0x4023FE4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_CheckIfShowNext5Desc;

			// Token: 0x04023FE5 RID: 147429
			[Token(Token = "0x4023FE5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetMust6Count;

			// Token: 0x04023FE6 RID: 147430
			[Token(Token = "0x4023FE6")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
