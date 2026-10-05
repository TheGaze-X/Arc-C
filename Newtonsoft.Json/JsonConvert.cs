using System;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	[Preserve]
	public static class JsonConvert
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000064")]
		public static Func<JsonSerializerSettings> DefaultSettings
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x4D658D0", Offset = "0x4D644D0", VA = "0x184D658D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x4D65920", Offset = "0x4D64520", VA = "0x184D65920")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x4D61E30", Offset = "0x4D60A30", VA = "0x184D61E30")]
		internal static JsonSerializerSettings GetDefaultSettings()
		{
			return null;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x4D65270", Offset = "0x4D63E70", VA = "0x184D65270")]
		public static string ToString(DateTime value)
		{
			return null;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x4D64A00", Offset = "0x4D63600", VA = "0x184D64A00")]
		public static string ToString(DateTime value, DateFormatHandling format, DateTimeZoneHandling timeZoneHandling)
		{
			return null;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x4D652C0", Offset = "0x4D63EC0", VA = "0x184D652C0")]
		public static string ToString(DateTimeOffset value)
		{
			return null;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x4D645D0", Offset = "0x4D631D0", VA = "0x184D645D0")]
		public static string ToString(DateTimeOffset value, DateFormatHandling format)
		{
			return null;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x4D64970", Offset = "0x4D63570", VA = "0x184D64970")]
		public static string ToString(bool value)
		{
			return null;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x4D63330", Offset = "0x4D61F30", VA = "0x184D63330")]
		public static string ToString(char value)
		{
			return null;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x4D65580", Offset = "0x4D64180", VA = "0x184D65580")]
		public static string ToString(Enum value)
		{
			return null;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x4D633B0", Offset = "0x4D61FB0", VA = "0x184D633B0")]
		public static string ToString(int value)
		{
			return null;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x4D64C20", Offset = "0x4D63820", VA = "0x184D64C20")]
		public static string ToString(short value)
		{
			return null;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x4D64C80", Offset = "0x4D63880", VA = "0x184D64C80")]
		[CLSCompliant(false)]
		public static string ToString(ushort value)
		{
			return null;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x4D64CE0", Offset = "0x4D638E0", VA = "0x184D64CE0")]
		[CLSCompliant(false)]
		public static string ToString(uint value)
		{
			return null;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x4D65150", Offset = "0x4D63D50", VA = "0x184D65150")]
		public static string ToString(long value)
		{
			return null;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x4D632D0", Offset = "0x4D61ED0", VA = "0x184D632D0")]
		[CLSCompliant(false)]
		public static string ToString(ulong value)
		{
			return null;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x4D648B0", Offset = "0x4D634B0", VA = "0x184D648B0")]
		public static string ToString(float value)
		{
			return null;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x4D64FF0", Offset = "0x4D63BF0", VA = "0x184D64FF0")]
		internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return null;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x4D61CF0", Offset = "0x4D608F0", VA = "0x184D61CF0")]
		private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return null;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x4D651B0", Offset = "0x4D63DB0", VA = "0x184D651B0")]
		public static string ToString(double value)
		{
			return null;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x4D653F0", Offset = "0x4D63FF0", VA = "0x184D653F0")]
		internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return null;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x4D61B30", Offset = "0x4D60730", VA = "0x184D61B30")]
		private static string EnsureDecimalPlace(double value, string text)
		{
			return null;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x4D61C80", Offset = "0x4D60880", VA = "0x184D61C80")]
		private static string EnsureDecimalPlace(string text)
		{
			return null;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x4D64570", Offset = "0x4D63170", VA = "0x184D64570")]
		public static string ToString(byte value)
		{
			return null;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x4D650F0", Offset = "0x4D63CF0", VA = "0x184D650F0")]
		[CLSCompliant(false)]
		public static string ToString(sbyte value)
		{
			return null;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x4D630C0", Offset = "0x4D61CC0", VA = "0x184D630C0")]
		public static string ToString(decimal value)
		{
			return null;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x4D631C0", Offset = "0x4D61DC0", VA = "0x184D631C0")]
		public static string ToString(Guid value)
		{
			return null;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x4D65320", Offset = "0x4D63F20", VA = "0x184D65320")]
		internal static string ToString(Guid value, char quoteChar)
		{
			return null;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x4D64EC0", Offset = "0x4D63AC0", VA = "0x184D64EC0")]
		public static string ToString(TimeSpan value)
		{
			return null;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x4D654F0", Offset = "0x4D640F0", VA = "0x184D654F0")]
		internal static string ToString(TimeSpan value, char quoteChar)
		{
			return null;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x4D64D40", Offset = "0x4D63940", VA = "0x184D64D40")]
		public static string ToString(Uri value)
		{
			return null;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x4D644F0", Offset = "0x4D630F0", VA = "0x184D644F0")]
		internal static string ToString(Uri value, char quoteChar)
		{
			return null;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x4D647F0", Offset = "0x4D633F0", VA = "0x184D647F0")]
		public static string ToString(string value)
		{
			return null;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x4D643E0", Offset = "0x4D62FE0", VA = "0x184D643E0")]
		public static string ToString(string value, char delimiter)
		{
			return null;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x4D642F0", Offset = "0x4D62EF0", VA = "0x184D642F0")]
		public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling)
		{
			return null;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x4D63410", Offset = "0x4D62010", VA = "0x184D63410")]
		public static string ToString(object value)
		{
			return null;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x4D625A0", Offset = "0x4D611A0", VA = "0x184D625A0")]
		public static string SerializeObject(object value)
		{
			return null;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x4D62640", Offset = "0x4D61240", VA = "0x184D62640")]
		public static string SerializeObject(object value, Formatting formatting)
		{
			return null;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x4D62490", Offset = "0x4D61090", VA = "0x184D62490")]
		public static string SerializeObject(object value, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x4D62760", Offset = "0x4D61360", VA = "0x184D62760")]
		public static string SerializeObject(object value, Formatting formatting, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x4D62900", Offset = "0x4D61500", VA = "0x184D62900")]
		public static string SerializeObject(object value, JsonSerializerSettings settings)
		{
			return null;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x4D62400", Offset = "0x4D61000", VA = "0x184D62400")]
		public static string SerializeObject(object value, Type type, JsonSerializerSettings settings)
		{
			return null;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x4D626E0", Offset = "0x4D612E0", VA = "0x184D626E0")]
		public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings)
		{
			return null;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x4D62830", Offset = "0x4D61430", VA = "0x184D62830")]
		public static string SerializeObject(object value, Type type, Formatting formatting, JsonSerializerSettings settings)
		{
			return null;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x4D62150", Offset = "0x4D60D50", VA = "0x184D62150")]
		private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer)
		{
			return null;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x4D614E0", Offset = "0x4D600E0", VA = "0x184D614E0")]
		public static object DeserializeObject(string value)
		{
			return null;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x4D61260", Offset = "0x4D5FE60", VA = "0x184D61260")]
		public static object DeserializeObject(string value, JsonSerializerSettings settings)
		{
			return null;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x4D61530", Offset = "0x4D60130", VA = "0x184D61530")]
		public static object DeserializeObject(string value, Type type)
		{
			return null;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D2")]
		public static T DeserializeObject<T>(string value)
		{
			return null;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D3")]
		public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject)
		{
			return null;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D4")]
		public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject, JsonSerializerSettings settings)
		{
			return null;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D5")]
		public static T DeserializeObject<T>(string value, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D6")]
		public static T DeserializeObject<T>(string value, JsonSerializerSettings settings)
		{
			return null;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x4D61190", Offset = "0x4D5FD90", VA = "0x184D61190")]
		public static object DeserializeObject(string value, Type type, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x4D612C0", Offset = "0x4D5FEC0", VA = "0x184D612C0")]
		public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings)
		{
			return null;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x4D620F0", Offset = "0x4D60CF0", VA = "0x184D620F0")]
		public static void PopulateObject(string value, object target)
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x4D61E80", Offset = "0x4D60A80", VA = "0x184D61E80")]
		public static void PopulateObject(string value, object target, JsonSerializerSettings settings)
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x4D62D70", Offset = "0x4D61970", VA = "0x184D62D70")]
		public static string SerializeXmlNode(XmlNode node)
		{
			return null;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x4D62FB0", Offset = "0x4D61BB0", VA = "0x184D62FB0")]
		public static string SerializeXmlNode(XmlNode node, Formatting formatting)
		{
			return null;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x4D62EA0", Offset = "0x4D61AA0", VA = "0x184D62EA0")]
		public static string SerializeXmlNode(XmlNode node, Formatting formatting, bool omitRootObject)
		{
			return null;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x4D61A50", Offset = "0x4D60650", VA = "0x184D61A50")]
		public static XmlDocument DeserializeXmlNode(string value)
		{
			return null;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x4D61AD0", Offset = "0x4D606D0", VA = "0x184D61AD0")]
		public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName)
		{
			return null;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x4D61860", Offset = "0x4D60460", VA = "0x184D61860")]
		public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute)
		{
			return null;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x4D629C0", Offset = "0x4D615C0", VA = "0x184D629C0")]
		public static string SerializeXNode(XObject node)
		{
			return null;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x4D62C30", Offset = "0x4D61830", VA = "0x184D62C30")]
		public static string SerializeXNode(XObject node, Formatting formatting)
		{
			return null;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x4D62B20", Offset = "0x4D61720", VA = "0x184D62B20")]
		public static string SerializeXNode(XObject node, Formatting formatting, bool omitRootObject)
		{
			return null;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x4D617E0", Offset = "0x4D603E0", VA = "0x184D617E0")]
		public static XDocument DeserializeXNode(string value)
		{
			return null;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x4D61780", Offset = "0x4D60380", VA = "0x184D61780")]
		public static XDocument DeserializeXNode(string value, string deserializeRootElementName)
		{
			return null;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x4D61590", Offset = "0x4D60190", VA = "0x184D61590")]
		public static XDocument DeserializeXNode(string value, string deserializeRootElementName, bool writeArrayAttribute)
		{
			return null;
		}

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string True;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string False;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string Null;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string Undefined;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string PositiveInfinity;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string NegativeInfinity;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x38")]
		public static readonly string NaN;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x40")]
		private static readonly JsonSerializerSettings InitialSerializerSettings;
	}
}
