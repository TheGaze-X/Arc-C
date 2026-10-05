using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001C8 RID: 456
	[Token(Token = "0x20001C8")]
	public abstract class NavigationEventBase<T> : EventBase<T>, INavigationEvent where T : NavigationEventBase<T>, new()
	{
		// Token: 0x06000C47 RID: 3143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C47")]
		protected NavigationEventBase()
		{
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C48")]
		protected override void Init()
		{
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C49")]
		private void LocalInit()
		{
		}
	}
}
