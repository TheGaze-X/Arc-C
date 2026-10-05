using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	[RequiredByNativeCode]
	[NativeHeader("Modules/Animation/HumanDescription.h")]
	[NativeType(CodegenOptions.Custom, "MonoSkeletonBone")]
	public struct SkeletonBone
	{
		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x0")]
		[NativeName("m_Name")]
		public string name;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x8")]
		[NativeName("m_ParentName")]
		internal string parentName;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x10")]
		[NativeName("m_Position")]
		public Vector3 position;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x1C")]
		[NativeName("m_Rotation")]
		public Quaternion rotation;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x2C")]
		[NativeName("m_Scale")]
		public Vector3 scale;
	}
}
