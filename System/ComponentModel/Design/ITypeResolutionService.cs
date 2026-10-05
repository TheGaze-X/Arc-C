using System;
using System.Reflection;
using Il2CppDummyDll;

namespace System.ComponentModel.Design
{
	// Token: 0x0200023A RID: 570
	[Token(Token = "0x200023A")]
	public interface ITypeResolutionService
	{
		// Token: 0x06000F87 RID: 3975
		[Token(Token = "0x6000F87")]
		Type GetType(string name);

		// Token: 0x06000F88 RID: 3976
		[Token(Token = "0x6000F88")]
		string GetPathOfAssembly(AssemblyName name);
	}
}
