using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200011B RID: 283
	[Token(Token = "0x200011B")]
	public interface INotifyValueChanged<T>
	{
		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600081C RID: 2076
		// (set) Token: 0x0600081D RID: 2077
		[Token(Token = "0x170001B2")]
		T value { [Token(Token = "0x600081C")] get; [Token(Token = "0x600081D")] set; }

		// Token: 0x0600081E RID: 2078
		[Token(Token = "0x600081E")]
		void SetValueWithoutNotify(T newValue);
	}
}
