using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002123 RID: 8483
	[Token(Token = "0x2002123")]
	public abstract class UnitAnimatorHooker : MonoBehaviour
	{
		// Token: 0x0600D04D RID: 53325
		[Token(Token = "0x600D04D")]
		public abstract bool TryHookAnimation(string animKey, out string newAnimKey);

		// Token: 0x0600D04E RID: 53326
		[Token(Token = "0x600D04E")]
		public abstract bool ValidateAnimSwitchable(string sourceAnimName, string targetAnimName);

		// Token: 0x0600D04F RID: 53327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D04F")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected UnitAnimatorHooker()
		{
		}
	}
}
