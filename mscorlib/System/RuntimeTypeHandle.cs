using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001BF RID: 447
	[Token(Token = "0x20001BF")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public struct RuntimeTypeHandle : System.Runtime.Serialization.ISerializable
	{
		// Token: 0x0600103F RID: 4159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600103F")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		internal RuntimeTypeHandle(System.IntPtr val)
		{
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001040")]
		[Address(RVA = "0x4D3E770", Offset = "0x4D3D370", VA = "0x184D3E770")]
		internal RuntimeTypeHandle(RuntimeType type)
		{
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001041")]
		[Address(RVA = "0x4D3E550", Offset = "0x4D3D150", VA = "0x184D3E550")]
		private RuntimeTypeHandle(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x0000D590 File Offset: 0x0000B790
		[Token(Token = "0x17000177")]
		public System.IntPtr Value
		{
			[Token(Token = "0x6001042")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001043")]
		[Address(RVA = "0x4D3DE40", Offset = "0x4D3CA40", VA = "0x184D3DE40", Slot = "4")]
		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0000D5A8 File Offset: 0x0000B7A8
		[Token(Token = "0x6001044")]
		[Address(RVA = "0x4D3DCB0", Offset = "0x4D3C8B0", VA = "0x184D3DCB0", Slot = "0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x0000D5C0 File Offset: 0x0000B7C0
		[Token(Token = "0x6001045")]
		[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001046 RID: 4166
		[Token(Token = "0x6001046")]
		[Address(RVA = "0x4D3DDC0", Offset = "0x4D3C9C0", VA = "0x184D3DDC0")]
		[MethodImpl(4096)]
		internal static extern System.Reflection.TypeAttributes GetAttributes(RuntimeType type);

		// Token: 0x06001047 RID: 4167
		[Token(Token = "0x6001047")]
		[Address(RVA = "0x4D3DE20", Offset = "0x4D3CA20", VA = "0x184D3DE20")]
		[MethodImpl(4096)]
		private static extern int GetMetadataToken(RuntimeType type);

		// Token: 0x06001048 RID: 4168 RVA: 0x0000D5D8 File Offset: 0x0000B7D8
		[Token(Token = "0x6001048")]
		[Address(RVA = "0x4D3DE20", Offset = "0x4D3CA20", VA = "0x184D3DE20")]
		internal static int GetToken(RuntimeType type)
		{
			return 0;
		}

		// Token: 0x06001049 RID: 4169
		[Token(Token = "0x6001049")]
		[Address(RVA = "0x4D3DE10", Offset = "0x4D3CA10", VA = "0x184D3DE10")]
		[MethodImpl(4096)]
		private static extern System.Type GetGenericTypeDefinition_impl(RuntimeType type);

		// Token: 0x0600104A RID: 4170 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600104A")]
		[Address(RVA = "0x4D3DE10", Offset = "0x4D3CA10", VA = "0x184D3DE10")]
		internal static System.Type GetGenericTypeDefinition(RuntimeType type)
		{
			return null;
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x0000D5F0 File Offset: 0x0000B7F0
		[Token(Token = "0x600104B")]
		[Address(RVA = "0x4D3E4D0", Offset = "0x4D3D0D0", VA = "0x184D3E4D0")]
		internal static bool IsPrimitive(RuntimeType type)
		{
			return default(bool);
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x0000D608 File Offset: 0x0000B808
		[Token(Token = "0x600104C")]
		[Address(RVA = "0x4D3E390", Offset = "0x4D3CF90", VA = "0x184D3E390")]
		internal static bool IsByRef(RuntimeType type)
		{
			return default(bool);
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x0000D620 File Offset: 0x0000B820
		[Token(Token = "0x600104D")]
		[Address(RVA = "0x4D3E4B0", Offset = "0x4D3D0B0", VA = "0x184D3E4B0")]
		internal static bool IsPointer(RuntimeType type)
		{
			return default(bool);
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x0000D638 File Offset: 0x0000B838
		[Token(Token = "0x600104E")]
		[Address(RVA = "0x4D3E370", Offset = "0x4D3CF70", VA = "0x184D3E370")]
		internal static bool IsArray(RuntimeType type)
		{
			return default(bool);
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0000D650 File Offset: 0x0000B850
		[Token(Token = "0x600104F")]
		[Address(RVA = "0x4D3E530", Offset = "0x4D3D130", VA = "0x184D3E530")]
		internal static bool IsSzArray(RuntimeType type)
		{
			return default(bool);
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0000D668 File Offset: 0x0000B868
		[Token(Token = "0x6001050")]
		[Address(RVA = "0x4D3E320", Offset = "0x4D3CF20", VA = "0x184D3E320")]
		internal static bool HasElementType(RuntimeType type)
		{
			return default(bool);
		}

		// Token: 0x06001051 RID: 4177
		[Token(Token = "0x6001051")]
		[Address(RVA = "0x4D3DDE0", Offset = "0x4D3C9E0", VA = "0x184D3DDE0")]
		[MethodImpl(4096)]
		internal static extern CorElementType GetCorElementType(RuntimeType type);

		// Token: 0x06001052 RID: 4178
		[Token(Token = "0x6001052")]
		[Address(RVA = "0x4D3E350", Offset = "0x4D3CF50", VA = "0x184D3E350")]
		[MethodImpl(4096)]
		internal static extern bool HasInstantiation(RuntimeType type);

		// Token: 0x06001053 RID: 4179
		[Token(Token = "0x6001053")]
		[Address(RVA = "0x4ACA7A0", Offset = "0x4AC93A0", VA = "0x184ACA7A0")]
		[MethodImpl(4096)]
		internal static extern bool IsComObject(RuntimeType type);

		// Token: 0x06001054 RID: 4180
		[Token(Token = "0x6001054")]
		[Address(RVA = "0x4D3E480", Offset = "0x4D3D080", VA = "0x184D3E480")]
		[MethodImpl(4096)]
		internal static extern bool IsInstanceOfType(RuntimeType type, object o);

		// Token: 0x06001055 RID: 4181
		[Token(Token = "0x6001055")]
		[Address(RVA = "0x4D3E360", Offset = "0x4D3CF60", VA = "0x184D3E360")]
		[MethodImpl(4096)]
		internal static extern bool HasReferences(RuntimeType type);

		// Token: 0x06001056 RID: 4182 RVA: 0x0000D680 File Offset: 0x0000B880
		[Token(Token = "0x6001056")]
		[Address(RVA = "0x4D3E3B0", Offset = "0x4D3CFB0", VA = "0x184D3E3B0")]
		internal static bool IsComObject(RuntimeType type, bool isGenericCOM)
		{
			return default(bool);
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x0000D698 File Offset: 0x0000B898
		[Token(Token = "0x6001057")]
		[Address(RVA = "0x4D3E3C0", Offset = "0x4D3CFC0", VA = "0x184D3E3C0")]
		internal static bool IsContextful(RuntimeType type)
		{
			return default(bool);
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
		[Token(Token = "0x6001058")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2)
		{
			return default(bool);
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0000D6C8 File Offset: 0x0000B8C8
		[Token(Token = "0x6001059")]
		[Address(RVA = "0x4D3E490", Offset = "0x4D3D090", VA = "0x184D3E490")]
		internal static bool IsInterface(RuntimeType type)
		{
			return default(bool);
		}

		// Token: 0x0600105A RID: 4186
		[Token(Token = "0x600105A")]
		[Address(RVA = "0x4D3DDA0", Offset = "0x4D3C9A0", VA = "0x184D3DDA0")]
		[MethodImpl(4096)]
		internal static extern int GetArrayRank(RuntimeType type);

		// Token: 0x0600105B RID: 4187
		[Token(Token = "0x600105B")]
		[Address(RVA = "0x4D3DDB0", Offset = "0x4D3C9B0", VA = "0x184D3DDB0")]
		[MethodImpl(4096)]
		internal static extern RuntimeAssembly GetAssembly(RuntimeType type);

		// Token: 0x0600105C RID: 4188
		[Token(Token = "0x600105C")]
		[Address(RVA = "0x4D3DDF0", Offset = "0x4D3C9F0", VA = "0x184D3DDF0")]
		[MethodImpl(4096)]
		internal static extern RuntimeType GetElementType(RuntimeType type);

		// Token: 0x0600105D RID: 4189
		[Token(Token = "0x600105D")]
		[Address(RVA = "0x4D3DE30", Offset = "0x4D3CA30", VA = "0x184D3DE30")]
		[MethodImpl(4096)]
		internal static extern RuntimeModule GetModule(RuntimeType type);

		// Token: 0x0600105E RID: 4190
		[Token(Token = "0x600105E")]
		[Address(RVA = "0x4D3E470", Offset = "0x4D3D070", VA = "0x184D3E470")]
		[MethodImpl(4096)]
		internal static extern bool IsGenericVariable(RuntimeType type);

		// Token: 0x0600105F RID: 4191
		[Token(Token = "0x600105F")]
		[Address(RVA = "0x4D3DDD0", Offset = "0x4D3C9D0", VA = "0x184D3DDD0")]
		[MethodImpl(4096)]
		internal static extern RuntimeType GetBaseType(RuntimeType type);

		// Token: 0x06001060 RID: 4192 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
		[Token(Token = "0x6001060")]
		[Address(RVA = "0x4D3DCA0", Offset = "0x4D3C8A0", VA = "0x184D3DCA0")]
		internal static bool CanCastTo(RuntimeType type, RuntimeType target)
		{
			return default(bool);
		}

		// Token: 0x06001061 RID: 4193
		[Token(Token = "0x6001061")]
		[Address(RVA = "0x4D3E7C0", Offset = "0x4D3D3C0", VA = "0x184D3E7C0")]
		[MethodImpl(4096)]
		private static extern bool type_is_assignable_from(System.Type a, System.Type b);

		// Token: 0x06001062 RID: 4194
		[Token(Token = "0x6001062")]
		[Address(RVA = "0x4D3E460", Offset = "0x4D3D060", VA = "0x184D3E460")]
		[MethodImpl(4096)]
		internal static extern bool IsGenericTypeDefinition(RuntimeType type);

		// Token: 0x06001063 RID: 4195
		[Token(Token = "0x6001063")]
		[Address(RVA = "0x4D3DE00", Offset = "0x4D3CA00", VA = "0x184D3DE00")]
		[MethodImpl(4096)]
		internal static extern System.IntPtr GetGenericParameterInfo(RuntimeType type);

		// Token: 0x06001064 RID: 4196 RVA: 0x0000D6F8 File Offset: 0x0000B8F8
		[Token(Token = "0x6001064")]
		[Address(RVA = "0x4D3E500", Offset = "0x4D3D100", VA = "0x184D3E500")]
		internal static bool IsSubclassOf(RuntimeType childType, RuntimeType baseType)
		{
			return default(bool);
		}

		// Token: 0x06001065 RID: 4197
		[Token(Token = "0x6001065")]
		[Address(RVA = "0x4D3E7B0", Offset = "0x4D3D3B0", VA = "0x184D3E7B0")]
		[MethodImpl(4096)]
		internal static extern bool is_subclass_of(System.IntPtr childType, System.IntPtr baseType);

		// Token: 0x06001066 RID: 4198
		[Token(Token = "0x6001066")]
		[Address(RVA = "0x4D3E790", Offset = "0x4D3D390", VA = "0x184D3E790")]
		[MethodImpl(4096)]
		private static extern RuntimeType internal_from_name(string name, ref StackCrawlMark stackMark, System.Reflection.Assembly callerAssembly, bool throwOnError, bool ignoreCase, bool reflectionOnly);

		// Token: 0x06001067 RID: 4199 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001067")]
		[Address(RVA = "0x4D3DFF0", Offset = "0x4D3CBF0", VA = "0x184D3DFF0")]
		internal static RuntimeType GetTypeByName(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark, bool loadTypeFromPartialName)
		{
			return null;
		}

		// Token: 0x04000785 RID: 1925
		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private System.IntPtr value;
	}
}
