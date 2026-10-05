using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x0200018B RID: 395
	[Token(Token = "0x200018B")]
	internal interface IEventMerger
	{
		// Token: 0x06000F73 RID: 3955
		[Token(Token = "0x6000F73")]
		bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr);
	}
}
