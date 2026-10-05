using System;
using System.Collections.Generic;
using FullInspector.Internal;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector.BackupService
{
	// Token: 0x02007C6B RID: 31851
	[Token(Token = "0x2007C6B")]
	public class fiSerializationOperator : ISerializationOperator
	{
		// Token: 0x0602C81E RID: 182302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C81E")]
		[Address(RVA = "0x28723C0", Offset = "0x2870FC0", VA = "0x1828723C0", Slot = "4")]
		public UnityEngine.Object RetrieveObjectReference(int storageId)
		{
			return null;
		}

		// Token: 0x0602C81F RID: 182303 RVA: 0x000E06D0 File Offset: 0x000DE8D0
		[Token(Token = "0x602C81F")]
		[Address(RVA = "0x28724D0", Offset = "0x28710D0", VA = "0x1828724D0", Slot = "5")]
		public int StoreObjectReference(UnityEngine.Object obj)
		{
			return 0;
		}

		// Token: 0x0602C820 RID: 182304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C820")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fiSerializationOperator()
		{
		}

		// Token: 0x04040349 RID: 262985
		[Token(Token = "0x4040349")]
		[FieldOffset(Offset = "0x10")]
		public List<fiUnityObjectReference> SerializedObjects;
	}
}
