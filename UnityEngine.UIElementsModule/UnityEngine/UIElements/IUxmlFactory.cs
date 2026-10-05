using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000280 RID: 640
	[Token(Token = "0x2000280")]
	public interface IUxmlFactory
	{
		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x060011B7 RID: 4535
		[Token(Token = "0x17000474")]
		string uxmlQualifiedName { [Token(Token = "0x60011B7")] get; }

		// Token: 0x060011B8 RID: 4536
		[Token(Token = "0x60011B8")]
		bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc);

		// Token: 0x060011B9 RID: 4537
		[Token(Token = "0x60011B9")]
		VisualElement Create(IUxmlAttributes bag, CreationContext cc);
	}
}
