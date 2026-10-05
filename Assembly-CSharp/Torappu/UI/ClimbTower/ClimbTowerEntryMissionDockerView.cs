using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C54 RID: 23636
	[Token(Token = "0x2005C54")]
	public class ClimbTowerEntryMissionDockerView : DataBinder<ClimbTowerEntryMissionProperty>, IHotfixable
	{
		// Token: 0x06022404 RID: 140292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022404")]
		[Address(RVA = "0x1CB90E0", Offset = "0x1CB7CE0", VA = "0x181CB90E0", Slot = "7")]
		public override void OnValueChanged(ClimbTowerEntryMissionProperty property)
		{
		}

		// Token: 0x06022405 RID: 140293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022405")]
		[Address(RVA = "0x1CB9250", Offset = "0x1CB7E50", VA = "0x181CB9250")]
		public ClimbTowerEntryMissionDockerView()
		{
		}

		// Token: 0x0402F043 RID: 192579
		[Token(Token = "0x402F043")]
		private const string TOTAL_PROGRESS_FORMAT = "/{0}";

		// Token: 0x0402F044 RID: 192580
		[Token(Token = "0x402F044")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _curProgress;

		// Token: 0x0402F045 RID: 192581
		[Token(Token = "0x402F045")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _totalProgress;

		// Token: 0x0402F046 RID: 192582
		[Token(Token = "0x402F046")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402F047 RID: 192583
		[Token(Token = "0x402F047")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
