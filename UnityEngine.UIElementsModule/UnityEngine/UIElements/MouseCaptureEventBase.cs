using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000188 RID: 392
	[Token(Token = "0x2000188")]
	public abstract class MouseCaptureEventBase<T> : PointerCaptureEventBase<T> where T : MouseCaptureEventBase<T>, new()
	{
		// Token: 0x06000ADC RID: 2780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADC")]
		protected override void Init()
		{
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADD")]
		protected MouseCaptureEventBase()
		{
		}
	}
}
