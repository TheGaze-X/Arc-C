using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x0200051A RID: 1306
	[Token(Token = "0x200051A")]
	internal abstract class SignatureType : System.Type
	{
		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06002545 RID: 9541 RVA: 0x00014F58 File Offset: 0x00013158
		[Token(Token = "0x1700050C")]
		public sealed override bool IsSignatureType
		{
			[Token(Token = "0x6002545")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "76")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002546 RID: 9542
		[Token(Token = "0x6002546")]
		protected abstract override bool HasElementTypeImpl();

		// Token: 0x06002547 RID: 9543
		[Token(Token = "0x6002547")]
		protected abstract override bool IsArrayImpl();

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06002548 RID: 9544
		[Token(Token = "0x1700050D")]
		public abstract override bool IsSZArray { [Token(Token = "0x6002548")] get; }

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06002549 RID: 9545
		[Token(Token = "0x1700050E")]
		public abstract override bool IsVariableBoundArray { [Token(Token = "0x6002549")] get; }

		// Token: 0x0600254A RID: 9546
		[Token(Token = "0x600254A")]
		protected abstract override bool IsByRefImpl();

		// Token: 0x0600254B RID: 9547
		[Token(Token = "0x600254B")]
		protected abstract override bool IsPointerImpl();

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x0600254C RID: 9548 RVA: 0x00014F70 File Offset: 0x00013170
		[Token(Token = "0x1700050F")]
		public sealed override bool IsGenericType
		{
			[Token(Token = "0x600254C")]
			[Address(RVA = "0x4BE93C0", Offset = "0x4BE7FC0", VA = "0x184BE93C0", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x0600254D RID: 9549
		[Token(Token = "0x17000510")]
		public abstract override bool IsGenericTypeDefinition { [Token(Token = "0x600254D")] get; }

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x0600254E RID: 9550
		[Token(Token = "0x17000511")]
		public abstract override bool IsConstructedGenericType { [Token(Token = "0x600254E")] get; }

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x0600254F RID: 9551
		[Token(Token = "0x17000512")]
		public abstract override bool IsGenericParameter { [Token(Token = "0x600254F")] get; }

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06002550 RID: 9552
		[Token(Token = "0x17000513")]
		public abstract override bool IsGenericMethodParameter { [Token(Token = "0x6002550")] get; }

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06002551 RID: 9553
		[Token(Token = "0x17000514")]
		public abstract override bool ContainsGenericParameters { [Token(Token = "0x6002551")] get; }

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06002552 RID: 9554 RVA: 0x00014F88 File Offset: 0x00013188
		[Token(Token = "0x17000515")]
		public sealed override MemberTypes MemberType
		{
			[Token(Token = "0x6002552")]
			[Address(RVA = "0x3D28750", Offset = "0x3D27350", VA = "0x183D28750", Slot = "7")]
			get
			{
				return (MemberTypes)0;
			}
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002553")]
		[Address(RVA = "0x4BE8E20", Offset = "0x4BE7A20", VA = "0x184BE8E20", Slot = "126")]
		public sealed override System.Type MakeArrayType()
		{
			return null;
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002554")]
		[Address(RVA = "0x4BE8ED0", Offset = "0x4BE7AD0", VA = "0x184BE8ED0", Slot = "127")]
		public sealed override System.Type MakeArrayType(int rank)
		{
			return null;
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002555")]
		[Address(RVA = "0x4BE8F90", Offset = "0x4BE7B90", VA = "0x184BE8F90", Slot = "128")]
		public sealed override System.Type MakeByRefType()
		{
			return null;
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002556")]
		[Address(RVA = "0x4BE9090", Offset = "0x4BE7C90", VA = "0x184BE9090", Slot = "130")]
		public sealed override System.Type MakePointerType()
		{
			return null;
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002557")]
		[Address(RVA = "0x4BE9030", Offset = "0x4BE7C30", VA = "0x184BE9030", Slot = "129")]
		public sealed override System.Type MakeGenericType(params System.Type[] typeArguments)
		{
			return null;
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002558")]
		[Address(RVA = "0x4BE8180", Offset = "0x4BE6D80", VA = "0x184BE8180", Slot = "46")]
		public sealed override System.Type GetElementType()
		{
			return null;
		}

		// Token: 0x06002559 RID: 9561
		[Token(Token = "0x6002559")]
		public abstract override int GetArrayRank();

		// Token: 0x0600255A RID: 9562
		[Token(Token = "0x600255A")]
		public abstract override System.Type GetGenericTypeDefinition();

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x0600255B RID: 9563
		[Token(Token = "0x17000516")]
		public abstract override System.Type[] GenericTypeArguments { [Token(Token = "0x600255B")] get; }

		// Token: 0x0600255C RID: 9564
		[Token(Token = "0x600255C")]
		public abstract override System.Type[] GetGenericArguments();

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x0600255D RID: 9565
		[Token(Token = "0x17000517")]
		public abstract override int GenericParameterPosition { [Token(Token = "0x600255D")] get; }

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x0600255E RID: 9566
		[Token(Token = "0x17000518")]
		internal abstract SignatureType ElementType { [Token(Token = "0x600255E")] get; }

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x0600255F RID: 9567 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000519")]
		public sealed override System.Type UnderlyingSystemType
		{
			[Token(Token = "0x600255F")]
			[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "30")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06002560 RID: 9568
		[Token(Token = "0x1700051A")]
		public abstract override string Name { [Token(Token = "0x6002560")] get; }

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06002561 RID: 9569
		[Token(Token = "0x1700051B")]
		public abstract override string Namespace { [Token(Token = "0x6002561")] get; }

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06002562 RID: 9570 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700051C")]
		public sealed override string FullName
		{
			[Token(Token = "0x6002562")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06002563 RID: 9571 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700051D")]
		public sealed override string AssemblyQualifiedName
		{
			[Token(Token = "0x6002563")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002564 RID: 9572
		[Token(Token = "0x6002564")]
		public abstract override string ToString();

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06002565 RID: 9573 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700051E")]
		public sealed override Assembly Assembly
		{
			[Token(Token = "0x6002565")]
			[Address(RVA = "0x4BE9180", Offset = "0x4BE7D80", VA = "0x184BE9180", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06002566 RID: 9574 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700051F")]
		public sealed override Module Module
		{
			[Token(Token = "0x6002566")]
			[Address(RVA = "0x4BE94F0", Offset = "0x4BE80F0", VA = "0x184BE94F0", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06002567 RID: 9575 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000520")]
		public sealed override System.Type ReflectedType
		{
			[Token(Token = "0x6002567")]
			[Address(RVA = "0x4BE9550", Offset = "0x4BE8150", VA = "0x184BE9550", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06002568 RID: 9576 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000521")]
		public sealed override System.Type BaseType
		{
			[Token(Token = "0x6002568")]
			[Address(RVA = "0x4BE91E0", Offset = "0x4BE7DE0", VA = "0x184BE91E0", Slot = "116")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002569")]
		[Address(RVA = "0x4BE8580", Offset = "0x4BE7180", VA = "0x184BE8580", Slot = "121")]
		public sealed override System.Type[] GetInterfaces()
		{
			return null;
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x00014FA0 File Offset: 0x000131A0
		[Token(Token = "0x600256A")]
		[Address(RVA = "0x4BE8A00", Offset = "0x4BE7600", VA = "0x184BE8A00", Slot = "22")]
		public sealed override bool IsAssignableFrom(System.Type c)
		{
			return default(bool);
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x0600256B RID: 9579 RVA: 0x00014FB8 File Offset: 0x000131B8
		[Token(Token = "0x17000522")]
		public sealed override int MetadataToken
		{
			[Token(Token = "0x600256B")]
			[Address(RVA = "0x4BE9490", Offset = "0x4BE8090", VA = "0x184BE9490", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x0600256C RID: 9580 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000523")]
		public sealed override System.Type DeclaringType
		{
			[Token(Token = "0x600256C")]
			[Address(RVA = "0x4BE92A0", Offset = "0x4BE7EA0", VA = "0x184BE92A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x0600256D RID: 9581 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000524")]
		public sealed override MethodBase DeclaringMethod
		{
			[Token(Token = "0x600256D")]
			[Address(RVA = "0x4BE9240", Offset = "0x4BE7E40", VA = "0x184BE9240", Slot = "29")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600256E")]
		[Address(RVA = "0x4BE84C0", Offset = "0x4BE70C0", VA = "0x184BE84C0", Slot = "53")]
		public sealed override System.Type[] GetGenericParameterConstraints()
		{
			return null;
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x0600256F RID: 9583 RVA: 0x00014FD0 File Offset: 0x000131D0
		[Token(Token = "0x17000525")]
		public sealed override GenericParameterAttributes GenericParameterAttributes
		{
			[Token(Token = "0x600256F")]
			[Address(RVA = "0x4BE9300", Offset = "0x4BE7F00", VA = "0x184BE9300", Slot = "52")]
			get
			{
				return GenericParameterAttributes.None;
			}
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x00014FE8 File Offset: 0x000131E8
		[Token(Token = "0x6002570")]
		[Address(RVA = "0x4BE8B80", Offset = "0x4BE7780", VA = "0x184BE8B80", Slot = "16")]
		public sealed override bool IsEnumDefined(object value)
		{
			return default(bool);
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002571")]
		[Address(RVA = "0x4BE81C0", Offset = "0x4BE6DC0", VA = "0x184BE81C0", Slot = "17")]
		public sealed override string GetEnumName(object value)
		{
			return null;
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002572")]
		[Address(RVA = "0x4BE8220", Offset = "0x4BE6E20", VA = "0x184BE8220", Slot = "18")]
		public sealed override string[] GetEnumNames()
		{
			return null;
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002573")]
		[Address(RVA = "0x4BE8280", Offset = "0x4BE6E80", VA = "0x184BE8280", Slot = "124")]
		public sealed override System.Type GetEnumUnderlyingType()
		{
			return null;
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002574")]
		[Address(RVA = "0x4BE82E0", Offset = "0x4BE6EE0", VA = "0x184BE82E0", Slot = "125")]
		public sealed override System.Array GetEnumValues()
		{
			return null;
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x00015000 File Offset: 0x00013200
		[Token(Token = "0x6002575")]
		[Address(RVA = "0x4BE8940", Offset = "0x4BE7540", VA = "0x184BE8940", Slot = "115")]
		protected sealed override System.TypeCode GetTypeCodeImpl()
		{
			return System.TypeCode.Empty;
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x00015018 File Offset: 0x00013218
		[Token(Token = "0x6002576")]
		[Address(RVA = "0x4BE7FA0", Offset = "0x4BE6BA0", VA = "0x184BE7FA0", Slot = "55")]
		protected sealed override TypeAttributes GetAttributeFlagsImpl()
		{
			return TypeAttributes.NotPublic;
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002577")]
		[Address(RVA = "0x4BE8060", Offset = "0x4BE6C60", VA = "0x184BE8060", Slot = "82")]
		public sealed override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002578")]
		[Address(RVA = "0x4BE8340", Offset = "0x4BE6F40", VA = "0x184BE8340", Slot = "84")]
		public sealed override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002579")]
		[Address(RVA = "0x4BE83A0", Offset = "0x4BE6FA0", VA = "0x184BE83A0", Slot = "85")]
		public sealed override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600257A")]
		[Address(RVA = "0x4BE8400", Offset = "0x4BE7000", VA = "0x184BE8400", Slot = "87")]
		public sealed override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600257B")]
		[Address(RVA = "0x4BE8460", Offset = "0x4BE7060", VA = "0x184BE8460", Slot = "89")]
		public sealed override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600257C")]
		[Address(RVA = "0x4BE86A0", Offset = "0x4BE72A0", VA = "0x184BE86A0", Slot = "93")]
		public sealed override MemberInfo[] GetMembers(BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600257D")]
		[Address(RVA = "0x4BE8760", Offset = "0x4BE7360", VA = "0x184BE8760", Slot = "102")]
		public sealed override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600257E")]
		[Address(RVA = "0x4BE87C0", Offset = "0x4BE73C0", VA = "0x184BE87C0", Slot = "103")]
		public sealed override System.Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600257F")]
		[Address(RVA = "0x4BE8820", Offset = "0x4BE7420", VA = "0x184BE8820", Slot = "104")]
		public sealed override System.Type[] GetNestedTypes(BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002580")]
		[Address(RVA = "0x4BE8880", Offset = "0x4BE7480", VA = "0x184BE8880", Slot = "113")]
		public sealed override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002581")]
		[Address(RVA = "0x4BE89A0", Offset = "0x4BE75A0", VA = "0x184BE89A0", Slot = "118")]
		public sealed override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] namedParameters)
		{
			return null;
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002582")]
		[Address(RVA = "0x4BE8700", Offset = "0x4BE7300", VA = "0x184BE8700", Slot = "100")]
		protected sealed override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, System.Type[] types, ParameterModifier[] modifiers)
		{
			return null;
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002583")]
		[Address(RVA = "0x4BE88E0", Offset = "0x4BE74E0", VA = "0x184BE88E0", Slot = "111")]
		protected sealed override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, System.Type returnType, System.Type[] types, ParameterModifier[] modifiers)
		{
			return null;
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002584")]
		[Address(RVA = "0x4BE8640", Offset = "0x4BE7240", VA = "0x184BE8640", Slot = "91")]
		public sealed override MemberInfo[] GetMember(string name, BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002585")]
		[Address(RVA = "0x4BE85E0", Offset = "0x4BE71E0", VA = "0x184BE85E0", Slot = "92")]
		public sealed override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			return null;
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002586")]
		[Address(RVA = "0x4BE80C0", Offset = "0x4BE6CC0", VA = "0x184BE80C0", Slot = "13")]
		public sealed override object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002587")]
		[Address(RVA = "0x4BE8120", Offset = "0x4BE6D20", VA = "0x184BE8120", Slot = "14")]
		public sealed override object[] GetCustomAttributes(System.Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x00015030 File Offset: 0x00013230
		[Token(Token = "0x6002588")]
		[Address(RVA = "0x4BE8B20", Offset = "0x4BE7720", VA = "0x184BE8B20", Slot = "12")]
		public sealed override bool IsDefined(System.Type attributeType, bool inherit)
		{
			return default(bool);
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002589")]
		[Address(RVA = "0x4BE8520", Offset = "0x4BE7120", VA = "0x184BE8520", Slot = "120")]
		public sealed override System.Type GetInterface(string name, bool ignoreCase)
		{
			return null;
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600258A")]
		[Address(RVA = "0x4BE8000", Offset = "0x4BE6C00", VA = "0x184BE8000", Slot = "80")]
		protected sealed override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, System.Type[] types, ParameterModifier[] modifiers)
		{
			return null;
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x00015048 File Offset: 0x00013248
		[Token(Token = "0x600258B")]
		[Address(RVA = "0x4BE8A60", Offset = "0x4BE7660", VA = "0x184BE8A60", Slot = "65")]
		protected sealed override bool IsCOMObjectImpl()
		{
			return default(bool);
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x00015060 File Offset: 0x00013260
		[Token(Token = "0x600258C")]
		[Address(RVA = "0x4BE8D00", Offset = "0x4BE7900", VA = "0x184BE8D00", Slot = "73")]
		protected sealed override bool IsPrimitiveImpl()
		{
			return default(bool);
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x00015078 File Offset: 0x00013278
		[Token(Token = "0x600258D")]
		[Address(RVA = "0x4BE8AC0", Offset = "0x4BE76C0", VA = "0x184BE8AC0", Slot = "67")]
		protected sealed override bool IsContextfulImpl()
		{
			return default(bool);
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x0600258E RID: 9614 RVA: 0x00015090 File Offset: 0x00013290
		[Token(Token = "0x17000526")]
		public sealed override bool IsEnum
		{
			[Token(Token = "0x600258E")]
			[Address(RVA = "0x4BE9360", Offset = "0x4BE7F60", VA = "0x184BE9360", Slot = "69")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600258F RID: 9615 RVA: 0x000150A8 File Offset: 0x000132A8
		[Token(Token = "0x600258F")]
		[Address(RVA = "0x4BE8BE0", Offset = "0x4BE77E0", VA = "0x184BE8BE0", Slot = "123")]
		public sealed override bool IsEquivalentTo(System.Type other)
		{
			return default(bool);
		}

		// Token: 0x06002590 RID: 9616 RVA: 0x000150C0 File Offset: 0x000132C0
		[Token(Token = "0x6002590")]
		[Address(RVA = "0x4BE8C40", Offset = "0x4BE7840", VA = "0x184BE8C40", Slot = "122")]
		public sealed override bool IsInstanceOfType(object o)
		{
			return default(bool);
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x000150D8 File Offset: 0x000132D8
		[Token(Token = "0x6002591")]
		[Address(RVA = "0x4BE8CA0", Offset = "0x4BE78A0", VA = "0x184BE8CA0", Slot = "71")]
		protected sealed override bool IsMarshalByRefImpl()
		{
			return default(bool);
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06002592 RID: 9618 RVA: 0x000150F0 File Offset: 0x000132F0
		[Token(Token = "0x17000527")]
		public sealed override bool IsSerializable
		{
			[Token(Token = "0x6002592")]
			[Address(RVA = "0x4BE9430", Offset = "0x4BE8030", VA = "0x184BE9430", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x00015108 File Offset: 0x00013308
		[Token(Token = "0x6002593")]
		[Address(RVA = "0x4BE8D60", Offset = "0x4BE7960", VA = "0x184BE8D60", Slot = "21")]
		public sealed override bool IsSubclassOf(System.Type c)
		{
			return default(bool);
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x00015120 File Offset: 0x00013320
		[Token(Token = "0x6002594")]
		[Address(RVA = "0x4BE8DC0", Offset = "0x4BE79C0", VA = "0x184BE8DC0", Slot = "75")]
		protected sealed override bool IsValueTypeImpl()
		{
			return default(bool);
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06002595 RID: 9621 RVA: 0x00015138 File Offset: 0x00013338
		[Token(Token = "0x17000528")]
		public sealed override System.RuntimeTypeHandle TypeHandle
		{
			[Token(Token = "0x6002595")]
			[Address(RVA = "0x4BE95B0", Offset = "0x4BE81B0", VA = "0x184BE95B0", Slot = "114")]
			get
			{
				return default(System.RuntimeTypeHandle);
			}
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002596")]
		[Address(RVA = "0x4BE9130", Offset = "0x4BE7D30", VA = "0x184BE9130")]
		protected SignatureType()
		{
		}
	}
}
