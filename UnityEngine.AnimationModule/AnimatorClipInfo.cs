using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	[UsedByNativeCode]
	[NativeHeader("Modules/Animation/AnimatorInfo.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	public struct AnimatorClipInfo
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000028")]
		public AnimationClip clip
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x5916B10", Offset = "0x5915710", VA = "0x185916B10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x17000029")]
		public float weight
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x5916B50", Offset = "0x5915750", VA = "0x185916B50")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000089 RID: 137
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x5916AD0", Offset = "0x59156D0", VA = "0x185916AD0")]
		[FreeFunction("AnimationBindings::InstanceIDToAnimationClipPPtr")]
		[MethodImpl(4096)]
		private static extern AnimationClip InstanceIDToAnimationClipPPtr(int instanceID);

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x0")]
		private int m_ClipInstanceID;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x4")]
		private float m_Weight;
	}
}
