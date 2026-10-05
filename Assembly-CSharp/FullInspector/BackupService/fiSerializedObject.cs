using System;
using System.Collections.Generic;
using FullInspector.Internal;
using Il2CppDummyDll;

namespace FullInspector.BackupService
{
	// Token: 0x02007C6C RID: 31852
	[Token(Token = "0x2007C6C")]
	[Serializable]
	public class fiSerializedObject
	{
		// Token: 0x0602C821 RID: 182305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C821")]
		[Address(RVA = "0x2872C90", Offset = "0x2871890", VA = "0x182872C90")]
		public fiSerializedObject()
		{
		}

		// Token: 0x0404034A RID: 262986
		[Token(Token = "0x404034A")]
		[FieldOffset(Offset = "0x10")]
		public fiUnityObjectReference Target;

		// Token: 0x0404034B RID: 262987
		[Token(Token = "0x404034B")]
		[FieldOffset(Offset = "0x18")]
		public string SavedAt;

		// Token: 0x0404034C RID: 262988
		[Token(Token = "0x404034C")]
		[FieldOffset(Offset = "0x20")]
		public bool ShowDeserialized;

		// Token: 0x0404034D RID: 262989
		[Token(Token = "0x404034D")]
		[FieldOffset(Offset = "0x28")]
		public fiDeserializedObject DeserializedState;

		// Token: 0x0404034E RID: 262990
		[Token(Token = "0x404034E")]
		[FieldOffset(Offset = "0x30")]
		public List<fiSerializedMember> Members;

		// Token: 0x0404034F RID: 262991
		[Token(Token = "0x404034F")]
		[FieldOffset(Offset = "0x38")]
		public List<fiUnityObjectReference> ObjectReferences;
	}
}
