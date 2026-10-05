using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit.GachaPlugins
{
	// Token: 0x02004777 RID: 18295
	[Token(Token = "0x2004777")]
	public class RecruitGachaRule3601 : RecruitGachaItemPlugin
	{
		// Token: 0x0601BB24 RID: 113444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB24")]
		[Address(RVA = "0x1517240", Offset = "0x1515E40", VA = "0x181517240", Slot = "4")]
		protected override void OnRefreshData(RecruitGachaItemViewBase host)
		{
		}

		// Token: 0x0601BB25 RID: 113445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB25")]
		[Address(RVA = "0x15175A0", Offset = "0x15161A0", VA = "0x1815175A0")]
		public RecruitGachaRule3601()
		{
		}

		// Token: 0x04023FE7 RID: 147431
		[Token(Token = "0x4023FE7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelSecure6;

		// Token: 0x04023FE8 RID: 147432
		[Token(Token = "0x4023FE8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textSecure6;

		// Token: 0x04023FE9 RID: 147433
		[Token(Token = "0x4023FE9")]
		[FieldOffset(Offset = "0x28")]
		private RecruitGachaRule3601.PlayerParam m_playerParam;

		// Token: 0x04023FEA RID: 147434
		[Token(Token = "0x4023FEA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRefreshData;

		// Token: 0x04023FEB RID: 147435
		[Token(Token = "0x4023FEB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004778 RID: 18296
		[Token(Token = "0x2004778")]
		private class PlayerParam : IHotfixable
		{
			// Token: 0x0601BB26 RID: 113446 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BB26")]
			[Address(RVA = "0x1507530", Offset = "0x1506130", VA = "0x181507530")]
			public void UpdateData(string poolId)
			{
			}

			// Token: 0x0601BB27 RID: 113447 RVA: 0x000A5E10 File Offset: 0x000A4010
			[Token(Token = "0x601BB27")]
			[Address(RVA = "0x1506C70", Offset = "0x1505870", VA = "0x181506C70")]
			public bool HasMust6()
			{
				return default(bool);
			}

			// Token: 0x0601BB28 RID: 113448 RVA: 0x000A5E28 File Offset: 0x000A4028
			[Token(Token = "0x601BB28")]
			[Address(RVA = "0x1506A60", Offset = "0x1505660", VA = "0x181506A60")]
			public int GetMust6Count()
			{
				return 0;
			}

			// Token: 0x0601BB29 RID: 113449 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BB29")]
			[Address(RVA = "0x15077B0", Offset = "0x15063B0", VA = "0x1815077B0")]
			public PlayerParam()
			{
			}

			// Token: 0x04023FEC RID: 147436
			[Token(Token = "0x4023FEC")]
			private const string BOOL_MUST6 = "must6";

			// Token: 0x04023FED RID: 147437
			[Token(Token = "0x4023FED")]
			private const string INT_6COUNT = "guaranteeTarget6Count";

			// Token: 0x04023FEE RID: 147438
			[Token(Token = "0x4023FEE")]
			[FieldOffset(Offset = "0x10")]
			private JObjectWrapper m_playerParam;

			// Token: 0x04023FEF RID: 147439
			[Token(Token = "0x4023FEF")]
			[FieldOffset(Offset = "0x18")]
			private JObjectWrapper m_dataParam;

			// Token: 0x04023FF0 RID: 147440
			[Token(Token = "0x4023FF0")]
			[FieldOffset(Offset = "0x20")]
			private bool m_hasMust6;

			// Token: 0x04023FF1 RID: 147441
			[Token(Token = "0x4023FF1")]
			[FieldOffset(Offset = "0x24")]
			private int m_must6Count;

			// Token: 0x04023FF2 RID: 147442
			[Token(Token = "0x4023FF2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_UpdateData;

			// Token: 0x04023FF3 RID: 147443
			[Token(Token = "0x4023FF3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_HasMust6;

			// Token: 0x04023FF4 RID: 147444
			[Token(Token = "0x4023FF4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetMust6Count;

			// Token: 0x04023FF5 RID: 147445
			[Token(Token = "0x4023FF5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
