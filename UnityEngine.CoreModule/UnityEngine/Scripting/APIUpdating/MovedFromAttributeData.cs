using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.Scripting.APIUpdating
{
	// Token: 0x0200019B RID: 411
	[Token(Token = "0x200019B")]
	internal struct MovedFromAttributeData
	{
		// Token: 0x06000CF4 RID: 3316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF4")]
		[Address(RVA = "0x5961150", Offset = "0x595FD50", VA = "0x185961150")]
		public void Set(bool autoUpdateAPI, [Optional] string sourceNamespace, [Optional] string sourceAssembly, [Optional] string sourceClassName)
		{
		}

		// Token: 0x040005DA RID: 1498
		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string className;

		// Token: 0x040005DB RID: 1499
		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string nameSpace;

		// Token: 0x040005DC RID: 1500
		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string assembly;

		// Token: 0x040005DD RID: 1501
		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool classHasChanged;

		// Token: 0x040005DE RID: 1502
		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool nameSpaceHasChanged;

		// Token: 0x040005DF RID: 1503
		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool assemblyHasChanged;

		// Token: 0x040005E0 RID: 1504
		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool autoUdpateAPI;
	}
}
