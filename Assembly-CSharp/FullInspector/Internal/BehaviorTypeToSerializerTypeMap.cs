using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace FullInspector.Internal
{
	// Token: 0x02007C75 RID: 31861
	[Token(Token = "0x2007C75")]
	public static class BehaviorTypeToSerializerTypeMap
	{
		// Token: 0x0602C83A RID: 182330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C83A")]
		[Address(RVA = "0x2854CE0", Offset = "0x28538E0", VA = "0x182854CE0")]
		public static void Register(Type behaviorType, Type serializerType)
		{
		}

		// Token: 0x0602C83B RID: 182331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C83B")]
		[Address(RVA = "0x2854A60", Offset = "0x2853660", VA = "0x182854A60")]
		public static Type GetSerializerType(Type behaviorType)
		{
			return null;
		}

		// Token: 0x04040354 RID: 262996
		[Token(Token = "0x4040354")]
		[FieldOffset(Offset = "0x0")]
		private static List<BehaviorTypeToSerializerTypeMap.SerializationMapping> _mappings;

		// Token: 0x02007C76 RID: 31862
		[Token(Token = "0x2007C76")]
		private struct SerializationMapping
		{
			// Token: 0x04040355 RID: 262997
			[Token(Token = "0x4040355")]
			[FieldOffset(Offset = "0x0")]
			public Type BehaviorType;

			// Token: 0x04040356 RID: 262998
			[Token(Token = "0x4040356")]
			[FieldOffset(Offset = "0x8")]
			public Type SerializerType;
		}
	}
}
