using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.DevelopTools
{
	// Token: 0x0200288F RID: 10383
	[Token(Token = "0x200288F")]
	[RequireComponent(typeof(BattleLauncher))]
	public abstract class LevelBaker : MonoBehaviour
	{
		// Token: 0x1700263C RID: 9788
		// (get) Token: 0x060114B2 RID: 70834
		[Token(Token = "0x1700263C")]
		protected abstract string outputFolder { [Token(Token = "0x60114B2")] get; }

		// Token: 0x060114B3 RID: 70835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114B3")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected LevelBaker()
		{
		}
	}
}
