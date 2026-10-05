using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002195 RID: 8597
	[Token(Token = "0x2002195")]
	public abstract class AbstractBattleLoader : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600D4DF RID: 54495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D4DF")]
		[Address(RVA = "0x35806E0", Offset = "0x357F2E0", VA = "0x1835806E0")]
		protected AsyncOperation LoadSceneAsync(string sceneName)
		{
			return null;
		}

		// Token: 0x0600D4E0 RID: 54496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4E0")]
		[Address(RVA = "0x3580790", Offset = "0x357F390", VA = "0x183580790")]
		protected void LoadScene(string sceneName)
		{
		}

		// Token: 0x0600D4E1 RID: 54497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D4E1")]
		[Address(RVA = "0x3580840", Offset = "0x357F440", VA = "0x183580840")]
		protected AbstractBattleLoader()
		{
		}

		// Token: 0x0400E489 RID: 58505
		[Token(Token = "0x400E489")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadSceneAsync;

		// Token: 0x0400E48A RID: 58506
		[Token(Token = "0x400E48A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadScene;

		// Token: 0x0400E48B RID: 58507
		[Token(Token = "0x400E48B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
