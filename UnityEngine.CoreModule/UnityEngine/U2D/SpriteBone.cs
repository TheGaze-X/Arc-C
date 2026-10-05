using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D
{
	// Token: 0x02000156 RID: 342
	[Token(Token = "0x2000156")]
	[MovedFrom("UnityEngine.Experimental.U2D")]
	[NativeType(CodegenOptions.Custom, "ScriptingSpriteBone")]
	[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
	[NativeHeader("Runtime/2D/Common/SpriteDataMarshalling.h")]
	[RequiredByNativeCode]
	[Serializable]
	public struct SpriteBone
	{
		// Token: 0x04000558 RID: 1368
		[Token(Token = "0x4000558")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[NativeName("name")]
		private string m_Name;

		// Token: 0x04000559 RID: 1369
		[Token(Token = "0x4000559")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[NativeName("guid")]
		private string m_Guid;

		// Token: 0x0400055A RID: 1370
		[Token(Token = "0x400055A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[NativeName("position")]
		private Vector3 m_Position;

		// Token: 0x0400055B RID: 1371
		[Token(Token = "0x400055B")]
		[FieldOffset(Offset = "0x1C")]
		[NativeName("rotation")]
		[SerializeField]
		private Quaternion m_Rotation;

		// Token: 0x0400055C RID: 1372
		[Token(Token = "0x400055C")]
		[FieldOffset(Offset = "0x2C")]
		[NativeName("length")]
		[SerializeField]
		private float m_Length;

		// Token: 0x0400055D RID: 1373
		[Token(Token = "0x400055D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[NativeName("parentId")]
		private int m_ParentId;

		// Token: 0x0400055E RID: 1374
		[Token(Token = "0x400055E")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[NativeName("color")]
		private Color32 m_Color;
	}
}
