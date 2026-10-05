using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public interface IInputActionCollection : IEnumerable<InputAction>, IEnumerable
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000120 RID: 288
		// (set) Token: 0x06000121 RID: 289
		[Token(Token = "0x1700007F")]
		InputBinding? bindingMask { [Token(Token = "0x6000120")] get; [Token(Token = "0x6000121")] set; }

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000122 RID: 290
		// (set) Token: 0x06000123 RID: 291
		[Token(Token = "0x17000080")]
		ReadOnlyArray<InputDevice>? devices { [Token(Token = "0x6000122")] get; [Token(Token = "0x6000123")] set; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000124 RID: 292
		[Token(Token = "0x17000081")]
		ReadOnlyArray<InputControlScheme> controlSchemes { [Token(Token = "0x6000124")] get; }

		// Token: 0x06000125 RID: 293
		[Token(Token = "0x6000125")]
		bool Contains(InputAction action);

		// Token: 0x06000126 RID: 294
		[Token(Token = "0x6000126")]
		void Enable();

		// Token: 0x06000127 RID: 295
		[Token(Token = "0x6000127")]
		void Disable();
	}
}
