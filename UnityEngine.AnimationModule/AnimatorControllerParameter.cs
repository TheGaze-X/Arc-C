using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	[UsedByNativeCode]
	[NativeAsStruct]
	[NativeType(CodegenOptions.Custom, "MonoAnimatorControllerParameter")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
	[NativeHeader("Modules/Animation/AnimatorControllerParameter.h")]
	[StructLayout(0)]
	public class AnimatorControllerParameter
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700003C")]
		public string name
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x3E76330", Offset = "0x3E74F30", VA = "0x183E76330")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000CB RID: 203 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x1700003D")]
		public AnimatorControllerParameterType type
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x428FB90", Offset = "0x428E790", VA = "0x18428FB90")]
			get
			{
				return (AnimatorControllerParameterType)0;
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x5916B60", Offset = "0x5915760", VA = "0x185916B60", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x5916C50", Offset = "0x5915850", VA = "0x185916C50", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x5916CA0", Offset = "0x59158A0", VA = "0x185916CA0")]
		public AnimatorControllerParameter()
		{
		}

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal string m_Name;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal AnimatorControllerParameterType m_Type;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal float m_DefaultFloat;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int m_DefaultInt;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal bool m_DefaultBool;
	}
}
