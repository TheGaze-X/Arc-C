using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A9E RID: 15006
	[Token(Token = "0x2003A9E")]
	public abstract class CustomPageActivityComponent : MonoBehaviour, IBaseActViewBinder, IHotfixable
	{
		// Token: 0x170038E3 RID: 14563
		// (get) Token: 0x06017B5F RID: 97119
		[Token(Token = "0x170038E3")]
		public abstract string param { [Token(Token = "0x6017B5F")] get; }

		// Token: 0x06017B60 RID: 97120
		[Token(Token = "0x6017B60")]
		public abstract void OnViewModelRefresh(TemplateActivityViewModel viewModel);

		// Token: 0x06017B61 RID: 97121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B61")]
		[Address(RVA = "0xFE5360", Offset = "0xFE3F60", VA = "0x180FE5360", Slot = "7")]
		public virtual void Bind(CustomPageActivityComponentHolder customPageActivityComponentHolder)
		{
		}

		// Token: 0x06017B62 RID: 97122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B62")]
		[Address(RVA = "0xFE5450", Offset = "0xFE4050", VA = "0x180FE5450")]
		protected CustomPageActivityComponent()
		{
		}

		// Token: 0x0401C9D8 RID: 117208
		[Token(Token = "0x401C9D8")]
		[FieldOffset(Offset = "0x18")]
		protected CustomPageActivityComponentHolder componentHolder;

		// Token: 0x0401C9D9 RID: 117209
		[Token(Token = "0x401C9D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Bind;

		// Token: 0x0401C9DA RID: 117210
		[Token(Token = "0x401C9DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
