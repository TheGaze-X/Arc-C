using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace FullInspector.Internal
{
	// Token: 0x02007CAE RID: 31918
	[Token(Token = "0x2007CAE")]
	public static class fiInstalledSerializerManager
	{
		// Token: 0x0602C94F RID: 182607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C94F")]
		[Address(RVA = "0x286AC10", Offset = "0x2869810", VA = "0x18286AC10")]
		private static fiISerializerMetadata GetProvider(Type type)
		{
			return null;
		}

		// Token: 0x0602C950 RID: 182608 RVA: 0x000E0F58 File Offset: 0x000DF158
		[Token(Token = "0x602C950")]
		[Address(RVA = "0x286AF10", Offset = "0x2869B10", VA = "0x18286AF10")]
		public static bool TryGetLoadedSerializerType(out fiILoadedSerializers serializers)
		{
			return default(bool);
		}

		// Token: 0x17006858 RID: 26712
		// (get) Token: 0x0602C952 RID: 182610 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C953 RID: 182611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006858")]
		public static List<fiISerializerMetadata> LoadedMetadata
		{
			[Token(Token = "0x602C952")]
			[Address(RVA = "0x286BC40", Offset = "0x286A840", VA = "0x18286BC40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602C953")]
			[Address(RVA = "0x286BD30", Offset = "0x286A930", VA = "0x18286BD30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006859 RID: 26713
		// (get) Token: 0x0602C954 RID: 182612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006859")]
		public static fiISerializerMetadata DefaultMetadata
		{
			[Token(Token = "0x602C954")]
			[Address(RVA = "0x286BB10", Offset = "0x286A710", VA = "0x18286BB10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C955 RID: 182613 RVA: 0x000E0F70 File Offset: 0x000DF170
		[Token(Token = "0x602C955")]
		[Address(RVA = "0x286AC80", Offset = "0x2869880", VA = "0x18286AC80")]
		public static bool IsLoaded(Guid serializerGuid)
		{
			return default(bool);
		}

		// Token: 0x1700685A RID: 26714
		// (get) Token: 0x0602C956 RID: 182614 RVA: 0x000E0F88 File Offset: 0x000DF188
		[Token(Token = "0x1700685A")]
		public static bool HasDefault
		{
			[Token(Token = "0x602C956")]
			[Address(RVA = "0x286BBE0", Offset = "0x286A7E0", VA = "0x18286BBE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700685B RID: 26715
		// (get) Token: 0x0602C957 RID: 182615 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C958 RID: 182616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700685B")]
		public static Type[] SerializationOptInAnnotations
		{
			[Token(Token = "0x602C957")]
			[Address(RVA = "0x286BC90", Offset = "0x286A890", VA = "0x18286BC90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602C958")]
			[Address(RVA = "0x286BDA0", Offset = "0x286A9A0", VA = "0x18286BDA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700685C RID: 26716
		// (get) Token: 0x0602C959 RID: 182617 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C95A RID: 182618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700685C")]
		public static Type[] SerializationOptOutAnnotations
		{
			[Token(Token = "0x602C959")]
			[Address(RVA = "0x286BCE0", Offset = "0x286A8E0", VA = "0x18286BCE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602C95A")]
			[Address(RVA = "0x286BE10", Offset = "0x286AA10", VA = "0x18286BE10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x040403D5 RID: 263125
		[Token(Token = "0x40403D5")]
		public const string GeneratedTypeName = "fiLoadedSerializers";

		// Token: 0x040403D7 RID: 263127
		[Token(Token = "0x40403D7")]
		[FieldOffset(Offset = "0x8")]
		private static fiISerializerMetadata _defaultMetadata;
	}
}
