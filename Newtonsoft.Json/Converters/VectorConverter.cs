using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using UnityEngine;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000105 RID: 261
	[Token(Token = "0x2000105")]
	[Preserve]
	public class VectorConverter : JsonConverter
	{
		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x00005E98 File Offset: 0x00004098
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001D4")]
		public bool EnableVector2
		{
			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A54")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x00005EB0 File Offset: 0x000040B0
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001D5")]
		public bool EnableVector3
		{
			[Token(Token = "0x6000A55")]
			[Address(RVA = "0x4E6310", Offset = "0x4E4F10", VA = "0x1804E6310")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A56")]
			[Address(RVA = "0x4E63F0", Offset = "0x4E4FF0", VA = "0x1804E63F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x00005EC8 File Offset: 0x000040C8
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001D6")]
		public bool EnableVector4
		{
			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x4EEB50", Offset = "0x4ED750", VA = "0x1804EEB50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A58")]
			[Address(RVA = "0x4EEBD0", Offset = "0x4ED7D0", VA = "0x1804EEBD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x4DF1A80", Offset = "0x4DF0680", VA = "0x184DF1A80")]
		public VectorConverter()
		{
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x4DF1A30", Offset = "0x4DF0630", VA = "0x184DF1A30")]
		public VectorConverter(bool enableVector2, bool enableVector3, bool enableVector4)
		{
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x4DF1370", Offset = "0x4DEFF70", VA = "0x184DF1370", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x4DF1690", Offset = "0x4DF0290", VA = "0x184DF1690")]
		private static void WriteVector(JsonWriter writer, float x, float y, float? z, float? w)
		{
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x4DF0EA0", Offset = "0x4DEFAA0", VA = "0x184DF0EA0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00005EE0 File Offset: 0x000040E0
		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x4DF0A30", Offset = "0x4DEF630", VA = "0x184DF0A30", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00005EF8 File Offset: 0x000040F8
		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x4DF0B00", Offset = "0x4DEF700", VA = "0x184DF0B00")]
		private static Vector2 PopulateVector2(JsonReader reader)
		{
			return default(Vector2);
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x00005F10 File Offset: 0x00004110
		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x4DF0C10", Offset = "0x4DEF810", VA = "0x184DF0C10")]
		private static Vector3 PopulateVector3(JsonReader reader)
		{
			return default(Vector3);
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00005F28 File Offset: 0x00004128
		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x4DF0D40", Offset = "0x4DEF940", VA = "0x184DF0D40")]
		private static Vector4 PopulateVector4(JsonReader reader)
		{
			return default(Vector4);
		}

		// Token: 0x04000403 RID: 1027
		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type V2;

		// Token: 0x04000404 RID: 1028
		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type V3;

		// Token: 0x04000405 RID: 1029
		[Token(Token = "0x4000405")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Type V4;
	}
}
