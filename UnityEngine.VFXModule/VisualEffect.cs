using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.VFX
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[NativeHeader("Modules/VFX/Public/ScriptBindings/VisualEffectBindings.h")]
	[NativeHeader("Modules/VFX/Public/VisualEffect.h")]
	[RequireComponent(typeof(Transform))]
	public class VisualEffect : Behaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001E RID: 30
		[Token(Token = "0x17000001")]
		public extern VisualEffectAsset visualEffectAsset { [Token(Token = "0x600001E")] [Address(RVA = "0x5BA16A0", Offset = "0x5BA02A0", VA = "0x185BA16A0")] [MethodImpl(4096)] get; }

		// Token: 0x0600001F RID: 31 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x5BA1320", Offset = "0x5B9FF20", VA = "0x185BA1320")]
		public VFXEventAttribute CreateVFXEventAttribute()
		{
			return null;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x5BA1490", Offset = "0x5BA0090", VA = "0x185BA1490")]
		[RequiredByNativeCode]
		private static VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(VisualEffect source)
		{
			return null;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x5BA1640", Offset = "0x5BA0240", VA = "0x185BA1640")]
		[RequiredByNativeCode]
		private static void InvokeOutputEventReceived_Internal(VisualEffect source, int eventNameId)
		{
		}

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x18")]
		private VFXEventAttribute m_cachedEventAttribute;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x20")]
		public Action<VFXOutputEventArgs> outputEventReceived;
	}
}
