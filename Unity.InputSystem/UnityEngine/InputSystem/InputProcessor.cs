using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	public abstract class InputProcessor
	{
		// Token: 0x06000612 RID: 1554
		[Token(Token = "0x6000612")]
		public abstract object ProcessAsObject(object value, InputControl control);

		// Token: 0x06000613 RID: 1555
		[Token(Token = "0x6000613")]
		public unsafe abstract void Process(void* buffer, int bufferSize, InputControl control);

		// Token: 0x06000614 RID: 1556 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x5629010", Offset = "0x5627C10", VA = "0x185629010")]
		internal static Type GetValueTypeFromType(Type processorType)
		{
			return null;
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x00004CE0 File Offset: 0x00002EE0
		[Token(Token = "0x170001A6")]
		public virtual InputProcessor.CachingPolicy cachingPolicy
		{
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
			get
			{
				return InputProcessor.CachingPolicy.CacheResult;
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected InputProcessor()
		{
		}

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x0")]
		internal static TypeTable s_Processors;

		// Token: 0x02000082 RID: 130
		[Token(Token = "0x2000082")]
		public enum CachingPolicy
		{
			// Token: 0x040002D6 RID: 726
			[Token(Token = "0x40002D6")]
			CacheResult,
			// Token: 0x040002D7 RID: 727
			[Token(Token = "0x40002D7")]
			EvaluateOnEveryRead
		}
	}
}
