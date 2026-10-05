using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000A5 RID: 165
	[Token(Token = "0x20000A5")]
	[Preserve]
	public class JsonObjectContract : JsonContainerContract
	{
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x000044B8 File Offset: 0x000026B8
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700011E")]
		public MemberSerialization MemberSerialization
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x789280", Offset = "0x787E80", VA = "0x180789280")]
			[CompilerGenerated]
			get
			{
				return MemberSerialization.OptOut;
			}
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x789440", Offset = "0x788040", VA = "0x180789440")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x000044D0 File Offset: 0x000026D0
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700011F")]
		public Required? ItemRequired
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x4DA8710", Offset = "0x4DA7310", VA = "0x184DA8710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x4DA8800", Offset = "0x4DA7400", VA = "0x184DA8800")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000120")]
		public JsonPropertyCollection Properties
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0xF0A850", Offset = "0xF09450", VA = "0x180F0A850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xF0A890", Offset = "0xF09490", VA = "0x180F0A890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000121")]
		[Obsolete("ConstructorParameters is obsolete. Use CreatorParameters instead.")]
		public JsonPropertyCollection ConstructorParameters
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x4DA8380", Offset = "0x4DA6F80", VA = "0x184DA8380")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000122")]
		public JsonPropertyCollection CreatorParameters
		{
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x4DA8390", Offset = "0x4DA6F90", VA = "0x184DA8390")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000123")]
		[Obsolete("OverrideConstructor is obsolete. Use OverrideCreator instead.")]
		public ConstructorInfo OverrideConstructor
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x4D6C800", Offset = "0x4D6B400", VA = "0x184D6C800")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x4DA8810", Offset = "0x4DA7410", VA = "0x184DA8810")]
			set
			{
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000124")]
		[Obsolete("ParametrizedConstructor is obsolete. Use OverrideCreator instead.")]
		public ConstructorInfo ParametrizedConstructor
		{
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x4D6C780", Offset = "0x4D6B380", VA = "0x184D6C780")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x4DA8920", Offset = "0x4DA7520", VA = "0x184DA8920")]
			set
			{
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000125")]
		public ObjectConstructor<object> OverrideCreator
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x22F8880", Offset = "0x22F7480", VA = "0x1822F8880")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x4DA88E0", Offset = "0x4DA74E0", VA = "0x184DA88E0")]
			set
			{
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000126")]
		internal ObjectConstructor<object> ParameterizedCreator
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x22F8840", Offset = "0x22F7440", VA = "0x1822F8840")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000127")]
		public ExtensionDataSetter ExtensionDataSetter
		{
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x2569110", Offset = "0x2567D10", VA = "0x182569110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x4D6CA00", Offset = "0x4D6B600", VA = "0x184D6CA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060005F9 RID: 1529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000128")]
		public ExtensionDataGetter ExtensionDataGetter
		{
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x371A260", Offset = "0x3718E60", VA = "0x18371A260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x371A3C0", Offset = "0x3718FC0", VA = "0x18371A3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060005FB RID: 1531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000129")]
		public Type ExtensionDataValueType
		{
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0xF0A870", Offset = "0xF09470", VA = "0x180F0A870")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x4DA8720", Offset = "0x4DA7320", VA = "0x184DA8720")]
			set
			{
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x000044E8 File Offset: 0x000026E8
		[Token(Token = "0x1700012A")]
		internal bool HasRequiredOrDefaultValueProperties
		{
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x4DA8420", Offset = "0x4DA7020", VA = "0x184DA8420")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x4DA82E0", Offset = "0x4DA6EE0", VA = "0x184DA82E0")]
		public JsonObjectContract(Type underlyingType)
		{
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x4DA81D0", Offset = "0x4DA6DD0", VA = "0x184DA81D0")]
		internal object GetUninitializedObject()
		{
			return null;
		}

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0xE8")]
		internal bool ExtensionDataIsJToken;

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0xE9")]
		private bool? _hasRequiredOrDefaultValueProperties;

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0xF0")]
		private ConstructorInfo _parametrizedConstructor;

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0xF8")]
		private ConstructorInfo _overrideConstructor;

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x100")]
		private ObjectConstructor<object> _overrideCreator;

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x108")]
		private ObjectConstructor<object> _parameterizedCreator;

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x110")]
		private JsonPropertyCollection _creatorParameters;

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x118")]
		private Type _extensionDataValueType;
	}
}
