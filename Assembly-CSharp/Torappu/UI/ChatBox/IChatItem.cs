using System;
using System.Collections;
using Il2CppDummyDll;

namespace Torappu.UI.ChatBox
{
	// Token: 0x02005A38 RID: 23096
	[Token(Token = "0x2005A38")]
	public interface IChatItem
	{
		// Token: 0x06021A07 RID: 137735
		[Token(Token = "0x6021A07")]
		PlayConfig BeforePlaying();

		// Token: 0x06021A08 RID: 137736
		[Token(Token = "0x6021A08")]
		IEnumerator PlayCoroutine();

		// Token: 0x06021A09 RID: 137737
		[Token(Token = "0x6021A09")]
		IEnumerator RemoveCoroutine();

		// Token: 0x06021A0A RID: 137738
		[Token(Token = "0x6021A0A")]
		void DisplayForLog();

		// Token: 0x06021A0B RID: 137739
		[Token(Token = "0x6021A0B")]
		void DisplayForRecord();
	}
}
