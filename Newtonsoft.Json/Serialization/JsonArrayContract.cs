using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000098")]
	[Preserve]
	public class JsonArrayContract : JsonContainerContract
	{
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000DC")]
		public Type CollectionItemType
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x20BBCF0", Offset = "0x20BA8F0", VA = "0x1820BBCF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x22F8A50", Offset = "0x22F7650", VA = "0x1822F8A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x00004230 File Offset: 0x00002430
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000DD")]
		public bool IsMultidimensionalArray
		{
			[Token(Token = "0x600053E")]
			[Address(RVA = "0x371A210", Offset = "0x3718E10", VA = "0x18371A210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x371A3B0", Offset = "0x3718FB0", VA = "0x18371A3B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x00004248 File Offset: 0x00002448
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000DE")]
		internal bool IsArray
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x42BAC50", Offset = "0x42B9850", VA = "0x1842BAC50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x42BAC70", Offset = "0x42B9870", VA = "0x1842BAC70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x00004260 File Offset: 0x00002460
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000DF")]
		internal bool ShouldCreateWrapper
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x42BAC40", Offset = "0x42B9840", VA = "0x1842BAC40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x42BAC60", Offset = "0x42B9860", VA = "0x1842BAC60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x00004278 File Offset: 0x00002478
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000E0")]
		internal bool CanDeserialize
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x4DA4E80", Offset = "0x4DA3A80", VA = "0x184DA4E80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000545")]
			[Address(RVA = "0x4DA4F90", Offset = "0x4DA3B90", VA = "0x184DA4F90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E1")]
		internal ObjectConstructor<object> ParameterizedCreator
		{
			[Token(Token = "0x6000546")]
			[Address(RVA = "0x4DA4ED0", Offset = "0x4DA3AD0", VA = "0x184DA4ED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000E2")]
		public ObjectConstructor<object> OverrideCreator
		{
			[Token(Token = "0x6000547")]
			[Address(RVA = "0x22F8840", Offset = "0x22F7440", VA = "0x1822F8840")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x4DA4FB0", Offset = "0x4DA3BB0", VA = "0x184DA4FB0")]
			set
			{
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00004290 File Offset: 0x00002490
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000E3")]
		public bool HasParameterizedCreator
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x4DA4EC0", Offset = "0x4DA3AC0", VA = "0x184DA4EC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600054A")]
			[Address(RVA = "0x4DA4FA0", Offset = "0x4DA3BA0", VA = "0x184DA4FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x000042A8 File Offset: 0x000024A8
		[Token(Token = "0x170000E4")]
		internal bool HasParameterizedCreatorInternal
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x4DA4E90", Offset = "0x4DA3A90", VA = "0x184DA4E90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x4DA4400", Offset = "0x4DA3000", VA = "0x184DA4400")]
		public JsonArrayContract(Type underlyingType)
		{
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x4DA3F40", Offset = "0x4DA2B40", VA = "0x184DA3F40")]
		internal IWrappedCollection CreateWrapper(object list)
		{
			return null;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x4DA3D00", Offset = "0x4DA2900", VA = "0x184DA3D00")]
		internal IList CreateTemporaryCollection()
		{
			return null;
		}

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0xD0")]
		private readonly Type _genericCollectionDefinitionType;

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0xD8")]
		private Type _genericWrapperType;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0xE0")]
		private ObjectConstructor<object> _genericWrapperCreator;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0xE8")]
		private Func<object> _genericTemporaryCollectionCreator;

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0xF8")]
		private readonly ConstructorInfo _parameterizedConstructor;

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x100")]
		private ObjectConstructor<object> _parameterizedCreator;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x108")]
		private ObjectConstructor<object> _overrideCreator;
	}
}
