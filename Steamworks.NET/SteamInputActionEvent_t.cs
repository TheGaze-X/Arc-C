using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001C9 RID: 457
	[Token(Token = "0x20001C9")]
	[Serializable]
	public struct SteamInputActionEvent_t
	{
		// Token: 0x04000AEF RID: 2799
		[Token(Token = "0x4000AEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputHandle_t controllerHandle;

		// Token: 0x04000AF0 RID: 2800
		[Token(Token = "0x4000AF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ESteamInputActionEventType eEventType;

		// Token: 0x04000AF1 RID: 2801
		[Token(Token = "0x4000AF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SteamInputActionEvent_t.OptionValue m_val;

		// Token: 0x020001CA RID: 458
		[Token(Token = "0x20001CA")]
		[Serializable]
		public struct AnalogAction_t
		{
			// Token: 0x04000AF2 RID: 2802
			[Token(Token = "0x4000AF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public InputAnalogActionHandle_t actionHandle;

			// Token: 0x04000AF3 RID: 2803
			[Token(Token = "0x4000AF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public InputAnalogActionData_t analogActionData;
		}

		// Token: 0x020001CB RID: 459
		[Token(Token = "0x20001CB")]
		[Serializable]
		public struct DigitalAction_t
		{
			// Token: 0x04000AF4 RID: 2804
			[Token(Token = "0x4000AF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public InputDigitalActionHandle_t actionHandle;

			// Token: 0x04000AF5 RID: 2805
			[Token(Token = "0x4000AF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public InputDigitalActionData_t digitalActionData;
		}

		// Token: 0x020001CC RID: 460
		[Token(Token = "0x20001CC")]
		[Serializable]
		[StructLayout(2)]
		public struct OptionValue
		{
			// Token: 0x04000AF6 RID: 2806
			[Token(Token = "0x4000AF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SteamInputActionEvent_t.AnalogAction_t analogAction;

			// Token: 0x04000AF7 RID: 2807
			[Token(Token = "0x4000AF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SteamInputActionEvent_t.DigitalAction_t digitalAction;
		}
	}
}
