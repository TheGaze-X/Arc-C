using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D7D RID: 15741
	[Token(Token = "0x2003D7D")]
	public abstract class AbstractTemplateMissionViewController : MonoBehaviour, IHotfixable
	{
		// Token: 0x060187DD RID: 100317
		[Token(Token = "0x60187DD")]
		public abstract void OnInit(TemplateMissionInputParam inputParam);

		// Token: 0x060187DE RID: 100318
		[Token(Token = "0x60187DE")]
		public abstract void OnStateResume();

		// Token: 0x060187DF RID: 100319
		[Token(Token = "0x60187DF")]
		public abstract void OnMessage(int key, ValueBundle msg);

		// Token: 0x060187E0 RID: 100320
		[Token(Token = "0x60187E0")]
		public abstract void BindState(TemplateMissionState state);

		// Token: 0x060187E1 RID: 100321
		[Token(Token = "0x60187E1")]
		public abstract void ResetEntryTween();

		// Token: 0x060187E2 RID: 100322
		[Token(Token = "0x60187E2")]
		public abstract IEnumerator PlayEntryTween();

		// Token: 0x060187E3 RID: 100323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187E3")]
		[Address(RVA = "0x1101410", Offset = "0x1100010", VA = "0x181101410")]
		protected AbstractTemplateMissionViewController()
		{
		}

		// Token: 0x0401E02C RID: 122924
		[Token(Token = "0x401E02C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
