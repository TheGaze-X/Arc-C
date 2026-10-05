using System;
using System.Collections.Generic;
using FullInspector.Internal;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector.BackupService
{
	// Token: 0x02007C6E RID: 31854
	[Token(Token = "0x2007C6E")]
	[AddComponentMenu("")]
	public class fiStorageComponent : MonoBehaviour, fiIEditorOnlyTag
	{
		// Token: 0x0602C823 RID: 182307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C823")]
		[Address(RVA = "0x2873F40", Offset = "0x2872B40", VA = "0x182873F40")]
		public void RemoveInvalidBackups()
		{
		}

		// Token: 0x0602C824 RID: 182308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C824")]
		[Address(RVA = "0x2874050", Offset = "0x2872C50", VA = "0x182874050")]
		public fiStorageComponent()
		{
		}

		// Token: 0x04040353 RID: 262995
		[Token(Token = "0x4040353")]
		[FieldOffset(Offset = "0x18")]
		public List<fiSerializedObject> Objects;
	}
}
