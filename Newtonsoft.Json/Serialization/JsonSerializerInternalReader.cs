using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000A8 RID: 168
	[Token(Token = "0x20000A8")]
	[Preserve]
	internal class JsonSerializerInternalReader : JsonSerializerInternalBase
	{
		// Token: 0x06000607 RID: 1543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x4DA9ED0", Offset = "0x4DA8AD0", VA = "0x184DA9ED0")]
		public JsonSerializerInternalReader(JsonSerializer serializer)
		{
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x4DB3AD0", Offset = "0x4DB26D0", VA = "0x184DB3AD0")]
		public void Populate(JsonReader reader, object target)
		{
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x4DB0330", Offset = "0x4DAEF30", VA = "0x184DB0330")]
		private JsonContract GetContractSafe(Type type)
		{
			return null;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x4DAF5A0", Offset = "0x4DAE1A0", VA = "0x184DAF5A0")]
		public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent)
		{
			return null;
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x4DB0560", Offset = "0x4DAF160", VA = "0x184DB0560")]
		private JsonSerializerProxy GetInternalSerializer()
		{
			return null;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x4DAB720", Offset = "0x4DAA320", VA = "0x184DAB720")]
		private JToken CreateJToken(JsonReader reader, JsonContract contract)
		{
			return null;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x4DAB380", Offset = "0x4DA9F80", VA = "0x184DAB380")]
		private JToken CreateJObject(JsonReader reader)
		{
			return null;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x4DAED10", Offset = "0x4DAD910", VA = "0x184DAED10")]
		private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue)
		{
			return null;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00004548 File Offset: 0x00002748
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x4DAA970", Offset = "0x4DA9570", VA = "0x184DAA970")]
		private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s)
		{
			return default(bool);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x4DB0450", Offset = "0x4DAF050", VA = "0x184DB0450")]
		internal string GetExpectedDescription(JsonContract contract)
		{
			return null;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x4DB03B0", Offset = "0x4DAEFB0", VA = "0x184DB03B0")]
		private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			return null;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x4DAE070", Offset = "0x4DACC70", VA = "0x184DAE070")]
		private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue)
		{
			return null;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00004560 File Offset: 0x00002760
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x4DB4370", Offset = "0x4DB2F70", VA = "0x184DB4370")]
		private bool ReadMetadataPropertiesToken(JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id)
		{
			return default(bool);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00004578 File Offset: 0x00002778
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x4DB4AC0", Offset = "0x4DB36C0", VA = "0x184DB4AC0")]
		private bool ReadMetadataProperties(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id)
		{
			return default(bool);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x4DB5C40", Offset = "0x4DB4840", VA = "0x184DB5C40")]
		private void ResolveTypeName(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName)
		{
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x4DAFE40", Offset = "0x4DAEA40", VA = "0x184DAFE40")]
		private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract)
		{
			return null;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x4DAB990", Offset = "0x4DAA590", VA = "0x184DAB990")]
		private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id)
		{
			return null;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00004590 File Offset: 0x00002790
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x4DB06A0", Offset = "0x4DAF2A0", VA = "0x184DB06A0")]
		private bool HasNoDefinedType(JsonContract contract)
		{
			return default(bool);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x4DB0020", Offset = "0x4DAEC20", VA = "0x184DB0020")]
		private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType)
		{
			return null;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x000045A8 File Offset: 0x000027A8
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x4DB6370", Offset = "0x4DB4F70", VA = "0x184DB6370")]
		private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target)
		{
			return default(bool);
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x000045C0 File Offset: 0x000027C0
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x4DAA390", Offset = "0x4DA8F90", VA = "0x184DAA390")]
		private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue)
		{
			return default(bool);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x4DAA0A0", Offset = "0x4DA8CA0", VA = "0x184DAA0A0")]
		private void AddReference(JsonReader reader, string id, object value)
		{
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x000045D8 File Offset: 0x000027D8
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x4BBDDE0", Offset = "0x4BBC9E0", VA = "0x184BBDDE0")]
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return default(bool);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x000045F0 File Offset: 0x000027F0
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x4DB6920", Offset = "0x4DB5520", VA = "0x184DB6920")]
		private bool ShouldSetPropertyValue(JsonProperty property, object value)
		{
			return default(bool);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x4DAC470", Offset = "0x4DAB070", VA = "0x184DAC470")]
		private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator)
		{
			return null;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x4DAC1C0", Offset = "0x4DAADC0", VA = "0x184DAC1C0")]
		private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator)
		{
			return null;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x4DB08F0", Offset = "0x4DAF4F0", VA = "0x184DB08F0")]
		private void OnDeserializing(JsonReader reader, JsonContract contract, object value)
		{
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x4DB0730", Offset = "0x4DAF330", VA = "0x184DB0730")]
		private void OnDeserialized(JsonReader reader, JsonContract contract, object value)
		{
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x4DB0AB0", Offset = "0x4DAF6B0", VA = "0x184DB0AB0")]
		private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id)
		{
			return null;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x4DB1FD0", Offset = "0x4DB0BD0", VA = "0x184DB1FD0")]
		private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id)
		{
			return null;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x4DB6A60", Offset = "0x4DB5660", VA = "0x184DB6A60")]
		private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message)
		{
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x4DB16C0", Offset = "0x4DB02C0", VA = "0x184DB16C0")]
		private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id)
		{
			return null;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x4DAAC10", Offset = "0x4DA9810", VA = "0x184DAAC10")]
		private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id)
		{
			return null;
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x4DAAA50", Offset = "0x4DA9650", VA = "0x184DAAA50")]
		internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member)
		{
			return null;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x4DACA60", Offset = "0x4DAB660", VA = "0x184DACA60")]
		private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<object> creator, string id)
		{
			return null;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x4DAF240", Offset = "0x4DADE40", VA = "0x184DAF240")]
		private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue)
		{
			return null;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x4DB52A0", Offset = "0x4DB3EA0", VA = "0x184DB52A0")]
		private List<JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType)
		{
			return null;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00004608 File Offset: 0x00002808
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x4DB40D0", Offset = "0x4DB2CD0", VA = "0x184DB40D0")]
		private bool ReadForType(JsonReader reader, JsonContract contract, bool hasConverter)
		{
			return default(bool);
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x4DAC7E0", Offset = "0x4DAB3E0", VA = "0x184DAC7E0")]
		public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator)
		{
			return null;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x4DB2B80", Offset = "0x4DB1780", VA = "0x184DB2B80")]
		private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id)
		{
			return null;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00004620 File Offset: 0x00002820
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x4DB6750", Offset = "0x4DB5350", VA = "0x184DB6750")]
		private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target)
		{
			return default(bool);
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00004638 File Offset: 0x00002838
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x4DAA840", Offset = "0x4DA9440", VA = "0x184DAA840")]
		private bool CheckPropertyName(JsonReader reader, string memberName)
		{
			return default(bool);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x4DB6100", Offset = "0x4DB4D00", VA = "0x184DB6100")]
		private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o)
		{
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x4DB4010", Offset = "0x4DB2C10", VA = "0x184DB4010")]
		private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x4DAF970", Offset = "0x4DAE570", VA = "0x184DAF970")]
		private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, JsonSerializerInternalReader.PropertyPresence presence, bool setDefaultValue)
		{
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x4DB6230", Offset = "0x4DB4E30", VA = "0x184DB6230")]
		private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> requiredProperties)
		{
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x4DB05F0", Offset = "0x4DAF1F0", VA = "0x184DB05F0")]
		private void HandleError(JsonReader reader, bool readPastError, int initialDepth)
		{
		}

		// Token: 0x020000A9 RID: 169
		[Token(Token = "0x20000A9")]
		internal enum PropertyPresence
		{
			// Token: 0x040002C2 RID: 706
			[Token(Token = "0x40002C2")]
			None,
			// Token: 0x040002C3 RID: 707
			[Token(Token = "0x40002C3")]
			Null,
			// Token: 0x040002C4 RID: 708
			[Token(Token = "0x40002C4")]
			Value
		}

		// Token: 0x020000AA RID: 170
		[Token(Token = "0x20000AA")]
		internal class CreatorPropertyContext
		{
			// Token: 0x06000636 RID: 1590 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CreatorPropertyContext()
			{
			}

			// Token: 0x040002C5 RID: 709
			[Token(Token = "0x40002C5")]
			[FieldOffset(Offset = "0x10")]
			public string Name;

			// Token: 0x040002C6 RID: 710
			[Token(Token = "0x40002C6")]
			[FieldOffset(Offset = "0x18")]
			public JsonProperty Property;

			// Token: 0x040002C7 RID: 711
			[Token(Token = "0x40002C7")]
			[FieldOffset(Offset = "0x20")]
			public JsonProperty ConstructorProperty;

			// Token: 0x040002C8 RID: 712
			[Token(Token = "0x40002C8")]
			[FieldOffset(Offset = "0x28")]
			public JsonSerializerInternalReader.PropertyPresence? Presence;

			// Token: 0x040002C9 RID: 713
			[Token(Token = "0x40002C9")]
			[FieldOffset(Offset = "0x30")]
			public object Value;

			// Token: 0x040002CA RID: 714
			[Token(Token = "0x40002CA")]
			[FieldOffset(Offset = "0x38")]
			public bool Used;
		}
	}
}
