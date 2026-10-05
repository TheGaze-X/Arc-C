using System;
using Il2CppDummyDll;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E4D RID: 20045
	[Token(Token = "0x2004E4D")]
	public class FireworkChangeAnimalResponse : PlayerDeltaResponse
	{
		// Token: 0x0601DECC RID: 122572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DECC")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public FireworkChangeAnimalResponse()
		{
		}

		// Token: 0x04027B88 RID: 162696
		[Token(Token = "0x4027B88")]
		[FieldOffset(Offset = "0x28")]
		public string animal;
	}
}
