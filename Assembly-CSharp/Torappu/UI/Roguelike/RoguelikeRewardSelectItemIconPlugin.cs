using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053FD RID: 21501
	[Token(Token = "0x20053FD")]
	public abstract class RoguelikeRewardSelectItemIconPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601FA24 RID: 129572
		[Token(Token = "0x601FA24")]
		public abstract bool OverrideIcon(string topicId, RoguelikeRewardShowType rewardShowType, string itemId);

		// Token: 0x0601FA25 RID: 129573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA25")]
		[Address(RVA = "0x195E0D0", Offset = "0x195CCD0", VA = "0x18195E0D0")]
		protected RoguelikeRewardSelectItemIconPlugin()
		{
		}

		// Token: 0x0402AA06 RID: 174598
		[Token(Token = "0x402AA06")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
