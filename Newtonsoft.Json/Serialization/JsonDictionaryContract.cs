using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000A1 RID: 161
	[Token(Token = "0x20000A1")]
	[Preserve]
	public class JsonDictionaryContract : JsonContainerContract
	{
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000F6")]
		[Obsolete("PropertyNameResolver is obsolete. Use DictionaryKeyResolver instead.")]
		public Func<string, string> PropertyNameResolver
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x20BBCF0", Offset = "0x20BA8F0", VA = "0x1820BBCF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x22F8A50", Offset = "0x22F7650", VA = "0x1822F8A50")]
			set
			{
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000F7")]
		public Func<string, string> DictionaryKeyResolver
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x20BBCF0", Offset = "0x20BA8F0", VA = "0x1820BBCF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x22F8A50", Offset = "0x22F7650", VA = "0x1822F8A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000F8")]
		public Type DictionaryKeyType
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x789430", Offset = "0x788030", VA = "0x180789430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x789470", Offset = "0x788070", VA = "0x180789470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000F9")]
		public Type DictionaryValueType
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0xF0A850", Offset = "0xF09450", VA = "0x180F0A850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600058F")]
			[Address(RVA = "0xF0A890", Offset = "0xF09490", VA = "0x180F0A890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000FA")]
		internal JsonContract KeyContract
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x2569110", Offset = "0x2567D10", VA = "0x182569110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x4D6CA00", Offset = "0x4D6B600", VA = "0x184D6CA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x000042F0 File Offset: 0x000024F0
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000FB")]
		internal bool ShouldCreateWrapper
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x4DA7710", Offset = "0x4DA6310", VA = "0x184DA7710")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x4DA7730", Offset = "0x4DA6330", VA = "0x184DA7730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000FC")]
		internal ObjectConstructor<object> ParameterizedCreator
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x4DA7650", Offset = "0x4DA6250", VA = "0x184DA7650")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000FD")]
		public ObjectConstructor<object> OverrideCreator
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x22F8830", Offset = "0x22F7430", VA = "0x1822F8830")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x22F8A30", Offset = "0x22F7630", VA = "0x1822F8A30")]
			set
			{
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00004308 File Offset: 0x00002508
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000FE")]
		public bool HasParameterizedCreator
		{
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x4DA7640", Offset = "0x4DA6240", VA = "0x184DA7640")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x4DA7720", Offset = "0x4DA6320", VA = "0x184DA7720")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00004320 File Offset: 0x00002520
		[Token(Token = "0x170000FF")]
		internal bool HasParameterizedCreatorInternal
		{
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x4DA7610", Offset = "0x4DA6210", VA = "0x184DA7610")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x4DA6EC0", Offset = "0x4DA5AC0", VA = "0x184DA6EC0")]
		public JsonDictionaryContract(Type underlyingType)
		{
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x4DA6B40", Offset = "0x4DA5740", VA = "0x184DA6B40")]
		internal IWrappedDictionary CreateWrapper(object dictionary)
		{
			return null;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x4DA6880", Offset = "0x4DA5480", VA = "0x184DA6880")]
		internal IDictionary CreateTemporaryDictionary()
		{
			return null;
		}

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0xE0")]
		private readonly Type _genericCollectionDefinitionType;

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0xE8")]
		private Type _genericWrapperType;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0xF0")]
		private ObjectConstructor<object> _genericWrapperCreator;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0xF8")]
		private Func<object> _genericTemporaryDictionaryCreator;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x108")]
		private readonly ConstructorInfo _parameterizedConstructor;

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x110")]
		private ObjectConstructor<object> _overrideCreator;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x118")]
		private ObjectConstructor<object> _parameterizedCreator;
	}
}
