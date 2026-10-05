using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using FullSerializer.Internal;
using Il2CppDummyDll;

namespace FullSerializer
{
	// Token: 0x02007B80 RID: 31616
	[Token(Token = "0x2007B80")]
	public class fsMetaType
	{
		// Token: 0x0602C419 RID: 181273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C419")]
		[Address(RVA = "0x2831870", Offset = "0x2830470", VA = "0x182831870")]
		public static fsMetaType Get(fsConfig config, Type type)
		{
			return null;
		}

		// Token: 0x0602C41A RID: 181274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C41A")]
		[Address(RVA = "0x2830B00", Offset = "0x282F700", VA = "0x182830B00")]
		public static void ClearCache()
		{
		}

		// Token: 0x0602C41B RID: 181275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C41B")]
		[Address(RVA = "0x2831DB0", Offset = "0x28309B0", VA = "0x182831DB0")]
		private fsMetaType(fsConfig config, Type reflectedType)
		{
		}

		// Token: 0x0602C41C RID: 181276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C41C")]
		[Address(RVA = "0x2830BB0", Offset = "0x282F7B0", VA = "0x182830BB0")]
		private static void CollectProperties(fsConfig config, List<fsMetaProperty> properties, Type reflectedType)
		{
		}

		// Token: 0x0602C41D RID: 181277 RVA: 0x000DEDB0 File Offset: 0x000DCFB0
		[Token(Token = "0x602C41D")]
		[Address(RVA = "0x2831BA0", Offset = "0x28307A0", VA = "0x182831BA0")]
		private static bool IsAutoProperty(PropertyInfo property, MemberInfo[] members)
		{
			return default(bool);
		}

		// Token: 0x0602C41E RID: 181278 RVA: 0x000DEDC8 File Offset: 0x000DCFC8
		[Token(Token = "0x602C41E")]
		[Address(RVA = "0x2830630", Offset = "0x282F230", VA = "0x182830630")]
		private static bool CanSerializeProperty(fsConfig config, PropertyInfo property, MemberInfo[] members, bool annotationFreeValue)
		{
			return default(bool);
		}

		// Token: 0x0602C41F RID: 181279 RVA: 0x000DEDE0 File Offset: 0x000DCFE0
		[Token(Token = "0x602C41F")]
		[Address(RVA = "0x28303D0", Offset = "0x282EFD0", VA = "0x1828303D0")]
		private static bool CanSerializeField(fsConfig config, FieldInfo field, bool annotationFreeValue)
		{
			return default(bool);
		}

		// Token: 0x0602C420 RID: 181280 RVA: 0x000DEDF8 File Offset: 0x000DCFF8
		[Token(Token = "0x602C420")]
		[Address(RVA = "0x2831670", Offset = "0x2830270", VA = "0x182831670")]
		public bool EmitAotData()
		{
			return default(bool);
		}

		// Token: 0x170067A9 RID: 26537
		// (get) Token: 0x0602C421 RID: 181281 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C422 RID: 181282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067A9")]
		public fsMetaProperty[] Properties
		{
			[Token(Token = "0x602C421")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602C422")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170067AA RID: 26538
		// (get) Token: 0x0602C423 RID: 181283 RVA: 0x000DEE10 File Offset: 0x000DD010
		[Token(Token = "0x170067AA")]
		public bool HasDefaultConstructor
		{
			[Token(Token = "0x602C423")]
			[Address(RVA = "0x2831EB0", Offset = "0x2830AB0", VA = "0x182831EB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602C424 RID: 181284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C424")]
		[Address(RVA = "0x2831130", Offset = "0x282FD30", VA = "0x182831130")]
		public object CreateInstance()
		{
			return null;
		}

		// Token: 0x040401CC RID: 262604
		[Token(Token = "0x40401CC")]
		[ThreadStatic]
		private static Dictionary<fsConfig, Dictionary<Type, fsMetaType>> _configMetaTypes;

		// Token: 0x040401CD RID: 262605
		[Token(Token = "0x40401CD")]
		[FieldOffset(Offset = "0x10")]
		public Type ReflectedType;

		// Token: 0x040401CE RID: 262606
		[Token(Token = "0x40401CE")]
		[FieldOffset(Offset = "0x18")]
		private bool _hasEmittedAotData;

		// Token: 0x040401D0 RID: 262608
		[Token(Token = "0x40401D0")]
		[FieldOffset(Offset = "0x28")]
		private bool? _hasDefaultConstructorCache;

		// Token: 0x040401D1 RID: 262609
		[Token(Token = "0x40401D1")]
		[FieldOffset(Offset = "0x2A")]
		private bool _isDefaultConstructorPublic;
	}
}
