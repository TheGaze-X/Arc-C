using System;
using System.Reflection;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BD4 RID: 31700
	[Token(Token = "0x2007BD4")]
	[Obsolete("Please use [fiInspectorOnly]")]
	public class NullSerializer : BaseSerializer
	{
		// Token: 0x0602C5E2 RID: 181730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C5E2")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "4")]
		public override string Serialize(MemberInfo storageType, object value, ISerializationOperator serializationOperator)
		{
			return null;
		}

		// Token: 0x0602C5E3 RID: 181731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C5E3")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "5")]
		public override object Deserialize(MemberInfo storageType, string serializedState, ISerializationOperator serializationOperator)
		{
			return null;
		}

		// Token: 0x0602C5E4 RID: 181732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C5E4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public NullSerializer()
		{
		}
	}
}
