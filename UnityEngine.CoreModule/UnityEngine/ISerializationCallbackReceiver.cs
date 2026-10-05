using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200012D RID: 301
	[Token(Token = "0x200012D")]
	[RequiredByNativeCode]
	public interface ISerializationCallbackReceiver
	{
		// Token: 0x06000A6A RID: 2666
		[Token(Token = "0x6000A6A")]
		[RequiredByNativeCode]
		void OnBeforeSerialize();

		// Token: 0x06000A6B RID: 2667
		[Token(Token = "0x6000A6B")]
		[RequiredByNativeCode]
		void OnAfterDeserialize();
	}
}
