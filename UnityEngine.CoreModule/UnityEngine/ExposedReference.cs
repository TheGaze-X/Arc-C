using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	[UsedByNativeCode(Name = "ExposedReference")]
	[Serializable]
	public struct ExposedReference<T> where T : Object
	{
		// Token: 0x06000205 RID: 517 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000205")]
		public T Resolve(IExposedPropertyTable resolver)
		{
			return null;
		}

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public PropertyName exposedName;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public Object defaultValue;
	}
}
