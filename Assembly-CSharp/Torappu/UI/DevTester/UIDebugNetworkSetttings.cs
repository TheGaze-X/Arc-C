using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.DevTester
{
	// Token: 0x020050FB RID: 20731
	[Token(Token = "0x20050FB")]
	public class UIDebugNetworkSetttings : MonoBehaviour
	{
		// Token: 0x0601EA10 RID: 125456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA10")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIDebugNetworkSetttings()
		{
		}

		// Token: 0x040290F2 RID: 168178
		[Token(Token = "0x40290F2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Input")]
		private InputField _gameServerInput;

		// Token: 0x040290F3 RID: 168179
		[Token(Token = "0x40290F3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Input")]
		private InputField _sdkServerInput;

		// Token: 0x040290F4 RID: 168180
		[Token(Token = "0x40290F4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Input")]
		private InputField _u8ServerInput;

		// Token: 0x040290F5 RID: 168181
		[Token(Token = "0x40290F5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Input")]
		private InputField _hotUpdateUrlInput;

		// Token: 0x040290F6 RID: 168182
		[Token(Token = "0x40290F6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Input")]
		private InputField _annouceUrlInput;

		// Token: 0x040290F7 RID: 168183
		[Token(Token = "0x40290F7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Button")]
		private Button _btnReset;

		// Token: 0x040290F8 RID: 168184
		[Token(Token = "0x40290F8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _buttonContent;
	}
}
