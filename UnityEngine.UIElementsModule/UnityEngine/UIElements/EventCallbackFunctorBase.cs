using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000198 RID: 408
	[Token(Token = "0x2000198")]
	internal abstract class EventCallbackFunctorBase
	{
		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x00006000 File Offset: 0x00004200
		[Token(Token = "0x1700027F")]
		public CallbackPhase phase
		{
			[Token(Token = "0x6000B51")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return (CallbackPhase)0;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000B52 RID: 2898 RVA: 0x00006018 File Offset: 0x00004218
		[Token(Token = "0x17000280")]
		public InvokePolicy invokePolicy
		{
			[Token(Token = "0x6000B52")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			[CompilerGenerated]
			get
			{
				return InvokePolicy.Default;
			}
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x3629A50", Offset = "0x3628650", VA = "0x183629A50")]
		protected EventCallbackFunctorBase(CallbackPhase phase, InvokePolicy invokePolicy)
		{
		}

		// Token: 0x06000B54 RID: 2900
		[Token(Token = "0x6000B54")]
		public abstract void Invoke(EventBase evt, PropagationPhase propagationPhase);

		// Token: 0x06000B55 RID: 2901
		[Token(Token = "0x6000B55")]
		public abstract bool IsEquivalentTo(long eventTypeId, Delegate callback, CallbackPhase phase);

		// Token: 0x06000B56 RID: 2902 RVA: 0x00006030 File Offset: 0x00004230
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x5ADC130", Offset = "0x5ADAD30", VA = "0x185ADC130")]
		protected bool PhaseMatches(PropagationPhase propagationPhase)
		{
			return default(bool);
		}
	}
}
