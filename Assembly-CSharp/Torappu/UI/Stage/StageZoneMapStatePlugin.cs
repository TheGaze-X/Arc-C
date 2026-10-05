using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006990 RID: 27024
	[Token(Token = "0x2006990")]
	[DisallowMultipleComponent]
	public abstract class StageZoneMapStatePlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026AB5 RID: 158389
		[Token(Token = "0x6026AB5")]
		public abstract void UpdateStatus(string actId, StagePage page, ZoneViewProperty zoneProp);

		// Token: 0x06026AB6 RID: 158390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026AB6")]
		[Address(RVA = "0x21C5E70", Offset = "0x21C4A70", VA = "0x1821C5E70")]
		protected StageZoneMapStatePlugin()
		{
		}

		// Token: 0x04036972 RID: 223602
		[Token(Token = "0x4036972")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
