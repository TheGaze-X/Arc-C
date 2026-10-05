using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004759 RID: 18265
	[Token(Token = "0x2004759")]
	public abstract class RecruitGachaItemPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BA73 RID: 113267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA73")]
		[Address(RVA = "0x1500340", Offset = "0x14FEF40", VA = "0x181500340")]
		public void RefreshData(RecruitGachaItemViewBase host)
		{
		}

		// Token: 0x0601BA74 RID: 113268
		[Token(Token = "0x601BA74")]
		protected abstract void OnRefreshData(RecruitGachaItemViewBase host);

		// Token: 0x0601BA75 RID: 113269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA75")]
		[Address(RVA = "0x15003D0", Offset = "0x14FEFD0", VA = "0x1815003D0")]
		protected RecruitGachaItemPlugin()
		{
		}

		// Token: 0x04023E51 RID: 147025
		[Token(Token = "0x4023E51")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04023E52 RID: 147026
		[Token(Token = "0x4023E52")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
