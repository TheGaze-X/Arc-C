using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector
{
	// Token: 0x02007BF9 RID: 31737
	[Token(Token = "0x2007BF9")]
	public class Facade<T>
	{
		// Token: 0x0602C670 RID: 181872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C670")]
		public void PopulateInstance(ref T instance)
		{
		}

		// Token: 0x0602C671 RID: 181873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C671")]
		public T ConstructInstance()
		{
			return null;
		}

		// Token: 0x0602C672 RID: 181874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C672")]
		public T ConstructInstance(GameObject context)
		{
			return null;
		}

		// Token: 0x0602C673 RID: 181875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C673")]
		public Facade()
		{
		}

		// Token: 0x04040296 RID: 262806
		[Token(Token = "0x4040296")]
		[FieldOffset(Offset = "0x0")]
		public Type InstanceType;

		// Token: 0x04040297 RID: 262807
		[Token(Token = "0x4040297")]
		[FieldOffset(Offset = "0x0")]
		public Dictionary<string, string> FacadeMembers;

		// Token: 0x04040298 RID: 262808
		[Token(Token = "0x4040298")]
		[FieldOffset(Offset = "0x0")]
		public List<UnityEngine.Object> ObjectReferences;
	}
}
