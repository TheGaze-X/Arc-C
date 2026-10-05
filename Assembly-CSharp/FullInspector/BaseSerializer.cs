using System;
using System.Reflection;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BBD RID: 31677
	[Token(Token = "0x2007BBD")]
	public abstract class BaseSerializer
	{
		// Token: 0x0602C556 RID: 181590
		[Token(Token = "0x602C556")]
		public abstract string Serialize(MemberInfo storageType, object value, ISerializationOperator serializationOperator);

		// Token: 0x0602C557 RID: 181591
		[Token(Token = "0x602C557")]
		public abstract object Deserialize(MemberInfo storageType, string serializedState, ISerializationOperator serializationOperator);

		// Token: 0x170067C6 RID: 26566
		// (get) Token: 0x0602C558 RID: 181592 RVA: 0x000DF950 File Offset: 0x000DDB50
		[Token(Token = "0x170067C6")]
		public virtual bool SupportsMultithreading
		{
			[Token(Token = "0x602C558")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602C559 RID: 181593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C559")]
		[Address(RVA = "0x2854690", Offset = "0x2853290", VA = "0x182854690")]
		protected static Type GetStorageType(MemberInfo member)
		{
			return null;
		}

		// Token: 0x0602C55A RID: 181594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C55A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected BaseSerializer()
		{
		}
	}
}
