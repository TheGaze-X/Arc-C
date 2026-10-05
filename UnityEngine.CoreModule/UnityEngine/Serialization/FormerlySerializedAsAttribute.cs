using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Serialization
{
	// Token: 0x02000198 RID: 408
	[Token(Token = "0x2000198")]
	[RequiredByNativeCode]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = false)]
	public class FormerlySerializedAsAttribute : Attribute
	{
		// Token: 0x06000CF0 RID: 3312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF0")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public FormerlySerializedAsAttribute(string oldName)
		{
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700029C")]
		public string oldName
		{
			[Token(Token = "0x6000CF1")]
			[Address(RVA = "0x3E76330", Offset = "0x3E74F30", VA = "0x183E76330")]
			get
			{
				return null;
			}
		}

		// Token: 0x040005D9 RID: 1497
		[Token(Token = "0x40005D9")]
		[FieldOffset(Offset = "0x10")]
		private string m_oldName;
	}
}
