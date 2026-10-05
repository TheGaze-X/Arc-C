using System;
using System.Collections;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003C3 RID: 963
	[Token(Token = "0x20003C3")]
	internal class CADMessageBase
	{
		// Token: 0x06001E6E RID: 7790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E6E")]
		[Address(RVA = "0x4B70B40", Offset = "0x4B6F740", VA = "0x184B70B40")]
		public CADMessageBase(IMethodMessage msg)
		{
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E6F")]
		[Address(RVA = "0x4B6EC40", Offset = "0x4B6D840", VA = "0x184B6EC40")]
		internal System.Reflection.MethodBase GetMethod()
		{
			return null;
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E70")]
		[Address(RVA = "0x4B6EDF0", Offset = "0x4B6D9F0", VA = "0x184B6EDF0")]
		protected static System.Type[] GetSignature(System.Reflection.MethodBase methodBase, bool load)
		{
			return null;
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x00012EA0 File Offset: 0x000110A0
		[Token(Token = "0x6001E71")]
		[Address(RVA = "0x4B6F5C0", Offset = "0x4B6E1C0", VA = "0x184B6F5C0")]
		internal static int MarshalProperties(System.Collections.IDictionary dict, ref System.Collections.ArrayList args)
		{
			return 0;
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E72")]
		[Address(RVA = "0x4B709A0", Offset = "0x4B6F5A0", VA = "0x184B709A0")]
		internal static void UnmarshalProperties(System.Collections.IDictionary dict, int count, System.Collections.ArrayList args)
		{
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x00012EB8 File Offset: 0x000110B8
		[Token(Token = "0x6001E73")]
		[Address(RVA = "0x4B6F000", Offset = "0x4B6DC00", VA = "0x184B6F000")]
		private static bool IsPossibleToIgnoreMarshal(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E74")]
		[Address(RVA = "0x4B6F1A0", Offset = "0x4B6DDA0", VA = "0x184B6F1A0")]
		protected object MarshalArgument(object arg, ref System.Collections.ArrayList args)
		{
			return null;
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E75")]
		[Address(RVA = "0x4B6FCC0", Offset = "0x4B6E8C0", VA = "0x184B6FCC0")]
		protected object UnmarshalArgument(object arg, System.Collections.ArrayList args)
		{
			return null;
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E76")]
		[Address(RVA = "0x4B6F4A0", Offset = "0x4B6E0A0", VA = "0x184B6F4A0")]
		internal object[] MarshalArguments(object[] arguments, ref System.Collections.ArrayList args)
		{
			return null;
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E77")]
		[Address(RVA = "0x4B70880", Offset = "0x4B6F480", VA = "0x184B70880")]
		internal object[] UnmarshalArguments(object[] arguments, System.Collections.ArrayList args)
		{
			return null;
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E78")]
		[Address(RVA = "0x4B6FB10", Offset = "0x4B6E710", VA = "0x184B6FB10")]
		protected void SaveLogicalCallContext(IMethodMessage msg, ref System.Collections.ArrayList serializeList)
		{
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E79")]
		[Address(RVA = "0x4B6EBA0", Offset = "0x4B6D7A0", VA = "0x184B6EBA0")]
		internal LogicalCallContext GetLogicalCallContext(System.Collections.ArrayList args)
		{
			return null;
		}

		// Token: 0x04001032 RID: 4146
		[Token(Token = "0x4001032")]
		[FieldOffset(Offset = "0x10")]
		protected object[] _args;

		// Token: 0x04001033 RID: 4147
		[Token(Token = "0x4001033")]
		[FieldOffset(Offset = "0x18")]
		protected byte[] _serializedArgs;

		// Token: 0x04001034 RID: 4148
		[Token(Token = "0x4001034")]
		[FieldOffset(Offset = "0x20")]
		protected int _propertyCount;

		// Token: 0x04001035 RID: 4149
		[Token(Token = "0x4001035")]
		[FieldOffset(Offset = "0x28")]
		protected CADArgHolder _callContext;

		// Token: 0x04001036 RID: 4150
		[Token(Token = "0x4001036")]
		[FieldOffset(Offset = "0x30")]
		internal byte[] serializedMethod;
	}
}
