using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005192 RID: 20882
	[Token(Token = "0x2005192")]
	public abstract class UIRoguelikeEndingDialogBasePlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601EDAF RID: 126383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EDAF")]
		[Address(RVA = "0x18AC160", Offset = "0x18AAD60", VA = "0x1818AC160", Slot = "4")]
		public virtual RoguelikeMapBossIconHolder GetOverrideRoguelikeMapBossIconHolder(ILoadAsset loader, string topicId)
		{
			return null;
		}

		// Token: 0x0601EDB0 RID: 126384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDB0")]
		[Address(RVA = "0x18AC1F0", Offset = "0x18AADF0", VA = "0x1818AC1F0")]
		protected UIRoguelikeEndingDialogBasePlugin()
		{
		}

		// Token: 0x0402963F RID: 169535
		[Token(Token = "0x402963F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetOverrideRoguelikeMapBossIconHolder;

		// Token: 0x04029640 RID: 169536
		[Token(Token = "0x4029640")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
